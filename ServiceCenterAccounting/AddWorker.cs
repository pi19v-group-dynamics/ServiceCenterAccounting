using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceCenterAccounting
{
    public partial class AddWorker : Form
    {
        public AddWorker()
        {
            InitializeComponent();
        }

        private void Last_Name_Text_TextChanged(object sender, EventArgs e)
        {
            if (DigitsOnly(Last_Name_Text.Text))
                Last_Name_Text.Clear();
        }

        private bool DigitsOnly(string text)
        {
            throw new NotImplementedException();
        }

        private void AddWorker_Load(object sender, EventArgs e)
        {

        }

        private void First_Name_Text_TextChanged(object sender, EventArgs e)
        {
            if (DigitsOnly(First_Name_Text.Text))
                First_Name_Text.Clear();
        }

        private void Middle_Name_Text_TextChanged(object sender, EventArgs e)
        {
            if (DigitsOnly(First_Name_Text.Text))
                First_Name_Text.Clear();
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            if (Last_Name_Text.Text == "" || First_Name_Text.Text == "" || Middle_Name_Text.Text == "")
            {
                MessageBox.Show($"Заполните поля!\nПоля не могут содержать только цифры и не может начинаться со спецсимволов\n" +
                                $"Поля доступные для заполнения не могут содержать только пробелы!", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else { Connect.GetString($"INSERT INTO workers(last_name_worker,first_name_worker,middle_name_worker,interest_rate,employment" +
                $") VALUES('{Last_Name_Text.Text}','{First_Name_Text.Text}','{Middle_Name_Text.Text}',{numericUpDown1.Value},'f')"); }
            }
        }
    }
