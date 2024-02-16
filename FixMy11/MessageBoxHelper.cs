using System.Windows.Forms;

namespace FixMy11
{
    internal static class MessageBoxHelper
    {
        internal static void ShowInformation(string text)
        {
            MessageBox.Show(text, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        internal static void ShowError(string text)
        {
            MessageBox.Show(text, "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}