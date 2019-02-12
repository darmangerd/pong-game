namespace PongGame
{
    partial class SoloGame
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
            this.lblPlayer2Score = new System.Windows.Forms.Label();
            this.pbxLine = new System.Windows.Forms.PictureBox();
            this.pbxPlayer1 = new System.Windows.Forms.PictureBox();
            this.pbxPlayer2 = new System.Windows.Forms.PictureBox();
            this.pbxBalle = new System.Windows.Forms.PictureBox();
            this.tmrGameTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNamePlayer1 = new System.Windows.Forms.Label();
            this.lblNamePlayer2 = new System.Windows.Forms.Label();
            this.lblPlayer1Score = new System.Windows.Forms.Label();
            this.pbxExit = new System.Windows.Forms.PictureBox();
            this.tmrStart = new System.Windows.Forms.Timer(this.components);
            this.lblStarTimer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlayer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxExit)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlayer2Score
            // 
            this.lblPlayer2Score.AutoSize = true;
            this.lblPlayer2Score.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.lblPlayer2Score.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPlayer2Score.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold);
            this.lblPlayer2Score.ForeColor = System.Drawing.Color.White;
            this.lblPlayer2Score.Location = new System.Drawing.Point(767, 80);
            this.lblPlayer2Score.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayer2Score.Name = "lblPlayer2Score";
            this.lblPlayer2Score.Size = new System.Drawing.Size(54, 62);
            this.lblPlayer2Score.TabIndex = 5;
            this.lblPlayer2Score.Text = "0";
            // 
            // pbxLine
            // 
            this.pbxLine.BackColor = System.Drawing.Color.White;
            this.pbxLine.Location = new System.Drawing.Point(707, 44);
            this.pbxLine.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbxLine.Name = "pbxLine";
            this.pbxLine.Size = new System.Drawing.Size(8, 672);
            this.pbxLine.TabIndex = 6;
            this.pbxLine.TabStop = false;
            // 
            // pbxPlayer1
            // 
            this.pbxPlayer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(142)))), ((int)(((byte)(165)))));
            this.pbxPlayer1.Location = new System.Drawing.Point(236, 320);
            this.pbxPlayer1.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.pbxPlayer1.Name = "pbxPlayer1";
            this.pbxPlayer1.Size = new System.Drawing.Size(24, 156);
            this.pbxPlayer1.TabIndex = 7;
            this.pbxPlayer1.TabStop = false;
            // 
            // pbxPlayer2
            // 
            this.pbxPlayer2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(230)))), ((int)(((byte)(193)))));
            this.pbxPlayer2.Location = new System.Drawing.Point(1159, 320);
            this.pbxPlayer2.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.pbxPlayer2.Name = "pbxPlayer2";
            this.pbxPlayer2.Size = new System.Drawing.Size(24, 156);
            this.pbxPlayer2.TabIndex = 8;
            this.pbxPlayer2.TabStop = false;
            // 
            // pbxBalle
            // 
            this.pbxBalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(68)))), ((int)(((byte)(125)))));
            this.pbxBalle.Location = new System.Drawing.Point(688, 371);
            this.pbxBalle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbxBalle.Name = "pbxBalle";
            this.pbxBalle.Size = new System.Drawing.Size(44, 39);
            this.pbxBalle.TabIndex = 9;
            this.pbxBalle.TabStop = false;
            // 
            // tmrGameTimer
            // 
            this.tmrGameTimer.Interval = 20;
            this.tmrGameTimer.Tick += new System.EventHandler(this.tmrGameTimer_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.pictureBox1.Location = new System.Drawing.Point(227, 44);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(965, 672);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.pictureBox2.Location = new System.Drawing.Point(203, 21);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1013, 714);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(142)))), ((int)(((byte)(165)))));
            this.panel1.Controls.Add(this.lblNamePlayer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(715, 754);
            this.panel1.TabIndex = 12;
            // 
            // lblNamePlayer1
            // 
            this.lblNamePlayer1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamePlayer1.ForeColor = System.Drawing.Color.White;
            this.lblNamePlayer1.Location = new System.Drawing.Point(-23, 238);
            this.lblNamePlayer1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNamePlayer1.Name = "lblNamePlayer1";
            this.lblNamePlayer1.Size = new System.Drawing.Size(217, 284);
            this.lblNamePlayer1.TabIndex = 14;
            this.lblNamePlayer1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNamePlayer1.Paint += new System.Windows.Forms.PaintEventHandler(this.lblNamePlayer1_Paint);
            // 
            // lblNamePlayer2
            // 
            this.lblNamePlayer2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamePlayer2.ForeColor = System.Drawing.Color.White;
            this.lblNamePlayer2.Location = new System.Drawing.Point(1221, 252);
            this.lblNamePlayer2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNamePlayer2.Name = "lblNamePlayer2";
            this.lblNamePlayer2.Size = new System.Drawing.Size(209, 315);
            this.lblNamePlayer2.TabIndex = 15;
            this.lblNamePlayer2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNamePlayer2.Paint += new System.Windows.Forms.PaintEventHandler(this.lblNamePlayer2_Paint);
            // 
            // lblPlayer1Score
            // 
            this.lblPlayer1Score.AutoSize = true;
            this.lblPlayer1Score.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.lblPlayer1Score.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold);
            this.lblPlayer1Score.ForeColor = System.Drawing.Color.White;
            this.lblPlayer1Score.Location = new System.Drawing.Point(593, 80);
            this.lblPlayer1Score.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayer1Score.Name = "lblPlayer1Score";
            this.lblPlayer1Score.Size = new System.Drawing.Size(54, 62);
            this.lblPlayer1Score.TabIndex = 16;
            this.lblPlayer1Score.Text = "0";
            // 
            // pbxExit
            // 
            this.pbxExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(230)))), ((int)(((byte)(193)))));
            this.pbxExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxExit.Image = global::PongGame.Properties.Resources.cross;
            this.pbxExit.Location = new System.Drawing.Point(1385, 6);
            this.pbxExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbxExit.Name = "pbxExit";
            this.pbxExit.Size = new System.Drawing.Size(45, 41);
            this.pbxExit.TabIndex = 22;
            this.pbxExit.TabStop = false;
            this.pbxExit.Click += new System.EventHandler(this.pbxExit_Click);
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
            this.lblStarTimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.lblStarTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblStarTimer.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStarTimer.ForeColor = System.Drawing.Color.White;
            this.lblStarTimer.Location = new System.Drawing.Point(648, 302);
            this.lblStarTimer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStarTimer.Name = "lblStarTimer";
            this.lblStarTimer.Size = new System.Drawing.Size(136, 159);
            this.lblStarTimer.TabIndex = 23;
            this.lblStarTimer.Text = "3";
            // 
            // SoloGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(230)))), ((int)(((byte)(193)))));
            this.ClientSize = new System.Drawing.Size(1436, 754);
            this.Controls.Add(this.lblStarTimer);
            this.Controls.Add(this.pbxExit);
            this.Controls.Add(this.lblPlayer1Score);
            this.Controls.Add(this.lblNamePlayer2);
            this.Controls.Add(this.pbxPlayer1);
            this.Controls.Add(this.pbxPlayer2);
            this.Controls.Add(this.pbxBalle);
            this.Controls.Add(this.lblPlayer2Score);
            this.Controls.Add(this.pbxLine);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SoloGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SoloGame";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SoloGame_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SoloGame_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlayer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPlayer2Score;
        private System.Windows.Forms.PictureBox pbxLine;
        private System.Windows.Forms.PictureBox pbxPlayer1;
        private System.Windows.Forms.PictureBox pbxPlayer2;
        private System.Windows.Forms.PictureBox pbxBalle;
        private System.Windows.Forms.Timer tmrGameTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNamePlayer2;
        private System.Windows.Forms.Label lblNamePlayer1;
        private System.Windows.Forms.Label lblPlayer1Score;
        private System.Windows.Forms.PictureBox pbxExit;
        private System.Windows.Forms.Timer tmrStart;
        private System.Windows.Forms.Label lblStarTimer;
    }
}