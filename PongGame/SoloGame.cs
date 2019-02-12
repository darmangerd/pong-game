﻿using System;
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
        const int TOP_BOX = 38;
        const int BOTTOM_BOX = 581;
        const int LEFT_BOX = 170;
        const int RIGHT_BOX = 892;
        const int MIDDLE_BOX = 533;

        bool bTwoPlayer; //Si la partie est en mode 2 joueur
        bool bGoUpPlayer1; //Detection du déplacement vers le haut du joueur 1
        bool bGoDownPlayer1; //Detection du déplacement vers le bas du joueur 1
        bool bGoUpPlayer2; //Detection du déplacement vers le haut du joueur 2
        bool bGoDownPlayer2; //Detection du déplacement vers le bas du joueur 2
        int iSpeed = 9; //Déplacement de l'IA
        int iBallx = 5; //Vitesse de déplacement de la balle en vertical x
        int iBally = 5; //Vitesse de déplacement de la balle en horizontal y
        int iStartCount = 3; //Compteur de comencement de la partie
        int iScorePlayer1 = 0;
        int iScorePlayer2 = 0;
        string strPlayer1Name = ""; //Nom du joueur 1
        string strPlayer2Name = ""; //Nom du joueur 2
        Random random = new Random(); //Variable pour déplacement aléatoire de L'IA


        public SoloGame(string strPlayer1_name, string strPlayer2_name, bool bTwoPlayers)
        {
            InitializeComponent();
            strPlayer1Name = strPlayer1_name; //Nom du joueur 1 entré dans le lobby
            strPlayer2Name = strPlayer2_name; //Nom du joueur 2 entré dans le lobby ou de l'IA
            bTwoPlayer = bTwoPlayers;
            
        }

        private void RestartGame()
        {
            iScorePlayer1 = 0;
            iScorePlayer2 = 0;
            iBallx = 5;
            iStartCount = 3;
            lblStarTimer.Visible = true;
            lblStarTimer.Text = iStartCount.ToString();
            tmrGameTimer.Stop();
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

            if (bTwoPlayer)
            {

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
            lblPlayer1Score.Text = "" + iScorePlayer1; //Score du joueur 1
            lblPlayer2Score.Text = "" + iScorePlayer2; //Score du joueur 2

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
                if (pbxPlayer2.Top < TOP_BOX || pbxPlayer2.Top > (BOTTOM_BOX - 140))
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
                pbxBalle.Left = MIDDLE_BOX;
                //Change la balle de direction
                iBallx = -iBallx;
                //+1 au score du joueur 2 (droite)
                iScorePlayer2++;
                //On baisse la vitesse de la balle
                iBallx = 8;
            }
            //Si la balle est marqué à droite
            else if (pbxBalle.Left + pbxBalle.Width > RIGHT_BOX) 
            {
                //Reposition de la balle au milieu de l'écran
                pbxBalle.Left = MIDDLE_BOX;
                //Change la balle de direction
                iBallx = -iBallx;
                //+1 au score du joueur 2 (droite)
                iScorePlayer1++;
                //On baisse la vitesse de la balle
                iBallx = 8;
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

            //Si le joueur 1 atteint 11, il a gagné
            if (iScorePlayer1 >= 11)
            {
                tmrGameTimer.Stop();

                //Ajout de la victoire du joueur à la base de donnée
                

                //Fin de partie
                DialogResult result = MessageBox.Show(strPlayer1Name.ToUpper() + " a gagné ! Voulez-vous recommencez ?", "Victoire", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Information);

                if (result == DialogResult.Abort)
                {
                    //Bouton de retour sur le menu
                    this.Hide();
                    Form1 menu = new Form1();
                    menu.Show();
                }
                else if (result == DialogResult.Retry)
                {
                    RestartGame();
                }
            }
            //Si le joueur 2 atteint 11, il a gagné
            else if (iScorePlayer2 >= 11)
            {
                tmrGameTimer.Stop();

                //Fin de partie
                DialogResult result = MessageBox.Show(strPlayer2Name.ToUpper() + " a gagné ! Voulez-vous recommencez ?", "Victoire", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Information);

                if (result == DialogResult.Abort)
                {
                    //Bouton de retour sur le menu
                    this.Hide();
                    Form1 menu = new Form1();
                    menu.Show();
                }
                else if (result == DialogResult.Retry)
                {
                    RestartGame();
                }
            }

            #endregion
        }

        /// <summary>
        /// Affichage du nom de l'utilisateur 1 entré dans le lobby
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblNamePlayer1_Paint(object sender, PaintEventArgs e)
        {
            //Segoe UI; 15.75pt; style=Bold
            Font font = new Font("Segoe UI", 15, FontStyle.Bold);
            Brush brush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
            e.Graphics.TranslateTransform(130, 142);
            e.Graphics.RotateTransform(270);
            e.Graphics.DrawString(strPlayer1Name.ToUpper(), font, brush, 0, 0);
        }

        /// <summary>
        /// Affichage du nom de l'utilisateur 2 entré dans le lobby ou l'IA
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblNamePlayer2_Paint(object sender, PaintEventArgs e)
        {
            Font font = new Font("Segoe UI", 15, FontStyle.Bold);
            Brush brush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
            e.Graphics.TranslateTransform(30, 20);
            e.Graphics.RotateTransform(90);
            e.Graphics.DrawString(strPlayer2Name.ToUpper(), font, brush, 0, 0);
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
            if (iStartCount==0)
            {
                tmrGameTimer.Start();
                tmrStart.Stop();
                lblStarTimer.Visible = false;
            }
            else
            {
                iStartCount--;
                lblStarTimer.Text = iStartCount.ToString();
            }
        }
    }
}
