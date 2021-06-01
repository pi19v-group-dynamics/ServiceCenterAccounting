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

    public enum Devices
    {
        Computer = 0,
        Phone = 1,
        Laptop = 2,
        Other = 3
    }

    public partial class AddingDevice : Form
    {
        public Device device;
        Devices type;

        public AddingDevice(Devices type)
        {
            InitializeComponent();
            this.type = type;
            Filling();
        }

        private void Filling()
        {
            Warning0.Visible = false;
            Warning1.Visible = false;
            Warning2.Visible = false;
            Warning3.Visible = false;
            Warning4.Visible = false;
            Warning5.Visible = false;
            Warning6.Visible = false;
            Warning7.Visible = false;
            Warning8.Visible = false;
            Warning9.Visible = false;

            label1.Visible = true;
            label1.Text = "Производитель:";
            textBox1.Visible = true;

            if (type == Devices.Computer)
            {
                label1.Visible = true;
                label1.Text = "Модель материнской платы:";
                textBox2.Visible = true;
                label2.Visible = true;
                label2.Text = "Процессор:";
                textBox3.Visible = true;
                label3.Visible = true;
                label3.Text = "Видеокарта:";
                textBox4.Visible = true;
                label4.Visible = true;
                label4.Text = "Блок питания:";
                textBox5.Visible = true;
                label5.Visible = true;
                label5.Text = "Охлаждение:";
                textBox6.Visible = true;
                label6.Visible = true;
                label6.Text = "ОЗУ:";
                numericUpDown1.Visible = true;
                labelNum1.Visible = true;
                labelNum1.Text = "Количество накопителей:";
                numericUpDown2.Visible = true;
                labelNum2.Visible = true;
                labelNum2.Text = "Суммарный объм накопителей:";
                numericUpDown3.Visible = true;
                labelNum3.Visible = true;
                labelNum3.Text = "Объём ОЗУ:";
                text.Visible = true;
            }
            else if(type == Devices.Phone)
            {
                textBox3.Visible = true;
                label3.Visible = true;
                label3.Text = "Модель:";
                textBox5.Visible = true;
                label5.Visible = true;
                label5.Text = "IMEI:";
            }
            else if(type == Devices.Laptop)
            {
                textBox2.Visible = true;
                label2.Visible = true;
                label2.Text = "Модель:";
                textBox3.Visible = true;
                label3.Visible = true;
                label3.Text = "Процессор:";
                textBox5.Visible = true;
                label5.Visible = true;
                label5.Text = "ОЗУ:";
                numericUpDown1.Visible = true;
                labelNum2.Visible = true;
                labelNum2.Text = "Объём ОЗУ:";
                numericUpDown2.Visible = true;
                labelNum2.Visible = true;
                labelNum2.Text = "Количество накопителей:";
                numericUpDown3.Visible = true;
                labelNum3.Visible = true;
                labelNum3.Text = "Суммарный объём памяти накопителей:";
            }
            else
            {
                textBox2.Visible = true;
                label2.Visible = true;
                label2.Text = "Модель:";
                comboBox1.Visible = true;
                label3.Visible = true;
                label3.Text = "Тип компонента:";

                comboBox1.DataSource = Connect.Select("select id_component_or_other_device_type as id, " +
                    "name_component_or_other_device_type as name " +
                    "from component_or_other_device_types");
                comboBox1.DisplayMember = "name";
                comboBox1.ValueMember = "id";
            }
        }

        private void AddingDevice_Load(object sender, EventArgs e)
        {

        }

        private void addBut_Click(object sender, EventArgs e)
        {
            if (label1.Visible == true && label1.Text == "")
            {
                Warning1.Visible = true;
                MessageBox.Show("Все поля должны быть заполнены!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (label2.Visible == true && label2.Text == "")
            {
                Warning2.Visible = true;
                MessageBox.Show("Все поля должны быть заполнены!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (label3.Visible == true && label3.Text == "")
            {
                Warning3.Visible = true;
                MessageBox.Show("Все поля должны быть заполнены!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (label4.Visible == true && label4.Text == "")
            {
                Warning4.Visible = true;
                MessageBox.Show("Все поля должны быть заполнены!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (label5.Visible == true && label5.Text == "")
            {
                Warning5.Visible = true;
                MessageBox.Show("Все поля должны быть заполнены!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (label6.Visible == true && label6.Text == "")
            {
                Warning6.Visible = true;
                MessageBox.Show("Все поля должны быть заполнены!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (labelNum1.Visible == true && numericUpDown1.Text == "")
            {
                Warning7.Visible = true;
                MessageBox.Show("Все поля должны быть заполнены!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (labelNum2.Visible == true && numericUpDown2.Text == "")
            {
                Warning8.Visible = true;
                MessageBox.Show("Все поля должны быть заполнены!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (labelNum3.Visible == true && numericUpDown3.Text == "")
            {
                Warning9.Visible = true;
                MessageBox.Show("Все поля должны быть заполнены!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (text.Visible == true && text.Text == "")
            {
                Warning0.Visible = true;
                MessageBox.Show("Все поля должны быть заполнены!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                if (type == Devices.Computer)
                {
                    device = new Device();
                    device.Type = Devices.Computer;
                    device.Text1 = label1.Text;
                    device.Text2 = label2.Text;
                    device.Text3 = label3.Text;
                    device.Text4 = label4.Text;
                    device.Text5 = label5.Text;
                    device.Text6 = label6.Text;
                    device.Num1 = (int)numericUpDown1.Value;
                    device.Num2 = (int)numericUpDown2.Value;
                    device.Num3 = (int)numericUpDown3.Value;
                    device.MultiText = text.Text;
                }
                else if (type == Devices.Phone)
                {
                    device.Type = Devices.Phone;
                    device.Text1 = textBox1.Text;
                    device.Text2 = textBox3.Text;
                    device.Text3 = textBox5.Text;
                }
                else if (type == Devices.Laptop) 
                {
                    device.Type = Devices.Laptop;
                    device.Text1 = textBox1.Text;
                    device.Text2 = textBox2.Text;
                    device.Text3 = textBox3.Text;
                    device.Text4 = textBox5.Text;
                    device.Num1 = (int)numericUpDown1.Value;
                    device.Num2 = (int)numericUpDown2.Value;
                    device.Num3 = (int)numericUpDown3.Value;
                }
                else
                {
                    device.Type = Devices.Other;
                    device.Text1 = textBox1.Text;
                    device.Text2 = textBox2.Text;
                    device.Num1 =  (int)comboBox1.SelectedValue;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Warning1.Visible = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Warning2.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Warning3.Visible = false;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Warning3.Visible = false;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            Warning4.Visible = false;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            Warning5.Visible = false;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            Warning6.Visible = false;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Warning7.Visible = false;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            Warning8.Visible = false;
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            Warning9.Visible = false;
        }

        private void text_TextChanged(object sender, EventArgs e)
        {
            Warning0.Visible = false;
        }

        private void cancleBut_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

    public class Device
    {
        public Devices Type { get; set; }
        public string Text1 { get; set; }
        public string Text2 { get; set; }
        public string Text3 { get; set; }
        public string Text4 { get; set; }
        public string Text5 { get; set; }
        public string Text6 { get; set; }
        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public int Num3 { get; set; }
        public string MultiText { get; set; }
    }

}
