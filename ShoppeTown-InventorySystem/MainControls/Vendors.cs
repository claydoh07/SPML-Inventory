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
        public Vendors()
        {
            InitializeComponent();
        }

        private void Vendors_Load(object sender, EventArgs e)
        {
            dgv_Vendors.DataSource = md.dgv_VendorTable("").DataSource;
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            string[] msg = new string[]
                { "", "Category ", "Sub Category ", "Company Name ", "Contact Person ",
                  "Company Address ", "Telephone # 1 ", "Telephone # 2 ", "Mobile # 1 ",
                  "Mobile # 2 ","Fax # ", "Email Address 1 ", "Email Address 2 ", "Website " };

            if ((cboCat.Text != "" && cboSubCat.Text != "" && txtVendorName.Text != "" && txtContactPerson.Text != "" &&
                txtCompAddress.Text != "" && txtTel1.Text != "" && txtTel2.Text != "" && txtMob1.Text != "" &&
                txtMob2.Text != "" && txtFax.Text != "" && txtEmail1.Text != "" && txtEmail2.Text != "" && txtWebsite.Text != "") == true)
            {
                DialogResult dg = MessageBox.Show(Review(msg) , "User Confirmation", MessageBoxButtons.OKCancel);
                if (dg == DialogResult.OK)
                {
                    md.AddVendor(cboCat.Text, cboSubCat.Text, txtVendorName.Text, txtContactPerson.Text,
                     txtCompAddress.Text, txtTel1.Text, txtTel2.Text, txtMob1.Text, txtMob2.Text,
                     txtFax.Text, txtEmail1.Text, txtEmail2.Text, txtWebsite.Text);
                    //Call Database
                    dgv_Vendors.DataSource = md.dgv_VendorTable("").DataSource;
                    Clear();
                }

                else if (dg == DialogResult.Cancel)
                {
                }
            }

            else
            {
                int checker = 0;
                if (cboCat.Text == "") checker = 1;
                else if (cboSubCat.Text == "") checker = 2;
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
                        if (checker == 1) cboCat.Focus();
                        else if (checker == 2) cboSubCat.Focus();
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
            cboCat.Text = "";
            cboSubCat.Text = "";
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

           
        }
        public string Review(string[] arr)
        {
            string msg = 
            arr[1] + ": " + cboCat.Text + System.Environment.NewLine + 
            arr[2] + ": " + cboSubCat.Text + System.Environment.NewLine +
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

        }

        private void txtSearch_OnValueChanged(object sender, EventArgs e)
        {
            dgv_Vendors.DataSource = md.dgv_VendorTable(txtSearch.Text).DataSource;
        }
    }
}
