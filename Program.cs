using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnifiAdopter
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());            
        }

        public static void AdoptDevice(string IP, string ControllerURL = "http://unifi.scharsich.dev:8080/inform")
        {
            using (var client = new Renci.SshNet.SshClient(IP, "ubnt", "ubnt"))
            {
                client.Connect();
                var cmd = client.CreateCommand("mca-cli-op set-inform " + ControllerURL);
                cmd.Execute();
                if (cmd.ExitStatus != 0)
                {
                    MessageBox.Show(cmd.Error);
                } else
                {
                    MessageBox.Show("Device " + IP + " adopted.");
                }
                client.Disconnect();
            }
        }
    }

}
