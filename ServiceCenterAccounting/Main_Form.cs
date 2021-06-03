using Microsoft.Win32;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ServiceCenterAccounting
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
            RegistryKey currentUserKey = Registry.CurrentUser;
            string[] sub_keys = currentUserKey.GetSubKeyNames();
            if (!sub_keys.Contains("SCA_Key"))
            {
                RegistryKey SCA_Key = currentUserKey.CreateSubKey("SCA_Key");
                Initial_Setup setup = new Initial_Setup();
                setup.ShowDialog();
            }
            Authorization authorization = new Authorization();
            authorization.ShowDialog();
            dg_Orders_Accepted.DataSource = Connect.Select("SELECT id_orders, " +
                "concat(clients.last_name_client, ' ', substring(clients.first_name_client, 1, 1), '. ', substring(clients.middle_name_client, 1, 1), '. ') " +
                "AS \"ФИО клиента\", " +
                "clients.passport_series AS \"Серия паспорта клиента\", " +
                "date_of_adoption AS \"Дата получения заказа\", " +
                "stages_of_execution.name_stage_of_execution AS \"Стадия выполнения\", " +
                "types_of_service.name_type_of_service AS \"Тип услуги\", " +
                "types_of_service.cost_of_service AS \"Стоимость услуги\" " +
                "FROM orders LEFT JOIN clients on orders.id_client = clients.id_client " +
                "LEFT JOIN types_of_service on types_of_service.id_type_of_service = orders.id_type_of_service " +
                "LEFT JOIN stages_of_execution on stages_of_execution.id_stage_of_execution = orders.id_stage_of_execution " +
                "WHERE stages_of_execution.id_stage_of_execution = 1");
            dg_Orders_Accepted.Columns[0].Visible = false;
        }

        private void btn_Add_Order_Click(object sender, EventArgs e)
        {
            AddingAndChangingOrders adding = new AddingAndChangingOrders();
            adding.ShowDialog();
        }


        private void bnt_Reports_Click(object sender, EventArgs e)
        {
            Reports_Creator reports = new Reports_Creator();
            reports.ShowDialog();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Text.Equals("Принятые заказы"))
            {
                dg_Orders_Accepted.DataSource = Connect.Select("SELECT id_orders, " +
                    "concat(clients.last_name_client, ' ', substring(clients.first_name_client, 1, 1), '. ', substring(clients.middle_name_client, 1, 1), '. ') " +
                    "AS \"ФИО клиента\", " +
                    "clients.passport_series AS \"Серия паспорта клиента\", " +
                    "date_of_adoption AS \"Дата получения заказа\", " +
                    "stages_of_execution.name_stage_of_execution AS \"Стадия выполнения\", " +
                    "types_of_service.name_type_of_service AS \"Тип услуги\", " +
                    "types_of_service.cost_of_service AS \"Стоимость услуги\" " +
                    "FROM orders LEFT JOIN clients on orders.id_client = clients.id_client " +
                    "LEFT JOIN types_of_service on types_of_service.id_type_of_service = orders.id_type_of_service " +
                    "LEFT JOIN stages_of_execution on stages_of_execution.id_stage_of_execution = orders.id_stage_of_execution " +
                    "WHERE stages_of_execution.id_stage_of_execution = 1");
                dg_Orders_Accepted.Columns[0].Visible = false;
                btn_Change_Status.Visible = true;
            }
            else if(tabControl1.SelectedTab.Text.Equals("Заказы в работе"))
            {
                dg_Orders_in_Progress.DataSource = Connect.Select("SELECT id_orders, " +
                    "concat(clients.last_name_client, ' ', substring(clients.first_name_client, 1, 1), '. ', substring(clients.middle_name_client, 1, 1), '. ') " +
                    "AS \"ФИО клиента\", " +
                    "clients.passport_series AS \"Серия паспорта клиента\",  " +
                    "concat(workers.last_name_worker, ' ', substring(workers.first_name_worker, 1, 1), '. ', substring(workers.middle_name_worker, 1, 1), '. ') " +
                    "AS \"ФИО работника\", " +
                    "date_of_adoption AS \"Дата получения заказа\", " +
                    "stages_of_execution.name_stage_of_execution AS \"Стадия выполнения\", " +
                    "types_of_service.name_type_of_service AS \"Тип услуги\", " +
                    "types_of_service.cost_of_service AS \"Стоимость услуги\" " +
                    "FROM orders " +
                    "LEFT JOIN clients on orders.id_client = clients.id_client " +
                    "LEFT JOIN workers on workers.id_worker = orders.id_worker " +
                    "LEFT JOIN types_of_service on types_of_service.id_type_of_service = orders.id_type_of_service " +
                    "LEFT JOIN stages_of_execution on stages_of_execution.id_stage_of_execution = orders.id_stage_of_execution " +
                    "WHERE stages_of_execution.id_stage_of_execution = 2");
                dg_Orders_in_Progress.Columns[0].Visible = false;
                btn_Change_Status.Visible = true;
            }
            else if(tabControl1.SelectedTab.Text.Equals("Завершенные заказы"))
            {
                dg_Completed_Orders.DataSource = Connect.Select("SELECT id_orders, " +
                    "concat(clients.last_name_client, ' ', substring(clients.first_name_client, 1, 1), '. ', substring(clients.middle_name_client, 1, 1), '. ') " +
                    "AS \"ФИО клиента\", " +
                    "clients.passport_series AS \"Серия паспорта клиента\",  " +
                    "concat(workers.last_name_worker, ' ', substring(workers.first_name_worker, 1, 1), '. ', substring(workers.middle_name_worker, 1, 1), '. ') " +
                    "AS \"ФИО работника\", " +
                    "date_of_adoption AS \"Дата получения заказа\", " +
                    "date_of_completion AS \"Дата завершения закза\", " +
                    "stages_of_execution.name_stage_of_execution AS \"Стадия выполнения\", " +
                    "types_of_service.name_type_of_service AS \"Тип услуги\", " +
                    "types_of_service.cost_of_service AS \"Стоимость услуги\", " +
                    "cost_of_parts AS \"Стоимость запчастей\", " +
                    "price AS \"Общая сумма\" " +
                    "FROM orders " +
                    "LEFT JOIN clients on orders.id_client = clients.id_client " +
                    "LEFT JOIN workers on workers.id_worker = orders.id_worker " +
                    "LEFT JOIN types_of_service on types_of_service.id_type_of_service = orders.id_type_of_service " +
                    "LEFT JOIN stages_of_execution on stages_of_execution.id_stage_of_execution = orders.id_stage_of_execution " +
                    "WHERE stages_of_execution.id_stage_of_execution = 3");
                dg_Completed_Orders.Columns[0].Visible = false;
                btn_Change_Status.Visible = false;
            }
        }

        private void btn_Change_Stattus_Click(object sender, EventArgs e)
        {
            string id_order = null;
            bool is_acepted = true;
            if (tabControl1.SelectedTab.Text.Equals("Принятые заказы"))
            {
                DataGridViewRow row = dg_Orders_Accepted.SelectedRows[0];
                id_order = row.Cells[0].Value.ToString();
                is_acepted = true;
            }
            else if (tabControl1.SelectedTab.Text.Equals("Заказы в работе"))
            {
                DataGridViewRow row = dg_Orders_in_Progress.SelectedRows[0];
                id_order = row.Cells[0].Value.ToString();
                is_acepted = false;
            }
            else
            {
                return;
            }
            Action_for_Orders action = new Action_for_Orders(id_order, is_acepted);
            action.ShowDialog();
        }
    }
}
