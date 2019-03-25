using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppeTown_InventorySystem.MainControls
{
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        MyDatabase md = new MyDatabase();

        private void Dashboard_Load(object sender, EventArgs e)
        {

            dgv_Dashboard.DataSource = md.dgv_SearchInventory("").DataSource;
        }

        private void txtSearch_OnValueChanged(object sender, EventArgs e)
        {
            dgv_Dashboard.DataSource = md.dgv_SearchInventory(txtSearch.Text).DataSource;
        }
    }
}
