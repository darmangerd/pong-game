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
    public partial class LobbySolo : Form
    {
        public LobbySolo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Test de la validation des champs (vides)
        /// </summary>
        /// <see cref="https://stackoverflow.com/questions/4202195/textbox-validation-in-a-windows-form"/>
        /// <returns></returns>
        private bool WithErrors()
        {
            // Retourne vrai si le champs est vide ou rempli avec des espaces
            if (tbxName.Text.Trim() == String.Empty)
                return true;
            if (tbxSurname.Text.Trim() == String.Empty)
                return true;

            return false;
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

        private void btnSinglePlayer_Click(object sender, EventArgs e)
        {
            if (WithErrors())
            {
                MessageBox.Show("Les champs ne sont pas remplis correctement.");
            }
            else
            {
                //Bouton de commencement de partie
                this.Hide();
                SoloGame solo = new SoloGame(tbxName.Text, "IA", false);
                solo.Show();
            }
        }

        private void pbxBack_Click(object sender, EventArgs e)
        {
            //Bouton de retour sur le menu
            this.Hide();
            Form1 menu = new Form1();
            menu.Show();
        }
    }
}
