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
    public partial class Registration : UserControl
    {
        MyDatabase md = new MyDatabase();
        public Registration()
        {
            InitializeComponent();
        }

        string edit_id = "";

        private void bunifuFlatButton12_Click(object sender, EventArgs e)
        {

        }

        public void showItemCode()
        {
            dgv_list.DataSource = md.dgv_showItemCode().DataSource;
            dgv_list.Columns[0].Visible = false;
            dgv_list.Columns[1].HeaderText = "Item Code";
            dgv_list.Columns[2].HeaderText = "Category";
            dgv_list.Columns[3].HeaderText = "Sub-Category";
            dgv_list.Columns[4].HeaderText = "Item Name";
            dgv_list.Columns[5].HeaderText = "Brand";
            dgv_list.Columns[6].HeaderText = "Model";
            dgv_list.Columns[7].HeaderText = "Description";
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            showItemCode();
        }
        private void btnRegItemCode_Click(object sender, EventArgs e)
        {
            frmRegisterItemCode rf = new frmRegisterItemCode();
            rf.Show();
        }

        private void btnRegICAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRegICDrop_Click(object sender, EventArgs e)
        {

        }

        private void btnRegICEdit_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton9_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            showItemCode();
        }

        private void dgv_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgv_list.SelectedRows)
            {
                btnEditItemCode.Enabled = true;
                edit_id = row.Cells[0].Value.ToString();
                lblPreviewItemCode.Text = row.Cells[1].Value.ToString();
                txtEditCategory.Text = row.Cells[2].Value.ToString();
                txtEditSubCategory.Text = row.Cells[3].Value.ToString();
                txtEditItemName.Text = row.Cells[4].Value.ToString();
                txtEditBrand.Text = row.Cells[5].Value.ToString();
                txtEditModel.Text = row.Cells[6].Value.ToString();
                txtEditDescription.Text = row.Cells[7].Value.ToString();
            }
        }

        private void btnEditItemCode_Click(object sender, EventArgs e)
        {
            pnlEditItemCode.Visible = true;
            txtEditCategory.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            pnlEditItemCode.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            md.UpdateItemCode(edit_id, txtEditCategory.Text, txtEditSubCategory.Text, txtEditItemName.Text, txtEditBrand.Text, txtEditModel.Text, txtEditDescription.Text);
            pnlEditItemCode.Visible = false;
            MessageBox.Show( lblPreviewItemCode.Text + " Update Succesfully.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void dgv_list_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pnlEditItemCode_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
