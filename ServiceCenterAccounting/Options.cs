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
using Microsoft.Win32;

namespace ServiceCenterAccounting
{
    public partial class Options : Form
    {
        Regex Telephone_Check = new Regex(@"^\+?38-?\(?0\d{2}\)?-?\d{3}-?\d{2}-?\d{2}$");
        RegistryKey currentUserKey = Registry.CurrentUser;
        RegistryKey SCA_Key;
        string[] sub_keys;
        string SelectedNote;
        public Options()
        {
            InitializeComponent();
            sub_keys= currentUserKey.GetSubKeyNames();
            SCA_Key = currentUserKey.OpenSubKey("SCA_Key");
        }

        private void Options_Load(object sender, EventArgs e)
        {
            if (sub_keys.Contains("SCA_Key"))
            {
                RegistryKey SCA_Key = currentUserKey.OpenSubKey("SCA_Key");
                Name_srv_text.Text = SCA_Key.GetValue("name_srvice").ToString();
                Address_srv_text.Text = SCA_Key.GetValue("addres_service").ToString();
                Number_srv_text.Text = SCA_Key.GetValue("phone_service").ToString();
            }
        }

        private void ChangeInfo_Click(object sender, EventArgs e)
        {
            if (DigitsOnly(Name_srv_text.Text) ||
              Name_srv_text.Text.StartsWith("-") | Name_srv_text.Text.StartsWith("`") | Name_srv_text.Text.StartsWith("'")
              || Name_srv_text.Text == (" ") || Name_srv_text.Text.StartsWith(".") || Name_srv_text.Text.StartsWith(",")
              || Name_srv_text.Text.StartsWith("/"))
            {
                MessageBox.Show($"Заполните название видеосалона!\nПоля доступные для заполнения не могут содержать только пробелы!",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else { SCA_Key.SetValue("name_srvice", Name_srv_text.Text); }

            if (String.IsNullOrWhiteSpace(Address_srv_text.Text) || DigitsOnly(Address_srv_text.Text) ||
              Address_srv_text.Text.StartsWith("-") | Address_srv_text.Text.StartsWith("`") | Address_srv_text.Text.StartsWith("'")
              || Address_srv_text.Text.StartsWith(" ") || Address_srv_text.Text.StartsWith(".") || Address_srv_text.Text.StartsWith(",")
              || Address_srv_text.Text.StartsWith("/"))
            {
                MessageBox.Show($"Заполните адрес!\nАдрес не может содержать только цифры и не может начинаться со спецсимволов\n" +
                                $"Поля доступные для заполнения не могут содержать только пробелы!", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else { SCA_Key.SetValue("addres_service", Name_srv_text.Text); }

            if (String.IsNullOrWhiteSpace(Number_srv_text.Text) || !Telephone_Check.IsMatch(Number_srv_text.Text) || Number_srv_text.Text.StartsWith(" ")
                || Number_srv_text.Text.StartsWith("-"))
            {
                MessageBox.Show($"Заполните телефонный номер!\nТелефонный номер должен иметь вид:\n" +
                                $" 38071XXXXXXX\n+38071XXXXXXX\n+38-071-XXX-XX-XX\n+38(071)-XXX-XX-XX\n" +
                                $"Поля доступные для заполнения не могут содержать только пробелы!",
                                 "Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else{SCA_Key.SetValue("phone_service", Name_srv_text.Text);}
        }

        private bool DigitsOnly(string text)
        {
            throw new NotImplementedException();
        }

        private void Type_of_notes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SelectedNote = Type_of_notes.SelectedItem.ToString();
        }
        public void LoadNotes() {
            switch (SelectedNote) {
                case "Работники":
                    NotesData.DataSource = Connect.Select("select id_worker as ID,last_name_worker as \"Фамилия работника\",first_name_worker as \"Имя работника\"," +
                    "middle_name_worker as \"Отчество работника\",interest_rate as \"Процентная ставка\",employment as " +
                    " \"Занятость работника\",date_of_brth as \"Дата рождения\" from workers");
                    break;
                case "Типы услуг":
                    NotesData.DataSource = Connect.Select("select id_type_of_service as ID,name_type_of_service as " +
                    "\"Название услуги\",cost_of_service as \"Стоимость услуги\" from types_of_service");
                    break;
                case "Типы компонентов":
                    NotesData.DataSource = Connect.Select("select id_component_or_other_device_type as ID,name_component_or_other_device_type as \"Название компонента\" " +
                        "from component_or_other_device_types");
                    break;
            }
        }

        private void InsertNote_Click(object sender, EventArgs e)
        {
            switch (SelectedNote) {
                case "Типы услуг":new AddNote(SelectedNote).ShowDialog();break;
                case "Типы компонентов":new AddNote(SelectedNote).ShowDialog();break;
                case "Работники":
                
            }
        }
    }
}
