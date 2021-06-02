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
    public partial class AddingAndChangingOrders : Form
    {
        Client client = null;
        Device device = null;

        public AddingAndChangingOrders()
        {
            InitializeComponent();
            Filling();
            Text = "Добавление заказа";
        }

        private void Filling()
        {

            servicesList.DataSource = Connect.Select("select id_type_of_service as id, name_type_of_service || ' (' || " +
                "cost_of_service || ' руб.' || ')' as name from types_of_service ");
            servicesList.DisplayMember = "name";
            servicesList.ValueMember = "id";

            typeList.DataSource = Connect.Select("select id_type_of_device as id, type_of_device as name from types_of_device");
            typeList.DisplayMember = "name";
            typeList.ValueMember = "id";

            dateTimePicker.MaxDate = Convert.ToDateTime(Connect.GetString("select CURRENT_DATE"));
        }

        private void AddingAndChangingOrders_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddingClient f = new AddingClient();
            f.ShowDialog();
            client = f.GetClient();
            if (client != null)
            {
                clientField.Text = $"{client.LastName} {client.FirstName[0]}. {client.MiddleName[0]}.";
                clientWarning.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddingDevice f = new AddingDevice((Devices)typeList.SelectedValue);
            f.ShowDialog();
            device = f.device;
            if (device != null)
            {
                deviceField.Text = $"{device.Text2} ({device.Text1})";
                deviceWarning.Visible = false;
            }
        }

        private void addBut_Click(object sender, EventArgs e)
        {
            string client_id = null;
            string device_id = null;
            string sql = null;
            string order_id = null;
            string completed = null;

            if(client == null)
            {
                clientWarning.Visible = true;
                MessageBox.Show("Сначала добавьте клиента!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(device == null)
            {
                deviceWarning.Visible = true;
                MessageBox.Show("Сначала добавьте устройство!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(servicesList.Items.Count == 0)
            {
                servicesWarning.Visible = true;
                MessageBox.Show("Нет предоставляемых услуг!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                client_id = Connect.GetString("insert into clients (last_name_client, first_name_client, middle_name_client, passport_series, phone) " +
                    $"values('{client.LastName}', '{client.FirstName}', '{client.MiddleName}', '{client.Series}', '{client.Number}') RETURNING id_client");
                if(client_id == null)
                {
                    MessageBox.Show("Не удалось добавить клиента!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if(device.Type == Devices.Computer)
                {
                    sql = "insert into stationary_computers (motherboard, cpu, gpu, power_supply, number_of_drives, total_drives_capacity, " +
                        "cpu_cooling, additional_devices, ram, ram_capacity) " +
                        $"VALUES ('{device.Text1}', '{device.Text2}', '{device.Text3}', '{device.Text4}', {device.Num1}, {device.Num2}, " +
                        $"'{device.Text5}', '{device.MultiText}', '{device.Text6}', {device.Num3}) " +
                        "RETURNING id_stationary_computer";
                }
                else if (device.Type == Devices.Phone)
                {
                    sql = $"insert into smartphones (manufacturer, model, imei) VALUES ('{device.Text1}', '{device.Text2}', '{device.Text3}') RETURNING id_smartphone";
                }
                else if (device.Type == Devices.Laptop)
                {
                    sql = "insert into laptops_and_monoblocks (manufacturer, model, cpu, ram, ram_capacity, number_of_drives, total_drives_capacity) " +
                        $"VALUES ('{device.Text1}', '{device.Text2}', '{device.Text3}', '{device.Text4}', {device.Num1}, {device.Num2}, {device.Num3}) " +
                        "RETURNING id_laptop_or_monoblock";
                }
                else if (device.Type == Devices.Other)
                {
                    sql = "insert into components_or_other_devices (id_component_type, manufacturer, model) " +
                        $"VALUES ({device.Num1}, '{device.Text1}', '{device.Text2}') RETURNING id_component_or_other_devices";
                }

                device_id = Connect.GetString(sql);
                if (device_id == null)
                {
                    MessageBox.Show("Не удалось добавить девайс!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                order_id = Connect.GetString("insert into orders (id_client, date_of_adoption, customer_comment, id_stage_of_execution, id_type_of_service) " +
                    $"values ({client_id}, '{dateTimePicker.Value.ToShortDateString()}', '{commentField.Text}', 1, {servicesList.SelectedValue}) " +
                    "RETURNING id_orders");
                if (order_id == null)
                {
                    MessageBox.Show("1Не удалось добавить заказ!1", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                completed = Connect.GetString("insert into orders_and_devices (id_order, id_type_of_device, id_specific_device) " +
                    $"values ({order_id}, {(int)device.Type}, {device_id}) " +
                    $" RETURNING id_order_and_device");
                if (completed == null)
                {
                    MessageBox.Show("Не удалось добавить заказ!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Close();
            }
        }

        private void cancleBut_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
