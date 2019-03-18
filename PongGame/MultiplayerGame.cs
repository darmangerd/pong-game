using EZSocket;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PongGame
{
    public partial class MultiplayerGame : Form
    {
        #region Déclaration des constantes

        const int TOP_BOX = 0; //Position de la limite du haut du terrain
        const int BOTTOM_BOX = 472; //Position de la limite du bas du terrain
        const int LEFT_BOX = 0; //Position de la limite gauche du terrain
        const int RIGHT_BOX = 826; //Position de la limite droite du terrain
        //const int MIDDLE_X_BOX = 531; //Position moitié horizontal du terrain
        //const int MIDDLE_Y_BOX = 260; //Position moitié vertical du terrain
        const int POINTS = 3; //Nombre de points par set

        #endregion

        #region Déclaration des variables

        string strAddressIP; //Adresse IPs des joueurs | [0] -> Server / [1] -> Client
        string strMessageServer;
        bool bEstClient; //Interface Client ou Serveur
        bool bStopServer=false; //Utilisé pour stopper le serveur
        bool bStopClient=false; //Utilisé pour stopper le client
        bool bBallPass=false;
        Player[] tblPlayers = new Player[2] { new Player(), new Player() }; //Tableau de joueurs
        Ball ball = new Ball(5, 5); //Vitesse de la balle
        Thread threadServer;
        Thread threadClient;
        //Thread threadServer; //Thread créé lors du lancement de serveur

        #endregion

        public MultiplayerGame(bool bClient, string adresseIPServeur)
        {
            InitializeComponent();
            bEstClient = bClient;
            strAddressIP = adresseIPServeur;
            Rectangle r = Screen.PrimaryScreen.WorkingArea;
            if (bEstClient)
            {
                this.StartPosition = FormStartPosition.Manual;
                this.Location = new Point(0,
                    (Screen.PrimaryScreen.WorkingArea.Height/2) - (this.Height/2));
                pbxPlayer1.Left = this.ClientSize.Width - 30;
                pbxBalle.Left = -10;
                lblWho.Text = "Je suis client";
                threadClient = new Thread(new ThreadStart(StartClient));
                threadClient.IsBackground = true; //Pour que lorsqu'on ferme l'application le thread ne continue pas de tourner
                threadClient.Start();
            }
            else
            {
                this.StartPosition = FormStartPosition.Manual;
                this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width,
                    (Screen.PrimaryScreen.WorkingArea.Height / 2) - (this.Height / 2));
                lblWho.Text = "Je suis serveur :" + strAddressIP ;
                threadServer = new Thread(new ThreadStart(StartServer));
                threadServer.IsBackground = true; //Pour que lorsqu'on ferme l'application le thread ne continue pas de tourner
                threadServer.Start();
            }            
        }

        /// <summary>
        /// Fonction utilisé dans le thread de lancement du serveur
        /// </summary>
        private void StartServer()
        {
            //Création du socket
            SocketServer server = new SocketServer(strAddressIP);

            //En attente de la connexion du client
            server.WaitInGame();

            //Contiendra la position de la balle en hauteur (TOP)
            int iPos =0;

            //Tant qu'on n'arrête pas le jeux
            while (!bStopServer)
            {
                //Si la balle dépasse de l'écran du serveur
                if (pbxBalle.Left > this.ClientSize.Width)
                {
                    //Envoie d'un message contenant la position en hauteur de la balle du client
                    server.Send(pbxBalle.Top.ToString());

                    /*ball.x = 5;
                   
                    pbxBalle.Invoke(new Action(() =>
                    {
                        pbxBalle.Left = -15;
                    }));*/

                    //On récupère la position en hauteur de l
                    iPos = Convert.ToInt32(server.Receive());

                    ball.x = 5; //Vitesse par défaut de la balle

                    //Repositionnement de la balle (pour avoir l'effet du passage entre les écrans)
                    pbxBalle.Invoke(new Action(() =>
                    {
                        pbxBalle.Top = iPos;
                        pbxBalle.Left = this.ClientSize.Width-3;
                    }));                    
                }
            }

            //server.Send("Je te passe la ball");

            /*while (!bStopServer)
            {
                if (pbxBalle.Left >= RIGHT_BOX)
                {
                    //Envoie d'un message au client
                    server.Send("Connexion réussi (Serveur) !");
                }
                else
                {
                    //Affichage du message reçu du serveur
                    //lblWho.Text = server.Receive().ToString();
                }
            }*/

            //Fermeture de la connexion
            server.Close();

            //Arrêt du thread
            threadServer.Abort();

        }

        private void StartClient()
        {
            //Création du socket
            SocketClient client = new SocketClient(strAddressIP);

            //Connexion au serveur
            client.ConnectInGame();

            //Contiendra la position de la balle en hauteur (TOP)
            int iPos;

            //Récupère le message du serveur qui est la position de la balle chez le serveur
            iPos = Convert.ToInt32(client.Receive());

            //Déplacement par défaut de la balle
            ball.x = -5;

            //Repositionnement de la balle (pour avoir l'effet du passage entre les écrans)
            pbxBalle.Invoke(new Action(() =>
            {
                pbxBalle.Top = iPos;
                pbxBalle.Left = 3;
            }));

            //Tant qu'on arrête pas le jeux
            while (!bStopClient)
            {
                //Si la balle dépasse l'écran du client
                if (pbxBalle.Left < -10)
                {
                    //Envoie d'un message contenant la position en hauteur de la balle du client
                    client.Send(pbxBalle.Top.ToString());

                    #region Position de la balle pas que le client la voit quand elle n'est pas censé être sur son écran

                    ball.x = -5;

                    pbxBalle.Invoke(new Action(() =>
                    {
                        pbxBalle.Left = 630;
                    }));

                    #endregion

                    /*if (Convert.ToInt32(client.Receive())!=iPos)
                    {*/

                    //Récupère le message du serveur qui est la position de la balle chez le serveur
                    iPos = Convert.ToInt32(client.Receive());

                    //Déplacement par défaut de la balle
                    ball.x = -5;

                    //Repositionnement de la balle (pour avoir l'effet du passage entre les écrans)
                    pbxBalle.Invoke(new Action(() =>
                    {
                        pbxBalle.Top = iPos;
                        pbxBalle.Left = 3;
                    }));
                    //}

                }
            }
            //Fermeture de la connexion
            client.Close();

            //Arrêt du thread
            threadClient.Abort();
        }

        #region Touches de déplacement

        /// <summary>
        /// Lorsque l'utilisateur appuie ou relâche une touche de déplacement du clavier
        /// </summary>
        /// <param name="movePlayers">//Detection de la posibilité de déplacement vers le haut/bas des joueurs</param>
        /// <param name="bKeyDown">Touche appuyé = true ou relaché = false</param>
        private void KeyMove(Player[] tblPlayers, bool bKeyDown, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                //Déplacement du joueur 1
                case Keys.W:
                    tblPlayers[0].MoveUp = bKeyDown;
                    break;

                case Keys.S:
                    tblPlayers[0].MoveDown = bKeyDown;
                    break;

                //Déplacement du joueur 2
                case Keys.Up:
                    tblPlayers[1].MoveUp = bKeyDown;
                    break;

                case Keys.Down:
                    tblPlayers[1].MoveDown = bKeyDown;
                    break;
            }
        }

        /// <summary>
        /// Lorsque l'utilisateur appuie sur une touche de déplacement du clavier
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MultiplayerGame_KeyDown(object sender, KeyEventArgs e)
        {
            KeyMove(tblPlayers, true, e);
        }

        /// <summary>
        /// Lorsque l'utilisateur relâche une touche de déplacement du clavier
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MultiplayerGame_KeyUp(object sender, KeyEventArgs e)
        {
            KeyMove(tblPlayers, false, e);
        }

        #endregion

        #region Timer Tick

        private void tmrGameTimer_Tick(object sender, EventArgs e)
        {
            #region Passage de données

            if (bEstClient)
            {
                if (pbxBalle.Left <= 0)
                {
                    bBallPass = true;
                }
                else
                {
                    bBallPass = false;
                }
            }
            else
            {
                if (pbxBalle.Left >= RIGHT_BOX)
                {
                    bBallPass = true;
                }
                else
                {
                    bBallPass = false;
                }

            }

            #endregion

            //Déplacement Horizontal et vertical de la balle. 
            // -= augmente la vitesse de la balle vers la gauche et le haut de l'écran
            // += augmente la vitesse de la balle vers la droite et le bas de l'écran
            pbxBalle.Top -= ball.y; //axe Y
            pbxBalle.Left -= ball.x; //axe X

            //AJOUT - Marquage de la balle

            #region Rebonds et Collision de la balle

            //Si la balle atteint le haut de l'écran ou le bas
            if (pbxBalle.Top < TOP_BOX || pbxBalle.Top + pbxBalle.Height > this.ClientSize.Height)
            {
                //On change la direction de la balle
                ball.y = -ball.y;
            }

            //OPTIMISATION - FAIRE UNE FONCTION
            //Si la balle touche un des joueurs
            //if (pbxBalle.Bounds.IntersectsWith(pbxPlayer1.Bounds) || pbxBalle.Bounds.IntersectsWith(pbxPlayer2.Bounds))
            if (pbxBalle.Bounds.IntersectsWith(pbxPlayer1.Bounds))
            {
                if(bEstClient)
                {
                    //Problème de collision
                    pbxBalle.Left -= 4;
                    //On change la direction de la balle
                    ball.x = 5;
                    /*Augmente la vitesse de la balle
                    ball.x -= 1; */
                }
                else
                {
                    //Problème de collision
                    pbxBalle.Left += 4;
                    //On change la direction de la balle
                    ball.x = -5;
                    /*Augmente la vitesse de la balle
                   ball.x += 1;*/
                }

            }
            /*else if (pbxBalle.Bounds.IntersectsWith(pbxPlayer2.Bounds))
            {
                //Problème de collision
                pbxBalle.Left -= 4;
                //On change la direction de la balle
                ball.x = -ball.x;
                /*Augmente la vitesse de la balle
               ball.x += 1;*/
            //} 

            #endregion

            #region Déplacement du joueur 1
            //OPTIMISATION - FAIRE UNE FONCTION
            //Si le déplacement vers le haut est autorisé et que le joueur se trouve avant la limite supérieure
            if (tblPlayers[0].MoveUp == true && pbxPlayer1.Top > TOP_BOX)
            {
                //Déplacement vers le haut
                pbxPlayer1.Top -= 8;
            }
            //Si le déplacement vers le bas est autorisé et que le joueur se trouve avant la limite inférieure
            if (tblPlayers[0].MoveDown == true && pbxPlayer1.Top < BOTTOM_BOX-123)
            {
                //Déplacement vers le bas
                pbxPlayer1.Top += 8;
            }

            #endregion

            //AJOUT - Déplacement joueur 2 + le reste


        }

        #endregion
    }
}
