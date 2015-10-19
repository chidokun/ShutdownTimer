using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShutdownTimer
{
    public partial class frmMain : Form
    {

        public bool IsSet = false;
        public int h, m, s, second, secondMax;

        public frmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Convert user's selection into parameter
        /// </summary>
        /// <returns>Parameter to run</returns>
        public string SetParameter()
        {
            string parameter = null;
            if (radShutdown.Checked)
            {
                parameter += "/s ";
                if (chkHybridOn.Checked && chkHybridOn.Enabled)
                    parameter += "/hybrid ";
                if (chkForce.Checked && chkForce.Enabled)
                    parameter += "/f ";
            }
            else if (radRestart.Checked)
            {
                parameter += "/r ";
                if (chkForce.Checked && chkForce.Enabled)
                    parameter += "/f ";
            }
            else if (radSignOut.Checked)
            {
                parameter += "/l ";
                return parameter;
            }
            parameter += " /t 00";
            return parameter;
        }

        #region Tick counter

        /// <summary>
        /// Format an integer number to time format
        /// </summary>
        /// <param name="num">A positive integer number </param>
        /// <returns></returns>
        public string FormatTime(int num)
        {
            string str = num.ToString();
            return num < 10 && num >= 0 ? "0" + str : str;
        }

        /// <summary>
        /// Convert a time to second
        /// </summary>
        /// <param name="h">Number of hours</param>
        /// <param name="m">Number of minutes</param>
        /// <param name="s">Number of seconds</param>
        /// <returns></returns>
        public int ToSecond(int h, int m, int s)
        {
            if (h > 23 || m > 59 || s > 59)
                return -1;
            else
                return h * 3600 + m * 60 + s;
        }

        /// <summary>
        /// Count down the time, show in progress bar
        /// </summary>
        private void TimeCounter()
        {
            lblCountdown.Text = FormatTime(h) + ":" + FormatTime(m) + ":" + FormatTime(s);
            if (h != 0 || m != 0 || s != 0)
            {
                if (s != 0)
                    s--;
                else
                {
                    if (m == 0 && h > 0)
                    {
                        m = 59;
                        h--;
                    }

                    else if (m > 0) m--;
                    s = 59;
                }
                second--;
                prgTask.Value = 100 - 100 * second / secondMax;
                if (chkWarn.Checked && ((int)numWarn.Value * 60 == second))
                    notifyIcon.ShowBalloonTip(7, currentLanguage.Items["Notification.Balloon.Warn.Title"],
                        string.Format(currentLanguage.Items["Notification.Balloon.Warn.Detail"], (int)numWarn.Value), ToolTipIcon.Info);
            }
        }

        #endregion

        #region Status Bar
        /// <summary>
        /// Type of status
        /// </summary>
        public enum Status { Complete, Warning, Error, Information }

        public Color COLOR_BLUE = Color.FromArgb(38, 157, 202),
                     COLOR_ORANGE = Color.FromArgb(202, 81, 0),
                     COLOR_RED = Color.FromArgb(240, 0, 0),
                     COLOR_GREEN = Color.FromArgb(34, 177, 76);

        /// <summary>
        /// Set default status
        /// </summary>
        public void SetStatus()
        {
            SetStatus(currentLanguage.Items["Status.Default"], Status.Information);
        }

        /// <summary>
        /// Set status
        /// </summary>
        /// <param name="content">Content of status</param>
        /// <param name="sttType">Type of status</param>
        public void SetStatus(string content, Status sttType)
        {
            switch (sttType)
            {
                case Status.Complete:
                    pnlStatus.BackColor = COLOR_GREEN;
                    lblStatus.Text = content;
                    break;
                case Status.Warning:
                    pnlStatus.BackColor = COLOR_ORANGE;
                    lblStatus.Text = content;
                    break;
                case Status.Error:
                    pnlStatus.BackColor = COLOR_RED;
                    lblStatus.Text = content;
                    break;
                case Status.Information:
                    pnlStatus.BackColor = COLOR_BLUE;
                    lblStatus.Text = content;
                    break;
            }
        }

        #endregion

        #region Power Menu

        private void InitializePowerContextMenu()
        {
            btnPowerMenu.Menu = new ContextMenuStrip();
            btnPowerMenu.Menu.Items.Add("Shutdown Now", null, Shutdown_Click);
            btnPowerMenu.Menu.Items.Add("Restart Now", null, Restart_Click);
        }

        private void btnPowerMenu_Click(object sender, EventArgs e)
        {
            btnPowerMenu.Menu.Show(btnPowerMenu, btnPowerMenu.Width - btnPowerMenu.Size.Width, btnPowerMenu.Height);
        }

        private void Restart_Click(object sender, EventArgs e)
        {
            Shutdown restart = new Shutdown("-r -f -t 00");
            restart.Execute();
        }

        private void Shutdown_Click(object sender, EventArgs e)
        {
            Shutdown shutdown = new Shutdown("-s -f -t 00");
            shutdown.Execute();
        }
        #endregion

        #region Events Handle

        private void frmMain_Load(object sender, EventArgs e)
        {
            chkHybridOn.Enabled = Shutdown.HybridAbility();
            numWarn.Enabled = chkWarn.Checked;
            InitializeNotifyContextMenu();
            InitializePowerContextMenu();
            currentLanguage = chkVietnamese.Checked ? vietnamese : english;
            InitializeLanguage();
        }

        private void chkWarn_CheckedChanged(object sender, EventArgs e)
        {
            numWarn.Enabled = chkWarn.Checked;
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            h = (int)numH.Value;
            m = (int)numM.Value;
            s = (int)numS.Value;
            if (IsSet)
            {
                tmrTime.Stop();
                btnSet.Text = currentLanguage.Items["Main.ButtonSet"];
                pnlTask.Visible = false;
                IsSet = false;
                prgTask.Value = 0;
                second = 0;
                SetStatus();
                h = m = s = 0;
            }
            else
            {
                second = secondMax = ToSecond(h, m, s);
                tmrTime.Start();
                //Interface
                btnSet.Text = currentLanguage.Items["Main.ButtonCancel"];
                SetStatus(currentLanguage.Items["Status.TaskCompleted"], Status.Complete);
                pnlTask.Visible = true;
                IsSet = true;
            }
        }

        /// <summary>
        /// Radio button events is handled
        /// </summary>
        /// <param name="sender">Radio button that was clicked</param>
        /// <param name="e"></param>
        private void radio_CheckedChanged(object sender, EventArgs e)
        {
            chkForce.Enabled = radRestart.Checked || radShutdown.Checked;
            chkHybridOn.Enabled = radShutdown.Checked && Shutdown.HybridAbility();
        }

        private void tmrTime_Tick(object sender, EventArgs e)
        {
            Shutdown shutdown = new Shutdown();
            TimeCounter();
            if (h == 0 && m == 0 && s == 0)
            {
                shutdown.Parameter = SetParameter();
                shutdown.Execute();
            }

        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            Form frm = new frmAbout();
            frm.ShowDialog();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsSet)
            {
                DialogResult dlr = MessageBox.Show(currentLanguage.Items["Message.Exit.Text"],
                    currentLanguage.Items["Message.Exit.Title"], MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlr == DialogResult.No)
                    e.Cancel = true;
            }

        }
        #endregion

        #region Taskbar Notification

        private void InitializeNotifyContextMenu()
        {
            notifyIcon.ContextMenuStrip = new ContextMenuStrip();
            notifyIcon.ContextMenuStrip.Items.Add("&Options", null, Option_click);
            notifyIcon.ContextMenuStrip.Items.Add(new ToolStripSeparator());
            notifyIcon.ContextMenuStrip.Items.Add("&Shutdown Now", null, Shutdown_Click);
            notifyIcon.ContextMenuStrip.Items.Add("&Restart", null, Restart_Click);
            notifyIcon.ContextMenuStrip.Items.Add(new ToolStripSeparator());
            notifyIcon.ContextMenuStrip.Items.Add("E&xit", null, Exit_click);
        }

        private void Option_click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
                this.WindowState = FormWindowState.Normal;
            this.Focus();
        }

        private void Exit_click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Language
        public Language currentLanguage;
        Language vietnamese = new Language(LanguageName.Vietnamese);
        Language english = new Language(LanguageName.English);

        private void InitializeLanguage()
        {
            grbSetTime.Text = currentLanguage.Items["Main.GroupBoxTime.Title"];
            grbOptions.Text = currentLanguage.Items["Main.Option.Title"];
            btnPowerMenu.Menu.Items[0].Text = currentLanguage.Items["Main.Bar.PowerMenu.Shutdown"];
            btnPowerMenu.Menu.Items[1].Text = currentLanguage.Items["Main.Bar.PowerMenu.Restart"];
            btnSet.Text = IsSet ? currentLanguage.Items["Main.ButtonCancel"] : currentLanguage.Items["Main.ButtonSet"];
            radShutdown.Text = currentLanguage.Items["Main.Option.Radio.Shutdown"];
            radRestart.Text = currentLanguage.Items["Main.Option.Radio.Restart"];
            radSignOut.Text = currentLanguage.Items["Main.Option.Radio.SignOut"];
            chkHybridOn.Text = currentLanguage.Items["Main.Option.Check.UseHybridBoot"];
            chkForce.Text = currentLanguage.Items["Main.Option.Check.ForceStop"];
            chkVietnamese.Text = currentLanguage.Items["Main.Option.Check.UseVietnamese"];
            chkWarn.Text = currentLanguage.Items["Main.Option.Check.WarnBefore"];
            lblminutes.Text = currentLanguage.Items["Main.Option.Check.minute"];
            lblTimeRemaining.Text = currentLanguage.Items["Main.Run.TimeRemaining"];

            //Notification
            notifyIcon.ContextMenuStrip.Items[0].Text = currentLanguage.Items["Notification.Options"];
            notifyIcon.ContextMenuStrip.Items[2].Text = currentLanguage.Items["Notification.Shutdown"];
            notifyIcon.ContextMenuStrip.Items[3].Text = currentLanguage.Items["Notification.Restart"];
            notifyIcon.ContextMenuStrip.Items[5].Text = currentLanguage.Items["Notification.Exit"];

            //Status
            lblStatus.Text = IsSet ? currentLanguage.Items["Status.TaskCompleted"] : currentLanguage.Items["Status.Default"];
        }

        private void chkVietnamese_CheckedChanged(object sender, EventArgs e)
        {
            currentLanguage = chkVietnamese.Checked ? vietnamese : english;
            InitializeLanguage();
        }

        #endregion

    }
}
