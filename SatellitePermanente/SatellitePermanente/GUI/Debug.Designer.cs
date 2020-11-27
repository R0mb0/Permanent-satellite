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
            this.ButtonRefresh = new System.Windows.Forms.Button();
            this.Nodes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PointA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamePointA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PointB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamePointB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Distance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeDifference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Speed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AltitudeDifference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridNodes = new System.Windows.Forms.DataGridView();
            this.Points = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamesPoints = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Latitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Longitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateAndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Angle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Altitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MeetingPoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridPoints = new System.Windows.Forms.DataGridView();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxLatitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minLatitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxLongitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minLongitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridCoordinates = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridNodes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridPoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCoordinates)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonRefresh
            // 
            this.ButtonRefresh.Location = new System.Drawing.Point(896, 12);
            this.ButtonRefresh.Name = "ButtonRefresh";
            this.ButtonRefresh.Size = new System.Drawing.Size(147, 124);
            this.ButtonRefresh.TabIndex = 2;
            this.ButtonRefresh.Text = "REFRESH";
            this.ButtonRefresh.UseVisualStyleBackColor = true;
            this.ButtonRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // Nodes
            // 
            this.Nodes.Frozen = true;
            this.Nodes.HeaderText = "NODES:";
            this.Nodes.MinimumWidth = 8;
            this.Nodes.Name = "Nodes";
            this.Nodes.ReadOnly = true;
            this.Nodes.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Nodes.Width = 150;
            // 
            // PointA
            // 
            this.PointA.Frozen = true;
            this.PointA.HeaderText = "POINT A:";
            this.PointA.MinimumWidth = 8;
            this.PointA.Name = "PointA";
            this.PointA.ReadOnly = true;
            this.PointA.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PointA.Width = 150;
            // 
            // NamePointA
            // 
            this.NamePointA.Frozen = true;
            this.NamePointA.HeaderText = "NAMES OF POINTS A:";
            this.NamePointA.MinimumWidth = 8;
            this.NamePointA.Name = "NamePointA";
            this.NamePointA.ReadOnly = true;
            this.NamePointA.Width = 150;
            // 
            // PointB
            // 
            this.PointB.Frozen = true;
            this.PointB.HeaderText = "POINT B:";
            this.PointB.MinimumWidth = 8;
            this.PointB.Name = "PointB";
            this.PointB.ReadOnly = true;
            this.PointB.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PointB.Width = 150;
            // 
            // NamePointB
            // 
            this.NamePointB.Frozen = true;
            this.NamePointB.HeaderText = "NAMES OF POINTD B";
            this.NamePointB.MinimumWidth = 8;
            this.NamePointB.Name = "NamePointB";
            this.NamePointB.ReadOnly = true;
            this.NamePointB.Width = 150;
            // 
            // Distance
            // 
            this.Distance.HeaderText = "DISTANCE:";
            this.Distance.MinimumWidth = 8;
            this.Distance.Name = "Distance";
            this.Distance.ReadOnly = true;
            this.Distance.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Distance.Width = 150;
            // 
            // Direction
            // 
            this.Direction.HeaderText = "DIRECTION:";
            this.Direction.MinimumWidth = 8;
            this.Direction.Name = "Direction";
            this.Direction.ReadOnly = true;
            this.Direction.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Direction.Width = 150;
            // 
            // TimeDifference
            // 
            this.TimeDifference.HeaderText = "TIME DIFFERENCE:";
            this.TimeDifference.MinimumWidth = 8;
            this.TimeDifference.Name = "TimeDifference";
            this.TimeDifference.ReadOnly = true;
            this.TimeDifference.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TimeDifference.Width = 150;
            // 
            // Speed
            // 
            this.Speed.HeaderText = "SPEED:";
            this.Speed.MinimumWidth = 8;
            this.Speed.Name = "Speed";
            this.Speed.ReadOnly = true;
            this.Speed.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Speed.Width = 150;
            // 
            // AltitudeDifference
            // 
            this.AltitudeDifference.HeaderText = "ALTITUDE DIFFERENCE:";
            this.AltitudeDifference.MinimumWidth = 8;
            this.AltitudeDifference.Name = "AltitudeDifference";
            this.AltitudeDifference.ReadOnly = true;
            this.AltitudeDifference.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AltitudeDifference.Width = 150;
            // 
            // DataGridNodes
            // 
            this.DataGridNodes.AllowUserToAddRows = false;
            this.DataGridNodes.AllowUserToDeleteRows = false;
            this.DataGridNodes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridNodes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nodes,
            this.PointA,
            this.NamePointA,
            this.PointB,
            this.NamePointB,
            this.Distance,
            this.Direction,
            this.TimeDifference,
            this.Speed,
            this.AltitudeDifference});
            this.DataGridNodes.Location = new System.Drawing.Point(19, 389);
            this.DataGridNodes.Name = "DataGridNodes";
            this.DataGridNodes.ReadOnly = true;
            this.DataGridNodes.RowHeadersWidth = 62;
            this.DataGridNodes.Size = new System.Drawing.Size(1571, 225);
            this.DataGridNodes.TabIndex = 1;
            this.DataGridNodes.Text = "dataGridView1";
            // 
            // Points
            // 
            this.Points.Frozen = true;
            this.Points.HeaderText = "POINTS:";
            this.Points.MinimumWidth = 8;
            this.Points.Name = "Points";
            this.Points.ReadOnly = true;
            this.Points.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Points.Width = 150;
            // 
            // NamesPoints
            // 
            this.NamesPoints.Frozen = true;
            this.NamesPoints.HeaderText = "POINTS NAMES:";
            this.NamesPoints.MinimumWidth = 8;
            this.NamesPoints.Name = "NamesPoints";
            this.NamesPoints.ReadOnly = true;
            this.NamesPoints.Width = 150;
            // 
            // Latitude
            // 
            this.Latitude.HeaderText = "LATITUDE:";
            this.Latitude.MinimumWidth = 8;
            this.Latitude.Name = "Latitude";
            this.Latitude.ReadOnly = true;
            this.Latitude.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Latitude.Width = 150;
            // 
            // Longitude
            // 
            this.Longitude.HeaderText = "LONGITUDE:";
            this.Longitude.MinimumWidth = 8;
            this.Longitude.Name = "Longitude";
            this.Longitude.ReadOnly = true;
            this.Longitude.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Longitude.Width = 150;
            // 
            // DateAndTime
            // 
            this.DateAndTime.HeaderText = "DATE AND TIME:";
            this.DateAndTime.MinimumWidth = 8;
            this.DateAndTime.Name = "DateAndTime";
            this.DateAndTime.ReadOnly = true;
            this.DateAndTime.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DateAndTime.Width = 150;
            // 
            // Angle
            // 
            this.Angle.HeaderText = "ANGLE:";
            this.Angle.MinimumWidth = 8;
            this.Angle.Name = "Angle";
            this.Angle.ReadOnly = true;
            this.Angle.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Angle.Width = 150;
            // 
            // Altitude
            // 
            this.Altitude.HeaderText = "ALTITUDE:";
            this.Altitude.MinimumWidth = 8;
            this.Altitude.Name = "Altitude";
            this.Altitude.ReadOnly = true;
            this.Altitude.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Altitude.Width = 150;
            // 
            // MeetingPoint
            // 
            this.MeetingPoint.HeaderText = "MEETING POINT:";
            this.MeetingPoint.MinimumWidth = 8;
            this.MeetingPoint.Name = "MeetingPoint";
            this.MeetingPoint.ReadOnly = true;
            this.MeetingPoint.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MeetingPoint.Width = 150;
            // 
            // DataGridPoints
            // 
            this.DataGridPoints.AllowUserToAddRows = false;
            this.DataGridPoints.AllowUserToDeleteRows = false;
            this.DataGridPoints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridPoints.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Points,
            this.NamesPoints,
            this.Latitude,
            this.Longitude,
            this.DateAndTime,
            this.Angle,
            this.Altitude,
            this.MeetingPoint});
            this.DataGridPoints.Location = new System.Drawing.Point(19, 158);
            this.DataGridPoints.Name = "DataGridPoints";
            this.DataGridPoints.ReadOnly = true;
            this.DataGridPoints.RowHeadersWidth = 62;
            this.DataGridPoints.Size = new System.Drawing.Size(1267, 225);
            this.DataGridPoints.TabIndex = 0;
            this.DataGridPoints.Text = "dataGridView1";
            // 
            // Status
            // 
            this.Status.HeaderText = "STATUS:";
            this.Status.MinimumWidth = 8;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 150;
            // 
            // maxLatitude
            // 
            this.maxLatitude.HeaderText = "MAX LATITUDE:";
            this.maxLatitude.MinimumWidth = 8;
            this.maxLatitude.Name = "maxLatitude";
            this.maxLatitude.ReadOnly = true;
            this.maxLatitude.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.maxLatitude.Width = 150;
            // 
            // minLatitude
            // 
            this.minLatitude.HeaderText = "MIN LATITUDE:";
            this.minLatitude.MinimumWidth = 8;
            this.minLatitude.Name = "minLatitude";
            this.minLatitude.ReadOnly = true;
            this.minLatitude.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.minLatitude.Width = 150;
            // 
            // maxLongitude
            // 
            this.maxLongitude.HeaderText = "MAX LONGITUDE:";
            this.maxLongitude.MinimumWidth = 8;
            this.maxLongitude.Name = "maxLongitude";
            this.maxLongitude.ReadOnly = true;
            this.maxLongitude.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.maxLongitude.Width = 150;
            // 
            // minLongitude
            // 
            this.minLongitude.HeaderText = "MIX LONGITUDE:";
            this.minLongitude.MinimumWidth = 8;
            this.minLongitude.Name = "minLongitude";
            this.minLongitude.ReadOnly = true;
            this.minLongitude.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.minLongitude.Width = 150;
            // 
            // Debug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1599, 625);
            // 
            // DataGridCoordinates
            // 
            this.DataGridCoordinates.AllowUserToAddRows = false;
            this.DataGridCoordinates.AllowUserToDeleteRows = false;
            this.DataGridCoordinates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridCoordinates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Status,
            this.maxLatitude,
            this.minLatitude,
            this.maxLongitude,
            this.minLongitude});
            this.DataGridCoordinates.Location = new System.Drawing.Point(19, 12);
            this.DataGridCoordinates.Name = "DataGridCoordinates";
            this.DataGridCoordinates.ReadOnly = true;
            this.DataGridCoordinates.RowHeadersWidth = 62;
            this.DataGridCoordinates.Size = new System.Drawing.Size(818, 140);
            this.DataGridCoordinates.TabIndex = 3;
            this.DataGridCoordinates.Text = "dataGridView1";
            this.Controls.Add(this.DataGridCoordinates);
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
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCoordinates)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ButtonRefresh;
        private System.Windows.Forms.DataGridView DataGridNodes;
        private System.Windows.Forms.DataGridView DataGridPoints;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nodes;
        private System.Windows.Forms.DataGridViewTextBoxColumn PointA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamePointA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PointB;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamePointB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Distance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direction;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeDifference;
        private System.Windows.Forms.DataGridViewTextBoxColumn Speed;
        private System.Windows.Forms.DataGridViewTextBoxColumn AltitudeDifference;
        private System.Windows.Forms.DataGridViewTextBoxColumn Points;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamesPoints;
        private System.Windows.Forms.DataGridViewTextBoxColumn Latitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn Longitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateAndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Angle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Altitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn MeetingPoint;
        private System.Windows.Forms.DataGridView DataGridCoordinates;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxLatitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn minLatitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxLongitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn minLongitude;
    }
}