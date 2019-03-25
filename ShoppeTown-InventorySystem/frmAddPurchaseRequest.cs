using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppeTown_InventorySystem
{
    public partial class frmAddPurchaseRequest : MetroFramework.Forms.MetroForm
    {
        public frmAddPurchaseRequest()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmAddPurchaseRequest_Load(object sender, EventArgs e)
        {
            tblRegPanel.Size = new Size(654, 27);

        }

        private void emptyComboBoxes()
        {
            cboCategory_1.Items.Clear();
            cboCategory_2.Items.Clear();
            cboCategory_3.Items.Clear();
            cboCategory_4.Items.Clear();
            cboCategory_5.Items.Clear();
            cboCategory_6.Items.Clear();
            cboCategory_7.Items.Clear();
            cboCategory_8.Items.Clear();
            cboCategory_9.Items.Clear();
            cboCategory_10.Items.Clear();
            cboCategory_11.Items.Clear();

            cboTOS_1.Items.Clear();
            cboTOS_2.Items.Clear();
            cboTOS_3.Items.Clear();
            cboTOS_4.Items.Clear();
            cboTOS_5.Items.Clear();
            cboTOS_6.Items.Clear();
            cboTOS_7.Items.Clear();
            cboTOS_8.Items.Clear();
            cboTOS_9.Items.Clear();
            cboTOS_10.Items.Clear();
            cboTOS_11.Items.Clear();

            cboUnit_1.Items.Clear();
            cboUnit_2.Items.Clear();
            cboUnit_3.Items.Clear();
            cboUnit_4.Items.Clear();
            cboUnit_5.Items.Clear();
            cboUnit_6.Items.Clear();
            cboUnit_7.Items.Clear();
            cboUnit_8.Items.Clear();
            cboUnit_9.Items.Clear();
            cboUnit_10.Items.Clear();
            cboUnit_11.Items.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void numRow_ValueChanged(object sender, EventArgs e)
        {
            tblRegPanel.Size = new Size(654, 27 + (25 * Convert.ToInt32(numRow.Value)));

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void tblRegPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
