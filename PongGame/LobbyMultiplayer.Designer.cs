namespace PongGame
{
    partial class LobbyMultiplayer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LobbyMultiplayer));
            this.pbxBack = new System.Windows.Forms.PictureBox();
            this.pbxExit = new System.Windows.Forms.PictureBox();
            this.lblSurnamePlayer = new System.Windows.Forms.Label();
            this.tbxSurnamePlayer = new System.Windows.Forms.TextBox();
            this.lblNamePlayer = new System.Windows.Forms.Label();
            this.tbxNamePlayer = new System.Windows.Forms.TextBox();
            this.lblIpServer = new System.Windows.Forms.Label();
            this.tbxIPServer = new System.Windows.Forms.TextBox();
            this.lblTitleServer = new System.Windows.Forms.Button();
            this.lblTitleClient = new System.Windows.Forms.Button();
            this.pbxLine = new System.Windows.Forms.PictureBox();
            this.lblIpClient = new System.Windows.Forms.Label();
            this.tbxIpClient = new System.Windows.Forms.TextBox();
            this.btnServer = new System.Windows.Forms.Button();
            this.btnClient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLine)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxBack
            // 
            this.pbxBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxBack.Image = ((System.Drawing.Image)(resources.GetObject("pbxBack.Image")));
            this.pbxBack.Location = new System.Drawing.Point(8, 7);
            this.pbxBack.Margin = new System.Windows.Forms.Padding(4);
            this.pbxBack.Name = "pbxBack";
            this.pbxBack.Size = new System.Drawing.Size(41, 41);
            this.pbxBack.TabIndex = 21;
            this.pbxBack.TabStop = false;
            this.pbxBack.Click += new System.EventHandler(this.pbxBack_Click);
            // 
            // pbxExit
            // 
            this.pbxExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.pbxExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxExit.Image = global::PongGame.Properties.Resources.cross;
            this.pbxExit.Location = new System.Drawing.Point(1003, 10);
            this.pbxExit.Margin = new System.Windows.Forms.Padding(4);
            this.pbxExit.Name = "pbxExit";
            this.pbxExit.Size = new System.Drawing.Size(45, 41);
            this.pbxExit.TabIndex = 22;
            this.pbxExit.TabStop = false;
            this.pbxExit.Click += new System.EventHandler(this.pbxExit_Click);
            // 
            // lblSurnamePlayer
            // 
            this.lblSurnamePlayer.AutoSize = true;
            this.lblSurnamePlayer.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurnamePlayer.ForeColor = System.Drawing.Color.White;
            this.lblSurnamePlayer.Location = new System.Drawing.Point(570, 39);
            this.lblSurnamePlayer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSurnamePlayer.Name = "lblSurnamePlayer";
            this.lblSurnamePlayer.Size = new System.Drawing.Size(133, 37);
            this.lblSurnamePlayer.TabIndex = 26;
            this.lblSurnamePlayer.Text = "PRÉNOM";
            // 
            // tbxSurnamePlayer
            // 
            this.tbxSurnamePlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.tbxSurnamePlayer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxSurnamePlayer.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSurnamePlayer.ForeColor = System.Drawing.Color.White;
            this.tbxSurnamePlayer.Location = new System.Drawing.Point(577, 80);
            this.tbxSurnamePlayer.Margin = new System.Windows.Forms.Padding(4);
            this.tbxSurnamePlayer.MaxLength = 10;
            this.tbxSurnamePlayer.Name = "tbxSurnamePlayer";
            this.tbxSurnamePlayer.Size = new System.Drawing.Size(260, 32);
            this.tbxSurnamePlayer.TabIndex = 25;
            this.tbxSurnamePlayer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNamePlayer
            // 
            this.lblNamePlayer.AutoSize = true;
            this.lblNamePlayer.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamePlayer.ForeColor = System.Drawing.Color.White;
            this.lblNamePlayer.Location = new System.Drawing.Point(170, 39);
            this.lblNamePlayer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNamePlayer.Name = "lblNamePlayer";
            this.lblNamePlayer.Size = new System.Drawing.Size(84, 37);
            this.lblNamePlayer.TabIndex = 24;
            this.lblNamePlayer.Text = "NOM";
            // 
            // tbxNamePlayer
            // 
            this.tbxNamePlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.tbxNamePlayer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxNamePlayer.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNamePlayer.ForeColor = System.Drawing.Color.White;
            this.tbxNamePlayer.Location = new System.Drawing.Point(177, 80);
            this.tbxNamePlayer.Margin = new System.Windows.Forms.Padding(4);
            this.tbxNamePlayer.MaxLength = 10;
            this.tbxNamePlayer.Name = "tbxNamePlayer";
            this.tbxNamePlayer.Size = new System.Drawing.Size(260, 32);
            this.tbxNamePlayer.TabIndex = 23;
            this.tbxNamePlayer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblIpServer
            // 
            this.lblIpServer.AutoSize = true;
            this.lblIpServer.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIpServer.ForeColor = System.Drawing.Color.White;
            this.lblIpServer.Location = new System.Drawing.Point(122, 344);
            this.lblIpServer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIpServer.Name = "lblIpServer";
            this.lblIpServer.Size = new System.Drawing.Size(165, 37);
            this.lblIpServer.TabIndex = 29;
            this.lblIpServer.Text = "ADRESSE IP";
            // 
            // tbxIPServer
            // 
            this.tbxIPServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.tbxIPServer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxIPServer.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxIPServer.ForeColor = System.Drawing.Color.White;
            this.tbxIPServer.Location = new System.Drawing.Point(129, 386);
            this.tbxIPServer.Margin = new System.Windows.Forms.Padding(4);
            this.tbxIPServer.MaxLength = 10;
            this.tbxIPServer.Name = "tbxIPServer";
            this.tbxIPServer.Size = new System.Drawing.Size(260, 32);
            this.tbxIPServer.TabIndex = 28;
            this.tbxIPServer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTitleServer
            // 
            this.lblTitleServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(14)))), ((int)(((byte)(98)))));
            this.lblTitleServer.FlatAppearance.BorderSize = 5;
            this.lblTitleServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitleServer.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleServer.ForeColor = System.Drawing.Color.White;
            this.lblTitleServer.Location = new System.Drawing.Point(93, 202);
            this.lblTitleServer.Margin = new System.Windows.Forms.Padding(4);
            this.lblTitleServer.Name = "lblTitleServer";
            this.lblTitleServer.Size = new System.Drawing.Size(333, 86);
            this.lblTitleServer.TabIndex = 31;
            this.lblTitleServer.Text = "SERVEUR";
            this.lblTitleServer.UseVisualStyleBackColor = false;
            // 
            // lblTitleClient
            // 
            this.lblTitleClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(137)))), ((int)(((byte)(250)))));
            this.lblTitleClient.FlatAppearance.BorderSize = 5;
            this.lblTitleClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitleClient.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleClient.ForeColor = System.Drawing.Color.White;
            this.lblTitleClient.Location = new System.Drawing.Point(606, 202);
            this.lblTitleClient.Margin = new System.Windows.Forms.Padding(4);
            this.lblTitleClient.Name = "lblTitleClient";
            this.lblTitleClient.Size = new System.Drawing.Size(333, 86);
            this.lblTitleClient.TabIndex = 30;
            this.lblTitleClient.Text = "CLIENT";
            this.lblTitleClient.UseVisualStyleBackColor = false;
            // 
            // pbxLine
            // 
            this.pbxLine.BackColor = System.Drawing.Color.White;
            this.pbxLine.Location = new System.Drawing.Point(513, 311);
            this.pbxLine.Margin = new System.Windows.Forms.Padding(4);
            this.pbxLine.Name = "pbxLine";
            this.pbxLine.Size = new System.Drawing.Size(9, 181);
            this.pbxLine.TabIndex = 32;
            this.pbxLine.TabStop = false;
            // 
            // lblIpClient
            // 
            this.lblIpClient.AutoSize = true;
            this.lblIpClient.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIpClient.ForeColor = System.Drawing.Color.White;
            this.lblIpClient.Location = new System.Drawing.Point(635, 345);
            this.lblIpClient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIpClient.Name = "lblIpClient";
            this.lblIpClient.Size = new System.Drawing.Size(165, 37);
            this.lblIpClient.TabIndex = 38;
            this.lblIpClient.Text = "ADRESSE IP";
            // 
            // tbxIpClient
            // 
            this.tbxIpClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.tbxIpClient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxIpClient.Enabled = false;
            this.tbxIpClient.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxIpClient.ForeColor = System.Drawing.Color.White;
            this.tbxIpClient.Location = new System.Drawing.Point(642, 386);
            this.tbxIpClient.Margin = new System.Windows.Forms.Padding(4);
            this.tbxIpClient.MaxLength = 10;
            this.tbxIpClient.Name = "tbxIpClient";
            this.tbxIpClient.Size = new System.Drawing.Size(260, 32);
            this.tbxIpClient.TabIndex = 37;
            this.tbxIpClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnServer
            // 
            this.btnServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(14)))), ((int)(((byte)(98)))));
            this.btnServer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnServer.FlatAppearance.BorderSize = 0;
            this.btnServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServer.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServer.ForeColor = System.Drawing.Color.White;
            this.btnServer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServer.Location = new System.Drawing.Point(164, 464);
            this.btnServer.Margin = new System.Windows.Forms.Padding(4);
            this.btnServer.Name = "btnServer";
            this.btnServer.Size = new System.Drawing.Size(191, 54);
            this.btnServer.TabIndex = 40;
            this.btnServer.Text = "JOUER";
            this.btnServer.UseVisualStyleBackColor = false;
            // 
            // btnClient
            // 
            this.btnClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(137)))), ((int)(((byte)(250)))));
            this.btnClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClient.FlatAppearance.BorderSize = 0;
            this.btnClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClient.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClient.ForeColor = System.Drawing.Color.White;
            this.btnClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClient.Location = new System.Drawing.Point(677, 464);
            this.btnClient.Margin = new System.Windows.Forms.Padding(4);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(191, 54);
            this.btnClient.TabIndex = 41;
            this.btnClient.Text = "JOUER";
            this.btnClient.UseVisualStyleBackColor = false;
            // 
            // LobbyMultiplayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(1055, 619);
            this.Controls.Add(this.btnClient);
            this.Controls.Add(this.btnServer);
            this.Controls.Add(this.lblIpClient);
            this.Controls.Add(this.tbxIpClient);
            this.Controls.Add(this.pbxLine);
            this.Controls.Add(this.lblTitleServer);
            this.Controls.Add(this.lblTitleClient);
            this.Controls.Add(this.lblIpServer);
            this.Controls.Add(this.tbxIPServer);
            this.Controls.Add(this.lblSurnamePlayer);
            this.Controls.Add(this.tbxSurnamePlayer);
            this.Controls.Add(this.lblNamePlayer);
            this.Controls.Add(this.tbxNamePlayer);
            this.Controls.Add(this.pbxExit);
            this.Controls.Add(this.pbxBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LobbyMultiplayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LobbyMultiplayer";
            ((System.ComponentModel.ISupportInitialize)(this.pbxBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxBack;
        private System.Windows.Forms.PictureBox pbxExit;
        private System.Windows.Forms.Label lblSurnamePlayer;
        private System.Windows.Forms.TextBox tbxSurnamePlayer;
        private System.Windows.Forms.Label lblNamePlayer;
        private System.Windows.Forms.TextBox tbxNamePlayer;
        private System.Windows.Forms.Label lblIpServer;
        private System.Windows.Forms.TextBox tbxIPServer;
        private System.Windows.Forms.Button lblTitleServer;
        private System.Windows.Forms.Button lblTitleClient;
        private System.Windows.Forms.PictureBox pbxLine;
        private System.Windows.Forms.Label lblIpClient;
        private System.Windows.Forms.TextBox tbxIpClient;
        private System.Windows.Forms.Button btnServer;
        private System.Windows.Forms.Button btnClient;
    }
}