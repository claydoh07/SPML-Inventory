using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppeTown_InventorySystem
{
    public partial class Account : UserControl
    {
        public Account()
        {
            InitializeComponent();
        }

        MyDatabase md = new MyDatabase();
        private void Account_Load(object sender, EventArgs e)
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

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUserType_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
