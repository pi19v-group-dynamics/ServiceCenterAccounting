using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace ServiceCenterAccounting
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string ip = textBox1.Text;
            string login = textBox2.Text;
            string password = textBox3.Text;
            var commandstring = $"Host = {ip}; Password = {password}; Database = postgres";
            bool isconnected;
            NpgsqlConnection connection = new NpgsqlConnection(commandstring);
            try
            {
                await connection.OpenAsync();
                isconnected = true;
            }
            catch
            {
                MessageBox.Show("Ошибка входа");
                isconnected = false;
            }
            if (isconnected)
            {
                Hide();
                Environment.Exit(0);
            }
        }
    }
}
