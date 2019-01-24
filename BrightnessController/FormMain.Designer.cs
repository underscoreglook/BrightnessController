namespace BrightnessController {
    partial class FormMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btnToTray = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.tkbBrightness = new System.Windows.Forms.TrackBar();
            this.tmrMain = new System.Windows.Forms.Timer(this.components);
            this.lblLongitude = new System.Windows.Forms.Label();
            this.lblLatitude = new System.Windows.Forms.Label();
            this.txtDegLat = new System.Windows.Forms.TextBox();
            this.txtDegLong = new System.Windows.Forms.TextBox();
            this.txtMinLong = new System.Windows.Forms.TextBox();
            this.txtMinLat = new System.Windows.Forms.TextBox();
            this.txtSecLong = new System.Windows.Forms.TextBox();
            this.txtSecLat = new System.Windows.Forms.TextBox();
            this.lblDegree = new System.Windows.Forms.Label();
            this.lblMinute = new System.Windows.Forms.Label();
            this.lblSecond = new System.Windows.Forms.Label();
            this.chkEnable = new System.Windows.Forms.CheckBox();
            this.lblBrightnessSettings = new System.Windows.Forms.Label();
            this.lblNight = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.tkbNight = new System.Windows.Forms.TrackBar();
            this.tkbDuring = new System.Windows.Forms.TrackBar();
            this.lblDuring = new System.Windows.Forms.Label();
            this.tkbDay = new System.Windows.Forms.TrackBar();
            this.lblDay = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radNorth = new System.Windows.Forms.RadioButton();
            this.radSouth = new System.Windows.Forms.RadioButton();
            this.radEast = new System.Windows.Forms.RadioButton();
            this.radWest = new System.Windows.Forms.RadioButton();
            this.icoNotify = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tkbBrightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbNight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbDuring)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbDay)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnToTray
            // 
            this.btnToTray.Location = new System.Drawing.Point(12, 12);
            this.btnToTray.Name = "btnToTray";
            this.btnToTray.Size = new System.Drawing.Size(75, 46);
            this.btnToTray.TabIndex = 0;
            this.btnToTray.Text = "Minimize To Tray";
            this.btnToTray.UseVisualStyleBackColor = true;
            this.btnToTray.Click += new System.EventHandler(this.btnToTray_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(381, 13);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(84, 46);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tkbBrightness
            // 
            this.tkbBrightness.LargeChange = 25;
            this.tkbBrightness.Location = new System.Drawing.Point(93, 13);
            this.tkbBrightness.Maximum = 127;
            this.tkbBrightness.Name = "tkbBrightness";
            this.tkbBrightness.Size = new System.Drawing.Size(282, 45);
            this.tkbBrightness.TabIndex = 2;
            this.tkbBrightness.TickFrequency = 5;
            this.tkbBrightness.Value = 127;
            this.tkbBrightness.Scroll += new System.EventHandler(this.tkbBrightness_Scroll);
            // 
            // tmrMain
            // 
            this.tmrMain.Interval = 60000;
            this.tmrMain.Tick += new System.EventHandler(this.tmrMain_Tick);
            // 
            // lblLongitude
            // 
            this.lblLongitude.AutoSize = true;
            this.lblLongitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLongitude.Location = new System.Drawing.Point(8, 127);
            this.lblLongitude.Name = "lblLongitude";
            this.lblLongitude.Size = new System.Drawing.Size(80, 20);
            this.lblLongitude.TabIndex = 3;
            this.lblLongitude.Text = "Longitude";
            // 
            // lblLatitude
            // 
            this.lblLatitude.AutoSize = true;
            this.lblLatitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLatitude.Location = new System.Drawing.Point(8, 98);
            this.lblLatitude.Name = "lblLatitude";
            this.lblLatitude.Size = new System.Drawing.Size(67, 20);
            this.lblLatitude.TabIndex = 4;
            this.lblLatitude.Text = "Latitude";
            // 
            // txtDegLat
            // 
            this.txtDegLat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDegLat.Location = new System.Drawing.Point(94, 92);
            this.txtDegLat.Name = "txtDegLat";
            this.txtDegLat.Size = new System.Drawing.Size(57, 26);
            this.txtDegLat.TabIndex = 5;
            // 
            // txtDegLong
            // 
            this.txtDegLong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDegLong.Location = new System.Drawing.Point(94, 121);
            this.txtDegLong.Name = "txtDegLong";
            this.txtDegLong.Size = new System.Drawing.Size(57, 26);
            this.txtDegLong.TabIndex = 8;
            // 
            // txtMinLong
            // 
            this.txtMinLong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinLong.Location = new System.Drawing.Point(157, 121);
            this.txtMinLong.Name = "txtMinLong";
            this.txtMinLong.Size = new System.Drawing.Size(57, 26);
            this.txtMinLong.TabIndex = 9;
            // 
            // txtMinLat
            // 
            this.txtMinLat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinLat.Location = new System.Drawing.Point(157, 92);
            this.txtMinLat.Name = "txtMinLat";
            this.txtMinLat.Size = new System.Drawing.Size(57, 26);
            this.txtMinLat.TabIndex = 6;
            // 
            // txtSecLong
            // 
            this.txtSecLong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecLong.Location = new System.Drawing.Point(220, 121);
            this.txtSecLong.Name = "txtSecLong";
            this.txtSecLong.Size = new System.Drawing.Size(57, 26);
            this.txtSecLong.TabIndex = 10;
            // 
            // txtSecLat
            // 
            this.txtSecLat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecLat.Location = new System.Drawing.Point(220, 92);
            this.txtSecLat.Name = "txtSecLat";
            this.txtSecLat.Size = new System.Drawing.Size(57, 26);
            this.txtSecLat.TabIndex = 7;
            // 
            // lblDegree
            // 
            this.lblDegree.AutoSize = true;
            this.lblDegree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDegree.Location = new System.Drawing.Point(90, 69);
            this.lblDegree.Name = "lblDegree";
            this.lblDegree.Size = new System.Drawing.Size(62, 20);
            this.lblDegree.TabIndex = 11;
            this.lblDegree.Text = "Degree";
            // 
            // lblMinute
            // 
            this.lblMinute.AutoSize = true;
            this.lblMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinute.Location = new System.Drawing.Point(158, 69);
            this.lblMinute.Name = "lblMinute";
            this.lblMinute.Size = new System.Drawing.Size(57, 20);
            this.lblMinute.TabIndex = 12;
            this.lblMinute.Text = "Minute";
            // 
            // lblSecond
            // 
            this.lblSecond.AutoSize = true;
            this.lblSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecond.Location = new System.Drawing.Point(216, 69);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(64, 20);
            this.lblSecond.TabIndex = 13;
            this.lblSecond.Text = "Second";
            this.lblSecond.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkEnable
            // 
            this.chkEnable.AutoSize = true;
            this.chkEnable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEnable.Location = new System.Drawing.Point(233, 169);
            this.chkEnable.Name = "chkEnable";
            this.chkEnable.Size = new System.Drawing.Size(80, 22);
            this.chkEnable.TabIndex = 14;
            this.chkEnable.Text = "Enabled";
            this.chkEnable.UseVisualStyleBackColor = true;
            this.chkEnable.CheckedChanged += new System.EventHandler(this.chkEnable_CheckedChanged);
            // 
            // lblBrightnessSettings
            // 
            this.lblBrightnessSettings.AutoSize = true;
            this.lblBrightnessSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrightnessSettings.Location = new System.Drawing.Point(79, 171);
            this.lblBrightnessSettings.Name = "lblBrightnessSettings";
            this.lblBrightnessSettings.Size = new System.Drawing.Size(148, 20);
            this.lblBrightnessSettings.TabIndex = 15;
            this.lblBrightnessSettings.Text = "Brightness Settings";
            // 
            // lblNight
            // 
            this.lblNight.AutoSize = true;
            this.lblNight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNight.Location = new System.Drawing.Point(8, 203);
            this.lblNight.Name = "lblNight";
            this.lblNight.Size = new System.Drawing.Size(46, 20);
            this.lblNight.TabIndex = 16;
            this.lblNight.Text = "Night";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(356, 69);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(108, 20);
            this.lblLocation.TabIndex = 17;
            this.lblLocation.Text = "Your Location";
            // 
            // tkbNight
            // 
            this.tkbNight.LargeChange = 25;
            this.tkbNight.Location = new System.Drawing.Point(94, 194);
            this.tkbNight.Maximum = 127;
            this.tkbNight.Name = "tkbNight";
            this.tkbNight.Size = new System.Drawing.Size(371, 45);
            this.tkbNight.TabIndex = 18;
            this.tkbNight.TickFrequency = 5;
            this.tkbNight.Value = 127;
            this.tkbNight.Scroll += new System.EventHandler(this.brightnessScroll);
            // 
            // tkbDuring
            // 
            this.tkbDuring.LargeChange = 25;
            this.tkbDuring.Location = new System.Drawing.Point(93, 245);
            this.tkbDuring.Maximum = 127;
            this.tkbDuring.Name = "tkbDuring";
            this.tkbDuring.Size = new System.Drawing.Size(371, 45);
            this.tkbDuring.TabIndex = 20;
            this.tkbDuring.TickFrequency = 5;
            this.tkbDuring.Value = 127;
            this.tkbDuring.Scroll += new System.EventHandler(this.brightnessScroll);
            // 
            // lblDuring
            // 
            this.lblDuring.AutoSize = true;
            this.lblDuring.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuring.Location = new System.Drawing.Point(7, 254);
            this.lblDuring.Name = "lblDuring";
            this.lblDuring.Size = new System.Drawing.Size(70, 20);
            this.lblDuring.TabIndex = 19;
            this.lblDuring.Text = "Rise/Set";
            // 
            // tkbDay
            // 
            this.tkbDay.LargeChange = 25;
            this.tkbDay.Location = new System.Drawing.Point(94, 296);
            this.tkbDay.Maximum = 127;
            this.tkbDay.Name = "tkbDay";
            this.tkbDay.Size = new System.Drawing.Size(371, 45);
            this.tkbDay.TabIndex = 22;
            this.tkbDay.TickFrequency = 5;
            this.tkbDay.Value = 127;
            this.tkbDay.Scroll += new System.EventHandler(this.brightnessScroll);
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.Location = new System.Drawing.Point(8, 305);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(37, 20);
            this.lblDay.TabIndex = 21;
            this.lblDay.Text = "Day";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radSouth);
            this.panel1.Controls.Add(this.radNorth);
            this.panel1.Location = new System.Drawing.Point(285, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(181, 26);
            this.panel1.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radEast);
            this.panel2.Controls.Add(this.radWest);
            this.panel2.Location = new System.Drawing.Point(284, 121);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(181, 26);
            this.panel2.TabIndex = 24;
            // 
            // radNorth
            // 
            this.radNorth.AutoSize = true;
            this.radNorth.Checked = true;
            this.radNorth.Location = new System.Drawing.Point(7, 3);
            this.radNorth.Name = "radNorth";
            this.radNorth.Size = new System.Drawing.Size(51, 17);
            this.radNorth.TabIndex = 1;
            this.radNorth.Text = "North";
            this.radNorth.UseVisualStyleBackColor = true;
            // 
            // radSouth
            // 
            this.radSouth.AutoSize = true;
            this.radSouth.Location = new System.Drawing.Point(64, 3);
            this.radSouth.Name = "radSouth";
            this.radSouth.Size = new System.Drawing.Size(53, 17);
            this.radSouth.TabIndex = 2;
            this.radSouth.Text = "South";
            this.radSouth.UseVisualStyleBackColor = true;
            // 
            // radEast
            // 
            this.radEast.AutoSize = true;
            this.radEast.Location = new System.Drawing.Point(65, 3);
            this.radEast.Name = "radEast";
            this.radEast.Size = new System.Drawing.Size(46, 17);
            this.radEast.TabIndex = 4;
            this.radEast.Text = "East";
            this.radEast.UseVisualStyleBackColor = true;
            // 
            // radWest
            // 
            this.radWest.AutoSize = true;
            this.radWest.Checked = true;
            this.radWest.Location = new System.Drawing.Point(8, 3);
            this.radWest.Name = "radWest";
            this.radWest.Size = new System.Drawing.Size(50, 17);
            this.radWest.TabIndex = 3;
            this.radWest.Text = "West";
            this.radWest.UseVisualStyleBackColor = true;
            // 
            // icoNotify
            // 
            this.icoNotify.BalloonTipText = "Click to toggle. Right click to show.";
            this.icoNotify.BalloonTipTitle = "Auto Brightness Controller";
            this.icoNotify.Icon = ((System.Drawing.Icon)(resources.GetObject("icoNotify.Icon")));
            this.icoNotify.Text = "Click to toggle. Right click to show.";
            this.icoNotify.MouseClick += new System.Windows.Forms.MouseEventHandler(this.icoNotify_MouseClick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 358);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tkbDay);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.tkbDuring);
            this.Controls.Add(this.lblDuring);
            this.Controls.Add(this.tkbNight);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblNight);
            this.Controls.Add(this.lblBrightnessSettings);
            this.Controls.Add(this.chkEnable);
            this.Controls.Add(this.lblSecond);
            this.Controls.Add(this.lblMinute);
            this.Controls.Add(this.lblDegree);
            this.Controls.Add(this.txtSecLong);
            this.Controls.Add(this.txtSecLat);
            this.Controls.Add(this.txtMinLong);
            this.Controls.Add(this.txtMinLat);
            this.Controls.Add(this.txtDegLong);
            this.Controls.Add(this.txtDegLat);
            this.Controls.Add(this.lblLatitude);
            this.Controls.Add(this.lblLongitude);
            this.Controls.Add(this.tkbBrightness);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnToTray);
            this.Name = "FormMain";
            this.Text = "Brightness Control";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tkbBrightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbNight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbDuring)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbDay)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnToTray;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TrackBar tkbBrightness;
        private System.Windows.Forms.Timer tmrMain;
        private System.Windows.Forms.Label lblLongitude;
        private System.Windows.Forms.Label lblLatitude;
        private System.Windows.Forms.TextBox txtDegLat;
        private System.Windows.Forms.TextBox txtDegLong;
        private System.Windows.Forms.TextBox txtMinLong;
        private System.Windows.Forms.TextBox txtMinLat;
        private System.Windows.Forms.TextBox txtSecLong;
        private System.Windows.Forms.TextBox txtSecLat;
        private System.Windows.Forms.Label lblDegree;
        private System.Windows.Forms.Label lblMinute;
        private System.Windows.Forms.Label lblSecond;
        private System.Windows.Forms.CheckBox chkEnable;
        private System.Windows.Forms.Label lblBrightnessSettings;
        private System.Windows.Forms.Label lblNight;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TrackBar tkbNight;
        private System.Windows.Forms.TrackBar tkbDuring;
        private System.Windows.Forms.Label lblDuring;
        private System.Windows.Forms.TrackBar tkbDay;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radSouth;
        private System.Windows.Forms.RadioButton radNorth;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radEast;
        private System.Windows.Forms.RadioButton radWest;
        private System.Windows.Forms.NotifyIcon icoNotify;
    }
}

