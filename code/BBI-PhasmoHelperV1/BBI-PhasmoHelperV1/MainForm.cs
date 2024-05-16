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

        public enum PrimaryEvidenceType
        {
            EMF5,
            SpiritBox,
            Fingerprints,
            GhostOrbs,
            GhostWriting,
            FreezingTemperatures,
            Dots
        }
        #endregion

        #region // actual vars
        private enum EvidenceButtonStates
        {
            TBD,
            Found,
            CrossedOut,
            Possible
        };
        List<ButtonHandler> buttons = new List<ButtonHandler>();
        //List<EvidenceButtonStates> evidenceButtonStates = new List<EvidenceButtonStates>();
        List<string> evidence = new List<string>();
        List<string> antiEvidence = new List<string>();
        List<Ghost> ghosts = new List<Ghost>(); // all the remaining ghosts are in this list
        bool turnsOffBreaker = true;
        bool turnsOnLights = true;
        int currentGhostIndex = 0;
        Server server;
        #endregion


        public MainForm()
        {
            InitializeComponent();
            helpText = preWord + versionText + helpText;
            Reset();
            ButtonList();
        }

        void Reset()
        {
            //clear the buttons

            //clear the evidence list
            evidence.Clear();

            //clear the ghosts list
            ghosts.Clear();

            turnsOnLights = true;
            turnsOffBreaker = true;

            LoadAllGhostsIntoList();
            LoadAllGhostsInTexbox();
        }

        private void LoadAllGhostsIntoList()
        {
            //clear the ghosts list
            ghosts.Clear();
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
                //make a ghost from the file

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

        private void RemoveNonRelevantGhosts(bool secondary)
        {
            List<Ghost> ghostsToRemove = new List<Ghost>();
            /* if (secondary)
             {
                 foreach (Ghost ghost in ghosts)
                 {
                     if (turnsOnLights)
                     {
                         if (!ghost.CanTurnOnLights)
                         {
                               ghostsToRemove.Add(ghost);
                         }
                     }
                     if (turnsOffBreaker)
                     {
                         if (!ghost.TurnsOffBreaker)
                         {
                             ghostsToRemove.Add(ghost);
                         }
                     }

                 }
             }
             else*/
            //{
            foreach (string evidence in evidence)
            {
                foreach (Ghost ghost in ghosts)
                {
                    if (!ghost.HasEvidence(evidence))
                    {
                        ghostsToRemove.Add(ghost);
                    }
                }
            }
            foreach (string evidence in antiEvidence)
            {
                foreach (Ghost ghost in ghosts)
                {
                    if (ghost.HasEvidence(evidence))
                    {
                        ghostsToRemove.Add(ghost);
                    }
                }
            }
            //}

            foreach (Ghost ghost in ghostsToRemove)
            {
                ghosts.Remove(ghost);
            }

            LoadAllGhostsInTexbox();
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

        private void ButtonList()
        {
            //add all the buttons to the list
            List<string> buttonsToAdd = new List<string>();
            buttonsToAdd.Add("EMF 5");
            buttonsToAdd.Add("Spirit box");
            buttonsToAdd.Add("UV");
            buttonsToAdd.Add("Ghost orbs");
            buttonsToAdd.Add("Ghost writing");
            buttonsToAdd.Add("Freezing temps");
            buttonsToAdd.Add("Dots");
            buttonsToAdd.Add("Turns lights on");
            buttonsToAdd.Add("Breaker shutoff");

            foreach (string buttonTA in buttonsToAdd)
            {
                buttons.Add(new ButtonHandler(buttonTA));
            }

        }

        private void EvidenceBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button clickedButton = sender as System.Windows.Forms.Button;
            if (clickedButton != null)
            {
                //find out what button is clicked using the list and switch the state
                foreach (ButtonHandler buttonToChange in buttons)
                {
                    if (buttonToChange.Text == clickedButton.Text)
                    {
                        buttonToChange.ChangeState();
                        if (clickedButton.Text != "Breaker shutoff" && clickedButton.Text != "Turns lights on")
                        {
                            switch (buttonToChange.CurrentState.ToString())
                            {
                                case "TBD":
                                    //test if the corresponding evidence is in the list and remove it
                                    if (evidence.Contains(buttonToChange.Text))
                                    {
                                        evidence.Remove(buttonToChange.Text);
                                    }
                                    if (antiEvidence.Contains(buttonToChange.Text))
                                    {
                                        antiEvidence.Remove(buttonToChange.Text);
                                    }
                                    clickedButton.BackColor = Color.Gray;
                                    break;
                                case "Found":
                                    if (!evidence.Contains(buttonToChange.Text))
                                    {
                                        evidence.Add(buttonToChange.Text);
                                    }
                                    if (antiEvidence.Contains(buttonToChange.Text))
                                    {
                                        antiEvidence.Remove(buttonToChange.Text);
                                    }
                                    clickedButton.BackColor = Color.Green;
                                    break;
                                case "CrossedOut":
                                    if (evidence.Contains(buttonToChange.Text))
                                    {
                                        evidence.Remove(buttonToChange.Text);
                                    }
                                    if (!antiEvidence.Contains(buttonToChange.Text))
                                    {
                                        antiEvidence.Add(buttonToChange.Text);
                                    }
                                    clickedButton.BackColor = Color.Red;

                                    break;
                                case "Possible": // this is the same as TBD, only difference is for the user (color)
                                    if (evidence.Contains(buttonToChange.Text))
                                    {
                                        evidence.Remove(buttonToChange.Text);
                                    }
                                    if (antiEvidence.Contains(buttonToChange.Text))
                                    {
                                        antiEvidence.Remove(buttonToChange.Text);
                                    }
                                    clickedButton.BackColor = Color.Yellow;
                                    break;
                                default:
                                    MessageBox.Show("Something went wrong. bel/app aldin, buttonToChangeSwitchingERR");
                                    break;
                            }
                            LoadAllGhostsIntoList();
                            RemoveNonRelevantGhosts(false);
                        }
                        else
                        {
                            switch (buttonToChange.CurrentState.ToString())
                            {
                                case "TBD":
                                    clickedButton.BackColor = Color.Gray;
                                    if (clickedButton.Text == "Turns lights on")
                                    {
                                        turnsOnLights = true;
                                    }
                                    else if (clickedButton.Text == "Breaker shutoff")
                                    {
                                        turnsOffBreaker = true;
                                    }
                                    break;
                                case "Found":
                                    clickedButton.BackColor = Color.Green;
                                    if (clickedButton.Text == "Turns lights on")
                                    {
                                        turnsOnLights = true;
                                    }
                                    else if (clickedButton.Text == "Breaker shutoff")
                                    {
                                        turnsOffBreaker = true;
                                    }
                                    break;
                                case "CrossedOut":
                                    clickedButton.BackColor = Color.Red;
                                    if (clickedButton.Text == "Turns lights on")
                                    {
                                        turnsOnLights = false;
                                    }
                                    else if (clickedButton.Text == "Breaker shutoff")
                                    {
                                        turnsOffBreaker = false;
                                    }
                                    break;
                                case "Possible": // this is the same as TBD, only difference is for the user (color)
                                    clickedButton.BackColor = Color.Yellow;
                                    if (clickedButton.Text == "Turns lights on")
                                    {
                                        turnsOnLights = true;
                                    }
                                    else if (clickedButton.Text == "Breaker shutoff")
                                    {
                                        turnsOffBreaker = true;
                                    }
                                    break;
                                default:
                                    MessageBox.Show("Something went wrong. bel/app aldin, secondary buttonToChangeSwitchingERR");
                                    break;
                            }
                            LoadAllGhostsIntoList();
                            RemoveNonRelevantGhosts(true);
                        }
                    }
                }
            }


        }

        private void resetEvidence_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void WriteToConsole(string text)
        {
            consoleTextBox.AppendText(text + Environment.NewLine);
        }

        private void ResetGhostInfoGUI()
        {
            ghostNameLBL.Text = "Ghost name";
            e1LBL.Text = "E1";
            e2LBL.Text = "E2";
            e3LBL.Text = "E3";
            strengthsTB.Text = "Strengths:";
            weaknessTB.Text = "Weaknesses:";
            abilityTB.Text = "Ability:";
            noteTB.Text = "Note:";
        }

        /// <summary>
        /// here the displaying of the selected ghost's info will be done, it will show up in the ghostinfo group
        /// </summary>
        /// <param name="highlightedGhost"></param>
        private void DisplayGhostInfo(Ghost highlightedGhost)
        {
            //first reset/add the template text
            ResetGhostInfoGUI();

            //add the ghost's info into all the different lbls and textboxes
            ghostNameLBL.Text = highlightedGhost.Name;
            e1LBL.Text = highlightedGhost.Evidence[0];
            e2LBL.Text = highlightedGhost.Evidence[1];
            e3LBL.Text = highlightedGhost.Evidence[2];
            strengthsTB.Text = "Strengths: " + highlightedGhost.Strengths;
            weaknessTB.Text = "Weaknesses: " + highlightedGhost.Weaknesses;
            abilityTB.Text = "Ability: " + highlightedGhost.Ability;
            noteTB.Text = "Note: " + highlightedGhost.Note;
        }

        private void mainForm_KeyDown(object sender, KeyEventArgs e) // not used yet
        {
            if (e.KeyCode == Keys.Enter)
            {
                WriteToConsole("Enter pressed");
                //handle the enter key and commands
            }
            else if (e.KeyCode == Keys.Right)
            {
                WriteToConsole("Right pressed");
                //handle the right key and commands
            }
            else if (e.KeyCode == Keys.Left)
            {
                WriteToConsole("Left pressed");
                //handle the left key and commands
            }
        }

        private void NextGhost(object sender, EventArgs e)
        {
            if (ghosts.Count > 0)
            {
                if (currentGhostIndex < ghosts.Count - 1)
                {
                    currentGhostIndex++;
                }
                else
                {
                    currentGhostIndex = 0;
                }
                DisplayGhostInfo(ghosts[currentGhostIndex]);
            }
        }

        private void PreviousGhost(object sender, EventArgs e)
        {
            if (ghosts.Count > 0)
            {
                if (currentGhostIndex > 0)
                {
                    currentGhostIndex--;
                }
                else
                {
                    currentGhostIndex = ghosts.Count - 1;
                }
                DisplayGhostInfo(ghosts[currentGhostIndex]);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void ExtraGB_Enter(object sender, EventArgs e)
        {

        }
    }
}