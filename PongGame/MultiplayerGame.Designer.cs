namespace PongGame
{
    partial class MultiplayerGame
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
            this.components = new System.ComponentModel.Container();
            this.lblNamePlayer = new System.Windows.Forms.Label();
            this.pbxPlayer1 = new System.Windows.Forms.PictureBox();
            this.pbxBalle = new System.Windows.Forms.PictureBox();
            this.tmrGameTimer = new System.Windows.Forms.Timer(this.components);
            this.tmrStart = new System.Windows.Forms.Timer(this.components);
            this.lblStarTimer = new System.Windows.Forms.Label();
            this.lblSetPlayer = new System.Windows.Forms.Label();
            this.lblPlayerScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBalle)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNamePlayer
            // 
            this.lblNamePlayer.AutoSize = true;
            this.lblNamePlayer.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamePlayer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(14)))), ((int)(((byte)(98)))));
            this.lblNamePlayer.Location = new System.Drawing.Point(180, 437);
            this.lblNamePlayer.Name = "lblNamePlayer";
            this.lblNamePlayer.Size = new System.Drawing.Size(93, 37);
            this.lblNamePlayer.TabIndex = 0;
            this.lblNamePlayer.Text = "Name";
            // 
            // pbxPlayer1
            // 
            this.pbxPlayer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(137)))), ((int)(((byte)(250)))));
            this.pbxPlayer1.Location = new System.Drawing.Point(9, 171);
            this.pbxPlayer1.Margin = new System.Windows.Forms.Padding(8);
            this.pbxPlayer1.Name = "pbxPlayer1";
            this.pbxPlayer1.Size = new System.Drawing.Size(18, 127);
            this.pbxPlayer1.TabIndex = 8;
            this.pbxPlayer1.TabStop = false;
            // 
            // pbxBalle
            // 
            this.pbxBalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(68)))), ((int)(((byte)(125)))));
            this.pbxBalle.Location = new System.Drawing.Point(516, 235);
            this.pbxBalle.Name = "pbxBalle";
            this.pbxBalle.Size = new System.Drawing.Size(21, 21);
            this.pbxBalle.TabIndex = 10;
            this.pbxBalle.TabStop = false;
            // 
            // tmrGameTimer
            // 
            this.tmrGameTimer.Interval = 20;
            this.tmrGameTimer.Tick += new System.EventHandler(this.tmrGameTimer_Tick);
            // 
            // tmrStart
            // 
            this.tmrStart.Enabled = true;
            this.tmrStart.Interval = 1000;
            this.tmrStart.Tick += new System.EventHandler(this.tmrStart_Tick);
            // 
            // lblStarTimer
            // 
            this.lblStarTimer.AutoSize = true;
            this.lblStarTimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.lblStarTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblStarTimer.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStarTimer.ForeColor = System.Drawing.Color.White;
            this.lblStarTimer.Location = new System.Drawing.Point(172, 192);
            this.lblStarTimer.Name = "lblStarTimer";
            this.lblStarTimer.Size = new System.Drawing.Size(272, 86);
            this.lblStarTimer.TabIndex = 24;
            this.lblStarTimer.Text = "Waiting";
            this.lblStarTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSetPlayer
            // 
            this.lblSetPlayer.AutoSize = true;
            this.lblSetPlayer.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetPlayer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(14)))), ((int)(((byte)(98)))));
            this.lblSetPlayer.Location = new System.Drawing.Point(331, 438);
            this.lblSetPlayer.Name = "lblSetPlayer";
            this.lblSetPlayer.Size = new System.Drawing.Size(33, 37);
            this.lblSetPlayer.TabIndex = 26;
            this.lblSetPlayer.Text = "0";
            // 
            // lblPlayerScore
            // 
            this.lblPlayerScore.AutoSize = true;
            this.lblPlayerScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.lblPlayerScore.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold);
            this.lblPlayerScore.ForeColor = System.Drawing.Color.White;
            this.lblPlayerScore.Location = new System.Drawing.Point(275, 8);
            this.lblPlayerScore.Name = "lblPlayerScore";
            this.lblPlayerScore.Size = new System.Drawing.Size(43, 50);
            this.lblPlayerScore.TabIndex = 27;
            this.lblPlayerScore.Text = "0";
            // 
            // MultiplayerGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(617, 483);
            this.Controls.Add(this.lblPlayerScore);
            this.Controls.Add(this.lblSetPlayer);
            this.Controls.Add(this.lblStarTimer);
            this.Controls.Add(this.pbxBalle);
            this.Controls.Add(this.pbxPlayer1);
            this.Controls.Add(this.lblNamePlayer);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "MultiplayerGame";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "MultiplayerGame";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MultiplayerGame_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MultiplayerGame_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNamePlayer;
        private System.Windows.Forms.PictureBox pbxPlayer1;
        private System.Windows.Forms.PictureBox pbxBalle;
        private System.Windows.Forms.Timer tmrGameTimer;
        private System.Windows.Forms.Timer tmrStart;
        private System.Windows.Forms.Label lblStarTimer;
        private System.Windows.Forms.Label lblSetPlayer;
        private System.Windows.Forms.Label lblPlayerScore;
    }
}