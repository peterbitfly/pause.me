using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PauseMe
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var settings = new Settings(new TimeSpan(0, 0, 20), new TimeSpan(0, 0, 20));

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(settings));
        }
    }
}
