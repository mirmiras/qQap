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
            this.captureActiveWindowCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.autoRecordButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.capturePeriodInSeconds = new System.Windows.Forms.NumericUpDown();
            this.captureTimer = new System.Windows.Forms.Timer(this.components);
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.capturePeriodInSeconds)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // captureButton
            // 
            this.captureButton.Location = new System.Drawing.Point(29, 35);
            this.captureButton.Name = "captureButton";
            this.captureButton.Size = new System.Drawing.Size(84, 23);
            this.captureButton.TabIndex = 0;
            this.captureButton.Text = "Capture";
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
            this.toTrayCheckBox.Location = new System.Drawing.Point(14, 39);
            this.toTrayCheckBox.Name = "toTrayCheckBox";
            this.toTrayCheckBox.Size = new System.Drawing.Size(106, 17);
            this.toTrayCheckBox.TabIndex = 1;
            this.toTrayCheckBox.Text = "Minimize To Tray";
            this.toTrayCheckBox.UseVisualStyleBackColor = true;
            // 
            // startMinimizedCheckBox
            // 
            this.startMinimizedCheckBox.AutoSize = true;
            this.startMinimizedCheckBox.Location = new System.Drawing.Point(14, 62);
            this.startMinimizedCheckBox.Name = "startMinimizedCheckBox";
            this.startMinimizedCheckBox.Size = new System.Drawing.Size(96, 17);
            this.startMinimizedCheckBox.TabIndex = 2;
            this.startMinimizedCheckBox.Text = "Start minimized";
            this.startMinimizedCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.toTrayCheckBox);
            this.groupBox1.Controls.Add(this.captureActiveWindowCheckBox);
            this.groupBox1.Controls.Add(this.startMinimizedCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(159, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(171, 85);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // captureActiveWindowCheckBox
            // 
            this.captureActiveWindowCheckBox.AutoSize = true;
            this.captureActiveWindowCheckBox.Location = new System.Drawing.Point(14, 16);
            this.captureActiveWindowCheckBox.Name = "captureActiveWindowCheckBox";
            this.captureActiveWindowCheckBox.Size = new System.Drawing.Size(138, 17);
            this.captureActiveWindowCheckBox.TabIndex = 3;
            this.captureActiveWindowCheckBox.Text = "Capture Active Window";
            this.captureActiveWindowCheckBox.UseVisualStyleBackColor = true;
            this.captureActiveWindowCheckBox.CheckedChanged += new System.EventHandler(this.captureActiveWindowCheckBox_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.captureButton);
            this.groupBox2.Location = new System.Drawing.Point(13, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(140, 85);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Manual Capture";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.autoRecordButton);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(13, 109);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(317, 72);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Auto Capture";
            // 
            // autoRecordButton
            // 
            this.autoRecordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.autoRecordButton.ForeColor = System.Drawing.Color.Red;
            this.autoRecordButton.Location = new System.Drawing.Point(16, 29);
            this.autoRecordButton.Name = "autoRecordButton";
            this.autoRecordButton.Size = new System.Drawing.Size(114, 23);
            this.autoRecordButton.TabIndex = 2;
            this.autoRecordButton.Text = "Start AutoRecord";
            this.autoRecordButton.UseVisualStyleBackColor = true;
            this.autoRecordButton.Click += new System.EventHandler(this.autoRecordButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.capturePeriodInSeconds);
            this.groupBox4.Location = new System.Drawing.Point(146, 15);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(158, 46);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Capture every";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "seconds";
            // 
            // capturePeriodInSeconds
            // 
            this.capturePeriodInSeconds.Location = new System.Drawing.Point(14, 17);
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
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip.Location = new System.Drawing.Point(0, 195);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(343, 22);
            this.statusStrip.TabIndex = 6;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(33, 17);
            this.toolStripStatusLabel1.Text = "Mode";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(53, 17);
            this.toolStripStatusLabel2.Text = "FileSaved";
            // 
            // groupBox5
            // 
            this.groupBox5.Location = new System.Drawing.Point(5, 1);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(335, 189);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            // 
            // TrayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 217);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TrayForm";
            this.Text = "Qap";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TrayForm_FormClosed);
            this.Load += new System.EventHandler(this.TrayForm_Load);
            this.Resize += new System.EventHandler(this.TrayForm_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.capturePeriodInSeconds)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button captureButton;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.CheckBox toTrayCheckBox;
        private System.Windows.Forms.CheckBox startMinimizedCheckBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown capturePeriodInSeconds;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox captureActiveWindowCheckBox;
        private System.Windows.Forms.Timer captureTimer;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button autoRecordButton;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    }
}

