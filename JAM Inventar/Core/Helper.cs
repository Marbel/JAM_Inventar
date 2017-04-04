using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JAM_Inventar.Core
{
    public class Helper
    {
        // string to store current culture which is comon in all the forms
        public static String StrCulture { get; set; } = "de-DE";

        public static String getActualUser()
        {
            return Environment.UserName;
        }

        static public string GetStringRegistryValue(string key, string defaultValue)
        {
            RegistryKey localKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\JAM\JAM Inventar");
            if (localKey == null)
            {
                return defaultValue;
            }
            else
            {
                string keyValue = (String)localKey.GetValue(key);
                if (keyValue != "")
                {
                    return keyValue;
                }
                else
                {
                    return defaultValue;
                }
            }
        }

        static public void SetStringRegistryValue(string key, string stringValue)
        {
            RegistryKey localKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"Software\JAM\JAM Inventar");
            localKey.SetValue(key, stringValue);
        }

        public static void SetCulture()
        {
            CultureInfo objCI = new CultureInfo(Helper.StrCulture);
            Thread.CurrentThread.CurrentCulture = objCI;
            Thread.CurrentThread.CurrentUICulture = objCI;

        }

        public static bool IsDigitsOnly(string str)
        {
            try
            {
                Int32 test = Convert.ToInt32(str);
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }
    }
}
