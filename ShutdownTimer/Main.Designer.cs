namespace ShutdownTimer
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.btnPowerMenu = new ShutdownTimer.MenuButton();
            this.btnInfo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.grbOptions = new System.Windows.Forms.GroupBox();
            this.lblminutes = new System.Windows.Forms.Label();
            this.numWarn = new System.Windows.Forms.NumericUpDown();
            this.chkWarn = new System.Windows.Forms.CheckBox();
            this.chkVietnamese = new System.Windows.Forms.CheckBox();
            this.chkForce = new System.Windows.Forms.CheckBox();
            this.chkHybridOn = new System.Windows.Forms.CheckBox();
            this.radSignOut = new System.Windows.Forms.RadioButton();
            this.radRestart = new System.Windows.Forms.RadioButton();
            this.radShutdown = new System.Windows.Forms.RadioButton();
            this.btnSet = new System.Windows.Forms.Button();
            this.grbSetTime = new System.Windows.Forms.GroupBox();
            this.numS = new System.Windows.Forms.NumericUpDown();
            this.numM = new System.Windows.Forms.NumericUpDown();
            this.numH = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlTask = new System.Windows.Forms.Panel();
            this.lblCountdown = new System.Windows.Forms.Label();
            this.lblTimeRemaining = new System.Windows.Forms.Label();
            this.prgTask = new System.Windows.Forms.ProgressBar();
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.pnlTitle.SuspendLayout();
            this.pnlStatus.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.grbOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWarn)).BeginInit();
            this.grbSetTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numH)).BeginInit();
            this.pnlTask.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(157)))), ((int)(((byte)(202)))));
            this.pnlTitle.Controls.Add(this.btnPowerMenu);
            this.pnlTitle.Controls.Add(this.btnInfo);
            this.pnlTitle.Controls.Add(this.label1);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.ForeColor = System.Drawing.Color.White;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(370, 38);
            this.pnlTitle.TabIndex = 0;
            // 
            // btnPowerMenu
            // 
            this.btnPowerMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(186)))), ((int)(((byte)(223)))));
            this.btnPowerMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPowerMenu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPowerMenu.FlatAppearance.BorderSize = 0;
            this.btnPowerMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(138)))), ((int)(((byte)(177)))));
            this.btnPowerMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(210)))), ((int)(((byte)(235)))));
            this.btnPowerMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPowerMenu.ForeColor = System.Drawing.Color.White;
            this.btnPowerMenu.Image = global::ShutdownTimer.Properties.Resources.icon_power_24;
            this.btnPowerMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPowerMenu.Location = new System.Drawing.Point(277, 0);
            this.btnPowerMenu.Name = "btnPowerMenu";
            this.btnPowerMenu.Size = new System.Drawing.Size(49, 38);
            this.btnPowerMenu.TabIndex = 6;
            this.btnPowerMenu.UseVisualStyleBackColor = false;
            this.btnPowerMenu.Click += new System.EventHandler(this.btnPowerMenu_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(186)))), ((int)(((byte)(223)))));
            this.btnInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnInfo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(138)))), ((int)(((byte)(177)))));
            this.btnInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(210)))), ((int)(((byte)(235)))));
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.ForeColor = System.Drawing.Color.White;
            this.btnInfo.Image = global::ShutdownTimer.Properties.Resources.icon_info_24;
            this.btnInfo.Location = new System.Drawing.Point(326, 0);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(44, 38);
            this.btnInfo.TabIndex = 5;
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Shutdown Timer";
            // 
            // pnlStatus
            // 
            this.pnlStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(157)))), ((int)(((byte)(202)))));
            this.pnlStatus.Controls.Add(this.lblStatus);
            this.pnlStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlStatus.ForeColor = System.Drawing.Color.White;
            this.pnlStatus.Location = new System.Drawing.Point(0, 293);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(370, 25);
            this.pnlStatus.TabIndex = 1;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(5, 5);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(207, 15);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Set time then click Set to start the task";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.grbOptions);
            this.pnlMain.Controls.Add(this.btnSet);
            this.pnlMain.Controls.Add(this.grbSetTime);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 38);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(370, 255);
            this.pnlMain.TabIndex = 2;
            // 
            // grbOptions
            // 
            this.grbOptions.Controls.Add(this.lblminutes);
            this.grbOptions.Controls.Add(this.numWarn);
            this.grbOptions.Controls.Add(this.chkWarn);
            this.grbOptions.Controls.Add(this.chkVietnamese);
            this.grbOptions.Controls.Add(this.chkForce);
            this.grbOptions.Controls.Add(this.chkHybridOn);
            this.grbOptions.Controls.Add(this.radSignOut);
            this.grbOptions.Controls.Add(this.radRestart);
            this.grbOptions.Controls.Add(this.radShutdown);
            this.grbOptions.Location = new System.Drawing.Point(17, 76);
            this.grbOptions.Name = "grbOptions";
            this.grbOptions.Size = new System.Drawing.Size(335, 113);
            this.grbOptions.TabIndex = 5;
            this.grbOptions.TabStop = false;
            this.grbOptions.Text = "Options";
            // 
            // lblminutes
            // 
            this.lblminutes.AutoSize = true;
            this.lblminutes.Location = new System.Drawing.Point(271, 74);
            this.lblminutes.Name = "lblminutes";
            this.lblminutes.Size = new System.Drawing.Size(58, 15);
            this.lblminutes.TabIndex = 13;
            this.lblminutes.Text = "minute(s)";
            // 
            // numWarn
            // 
            this.numWarn.Location = new System.Drawing.Point(216, 72);
            this.numWarn.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numWarn.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numWarn.Name = "numWarn";
            this.numWarn.Size = new System.Drawing.Size(46, 23);
            this.numWarn.TabIndex = 12;
            this.numWarn.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // chkWarn
            // 
            this.chkWarn.AutoSize = true;
            this.chkWarn.Location = new System.Drawing.Point(116, 73);
            this.chkWarn.Name = "chkWarn";
            this.chkWarn.Size = new System.Drawing.Size(94, 19);
            this.chkWarn.TabIndex = 11;
            this.chkWarn.Text = "Warn before:";
            this.chkWarn.UseVisualStyleBackColor = true;
            this.chkWarn.CheckedChanged += new System.EventHandler(this.chkWarn_CheckedChanged);
            // 
            // chkVietnamese
            // 
            this.chkVietnamese.AutoSize = true;
            this.chkVietnamese.Checked = true;
            this.chkVietnamese.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkVietnamese.Location = new System.Drawing.Point(116, 48);
            this.chkVietnamese.Name = "chkVietnamese";
            this.chkVietnamese.Size = new System.Drawing.Size(158, 19);
            this.chkVietnamese.TabIndex = 10;
            this.chkVietnamese.Text = "Use Vietnamese interface";
            this.chkVietnamese.UseVisualStyleBackColor = true;
            this.chkVietnamese.CheckedChanged += new System.EventHandler(this.chkVietnamese_CheckedChanged);
            // 
            // chkForce
            // 
            this.chkForce.AutoSize = true;
            this.chkForce.Checked = true;
            this.chkForce.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkForce.Location = new System.Drawing.Point(248, 23);
            this.chkForce.Name = "chkForce";
            this.chkForce.Size = new System.Drawing.Size(81, 19);
            this.chkForce.TabIndex = 9;
            this.chkForce.Text = "Force stop";
            this.chkForce.UseVisualStyleBackColor = true;
            // 
            // chkHybridOn
            // 
            this.chkHybridOn.AutoSize = true;
            this.chkHybridOn.Checked = true;
            this.chkHybridOn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHybridOn.Location = new System.Drawing.Point(116, 23);
            this.chkHybridOn.Name = "chkHybridOn";
            this.chkHybridOn.Size = new System.Drawing.Size(112, 19);
            this.chkHybridOn.TabIndex = 6;
            this.chkHybridOn.Text = "Use Hybrid boot";
            this.chkHybridOn.UseVisualStyleBackColor = true;
            // 
            // radSignOut
            // 
            this.radSignOut.AutoSize = true;
            this.radSignOut.Location = new System.Drawing.Point(16, 72);
            this.radSignOut.Name = "radSignOut";
            this.radSignOut.Size = new System.Drawing.Size(69, 19);
            this.radSignOut.TabIndex = 8;
            this.radSignOut.Text = "Sign out";
            this.radSignOut.UseVisualStyleBackColor = true;
            this.radSignOut.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // radRestart
            // 
            this.radRestart.AutoSize = true;
            this.radRestart.Location = new System.Drawing.Point(16, 47);
            this.radRestart.Name = "radRestart";
            this.radRestart.Size = new System.Drawing.Size(61, 19);
            this.radRestart.TabIndex = 7;
            this.radRestart.Text = "Restart";
            this.radRestart.UseVisualStyleBackColor = true;
            this.radRestart.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // radShutdown
            // 
            this.radShutdown.AutoSize = true;
            this.radShutdown.Checked = true;
            this.radShutdown.Location = new System.Drawing.Point(16, 22);
            this.radShutdown.Name = "radShutdown";
            this.radShutdown.Size = new System.Drawing.Size(79, 19);
            this.radShutdown.TabIndex = 6;
            this.radShutdown.TabStop = true;
            this.radShutdown.Text = "Shutdown";
            this.radShutdown.UseVisualStyleBackColor = true;
            this.radShutdown.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // btnSet
            // 
            this.btnSet.BackColor = System.Drawing.Color.Silver;
            this.btnSet.FlatAppearance.BorderSize = 0;
            this.btnSet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnSet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSet.Location = new System.Drawing.Point(254, 14);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(98, 56);
            this.btnSet.TabIndex = 3;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = false;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // grbSetTime
            // 
            this.grbSetTime.Controls.Add(this.numS);
            this.grbSetTime.Controls.Add(this.numM);
            this.grbSetTime.Controls.Add(this.numH);
            this.grbSetTime.Controls.Add(this.label5);
            this.grbSetTime.Controls.Add(this.label4);
            this.grbSetTime.Controls.Add(this.label3);
            this.grbSetTime.Location = new System.Drawing.Point(17, 6);
            this.grbSetTime.Name = "grbSetTime";
            this.grbSetTime.Size = new System.Drawing.Size(228, 64);
            this.grbSetTime.TabIndex = 0;
            this.grbSetTime.TabStop = false;
            this.grbSetTime.Text = "Set time";
            // 
            // numS
            // 
            this.numS.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.numS.Location = new System.Drawing.Point(157, 22);
            this.numS.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numS.Name = "numS";
            this.numS.Size = new System.Drawing.Size(45, 30);
            this.numS.TabIndex = 0;
            // 
            // numM
            // 
            this.numM.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.numM.Location = new System.Drawing.Point(86, 22);
            this.numM.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numM.Name = "numM";
            this.numM.Size = new System.Drawing.Size(45, 30);
            this.numM.TabIndex = 1;
            // 
            // numH
            // 
            this.numH.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.numH.Location = new System.Drawing.Point(15, 22);
            this.numH.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numH.Name = "numH";
            this.numH.Size = new System.Drawing.Size(45, 30);
            this.numH.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(203, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "s";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(134, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "m";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(63, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "h";
            // 
            // pnlTask
            // 
            this.pnlTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(227)))), ((int)(((byte)(233)))));
            this.pnlTask.Controls.Add(this.lblCountdown);
            this.pnlTask.Controls.Add(this.lblTimeRemaining);
            this.pnlTask.Controls.Add(this.prgTask);
            this.pnlTask.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTask.Location = new System.Drawing.Point(0, 236);
            this.pnlTask.Name = "pnlTask";
            this.pnlTask.Size = new System.Drawing.Size(370, 57);
            this.pnlTask.TabIndex = 3;
            this.pnlTask.Visible = false;
            // 
            // lblCountdown
            // 
            this.lblCountdown.AutoSize = true;
            this.lblCountdown.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCountdown.Location = new System.Drawing.Point(109, 12);
            this.lblCountdown.Name = "lblCountdown";
            this.lblCountdown.Size = new System.Drawing.Size(55, 15);
            this.lblCountdown.TabIndex = 2;
            this.lblCountdown.Text = "00:00:00";
            // 
            // lblTimeRemaining
            // 
            this.lblTimeRemaining.AutoSize = true;
            this.lblTimeRemaining.Location = new System.Drawing.Point(14, 12);
            this.lblTimeRemaining.Name = "lblTimeRemaining";
            this.lblTimeRemaining.Size = new System.Drawing.Size(94, 15);
            this.lblTimeRemaining.TabIndex = 1;
            this.lblTimeRemaining.Text = "Time remaining:";
            // 
            // prgTask
            // 
            this.prgTask.Location = new System.Drawing.Point(17, 34);
            this.prgTask.Name = "prgTask";
            this.prgTask.Size = new System.Drawing.Size(335, 10);
            this.prgTask.TabIndex = 0;
            // 
            // tmrTime
            // 
            this.tmrTime.Interval = 1000;
            this.tmrTime.Tick += new System.EventHandler(this.tmrTime_Tick);
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipText = "fsdgsdgs";
            this.notifyIcon.BalloonTipTitle = "gdgdfgdf";
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Shutdown Timer";
            this.notifyIcon.Visible = true;
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnSet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(370, 318);
            this.Controls.Add(this.pnlTask);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlStatus);
            this.Controls.Add(this.pnlTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Shutdown Timer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.pnlStatus.ResumeLayout(false);
            this.pnlStatus.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.grbOptions.ResumeLayout(false);
            this.grbOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWarn)).EndInit();
            this.grbSetTime.ResumeLayout(false);
            this.grbSetTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numH)).EndInit();
            this.pnlTask.ResumeLayout(false);
            this.pnlTask.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.GroupBox grbSetTime;
        private System.Windows.Forms.NumericUpDown numH;
        private System.Windows.Forms.NumericUpDown numS;
        private System.Windows.Forms.NumericUpDown numM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grbOptions;
        private System.Windows.Forms.CheckBox chkHybridOn;
        private System.Windows.Forms.RadioButton radSignOut;
        private System.Windows.Forms.RadioButton radRestart;
        private System.Windows.Forms.RadioButton radShutdown;
        private System.Windows.Forms.Panel pnlTask;
        private System.Windows.Forms.Timer tmrTime;
        private System.Windows.Forms.CheckBox chkForce;
        private System.Windows.Forms.Label lblCountdown;
        private System.Windows.Forms.Label lblTimeRemaining;
        private System.Windows.Forms.ProgressBar prgTask;
        internal System.Windows.Forms.Button btnInfo;
        internal ShutdownTimer.MenuButton btnPowerMenu;
        private System.Windows.Forms.CheckBox chkWarn;
        private System.Windows.Forms.CheckBox chkVietnamese;
        private System.Windows.Forms.Label lblminutes;
        private System.Windows.Forms.NumericUpDown numWarn;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}

