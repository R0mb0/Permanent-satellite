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
            this.GreyMap = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // monitor
            // 
            this.monitor.AutoSize = true;
            this.monitor.Location = new System.Drawing.Point(-3451, -132);
            this.monitor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.monitor.Name = "monitor";
            this.monitor.Size = new System.Drawing.Size(115, 23);
            this.monitor.TabIndex = 0;
            this.monitor.Text = "HomeLabel";
            // 
            // AddPoint
            // 
            this.AddPoint.Font = new System.Drawing.Font("Showcard Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddPoint.Location = new System.Drawing.Point(14, 27);
            this.AddPoint.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AddPoint.Name = "AddPoint";
            this.AddPoint.Size = new System.Drawing.Size(134, 31);
            this.AddPoint.TabIndex = 1;
            this.AddPoint.Text = "Add Point";
            this.AddPoint.UseVisualStyleBackColor = true;
            this.AddPoint.Click += new System.EventHandler(this.AddPoint_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(14, 496);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(816, 115);
            this.label1.TabIndex = 2;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // DeletePoint
            // 
            this.DeletePoint.Font = new System.Drawing.Font("Showcard Gothic", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeletePoint.Location = new System.Drawing.Point(14, 75);
            this.DeletePoint.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DeletePoint.Name = "DeletePoint";
            this.DeletePoint.Size = new System.Drawing.Size(134, 31);
            this.DeletePoint.TabIndex = 3;
            this.DeletePoint.Text = "DELETE POINT";
            this.DeletePoint.UseVisualStyleBackColor = true;
            this.DeletePoint.Click += new System.EventHandler(this.DeletePoint_Click);
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Save.Location = new System.Drawing.Point(14, 125);
            this.Save.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(134, 31);
            this.Save.TabIndex = 4;
            this.Save.Text = "SAVE";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Load
            // 
            this.Load.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Load.Location = new System.Drawing.Point(14, 177);
            this.Load.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(134, 31);
            this.Load.TabIndex = 5;
            this.Load.Text = "LOAD";
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // Debug
            // 
            this.Debug.Location = new System.Drawing.Point(14, 227);
            this.Debug.Name = "Debug";
            this.Debug.Size = new System.Drawing.Size(134, 34);
            this.Debug.TabIndex = 6;
            this.Debug.Text = "DEBUG";
            this.Debug.UseVisualStyleBackColor = true;
            this.Debug.Click += new System.EventHandler(this.Debug_Click);
            // 
            // GreyMap
            // 
            this.GreyMap.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.GreyMap.Location = new System.Drawing.Point(173, 27);
            this.GreyMap.Name = "GreyMap";
            this.GreyMap.Size = new System.Drawing.Size(942, 456);
            this.GreyMap.TabIndex = 7;
            this.GreyMap.Paint += new System.Windows.Forms.PaintEventHandler(this.GreyMap_Paint);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1139, 620);
            this.Controls.Add(this.GreyMap);
            this.Controls.Add(this.Debug);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.DeletePoint);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddPoint);
            this.Controls.Add(this.monitor);
            this.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relative system of orientation to permanent satellite";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label monitor;
        private System.Windows.Forms.Button AddPoint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DeletePoint;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Load;
        private System.Windows.Forms.Button Debug;
        private System.Windows.Forms.Panel GreyMap;
    }
}

