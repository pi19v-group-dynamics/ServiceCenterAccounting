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
    public partial class Action_for_Orders : Form
    {
        string Id_order;
        bool Previos_Stage;

        public Action_for_Orders(string id_order, bool previos_stage)
        {
            InitializeComponent();
            Id_order = id_order;
            Previos_Stage = previos_stage;
            if(Previos_Stage == true)
            {
                cb_Worker.Visible = true;
                cb_Worker.DataSource = Connect.Select("SELECT id_worker, " +
                    "concat(workers.last_name_worker, ' ', substring(workers.first_name_worker, 1, 1), '. ', substring(workers.middle_name_worker, 1, 1), '. ') " +
                    "AS \"fio\" " +
                    "FROM workers " +
                    "WHERE employment = false");
                cb_Worker.DisplayMember = "fio";
                cb_Worker.ValueMember = "id_worker";
                l_Text1.Text = "Назначте работника:";
                l_Text1.Location = new Point(54, 9);
            }
            else
            {
                nud_Cost_of_Parts.Visible = true;
                nud_Cost_of_Parts.Enabled = true;
                l_Text1.Text = "Введите стоимость запчастей:";
                l_Text1.Location = new Point(37, 9);
            }
        }

        private void btn_Accept_Click(object sender, EventArgs e)
        {
            if (Previos_Stage == true)
            {
                Connect.Select($"UPDATE orders SET id_worker = {cb_Worker.SelectedValue}, id_stage_of_execution = 2 WHERE id_orders = {Id_order};" +
                    $"UPDATE workers SET employment = true WHERE id_worker = {cb_Worker.SelectedValue}");
                this.Close();
            }
            else
            {
                 Connect.Select($"UPDATE orders SET date_of_completion = '{DateTime.Now.ToString("d")}', " +
                     $"id_stage_of_execution = 3, " +
                     $"cost_of_parts = {nud_Cost_of_Parts.Value.ToString().Replace(',', '.')} WHERE id_orders = {Id_order}");
                this.Close();
            }
        }
    }
}
