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

        MyDatabase md = new MyDatabase();

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
            tblRegPanel.Size = new Size(660, 20);

            txtPRNo.Text = md.getPRNo().ToString();

            numRow.Value = 1;
            emptyComboBoxes();

            cboBusinessType.Items.Add("UAC");
            cboBusinessType.Items.Add("SPML");

            string[] tos = new string[3];
            tos[0] = "CONSTRUCTIONS";
            tos[1] = "FIXED ASSET";
            tos[2] = "CONSUMABLES";

            cboTOS_1.Items.AddRange(tos);
            cboTOS_2.Items.AddRange(tos);
            cboTOS_3.Items.AddRange(tos);
            cboTOS_4.Items.AddRange(tos);
            cboTOS_5.Items.AddRange(tos);
            cboTOS_6.Items.AddRange(tos);
            cboTOS_7.Items.AddRange(tos);
            cboTOS_8.Items.AddRange(tos);
            cboTOS_9.Items.AddRange(tos);
            cboTOS_10.Items.AddRange(tos);
            cboTOS_11.Items.AddRange(tos);


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

            cboBusinessType.Items.Clear(); 
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
            tblRegPanel.Size = new Size(660, 20 + (28 * Convert.ToInt32(numRow.Value)));

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

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            insertingPR();
            this.Hide();
        }

        public void insertingPR()
        {
            md.PRno_insert(txtPRNo.Text, txtRequestorName.Text);

            string[,] info = new string[100, 100];

            info[0, 0] = cboTOS_1.Text;
            info[0, 1] = txtItem_1.Text;
            info[0, 2] = txtDesc_1.Text;
            info[0, 3] = "";
            info[0, 4] = txtQuantity_1.Text;
            info[0, 5] = cboUnit_1.Text;

            info[1, 0] = cboTOS_2.Text;
            info[1, 1] = txtItem_2.Text;
            info[1, 2] = txtDesc_2.Text;
            info[1, 3] = "";
            info[1, 4] = txtQuantity_2.Text;
            info[1, 5] = cboUnit_2.Text;

            info[2, 0] = cboTOS_3.Text;
            info[2, 1] = txtItem_3.Text;
            info[2, 2] = txtDesc_3.Text;
            info[2, 3] = "";
            info[2, 4] = txtQuantity_3.Text;
            info[2, 5] = cboUnit_3.Text;

            info[3, 0] = cboTOS_4.Text;
            info[3, 1] = txtItem_4.Text;
            info[3, 2] = txtDesc_4.Text;
            info[3, 3] = "";
            info[3, 4] = txtQuantity_4.Text;
            info[3, 5] = cboUnit_4.Text;

            info[4, 0] = cboTOS_5.Text;
            info[4, 1] = txtItem_5.Text;
            info[4, 2] = txtDesc_5.Text;
            info[4, 3] = "";
            info[4, 4] = txtQuantity_5.Text;
            info[4, 5] = cboUnit_5.Text;

            info[5, 0] = cboTOS_6.Text;
            info[5, 1] = txtItem_6.Text;
            info[5, 2] = txtDesc_6.Text;
            info[5, 3] = "";
            info[5, 4] = txtQuantity_6.Text;
            info[5, 5] = cboUnit_6.Text;

            info[6, 0] = cboTOS_7.Text;
            info[6, 1] = txtItem_7.Text;
            info[6, 2] = txtDesc_7.Text;
            info[6, 3] = "";
            info[6, 4] = txtQuantity_7.Text;
            info[6, 5] = cboUnit_7.Text;

            info[7, 0] = cboTOS_8.Text;
            info[7, 1] = txtItem_8.Text;
            info[7, 2] = txtDesc_8.Text;
            info[7, 3] = "";
            info[7, 4] = txtQuantity_8.Text;
            info[7, 5] = cboUnit_8.Text;

            info[8, 0] = cboTOS_9.Text;
            info[8, 1] = txtItem_9.Text;
            info[8, 2] = txtDesc_9.Text;
            info[8, 3] = "";
            info[8, 4] = txtQuantity_9.Text;
            info[8, 5] = cboUnit_9.Text;

            info[9, 0] = cboTOS_10.Text;
            info[9, 1] = txtItem_10.Text;
            info[9, 2] = txtDesc_10.Text;
            info[9, 3] = "";
            info[9, 4] = txtQuantity_10.Text;
            info[9, 5] = cboUnit_10.Text;

            md.PR_insert(txtPRNo.Text, txtRequestorName.Text, txtContactNumber.Text, txtDepartment.Text, txtProjectName.Text, cboBusinessType.Text, dtpReqDate1.Text, dtpReqDate2.Text, txtCostCenter.Text, txtPurpose.Text, cboPriority.Text, numRow.Value.ToString(), info);
            MessageBox.Show("Purchase Requests has been successfully added!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
