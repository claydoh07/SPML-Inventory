using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShoppeTown_InventorySystem.Properties;
using MySql.Data.MySqlClient;

namespace ShoppeTown_InventorySystem
{
    public partial class frmAdminDashboard : MetroFramework.Forms.MetroForm
    {
        MyDatabase md = new MyDatabase();
      
        string button;

        public frmAdminDashboard()
        {
            InitializeComponent();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            //MainControls.Dashboard dash = new MainControls.Dashboard();
            //pnlAdminBoard.Controls.Add(dash);
            dashboard1.Visible = true;
            lblDate.Text = "Date: " + DateTime.Now.ToString("MM/dd/yyyy");
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            button = "1";
            getBackColor(button);

            //pnlAdminBoard.Controls.Clear();
            //MainControls.Dashboard dash = new MainControls.Dashboard();
            //pnlAdminBoard.Controls.Add(dash);
            clearControls();
            dashboard1.Visible = true;
            
        }

        private void btnPurchaseRequest_Click(object sender, EventArgs e)
        {
            button = "2";
            getBackColor(button);

            clearControls();
            pr1.Visible = true;
            //pnlAdminBoard.Controls.Clear();
            //MainControls.PR pr = new MainControls.PR();
            //pnlAdminBoard.Controls.Add(pr);
        }

        private void btnPurchaseOrder_Click(object sender, EventArgs e)
        {
            button = "3";
            getBackColor(button);

            clearControls();
            po1.Visible = true;
            //pnlAdminBoard.Controls.Clear();
            //MainControls.PO po = new MainControls.PO();
            //pnlAdminBoard.Controls.Add(po);

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                frmLogin login = new frmLogin();
                this.Hide();
                login.Show();
            }
        }

        private void btnDelivery_Click(object sender, EventArgs e)
        {
            button = "4";
            getBackColor(button);

            clearControls();
            delivery1.Visible = true;
            //pnlAdminBoard.Controls.Clear();
            //MainControls.Delivery deliv = new MainControls.Delivery();
            //pnlAdminBoard.Controls.Add(deliv);
        }

        private void btnFASM_Click(object sender, EventArgs e)
        {
            button = "5";
            getBackColor(button);

            clearControls();
            fasm1.Visible = true;
            //pnlAdminBoard.Controls.Clear();
            //MainControls.FASM fasm = new MainControls.FASM();
            //pnlAdminBoard.Controls.Add(fasm);
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            button = "6";
            getBackColor(button);

            clearControls();
            registration1.Visible = true;
            //pnlAdminBoard.Controls.Clear();
            //MainControls.Registration rg = new MainControls.Registration();
            //pnlAdminBoard.Controls.Add(rg);
        }

