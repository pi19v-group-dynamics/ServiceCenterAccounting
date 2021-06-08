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
    public partial class InfoAboutOrder : Form
    {
        DataTable order = null;
        DataTable deviceAndOrder = null;
        Device device;

        string id = null;

        public InfoAboutOrder(string id)
        {
            InitializeComponent();
            this.id = id;
            Filling();
        }

        private void Filling()
        {
            deviceAndOrder = Connect.Select("select id_order_and_device as id, id_order as order, " +
                    "id_type_of_device as type, id_specific_device as devise " +
                    $"from orders_and_devices where id_order_and_device = {id}");

            order = Connect.Select("select  id_worker as worker, id_orders as id, id_client as client, id_stage_of_execution as stage, date_of_adoption as date, " +
                    "customer_comment as comment, id_type_of_service as service " +
                    $"from orders where id_orders = {deviceAndOrder.Rows[0].Field<int>("order")}");

            dateField.Text = order.Rows[0].Field<DateTime>("date").ToShortDateString();

            DataTable dt = Connect.Select("select last_name_client as lname, first_name_client as fname, " +
                    "middle_name_client as mname, passport_series as series, phone " +
                    $"from clients where id_client = {order.Rows[0].Field<int>("client")}");
            lastNameField.Text = dt.Rows[0].Field<string>("lname");
            firstNameField.Text = dt.Rows[0].Field<string>("fname");
            middleNameField.Text = dt.Rows[0].Field<string>("mname");
            seriesField.Text = dt.Rows[0].Field<string>("series");
            numberField.Text = dt.Rows[0].Field<string>("phone");
            commentField.Text = order.Rows[0].Field<string>("comment");

            if (order.Rows[0].Field<object>("worker") == null)
                workerField.Text = "Неназначен";
            else
            {
                workerField.Text = Connect.GetString("select last_name_worker || ' '|| substring(first_name_worker from 1 for 1) " +
                    "|| '.' || substring(middle_name_worker from 1 for 1) || '.' " +
                    $"from workers WHERE id_worker = {order.Rows[0].Field<int>("worker")}");
            }
            seriesField.Text = Connect.GetString("select name_type_of_service || ' ' || " +
                $"to_char(cost_of_service, '(990.99р)') from types_of_service where id_type_of_service = {order.Rows[0].Field<int>("service")}");
            typeField.Text = Connect.GetString($"select type_of_device from types_of_device where id_type_of_device = {deviceAndOrder.Rows[0].Field<int>("type")}");
            stadField.Text = Connect.GetString($"select name_stage_of_execution from stages_of_execution where id_stage_of_execution = {order.Rows[0].Field<int>("stage")}");
            serviceField.Text = Connect.GetString($"select name_type_of_service || ' ' || to_char(cost_of_service, '(990.99р)') from types_of_service where id_type_of_service = {order.Rows[0].Field<int>("service")}");
            LoadDevice((Devices)deviceAndOrder.Rows[0].Field<int>("type"), deviceAndOrder.Rows[0].Field<int>("devise").ToString());
        }

        private void LoadDevice(Devices type, string id)
        {

            DataTable dt = null;
            device = new Device();

            label1.Visible = true;
            label1.Text = "Производитель:";
            textBox1.Visible = true;

            if (type == Devices.Computer)
            {

                dt = Connect.Select("SELECT motherboard, cpu, gpu, power_supply as power, " +
                    "number_of_drives as num, total_drives_capacity as dcapacity, cpu_cooling as cooling, " +
                    "additional_devices as additional, ram, ram_capacity as rcapacity " +
                    $"from stationary_computers where id_stationary_computer = {id}");

                device.Type = type;
                device.Text1 = dt.Rows[0].Field<string>("motherboard");
                device.Text2 = dt.Rows[0].Field<string>("cpu");
                device.Text3 = dt.Rows[0].Field<string>("gpu");
                device.Text4 = dt.Rows[0].Field<string>("power");
                device.Text5 = dt.Rows[0].Field<string>("cooling");
                device.Text6 = dt.Rows[0].Field<string>("ram");
                device.Num1 = dt.Rows[0].Field<int>("num");
                device.Num2 = dt.Rows[0].Field<int>("dcapacity");
                device.Num3 = dt.Rows[0].Field<int>("rcapacity");
                device.MultiText = dt.Rows[0].Field<string>("additional");


                label1.Visible = true;
                label1.Text = "Мат.плата:";
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
                label9.Visible = true;
                label9.Text = "ОЗУ:";
                numericUpDown1.Visible = true;
                labelNum1.Visible = true;
                labelNum1.Text = "Кол-во накопителей:";
                numericUpDown2.Visible = true;
                labelNum2.Visible = true;
                labelNum2.Text = "Общ.объм памяти:";
                numericUpDown3.Visible = true;
                labelNum3.Visible = true;
                labelNum3.Text = "Объём ОЗУ:";
                text.Visible = true;
                labelText.Visible = true;
                labelText.Text = "Доп.устройства:";

                if (device != null && device.Type == Devices.Computer)
                {
                    textBox1.Text = device.Text1;
                    textBox2.Text = device.Text2;
                    textBox3.Text = device.Text3;
                    textBox4.Text = device.Text4;
                    textBox5.Text = device.Text5;
                    textBox6.Text = device.Text6;
                    numericUpDown1.Value = device.Num1;
                    numericUpDown2.Value = device.Num2;
                    numericUpDown3.Value = device.Num3;
                    text.Text = device.MultiText;
                }

            }
            else if (type == Devices.Phone)
            {

                dt = Connect.Select($"SELECT manufacturer as man, model, imei from smartphones where id_smartphone = {id}");
                device.Type = type;
                device.Text1 = dt.Rows[0].Field<string>("man");
                device.Text2 = dt.Rows[0].Field<string>("model");
                device.Text3 = dt.Rows[0].Field<string>("imei");

                textBox3.Visible = true;
                label3.Visible = true;
                label3.Text = "Модель:";
                textBox5.Visible = true;
                label5.Visible = true;
                label5.Text = "IMEI:";

                if (device != null && device.Type == Devices.Phone)
                {
                    textBox1.Text = device.Text1;
                    textBox3.Text = device.Text2;
                    textBox5.Text = device.Text3;
                }

            }
            else if (type == Devices.Laptop)
            {

                dt = Connect.Select("SELECT manufacturer as man, model, cpu, ram, " +
                    "ram_capacity as rcapacity, number_of_drives as num, total_drives_capacity as dcapacity " +
                    $"from laptops_and_monoblocks where id_laptop_or_monoblock = {id}");

                device.Type = type;
                device.Text1 = dt.Rows[0].Field<string>("man");
                device.Text2 = dt.Rows[0].Field<string>("model");
                device.Text3 = dt.Rows[0].Field<string>("cpu");
                device.Text4 = dt.Rows[0].Field<string>("ram");
                device.Num1 = dt.Rows[0].Field<int>("rcapacity");
                device.Num2 = dt.Rows[0].Field<int>("num");
                device.Num3 = dt.Rows[0].Field<int>("dcapacity");



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
                labelNum1.Visible = true;
                labelNum1.Text = "Объём ОЗУ:";
                numericUpDown2.Visible = true;
                labelNum2.Visible = true;
                labelNum2.Text = "Кол-во накопителей:";
                numericUpDown3.Visible = true;
                labelNum3.Visible = true;
                labelNum3.Text = "Общ.объём памяти:";

                if (device != null && device.Type == Devices.Laptop)
                {
                    textBox1.Text = device.Text1;
                    textBox2.Text = device.Text2;
                    textBox3.Text = device.Text3;
                    textBox5.Text = device.Text4;
                    numericUpDown1.Value = device.Num1;
                    numericUpDown2.Value = device.Num2;
                    numericUpDown3.Value = device.Num3;
                }

            }
            else
            {

                dt = Connect.Select($"SELECT id_component_type as type, manufacturer as man, model from components_or_other_devices where id_component_or_other_devices = {id}");
                device.Type = type;
                device.Text1 = dt.Rows[0].Field<string>("man");
                device.Text2 = dt.Rows[0].Field<string>("model");
                device.Num1 = dt.Rows[0].Field<int>("type");


                textBox2.Visible = true;
                label2.Visible = true;
                label2.Text = "Модель:";
                textBox3.Visible = true;
                label3.Visible = true;
                label3.Text = "Тип компонента:";

                
                

                if (device != null && device.Type == Devices.Other)
                {
                    textBox1.Text = device.Text1;
                    textBox2.Text = device.Text2;
                    textBox3.Text = Connect.GetString("select id_component_or_other_device_type as id, " +
                    "name_component_or_other_device_type as name " +
                    $"from component_or_other_device_types where id_component_or_other_device_type = {device.Num1}");
                }
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
