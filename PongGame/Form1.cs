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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pbxExit_Click(object sender, EventArgs e)
        {
            //confirmation de fermeture de l'application
            DialogResult result = MessageBox.Show("Do you really want to close the Program", "Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
            {
                this.Close();
                Environment.Exit(1);
            }
        }

        private void btnSinglePlayer_Click(object sender, EventArgs e)
        {
            this.Hide();
            LobbySolo lobby = new LobbySolo();
            lobby.Show();
            
        }

        private void btnLocal_Click(object sender, EventArgs e)
        {
            this.Hide();
            LobbyLocal lobbyLocal = new LobbyLocal();
            lobbyLocal.Show();
        }
    }
}
