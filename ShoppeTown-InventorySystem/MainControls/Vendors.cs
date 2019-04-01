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
    public partial class Vendors : UserControl
    {
        MyDatabase md = new MyDatabase();
        public int ctrl = 0;
        public Vendors()
        {
            InitializeComponent();
        }

        private void Vendors_Load(object sender, EventArgs e)
        {
            dgv_Vendors.DataSource = md.dgv_VendorTable("").DataSource;
            showDgv();//to change the header of the datagridview

            for (int x = 0; x < md.showCategory().Length; x++)//for listing ng mga category name
            {
                if (md.showCategory().GetValue(x).ToString() != "")
                    cboCat1.Items.Add(md.showCategory().GetValue(x).ToString());
                if (md.showCategory().GetValue(x).ToString() != "")
                    cboCat2.Items.Add(md.showCategory().GetValue(x).ToString());
                if (md.showCategory().GetValue(x).ToString() != "")
                    cboCat3.Items.Add(md.showCategory().GetValue(x).ToString());
            }

        }

        private void showDgv()
        {
            dgv_Vendors.DataSource = md.dgv_VendorTable("").DataSource;
            dgv_Vendors.Columns[0].Visible = false;
            dgv_Vendors.Columns[1].HeaderText = "VENDOR NAME";
            dgv_Vendors.Columns[2].HeaderText = "CONTACT PERSON";
            dgv_Vendors.Columns[3].HeaderText = "ADDRESS";
            dgv_Vendors.Columns[4].HeaderText = "TEL #1";
            dgv_Vendors.Columns[5].HeaderText = "TEL #2";
            dgv_Vendors.Columns[6].HeaderText = "MOBILE #1";
            dgv_Vendors.Columns[7].HeaderText = "MOBILE #2";
            dgv_Vendors.Columns[8].HeaderText = "FAX #";
            dgv_Vendors.Columns[9].HeaderText = "EMAIL #1";
            dgv_Vendors.Columns[10].HeaderText = "EMAIL #2";
            dgv_Vendors.Columns[11].HeaderText = "WEBSITE";
            dgv_Vendors.Columns[12].HeaderText = "CATEGORY 1";
            dgv_Vendors.Columns[13].HeaderText = "SUB CATEGORY 1";
            dgv_Vendors.Columns[14].HeaderText = "CATEGORY 2";
            dgv_Vendors.Columns[15].HeaderText = "SUB CATEGORY 2";
            dgv_Vendors.Columns[16].HeaderText = "CATEGORY 3";
            dgv_Vendors.Columns[17].HeaderText = "SUB CATEGORY 3";

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_OnValueChanged_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            

        }

        public string[] msg = new string[]
                { "", "Category ", "Sub Category ", "Company Name ", "Contact Person ",
                  "Company Address ", "Telephone # 1 ", "Telephone # 2 ", "Mobile # 1 ",
                  "Mobile # 2 ","Fax # ", "Email Address 1 ", "Email Address 2 ", "Website " };

        private void btnSave_Click(object sender, EventArgs e)
        {
            if ((cboCat1.Text != "" && txtCat1.Text != "" && txtVendorName.Text != "" && txtContactPerson.Text != "" &&
                txtCompAddress.Text != "" && txtTel1.Text != "" && txtTel2.Text != "" && txtMob1.Text != "" &&
                txtMob2.Text != "" && txtFax.Text != "" && txtEmail1.Text != "" && txtEmail2.Text != "" && txtWebsite.Text != "") == true)
            {
                DialogResult dg = MessageBox.Show(Review(msg) , "User Confirmation", MessageBoxButtons.OKCancel);
                if (dg == DialogResult.OK)
                {
                    if (RegisterAutoProperty.vendorID == "0")
                    {
                        md.AddVendor(cboCat1.Text, txtCat1.Text, cboCat2.Text, txtCat2.Text,
                            cboCat3.Text, txtCat3.Text, "", "", "", "", "", "", "", "", txtVendorName.Text, txtContactPerson.Text,
                         txtCompAddress.Text, txtTel1.Text, txtTel2.Text, txtMob1.Text, txtMob2.Text,
                         txtFax.Text, txtEmail1.Text, txtEmail2.Text, txtWebsite.Text);
                        //Call Database
                        //dgv_Vendors.DataSource = md.dgv_VendorTable("").DataSource;
                        showDgv();
                        Clear();
                        btnCancel_Click(sender, e);
                    }
                    else
                    {
                        md.UpdateVendor(cboCat1.Text, txtCat1.Text, cboCat2.Text, txtCat2.Text,
                            cboCat3.Text, txtCat3.Text, "hello", "hello", "hello", "hello", "hello", "hello", "hello", "hello", txtVendorName.Text, txtContactPerson.Text,
                         txtCompAddress.Text, txtTel1.Text, txtTel2.Text, txtMob1.Text, txtMob2.Text,
                         txtFax.Text, txtEmail1.Text, txtEmail2.Text, txtWebsite.Text);
                        //Call Database
                        //dgv_Vendors.DataSource = md.dgv_VendorTable("").DataSource;
                        showDgv();
                        Clear();
                        btnCancel_Click(sender, e);
                    }
                }

                else if (dg == DialogResult.Cancel)
                {
                }
            }

            else
            {
                int checker = 0;
                if (cboCat.Text == "") checker = 1;
                else if (cboCat1.Text == "") checker = 2;
                else if (txtVendorName.Text == "") checker = 3;
                else if (txtContactPerson.Text == "") checker = 4;
                else if (txtCompAddress.Text == "") checker = 5;
                else if (txtTel1.Text == "") checker = 6;
                else if (txtTel2.Text == "") checker = 7;
                else if (txtMob1.Text == "") checker = 8;
                else if (txtMob2.Text == "") checker = 9;
                else if (txtFax.Text == "") checker = 10;
                else if (txtEmail1.Text == "") checker = 11;
                else if (txtEmail2.Text == "") checker = 12;
                else if (txtWebsite.Text == "") checker = 13;
                
                for (int i = 0; i <= 13; i++)
                {
                    if (checker == i)
                    {
                        MessageBox.Show(null, msg[checker] + "must have a value.", "Attention", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        if (checker == 1) cboCat1.Focus();
                        else if (checker == 2) txtCat1.Focus();
                        else if (checker == 3) txtVendorName.Focus();
                        else if (checker == 4) txtContactPerson.Focus();
                        else if (checker == 5) txtCompAddress.Focus();
                        else if (checker == 6) txtTel1.Focus();
                        else if (checker == 7) txtTel2.Focus();
                        else if (checker == 8) txtMob1.Focus();
                        else if (checker == 9) txtMob2.Focus();
                        else if (checker == 10) txtFax.Focus();
                        else if (checker == 11) txtEmail1.Focus();
                        else if (checker == 12) txtEmail2.Focus();
                        else if (checker == 13) txtWebsite.Focus();
                    }
                }

            }

        }
        private void btnRegVendor_Click(object sender, EventArgs e)
        {
            RegisterAutoProperty.vendorID = "0";
            grpRegVendor.Enabled = true;
            btnSave.Visible = true;
            btnClear.Visible = true;
            btnCancel.Visible = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
            btnSave.Visible = false;
            btnClear.Visible = false;
            btnCancel.Visible = false;
            grpRegVendor.Enabled = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        public void Clear()
        {
            cboCat1.SelectedIndex = -1;
            txtCat1.Text = "";
            cboCat2.SelectedIndex = -1;
            txtCat2.Text = "";
            cboCat3.SelectedIndex = -1;
            txtCat3.Text = "";
            txtContactPerson.Text = "";
            txtCompAddress.Text = "";
            txtEmail1.Text = "";
            txtEmail2.Text = "";
            txtFax.Text = "";
            txtMob1.Text = "";
            txtMob2.Text = "";
            txtTel1.Text = "";
            txtTel2.Text = "";
            txtVendorName.Text = "";
            txtWebsite.Text = "";
            btnDelete.Visible = false;
            txtCat1.Text = "";

            btnAddCat1.Enabled = false;
            txtCat1.Enabled = false;
            btnAddCat2.Enabled = false;
            txtCat2.Enabled = false;
            btnAddCat3.Enabled = false;
            txtCat3.Enabled = false;


        }
        public string Review(string[] arr)
        {
            string msg = 
            arr[1] + ": " + cboCat.Text + System.Environment.NewLine + 
            arr[2] + ": " + cboCat1.Text + System.Environment.NewLine +
            arr[3] + ": " + txtVendorName.Text + System.Environment.NewLine +
            arr[4] + ": " + txtContactPerson.Text + System.Environment.NewLine +
            arr[5] + ": " + txtCompAddress.Text + System.Environment.NewLine +
            arr[6] + ": " + txtTel1.Text + System.Environment.NewLine +
            arr[7] + ": " + txtTel2.Text + System.Environment.NewLine +
            arr[8] + ": " + txtMob1.Text + System.Environment.NewLine +
            arr[9] + ": " + txtMob2.Text + System.Environment.NewLine +
            arr[10] + ": " + txtFax.Text + System.Environment.NewLine +
            arr[11] + ": " + txtEmail1.Text + System.Environment.NewLine +
            arr[12] + ": " + txtEmail2.Text + System.Environment.NewLine +
            arr[13] + ": " + txtWebsite.Text;

            return msg;
        }

        private void dgv_Vendors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            foreach (DataGridViewRow row in dgv_Vendors.SelectedRows)
            {
                RegisterAutoProperty.vendorID = row.Cells[0].Value.ToString();
                cboCat1.SelectedItem =           row.Cells[12].Value.ToString();
                txtCat1.Text =           row.Cells[13].Value.ToString();
                cboCat2.SelectedItem =           row.Cells[14].Value.ToString();
                txtCat2.Text =           row.Cells[15].Value.ToString();
                cboCat3.SelectedItem =           row.Cells[16].Value.ToString();
                txtCat3.Text =           row.Cells[17].Value.ToString();
               
                txtVendorName.Text =    row.Cells[1].Value.ToString();
                txtContactPerson.Text = row.Cells[2].Value.ToString();
                txtCompAddress.Text =   row.Cells[3].Value.ToString();
                txtTel1.Text =          row.Cells[4].Value.ToString();
                txtTel2.Text =          row.Cells[5].Value.ToString();
                txtMob1.Text =          row.Cells[6].Value.ToString();
                txtMob2.Text =          row.Cells[7].Value.ToString();
                txtFax.Text =           row.Cells[8].Value.ToString();
                txtEmail1.Text =        row.Cells[9].Value.ToString();
                txtEmail2.Text =        row.Cells[10].Value.ToString();
                txtWebsite.Text =       row.Cells[11].Value.ToString();
            }
            grpRegVendor.Enabled = true;
            btnClear.Visible = true;
            btnSave.Visible = true;
            btnCancel.Visible = true;
            btnDelete.Visible = true;
        }
        private void txtSearch_OnValueChanged(object sender, EventArgs e)
        {
            dgv_Vendors.DataSource = md.dgv_VendorTable(txtSearch.Text).DataSource;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (RegisterAutoProperty.vendorID != "0")
            {
                DialogResult dg = MessageBox.Show(Review(msg), "Delete these information?", MessageBoxButtons.OKCancel);
                if (dg == DialogResult.OK)
                {
                    md.DeleteVendor(txtCat1.Text, cboCat1.Text, cboCat2.Text, txtCat2.Text,
                            cboCat3.Text, txtCat3.Text, "", "", "", "", "", "", "", "", txtVendorName.Text, txtContactPerson.Text,
                        txtCompAddress.Text, txtTel1.Text, txtTel2.Text, txtMob1.Text, txtMob2.Text,
                        txtFax.Text, txtEmail1.Text, txtEmail2.Text, txtWebsite.Text);
                    //Call Database
                    dgv_Vendors.DataSource = md.dgv_VendorTable("").DataSource;
                    Clear();
                    RegisterAutoProperty.vendorID = "0";
                    btnDelete.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("No rows selected", "Delete these information?", MessageBoxButtons.OK);
                btnDelete.Visible = false;
            }
        }

        private void dgv_Vendors_Leave(object sender, EventArgs e)
        {
            btnDelete.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       
        private void btnCan_Click(object sender, EventArgs e)
        {
            pnlAddCategory.Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ctrl == 1)
            {
                if (cboCat.Text != "")
                {
                    txtCat1.Text += cboCat.Text + ", ";
                    pnlAddCategory.Visible = false;
                }
                else
                {
                    MessageBox.Show("Please select category before you add.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                ctrl = 0;
            }
            else if (ctrl == 2)
            {
                if (cboCat.Text != "")
                {
                    txtCat2.Text += cboCat.Text + ", ";
                    pnlAddCategory.Visible = false;
                }
                else
                {
                    MessageBox.Show("Please select category before you add.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                ctrl = 0;
            }
            else if (ctrl == 3)
            {
                if (cboCat.Text != "")
                {
                    txtCat3.Text += cboCat.Text + ", ";
                    pnlAddCategory.Visible = false;
                }
                else
                {
                    MessageBox.Show("Please select category before you add.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                ctrl = 0;
            }
        }

        private void btnAddCat_Click(object sender, EventArgs e)
        {
            ctrl = 1;
            lblAddSubCat.Text = "Add Sub Category for Category # " + ctrl;
            pnlAddCategory.Visible = true;
            cboCat.Items.Clear();

            for (int x = 0; x < md.ShowSC(cboCat1.Text).Length; x++)//for listing ng mga item name
            {
                if (md.ShowSC(cboCat1.Text).GetValue(x).ToString() != "")
                    cboCat.Items.Add(md.ShowSC(cboCat1.Text).GetValue(x).ToString());


            }

        }

        private void btnAddCat2_Click(object sender, EventArgs e)
        {
            ctrl = 2;
            lblAddSubCat.Text = "Add Sub Category for Category # " + ctrl;
            pnlAddCategory.Visible = true;
            cboCat.Items.Clear();

            for (int x = 0; x < md.ShowSC(cboCat2.Text).Length; x++)//for listing ng mga item name
            {
                if (md.ShowSC(cboCat2.Text).GetValue(x).ToString() != "")
                    cboCat.Items.Add(md.ShowSC(cboCat2.Text).GetValue(x).ToString());


            }
        }

        private void btnAddCat3_Click(object sender, EventArgs e)
        {
            ctrl = 3;
            lblAddSubCat.Text = "Add Sub Category for Category # " + ctrl;
            pnlAddCategory.Visible = true;
            cboCat.Items.Clear();

            for (int x = 0; x < md.ShowSC(cboCat3.Text).Length; x++)//for listing ng mga item name
            {
                if (md.ShowSC(cboCat3.Text).GetValue(x).ToString() != "")
                    cboCat.Items.Add(md.ShowSC(cboCat3.Text).GetValue(x).ToString());
            }
        }

        private void btnAddCat4_Click(object sender, EventArgs e)
        {
        }

        private void btnAddCat5_Click(object sender, EventArgs e)
        {
        }

        private void btnAddCat6_Click(object sender, EventArgs e)
        {
        }

        private void btnAddCat7_Click(object sender, EventArgs e)
        {
        }

        private void pnlAddCategory_Paint(object sender, PaintEventArgs e)
        {

        }
        public void EnableTxtBox()
        {
            if (cboCat1.SelectedIndex > -1)
            {
                txtCat1.Enabled = true;
                btnAddCat1.Enabled = true;
            }
            if (cboCat2.SelectedIndex > -1) { 
                txtCat2.Enabled = true;
                btnAddCat2.Enabled = true;
            }
            if (cboCat3.SelectedIndex > -1)
            {
                txtCat3.Enabled = true;
                btnAddCat3.Enabled = true;
            }
        }

        private void grpRegVendor_MouseHover(object sender, EventArgs e)
        {
            EnableTxtBox();
        }

        private void cboCat1_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableTxtBox();
        }

        private void cboCat6_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableTxtBox();
        }

        private void cboCat5_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableTxtBox();
        }

        private void cboCat3_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableTxtBox();
        }

        private void cboCat2_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableTxtBox();
        }

        private void cboCat7_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableTxtBox();
        }

        private void cboCat4_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableTxtBox();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showDgv();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            
        }

        private void label12_Click(object sender, EventArgs e)
        {
           
        }
    }
}
