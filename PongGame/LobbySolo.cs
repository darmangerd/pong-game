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
    public partial class LobbySolo : Form
    {
        string[] tblPrenom; //Tableau contenant les prenoms des joueurs
        string[] tblNom; //Tableau contenant les noms des joueurs
        string[] tblId; //ID des utilisateurs provenant de la base de données

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
                #region Base de données

                //Récupération des noms/prénoms de l'utilisateur
                //L'IA est considéré comme un joueur. Son nom: IA et son prénom : (ordinateur)
                tblNom = new string[2] { tbxName.Text, "IA" };
                tblPrenom = new string[2] { tbxSurname.Text, "(ordinateur)" };
                tblId = new string[2];

                //Classe permettant d'ajouter des données de l'utilisateur dans la base Access
                UserInDB userInDB = new UserInDB();
                //Ajout de l'utilisateur s'il n'existe pas dans la base de données
                userInDB.AddUserInDB(tblNom, tblPrenom);
                //Récupération des IDs du joueur et de l'IA dans la base de données
                tblId = userInDB.GetIdFromPlayer(tblNom, tblPrenom);

                #endregion

                //Commencement de partie
                if (rbtnUseGamepad.Checked)
                {
                    SoloGame solo = new SoloGame(tbxName.Text, "IA", tblId, false, 1);
                    solo.Show();
                }
                else if (rbtnDontUseGamepad.Checked)
                {
                    SoloGame solo = new SoloGame(tbxName.Text, "IA", tblId, false, 0);
                    solo.Show();
                }
                this.Hide();
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
