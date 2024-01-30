using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BBI_PhasmoHelperV1
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            StartUpMenu startup = new StartUpMenu();
            Application.Run(startup);

            if (startup.Mode == StartUpMenu.startMode.Server)
            {
                if (PassTest.TestPassword(startup.Password))
                {
                    //Application.Run(new ServerForm);
                }
                else
                {
                    MessageBox.Show("jaaaaaa, maar jij bent aldin niet");
                    MessageBox.Show("je dacht toch niet dat ik dit zou toestaan");
                    MessageBox.Show("en dan sterft je computer en heb ik het weer gedaan zeker");
                    MessageBox.Show("ik ben het zat");
                    MessageBox.Show("ik sluit hem af (de app)");
                    MessageBox.Show("hmm misschien toch wel je windows");
                    MessageBox.Show("nah lm dat zou niet lief zijn");
                    MessageBox.Show("maar niet meer doen!");
                    Application.Exit();
                }
            }
            else if (startup.Mode == StartUpMenu.startMode.ChangeGhostMode)
            {
                if (PassTest.TestPassword(startup.Password))
                {
                    Application.Run(new ChangeGhostForm(true));
                }
                else
                {
                    Application.Run(new ChangeGhostForm(false));
                }
            }
            else if (startup.Mode == StartUpMenu.startMode.Offline)
            {
                Application.Run(new MainForm());
            }
            else if (startup.Mode == StartUpMenu.startMode.NoneSelected)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Error: Unknown start mode");
                Application.Exit();
            }
        }
    }
}
