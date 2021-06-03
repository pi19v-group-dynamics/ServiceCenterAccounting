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
        bool isUpdating = false;
        string id = null;
        DataTable order = null;
        DataTable deviceAndOrder = null;

        public AddingAndChangingOrders()
        {
            InitializeComponent();
            Filling();
            Text = "Добавление заказа";
        }

        public AddingAndChangingOrders(string id)
        {
            InitializeComponent();
            isUpdating = true;
            this.id = id;
            Filling();
            Text = "Изменение заказа";
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

            if (isUpdating)
            {
                deviceAndOrder = Connect.Select("select id_order_and_device as id, id_order as order, " +
                    "id_type_of_device as type, id_specific_device as devise " +
                    $"from orders_and_devices where id_order_and_device = {id}");
                
                order = Connect.Select("select id_orders as id, id_client as client, date_of_adoption as date, " +
                    "customer_comment as comment, id_type_of_service as service " +
                    $"from orders where id_orders = {deviceAndOrder.Rows[0].Field<int>("order")}");

                dateTimePicker.Value = Convert.ToDateTime(order.Rows[0].Field<string>("date"));
                typeList.SelectedValue = order.Rows[0].Field<int>("service");
                commentField.Text = order.Rows[0].Field<string>("comment");

                DataTable dt = Connect.Select("select last_name_client as lname, first_name_client as fname, " +
                    "middle_name_client as mname, passport_series as series, phone " +
                    "from clients where id_client = 2");
                client = new Client(dt.Rows[0].Field<string>("lname"), dt.Rows[0].Field<string>("fname"),
                    dt.Rows[0].Field<string>("mname"), dt.Rows[0].Field<string>("series"), dt.Rows[0].Field<string>("phone"));
                clientField.Text = $"{client.LastName} {client.FirstName[0]}. {client.MiddleName[0]}. ({client.Series})";
                LoadDevice((Devices)deviceAndOrder.Rows[0].Field<int>("type"), deviceAndOrder.Rows[0].Field<int>("devise").ToString());
            }
        }

        private void LoadDevice(Devices type ,string id)
        {
            DataTable dt = null;
            device = new Device();
            if(type = Devices.Computer)
            {
                dt = Connect.Select("SELECT motherboard, cpu, gpu, power_supply as power, " + 
                    "number_of_drives as num, total_drives_capacity as dcapacity, cpu_cooling as cooling, " + 
                    "additional_devices as additional, ram, ram_capacity as rcapacity " + 
                    $"from stationary_computers where id_stationary_computer = {(int)type}");

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
                
            }
            else if(type = Devices.Laptop) 
            {
                dt = Connect.Select("SELECT manufacturer as man, model, cpu, ram, " + 
                    "ram_capacity as rcapacity, number_of_drives as num, total_drives_capacity as dcapacity " +
                    $"from laptops_and_monoblocks where id_laptop_or_monoblock = {(int)type}");

                device.Type = type;
                device.Text1 = dt.Rows[0].Field<string>("man");
                device.Text2 = dt.Rows[0].Field<string>("model");
                device.Text3 = dt.Rows[0].Field<string>("cpu");
                device.Text4 = dt.Rows[0].Field<string>("ram");
                device.Num1 = dt.Rows[0].Field<int>("rcapacity");
                device.Num2 = dt.Rows[0].Field<int>("num");
                device.Num3 = dt.Rows[0].Field<int>("dcapacity");

            }
            else if(type = Devices.Phone)
            {
                dt = Connect.Select($"SELECT manufacturer as man, model, imei from smartphones where id_smartphone = {(int)type}");
                device.Text1 = dt.Rows[0].Field<string>("man");
                device.Text2 = dt.Rows[0].Field<string>("model");
                device.Text3 = dt.Rows[0].Field<string>("imei");
            }
            else if(type = Devices.Other)
            {
                dt = Connect.Select($"SELECT id_component_type as type, manufacturer as man, model from components_or_other_devices where id_component_or_other_devices = {(int)type}");
                device.Text1 = dt.Rows[0].Field<string>("man");
                device.Text2 = dt.Rows[0].Field<string>("model");
                device.Num1 = dt.Rows[0].Field<int>("type");
            }
            deviceField.Text = $"{device.Text2} ({device.Text1})";
        }

        private void AddingAndChangingOrders_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddingClient f = new AddingClient(client);
            f.ShowDialog();
            client = f.GetClient();
            if (client != null)
            {
                clientField.Text = $"{client.LastName} {client.FirstName[0]}. {client.MiddleName[0]}. ({client.Series})";
                clientWarning.Visible = false;
            }
            else
                clientField.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddingDevice f = new AddingDevice((Devices)typeList.SelectedValue, device);
            f.ShowDialog();
            device = f.device;
            if (device != null)
            {
                deviceField.Text = $"{device.Text2} ({device.Text1})";
                deviceWarning.Visible = false;
            }
            else
                deviceField.Text = "";
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

                if (isUpdating)
                {
                    string result = null;
                    string device_id = null;
                    string sql = null;
                    string name = null;
                    string column;

                    result = Connect.GetString("UPDATE clients SET (last_name_client, first_name_client, middle_name_client, passport_series, phone) = " + 
                        $"('{client.LastName}', '{client.FirstName}', '{client.MiddleName}', '{client.Series}', '{client.Number}') " + 
                        $"WHERE id_client = {order.Rows[0].Field<int>("client")}");
                    if (result == null)
                    {
                            MessageBox.Show("Не удалось обновить данные о клиенте!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                    }

                    if(device.Type == Devices.Computer)
                    {
                        column = "id_stationary_computer";
                        sql = "insert into stationary_computers (motherboard, cpu, gpu, power_supply, number_of_drives, total_drives_capacity, " +
                            "cpu_cooling, additional_devices, ram, ram_capacity) " +
                            $"VALUES ('{device.Text1}', '{device.Text2}', '{device.Text3}', '{device.Text4}', {device.Num1}, {device.Num2}, " +
                            $"'{device.Text5}', '{device.MultiText}', '{device.Text6}', {device.Num3}) " +
                            "RETURNING id_stationary_computer";
                    }
                    else if (device.Type == Devices.Phone)
                    {
                        column = "id_smartphone";
                        sql = $"insert into smartphones (manufacturer, model, imei) VALUES ('{device.Text1}', '{device.Text2}', '{device.Text3}') RETURNING id_smartphone";
                    }
                    else if (device.Type == Devices.Laptop)
                    {
                        column = "id_laptop_or_monoblock";
                        sql = "insert into laptops_and_monoblocks (manufacturer, model, cpu, ram, ram_capacity, number_of_drives, total_drives_capacity) " +
                            $"VALUES ('{device.Text1}', '{device.Text2}', '{device.Text3}', '{device.Text4}', {device.Num1}, {device.Num2}, {device.Num3}) " +
                            "RETURNING id_laptop_or_monoblock";
                    }
                    else if (device.Type == Devices.Other)
                    {
                        column = "id_component_or_other_devices";
                        sql = "insert into components_or_other_devices (id_component_type, manufacturer, model) " +
                            $"VALUES ({device.Num1}, '{device.Text1}', '{device.Text2}') RETURNING id_component_or_other_devices";
                    }

                    device_id = Connect.GetString(sql);
                    if (device_id == null)
                    {
                        MessageBox.Show("Не удалось обновить информацию о девайсе!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }


                    name = Connect.GetString($"select name_table from types_of_device where id_type_of_device  = {deviceAndOrder.Rows[0].Field<int>("type")}");
                    Connect.GetString($"delete from {name} where {column} = {deviceAndOrder.Rows[0].Field<int>("device")}");

                    result = Connect.GetString($"UPDATE orders SET (date_of_adoption, customer_comment, id_type_of_service) = " + 
                        $"('{dateTimePicker.Value.ToShortDateString()}', '{commentField.Text}', {servicesList.SelectedValue}) " + 
                        $"WHERE id_orders = {deviceAndOrder.Rows[0]("order")}");
                    if (result == null)
                    {
                            MessageBox.Show("Не удалось обновить данные о заказе!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                    }
                    result = Connect.GetString($"UPDATE orders_and_devices SET (id_type_of_device, id_specific_device) = " + 
                        $"({(int)device.Type}, {device_id}) WHERE id_order_and_device = {id}");
                }

                else 
                { 
                    client_id = Connect.GetString($"select id_client from clients where passport_series = '{client.Series}'");
                    if (client_id != null)
                    {
                        if (MessageBox.Show("Информация о клиенте с такой серией паспорта уже иммеется.\n" +
                            "Желаете использовать данные уже существующего клиента ?", "Информация", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Information) == DialogResult.No)
                            return;
                    }
                    else
                    {
                        client_id = Connect.GetString("insert into clients (last_name_client, first_name_client, middle_name_client, passport_series, phone) " +
                            $"values('{client.LastName}', '{client.FirstName}', '{client.MiddleName}', '{client.Series}', '{client.Number}') RETURNING id_client");
                        if (client_id == null)
                        {
                            MessageBox.Show("Не удалось добавить клиента!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
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
