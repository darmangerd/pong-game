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
    public partial class LobbyLocal : Form
    {
        string[] tblPrenom; //Tableau contenant les prenoms des joueurs
        string[] tblNom; //Tableau contenant les noms des joueurs
        string[] tblId; //ID des utilisateurs provenant de la base de données

        public LobbyLocal()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Lancement de la form de jeux
        /// </summary>
        private void startGame()
        {
            if (hasErrors())
            {
                MessageBox.Show("Les champs ne sont pas remplis correctement.");
                cbxReadyPlayer1.Checked = false;
                cbxReadyPlayer2.Checked = false;
            }
            else
            {
                #region Base de données

                //Récupération des noms/prénoms des utilisateurs
                tblNom = new string[2] {tbxNamePlayer1.Text, tbxNamePlayer2.Text};
                tblPrenom = new string[2] { tbxSurnamePlayer1.Text, tbxSurnamePlayer2.Text };
                tblId = new string[2];

                //Classe permettant d'ajouter des données des utilisateurs dans la base Access
                UserInDB userInDB = new UserInDB();
                //Ajout des utilisateurs s'ils n'existe pas dans la base de données
                userInDB.AddUserInDB(tblNom, tblPrenom);
                //Récupération des IDs des joueurs dans la base de données
                tblId = userInDB.GetIdFromPlayer(tblNom, tblPrenom);

                #endregion

                //Lancement de la partie
                this.Hide();
                SoloGame solo = new SoloGame(tbxNamePlayer1.Text, tbxNamePlayer2.Text, tblId ,true);
                solo.Show();
            }
        }

        /// <summary>
        /// Test de la validation des champs (vides)
        /// </summary>
        /// <see cref="https://stackoverflow.com/questions/4202195/textbox-validation-in-a-windows-form"/>
        /// <returns></returns>
        private bool hasErrors()
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
