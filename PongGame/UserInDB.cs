using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PongGame
{
    public class UserInDB
    {
        public void AddUserInDB(string[] noms, string[] prenoms)
        {
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
                    cmd.Parameters.Add(new OleDbParameter("?", OleDbType.VarChar) { Value = noms[i] });
                    cmd.Parameters.Add(new OleDbParameter("?", OleDbType.VarChar) { Value = prenoms[i] });

                    //Try catch en raison de doublon. Car lorsqu'il y a un doublon, Access envoie une erreur.
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
        }

        public string[] GetIdFromPlayer(string[] noms, string[] prenoms)
        {
            string[] tblId = new string[2];
            //BDD - Récupération de l'ID des joueurs
            string strConnection = @"Provider = Microsoft.ACE.OLEDB.12.0;Data Source=\\s2lfile3.s2.rpn.ch\CPLNpublic\Classes\ET\INF-HP\4INF-HP-M\module ict-153\dbScores.accdb";
            for (int i = 0; i <= 1; i++)
            {
                //Requête SQL envoyé au serveur
                string strSQL = "SELECT tblUsers.numero FROM tblUsers WHERE nomUser='" + noms[i] + "' AND prenom ='" + prenoms[i] + "';";

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
            return tblId;
        }
    }
}
