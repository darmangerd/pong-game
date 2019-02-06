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

        private void pbxExit_Click(object sender, EventArgs e)
        {
            //Bouton de fermeture de l'application
            this.Close();
        }

        private void btnSinglePlayer_Click(object sender, EventArgs e)
        {
            //Bouton de commencement de partie
            this.Hide();
            SoloGame solo = new SoloGame();
            solo.Show();
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
