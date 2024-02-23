using System.Diagnostics;
using System.Windows.Forms;

namespace FixMy11.Forms
{
    public partial class LogForm : Form
    {
        public LogForm()
        {
            InitializeComponent();
        }

        #region Event Handlers

        #region Link Label

        private void sourceCodeLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            => Process.Start("https://github.com/Dan-Banfield/FixMy11");

        #endregion

        #region Form

        private void LogForm_FormClosing(object sender, FormClosingEventArgs e) => Application.Exit();

        #endregion

        #region Button

        private void continueButton_Click(object sender, System.EventArgs e)
        {
            if (PromptRestart())
            {
                RestartPC();
                return;
            }
            Application.Exit();
        }

        #endregion

        #endregion

        #region Methods

        private bool PromptRestart() => MessageBoxHelper.AskQuestion("It is highly recommended to restart your PC after making changes like these. Would you like to do so now?") == DialogResult.Yes;

        private void RestartPC() => Process.Start("shutdown", "/r /t 0");

        #endregion
    }
}