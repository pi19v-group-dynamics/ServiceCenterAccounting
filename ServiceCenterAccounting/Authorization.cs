using System;
using System.Windows.Forms;
using Microsoft.Win32;

namespace ServiceCenterAccounting
{
    public partial class Authorization : Form
    {
        bool is_have_login = false;
        bool is_have_passvord = false;
        bool Is_operator;

        public Authorization(bool is_operator)
        {
            InitializeComponent();
            Is_operator = is_operator;
            if(Is_operator)
            {
                label1.Text = "Введите логин оператора";
                label2.Text = "Введите пароль оператора";
            }
            else
            {
                label1.Text = "Введите логин администратора";
                label2.Text = "Введите пароль админимтратора";
            }
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
            RegistryKey currentUserKey = Registry.CurrentUser;
            RegistryKey SCA_Key = currentUserKey.OpenSubKey("SCA_Key");
            string login_op = SCA_Key.GetValue("login_op").ToString();
            if (Is_operator)
            {
                if (is_have_login & is_have_passvord & tb_Login.Text.Equals(login_op))
                {
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
                        MessageBox.Show("Неверный логин или пароль оператора!", "Ошибка подключения к БД", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                if (is_have_login & is_have_passvord & !tb_Login.Text.Equals(login_op))
                {
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
                        MessageBox.Show("Неверный логин или пароль администратора!", "Ошибка подключения к БД", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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
