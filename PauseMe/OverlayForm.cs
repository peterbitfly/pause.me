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
        private readonly Action<int> _updateCountdownLabel;
        private Settings _settings;

        public OverlayForm(Settings settings)
        {
            InitializeComponent();

            _settings = settings;

            this.TopMost = true;
            this.ShowInTaskbar = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Opacity = 0.5;
            this.WindowState = FormWindowState.Maximized;
            this.DoubleBuffered = true;

            _updateCountdownLabel = (timer) => lblCountdown.Text = "Pause time: " + (new TimeSpan(0, 0, ((int)_settings.PauseTime.TotalSeconds) - timer)).ToShortString();
            _updateCountdownLabel(_CountDownTimer++);

            tmrCountdown.Start();
        }

        private void tmrCountdown_Tick(object sender, EventArgs e)
        {
            _updateCountdownLabel(_CountDownTimer++);

            if (_CountDownTimer > _settings.PauseTime.TotalSeconds)
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
