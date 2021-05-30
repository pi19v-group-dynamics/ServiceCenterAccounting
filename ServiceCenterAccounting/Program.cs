using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceCenterAccounting
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            RegistryKey currentUserKey = Registry.CurrentUser;
            //currentUserKey.DeleteSubKey("SCA_Key");
            string[] sub_keys = currentUserKey.GetSubKeyNames();
            if(sub_keys.Contains("SCA_Key"))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form_Main());
            }
            else
            {
                RegistryKey SCA_Key = currentUserKey.CreateSubKey("SCA_Key");
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Initial_Setup());
            }
        }
    }
}
