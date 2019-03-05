using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using EZSocket;


namespace PongGame
{
    public partial class LobbyMultiplayer : Form
    {
        Thread threadServer; //Thread créé lors du lancement de serveur
        MessageBox messageBox; //MessageBox affiché lors du lancement du serveur en attente d'un client

        public LobbyMultiplayer()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Vérifie si le texte reçu est une adresse IP valide
        /// </summary>
        /// <param name="addrString"></param>
        /// <returns></returns>
        public bool IsAddressValid(string strAddress)
        {
            IPAddress address;
            return IPAddress.TryParse(strAddress, out address);
        }

        /// <summary>
        /// Test de la validation des champs (vides)
        /// </summary>
        /// <see cref="https://stackoverflow.com/questions/4202195/textbox-validation-in-a-windows-form"/>
        /// <returns></returns>
        private bool IsEmpty(TextBox textBox)
        {
            // Retourne vrai si le champs est vide ou rempli avec des espaces
            if (textBox.Text.Trim() == String.Empty)
            {
                return true;
            }
            return false;
        }

        private void pbxBack_Click(object sender, EventArgs e)
        {
            //Bouton de retour sur le menu
            this.Hide();
            Form1 menu = new Form1();
            menu.Show();
        }

        private void pbxExit_Click(object sender, EventArgs e)
        {
            //confirmation de fermeture de l'application
            DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir fermer l'application ?", "Fermeture", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
            {
                Environment.Exit(1);
            }
        }

        /// <summary>
        /// Fonction utilisé dans le thread de lancement du serveur
        /// </summary>
        private void StartServer()
        {
            //Création du socket
            SocketServer server = new SocketServer(tbxIPServer.Text);

            server.Wait();

            //Envoie d'un message au client
            server.Send("salut tu es connecté (serveur)");

            //Affichage du message reçu du client
            //lblIpServer.Text = server.Receive().ToString();

            server.Close();

            //Arrêt du thread
            threadServer.Abort();
        }

        private void btnServer_Click(object sender, EventArgs e)
        {
            if (!IsEmpty(tbxIPServer))
            {
                if (IsAddressValid(tbxIPServer.Text))
                {
                    threadServer = new Thread(new ThreadStart(StartServer));
                    threadServer.Start();
                }
                else
                {
                    MessageBox.Show("L'adresse IP entrée n'est pas valide");
                }
            }
            else
            {
                MessageBox.Show("Le champ Adresse IP du serveur est vide.");
            }

        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            if (!IsEmpty(tbxIpClient))
            {
                if (IsAddressValid(tbxIpClient.Text))
                {
                    try
                    {
                        //Création du socket
                        SocketClient client = new SocketClient(tbxIpClient.Text);

                        client.Connect();

                        //Affichage du message reçu du serveur
                        lblIpClient.Text = client.Receive().ToString();

                        //Envoie d'un message au serveur
                        client.Send("Salut je suis connecté (client)");

                        client.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Impossible de contacter le serveur");
                    }
                }
                else
                {
                    MessageBox.Show("L'adresse IP entrée n'est pas valide");
                }
            }
            else
            {
                MessageBox.Show("Le champ Adresse IP du client est vide.");
            }
        }
    }
}
