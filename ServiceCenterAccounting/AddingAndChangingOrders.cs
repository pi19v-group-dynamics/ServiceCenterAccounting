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
        Client client;

        public AddingAndChangingOrders()
        {
            InitializeComponent();
            Filling();
        }

        private void Filling()
        {
            workersList.DataSource = Connect.Select("select id_worker as id, " +
                "last_name_worker || ' ' || substring(first_name_worker from 1 for 1) " +
                "|| '.'|| substring(middle_name_worker from 1 for 1) || '.' as name from workers where employment = false");
            workersList.DisplayMember = "name";
            workersList.ValueMember = "id";

            servicesList.DataSource = Connect.Select("select id_type_of_service as id, name_type_of_service || ' (' || " +
                "cost_of_service || ' руб.' || ')' as name from types_of_service ");
            servicesList.DisplayMember = "name";
            servicesList.ValueMember = "id";

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
            clientField.Text = $"{client.LastName} {client.FirstName[0]}. {client.MiddleName[0]}.";
        }
    }
}
