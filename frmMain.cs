using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Renci.SshNet;

namespace UnifiAdopter
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnAdopt_Click(object sender, EventArgs e)
        {
            Program.AdoptDevice(txtDevice.Text, txtController.Text);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            var cmdArgs = Environment.GetCommandLineArgs();
            if (cmdArgs.Length == 2)
            {
                Program.AdoptDevice(cmdArgs[1]);
                Application.Exit();
            } else
            {
                if (cmdArgs.Length == 3)
                {
                    Program.AdoptDevice(cmdArgs[1], cmdArgs[2]);
                    Application.Exit();
                }
            }
        }
    }
}
