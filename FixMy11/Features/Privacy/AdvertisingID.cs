﻿using Microsoft.Win32;

namespace FixMy11.Features.Privacy
{
    internal class AdvertisingID : FeatureBase
    {
        private static AdvertisingID instance;
        internal static AdvertisingID Instance
        {
            get
            {
                if (instance == null)
                    instance = new AdvertisingID();
                return instance;
            }
        }

        private AdvertisingID() { }

        private const int FIX_VALUE = 0;
        private const string KEY_NAME = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\AdvertisingInfo";

        internal override void DoFeature()
        {
            try
            {
                Registry.SetValue(KEY_NAME, "Enabled", FIX_VALUE, RegistryValueKind.DWord);
                Logger.Instance.Log("Successfully disabled Advertising ID.");
            }
            catch { Logger.Instance.Log("Failed to disable advertising ID!"); }
        }

        internal override void UndoFeature()
        {
            try
            {
                Registry.SetValue(KEY_NAME, "Enabled", 1, RegistryValueKind.DWord);
                Logger.Instance.Log("Successfully enabled Advertising ID.");
            }
            catch { Logger.Instance.Log("Failed to enable advertising ID!"); }
        }
    }
}