using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            TBD,
            Found,
            CrossedOut,
            Possible
        };
        List<string> evidence = new List<string>();
        List<Ghost> ghosts = new List<Ghost>();
        bool turnsOffBreaker = true;
        bool turnsOffLights = true;
        #endregion


        public MainForm()
        {
            InitializeComponent();
            helpText = preWord + versionText + helpText;
            Reset();

        }

        private void Reset()
        { 
            //clear the buttons

            //clear the evidence list
            evidence.Clear();

            //clear the ghosts list
            ghosts.Clear();

            turnsOffLights = true;
            turnsOffBreaker = true;

            LoadAllGhostsIntoList();
            LoadAllGhostsInTexbox();
        }

        private void LoadAllGhostsIntoList()
        {
            //current directory
            string runningDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string ghostsDirectory = Path.Combine(runningDirectory, "ghosts");
            // get all the files in the runningDirectory
            string[] files = Directory.GetFiles(ghostsDirectory);

            //prepare each file for creating a ghost object
            foreach (string file in files)
            {
                //remove .txt from the filename
                string fileName = Path.GetFileNameWithoutExtension(file);
                ghosts.Add(FileHandler.FileInGhostOut(fileName));
            }
        }

        private void LoadAllGhostsInTexbox()
        {

            // first clear the textbox
            remainingGhostsTB.Text = "";
            // add all the files to the combobox
            foreach (Ghost ghost in ghosts)
            {
                remainingGhostsTB.Text += ghost.Name + "\r\n";
            }
        }

        private void RemoveNonRelevantGhosts()
        {
            foreach (string evidence in evidence)
            {
                foreach (Ghost ghost in ghosts)
                {
                    if (!ghost.HasEvidence(evidence))
                    {
                        ghosts.Remove(ghost);
                    }
                }
            }
        }

        private void DisplayGhostInfo(string highlightedGhost)
        {
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
