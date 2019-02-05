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
            this.btnTitre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTitre
            // 
            this.btnTitre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnTitre.FlatAppearance.BorderSize = 5;
            this.btnTitre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTitre.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold);
            this.btnTitre.ForeColor = System.Drawing.Color.White;
            this.btnTitre.Location = new System.Drawing.Point(295, 12);
            this.btnTitre.Name = "btnTitre";
            this.btnTitre.Size = new System.Drawing.Size(192, 66);
            this.btnTitre.TabIndex = 9;
            this.btnTitre.Text = "GAME";
            this.btnTitre.UseVisualStyleBackColor = false;
            // 
            // SoloGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(841, 482);
            this.Controls.Add(this.btnTitre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SoloGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SoloGame";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTitre;
    }
}