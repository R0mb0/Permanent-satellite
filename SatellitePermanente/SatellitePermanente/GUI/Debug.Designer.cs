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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Debug));
            this.ButtonRefresh = new System.Windows.Forms.Button();
            this.MeetingPoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Altitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Angle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateAndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Longitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Latitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamesPoints = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Points = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridPoints = new System.Windows.Forms.DataGridView();
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
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxLatitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minLatitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxLongitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minLongitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridCoordinates = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridPoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridNodes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCoordinates)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonRefresh
            // 
            this.ButtonRefresh.Location = new System.Drawing.Point(1175, 30);
            this.ButtonRefresh.Name = "ButtonRefresh";
            this.ButtonRefresh.Size = new System.Drawing.Size(135, 135);
            this.ButtonRefresh.TabIndex = 2;
            this.ButtonRefresh.Text = "REFRESH";
            this.ButtonRefresh.UseVisualStyleBackColor = true;
            this.ButtonRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // MeetingPoint
            // 
            this.MeetingPoint.HeaderText = "MEETING POINT:";
            this.MeetingPoint.MinimumWidth = 8;
            this.MeetingPoint.Name = "MeetingPoint";
            this.MeetingPoint.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MeetingPoint.Width = 150;
            // 
            // Altitude
            // 
            this.Altitude.HeaderText = "ALTITUDE:";
            this.Altitude.MinimumWidth = 8;
            this.Altitude.Name = "Altitude";
            this.Altitude.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Altitude.Width = 150;
            // 
            // Angle
            // 
            this.Angle.HeaderText = "ANGLE:";
            this.Angle.MinimumWidth = 8;
            this.Angle.Name = "Angle";
            this.Angle.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Angle.Width = 150;
            // 
            // DateAndTime
            // 
            this.DateAndTime.HeaderText = "DATE AND TIME:";
            this.DateAndTime.MinimumWidth = 8;
            this.DateAndTime.Name = "DateAndTime";
            this.DateAndTime.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DateAndTime.Width = 150;
            // 
            // Longitude
            // 
            this.Longitude.HeaderText = "LONGITUDE:";
            this.Longitude.MinimumWidth = 8;
            this.Longitude.Name = "Longitude";
            this.Longitude.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Longitude.Width = 150;
            // 
            // Latitude
            // 
            this.Latitude.HeaderText = "LATITUDE:";
            this.Latitude.MinimumWidth = 8;
            this.Latitude.Name = "Latitude";
            this.Latitude.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Latitude.Width = 150;
            // 
            // NamesPoints
            // 
            this.NamesPoints.Frozen = true;
            this.NamesPoints.HeaderText = "POINTS NAMES:";
            this.NamesPoints.MinimumWidth = 8;
            this.NamesPoints.Name = "NamesPoints";
            this.NamesPoints.Width = 150;
            // 
            // Points
            // 
            this.Points.Frozen = true;
            this.Points.HeaderText = "POINTS:";
            this.Points.MinimumWidth = 8;
            this.Points.Name = "Points";
            this.Points.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Points.Width = 150;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "POINTS:";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.Frozen = true;
            this.dataGridViewTextBoxColumn2.HeaderText = "POINTS NAMES:";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "LATITUDE:";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.Width = 210;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "LONGITUDE:";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.Width = 210;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "DATE AND TIME:";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn5.Width = 210;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "ANGLE:";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "ALTITUDE:";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "MEETING POINT:";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn8.Width = 150;
            // 
            // DataGridPoints
            // 
            this.DataGridPoints.AllowUserToAddRows = false;
            this.DataGridPoints.AllowUserToDeleteRows = false;
            this.DataGridPoints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridPoints.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.DataGridPoints.Location = new System.Drawing.Point(17, 172);
            this.DataGridPoints.Name = "DataGridPoints";
            this.DataGridPoints.ReadOnly = true;
            this.DataGridPoints.RowHeadersWidth = 62;
            this.DataGridPoints.Size = new System.Drawing.Size(1444, 245);
            this.DataGridPoints.TabIndex = 0;
            this.DataGridPoints.Text = "dataGridView1";
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
            this.NamePointA.Resizable = System.Windows.Forms.DataGridViewTriState.True;
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
            this.NamePointB.HeaderText = "NAMES OF POINTS B";
            this.NamePointB.MinimumWidth = 8;
            this.NamePointB.Name = "NamePointB";
            this.NamePointB.ReadOnly = true;
            this.NamePointB.Resizable = System.Windows.Forms.DataGridViewTriState.True;
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
            this.DataGridNodes.Location = new System.Drawing.Point(17, 423);
            this.DataGridNodes.Name = "DataGridNodes";
            this.DataGridNodes.ReadOnly = true;
            this.DataGridNodes.RowHeadersWidth = 62;
            this.DataGridNodes.Size = new System.Drawing.Size(1567, 245);
            this.DataGridNodes.TabIndex = 1;
            this.DataGridNodes.Text = "dataGridView1";
            // 
            // Status
            // 
            this.Status.HeaderText = "STATUS:";
            this.Status.MinimumWidth = 8;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Status.Width = 150;
            // 
            // maxLatitude
            // 
            this.maxLatitude.HeaderText = "MAX LATITUDE:";
            this.maxLatitude.MinimumWidth = 8;
            this.maxLatitude.Name = "maxLatitude";
            this.maxLatitude.ReadOnly = true;
            this.maxLatitude.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.maxLatitude.Width = 210;
            // 
            // minLatitude
            // 
            this.minLatitude.HeaderText = "MIN LATITUDE:";
            this.minLatitude.MinimumWidth = 8;
            this.minLatitude.Name = "minLatitude";
            this.minLatitude.ReadOnly = true;
            this.minLatitude.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.minLatitude.Width = 210;
            // 
            // maxLongitude
            // 
            this.maxLongitude.HeaderText = "MAX LONGITUDE:";
            this.maxLongitude.MinimumWidth = 8;
            this.maxLongitude.Name = "maxLongitude";
            this.maxLongitude.ReadOnly = true;
            this.maxLongitude.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.maxLongitude.Width = 210;
            // 
            // minLongitude
            // 
            this.minLongitude.HeaderText = "MIN LONGITUDE:";
            this.minLongitude.MinimumWidth = 8;
            this.minLongitude.Name = "minLongitude";
            this.minLongitude.ReadOnly = true;
            this.minLongitude.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.minLongitude.Width = 210;
            // 
            // Debug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1619, 679);
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
            this.DataGridCoordinates.Location = new System.Drawing.Point(17, 13);
            this.DataGridCoordinates.Name = "DataGridCoordinates";
            this.DataGridCoordinates.ReadOnly = true;
            this.DataGridCoordinates.RowHeadersWidth = 62;
            this.DataGridCoordinates.Size = new System.Drawing.Size(1056, 152);
            this.DataGridCoordinates.TabIndex = 3;
            this.DataGridCoordinates.Text = "dataGridView1";
            this.Controls.Add(this.DataGridCoordinates);
            this.Controls.Add(this.ButtonRefresh);
            this.Controls.Add(this.DataGridNodes);
            this.Controls.Add(this.DataGridPoints);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Debug";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Debug";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridPoints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridNodes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCoordinates)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ButtonRefresh;
        private System.Windows.Forms.DataGridView DataGridNodes;
        private System.Windows.Forms.DataGridView DataGridPoints;
        private System.Windows.Forms.DataGridView DataGridCoordinates;
        private System.Windows.Forms.DataGridViewTextBoxColumn MeetingPoint;
        private System.Windows.Forms.DataGridViewTextBoxColumn Altitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn Angle;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateAndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Longitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn Latitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamesPoints;
        private System.Windows.Forms.DataGridViewTextBoxColumn Points;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxLatitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn minLatitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxLongitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn minLongitude;
    }
}