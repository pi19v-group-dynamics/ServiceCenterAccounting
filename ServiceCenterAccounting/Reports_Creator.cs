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
    public partial class Reports_Creator : Form
    {
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
    }
}
