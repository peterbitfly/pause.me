/*
 * ----------------------------------------------------------------------------
 * "THE BEER-WARE LICENSE" (Revision 42):
 * <peter@pratscher.org> wrote this file.  As long as you retain this notice you
 * can do whatever you want with this stuff. If we meet some day, and you think
 * this stuff is worth it, you can buy me a beer in return.   Poul-Henning Kamp
 * ----------------------------------------------------------------------------
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PauseMe
{
    public partial class MainForm : Form
    {
        private int _CountDownTimer = 0;

        private DateTime _TimerStarted;

        public MainForm()
        {
            InitializeComponent();

            this.TopMost = true;
            this.ShowInTaskbar = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Opacity = 0.5;
            this.WindowState = FormWindowState.Maximized;

            lblCountdown.Text = "";
            tbxStatus.Text = "Stopped";

            tmrMain_Tick(null, null);
        }

        private void tmrCountdown_Tick(object sender, EventArgs e)
        {
            lblCountdown.Text = "Pause time: " + (20 - _CountDownTimer++) + "s";

            if (_CountDownTimer == 21)
            {
                _CountDownTimer = 0;
                tmrCountdown.Stop();
                this.Hide();
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tmrMain.Start();
            _TimerStarted = DateTime.Now;
            tmrUpdateStatus.Start();

            tbxStatus.Text = "Running";
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tmrMain.Stop();
            tmrUpdateStatus.Stop();
            tbxStatus.Text = "Stopped";
            niMain.Text = "Pause Me - Stopped";
        }

        private void lblCountdown_Click(object sender, EventArgs e)
        {
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            BeginInvoke(new MethodInvoker(delegate
            {
                Hide();
                startToolStripMenuItem_Click(this, null);
                niMain.ShowBalloonTip(5000, "Pause Me Started", "Pause Me has been started an will gently remind you every 20 minutes to rest your eyes!", ToolTipIcon.Info);
            }));
        }

        private void tmrMain_Tick(object sender, EventArgs e)
        {
            lblCountdown.Text = "Pause time: " + (20 - _CountDownTimer++) + "s";
            this.Show();
            _TimerStarted = DateTime.Now;
            tmrCountdown.Start();
        }

        private void lblCountdown_DoubleClick(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void tmrUpdateStatus_Tick(object sender, EventArgs e)
        {
            var timePassed = (DateTime.Now - (_TimerStarted.AddMinutes(20))).Negate();
            var minutesPassed = timePassed.Minutes.ToString("00");
            var secondsPassed = timePassed.Seconds.ToString("00");

            tbxStatus.Text = "Running (" + minutesPassed + ":" + secondsPassed + ")";
            niMain.Text = "Pause Me - Running (" + minutesPassed + ":" + secondsPassed + ")";
        }
    }
}
