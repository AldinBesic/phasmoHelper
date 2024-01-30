using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BBI_PhasmoHelperV1
{
    public partial class MainForm : Form
    {
        #region //readonly vars
        readonly string preWord = "This is the BBI International phasmophobia helper version: ";
        readonly string helpText = "You can use me to find out strategies for certain ghosts and see the map you're an with greater ease than the wiki. Everything here is either found on the wiki or written using experience. feedback and tips are always welcome! Happy hunting. -Aldin Besic 2024";
        readonly string versionText = "Version 1.0.0 ";
        /* TODO
         * -Timer toevoegen
        */
        #endregion

        #region // actual vars
        private enum EvidenceButtonStates
        {
            Found,
            CrossedOut,
            Possible
        };
        #endregion


        public MainForm()
        {
            InitializeComponent();
            helpText = preWord + versionText + helpText;
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(helpText);
        }

        private void addNewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string password = toolStripPassTB.Text;
            if (PassTest.TestPassword(password))
            {
                new ChangeGhostForm(true).ShowDialog();
            }
            else
            {
                new ChangeGhostForm(false).ShowDialog();
            }
        }
    }
}
