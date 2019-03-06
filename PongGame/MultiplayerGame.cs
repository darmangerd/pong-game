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
    public partial class MultiplayerGame : Form
    {

        public MultiplayerGame(bool bClient)
        {
            InitializeComponent();

            if (bClient)
            {
                lblWho.Text = "Je suis client";
            }
            else
            {
                lblWho.Text = "Je suis serveur";
            }
        }
    }
}
