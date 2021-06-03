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
    public partial class AddNote : Form
    {
        public AddNote(string SelectedNote)
        {
            InitializeComponent();
            textBox2.Text = SelectedNote;
            if (SelectedNote == "Типы услуг") { label3.Visible = true;Price.Visible = true; }
        }

        private void AddNote_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (textBox2.Text)
            {
                case "Типы услуг":
                    Connect.GetString($"INSERT INTO types_of_service(name_type_of_service,cost_of_service) VALUES ('{Note.Text}',{Price.Value})");break;
                case "Типы компонентов":
                    Connect.GetString($"INSERT INTO component_or_other_device_types(name_component_or_other_device_type) VALUES ('{Note.Text}')");break;
            }
        }

        private void Note_TextChanged(object sender, EventArgs e)
        {
            if (DigitsOnly(Note.Text)==true)
            {
                Note.Clear();
            }
        }

        private bool DigitsOnly(string text)
        {
            int len = text.Length;
            for (int i = 0; i < len; ++i)
            {
                char c = text[i];
                if (c < '0' || c > '9')
                    return false;
            }
            return true;
        }
    }
}
