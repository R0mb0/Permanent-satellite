using System.Runtime.CompilerServices;

namespace SatellitePermanente
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
    private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.monitor = new System.Windows.Forms.Label();
            this.AddPoint = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DeletePoint = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Load = new System.Windows.Forms.Button();
            this.Debug = new System.Windows.Forms.Button();
            this.GrayMap = new System.Windows.Forms.Panel();
            this.pictureBoxNord = new System.Windows.Forms.PictureBox();
            this.TextBoxLatutude1 = new System.Windows.Forms.TextBox();
            this.TextBoxLatitude2 = new System.Windows.Forms.TextBox();
            this.TextBoxLongitude2 = new System.Windows.Forms.TextBox();
            this.TextBoxLongitude1 = new System.Windows.Forms.TextBox();
            this.pictureBoxPoints = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.GrayMap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPoints)).BeginInit();
            this.SuspendLayout();
            // 
            // monitor
            // 
            this.monitor.AutoSize = true;
            this.monitor.Location = new System.Drawing.Point(-3163, -143);
            this.monitor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.monitor.Name = "monitor";
            this.monitor.Size = new System.Drawing.Size(105, 25);
            this.monitor.TabIndex = 0;
            this.monitor.Text = "HomeLabel";
            // 
            // AddPoint
            // 
            this.AddPoint.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddPoint.Location = new System.Drawing.Point(13, 29);
            this.AddPoint.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AddPoint.Name = "AddPoint";
            this.AddPoint.Size = new System.Drawing.Size(123, 34);
            this.AddPoint.TabIndex = 1;
            this.AddPoint.Text = "Add Point";
            this.AddPoint.UseVisualStyleBackColor = true;
            this.AddPoint.Click += new System.EventHandler(this.AddPoint_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(13, 580);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(727, 125);
            this.label1.TabIndex = 2;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // DeletePoint
            // 
            this.DeletePoint.Font = new System.Drawing.Font("Comic Sans MS", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeletePoint.Location = new System.Drawing.Point(13, 82);
            this.DeletePoint.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DeletePoint.Name = "DeletePoint";
            this.DeletePoint.Size = new System.Drawing.Size(123, 34);
            this.DeletePoint.TabIndex = 2;
            this.DeletePoint.Text = "DELETE POINT";
            this.DeletePoint.UseVisualStyleBackColor = true;
            this.DeletePoint.Click += new System.EventHandler(this.DeletePoint_Click);
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Save.Location = new System.Drawing.Point(13, 136);
            this.Save.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(123, 34);
            this.Save.TabIndex = 3;
            this.Save.Text = "SAVE";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Load
            // 
            this.Load.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Load.Location = new System.Drawing.Point(13, 192);
            this.Load.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(123, 34);
            this.Load.TabIndex = 4;
            this.Load.Text = "LOAD";
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // Debug
            // 
            this.Debug.Location = new System.Drawing.Point(13, 247);
            this.Debug.Name = "Debug";
            this.Debug.Size = new System.Drawing.Size(123, 37);
            this.Debug.TabIndex = 5;
            this.Debug.Text = "TABLE";
            this.Debug.UseVisualStyleBackColor = true;
            this.Debug.Click += new System.EventHandler(this.Debug_Click);
            // 
            // GrayMap
            // 
            this.GrayMap.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.GrayMap.Controls.Add(this.pictureBoxNord);
            this.GrayMap.Location = new System.Drawing.Point(159, 29);
            this.GrayMap.Name = "GrayMap";
            this.GrayMap.Size = new System.Drawing.Size(938, 447);
            this.GrayMap.TabIndex = 7;
            this.GrayMap.Paint += new System.Windows.Forms.PaintEventHandler(this.GreyMap_Paint);
            // 
            // pictureBoxNord
            // 
            this.pictureBoxNord.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxNord.Name = "pictureBoxNord";
            this.pictureBoxNord.Size = new System.Drawing.Size(86, 140);
            this.pictureBoxNord.TabIndex = 0;
            this.pictureBoxNord.TabStop = false;
            // 
            // TextBoxLatutude1
            // 
            this.TextBoxLatutude1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.TextBoxLatutude1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxLatutude1.Location = new System.Drawing.Point(471, 495);
            this.TextBoxLatutude1.Name = "TextBoxLatutude1";
            this.TextBoxLatutude1.Size = new System.Drawing.Size(185, 26);
            this.TextBoxLatutude1.TabIndex = 8;
            // 
            // TextBoxLatitude2
            // 
            this.TextBoxLatitude2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.TextBoxLatitude2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxLatitude2.Location = new System.Drawing.Point(786, 495);
            this.TextBoxLatitude2.Name = "TextBoxLatitude2";
            this.TextBoxLatitude2.Size = new System.Drawing.Size(185, 26);
            this.TextBoxLatitude2.TabIndex = 8;
            // 
            // TextBoxLongitude2
            // 
            this.TextBoxLongitude2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.TextBoxLongitude2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxLongitude2.Location = new System.Drawing.Point(1111, 313);
            this.TextBoxLongitude2.Name = "TextBoxLongitude2";
            this.TextBoxLongitude2.Size = new System.Drawing.Size(219, 26);
            this.TextBoxLongitude2.TabIndex = 8;
            // 
            // TextBoxLongitude1
            // 
            this.TextBoxLongitude1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.TextBoxLongitude1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxLongitude1.Location = new System.Drawing.Point(1111, 160);
            this.TextBoxLongitude1.Name = "TextBoxLongitude1";
            this.TextBoxLongitude1.Size = new System.Drawing.Size(219, 26);
            this.TextBoxLongitude1.TabIndex = 8;
            // 
            // pictureBoxPoints
            // 
            this.pictureBoxPoints.Location = new System.Drawing.Point(767, 596);
            this.pictureBoxPoints.Name = "pictureBoxPoints";
            this.pictureBoxPoints.Size = new System.Drawing.Size(60, 125);
            this.pictureBoxPoints.TabIndex = 9;
            this.pictureBoxPoints.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(820, 608);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(138, 26);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "Normal Points";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(820, 661);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(138, 26);
            this.textBox2.TabIndex = 11;
            this.textBox2.Text = "Meeting Point";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1342, 723);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBoxPoints);
            this.Controls.Add(this.TextBoxLongitude1);
            this.Controls.Add(this.TextBoxLongitude2);
            this.Controls.Add(this.TextBoxLatitude2);
            this.Controls.Add(this.TextBoxLatutude1);
            this.Controls.Add(this.GrayMap);
            this.Controls.Add(this.Debug);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.DeletePoint);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddPoint);
            this.Controls.Add(this.monitor);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relative system of orientation to permanent satellite";
            this.GrayMap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPoints)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label monitor;
        private System.Windows.Forms.Button AddPoint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DeletePoint;
        private System.Windows.Forms.Button Save;
        private new System.Windows.Forms.Button Load;
        private System.Windows.Forms.Button Debug;
        private System.Windows.Forms.Panel GrayMap;
        private System.Windows.Forms.TextBox TextBoxLatutude1;
        private System.Windows.Forms.TextBox TextBoxLatitude2;
        private System.Windows.Forms.TextBox TextBoxLongitude2;
        private System.Windows.Forms.TextBox TextBoxLongitude1;
        private System.Windows.Forms.PictureBox pictureBoxNord;
        private System.Windows.Forms.PictureBox pictureBoxPoints;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

