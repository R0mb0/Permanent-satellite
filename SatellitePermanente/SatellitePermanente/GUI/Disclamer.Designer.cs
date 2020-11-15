namespace SatellitePermanente.GUI
{
    partial class Disclamer
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
            this.DisclamerText = new System.Windows.Forms.Label();
            this.ButtonYes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DisclamerText
            // 
            this.DisclamerText.AutoSize = true;
            this.DisclamerText.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DisclamerText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DisclamerText.Location = new System.Drawing.Point(12, 50);
            this.DisclamerText.Name = "DisclamerText";
            this.DisclamerText.Size = new System.Drawing.Size(418, 30);
            this.DisclamerText.TabIndex = 0;
            this.DisclamerText.Text = "DO YOU WANT DELETE THIS POINT?";
            // 
            // ButtonYes
            // 
            this.ButtonYes.Location = new System.Drawing.Point(137, 83);
            this.ButtonYes.Name = "ButtonYes";
            this.ButtonYes.Size = new System.Drawing.Size(136, 57);
            this.ButtonYes.TabIndex = 1;
            this.ButtonYes.Text = "YES";
            this.ButtonYes.UseVisualStyleBackColor = true;
            this.ButtonYes.Click += new System.EventHandler(this.ButtonYes_Click);
            // 
            // Disclamer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(430, 153);
            this.Controls.Add(this.ButtonYes);
            this.Controls.Add(this.DisclamerText);
            this.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Disclamer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DISCLAMER";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DisclamerText;
        private System.Windows.Forms.Button ButtonYes;
    }
}