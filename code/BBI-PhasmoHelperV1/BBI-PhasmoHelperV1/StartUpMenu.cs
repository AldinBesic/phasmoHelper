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

namespace BBI_PhasmoHelperV1
{
    public partial class StartUpMenu : Form
    {
        public StartUpMenu()
        {
            InitializeComponent();
        }
        public enum StartMode
        {
            Offline,
            Server,
            ChangeGhostMode,
            NoneSelected
        }
        public string Password { get; private set; }
        public StartMode Mode { get; private set; }

        private void StartUpMenu_Load(object sender, EventArgs e)
        {
            //assets directory
            string runningDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string assetsDirectory = Path.Combine(runningDirectory, "Assets");
            string ghostsDirectory = Path.Combine(runningDirectory, "Ghosts");
            //check if there are folders for the app to use, assets, ghosts, evidence. in the same directory as the exe
            if (!System.IO.Directory.Exists(assetsDirectory))
            {
                MessageBox.Show("Assets not found.");
                Application.Exit();
            }
            else if (!System.IO.Directory.Exists(ghostsDirectory))
            {
                MessageBox.Show("Ghosts not found.");
                Application.Exit();
            }
            Mode = StartMode.NoneSelected;
        }

        private void OfflineButton_Click(object sender, EventArgs e)
        {
            Mode = StartMode.Offline;
            Close();
        }

        private void ServerButton_Click(object sender, EventArgs e)
        {
            Mode = StartMode.Server;
            Password = pass.Text;
            Close();
        }

        private void AddOrChangeGhost_Click(object sender, EventArgs e)
        {
            Mode = StartMode.ChangeGhostMode;
            Password = pass.Text;
            Close();
        }
    }
}
