using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BBI_PhasmoHelperV1
{
    public partial class ChangeGhostForm : Form
    {
        enum PrimaryEvidenceType
        {
            EMF5,
            SpiritBox,
            Ultraviolet,
            GhostOrbs,
            GhostWriting,
            FreezingTemperatures,
            Dots
        }
        private bool sudo = false;
        public ChangeGhostForm(bool sudo)
        {
            InitializeComponent();
            LoadComboBoxItems(true);
            if (!sudo)
            {
                ghostNameTB.Enabled = false;
                e1CB.Enabled = false;
                e2CB.Enabled = false;
                e3CB.Enabled = false;
                breakerCheckB.Enabled = false;
                lightsCheckB.Enabled = false;
                strengthsTB.Enabled = false;
                weaknessTB.Enabled = false;
                StratsTB.Enabled = false;
                abilityTB.Enabled = false;
                huntThreshholdTB.Enabled = false;
            }
            this.sudo = sudo;
        }

        private Ghost ghost;
        private void LoadComboBoxItems(bool all)
        {
            if (all)
            {
                //clear the combobox
                GhostCB.Items.Clear();

                string runningDirectory = AppDomain.CurrentDomain.BaseDirectory;
                string ghostsDirectory = Path.Combine(runningDirectory, "ghosts");
                if (Directory.Exists(ghostsDirectory))
                {
                    // get all the files in the runningDirectory
                    string[] files = Directory.GetFiles(ghostsDirectory);

                    // first clear the combobox
                    GhostCB.Items.Clear();

                    // add please select to the combobox
                    GhostCB.Items.Add("please select");

                    // add all the files to the combobox
                    foreach (string file in files)
                    {
                        GhostCB.Items.Add(Path.GetFileNameWithoutExtension(file));
                    }
                }
            }
            // clear the comboboxes
            e1CB.Items.Clear();
            e2CB.Items.Clear();
            e3CB.Items.Clear();
            foreach (object item in Enum.GetValues(typeof(PrimaryEvidenceType)))
            {
                e1CB.Items.Add(item);
                e2CB.Items.Add(item);
                e3CB.Items.Add(item);
            }
        }


        private void importGhostBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Text Files (*.txt)|*.txt",
                Title = "Select a Ghost File"
            })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        MessageBox.Show("nog niet gemaakt");
                        //string filePath = openFileDialog.FileName;
                        //string[] lines = File.ReadAllLines(filePath);

                        //foreach (string line in lines)
                        /*{
                            if (line.StartsWith("Drone: "))
                            {
                                //droneNameTB.Text = line.Substring("Drone: ".Length);
                            }
                            else if (line.StartsWith("Adress: "))
                            {
                                //adressTB.Text = line.Substring("Adress: ".Length);
                        }
                        }*/
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            // first fill the type with the ghost info, this way the error handling is already done
            try
            {
                // add evidence to the array
                String[] evidence = { e1CB.SelectedItem.ToString(), e2CB.SelectedItem.ToString(), e3CB.SelectedItem.ToString() };
                ghost = new Ghost(ghostNameTB.Text, evidence, breakerCheckB.Checked, lightsCheckB.Checked, strengthsTB.Text, weaknessTB.Text, StratsTB.Text, noteTB.Text, abilityTB.Text, huntThreshholdTB.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return; // make sure nothing gets saved
            }

            // get the runningDirectory of the exe
            string runningDirectory = AppDomain.CurrentDomain.BaseDirectory;

            // check if the ghosts runningDirectory already exists in the same runningDirectory as the exe, if not, create one, making sure to handle the exeptions
            try
            {
                string ghostsDirectory = Path.Combine(runningDirectory, "Ghosts");
                if (!Directory.Exists(ghostsDirectory))
                {
                    Directory.CreateDirectory(ghostsDirectory);
                }

                // create or overwrite the file
                string ghostFile = Path.Combine(ghostsDirectory, $"{ghost.Name}.txt");
                using (FileStream fs = File.Create(ghostFile))
                {

                }

                // save the textboxes to the file
                string[] lines = {$"E1: {e1CB.Text}", $"E2: {e2CB.Text}", $"E3: {e3CB.Text}", $"Strengths: {strengthsTB.Text}", $"Weakness: {weaknessTB.Text}", $"Strats: {StratsTB.Text}", $"Note: {noteTB.Text}", $"Ability: {abilityTB.Text}", $"Threshold: {huntThreshholdTB.Text}" };
                // add the breaker and lights to the file if they are checked
                if (breakerCheckB.Checked)
                {
                    lines.Append("TurnsOffBreaker");
                }
                if (lightsCheckB.Checked)
                {
                    lines.Append("TurnsOffLights");
                }
                File.WriteAllLines(ghostFile, lines);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            LoadComboBoxItems(true);
        }

        private void GhostCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool instantiate = false;
            if (GhostCB.SelectedItem.ToString() == "please select")
            {
                // reset the textboxes to standard values
                ghostNameTB.Text = "";
                weaknessTB.Text = "";
                strengthsTB.Text = "";
                StratsTB.Text = "Strat";
                noteTB.Text = "Note";
                abilityTB.Text = "";
                huntThreshholdTB.Text = "60%";
                LoadComboBoxItems(false);
                return;
            }
            else
            {
                instantiate = true;
            }

            string selectedGhost = GhostCB.SelectedItem.ToString();

            // Get the runningDirectory of the exe
            string directory = AppDomain.CurrentDomain.BaseDirectory;

            // Check if the relay runningDirectory already exists in the same runningDirectory as the exe
            string ghostsDirectory = Path.Combine(directory, "Ghosts");

            // Check if the file exists
            string ghostFile = Path.Combine(ghostsDirectory, $"{selectedGhost}.txt");
            try
            {
                if (File.Exists(ghostFile))
                {
                    // Read the file lines
                    string[] lines = File.ReadAllLines(ghostFile);

                    foreach (string line in lines)
                    {
                        //name is the same as the file name
                        ghostNameTB.Text = selectedGhost;

                        if (line.StartsWith("Weakness: "))
                        {
                            weaknessTB.Text = line.Substring("Weakness: ".Length);
                        }
                        else if (line.StartsWith("Strengths: "))
                        {
                            strengthsTB.Text = line.Substring("Strengths: ".Length);
                        }
                        else if (line.StartsWith("Strats: "))
                        {
                            StratsTB.Text = line.Substring("Strats: ".Length);
                        }
                        else if (line.StartsWith("Note: "))
                        {
                            noteTB.Text = line.Substring("Note: ".Length);
                        }
                        else if (line.StartsWith("E1"))
                        {
                            string evidence = line.Substring("E1: ".Length);
                            e1CB.SelectedItem = Enum.Parse(typeof(PrimaryEvidenceType), evidence);
                        }
                        else if (line.StartsWith("E2"))
                        {
                            string evidence = line.Substring("E2: ".Length);
                            e2CB.SelectedItem = Enum.Parse(typeof(PrimaryEvidenceType), evidence);
                        }
                        else if (line.StartsWith("E3"))
                        {
                            string evidence = line.Substring("E3: ".Length);
                            e3CB.SelectedItem = Enum.Parse(typeof(PrimaryEvidenceType), evidence);
                        }
                        else if (line.StartsWith("Ability:"))
                        {
                            abilityTB.Text = line.Substring("Ability: ".Length);
                        }
                        else if (line.StartsWith("Threshold:"))
                        {
                            huntThreshholdTB.Text = line.Substring("Threshold: ".Length);
                        }
                        else if (line.StartsWith("TurnsOffBreaker"))
                        {
                            breakerCheckB.Checked = true;
                        }
                        else if (line.StartsWith("TurnsOffLights"))
                        {
                            lightsCheckB.Checked = true;
                        }
                    }
                }
                else
                {
                    throw new FileNotFoundException("File not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (instantiate)
            {
                try
                {
                    string[] evidence = { e1CB.SelectedItem.ToString(), e2CB.SelectedItem.ToString(), e3CB.SelectedItem.ToString() };
                    ghost = new Ghost(ghostNameTB.Text, evidence, breakerCheckB.Checked, lightsCheckB.Checked, strengthsTB.Text, weaknessTB.Text, StratsTB.Text, noteTB.Text, abilityTB.Text, huntThreshholdTB.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}