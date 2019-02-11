using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        const int HAUT_TERRAIN = 38;
        const int BAS_TERRAIN = 581;
        const int GAUCHE_TERRAIN = 170;
        const int DROITE_TERRAIN = 892;
        const int MILIEU_TERRAIN = 533;

        bool bGoUp; //Detection du déplacement vers le haut du joueur
        bool bGoDown; //Detection du déplacement vers le bas du joueur
        int iSpeed = 9;
        int iBallx = 5; //Vitesse de déplacement de la balle en vertical x
        int iBally = 5; //Vitesse de déplacement de la balle en horizontal y
        int iScorePlayer1 = 0;
        int iScorePlayer2 = 0;
        string strPlayer1Name ="";
        Random random = new Random(); //Variable pour déplacement aléatoire de L'IA


        public SoloGame(string strPlayer1_name, string strPlayer2_name)
        {
            InitializeComponent();
            strPlayer1Name = strPlayer1_name;
        }

        private void SoloGame_KeyDown(object sender, KeyEventArgs e)
        {
            //Lorsque l'utilisateur appuie la touche UP/DOWN du clavier
            if (e.KeyCode == Keys.Up)
            {
                //UP
                bGoUp = true;
            }
            else if (e.KeyCode == Keys.Down)
            {
                //DOWN
                bGoDown = true;
            }
        }

        private void SoloGame_KeyUp(object sender, KeyEventArgs e)
        {
            //Lorsque l'utilisateur relâche la touche UP/DOWN du clavier
            if (e.KeyCode == Keys.Up)
            {
                bGoUp = false;
            }
            else if (e.KeyCode == Keys.Down)
            {
                bGoDown = false;
            }
        }

        private void tmrGameTimer_Tick(object sender, EventArgs e)
        {
            lblPlayer1Score.Text = "" + iScorePlayer1; //Score du joueur 1
            lblPlayer2Score.Text = "" + iScorePlayer2; //Score du joueur 2

            //Déplacement Horizontal et vertical de la balle. 
            // -= augmente la vitesse de la balle vers la gauche et le haut de l'écran
            // += augmente la vitesse de la balle vers la droite et le bas de l'écran
            pbxBalle.Top -= iBally; //Position Y
            pbxBalle.Left -= iBallx; //Position X

            //Vitesse/Direction du CPU (Commence par descendre)
            pbxPlayer2.Top += iSpeed;

            #region IA

            //Si le CPU atteint le top ou le bas de l'écran
            if (pbxPlayer2.Top < HAUT_TERRAIN || pbxPlayer2.Top > (BAS_TERRAIN-140))
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

            #endregion


            #region Marquage de la balle

            // Si la balle est marqué à gauche
            if (pbxBalle.Left < GAUCHE_TERRAIN)
            {
                //Reposition de la balle au milieu de l'écran
                pbxBalle.Left = MILIEU_TERRAIN;
                //Change la balle de direction
                iBallx = -iBallx;
                //Augmente la vitesse de la balle
                iBallx -= 1;
                //+1 au score du joueur 2 (droite)
                iScorePlayer2++;
            }
            //Si la balle est marqué à droite
            else if (pbxBalle.Left + pbxBalle.Width > DROITE_TERRAIN) 
            {
                //Reposition de la balle au milieu de l'écran
                pbxBalle.Left = MILIEU_TERRAIN;
                //Change la balle de direction
                iBallx = -iBallx;
                //Augmente la vitesse de la balle
                iBallx += 1;
                //+1 au score du joueur 2 (droite)
                iScorePlayer1++;
            }

            #endregion

            #region Rebonds et Collision de la balle

            //Si la balle atteint le haut de l'écran ou le bas
            if (pbxBalle.Top < HAUT_TERRAIN || pbxBalle.Top + pbxBalle.Height > BAS_TERRAIN)
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

            }
            else if (pbxBalle.Bounds.IntersectsWith(pbxPlayer2.Bounds))
            {
                //Problème de collision
                pbxBalle.Left -= 4;
                //On change la direction de la balle
                iBallx = -iBallx;
            }

            #endregion

            #region Déplacement des joueurs

            //Si le déplacement vers le haut est autorisé et que le joueur se trouve avant la limite supérieure
            if (bGoUp == true && pbxPlayer1.Top > HAUT_TERRAIN)
            {
                //Déplacement vers le haut
                pbxPlayer1.Top -= 8;
            }
            //Si le déplacement vers le bas est autorisé et que le joueur se trouve avant la limite inférieure
            if (bGoDown == true && pbxPlayer1.Top < 452)
            {
                //Déplacement vers le bas
                pbxPlayer1.Top += 8;
            }

            #endregion

            #region Fin de la partie

            //Si le joueur 1 atteint 10, il a gagné
            if (iScorePlayer1 > 10)
            {
                tmrGameTimer.Stop();
                MessageBox.Show("Player 1 a gagné");
            }
            //Si le joueur 2 atteint 10, il a gagné
            else if (iScorePlayer2 > 10)
            {
                tmrGameTimer.Stop();
                MessageBox.Show("Player 2 a gagné");
            }

            #endregion
        }

        private void lblNamePlayer1_Paint(object sender, PaintEventArgs e)
        {
            //Segoe UI; 15.75pt; style=Bold
            Font font = new Font("Segoe UI", 15, FontStyle.Bold);
            Brush brush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
            e.Graphics.TranslateTransform(130, 142);
            e.Graphics.RotateTransform(270);
            e.Graphics.DrawString(strPlayer1Name.ToUpper(), font, brush, 0, 0);
        }

        private void lblNamePlayer2_Paint(object sender, PaintEventArgs e)
        {
            Font font = new Font("Segoe UI", 15, FontStyle.Bold);
            Brush brush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
            e.Graphics.TranslateTransform(30, 20);
            e.Graphics.RotateTransform(90);
            e.Graphics.DrawString("IA", font, brush, 0, 0);
        }
    }
}
