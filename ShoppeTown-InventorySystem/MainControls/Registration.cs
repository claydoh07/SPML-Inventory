﻿using System;
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

            this.dgv_list.Columns[0].Width = 0;
            this.dgv_list.Columns[1].Width = 20;
            this.dgv_list.Columns[2].Width = 25;
            this.dgv_list.Columns[3].Width = 20;
            this.dgv_list.Columns[4].Width = 20;
            this.dgv_list.Columns[5].Width = 20;
            this.dgv_list.Columns[6].Width = 20;
            this.dgv_list.Columns[7].Width = 300;
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

        private void pnlEditItemCode_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgv_list_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgv_list.SelectedRows)
            {
                btnEditItemCode.Enabled = true;
                btnDelete.Enabled = true;
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgv_list.SelectedRows)
            {
                DialogResult dr =  MessageBox.Show("Do you want to Delete?", "Delete item code", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    md.DeleteItemCode(row.Cells[0].Value.ToString());
                    MessageBox.Show("Delete Successfully!?", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnRefresh_Click(sender, e);
                }
            }
        }

        private void dgv_list_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgv_list.SelectedRows)
            {
                string item_Code = row.Cells[1].Value.ToString();
                string category = row.Cells[2].Value.ToString();
                string sub_category = row.Cells[3].Value.ToString();
                string item_name = row.Cells[4].Value.ToString();
                string brand = row.Cells[5].Value.ToString();
                string model = row.Cells[6].Value.ToString();
                string description = row.Cells[7].Value.ToString();

                MessageBox.Show("Item Code:\t'" + item_Code + "'\n Category:\t'" + category + "'\n Sub category:\t'" + sub_category + "'\n Item Name:\t'" + item_name + "'\n Brand:\t\t'" + brand + "'\n Model:\t\t'" + model + "'\n Description:\t'" + description + "'\n"
                    , "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
