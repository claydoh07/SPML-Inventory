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
    public partial class Acct : UserControl
    {
        public Acct()
        {
            InitializeComponent();
        }

        MyDatabase md = new MyDatabase();
        private void Acct_Load(object sender, EventArgs e)
        {
            showMyAccountInfor();
        }

        private void showMyAccountInfor()
        {
            txtFirstName.Text = md.ShowAccountInfor(AccountInfo.id).GetValue(0).ToString();
            txtMIddleName.Text = md.ShowAccountInfor(AccountInfo.id).GetValue(1).ToString();
            txtLastName.Text = md.ShowAccountInfor(AccountInfo.id).GetValue(2).ToString();
            txtUserType.Text = md.ShowAccountInfor(AccountInfo.id).GetValue(3).ToString();
            txtPosition.Text = md.ShowAccountInfor(AccountInfo.id).GetValue(4).ToString();
            txtDepartment.Text = md.ShowAccountInfor(AccountInfo.id).GetValue(5).ToString();

            txtUsername.Text = md.ShowAccountInfor(AccountInfo.id).GetValue(6).ToString();
            txtpassword.Text = md.ShowAccountInfor(AccountInfo.id).GetValue(7).ToString();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.Visible == false)
                txtNewPassword.Visible = true;
            else
                txtNewPassword.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (grp1.Enabled == false)
            {
                grp1.Enabled = true;
                btnSave.Text = "SAVE";
            }
            else
            {
                DialogResult dr = MessageBox.Show("Do you want to Edit?", "Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    md.Account_update(AccountInfo.id, txtFirstName.Text, txtMIddleName.Text, txtLastName.Text, txtPosition.Text, txtDepartment.Text, txtUsername.Text, txtNewPassword.Text);
                    showMyAccountInfor();
                    grp1.Enabled = false;
                    btnSave.Text = "EDIT";
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            grp1.Enabled = false;
            btnSave.Text = "EDIT";
            showMyAccountInfor();
        }

        

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnCat_Click(object sender, EventArgs e)
        {
            dgv_Acct.DataSource = md.dgv_Acct(1).DataSource;
        }

        private void btnSubCat_Click(object sender, EventArgs e)
        {
            dgv_Acct.DataSource = md.dgv_Acct(2).DataSource;
        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            dgv_Acct.DataSource = md.dgv_Acct(3).DataSource;
        }

        private void btnBrand_Click(object sender, EventArgs e)
        {
            dgv_Acct.DataSource = md.dgv_Acct(4).DataSource;
        }

        private void btnModel_Click(object sender, EventArgs e)
        {
            dgv_Acct.DataSource = md.dgv_Acct(5).DataSource;
        }

        private void btnDescription_Click(object sender, EventArgs e)
        {
            dgv_Acct.DataSource = md.dgv_Acct(6).DataSource;
        }
    }
}
