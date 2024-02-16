using Microsoft.Win32;

namespace FixMy11.Features.Privacy
{
    internal class DiagnosticData : IFeature
    {
        private const string KEY_NAME = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Privacy";
        private const int FIX_VALUE = 0;

        void IFeature.DoFeature()
        {
            try
            {
                Registry.SetValue(KEY_NAME, "TailoredExperiencesWithDiagnosticDataEnabled", FIX_VALUE, RegistryValueKind.DWord);
                MessageBoxHelper.ShowInformation("Successfully disabled diagnostic data.");
            }
            catch { MessageBoxHelper.ShowError("Failed to disable diagnostic data!"); }
        }

        void IFeature.UndoFeature()
        {
            try
            {
                Registry.SetValue(KEY_NAME, "TailoredExperiencesWithDiagnosticDataEnabled", 1, RegistryValueKind.DWord);
                MessageBoxHelper.ShowInformation("Successfully enabled diagnostic data.");
            }
            catch { MessageBoxHelper.ShowError("Failed to enable diagnostic data!"); }
        }
    }
}