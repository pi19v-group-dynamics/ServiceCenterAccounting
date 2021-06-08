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
    public partial class AddingClient : Form
    {

        public Client client = null;

        public AddingClient(Client c)
        {
            InitializeComponent();

            lastNameWarning.Visible = false;
            firstNameWarning.Visible = false;
            middleNameWarning.Visible = false;
            seriesWarning.Visible = false;
            numberWarning.Visible = false;

            if(c != null)
            {
                client = c;
                lastNameField.Text = c.LastName;
                firstNameField.Text = c.FirstName;
                middleNameField.Text = c.MiddleName;
                seriesField.Text = c.Series;
                numberField.Text = c.Number.Substring(3);
            }
        }

        public Client GetClient()
        {
            return client;
        }


        private void AddingClient_Load(object sender, EventArgs e)
        {

        }

        private void addBut_Click(object sender, EventArgs e)
        {
            if(lastNameField.Text == "")
            {
                lastNameWarning.Visible = true;
                MessageBox.Show("Все поля должны быть заполнены!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (firstNameField.Text == "")
            {
                firstNameWarning.Visible = true;
                MessageBox.Show("Все поля должны быть заполнены!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (middleNameField.Text == "")
            {
                middleNameWarning.Visible = true;
                MessageBox.Show("Все поля должны быть заполнены!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (seriesField.Text == "" || seriesField.Text.Length < seriesField.MaxLength)
            {
                seriesWarning.Visible = true;
                MessageBox.Show($"Поле 'Серия паспорта' должно содержать {seriesField.MaxLength} цифр!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (numberField.Text == "" || numberField.Text.Length < numberField.MaxLength)
            {
                numberWarning.Visible = true;
                MessageBox.Show($"Поле 'Тел. номер' должно содержать {numberField.MaxLength} цифр", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                client = new Client(lastNameField.Text, firstNameField.Text, middleNameField.Text, seriesField.Text, (numLable.Text + numberField.Text));
                Close();
            }
        }

        private void lastNameField_TextChanged(object sender, EventArgs e)
        {
            lastNameWarning.Visible = false;
        }

        private void firstNameField_TextChanged(object sender, EventArgs e)
        {
            firstNameWarning.Visible = false;
        }

        private void middleNameField_TextChanged(object sender, EventArgs e)
        {
            middleNameWarning.Visible = false;
        }

        private void seriesField_TextChanged(object sender, EventArgs e)
        {
            seriesWarning.Visible = false;
        }

        private void numberField_TextChanged(object sender, EventArgs e)
        {
            numberWarning.Visible = false;
        }

        private void cancleBut_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void numberField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 | e.KeyChar > 57) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void seriesField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 | e.KeyChar > 57) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void lastNameField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 & e.KeyChar <= 57)
                e.Handled = true;
        }

        private void firstNameField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 & e.KeyChar <= 57)
                e.Handled = true;
        }

        private void middleNameField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 & e.KeyChar <= 57)
                e.Handled = true;
        }
    }

    public class Client
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Series { get; set; }
        public string Number { get; set; }

        public Client()
        {

        }

        public Client(string lastName, string firstName, string middleName, string series, string number)
        { 
            LastName = lastName;
            FirstName = firstName;
            MiddleName = middleName;
            Series = series;
            Number = number;
        }
    }
}
