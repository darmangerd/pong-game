namespace PongGame
{
    partial class LobbySolo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LobbySolo));
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.tbxSurname = new System.Windows.Forms.TextBox();
            this.lblDifficulty = new System.Windows.Forms.Label();
            this.rbtnEasy = new System.Windows.Forms.RadioButton();
            this.rbtnNormal = new System.Windows.Forms.RadioButton();
            this.rbtnHard = new System.Windows.Forms.RadioButton();
            this.btnTitre = new System.Windows.Forms.Button();
            this.btnSinglePlayer = new System.Windows.Forms.Button();
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.pbxBack = new System.Windows.Forms.PictureBox();
            this.pbxExit = new System.Windows.Forms.PictureBox();
            this.pbxRaquetteLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRaquetteLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxName
            // 
            this.tbxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.tbxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxName.ForeColor = System.Drawing.Color.White;
            this.tbxName.Location = new System.Drawing.Point(84, 89);
            this.tbxName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxName.MaxLength = 10;
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(260, 32);
            this.tbxName.TabIndex = 0;
            this.tbxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(77, 42);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(84, 37);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "NOM";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.Color.White;
            this.lblFirstName.Location = new System.Drawing.Point(77, 176);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(133, 37);
            this.lblFirstName.TabIndex = 3;
            this.lblFirstName.Text = "PRÉNOM";
            // 
            // tbxSurname
            // 
            this.tbxSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.tbxSurname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxSurname.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSurname.ForeColor = System.Drawing.Color.White;
            this.tbxSurname.Location = new System.Drawing.Point(84, 223);
            this.tbxSurname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxSurname.MaxLength = 10;
            this.tbxSurname.Name = "tbxSurname";
            this.tbxSurname.Size = new System.Drawing.Size(260, 32);
            this.tbxSurname.TabIndex = 2;
            this.tbxSurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.AutoSize = true;
            this.lblDifficulty.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDifficulty.ForeColor = System.Drawing.Color.White;
            this.lblDifficulty.Location = new System.Drawing.Point(77, 318);
            this.lblDifficulty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(162, 37);
            this.lblDifficulty.TabIndex = 4;
            this.lblDifficulty.Text = "DIFFICULTÉ";
            // 
            // rbtnEasy
            // 
            this.rbtnEasy.AutoSize = true;
            this.rbtnEasy.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.rbtnEasy.ForeColor = System.Drawing.Color.White;
            this.rbtnEasy.Location = new System.Drawing.Point(95, 363);
            this.rbtnEasy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnEasy.Name = "rbtnEasy";
            this.rbtnEasy.Size = new System.Drawing.Size(112, 36);
            this.rbtnEasy.TabIndex = 5;
            this.rbtnEasy.Text = "FACILE";
            this.rbtnEasy.UseVisualStyleBackColor = true;
            // 
            // rbtnNormal
            // 
            this.rbtnNormal.AutoSize = true;
            this.rbtnNormal.Checked = true;
            this.rbtnNormal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.rbtnNormal.ForeColor = System.Drawing.Color.White;
            this.rbtnNormal.Location = new System.Drawing.Point(95, 404);
            this.rbtnNormal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnNormal.Name = "rbtnNormal";
            this.rbtnNormal.Size = new System.Drawing.Size(141, 36);
            this.rbtnNormal.TabIndex = 6;
            this.rbtnNormal.TabStop = true;
            this.rbtnNormal.Text = "NORMAL";
            this.rbtnNormal.UseVisualStyleBackColor = true;
            // 
            // rbtnHard
            // 
            this.rbtnHard.AutoSize = true;
            this.rbtnHard.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnHard.ForeColor = System.Drawing.Color.White;
            this.rbtnHard.Location = new System.Drawing.Point(95, 449);
            this.rbtnHard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnHard.Name = "rbtnHard";
            this.rbtnHard.Size = new System.Drawing.Size(142, 36);
            this.rbtnHard.TabIndex = 7;
            this.rbtnHard.Text = "DIFFICILE";
            this.rbtnHard.UseVisualStyleBackColor = true;
            // 
            // btnTitre
            // 
            this.btnTitre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(230)))), ((int)(((byte)(193)))));
            this.btnTitre.FlatAppearance.BorderSize = 5;
            this.btnTitre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTitre.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold);
            this.btnTitre.ForeColor = System.Drawing.Color.White;
            this.btnTitre.Location = new System.Drawing.Point(488, 124);
            this.btnTitre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTitre.Name = "btnTitre";
            this.btnTitre.Size = new System.Drawing.Size(372, 89);
            this.btnTitre.TabIndex = 8;
            this.btnTitre.Text = "PONG GAME";
            this.btnTitre.UseVisualStyleBackColor = false;
            // 
            // btnSinglePlayer
            // 
            this.btnSinglePlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(230)))), ((int)(((byte)(193)))));
            this.btnSinglePlayer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSinglePlayer.FlatAppearance.BorderSize = 0;
            this.btnSinglePlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSinglePlayer.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSinglePlayer.ForeColor = System.Drawing.Color.White;
            this.btnSinglePlayer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSinglePlayer.Location = new System.Drawing.Point(84, 529);
            this.btnSinglePlayer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSinglePlayer.Name = "btnSinglePlayer";
            this.btnSinglePlayer.Size = new System.Drawing.Size(191, 54);
            this.btnSinglePlayer.TabIndex = 9;
            this.btnSinglePlayer.Text = "JOUER";
            this.btnSinglePlayer.UseVisualStyleBackColor = false;
            this.btnSinglePlayer.Click += new System.EventHandler(this.btnSinglePlayer_Click);
            // 
            // pnlBackground
            // 
            this.pnlBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(230)))), ((int)(((byte)(193)))));
            this.pnlBackground.Location = new System.Drawing.Point(423, -2);
            this.pnlBackground.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(495, 624);
            this.pnlBackground.TabIndex = 13;
            // 
            // pbxBack
            // 
            this.pbxBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxBack.Image = ((System.Drawing.Image)(resources.GetObject("pbxBack.Image")));
            this.pbxBack.Location = new System.Drawing.Point(13, 11);
            this.pbxBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbxBack.Name = "pbxBack";
            this.pbxBack.Size = new System.Drawing.Size(41, 41);
            this.pbxBack.TabIndex = 14;
            this.pbxBack.TabStop = false;
            this.pbxBack.Click += new System.EventHandler(this.pbxBack_Click);
            // 
            // pbxExit
            // 
            this.pbxExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(230)))), ((int)(((byte)(193)))));
            this.pbxExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxExit.Image = global::PongGame.Properties.Resources.cross;
            this.pbxExit.Location = new System.Drawing.Point(863, 9);
            this.pbxExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbxExit.Name = "pbxExit";
            this.pbxExit.Size = new System.Drawing.Size(45, 41);
            this.pbxExit.TabIndex = 12;
            this.pbxExit.TabStop = false;
            this.pbxExit.Click += new System.EventHandler(this.pbxExit_Click);
            // 
            // pbxRaquetteLogo
            // 
            this.pbxRaquetteLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(230)))), ((int)(((byte)(193)))));
            this.pbxRaquetteLogo.Image = global::PongGame.Properties.Resources.table_tennis;
            this.pbxRaquetteLogo.Location = new System.Drawing.Point(543, 246);
            this.pbxRaquetteLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbxRaquetteLogo.Name = "pbxRaquetteLogo";
            this.pbxRaquetteLogo.Size = new System.Drawing.Size(261, 218);
            this.pbxRaquetteLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxRaquetteLogo.TabIndex = 11;
            this.pbxRaquetteLogo.TabStop = false;
            // 
            // LobbySolo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(917, 619);
            this.Controls.Add(this.pbxBack);
            this.Controls.Add(this.pbxExit);
            this.Controls.Add(this.pbxRaquetteLogo);
            this.Controls.Add(this.btnSinglePlayer);
            this.Controls.Add(this.btnTitre);
            this.Controls.Add(this.rbtnHard);
            this.Controls.Add(this.rbtnNormal);
            this.Controls.Add(this.rbtnEasy);
            this.Controls.Add(this.lblDifficulty);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.tbxSurname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.pnlBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LobbySolo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LobbySolo";
            ((System.ComponentModel.ISupportInitialize)(this.pbxBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRaquetteLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox tbxSurname;
        private System.Windows.Forms.Label lblDifficulty;
        private System.Windows.Forms.RadioButton rbtnEasy;
        private System.Windows.Forms.RadioButton rbtnNormal;
        private System.Windows.Forms.RadioButton rbtnHard;
        private System.Windows.Forms.Button btnTitre;
        private System.Windows.Forms.Button btnSinglePlayer;
        private System.Windows.Forms.PictureBox pbxRaquetteLogo;
        private System.Windows.Forms.PictureBox pbxExit;
        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.PictureBox pbxBack;
    }
}