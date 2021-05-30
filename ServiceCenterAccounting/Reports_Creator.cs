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
    public partial class Reports_Creator : Form
    {
        string LoadSQL;
        public Reports_Creator()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IntervalBox.SelectedItem.ToString() == "За определённый промежуток")
            {
                label2.Visible = true;
                label3.Visible = true;
                IntervalTo.Visible = true;
                IntervalAfter.Visible = true;
            }
        }

        private void Reports_Creator_Load(object sender, EventArgs e)
        {

        }

        private void IntervalAfter_CloseUp(object sender, EventArgs e)
        {
            LoadSQL = "select distinct workers.id_worker as ID,workers.last_name_worker as Фамилия_работника," +
            "workers.first_name_worker as Имя_работника,workers.middle_name_worker as Отчество_работника," +
            "(select count(*)from orders where id_worker = workers.id_worker) as Кол-во_выполненных_заказов," +
            "(select sum(price) from orders where id_worker = workers.id_worker) as Общая_стоимость_заказов," +
            "((select count(*)from orders where id_worker = workers.id_worker)*interest_rate) as Зарплата_сотрудника" +
            $"from workers, orders where orders.date_of_completion between date('{IntervalTo.Value.Date.ToString("yyyy-MM-dd")}') and date('{IntervalAfter.Value.Date.ToString("yyyy-MM-dd")}')";
        }
    }
}
