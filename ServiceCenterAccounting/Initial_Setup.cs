using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceCenterAccounting
{
    public partial class Initial_Setup : Form
    {
        Regex Telephone_Check = new Regex(@"^\+?38-?\(?0\d{2}\)?-?\d{3}-?\d{2}-?\d{2}$");
        int counter = 0; 
        bool is_have_name_service = false;
        bool is_have_addres_service = false;
        bool is_have_phone_service = false;

        public Initial_Setup()
        {
            InitializeComponent();
        }

        private void btn_Further_Click(object sender, EventArgs e)
        {
            switch(counter)
            {
                case 0:
                    {
                        counter++;
                        btn_Back.Enabled = true;
                        l_Text1.Visible = false;
                        l_Text2.Visible = true;
                        l_Input_Text1.Visible = true;
                        l_Input_Text2.Visible = true;
                        l_Input_Text3.Visible = true;
                        tb_Addres_Service.Visible = true;
                        tb_Name_Srvice.Visible = true;
                        tb_Phone_Service.Visible = true;
                        l_Text2.Enabled = true;
                        l_Input_Text1.Enabled = true;
                        l_Input_Text2.Enabled = true;
                        l_Input_Text3.Enabled = true;
                        tb_Addres_Service.Enabled = true;
                        tb_Name_Srvice.Enabled = true;
                        tb_Phone_Service.Enabled = true;
                        break;
                    }
                case 1:
                    {
                        if(is_have_name_service & is_have_addres_service & is_have_phone_service)
                        {
                            counter++;
                            RegistryKey currentUserKey = Registry.CurrentUser;
                            RegistryKey SCA_Key = currentUserKey.CreateSubKey("SCA_Key");
                            SCA_Key.SetValue("name_srvice", tb_Name_Srvice.Text);
                            SCA_Key.SetValue("addres_service", tb_Addres_Service.Text);
                            SCA_Key.SetValue("phone_service", tb_Phone_Service.Text);
                            l_Text2.Visible = false;
                            l_Input_Text1.Visible = false;
                            l_Input_Text2.Visible = false;
                            l_Input_Text3.Visible = false;
                            tb_Addres_Service.Visible = false;
                            tb_Name_Srvice.Visible = false;
                            tb_Phone_Service.Visible = false;

                        }
                        else
                        {
                            if (!is_have_name_service)
                            {
                                MessageBox.Show(
                                            $"Заполните название видеосалона!\nПоля доступные для заполнения не могут содержать только пробелы!",
                                            "Ошибка",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error
                                            );
                            }
                            if (!is_have_addres_service)
                            {
                                MessageBox.Show(
                                            $"Заполните адрес!\nАдрес не может содержать только цифры и не может начинаться со спецсимволов\n" +
                                            $"Поля доступные для заполнения не могут содержать только пробелы!",
                                            "Ошибка",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error
                                            );
                            }
                            if (!is_have_phone_service)
                            {
                                MessageBox.Show(
                                            $"Заполните телефонный номер!\nТелефонный номер должен иметь вид:\n" +
                                            $" 38071XXXXXXX\n+38071XXXXXXX\n+38-071-XXX-XX-XX\n+38(071)-XXX-XX-XX\n" +
                                            $"Поля доступные для заполнения не могут содержать только пробелы!",
                                            "Ошибка",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error
                                            );
                            }
                        }

                        
                        break;
                    }
            }
        }

        private void tb_Name_Srvice_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tb_Name_Srvice.Text) || tb_Name_Srvice.Text.StartsWith(" "))
            {
                l_Warning1.Visible = true;
                is_have_name_service = false;
            }
            else
            {
                is_have_name_service = true;
                l_Warning1.Visible = false;
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_Addres_Service_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && (number < 0x0410 || number > 0x044F) && number != 8 && number != 0x0027 
                && number != 1101 && number != 1025 && number != 1105 && number != 1069 && number != 1098 && number != 1066 
                && number != 45 && number != 96 && number != 32 && number != 44 && number != 46 && number != 47)
            {
                e.Handled = true;
            }
        }

        private void tb_Phone_Service_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 45 && number != 43 && number != 40 && number != 41)
            {
                e.Handled = true;
            }
        }

        private void tb_Addres_Service_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tb_Addres_Service.Text) || DigitsOnly(tb_Addres_Service.Text) ||
                tb_Addres_Service.Text.StartsWith("-") | tb_Addres_Service.Text.StartsWith("`") | tb_Addres_Service.Text.StartsWith("'")
                || tb_Addres_Service.Text.StartsWith(" ") || tb_Addres_Service.Text.StartsWith(".") || tb_Addres_Service.Text.StartsWith(",")
                || tb_Addres_Service.Text.StartsWith("/"))
            {
                l_Warning2.Visible = true;
                is_have_addres_service = false;
            }
            else
            {
                is_have_addres_service = true;
                l_Warning2.Visible = false;
            }
        }

        private void tb_Phone_Service_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tb_Phone_Service.Text) || !Telephone_Check.IsMatch(tb_Phone_Service.Text) || tb_Phone_Service.Text.StartsWith(" ") 
                || tb_Phone_Service.Text.StartsWith("-"))
            {
                l_Warning3.Visible = true;
                is_have_phone_service = false;
            }
            else
            {
                is_have_phone_service = true;
                l_Warning3.Visible = false;
            }
        }

        private bool DigitsOnly(string s)
        {
            int len = s.Length;
            for (int i = 0; i < len; ++i)
            {
                char c = s[i];
                if (c < '0' || c > '9')
                    return false;
            }
            return true;
        }
    }
}
