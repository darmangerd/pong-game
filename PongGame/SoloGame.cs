using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PongGame
{
    public partial class SoloGame : Form
    {
        //Taille (position) du terrain de jeux
        const int TOP_BOX = 38; //Position de la limite du haut du terrain
        const int BOTTOM_BOX = 576; //Position de la limite du bas du terrain
        const int LEFT_BOX = 170; //Position de la limite gauche du terrain
        const int RIGHT_BOX = 892; //Position de la limite droite du terrain
        const int MIDDLE_X_BOX = 531; //Position moitié horizontal du terrain
        const int MIDDLE_Y_BOX = 260; //Position moitié vertical du terrain
        const int POINTS = 3; //Nombre de points par set

        bool bTwoPlayer; //Si la partie est en mode 2 joueur
        bool bGoUpPlayer1; //Detection du déplacement vers le haut du joueur 1
        bool bGoDownPlayer1; //Detection du déplacement vers le bas du joueur 1
        bool bGoUpPlayer2; //Detection du déplacement vers le haut du joueur 2
        bool bGoDownPlayer2; //Detection du déplacement vers le bas du joueur 2
        bool bRestartGame = false; //Utilisé pour vérifier si on recommence une partie
        int iPoints = POINTS; //Nombre de points par set
        int iSpeed = 9; //Déplacement de l'IA
        int iBallx = 5; //Vitesse de déplacement de la balle en vertical x
        int iBally = 5; //Vitesse de déplacement de la balle en horizontal y
        int iStartCount = 3; //Compteur de comencement de la partie
        int iScorePlayer1 = 0; //Score du joueur 1
        int iScorePlayer2 = 0; //Score du joueur 2 ou de l'IA
        int iSetPlayer1 = 0; //Set gagné par le joueur 1
        int iSetPlayer2 = 0; //Set gagné par le joueur 2 ou l'IA
        int iSet = 0; //Set actuel
        int[] tblIDPlayers = new int[2];
        string strPlayer1Name = ""; //Nom du joueur 1
        string strPlayer2Name = ""; //Nom du joueur 2
        int[,] tblSet = new int[5, 2]; //Table qui contient le score des joueurs par set
        Random random = new Random(); //Variable pour déplacement aléatoire de L'IA


        public SoloGame(string strPlayer1_name, string strPlayer2_name, string[] tblID, bool bTwoPlayers)
        {
            InitializeComponent();
            strPlayer1Name = strPlayer1_name; //Nom du joueur 1 entré dans le lobby
            strPlayer2Name = strPlayer2_name; //Nom du joueur 2 entré dans le lobby ou de l'IA
            bTwoPlayer = bTwoPlayers; //2 Joueur ou 1 joueur contre 1 IA
            lblNamePlayer1.Text = strPlayer1Name; //Affichage du nom du joueur 1 sur l'écran
            lblNamePlayer2.Text = strPlayer2Name; //Affichage du nom du joueur 2 sur l'écran

            //Récupération des IDs des joueurs provenant de la base de données
            for (int i=0; i <= 1; i++)
            {
                tblIDPlayers[i] = Convert.ToInt32(tblID[i]);
            }

            //Ajout de la partie dans la base de donnée
            AddGamesInBDD(tblIDPlayers);
        }

        private void AddGamesInBDD(int[] tblID)
        {
            //Connexion à la base de données
            OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0;Data Source=\\s2lfile3.s2.rpn.ch\CPLNpublic\Classes\ET\INF-HP\4INF-HP-M\module ict-153\dbScores.accdb");
            OleDbCommand cmd = con.CreateCommand();
            con.Open();
            //Requête SQL envoyé au serveur
            cmd.CommandText = "INSERT into tblGames ( num_tblUsers1, num_tblUsers2, dateDebut, heureDebut ) VALUES ('" + Convert.ToInt32(tblID[0]) + "','" + Convert.ToInt32(tblID[1]) + "', '" + DateTime.Today.Day + "." + DateTime.Today.Month + "." + DateTime.Today.Year + "', '" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + "')";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }


        /// <summary>
        /// Affiche les différents scores des joueurs sur l'écran
        /// </summary>
        private void SetScoreOnScreen()
        {
            lblPlayer1Score.Text = "" + iScorePlayer1; //Score du joueur 1
            lblPlayer2Score.Text = "" + iScorePlayer2; //Score du joueur 2
            lblSetPlayer1.Text = "" + iSetPlayer1; //Set gagné par le joueur 1
            lblSetPlayer2.Text = "" + iSetPlayer2; //Set gagné par le joueur 2
        }

        /// <summary>
        /// Ajoute le score des joueurs par set
        /// </summary>
        private void AddPointsBySet()
        {
            tblSet[iSet, 0] = iScorePlayer1; //Ajout du score du joueur 1 dans le tableau
            tblSet[iSet, 1] = iScorePlayer1; //Ajout du score du joueur 2 ou IA dans le tableau
            iSet++; //Nombre de set de la partie
        }

        /// <summary>
        /// Message qui s'affiche à la fin d'une partie
        /// </summary>
        /// <param name="playerName"></param>
        private void ShowMessageEndGame(string playerName)
        {
            tmrGameTimer.Stop();

            DialogResult result = MessageBox.Show(playerName.ToUpper() + " a gagné ! Voulez-vous recommencer ?", "Victoire", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Information);

            if (result == DialogResult.Abort)
            {
                //Bouton de retour sur le menu
                this.Hide();
                Form1 menu = new Form1();
                menu.Show();
            }
            else if (result == DialogResult.Retry)
            {
                bRestartGame = true;
                RestartGame();
            }
        }

        /// <summary>
        /// Remise à zéro des valeurs
        /// </summary>
        private void RestartGame()
        {
            iPoints = POINTS;
            iScorePlayer1 = 0; //Remise du score du joueur 1 à zéro
            iScorePlayer2 = 0; //Remise du score du joueur 2 ou IA à zéro
            iBallx = 5; //Vitesse par défaut de la balle
            iStartCount = 3; //Décompte avant le début de la partie
            lblStarTimer.Visible = true; //Label du compteur visible
            lblStarTimer.Text = iStartCount.ToString(); //Affichage du nombre du décompte
            tmrGameTimer.Stop();
            pbxBalle.Left = MIDDLE_X_BOX; //Reposition de la balle au millieu du terrain (Axe X)
            pbxBalle.Top = MIDDLE_Y_BOX; //Reposition de la balle au millieu du terrain (Axe Y)
            pbxPlayer1.Top = MIDDLE_Y_BOX; //Reposition du joueur 1 au milieu du terrain
            pbxPlayer2.Top = MIDDLE_Y_BOX; //Reposition du joueur 2 ou IA au milieu du terrain
            SetScoreOnScreen(); //Affichage des scores
            tmrStart.Start();
        }

        #region Touches de déplacement du joueur 1

        /// <summary>
        /// Lorsque l'utilisateur appuie la touche UP/DOWN du clavier
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SoloGame_KeyDown(object sender, KeyEventArgs e)
        {
            //Déplacement du joueur 1
            if (e.KeyCode == Keys.W)
            {
                bGoUpPlayer1 = true;
            }
            else if (e.KeyCode == Keys.S)
            {
                bGoDownPlayer1 = true;
            }

            //Déplacement du joueur 2
            if (e.KeyCode == Keys.Up)
            {
                //UP
                bGoUpPlayer2 = true;
            }
            else if (e.KeyCode == Keys.Down)
            {
                //DOWN
                bGoDownPlayer2 = true;
            }
        }

        /// <summary>
        /// Lorsque l'utilisateur relâche la touche UP/DOWN du clavier
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SoloGame_KeyUp(object sender, KeyEventArgs e)
        {
            //Déplacement du joueur 1
            if (e.KeyCode == Keys.W)
            {
                bGoUpPlayer1 = false;
            }
            else if (e.KeyCode == Keys.S)
            {
                bGoDownPlayer1 = false;
            }

            //Déplacement du joueur 2
            if (e.KeyCode == Keys.Up)
            {
                bGoUpPlayer2 = false;
            }
            else if (e.KeyCode == Keys.Down)
            {
                bGoDownPlayer2 = false;
            }
        }

        #endregion

        /// <summary>
        /// Tick du timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmrGameTimer_Tick(object sender, EventArgs e)
        {
            //Affichage des scores des joueurs
            SetScoreOnScreen();

            //Déplacement Horizontal et vertical de la balle. 
            // -= augmente la vitesse de la balle vers la gauche et le haut de l'écran
            // += augmente la vitesse de la balle vers la droite et le bas de l'écran
            pbxBalle.Top -= iBally; //Position Y
            pbxBalle.Left -= iBallx; //Position X

            #region IA

            if (!bTwoPlayer)
            {
                //Vitesse/Direction du CPU (Commence par descendre)
                pbxPlayer2.Top += iSpeed;

                //Si le CPU atteint le top ou le bas de l'écran
                if (pbxPlayer2.Top < TOP_BOX || pbxPlayer2.Top > (BOTTOM_BOX - 135))
                {
                    //On change sa direction
                    iSpeed = -iSpeed;
                }

                //VERSION AVEC IA - PAS FONCTIONNEL POUR L'INSTANT
                /*if (iScorePlayer1 < 5)
                {
                    //Si le CPU atteint le top ou le bas de l'écran
                    if (pbxPlayer2.Top < 0 || pbxPlayer2.Top > 480)
                    {
                        //On change sa direction
                        iSpeed = -iSpeed;
                    }
                }
                else
                {
                    //Amélioration de l'IA
                    pbxPlayer2.Top = pbxBalle.Top + 20;
                }*/
            }

            #endregion


            #region Marquage de la balle

            // Si la balle est marqué à gauche
            if (pbxBalle.Left < LEFT_BOX)
            {
                //Reposition de la balle au milieu de l'écran
                pbxBalle.Left = MIDDLE_X_BOX;
                //TODO - Reposition Y
                //Change la balle de direction
                iBallx = -iBallx;
                //+1 au score du joueur 2 (droite)
                iScorePlayer2++;
                //On baisse la vitesse de la balle
                iBallx = -8;
            }
            //Si la balle est marqué à droite
            else if (pbxBalle.Left + pbxBalle.Width > RIGHT_BOX)
            {
                //Reposition de la balle au milieu de l'écran
                pbxBalle.Left = MIDDLE_X_BOX;
                //Change la balle de direction
                iBallx = -iBallx;
                //+1 au score du joueur 2 (droite)
                iScorePlayer1++;
                //On baisse la vitesse de la balle
                iBallx = +8;
            }

            #endregion

            #region Rebonds et Collision de la balle

            //Si la balle atteint le haut de l'écran ou le bas
            if (pbxBalle.Top < TOP_BOX || pbxBalle.Top + pbxBalle.Height > BOTTOM_BOX)
            {
                //On change la direction de la balle
                iBally = -iBally;
            }

            //Si la balle touche un des joueurs
            //if (pbxBalle.Bounds.IntersectsWith(pbxPlayer1.Bounds) || pbxBalle.Bounds.IntersectsWith(pbxPlayer2.Bounds))
            if (pbxBalle.Bounds.IntersectsWith(pbxPlayer1.Bounds))
            {
                //Problème de collision
                pbxBalle.Left += 4;
                //On change la direction de la balle
                iBallx = -iBallx;
                //Augmente la vitesse de la balle
                iBallx -= 1;
            }
            else if (pbxBalle.Bounds.IntersectsWith(pbxPlayer2.Bounds))
            {
                //Problème de collision
                pbxBalle.Left -= 4;
                //On change la direction de la balle
                iBallx = -iBallx;
                //Augmente la vitesse de la balle
                iBallx += 2;
            }

            #endregion

            #region Déplacement du joueur 1

            //Si le déplacement vers le haut est autorisé et que le joueur se trouve avant la limite supérieure
            if (bGoUpPlayer1 == true && pbxPlayer1.Top > TOP_BOX)
            {
                //Déplacement vers le haut
                pbxPlayer1.Top -= 8;
            }
            //Si le déplacement vers le bas est autorisé et que le joueur se trouve avant la limite inférieure
            if (bGoDownPlayer1 == true && pbxPlayer1.Top < 452)
            {
                //Déplacement vers le bas
                pbxPlayer1.Top += 8;
            }

            #endregion

            #region Déplacement du joueur 2

            if (bTwoPlayer)
            {
                //Si le déplacement vers le haut est autorisé et que le joueur se trouve avant la limite supérieure
                if (bGoUpPlayer2 == true && pbxPlayer2.Top > TOP_BOX)
                {
                    //Déplacement vers le haut
                    pbxPlayer2.Top -= 8;
                }
                //Si le déplacement vers le bas est autorisé et que le joueur se trouve avant la limite inférieure
                if (bGoDownPlayer2 == true && pbxPlayer2.Top < 452)
                {
                    //Déplacement vers le bas
                    pbxPlayer2.Top += 8;
                }
            }

            #endregion

            #region Fin de la partie

            //2 Points de différence
            if (iScorePlayer1 == iPoints && iScorePlayer2 >= iPoints-2)
            {
                iPoints++;
            }
            else if (iScorePlayer2 == iPoints && iScorePlayer1 >= iPoints - 2)
            {
                iPoints++;
            }

            //OPTIMISATION - Faire une fonction
            //Si le joueur 1 atteint le nombre de points pour gagner
            if (iScorePlayer1 >= iPoints)
            {
                iSetPlayer1++;
                SetScoreOnScreen();
                tmrGameTimer.Stop();

                //Score par set
                AddPointsBySet();

                if (iSetPlayer1 >= 3)
                {
                    iSet = 0;
                    iSetPlayer1 = 0;
                    iSetPlayer2 = 0;
                    tblSet = new int[5,2]; //OPTIMISATION - Clear le tableau
                    //Message de fin de partie
                    ShowMessageEndGame(strPlayer1Name);
                }
                else
                {
                    RestartGame();
                }
                //TODO - Ajout de la victoire du joueur à la base de donnée
            }
            //Si le joueur 2 atteint le nombre de points pour gagner
            else if (iScorePlayer2 >= iPoints)
            {
                iSetPlayer2++;
                SetScoreOnScreen();
                tmrGameTimer.Stop();

                //Score par set
                AddPointsBySet();

                if (iSetPlayer2 >= 3)
                {
                    iSet = 0;
                    iSetPlayer1 = 0;
                    iSetPlayer2 = 0;
                    tblSet = new int[5, 2]; //OPTIMISATION - Clear le tableau
                    //Message de fin de partie
                    ShowMessageEndGame(strPlayer2Name);
                }
                else
                {
                    RestartGame();
                }
                //TODO - Ajout de la victoire du joueur à la base de donnée
            }

            #endregion
        }

        /// <summary>
        /// Bouton de fermeture de l'application
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

        /// <summary>
        /// Compteur de début de jeu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmrStart_Tick(object sender, EventArgs e)
        {
            if (iStartCount == 0)
            {
                tmrGameTimer.Start();
                tmrStart.Stop();
                lblStarTimer.Visible = false;
                
                //Si la partie a été relancée
                if (bRestartGame)
                {
                    bRestartGame = false;
                    //Ajout de la partie dans la base de donnée
                    AddGamesInBDD(tblIDPlayers);
                }
            }
            else
            {
                iStartCount--;
                lblStarTimer.Text = iStartCount.ToString();
            }
        }
    }
}
