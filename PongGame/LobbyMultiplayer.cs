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
        Player PlayerClient = new Player(); //Joueur client
        Player[] tblPlayers = new Player[2] { new Player(), new Player() }; //Tableau de joueurs

        public LobbyMultiplayer()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Vérifie si le texte reçu est une adresse IP valide
        /// </summary>
        /// <param name="addrString">Adresse IP entré</param>
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
        private void StartGame(bool client, string ipServer, string name)
        {
            MultiplayerGame multiplayer = new MultiplayerGame(client, ipServer, name);
            multiplayer.Show();

            //Clean
            this.Close();
            this.Dispose();
        }

        /// <summary>
        /// Lancement de la partie en ajoutant les utilisateur à la base de données
        /// </summary>
        /// <param name="client">Permet de définir si le joueur est le client ou le serveur</param>
        private void StartGame(bool client, string ipServer, Player[] players)
        {
            #region Base de données

            //Récupération des noms/prénoms des utilisateurs
            string[] tblNom = new string[2] { players[0].Name, players[1].Name };
            string[] tblPrenom = new string[2] { players[0].Surname, players[1].Surname };
            string[] tblId = new string[2];

            //Classe permettant d'ajouter des données des utilisateurs dans la base Access
            UserInDB userInDB = new UserInDB();
            //Ajout des utilisateurs s'ils n'existe pas dans la base de données
            userInDB.AddUserInDB(tblNom, tblPrenom);
            //Récupération des IDs des joueurs dans la base de données
            tblId = userInDB.GetIdFromPlayer(tblNom, tblPrenom);
            
            #endregion

            MultiplayerGame multiplayer = new MultiplayerGame(client, ipServer, tblNom, tblId);
            multiplayer.Show();

            //Clean
            this.Close();
            this.Dispose();
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

            //Contiendra le message brut du client
            string strReponse;

            //Envoie d'un message au client
            //server.Send("Connexion réussi !");

            //Récupération du message du client contenant son nom et prénom
            strReponse = server.Receive().ToString();
            //Séparation en tableau du nom et prénom. Car le message est envoyé comme ceci: "nom,prenom"
            string[] tblReponses = strReponse.Split(',');

            tblPlayers[1].Name = tblReponses[0];
            tblPlayers[1].Surname = tblReponses[1];

            server.Close();

            /*while(!server.Closed)
            {
                server.Send("Fin");
                server.Close();
            }*/

            //Arrêt du thread
            threadServer.Abort();            
        }
        
        private void btnServer_Click(object sender, EventArgs e)
        {
            //Vérifie si la les champs ne sont pas vide ET que l'adresse IP donnée est valide
            if (!IsEmpty(tbxIPServer) && !IsEmpty(tbxNamePlayer) && !IsEmpty(tbxSurnamePlayer) && IsAddressValid(tbxIPServer.Text))
            {
                //Récupération du nom et prénom du client
                tblPlayers[0].Name = tbxNamePlayer.Text;
                tblPlayers[0].Surname = tbxSurnamePlayer.Text;
                //Changement entre les boutons
                btnServer.Visible = false;
                btnCancelServer.Visible = true;
                //Lancement du thread
                threadServer = new Thread(new ThreadStart(StartServer));
                threadServer.IsBackground = true; //Pour que lorsqu'on ferme l'application le thread ne continue pas de tourner
                threadServer.Start();
                tmrCheck.Start();
            }
            else
            {
                MessageBox.Show("Les champs ne sont pas remplis correctement");
            }

        }

        /// <summary>
        /// Utilisé pour vérification de l'arrêt d'un thread
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmrCheck_Tick(object sender, EventArgs e)
        {
            if (!threadServer.IsAlive)
            {
                tmrCheck.Stop();
                tmrCheck.Dispose();
                StartGame(false,tbxIPServer.Text, tblPlayers);
            }
        }

        #endregion

        #region Processus de lancement pour le client

        private void btnClient_Click(object sender, EventArgs e)
        {
            //Vérifie si la le champs n'est pas vide ET que l'adresse IP donnée est valide
            if (!IsEmpty(tbxIpClient) && !IsEmpty(tbxNamePlayer) && !IsEmpty(tbxSurnamePlayer) && IsAddressValid(tbxIpClient.Text))
            {
                PlayerClient.Name = tbxNamePlayer.Text;
                PlayerClient.Surname = tbxSurnamePlayer.Text;
                try
                {
                    //Création du socket
                    SocketClient client = new SocketClient(tbxIpClient.Text);

                    client.Connect();

                    //Affichage du message reçu du serveur
                    //lblIpClient.Text = client.Receive().ToString();

                    //Envoie d'un message au serveur
                    client.Send(PlayerClient.Name + ',' + PlayerClient.Surname);

                    client.Close();

                    StartGame(true, tbxIpClient.Text, PlayerClient.Name);

                    /*if (client.Receive()=="false")
                    {

                    }*/
                    
                    //while(client.Receive().ToString() == "Fin")
                    //{
                        //Commencement d'une partie en ligne
                    
                    //}

                    
                }
                catch 
                {
                    MessageBox.Show("Impossible de contacter le serveur");
                }
            }
            else
            {
                MessageBox.Show("Les champs ne sont pas remplis correctement");
            }
        }

        #endregion

        private void btnCancelServer_Click(object sender, EventArgs e)
        {
            btnCancelServer.Visible = false;
            btnServer.Visible=true;
        }
    }
}
