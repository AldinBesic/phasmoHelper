using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public enum startMode
        {
            Offline,
            Server,
            ChangeGhostMode,
            NoneSelected
        }
        public string Password { get; private set; }
        public startMode Mode { get; private set; }

        private void StartUpMenu_Load(object sender, EventArgs e)
        {
            //check if there are folders for the app to use, assets, ghosts, evidence. in the same directory as the exe
            if (System.IO.Directory.Exists("Assets") && System.IO.Directory.Exists("Ghosts") && System.IO.Directory.Exists("Evidence"))
            {
                //if there are, continue
            }
            else
            {
                //if not, throw error and close app
                MessageBox.Show("Error: Missing directory/directories. aka. bel Aldin, shit is kapot" +
                    "    ERR, MISDIR 0x1");
                //Application.Exit();
            }
            Mode = startMode.NoneSelected;
        }

        private void OfflineButton_Click(object sender, EventArgs e)
        {
            Mode = startMode.Offline;
            Close();
        }

        private void ServerButton_Click(object sender, EventArgs e)
        {
            Mode = startMode.Server;
            Password = pass.Text;
            Close();
        }

        private void AddOrChangeGhost_Click(object sender, EventArgs e)
        {
            Mode = startMode.ChangeGhostMode;
            Password = pass.Text;
            Close();
        }
    }
}
