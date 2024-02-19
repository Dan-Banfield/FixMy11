using Microsoft.Win32;

namespace FixMy11.Features.Privacy
{
    internal class LocationTracking : FeatureBase
    {
        private static LocationTracking instance;
        internal static LocationTracking Instance
        {
            get
            {
                if (instance == null)
                    instance = new LocationTracking();
                return instance;
            }
        }

        private LocationTracking() { }

        private const string FIX_VALUE = "Deny";
        private const string KEY_NAME = @"HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\CapabilityAccessManager\ConsentStore\location";

        internal override void DoFeature()
        {
            try
            {
                Registry.SetValue(KEY_NAME, "Value", FIX_VALUE, RegistryValueKind.String);
                MessageBoxHelper.ShowInformation("Location tracking disabled successfully.");
            }
            catch { MessageBoxHelper.ShowError("Failed to disable location tracking!"); }
        }

        internal override void UndoFeature()
        {
            try
            {
                Registry.SetValue(KEY_NAME, "Value", "Allow", RegistryValueKind.String);
                MessageBoxHelper.ShowInformation("Location tracking enabled successfully.");
            }
            catch { MessageBoxHelper.ShowError("Failed to enable location tracking!"); }
        }
    }
}