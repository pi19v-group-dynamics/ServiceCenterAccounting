using System;
using System.Windows.Forms;
using Microsoft.Win32;

namespace ServiceCenterAccounting
{
    public partial class Authorization : Form
    {
        bool is_have_login = false;
        bool is_have_passvord = false;

        public Authorization()
        {
            InitializeComponent();
        }

        private void Eng_and_Digits_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '_' || e.KeyChar == (char)Keys.Back)
            {

            }
            else
            {
                e.Handled = true;
            }
        }

        private void tb_Login_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tb_Login.Text) || tb_Login.Text.StartsWith(" "))
            {
                l_Warning1.Visible = true;
                is_have_login = false;
            }
            else
            {
                is_have_login = true;
                l_Warning1.Visible = false;
            }
        }

        private void tb_Password_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tb_Login.Text) || tb_Login.Text.StartsWith(" "))
            {
                l_Warning2.Visible = true;
                is_have_passvord = false;
            }
            else
            {
                is_have_passvord = true;
                l_Warning2.Visible = false;
            }
        }

        private void tb_Enter_Click(object sender, EventArgs e)
        {
            if (is_have_login & is_have_passvord)
            {
                RegistryKey currentUserKey = Registry.CurrentUser;
                RegistryKey SCA_Key = currentUserKey.OpenSubKey("SCA_Key");
                string name_database = SCA_Key.GetValue("name_database").ToString();
                Connect.OpenConnection(name_database, tb_Login.Text, tb_Password.Text);
                try
                {
                    Connect.connection.Open();
                    Connect.connection.Close();
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Неверный логин или пароль!", "Ошибка подключения к БД", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void Authorization_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(Connect.connection == null)
            {
                Application.Exit();
            }
        }
    }
}
