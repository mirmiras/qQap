namespace QapTray
{
    partial class TrayForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrayForm));
            this.captureButton = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.toTrayCheckBox = new System.Windows.Forms.CheckBox();
            this.startMinimizedCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.activeWindowCaptureButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.captureActiveWindowCheckBox = new System.Windows.Forms.CheckBox();
            this.captureCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.capturePeriodInSeconds = new System.Windows.Forms.NumericUpDown();
            this.captureTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.capturePeriodInSeconds)).BeginInit();
            this.SuspendLayout();
            // 
            // captureButton
            // 
            this.captureButton.Location = new System.Drawing.Point(16, 19);
            this.captureButton.Name = "captureButton";
            this.captureButton.Size = new System.Drawing.Size(134, 23);
            this.captureButton.TabIndex = 0;
            this.captureButton.Text = "Capture Full Screen";
            this.captureButton.UseVisualStyleBackColor = true;
            this.captureButton.Click += new System.EventHandler(this.captureButton_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipText = "qQap minimized to tray";
            this.notifyIcon.BalloonTipTitle = "qQap Tray";
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "qQap";
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // toTrayCheckBox
            // 
            this.toTrayCheckBox.AutoSize = true;
            this.toTrayCheckBox.Location = new System.Drawing.Point(13, 22);
            this.toTrayCheckBox.Name = "toTrayCheckBox";
            this.toTrayCheckBox.Size = new System.Drawing.Size(106, 17);
            this.toTrayCheckBox.TabIndex = 1;
            this.toTrayCheckBox.Text = "Minimize To Tray";
            this.toTrayCheckBox.UseVisualStyleBackColor = true;
            // 
            // startMinimizedCheckBox
            // 
            this.startMinimizedCheckBox.AutoSize = true;
            this.startMinimizedCheckBox.Location = new System.Drawing.Point(13, 54);
            this.startMinimizedCheckBox.Name = "startMinimizedCheckBox";
            this.startMinimizedCheckBox.Size = new System.Drawing.Size(96, 17);
            this.startMinimizedCheckBox.TabIndex = 2;
            this.startMinimizedCheckBox.Text = "Start minimized";
            this.startMinimizedCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.toTrayCheckBox);
            this.groupBox1.Controls.Add(this.startMinimizedCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(186, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(142, 85);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.activeWindowCaptureButton);
            this.groupBox2.Controls.Add(this.captureButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(168, 85);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Manual Capture";
            // 
            // activeWindowCaptureButton
            // 
            this.activeWindowCaptureButton.Location = new System.Drawing.Point(16, 48);
            this.activeWindowCaptureButton.Name = "activeWindowCaptureButton";
            this.activeWindowCaptureButton.Size = new System.Drawing.Size(134, 23);
            this.activeWindowCaptureButton.TabIndex = 1;
            this.activeWindowCaptureButton.Text = "Capture Active Window";
            this.activeWindowCaptureButton.UseVisualStyleBackColor = true;
            this.activeWindowCaptureButton.Click += new System.EventHandler(this.activeWindowCaptureButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.captureActiveWindowCheckBox);
            this.groupBox3.Controls.Add(this.captureCheckBox);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(12, 103);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(316, 81);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Auto Capture";
            // 
            // captureActiveWindowCheckBox
            // 
            this.captureActiveWindowCheckBox.AutoSize = true;
            this.captureActiveWindowCheckBox.Location = new System.Drawing.Point(16, 48);
            this.captureActiveWindowCheckBox.Name = "captureActiveWindowCheckBox";
            this.captureActiveWindowCheckBox.Size = new System.Drawing.Size(138, 17);
            this.captureActiveWindowCheckBox.TabIndex = 3;
            this.captureActiveWindowCheckBox.Text = "Capture Active Window";
            this.captureActiveWindowCheckBox.UseVisualStyleBackColor = true;
            // 
            // captureCheckBox
            // 
            this.captureCheckBox.AutoSize = true;
            this.captureCheckBox.Location = new System.Drawing.Point(16, 20);
            this.captureCheckBox.Name = "captureCheckBox";
            this.captureCheckBox.Size = new System.Drawing.Size(113, 17);
            this.captureCheckBox.TabIndex = 0;
            this.captureCheckBox.Text = "Auto Caputre Start";
            this.captureCheckBox.UseVisualStyleBackColor = true;
            this.captureCheckBox.CheckedChanged += new System.EventHandler(this.captureCheckBox_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.capturePeriodInSeconds);
            this.groupBox4.Location = new System.Drawing.Point(160, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(150, 60);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Capture every";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "seconds";
            // 
            // capturePeriodInSeconds
            // 
            this.capturePeriodInSeconds.Location = new System.Drawing.Point(14, 24);
            this.capturePeriodInSeconds.Name = "capturePeriodInSeconds";
            this.capturePeriodInSeconds.Size = new System.Drawing.Size(64, 20);
            this.capturePeriodInSeconds.TabIndex = 1;
            this.capturePeriodInSeconds.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // captureTimer
            // 
            this.captureTimer.Tick += new System.EventHandler(this.captureTimer_Tick);
            // 
            // TrayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 195);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TrayForm";
            this.Text = "qQap Tray";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TrayForm_FormClosed);
            this.Load += new System.EventHandler(this.TrayForm_Load);
            this.Resize += new System.EventHandler(this.TrayForm_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.capturePeriodInSeconds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button captureButton;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.CheckBox toTrayCheckBox;
        private System.Windows.Forms.CheckBox startMinimizedCheckBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button activeWindowCaptureButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown capturePeriodInSeconds;
        private System.Windows.Forms.CheckBox captureCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox captureActiveWindowCheckBox;
        private System.Windows.Forms.Timer captureTimer;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

