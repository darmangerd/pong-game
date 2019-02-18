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
    public partial class LobbyLocal : Form
    {
        public LobbyLocal()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Lancement de la form de jeux
        /// </summary>
        private void startGame()
        {
            if (WithErrors())
            {
                MessageBox.Show("Les champs ne sont pas remplis correctement.");
                cbxReadyPlayer1.Checked = false;
                cbxReadyPlayer2.Checked = false;
            }
            else
            {
                this.Hide();
                SoloGame solo = new SoloGame(tbxNamePlayer1.Text, tbxNamePlayer2.Text, true);
                solo.Show();
            }
        }

        /// <summary>
        /// Test de la validation des champs (vides)
        /// </summary>
        /// <see cref="https://stackoverflow.com/questions/4202195/textbox-validation-in-a-windows-form"/>
        /// <returns></returns>
        private bool WithErrors()
        {
            // Retourne vrai si le champs est vide ou rempli avec des espaces
            if (tbxNamePlayer1.Text.Trim() == String.Empty)
                return true;
            if (tbxNamePlayer2.Text.Trim() == String.Empty)
                return true;
            if (tbxSurnamePlayer1.Text.Trim() == String.Empty)
                return true;
            if (tbxSurnamePlayer2.Text.Trim() == String.Empty)
                return true;

            return false;
        }

        /// <summary>
        /// Quand la checkbox du joueur 1 change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxReadyPlayer1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxReadyPlayer1.Checked && cbxReadyPlayer2.Checked)
            {
                startGame();
            }
        }

        /// <summary>
        /// Quand la checkbox du joueur 2 change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxReadyPlayer2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxReadyPlayer1.Checked && cbxReadyPlayer2.Checked)
            {
                startGame();
            }
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
    }
}
