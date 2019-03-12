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
            this.lblWho = new System.Windows.Forms.Label();
            this.pbxPlayer1 = new System.Windows.Forms.PictureBox();
            this.pbxBalle = new System.Windows.Forms.PictureBox();
            this.tmrGameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBalle)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWho
            // 
            this.lblWho.AutoSize = true;
            this.lblWho.Location = new System.Drawing.Point(341, 11);
            this.lblWho.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWho.Name = "lblWho";
            this.lblWho.Size = new System.Drawing.Size(46, 17);
            this.lblWho.TabIndex = 0;
            this.lblWho.Text = "label1";
            // 
            // pbxPlayer1
            // 
            this.pbxPlayer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(142)))), ((int)(((byte)(165)))));
            this.pbxPlayer1.Location = new System.Drawing.Point(12, 192);
            this.pbxPlayer1.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.pbxPlayer1.Name = "pbxPlayer1";
            this.pbxPlayer1.Size = new System.Drawing.Size(24, 156);
            this.pbxPlayer1.TabIndex = 8;
            this.pbxPlayer1.TabStop = false;
            // 
            // pbxBalle
            // 
            this.pbxBalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(68)))), ((int)(((byte)(125)))));
            this.pbxBalle.Location = new System.Drawing.Point(629, 252);
            this.pbxBalle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbxBalle.Name = "pbxBalle";
            this.pbxBalle.Size = new System.Drawing.Size(28, 26);
            this.pbxBalle.TabIndex = 10;
            this.pbxBalle.TabStop = false;
            // 
            // tmrGameTimer
            // 
            this.tmrGameTimer.Enabled = true;
            this.tmrGameTimer.Interval = 20;
            this.tmrGameTimer.Tick += new System.EventHandler(this.tmrGameTimer_Tick);
            // 
            // MultiplayerGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 594);
            this.Controls.Add(this.pbxBalle);
            this.Controls.Add(this.pbxPlayer1);
            this.Controls.Add(this.lblWho);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MultiplayerGame";
            this.Text = "MultiplayerGame";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MultiplayerGame_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MultiplayerGame_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWho;
        private System.Windows.Forms.PictureBox pbxPlayer1;
        private System.Windows.Forms.PictureBox pbxBalle;
        private System.Windows.Forms.Timer tmrGameTimer;
    }
}