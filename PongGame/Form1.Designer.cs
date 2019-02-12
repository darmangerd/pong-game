namespace PongGame
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTitre = new System.Windows.Forms.Button();
            this.pbxExit = new System.Windows.Forms.PictureBox();
            this.btnLocal = new System.Windows.Forms.Button();
            this.btnMultiplayer = new System.Windows.Forms.Button();
            this.btnSinglePlayer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxExit)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTitre
            // 
            this.btnTitre.FlatAppearance.BorderSize = 5;
            this.btnTitre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTitre.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold);
            this.btnTitre.ForeColor = System.Drawing.Color.White;
            this.btnTitre.Location = new System.Drawing.Point(93, 89);
            this.btnTitre.Margin = new System.Windows.Forms.Padding(4);
            this.btnTitre.Name = "btnTitre";
            this.btnTitre.Size = new System.Drawing.Size(372, 89);
            this.btnTitre.TabIndex = 4;
            this.btnTitre.Text = "PONG GAME";
            this.btnTitre.UseVisualStyleBackColor = true;
            // 
            // pbxExit
            // 
            this.pbxExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxExit.Image = global::PongGame.Properties.Resources.cross;
            this.pbxExit.Location = new System.Drawing.Point(515, 6);
            this.pbxExit.Margin = new System.Windows.Forms.Padding(4);
            this.pbxExit.Name = "pbxExit";
            this.pbxExit.Size = new System.Drawing.Size(45, 41);
            this.pbxExit.TabIndex = 5;
            this.pbxExit.TabStop = false;
            this.pbxExit.Click += new System.EventHandler(this.pbxExit_Click);
            // 
            // btnLocal
            // 
            this.btnLocal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(142)))), ((int)(((byte)(165)))));
            this.btnLocal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLocal.FlatAppearance.BorderSize = 0;
            this.btnLocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocal.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.btnLocal.ForeColor = System.Drawing.Color.White;
            this.btnLocal.Image = global::PongGame.Properties.Resources.local;
            this.btnLocal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLocal.Location = new System.Drawing.Point(-12, 382);
            this.btnLocal.Margin = new System.Windows.Forms.Padding(4);
            this.btnLocal.Name = "btnLocal";
            this.btnLocal.Padding = new System.Windows.Forms.Padding(71, 0, 40, 0);
            this.btnLocal.Size = new System.Drawing.Size(575, 130);
            this.btnLocal.TabIndex = 2;
            this.btnLocal.Text = "PARTIE LOCAL";
            this.btnLocal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLocal.UseVisualStyleBackColor = false;
            this.btnLocal.Click += new System.EventHandler(this.btnLocal_Click);
            // 
            // btnMultiplayer
            // 
            this.btnMultiplayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(41)))), ((int)(((byte)(82)))));
            this.btnMultiplayer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMultiplayer.FlatAppearance.BorderSize = 0;
            this.btnMultiplayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiplayer.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.btnMultiplayer.ForeColor = System.Drawing.Color.White;
            this.btnMultiplayer.Image = global::PongGame.Properties.Resources.multiplayer;
            this.btnMultiplayer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMultiplayer.Location = new System.Drawing.Point(-11, 511);
            this.btnMultiplayer.Margin = new System.Windows.Forms.Padding(4);
            this.btnMultiplayer.Name = "btnMultiplayer";
            this.btnMultiplayer.Padding = new System.Windows.Forms.Padding(71, 0, 40, 0);
            this.btnMultiplayer.Size = new System.Drawing.Size(575, 130);
            this.btnMultiplayer.TabIndex = 1;
            this.btnMultiplayer.Text = "MULTIJOUEUR";
            this.btnMultiplayer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMultiplayer.UseVisualStyleBackColor = false;
            // 
            // btnSinglePlayer
            // 
            this.btnSinglePlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(230)))), ((int)(((byte)(193)))));
            this.btnSinglePlayer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSinglePlayer.FlatAppearance.BorderSize = 0;
            this.btnSinglePlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSinglePlayer.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSinglePlayer.ForeColor = System.Drawing.Color.White;
            this.btnSinglePlayer.Image = global::PongGame.Properties.Resources.solo;
            this.btnSinglePlayer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSinglePlayer.Location = new System.Drawing.Point(-5, 255);
            this.btnSinglePlayer.Margin = new System.Windows.Forms.Padding(4);
            this.btnSinglePlayer.Name = "btnSinglePlayer";
            this.btnSinglePlayer.Padding = new System.Windows.Forms.Padding(71, 0, 40, 0);
            this.btnSinglePlayer.Size = new System.Drawing.Size(575, 130);
            this.btnSinglePlayer.TabIndex = 3;
            this.btnSinglePlayer.Text = "PARTIE SOLO";
            this.btnSinglePlayer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSinglePlayer.UseVisualStyleBackColor = false;
            this.btnSinglePlayer.Click += new System.EventHandler(this.btnSinglePlayer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(563, 640);
            this.Controls.Add(this.pbxExit);
            this.Controls.Add(this.btnTitre);
            this.Controls.Add(this.btnLocal);
            this.Controls.Add(this.btnMultiplayer);
            this.Controls.Add(this.btnSinglePlayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbxExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnMultiplayer;
        private System.Windows.Forms.Button btnLocal;
        private System.Windows.Forms.Button btnSinglePlayer;
        private System.Windows.Forms.Button btnTitre;
        private System.Windows.Forms.PictureBox pbxExit;
    }
}

