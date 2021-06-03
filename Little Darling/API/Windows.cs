using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;
using System.Windows.Forms;

namespace LittleDarling
{
    public static class Windows
    {
        public static void ToggleStartupLaunch(bool enable)
        {
            string registryKeyName = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run";
            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(registryKeyName, writable: true);
            if (enable)
                registryKey.SetValue(Application.ProductName, Application.ExecutablePath);
            else
                registryKey.DeleteValue(Application.ProductName, throwOnMissingValue: false);
        }
    }
}
