namespace SatellitePermanente.GUI
{
    partial class DeletePoint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeletePoint));
            this.ButtonDelette = new System.Windows.Forms.Button();
            this.ButtonRefresh = new System.Windows.Forms.Button();
            this.Points = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Names = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridPoints = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridPoints)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonDelette
            // 
            this.ButtonDelette.Location = new System.Drawing.Point(360, 320);
            this.ButtonDelette.Name = "ButtonDelette";
            this.ButtonDelette.Size = new System.Drawing.Size(151, 115);
            this.ButtonDelette.TabIndex = 2;
            this.ButtonDelette.Text = "DELETE";
            this.ButtonDelette.UseVisualStyleBackColor = true;
            this.ButtonDelette.Click += new System.EventHandler(this.ButtonDelette_Click);
            // 
            // ButtonRefresh
            // 
            this.ButtonRefresh.Location = new System.Drawing.Point(360, 141);
            this.ButtonRefresh.Name = "ButtonRefresh";
            this.ButtonRefresh.Size = new System.Drawing.Size(151, 115);
            this.ButtonRefresh.TabIndex = 3;
            this.ButtonRefresh.Text = "REFRESH";
            this.ButtonRefresh.UseVisualStyleBackColor = true;
            this.ButtonRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // Points
            // 
            this.Points.Frozen = true;
            this.Points.HeaderText = "POINTS:";
            this.Points.MinimumWidth = 8;
            this.Points.Name = "Points";
            this.Points.ReadOnly = true;
            this.Points.Width = 150;
            // 
            // Names
            // 
            this.Names.Frozen = true;
            this.Names.HeaderText = "NAMES";
            this.Names.MinimumWidth = 8;
            this.Names.Name = "Names";
            this.Names.ReadOnly = true;
            this.Names.Width = 150;
            // 
            // DataGridPoints
            // 
            this.DataGridPoints.AllowUserToAddRows = false;
            this.DataGridPoints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridPoints.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Points,
            this.Names});
            this.DataGridPoints.Location = new System.Drawing.Point(12, 13);
            this.DataGridPoints.Name = "DataGridPoints";
            this.DataGridPoints.ReadOnly = true;
            this.DataGridPoints.RowHeadersWidth = 62;
            this.DataGridPoints.Size = new System.Drawing.Size(335, 714);
            this.DataGridPoints.TabIndex = 1;
            this.DataGridPoints.Text = "dataGridView1";
            // 
            // DeletePoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(522, 740);
            this.Controls.Add(this.DataGridPoints);
            this.Controls.Add(this.ButtonRefresh);
            this.Controls.Add(this.ButtonDelette);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "DeletePoint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DELETE POINT";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridPoints)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ButtonDelette;
        private System.Windows.Forms.Button ButtonRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Points;
        private System.Windows.Forms.DataGridView DataGridPoints;
        private System.Windows.Forms.DataGridViewTextBoxColumn Names;
    }
}