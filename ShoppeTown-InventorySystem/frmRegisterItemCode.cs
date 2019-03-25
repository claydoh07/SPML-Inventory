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
    public partial class frmRegisterItemCode : MetroFramework.Forms.MetroForm
    {
        public frmRegisterItemCode()
        {
            InitializeComponent();
        }

        MyDatabase md = new MyDatabase();

        private void frmRegForm_Load(object sender, EventArgs e)
        {
            clearText(0);
            //defaultSetting();

            for (int x = 0; x < md.showCategory().Length; x++)//for listing ng mga category name
            {
                if (md.showCategory().GetValue(x).ToString() != "")
                    cboCategoryName.Items.Add(md.showCategory().GetValue(x).ToString());
            }
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void frmRegForm_Click(object sender, EventArgs e)
        {

        }

        //kel code backend
        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlRegisterItemCode.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            md.RegisterItemCode(cboCategoryName.Text, txtCode.Text, cboSubCat.Text, cboItemName.Text, cboBrand.Text, cboModel.Text, txtDescription.Text);
        }

        private void btnCreate1_Click(object sender, EventArgs e)
        {
            if (btnCreate1.Text == "Create")
            {
                pnlPopUp_Category.Visible = true;
                cboCategoryName.Visible = false;
                txtNewCode.Visible = true;
                btnCreate1.Text = "Save";
                btnCancel1.Visible = true;
                txtNewCode.Text = "";
                txtNewCode.Focus();
            }
            else
            {
                //defaultSetting();//to default registration of item code
                pnlPopUp_Category.Visible = false;

                btnCancel1.Visible = false;
                btnCreate1.Text = "Create";

                md.InsertCategory(txtCategoryName.Text, txtNewCode.Text);//inserting category
                cboCategoryName.Items.Clear();
                cboCategoryName.Visible = true;
                for (int x = 0; x < md.showCategory().Length; x++)//for listing ng mga category name
                {
                    if (md.showCategory().GetValue(x).ToString() != "")
                        cboCategoryName.Items.Add(md.showCategory().GetValue(x).ToString());
                }

                txtNewCode.Visible = false;
                cboCategoryName.Text = txtCategoryName.Text;
                txtCategoryName.Text = "";

                cboCategoryName_SelectedIndexChanged(sender, e);
                MessageBox.Show(txtCategoryName.Text + " created successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancel1_Click(object sender, EventArgs e)
        {
            pnlPopUp_Category.Visible = false;
            btnCreate1.Text = "Create";
            cboCategoryName.Visible = true;
            txtNewCode.Visible = false;
            btnCancel1.Visible = false;
        }

        private void cboCategoryName_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnCreate2.Visible = true;
            cboSubCat.Visible = true;
            cboSubCat.Items.Clear();
            lblSubcat.Visible = true;
            txtCode.Text = md.sCode(cboCategoryName.Text);
            for (int x = 0; x < md.ShowSubCategory(cboCategoryName.Text, txtCode.Text).Length; x++)//for listing ng mga category name
            {
                if (md.ShowSubCategory(cboCategoryName.Text, txtCode.Text).GetValue(x).ToString() != "")
                    cboSubCat.Items.Add(md.ShowSubCategory(cboCategoryName.Text, txtCode.Text).GetValue(x).ToString());
            }

            regItemCode.previewCode_1 = txtCode.Text;
            lblPreviewItemCode.Text = regItemCode.previewCode_1;
            clearText(1);
        }

        public void defaultSetting()
        {
            cboCategoryName.Items.Clear();
            cboSubCat.Items.Clear();
            cboItemName.Items.Clear();
            cboBrand.Items.Clear();
            cboModel.Items.Clear();
            txtDescription.Text = "";
            cboDescription.Items.Clear();

            txtNewSubCategory.Visible = false;
            txtNewItemName.Visible = false;
            txtNewBrand.Visible = false;
            txtNewModel.Visible = false;

            cboSubCat.Visible = false;
            cboItemName.Visible = false;
            cboBrand.Visible = false;
            cboModel.Visible = false;
            txtDescription.Visible = false;
            cboDescription.Visible = false;

            btnCreate2.Visible = false;
            btnCreate3.Visible = false;
            btnCreate4.Visible = false;
            btnCreate5.Visible = false;
            btnCreate6.Visible = false;

            btnCancel2.Visible = false;
            btnCancel3.Visible = false;
            btnCancel4.Visible = false;
            btnCancel5.Visible = false;
            btnCancel6.Visible = false;

            lblSubcat.Visible = false;
            lblitemname.Visible = false;
            lblBrand.Visible = false;
            lblModel.Visible = false;
            lblDescription.Visible = false;
            lblPreviewItemCode.Text = "------";
        }

        private void btnCreate2_Click(object sender, EventArgs e)
        {
            if (btnCreate2.Text == "Create")
            {
                pnlPopUp_subcategory.Visible = true;
                txtNewSubCategory.Visible = true;
                btnCreate2.Text = "Save";
                btnCancel2.Visible = true; ;
                txtNewSubCategory.Text = "";
                txtNewSubCategory.Focus();
            }
            else
            {
                pnlPopUp_subcategory.Visible = false;
                btnCreate2.Text = "Create";
                txtNewSubCategory.Visible = false;
                btnCancel2.Visible = false;
                md.InsertSubCategory(cboCategoryName.Text, txtCode.Text, txtNewSubCategory.Text);//inserting new subcategory
                cboSubCat.Items.Clear();
                for (int x = 0; x < md.ShowSubCategory(cboCategoryName.Text, txtCode.Text).Length; x++)//for listing ng mga category name
                {
                    if (md.ShowSubCategory(cboCategoryName.Text, txtCode.Text).GetValue(x).ToString() != "")
                        cboSubCat.Items.Add(md.ShowSubCategory(cboCategoryName.Text, txtCode.Text).GetValue(x).ToString());
                }
                cboSubCat_SelectedIndexChanged(sender, e);
                cboSubCat.Text = txtNewSubCategory.Text;
                MessageBox.Show(txtNewSubCategory.Text + " created successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancel2_Click(object sender, EventArgs e)
        {
            pnlPopUp_subcategory.Visible = false;
            btnCancel2.Visible = false;
            btnCreate2.Text = "Create";
            txtNewSubCategory.Visible = false;
        }

        private void cboSubCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnCreate3.Visible = true;
            cboItemName.Visible = true;
            cboItemName.Items.Clear();
            lblitemname.Visible = true;
            for (int x = 0; x < md.ShowItems(cboCategoryName.Text, txtCode.Text, cboSubCat.Text).Length; x++)//for listing ng mga item name
            {
                if (md.ShowItems(cboCategoryName.Text, txtCode.Text, cboSubCat.Text).GetValue(x).ToString() != "")
                    cboItemName.Items.Add(md.ShowItems(cboCategoryName.Text, txtCode.Text, cboSubCat.Text).GetValue(x).ToString());
            }

            regItemCode.previewCode_2 = md.sSubCat(cboCategoryName.Text, txtCode.Text, cboSubCat.Text);
            txt_2.Text = regItemCode.previewCode_2;
            lblPreviewItemCode.Text = regItemCode.previewCode_1 + regItemCode.previewCode_2;
            clearText(2);
        }

        private void btnCreate3_Click(object sender, EventArgs e)
        {
            if (btnCreate3.Text == "Create")
            {
                pnlPopUp_itemName.Visible = true;
                txtNewItemName.Visible = true;
                btnCreate3.Text = "Save";
                btnCancel3.Visible = true;
                txtNewItemName.Text = "";
                txtNewItemName.Focus();
            }
            else
            {
                pnlPopUp_itemName.Visible = false;
                btnCreate3.Text = "Create";
                txtNewItemName.Visible = false;
                btnCancel3.Visible = false;
                md.InsertItemName(cboCategoryName.Text, txtCode.Text, cboSubCat.Text, txtNewItemName.Text);//inserting new ITEMNAME
                cboItemName.Items.Clear();
                for (int x = 0; x < md.ShowItems(cboCategoryName.Text, txtCode.Text, cboSubCat.Text).Length; x++)//for listing ng mga ITEM name
                {
                    if (md.ShowItems(cboCategoryName.Text, txtCode.Text, cboSubCat.Text).GetValue(x).ToString() != "")
                        cboItemName.Items.Add(md.ShowItems(cboCategoryName.Text, txtCode.Text, cboSubCat.Text).GetValue(x).ToString());
                }

                md.InsertBrand(cboCategoryName.Text, txtCode.Text, cboSubCat.Text, txtNewItemName.Text, "N/A");//inserting new brand generic
                cboItemName_SelectedIndexChanged(sender, e);
                cboItemName.Text = txtNewItemName.Text;

                md.InsertModel(cboCategoryName.Text, txtCode.Text, cboSubCat.Text, cboItemName.Text, "N/A", "N/A");//inserting new model
                md.InsertDescription(cboCategoryName.Text, txtCode.Text, cboSubCat.Text, cboItemName.Text, "N/A", "N/A", "N/A");//inserting new description
                MessageBox.Show(txtNewItemName.Text + " created successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancel3_Click(object sender, EventArgs e)
        {
            pnlPopUp_itemName.Visible = false;
            btnCancel3.Visible = false;
            btnCreate3.Text = "Create";
            txtNewItemName.Visible = false;
        }

        private void cboItemName_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnCreate4.Visible = true;
            cboBrand.Visible = true;
            cboBrand.Items.Clear();
            lblBrand.Visible = true;
            for (int x = 0; x < md.ShowBrand(cboCategoryName.Text, txtCode.Text, cboSubCat.Text, cboItemName.Text).Length; x++)//for listing ng mga item name
            {
                if (md.ShowBrand(cboCategoryName.Text, txtCode.Text, cboSubCat.Text, cboItemName.Text).GetValue(x).ToString() != "")
                    cboBrand.Items.Add(md.ShowBrand(cboCategoryName.Text, txtCode.Text, cboSubCat.Text, cboItemName.Text).GetValue(x).ToString());
            }

            regItemCode.previewCode_3 = md.sItem(cboCategoryName.Text, txtCode.Text, cboSubCat.Text, cboItemName.Text);
            txt_3.Text = regItemCode.previewCode_3;
            lblPreviewItemCode.Text = regItemCode.previewCode_1 + regItemCode.previewCode_2 + regItemCode.previewCode_3;
            clearText(3);
        }

        private void btnCreate4_Click(object sender, EventArgs e)
        {
            if (btnCreate4.Text == "Create")
            {
                pnlPopUp_brand.Visible = true;
                txtNewBrand.Visible = true;
                btnCreate4.Text = "Save";
                btnCancel4.Visible = true;
                txtNewBrand.Text = "";
                txtNewBrand.Focus();
            }
            else
            {
                pnlPopUp_brand.Visible = false;
                btnCreate4.Text = "Create";
                txtNewBrand.Visible = false;
                btnCancel4.Visible = false;
                md.InsertBrand(cboCategoryName.Text, txtCode.Text, cboSubCat.Text, cboItemName.Text, txtNewBrand.Text);//inserting new brand
                cboBrand.Items.Clear();
                for (int x = 0; x < md.ShowBrand(cboCategoryName.Text, txtCode.Text, cboSubCat.Text, cboItemName.Text).Length; x++)//for listing ng mga brand name
                {
                    if (md.ShowBrand(cboCategoryName.Text, txtCode.Text, cboSubCat.Text, cboItemName.Text).GetValue(x).ToString() != "")
                        cboBrand.Items.Add(md.ShowBrand(cboCategoryName.Text, txtCode.Text, cboSubCat.Text, cboItemName.Text).GetValue(x).ToString());
                }
                md.InsertModel(cboCategoryName.Text, txtCode.Text, cboSubCat.Text, cboItemName.Text, txtNewBrand.Text, "N/A");//inserting new model
                md.InsertDescription(cboCategoryName.Text, txtCode.Text, cboSubCat.Text, cboItemName.Text, txtNewBrand.Text, "N/A", "N/A");//inserting new description
                cboBrand_SelectedIndexChanged(sender, e);
                cboBrand.Text = txtNewBrand.Text;

                
                MessageBox.Show(txtNewItemName.Text + " created successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cboBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnCreate5.Visible = true;
            cboModel.Visible = true;
            cboModel.Items.Clear();
            lblModel.Visible = true;
            for (int x = 0; x < md.ShowModel(cboCategoryName.Text, txtCode.Text, cboSubCat.Text, cboItemName.Text, cboBrand.Text).Length; x++)//for listing ng mga item name
            {
                if (md.ShowModel(cboCategoryName.Text, txtCode.Text, cboSubCat.Text, cboItemName.Text, cboBrand.Text).GetValue(x).ToString() != "")
                    cboModel.Items.Add(md.ShowModel(cboCategoryName.Text, txtCode.Text, cboSubCat.Text, cboItemName.Text, cboBrand.Text).GetValue(x).ToString());
            }

            regItemCode.previewCode_4 = md.sBrand(cboCategoryName.Text, txtCode.Text, cboSubCat.Text, cboItemName.Text, cboBrand.Text);
            txt_4.Text = regItemCode.previewCode_4;
            lblPreviewItemCode.Text = regItemCode.previewCode_1 + regItemCode.previewCode_2 + regItemCode.previewCode_3 + regItemCode.previewCode_4;
            clearText(4);
        }

        private void btnCancel4_Click(object sender, EventArgs e)
        {
            pnlPopUp_brand.Visible = false;
            btnCancel4.Visible = false;
            btnCreate4.Text = "Create";
            txtNewBrand.Visible = false;
        }

        private void btnCreate5_Click(object sender, EventArgs e)
        {
            if (btnCreate5.Text == "Create")
            {
                pnlPopUp_model.Visible = true;
                txtNewModel.Visible = true;
                btnCreate5.Text = "Save";
                btnCancel5.Visible = true;
                txtNewModel.Text = "";
                txtNewModel.Focus();
            }
            else
            {
                pnlPopUp_model.Visible = false;
                btnCreate5.Text = "Create";
                txtNewModel.Visible = false;
                btnCancel5.Visible = false;
                md.InsertModel(cboCategoryName.Text, txtCode.Text, cboSubCat.Text, cboItemName.Text, cboBrand.Text, txtNewModel.Text);//inserting new model
                cboModel.Items.Clear();
                for (int x = 0; x < md.ShowModel(cboCategoryName.Text, txtCode.Text, cboSubCat.Text, cboItemName.Text, cboBrand.Text).Length; x++)//for listing ng mga model name
                {
                    if (md.ShowModel(cboCategoryName.Text, txtCode.Text, cboSubCat.Text, cboItemName.Text, cboBrand.Text).GetValue(x).ToString() != "")
                        cboModel.Items.Add(md.ShowModel(cboCategoryName.Text, txtCode.Text, cboSubCat.Text, cboItemName.Text, cboBrand.Text).GetValue(x).ToString());
                }
                md.InsertDescription(cboCategoryName.Text, txtCode.Text, cboSubCat.Text, cboItemName.Text, cboBrand.Text, txtNewModel.Text, "N/A");//inserting new description

                cboModel_SelectedIndexChanged(sender, e);
                cboModel.Text = txtNewModel.Text;
                MessageBox.Show(txtNewModel.Text + " created successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancel5_Click(object sender, EventArgs e)
        {
            pnlPopUp_model.Visible = false;
            btnCancel5.Visible = false;
            btnCreate5.Text = "Create";
            txtNewModel.Visible = false;
        }

        private void cboModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnCreate6.Visible = true;
            cboDescription.Visible = true;
            cboDescription.Items.Clear();
            lblDescription.Visible = true;
            txtDescription.Visible = true;
            for (int x = 0; x < md.ShowDescription(cboCategoryName.Text, txtCode.Text, cboSubCat.Text, cboItemName.Text, cboBrand.Text, cboModel.Text).Length; x++)//for listing ng mga descriptions
            {
                if (md.ShowDescription(cboCategoryName.Text, txtCode.Text, cboSubCat.Text, cboItemName.Text, cboBrand.Text, cboModel.Text).GetValue(x).ToString() != "")
                    cboDescription.Items.Add(md.ShowDescription(cboCategoryName.Text, txtCode.Text, cboSubCat.Text, cboItemName.Text, cboBrand.Text, cboModel.Text).GetValue(x).ToString());
            }

            regItemCode.previewCode_5 = md.sModel(cboCategoryName.Text, txtCode.Text, cboSubCat.Text, cboItemName.Text, cboBrand.Text, cboModel.Text);
            txt_5.Text = regItemCode.previewCode_5;
            lblPreviewItemCode.Text = regItemCode.previewCode_1 + regItemCode.previewCode_2 + regItemCode.previewCode_3 + regItemCode.previewCode_4 + regItemCode.previewCode_5;
            clearText(5);
        }

        private void cboDescription_SelectedIndexChanged(object sender, EventArgs e)
        {
            //btnCreate6.Visible = true;
            //cboDescription.Visible = true;
            //cboDescription.Items.Clear();
            //lblDescription.Visible = true;
            //txtDescription.Visible = true;
            //for (int x = 0; x < md.ShowDescription(cboCategoryName.Text, txtCode.Text, cboSubCat.Text, cboItemName.Text, cboBrand.Text, cboModel.Text).Length; x++)//for listing ng mga descriptions
            //{
            //    if (md.ShowDescription(cboCategoryName.Text, txtCode.Text, cboSubCat.Text, cboItemName.Text, cboBrand.Text, cboModel.Text).GetValue(x).ToString() != "")
            //        cboDescription.Items.Add(md.ShowDescription(cboCategoryName.Text, txtCode.Text, cboSubCat.Text, cboItemName.Text, cboBrand.Text, cboModel.Text).GetValue(x).ToString());
            //}

            regItemCode.previewCode_6 = md.sDescription(cboCategoryName.Text, txtCode.Text, cboSubCat.Text, cboItemName.Text, cboBrand.Text, cboModel.Text, cboDescription.Text);
            txt_6.Text = regItemCode.previewCode_6;
            lblPreviewItemCode.Text = regItemCode.previewCode_1 + regItemCode.previewCode_2 + regItemCode.previewCode_3 + regItemCode.previewCode_4 + regItemCode.previewCode_5 + regItemCode.previewCode_6;
            txtDescription.Text = cboDescription.Text;
            txtDesc.Text = cboDescription.Text;
        }

        private void btnCreate6_Click(object sender, EventArgs e)
        {
            if (btnCreate6.Text == "Create")
            {
                pnlPopUp_description.Visible = true;
                txtDescription.Enabled = true;
                btnCreate6.Text = "Save";
                btnCancel6.Visible = true;
                txtDescription.Text = "";
                txtDescription.Focus();
            }
            else
            {
                pnlPopUp_description.Visible = false;
                btnCreate6.Text = "Create";
                txtDescription.Enabled = false;
                btnCancel6.Visible = false;
                md.InsertDescription(cboCategoryName.Text, txtCode.Text, cboSubCat.Text, cboItemName.Text, cboBrand.Text, cboModel.Text, txtDescription.Text);//inserting new description
                cboDescription.Items.Clear();
                for (int x = 0; x < md.ShowDescription(cboCategoryName.Text, txtCode.Text, cboSubCat.Text, cboItemName.Text, cboBrand.Text, cboModel.Text).Length; x++)//for listing ng mga model name
                {
                    if (md.ShowDescription(cboCategoryName.Text, txtCode.Text, cboSubCat.Text, cboItemName.Text, cboBrand.Text, cboModel.Text).GetValue(x).ToString() != "")
                        cboDescription.Items.Add(md.ShowDescription(cboCategoryName.Text, txtCode.Text, cboSubCat.Text, cboItemName.Text, cboBrand.Text, cboModel.Text).GetValue(x).ToString());
                }
                //cboModel_SelectedIndexChanged(sender, e);
                cboDescription.Text = txtDescription.Text;
                MessageBox.Show(txtDescription.Text + " created successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancel6_Click(object sender, EventArgs e)
        {
            pnlPopUp_description.Visible = false;
            btnCancel6.Visible = false;
            btnCreate6.Text = "Create";
            txtDescription.Enabled = false;
        }

        private void clearText(int num)
        {
            if (num == 0)//default
            {
                lblPreviewItemCode.Text = "";
                txtNewCode.Text = "";
                txtCategoryName.Text = "";
                txtNewSubCategory.Text = "";
                txtNewItemName.Text = "";
                txtNewBrand.Text = "";
                txtNewModel.Text = "";
                txtDescription.Text = "";
                txtDesc.Text = "";

                txtCode.Text = "";
                txt_2.Text = "";
                txt_3.Text = "";
                txt_4.Text = "";
                txt_5.Text = "";
                txt_6.Text = "";

                cboCategoryName.Items.Clear();
                cboSubCat.Items.Clear();
                cboItemName.Items.Clear();
                cboBrand.Items.Clear();
                cboModel.Items.Clear();
                cboDescription.Items.Clear();

                cboSubCat.Enabled = false;
                cboItemName.Enabled = false;
                cboBrand.Enabled = false;
                cboModel.Enabled = false;
                cboDescription.Enabled = false;

                btnCreate2.Enabled = false;
                btnCreate3.Enabled = false;
                btnCreate4.Enabled = false;
                btnCreate5.Enabled = false;
                btnCreate6.Enabled = false;
            }
            else if (num == 1)//category
            {
                txtNewSubCategory.Text = "";
                txtNewItemName.Text = "";
                txtNewBrand.Text = "";
                txtNewModel.Text = "";
                txtDescription.Text = "";
                txtDesc.Text = "";

                txt_2.Text = "";
                txt_3.Text = "";
                txt_4.Text = "";
                txt_5.Text = "";
                txt_6.Text = "";

                cboItemName.Items.Clear();
                cboBrand.Items.Clear();
                cboModel.Items.Clear();
                cboDescription.Items.Clear();

                cboSubCat.Enabled = true;
                cboItemName.Enabled = false;
                cboBrand.Enabled = false;
                cboModel.Enabled = false;
                cboDescription.Enabled = false;

                btnCreate2.Enabled = true;
                btnCreate3.Enabled = false;
                btnCreate4.Enabled = false;
                btnCreate5.Enabled = false;
                btnCreate6.Enabled = false;
            }
            else if (num == 2)//sub
            {
                txtNewItemName.Text = "";
                txtNewBrand.Text = "";
                txtNewModel.Text = "";
                txtDescription.Text = "";
                txtDesc.Text = "";

                txt_3.Text = "";
                txt_4.Text = "";
                txt_5.Text = "";
                txt_6.Text = "";

                cboBrand.Items.Clear();
                cboModel.Items.Clear();
                cboDescription.Items.Clear();

                cboSubCat.Enabled = true;
                cboItemName.Enabled = true;
                cboBrand.Enabled = false;
                cboModel.Enabled = false;
                cboDescription.Enabled = false;

                btnCreate2.Enabled = true;
                btnCreate3.Enabled = true;
                btnCreate4.Enabled = false;
                btnCreate5.Enabled = false;
                btnCreate6.Enabled = false;
            }
            else if (num == 3)//item
            {
                txtNewBrand.Text = "";
                txtNewModel.Text = "";
                txtDescription.Text = "";
                txtDesc.Text = "";

                txt_4.Text = "";
                txt_5.Text = "";
                txt_6.Text = "";

                cboModel.Items.Clear();
                cboDescription.Items.Clear();

                cboSubCat.Enabled = true;
                cboItemName.Enabled = true;
                cboBrand.Enabled = true;
                cboModel.Enabled = false;
                cboDescription.Enabled = false;

                btnCreate2.Enabled = true;
                btnCreate3.Enabled = true;
                btnCreate4.Enabled = true;
                btnCreate5.Enabled = false;
                btnCreate6.Enabled = false;
            }
            else if (num == 4)//brand
            {
                txtNewModel.Text = "";
                txtDescription.Text = "";
                txtDesc.Text = "";

                txt_5.Text = "";
                txt_6.Text = "";

                cboDescription.Items.Clear();

                cboSubCat.Enabled = true;
                cboItemName.Enabled = true;
                cboBrand.Enabled = true;
                cboModel.Enabled = true;
                cboDescription.Enabled = false;

                btnCreate2.Enabled = true;
                btnCreate3.Enabled = true;
                btnCreate4.Enabled = true;
                btnCreate5.Enabled = true;
                btnCreate6.Enabled = false;
            }
            else if (num == 5)//model
            {
                txtDescription.Text = "";
                txtDesc.Text = "";

                txt_6.Text = "";

                cboSubCat.Enabled = true;
                cboItemName.Enabled = true;
                cboBrand.Enabled = true;
                cboModel.Enabled = true;
                cboDescription.Enabled = true;

                btnCreate2.Enabled = true;
                btnCreate3.Enabled = true;
                btnCreate4.Enabled = true;
                btnCreate5.Enabled = true;
                btnCreate6.Enabled = true;
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSave_1_Click(object sender, EventArgs e)
        {
            btnCreate1_Click(sender, e);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_2_Click(object sender, EventArgs e)
        {
            btnCreate2_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSave_3_Click(object sender, EventArgs e)
        {
            btnCreate3_Click(sender, e);
        }

        private void btnSave_4_Click(object sender, EventArgs e)
        {
            btnCreate4_Click(sender, e);
        }

        private void btnSave_5_Click(object sender, EventArgs e)
        {
            btnCreate5_Click(sender, e);
        }

        private void btnSave_6_Click(object sender, EventArgs e)
        {
            btnCreate6_Click(sender, e);
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            md.RegisterItemCode(lblPreviewItemCode.Text, cboCategoryName.Text, cboSubCat.Text, cboItemName.Text, cboBrand.Text, cboModel.Text, cboDescription.Text);
            MessageBox.Show(lblPreviewItemCode.Text + " created successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }

        private void pnlRegisterItemCode_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmRegisterItemCode_KeyDown(object sender, KeyEventArgs e)
        {
            // If Escape, quit application.  
            if (e.KeyCode == System.Windows.Forms.Keys.Escape)
            {
                // Call quit method.  
                btnCancel_Click_1(sender, e);
            } 
        }

        
    }
}