        public void getBackColor(string click)
        {
            if (click == "1")
            {
                btnDashboard.Normalcolor = Color.FromArgb(96,169,23);
                btnPurchaseRequest.Normalcolor = Color.FromArgb(21, 32, 40);
                btnPurchaseOrder.Normalcolor = Color.FromArgb(21, 32, 40);
                btnDelivery.Normalcolor = Color.FromArgb(21, 32, 40);
                btnFASM.Normalcolor = Color.FromArgb(21, 32, 40);
                btnRegistration.Normalcolor = Color.FromArgb(21, 32, 40);
                btnVendors.Normalcolor = Color.FromArgb(21, 32, 40);
                btnLogout.Normalcolor = Color.FromArgb(21, 32, 40);
                btnAccount.Normalcolor = Color.FromArgb(21, 32, 40);
            }
            else if (click == "2")
            {
                btnDashboard.Normalcolor = Color.FromArgb(21, 32, 40);
                btnPurchaseRequest.Normalcolor = Color.FromArgb(96,169,23);
                btnPurchaseOrder.Normalcolor = Color.FromArgb(21, 32, 40);
                btnDelivery.Normalcolor = Color.FromArgb(21, 32, 40);
                btnFASM.Normalcolor = Color.FromArgb(21, 32, 40);
                btnRegistration.Normalcolor = Color.FromArgb(21, 32, 40);
                btnVendors.Normalcolor = Color.FromArgb(21, 32, 40);
                btnLogout.Normalcolor = Color.FromArgb(21, 32, 40);
                btnAccount.Normalcolor = Color.FromArgb(21, 32, 40);
            }
            else if (click == "3")
            {
                btnDashboard.Normalcolor = Color.FromArgb(21, 32, 40);
                btnPurchaseRequest.Normalcolor = Color.FromArgb(21, 32, 40);
                btnPurchaseOrder.Normalcolor = Color.FromArgb(96,169,23);
                btnDelivery.Normalcolor = Color.FromArgb(21, 32, 40);
                btnFASM.Normalcolor = Color.FromArgb(21, 32, 40);
                btnRegistration.Normalcolor = Color.FromArgb(21, 32, 40);
                btnVendors.Normalcolor = Color.FromArgb(21, 32, 40);
                btnLogout.Normalcolor = Color.FromArgb(21, 32, 40);
                btnAccount.Normalcolor = Color.FromArgb(21, 32, 40);
            }
            else if (click == "4")
            {
                btnDashboard.Normalcolor = Color.FromArgb(21, 32, 40);
                btnPurchaseRequest.Normalcolor = Color.FromArgb(21, 32, 40);
                btnPurchaseOrder.Normalcolor = Color.FromArgb(21, 32, 40);
                btnDelivery.Normalcolor = Color.FromArgb(96,169,23);
                btnFASM.Normalcolor = Color.FromArgb(21, 32, 40);
                btnRegistration.Normalcolor = Color.FromArgb(21, 32, 40);
                btnVendors.Normalcolor = Color.FromArgb(21, 32, 40);
                btnLogout.Normalcolor = Color.FromArgb(21, 32, 40);
                btnAccount.Normalcolor = Color.FromArgb(21, 32, 40);
            }
            else if (click == "5")
            {
                btnDashboard.Normalcolor = Color.FromArgb(21, 32, 40);
                btnPurchaseRequest.Normalcolor = Color.FromArgb(21, 32, 40);
                btnPurchaseOrder.Normalcolor = Color.FromArgb(21, 32, 40);
                btnDelivery.Normalcolor = Color.FromArgb(21, 32, 40);
                btnFASM.Normalcolor = Color.FromArgb(96,169,23);
                btnRegistration.Normalcolor = Color.FromArgb(21, 32, 40);
                btnVendors.Normalcolor = Color.FromArgb(21, 32, 40);
                btnLogout.Normalcolor = Color.FromArgb(21, 32, 40);
                btnAccount.Normalcolor = Color.FromArgb(21, 32, 40);
            }
            else if (click == "6")
            {
                btnDashboard.Normalcolor = Color.FromArgb(21, 32, 40);
                btnPurchaseRequest.Normalcolor = Color.FromArgb(21, 32, 40);
                btnPurchaseOrder.Normalcolor = Color.FromArgb(21, 32, 40);
                btnDelivery.Normalcolor = Color.FromArgb(21, 32, 40);
                btnFASM.Normalcolor = Color.FromArgb(21, 32, 40);
                btnRegistration.Normalcolor = Color.FromArgb(96,169,23);
                btnVendors.Normalcolor = Color.FromArgb(21, 32, 40);
                btnLogout.Normalcolor = Color.FromArgb(21, 32, 40);
                btnAccount.Normalcolor = Color.FromArgb(21, 32, 40);
            }
            else if (click == "7")
            {
                btnDashboard.Normalcolor = Color.FromArgb(21, 32, 40);
                btnPurchaseRequest.Normalcolor = Color.FromArgb(21, 32, 40);
                btnPurchaseOrder.Normalcolor = Color.FromArgb(21, 32, 40);
                btnDelivery.Normalcolor = Color.FromArgb(21, 32, 40);
                btnFASM.Normalcolor = Color.FromArgb(21, 32, 40);
                btnRegistration.Normalcolor = Color.FromArgb(21, 32, 40);
                btnVendors.Normalcolor = Color.FromArgb(96,169,23);
                btnLogout.Normalcolor = Color.FromArgb(21, 32, 40);
                btnAccount.Normalcolor = Color.FromArgb(21, 32, 40);
            }
            else if (click == "8")
            {
                btnDashboard.Normalcolor = Color.FromArgb(21, 32, 40);
                btnPurchaseRequest.Normalcolor = Color.FromArgb(21, 32, 40);
                btnPurchaseOrder.Normalcolor = Color.FromArgb(21, 32, 40);
                btnDelivery.Normalcolor = Color.FromArgb(21, 32, 40);
                btnFASM.Normalcolor = Color.FromArgb(21, 32, 40);
                btnRegistration.Normalcolor = Color.FromArgb(21, 32, 40);
                btnVendors.Normalcolor = Color.FromArgb(21, 32, 40);
                btnLogout.Normalcolor = Color.FromArgb(21, 32, 40);
                btnAccount.Normalcolor = Color.FromArgb(96, 169, 23);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlAdminBoard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVendors_Click(object sender, EventArgs e)
        {
            button = "7";
            getBackColor(button);

            clearControls();
            vendors1.Visible = true;
            //pnlAdminBoard.Controls.Clear();
            //MainControls.Vendors v = new MainControls.Vendors();
            //pnlAdminBoard.Controls.Add(v);
        }

        private void clearControls()
        {
            registration1.Visible = false;
            dashboard1.Visible = false;
            vendors1.Visible = false;
            pr1.Visible = false;
            po1.Visible = false;
            delivery1.Visible = false;
            fasm1.Visible = false;
            acct1.Visible = false;
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            button = "8";
            getBackColor(button);

            clearControls();
            acct1.Visible = true;
            //pnlAdminBoard.Controls.Clear();
            //MainControls.Vendors v = new MainControls.Vendors();
            //pnlAdminBoard.Controls.Add(v);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.CenterToScreen();
            }
            else
                this.WindowState = FormWindowState.Maximized;
        }
    }
}
