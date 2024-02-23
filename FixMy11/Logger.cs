using System;
using FixMy11.Forms;

namespace FixMy11
{
    internal class Logger
    {
        private static Logger instance;
        internal static Logger Instance
        {
            get
            {
                if (instance == null)
                    instance = new Logger();
                return instance;
            }
        }

        private Logger() { logForm = new LogForm(); }

        private LogForm logForm;

        internal void Log(string message)
        {
            if (logForm.InvokeRequired)
                logForm.Invoke(new Action(() => Log(message)));
            else
            {
                logForm.logTextBox.AppendText(message + Environment.NewLine);
                logForm.logTextBox.ScrollToCaret();
            }
        }

        internal void ShowLogForm() => logForm.Show();
    }
}