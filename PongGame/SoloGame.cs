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
        #region Déclaration des constantes

        const int TOP_BOX = 38; //Position de la limite du haut du terrain
        const int BOTTOM_BOX = 576; //Position de la limite du bas du terrain
        const int LEFT_BOX = 170; //Position de la limite gauche du terrain
        const int RIGHT_BOX = 892; //Position de la limite droite du terrain
        const int MIDDLE_X_BOX = 531; //Position moitié horizontal du terrain
        const int MIDDLE_Y_BOX = 260; //Position moitié vertical du terrain
        const int POINTS = 3; //Nombre de points par set

        #endregion

        #region Déclaration des variables

        bool bTwoPlayer; //Si la partie est en mode 2 joueur (utilisateur contre utilisateur)
        bool bRestartGame = false; //Utilisé pour vérifier si on recommence une partie
        int iPoints = POINTS; //Nombre de points par set
        int iSpeed = 9; //Déplacement de l'IA
        int iStartCount = 3; //Compteur de comencement de la partie
        int iSet = 1; //Set actuel
        int iIdGame; //ID de la partie dans la base de donnée
        string strQuerySelectId = "Select @@Identity"; //Permettra de récupérer l'ID d'une partie lors de l'ajout dans la BDD
        Ball ball = new Ball(5, 5); //Vitesse de la balle
        Random random = new Random(); //Variable pour déplacement aléatoire de L'IA
        Player[] tblPlayers = new Player[2] {new Player(), new Player() }; //Tableau de joueurs

        #endregion


        public SoloGame(string strPlayer1_name, string strPlayer2_name, string[] tblID, bool bTwoPlayers)
        {
            InitializeComponent();
            tblPlayers[0].Name = strPlayer1_name; //Nom du joueur 1 entré dans le lobby
            tblPlayers[1].Name = strPlayer2_name; //Nom du joueur 2 entré dans le lobby ou de l'IA
            bTwoPlayer = bTwoPlayers; //2 Joueur ou 1 joueur contre 1 IA
            lblNamePlayer1.Text = tblPlayers[0].Name; //Affichage du nom du joueur 1 sur l'écran
            lblNamePlayer2.Text = tblPlayers[1].Name; //Affichage du nom du joueur 2 sur l'écran

            //Récupération des IDs des joueurs provenant de la base de données
            for (int i=0; i <= 1; i++)
            {
                tblPlayers[i].Id = Convert.ToInt32(tblID[i]);
            }

            //Ajout de la partie dans la base de donnée
            AddGamesInBDD(tblPlayers[0].Id, tblPlayers[1].Id);
        }

        private void AddGamesInBDD(int IDJoueur1, int IDJoueur2)
        {
            //Connexion à la base de données
            OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0;Data Source=\\s2lfile3.s2.rpn.ch\CPLNpublic\Classes\ET\INF-HP\4INF-HP-M\module ict-153\dbScores.accdb");
            OleDbCommand cmd = con.CreateCommand();
            con.Open();
            //Requête SQL envoyé au serveur
            cmd.CommandText = "INSERT into tblGames ( num_tblUsers1, num_tblUsers2, dateDebut, heureDebut ) VALUES ('" + IDJoueur1 + "','" + IDJoueur2 + "', '" + DateTime.Today.Day + "." + DateTime.Today.Month + "." + DateTime.Today.Year + "', '" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + "')";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            //Récupération de l'ID de la partie qui vient d'être ajouté dans la BDD. Source de la solution : https://stackoverflow.com/questions/7230200/how-to-get-the-last-record-number-after-inserting-record-to-database-in-access
            cmd.CommandText = strQuerySelectId;
            iIdGame = (int)cmd.ExecuteScalar();
            con.Close();
        }


        /// <summary>
        /// Affiche les différents scores des joueurs sur l'écran
        /// </summary>
        private void SetScoreOnScreen()
        {
            lblPlayer1Score.Text = "" + tblPlayers[0].Score; //Score du joueur 1
            lblPlayer2Score.Text = "" + tblPlayers[1].Score; //Score du joueur 2
            lblSetPlayer1.Text = "" + tblPlayers[0].WinSet; //Set gagné par le joueur 1
            lblSetPlayer2.Text = "" + tblPlayers[1].WinSet; //Set gagné par le joueur 2
        }

        /// <summary>
        /// Ajoute le score des joueurs par set
        /// </summary>
        private void AddPointsBySet()
        {

            //Connexion à la base de données
            OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0;Data Source=\\s2lfile3.s2.rpn.ch\CPLNpublic\Classes\ET\INF-HP\4INF-HP-M\module ict-153\dbScores.accdb");
            OleDbCommand cmd = con.CreateCommand();
            con.Open();
            //Requête SQL envoyé au serveur
            cmd.CommandText = "INSERT INTO tblSets ( num_tblGames, scoreJoueur1, scoreJoueur2, numeroSet ) VALUES ('" + iIdGame + "','" + tblPlayers[0].Score + "', '" + tblPlayers[1].Score +  "', '" + iSet + "')";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
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
            //Remise du score des joueurs à zéro
            for (int i=0; i < tblPlayers.Length; i++)
            {
                tblPlayers[i].Score = 0;
            }
            ball.x = 5; //Vitesse par défaut de la balle
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

        #region Touches de déplacement

        /// <summary>
        /// Lorsque l'utilisateur appuie ou relâche une touche de déplacement du clavier
        /// </summary>
        /// <param name="movePlayers">//Detection de la posibilité de déplacement vers le haut/bas des joueurs</param>
        /// <param name="bKeyDown">Touche appuyé = true ou relaché = false</param>
        private void KeyMove(Player[] tblPlayers, bool bKeyDown, KeyEventArgs e)
        {
            switch(e.KeyCode)
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
        private void SoloGame_KeyDown(object sender, KeyEventArgs e)
        {
            KeyMove(tblPlayers, true, e);
        }

        /// <summary>
        /// Lorsque l'utilisateur relâche une touche de déplacement du clavier
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SoloGame_KeyUp(object sender, KeyEventArgs e)
        {
            KeyMove(tblPlayers, false, e);
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
            pbxBalle.Top -= ball.y; //axe Y
            pbxBalle.Left -= ball.x; //axe X

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
                /*if (tblPlayers[0].Score < 5)
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
                ball.x = -ball.x;
                //+1 au score du joueur 2 (droite)
                tblPlayers[1].Score++;
                /* On baisse la vitesse de la balle
                ball.x = -8; */
            }
            //Si la balle est marqué à droite
            else if (pbxBalle.Left + pbxBalle.Width > RIGHT_BOX)
            {
                //Reposition de la balle au milieu de l'écran
                pbxBalle.Left = MIDDLE_X_BOX;
                //Change la balle de direction
                ball.x = -ball.x;
                //+1 au score du joueur 1 (gauche)
                tblPlayers[0].Score++;
                /* On baisse la vitesse de la balle
                ball.x = +8; */
            }

            #endregion

            #region Rebonds et Collision de la balle

            //Si la balle atteint le haut de l'écran ou le bas
            if (pbxBalle.Top < TOP_BOX || pbxBalle.Top + pbxBalle.Height > BOTTOM_BOX)
            {
                //On change la direction de la balle
                ball.y = -ball.y;
            }

            //Si la balle touche un des joueurs
            //if (pbxBalle.Bounds.IntersectsWith(pbxPlayer1.Bounds) || pbxBalle.Bounds.IntersectsWith(pbxPlayer2.Bounds))
            if (pbxBalle.Bounds.IntersectsWith(pbxPlayer1.Bounds))
            {
                //Problème de collision
                pbxBalle.Left += 4;
                //On change la direction de la balle
                ball.x = -ball.x;
                /*Augmente la vitesse de la balle
                ball.x -= 1; */
            }
            else if (pbxBalle.Bounds.IntersectsWith(pbxPlayer2.Bounds))
            {
                //Problème de collision
                pbxBalle.Left -= 4;
                //On change la direction de la balle
                ball.x = -ball.x;
                /*Augmente la vitesse de la balle
               ball.x += 1;*/
            }

            #endregion

            #region Déplacement du joueur 1

            //Si le déplacement vers le haut est autorisé et que le joueur se trouve avant la limite supérieure
            if (tblPlayers[0].MoveUp == true && pbxPlayer1.Top > TOP_BOX)
            {
                //Déplacement vers le haut
                pbxPlayer1.Top -= 8;
            }
            //Si le déplacement vers le bas est autorisé et que le joueur se trouve avant la limite inférieure
            if (tblPlayers[0].MoveDown == true && pbxPlayer1.Top < 452)
            {
                //Déplacement vers le bas
                pbxPlayer1.Top += 8;
            }

            #endregion

            #region Déplacement du joueur 2

            if (bTwoPlayer)
            {
                //Si le déplacement vers le bas est autorisé et que le joueur se trouve avant la limite supérieure
                if (tblPlayers[1].MoveUp == true && pbxPlayer2.Top > TOP_BOX)
                {
                    //Déplacement vers le haut
                    pbxPlayer2.Top -= 8;
                }
                //Si le déplacement vers le bas est autorisé et que le joueur se trouve avant la limite inférieure
                if (tblPlayers[1].MoveDown == true && pbxPlayer2.Top < 452)
                {
                    //Déplacement vers le bas
                    pbxPlayer2.Top += 8;
                }
            }

            #endregion

            #region Fin de la partie

            // Gagner avec 2 Points de différence
            if (tblPlayers[0].Score == iPoints && tblPlayers[1].Score >= iPoints-1)
            {
                iPoints++;
            }
            else if (tblPlayers[1].Score == iPoints && tblPlayers[0].Score >= iPoints - 1)
            {
                iPoints++;
            }

            //Si le joueur 1 atteint le nombre de points pour gagner
            if (tblPlayers[0].Score >= iPoints)
            {
                tblPlayers[0].WinSet++;
                SetScoreOnScreen();
                tmrGameTimer.Stop();

                //Score par set
                AddPointsBySet();

                if (tblPlayers[0].WinSet >= 3)
                {
                    iSet = 1;
                    tblPlayers[0].WinSet = 0;
                    tblPlayers[1].WinSet = 0;
                    //Message de fin de partie
                    ShowMessageEndGame(tblPlayers[0].Name);
                }
                else
                {
                    RestartGame();
                }
            }
            //Si le joueur 2 atteint le nombre de points pour gagner
            else if (tblPlayers[1].Score >= iPoints)
            {
                tblPlayers[1].WinSet++;
                SetScoreOnScreen();
                tmrGameTimer.Stop();

                //Score par set
                AddPointsBySet();

                if (tblPlayers[1].WinSet >= 3)
                {
                    iSet = 1;
                    tblPlayers[0].WinSet = 0;
                    tblPlayers[1].WinSet = 0;
                    //Message de fin de partie
                    ShowMessageEndGame(tblPlayers[1].Name);
                }
                else
                {
                    RestartGame();
                }
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
                    AddGamesInBDD(tblPlayers[0].Id, tblPlayers[1].Id);
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
