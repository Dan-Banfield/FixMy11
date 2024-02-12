using System;
using OSVersionExtension;
using System.Windows.Forms;
using OperatingSystem = OSVersionExtension.OperatingSystem;

namespace FixMy11
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            /* Ensure the user is running the program on Windows 11
             * as it's untested on other Windows versions. */

            if (!(OSVersion.GetOperatingSystem() == OperatingSystem.Windows11))
            {
                MessageBox.Show("This application only supports Windows 11 builds. Thank you for your patience.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }

            Application.Run(new Form1());
        }
    }
}