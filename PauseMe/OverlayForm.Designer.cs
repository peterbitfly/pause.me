namespace PauseMe
{
    partial class OverlayForm
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
            this.lblCountdown = new System.Windows.Forms.Label();
            this.tmrCountdown = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblCountdown
            // 
            this.lblCountdown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCountdown.Font = new System.Drawing.Font("Monotype Corsiva", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountdown.Location = new System.Drawing.Point(0, 0);
            this.lblCountdown.Name = "lblCountdown";
            this.lblCountdown.Size = new System.Drawing.Size(796, 327);
            this.lblCountdown.TabIndex = 1;
            this.lblCountdown.Text = "Countdown Timer";
            this.lblCountdown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCountdown.Click += new System.EventHandler(this.lblCountdown_Click);
            // 
            // tmrCountdown
            // 
            this.tmrCountdown.Interval = 1000;
            this.tmrCountdown.Tick += new System.EventHandler(this.tmrCountdown_Tick);
            // 
            // OverlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 327);
            this.Controls.Add(this.lblCountdown);
            this.Name = "OverlayForm";
            this.Text = "OverlayForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCountdown;
        private System.Windows.Forms.Timer tmrCountdown;
    }
}