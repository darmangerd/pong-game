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
                //BDD - Ajout de ou des utilisateurs
                OleDbConnection DBConnection = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0;Data Source=\\s2lfile3.s2.rpn.ch\CPLNpublic\Classes\ET\INF-HP\4INF-HP-M\module ict-153\dbScores.accdb");
                DBConnection.Open();
                for (int i = 0; i <= 1; i++)
                {
                    using (var cmd = DBConnection.CreateCommand())
                    {
                        //Requête SQL envoyé au serveur
                        cmd.CommandText =
                        "INSERT INTO tblUsers ( nomUser, prenom )" +
                        "VALUES(?, ?)";
                        cmd.Parameters.Add(new OleDbParameter("?", OleDbType.VarChar) { Value = tblNom[i] });
                        cmd.Parameters.Add(new OleDbParameter("?", OleDbType.VarChar) { Value = tblPrenom[i] });
                        try
                        {
                            var numberOfRowsInserted = cmd.ExecuteNonQuery();
                        }
                        catch
                        {
                            //OPTIMISATION - Faire plus propre
                            //Rien
                        }
                    }
                    
                }
                DBConnection.Close();

                //BDD - Récupération de l'ID des joueurs
                string strConnection = @"Provider = Microsoft.ACE.OLEDB.12.0;Data Source=\\s2lfile3.s2.rpn.ch\CPLNpublic\Classes\ET\INF-HP\4INF-HP-M\module ict-153\dbScores.accdb";
                for (int i=0; i<=1;i++)
                {
                    //Requête SQL envoyé au serveur
                    string strSQL = "SELECT tblUsers.numero FROM tblUsers WHERE nomUser='" + tblNom[i] + "' AND prenom ='" + tblPrenom[i] + "';";

                    //Création de la connection
                    using (OleDbConnection connection = new OleDbConnection(strConnection))
                    {
                        //Création de la commande
                        OleDbCommand command = new OleDbCommand(strSQL, connection);
                        try
                        {
                            //Ouverture de la connection
                            connection.Open();
                            //Exécution de la commande 
                            using (OleDbDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    //Récupération de l'ID des joueurs
                                    tblId[i] = reader[0].ToString();
                                }
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Erreur avec la base de données");
                        }
                    }
                }

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
