using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PauseMe
{
    public partial class OverlayForm : Form
    {
        private int _CountDownTimer = 0;

        public OverlayForm()
        {
            InitializeComponent();
            this.TopMost = true;
            this.ShowInTaskbar = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Opacity = 0.5;
            this.WindowState = FormWindowState.Maximized;
            this.DoubleBuffered = true;

            lblCountdown.Text = "";

            lblCountdown.Text = "Pause time: " + (20 - _CountDownTimer++) + "s";

            tmrCountdown.Start();
        }

        private void tmrCountdown_Tick(object sender, EventArgs e)
        {
            lblCountdown.Text = "Pause time: " + (20 - _CountDownTimer++) + "s";

            if (_CountDownTimer == 21)
            {
                _CountDownTimer = 0;
                tmrCountdown.Stop();
                this.Close();
            }
        }

        private void lblCountdown_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
