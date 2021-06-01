using Microsoft.Win32;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ServiceCenterAccounting
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
            RegistryKey currentUserKey = Registry.CurrentUser;
            string[] sub_keys = currentUserKey.GetSubKeyNames();
            if (!sub_keys.Contains("SCA_Key"))
            {
                RegistryKey SCA_Key = currentUserKey.CreateSubKey("SCA_Key");
                Initial_Setup setup = new Initial_Setup();
                setup.ShowDialog();
            }
            Authorization authorization = new Authorization();
            authorization.ShowDialog();
        }

        private void btn_Add_Order_Click(object sender, EventArgs e)
        {
            AddingAndChangingOrders adding = new AddingAndChangingOrders();
            adding.ShowDialog();
        }


        private void bnt_Reports_Click(object sender, EventArgs e)
        {
            Reports_Creator reports = new Reports_Creator();
            reports.ShowDialog();
        }
    }
}
