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
        /// Lancement de la partie.
        /// </summary>
        /// <param name="client">Permet de définir si le joueur est le client ou le serveur</param>
        private void StartGame(bool client)
        {
            MultiplayerGame multiplayer = new MultiplayerGame(client);
            multiplayer.Show();

            //Commencement d'une partie en ligne
            this.Close();
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

        /// <summary>
        /// Retour sur le menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbxBack_Click(object sender, EventArgs e)
        {
            //Bouton de retour sur le menu
            this.Hide();
            Form1 menu = new Form1();
            menu.Show();
        }

        /// <summary>
        /// Fermeture de l'application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbxExit_Click(object sender, EventArgs e)
        {
            //confirmation de fermeture de l'application
            DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir fermer l'application ?", "Fermeture", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
            {
                Environment.Exit(1);
            }
        }

        #region Processus de lancement pour le server

        /// <summary>
        /// Fonction utilisé dans le thread de lancement du serveur
        /// </summary>
        private void StartServer()
        {
            //Création du socket
            SocketServer server = new SocketServer(tbxIPServer.Text);

            server.Wait();

            //Envoie d'un message au client
            server.Send("Connexion réussi !");

            server.Close();

            //Arrêt du thread
            threadServer.Abort();
        }
        
        private void btnServer_Click(object sender, EventArgs e)
        {
            //Vérifie si la le champs n'est pas vide ET que l'adresse IP donnée est valide
            if (!IsEmpty(tbxIPServer) && IsAddressValid(tbxIPServer.Text))
            {
                threadServer = new Thread(new ThreadStart(StartServer));                    
                threadServer.Start();
                tmrCheck.Start();
            }
            else
            {
                MessageBox.Show("Le champ Adresse IP du serveur est vide ou n'est pas valide");
            }

        }

        private void tmrCheck_Tick(object sender, EventArgs e)
        {
            if (!threadServer.IsAlive)
            {
                StartGame(false);
                tmrCheck.Stop();
                tmrCheck.Dispose();
            }
        }

        #endregion

        #region Processus de lancement pour le client

        private void btnClient_Click(object sender, EventArgs e)
        {
            //Vérifie si la le champs n'est pas vide ET que l'adresse IP donnée est valide
            if (!IsEmpty(tbxIpClient) && IsAddressValid(tbxIpClient.Text))
            {
                try
                {
                    //Création du socket
                    SocketClient client = new SocketClient(tbxIpClient.Text);

                    client.Connect();

                    //Affichage du message reçu du serveur
                    lblIpClient.Text = client.Receive().ToString();

                    //Envoie d'un message au serveur
                    client.Send("Connexion réussi !");

                    client.Close();

                    //Commencement d'une partie en ligne
                    StartGame(true);
                }
                catch
                {
                    MessageBox.Show("Impossible de contacter le serveur");
                }
            }
            else
            {
                MessageBox.Show("Le champ Adresse IP du client est vide ou n'est pas valide");
            }
        }

        #endregion
    }
}
