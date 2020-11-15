namespace SatellitePermanente.GUI
{
    partial class Debug
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
            this.Points = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Latitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Longitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateAndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Angle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Altitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MeetingPoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nodes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PointA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PointB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Distance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeDifference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Speed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AltitudeDifference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonRefresh = new System.Windows.Forms.Button();
            this.DataGridNodes = new System.Windows.Forms.DataGridView();
            this.DataGridPoints = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridNodes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridPoints)).BeginInit();
            this.SuspendLayout();
            // 
            // Points
            // 
            this.Points.HeaderText = "POINTS:";
            this.Points.MinimumWidth = 8;
            this.Points.Name = "Points";
            this.Points.ReadOnly = true;
            this.Points.Width = 150;
            // 
            // Latitude
            // 
            this.Latitude.HeaderText = "LATITUDE:";
            this.Latitude.MinimumWidth = 8;
            this.Latitude.Name = "Latitude";
            this.Latitude.ReadOnly = true;
            this.Latitude.Width = 150;
            // 
            // Longitude
            // 
            this.Longitude.HeaderText = "LONGITUDE:";
            this.Longitude.MinimumWidth = 8;
            this.Longitude.Name = "Longitude";
            this.Longitude.ReadOnly = true;
            this.Longitude.Width = 150;
            // 
            // DateAndTime
            // 
            this.DateAndTime.HeaderText = "DATE AND TIME:";
            this.DateAndTime.MinimumWidth = 8;
            this.DateAndTime.Name = "DateAndTime";
            this.DateAndTime.ReadOnly = true;
            this.DateAndTime.Width = 150;
            // 
            // Angle
            // 
            this.Angle.HeaderText = "ANGLE:";
            this.Angle.MinimumWidth = 8;
            this.Angle.Name = "Angle";
            this.Angle.ReadOnly = true;
            this.Angle.Width = 150;
            // 
            // Altitude
            // 
            this.Altitude.HeaderText = "ALTITUDE:";
            this.Altitude.MinimumWidth = 8;
            this.Altitude.Name = "Altitude";
            this.Altitude.ReadOnly = true;
            this.Altitude.Width = 150;
            // 
            // MeetingPoint
            // 
            this.MeetingPoint.HeaderText = "MEETING POINT:";
            this.MeetingPoint.MinimumWidth = 8;
            this.MeetingPoint.Name = "MeetingPoint";
            this.MeetingPoint.ReadOnly = true;
            this.MeetingPoint.Width = 150;
            // 
            // Nodes
            // 
            this.Nodes.HeaderText = "NODES:";
            this.Nodes.MinimumWidth = 8;
            this.Nodes.Name = "Nodes";
            this.Nodes.ReadOnly = true;
            this.Nodes.Width = 150;
            // 
            // PointA
            // 
            this.PointA.HeaderText = "POINT A:";
            this.PointA.MinimumWidth = 8;
            this.PointA.Name = "PointA";
            this.PointA.ReadOnly = true;
            this.PointA.Width = 150;
            // 
            // PointB
            // 
            this.PointB.HeaderText = "POINT B:";
            this.PointB.MinimumWidth = 8;
            this.PointB.Name = "PointB";
            this.PointB.ReadOnly = true;
            this.PointB.Width = 150;
            // 
            // Distance
            // 
            this.Distance.HeaderText = "DISTANCE:";
            this.Distance.MinimumWidth = 8;
            this.Distance.Name = "Distance";
            this.Distance.ReadOnly = true;
            this.Distance.Width = 150;
            // 
            // Direction
            // 
            this.Direction.HeaderText = "DIRECTION:";
            this.Direction.MinimumWidth = 8;
            this.Direction.Name = "Direction";
            this.Direction.ReadOnly = true;
            this.Direction.Width = 150;
            // 
            // TimeDifference
            // 
            this.TimeDifference.HeaderText = "TIME DIFFERENCE:";
            this.TimeDifference.MinimumWidth = 8;
            this.TimeDifference.Name = "TimeDifference";
            this.TimeDifference.ReadOnly = true;
            this.TimeDifference.Width = 150;
            // 
            // Speed
            // 
            this.Speed.HeaderText = "SPEED:";
            this.Speed.MinimumWidth = 8;
            this.Speed.Name = "Speed";
            this.Speed.ReadOnly = true;
            this.Speed.Width = 150;
            // 
            // AltitudeDifference
            // 
            this.AltitudeDifference.HeaderText = "ALTITUDE DIFFERENCE:";
            this.AltitudeDifference.MinimumWidth = 8;
            this.AltitudeDifference.Name = "AltitudeDifference";
            this.AltitudeDifference.ReadOnly = true;
            this.AltitudeDifference.Width = 150;
            // 
            // ButtonRefresh
            // 
            this.ButtonRefresh.Location = new System.Drawing.Point(1135, 55);
            this.ButtonRefresh.Name = "ButtonRefresh";
            this.ButtonRefresh.Size = new System.Drawing.Size(147, 124);
            this.ButtonRefresh.TabIndex = 2;
            this.ButtonRefresh.Text = "REFRESH";
            this.ButtonRefresh.UseVisualStyleBackColor = true;
            this.ButtonRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // DataGridNodes
            // 
            this.DataGridNodes.AllowUserToAddRows = false;
            this.DataGridNodes.AllowUserToDeleteRows = false;
            this.DataGridNodes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridNodes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nodes,
            this.PointA,
            this.PointB,
            this.Distance,
            this.Direction,
            this.TimeDifference,
            this.Speed,
            this.AltitudeDifference});
            this.DataGridNodes.Location = new System.Drawing.Point(12, 243);
            this.DataGridNodes.Name = "DataGridNodes";
            this.DataGridNodes.ReadOnly = true;
            this.DataGridNodes.RowHeadersWidth = 62;
            this.DataGridNodes.Size = new System.Drawing.Size(1270, 225);
            this.DataGridNodes.TabIndex = 1;
            this.DataGridNodes.Text = "dataGridView1";
            // 
            // DataGridPoints
            // 
            this.DataGridPoints.AllowUserToAddRows = false;
            this.DataGridPoints.AllowUserToDeleteRows = false;
            this.DataGridPoints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridPoints.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Points,
            this.Latitude,
            this.Longitude,
            this.DateAndTime,
            this.Angle,
            this.Altitude,
            this.MeetingPoint});
            this.DataGridPoints.Location = new System.Drawing.Point(12, 12);
            this.DataGridPoints.Name = "DataGridPoints";
            this.DataGridPoints.ReadOnly = true;
            this.DataGridPoints.RowHeadersWidth = 62;
            this.DataGridPoints.Size = new System.Drawing.Size(1117, 225);
            this.DataGridPoints.TabIndex = 0;
            this.DataGridPoints.Text = "dataGridView1";
            // 
            // Debug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1289, 483);
            this.Controls.Add(this.ButtonRefresh);
            this.Controls.Add(this.DataGridNodes);
            this.Controls.Add(this.DataGridPoints);
            this.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Debug";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Debug";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridNodes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridPoints)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn Points;
        private System.Windows.Forms.DataGridViewTextBoxColumn Latitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn Longitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateAndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Angle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Altitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn MeetingPoint;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nodes;
        private System.Windows.Forms.DataGridViewTextBoxColumn PointA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PointB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Distance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direction;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeDifference;
        private System.Windows.Forms.DataGridViewTextBoxColumn Speed;
        private System.Windows.Forms.DataGridViewTextBoxColumn AltitudeDifference;
        private System.Windows.Forms.Button ButtonRefresh;
        private System.Windows.Forms.DataGridView DataGridNodes;
        private System.Windows.Forms.DataGridView DataGridPoints;
    }
}