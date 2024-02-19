using System.Windows.Forms;

namespace FixMy11
{
    internal static class MessageBoxHelper
    {
        internal static DialogResult ShowInformation(string text) => MessageBox.Show(text, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        internal static DialogResult ShowError(string text) => MessageBox.Show(text, "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);

        internal static DialogResult AskQuestion(string text) => MessageBox.Show(text, "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
    }
}