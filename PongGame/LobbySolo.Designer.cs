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
            this.lblSurnamePlayer = new System.Windows.Forms.Label();
            this.tbxSurname = new System.Windows.Forms.TextBox();
            this.lblGamepad = new System.Windows.Forms.Label();
            this.rbtnUseGamepad = new System.Windows.Forms.RadioButton();
            this.rbtnDontUseGamepad = new System.Windows.Forms.RadioButton();
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
            this.tbxName.Location = new System.Drawing.Point(63, 72);
            this.tbxName.MaxLength = 10;
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(195, 26);
            this.tbxName.TabIndex = 0;
            this.tbxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(58, 34);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(66, 30);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "NOM";
            // 
            // lblSurnamePlayer
            // 
            this.lblSurnamePlayer.AutoSize = true;
            this.lblSurnamePlayer.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurnamePlayer.ForeColor = System.Drawing.Color.White;
            this.lblSurnamePlayer.Location = new System.Drawing.Point(58, 148);
            this.lblSurnamePlayer.Name = "lblSurnamePlayer";
            this.lblSurnamePlayer.Size = new System.Drawing.Size(104, 30);
            this.lblSurnamePlayer.TabIndex = 3;
            this.lblSurnamePlayer.Text = "PRÉNOM";
            // 
            // tbxSurname
            // 
            this.tbxSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.tbxSurname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxSurname.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSurname.ForeColor = System.Drawing.Color.White;
            this.tbxSurname.Location = new System.Drawing.Point(63, 186);
            this.tbxSurname.MaxLength = 10;
            this.tbxSurname.Name = "tbxSurname";
            this.tbxSurname.Size = new System.Drawing.Size(195, 26);
            this.tbxSurname.TabIndex = 2;
            this.tbxSurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblGamepad
            // 
            this.lblGamepad.AutoSize = true;
            this.lblGamepad.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGamepad.ForeColor = System.Drawing.Color.White;
            this.lblGamepad.Location = new System.Drawing.Point(58, 263);
            this.lblGamepad.Name = "lblGamepad";
            this.lblGamepad.Size = new System.Drawing.Size(111, 30);
            this.lblGamepad.TabIndex = 4;
            this.lblGamepad.Text = "MANETTE";
            // 
            // rbtnUseGamepad
            // 
            this.rbtnUseGamepad.AutoSize = true;
            this.rbtnUseGamepad.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.rbtnUseGamepad.ForeColor = System.Drawing.Color.White;
            this.rbtnUseGamepad.Location = new System.Drawing.Point(71, 303);
            this.rbtnUseGamepad.Name = "rbtnUseGamepad";
            this.rbtnUseGamepad.Size = new System.Drawing.Size(110, 29);
            this.rbtnUseGamepad.TabIndex = 6;
            this.rbtnUseGamepad.Text = "UTILISER";
            this.rbtnUseGamepad.UseVisualStyleBackColor = true;
            // 
            // rbtnDontUseGamepad
            // 
            this.rbtnDontUseGamepad.AutoSize = true;
            this.rbtnDontUseGamepad.Checked = true;
            this.rbtnDontUseGamepad.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnDontUseGamepad.ForeColor = System.Drawing.Color.White;
            this.rbtnDontUseGamepad.Location = new System.Drawing.Point(71, 340);
            this.rbtnDontUseGamepad.Name = "rbtnDontUseGamepad";
            this.rbtnDontUseGamepad.Size = new System.Drawing.Size(180, 29);
            this.rbtnDontUseGamepad.TabIndex = 7;
            this.rbtnDontUseGamepad.TabStop = true;
            this.rbtnDontUseGamepad.Text = "NE PAS UTILISER";
            this.rbtnDontUseGamepad.UseVisualStyleBackColor = true;
            // 
            // btnTitre
            // 
            this.btnTitre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(230)))), ((int)(((byte)(193)))));
            this.btnTitre.FlatAppearance.BorderSize = 5;
            this.btnTitre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTitre.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold);
            this.btnTitre.ForeColor = System.Drawing.Color.White;
            this.btnTitre.Location = new System.Drawing.Point(366, 101);
            this.btnTitre.Name = "btnTitre";
            this.btnTitre.Size = new System.Drawing.Size(279, 72);
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
            this.btnSinglePlayer.Location = new System.Drawing.Point(63, 419);
            this.btnSinglePlayer.Name = "btnSinglePlayer";
            this.btnSinglePlayer.Size = new System.Drawing.Size(143, 44);
            this.btnSinglePlayer.TabIndex = 9;
            this.btnSinglePlayer.Text = "JOUER";
            this.btnSinglePlayer.UseVisualStyleBackColor = false;
            this.btnSinglePlayer.Click += new System.EventHandler(this.btnSinglePlayer_Click);
            // 
            // pnlBackground
            // 
            this.pnlBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(230)))), ((int)(((byte)(193)))));
            this.pnlBackground.Location = new System.Drawing.Point(317, -2);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(371, 507);
            this.pnlBackground.TabIndex = 13;
            // 
            // pbxBack
            // 
            this.pbxBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxBack.Image = ((System.Drawing.Image)(resources.GetObject("pbxBack.Image")));
            this.pbxBack.Location = new System.Drawing.Point(10, 9);
            this.pbxBack.Name = "pbxBack";
            this.pbxBack.Size = new System.Drawing.Size(31, 33);
            this.pbxBack.TabIndex = 14;
            this.pbxBack.TabStop = false;
            this.pbxBack.Click += new System.EventHandler(this.pbxBack_Click);
            // 
            // pbxExit
            // 
            this.pbxExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(230)))), ((int)(((byte)(193)))));
            this.pbxExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxExit.Image = global::PongGame.Properties.Resources.cross;
            this.pbxExit.Location = new System.Drawing.Point(647, 7);
            this.pbxExit.Name = "pbxExit";
            this.pbxExit.Size = new System.Drawing.Size(34, 33);
            this.pbxExit.TabIndex = 12;
            this.pbxExit.TabStop = false;
            this.pbxExit.Click += new System.EventHandler(this.pbxExit_Click);
            // 
            // pbxRaquetteLogo
            // 
            this.pbxRaquetteLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(230)))), ((int)(((byte)(193)))));
            this.pbxRaquetteLogo.Image = global::PongGame.Properties.Resources.table_tennis;
            this.pbxRaquetteLogo.Location = new System.Drawing.Point(407, 200);
            this.pbxRaquetteLogo.Name = "pbxRaquetteLogo";
            this.pbxRaquetteLogo.Size = new System.Drawing.Size(196, 177);
            this.pbxRaquetteLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxRaquetteLogo.TabIndex = 11;
            this.pbxRaquetteLogo.TabStop = false;
            // 
            // LobbySolo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(688, 503);
            this.Controls.Add(this.pbxBack);
            this.Controls.Add(this.pbxExit);
            this.Controls.Add(this.pbxRaquetteLogo);
            this.Controls.Add(this.btnSinglePlayer);
            this.Controls.Add(this.btnTitre);
            this.Controls.Add(this.rbtnDontUseGamepad);
            this.Controls.Add(this.rbtnUseGamepad);
            this.Controls.Add(this.lblGamepad);
            this.Controls.Add(this.lblSurnamePlayer);
            this.Controls.Add(this.tbxSurname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.pnlBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.Label lblSurnamePlayer;
        private System.Windows.Forms.TextBox tbxSurname;
        private System.Windows.Forms.Label lblGamepad;
        private System.Windows.Forms.RadioButton rbtnUseGamepad;
        private System.Windows.Forms.RadioButton rbtnDontUseGamepad;
        private System.Windows.Forms.Button btnTitre;
        private System.Windows.Forms.Button btnSinglePlayer;
        private System.Windows.Forms.PictureBox pbxRaquetteLogo;
        private System.Windows.Forms.PictureBox pbxExit;
        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.PictureBox pbxBack;
    }
}