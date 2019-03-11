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
            this.lblWho.Location = new System.Drawing.Point(256, 9);
            this.lblWho.Name = "lblWho";
            this.lblWho.Size = new System.Drawing.Size(35, 13);
            this.lblWho.TabIndex = 0;
            this.lblWho.Text = "label1";
            // 
            // pbxPlayer1
            // 
            this.pbxPlayer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(142)))), ((int)(((byte)(165)))));
            this.pbxPlayer1.Location = new System.Drawing.Point(9, 156);
            this.pbxPlayer1.Margin = new System.Windows.Forms.Padding(8);
            this.pbxPlayer1.Name = "pbxPlayer1";
            this.pbxPlayer1.Size = new System.Drawing.Size(18, 127);
            this.pbxPlayer1.TabIndex = 8;
            this.pbxPlayer1.TabStop = false;
            // 
            // pbxBalle
            // 
            this.pbxBalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(68)))), ((int)(((byte)(125)))));
            this.pbxBalle.Location = new System.Drawing.Point(472, 205);
            this.pbxBalle.Name = "pbxBalle";
            this.pbxBalle.Size = new System.Drawing.Size(21, 21);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 483);
            this.Controls.Add(this.pbxBalle);
            this.Controls.Add(this.pbxPlayer1);
            this.Controls.Add(this.lblWho);
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