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
    public partial class PR : UserControl
    {
        MyDatabase md = new MyDatabase();
        public PR()
        {
            InitializeComponent();
        }

        private void PR_Load(object sender, EventArgs e)
        {
            btnAddPR.Focus();

            showPR();
        }

        private void showPR()
        {
            dgv_PR.DataSource = md.dgv_showPR().DataSource;
            dgv_PR.Columns[0].Visible = false;
            dgv_PR.Columns[1].HeaderText = "PR No.";
            dgv_PR.Columns[2].HeaderText = "Requestor";
            dgv_PR.Columns[3].HeaderText = "Contact No.";
            dgv_PR.Columns[4].HeaderText = "Department";
            dgv_PR.Columns[5].HeaderText = "Project Name";
            dgv_PR.Columns[6].HeaderText = "Business Type";
            dgv_PR.Columns[7].HeaderText = "Requisition Date";
            dgv_PR.Columns[8].HeaderText = "Required Date";
            dgv_PR.Columns[9].HeaderText = "Cost Center";
            dgv_PR.Columns[10].HeaderText = "Purpose";
            dgv_PR.Columns[11].HeaderText = "Priority";
            dgv_PR.Columns[12].HeaderText = "Type of Supply";
            dgv_PR.Columns[13].HeaderText = "Item";
            dgv_PR.Columns[14].HeaderText = "Description";
            dgv_PR.Columns[15].HeaderText = "Category";
            dgv_PR.Columns[16].HeaderText = "QTY";
            dgv_PR.Columns[17].HeaderText = "Unit";
        }

        private void dgv_PO_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDeletePR.Enabled = true;
            btnEditPR.Enabled = true;
        }

        private void dgv_PO_Leave(object sender, EventArgs e)
        {
            btnDeletePR.Enabled = false;
            btnEditPR.Enabled = false;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAddPR_Click(object sender, EventArgs e)
        {
            frmAddPurchaseRequest addPR = new frmAddPurchaseRequest();
            addPR.Show();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            showPR();
        }

        private void dgv_PR_DoubleClick(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgv_PR.SelectedRows)
            {
                string prno = row.Cells[1].Value.ToString();
                string requestor = row.Cells[2].Value.ToString();
                string contact = row.Cells[3].Value.ToString();
                string department = row.Cells[4].Value.ToString();
                string project = row.Cells[5].Value.ToString();
                string business = row.Cells[6].Value.ToString();
                string date1 = row.Cells[7].Value.ToString();
                string date2 = row.Cells[8].Value.ToString();
                string cost = row.Cells[9].Value.ToString();
                string purpose = row.Cells[10].Value.ToString();
                string priority = row.Cells[11].Value.ToString();
                string tos = row.Cells[12].Value.ToString();
                string item = row.Cells[13].Value.ToString();
                string desc = row.Cells[14].Value.ToString();
                string category = row.Cells[15].Value.ToString();
                string qty = row.Cells[16].Value.ToString();
                string unit = row.Cells[17].Value.ToString();

                MessageBox.Show("PR No:\t\t'" + prno + "'\n Requestor:\t'" + requestor + "'\n Contact:\t\t'" + contact + "'\n Department:\t'" + department + "'\n Project Name:\t'" + project + "'\n Business Type:\t'" + business + "'\n Requisition Date:\t'" + date1 + "'\n Required Date:\t'" + date2 + "'\n Cost Center:\t'" + cost + "'\n Purpose:\t'" + purpose + "'\n Priority:\t\t'" + priority + "'\n Type of Supply:\t'" + tos + "'\n Item:\t\t'" + item + "'\n Description:\t'" + desc + "'\n category:\t'" + category + "'\n Quantity:\t'" + qty + "'\n Unit:\t\t'" + unit + "'\n "
                    , "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPR();
        }
    }
}
