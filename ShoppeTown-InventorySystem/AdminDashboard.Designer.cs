namespace ShoppeTown_InventorySystem
{
    partial class frmAdminDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminDashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMaximize = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMinimize = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlDtp = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnDashboard = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPurchaseOrder = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnFASM = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnRegistration = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnVendors = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnLogout = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPurchaseRequest = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnDelivery = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAccount = new Bunifu.Framework.UI.BunifuFlatButton();
            this.fasm1 = new ShoppeTown_InventorySystem.MainControls.FASM();
            this.vendors1 = new ShoppeTown_InventorySystem.MainControls.Vendors();
            this.dashboard1 = new ShoppeTown_InventorySystem.MainControls.Dashboard();
            this.registration1 = new ShoppeTown_InventorySystem.MainControls.Registration();
            this.delivery1 = new ShoppeTown_InventorySystem.MainControls.Delivery();
            this.po1 = new ShoppeTown_InventorySystem.MainControls.PO();
            this.pr1 = new ShoppeTown_InventorySystem.MainControls.PR();
            this.acct1 = new ShoppeTown_InventorySystem.MainControls.Acct();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlDtp.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(30)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnMaximize);
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1226, 56);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(197)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(63, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(499, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "UNITED AGRIMALL CORPORATION";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnMaximize
            // 
            this.btnMaximize.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(169)))), ((int)(((byte)(23)))));
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(30)))), ((int)(((byte)(49)))));
            this.btnMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMaximize.BorderRadius = 0;
            this.btnMaximize.ButtonText = "";
            this.btnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximize.DisabledColor = System.Drawing.Color.Gray;
            this.btnMaximize.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximize.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMaximize.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnMaximize.Iconimage")));
            this.btnMaximize.Iconimage_right = null;
            this.btnMaximize.Iconimage_right_Selected = null;
            this.btnMaximize.Iconimage_Selected = null;
            this.btnMaximize.IconMarginLeft = 0;
            this.btnMaximize.IconMarginRight = 0;
            this.btnMaximize.IconRightVisible = true;
            this.btnMaximize.IconRightZoom = 0D;
            this.btnMaximize.IconVisible = true;
            this.btnMaximize.IconZoom = 50D;
            this.btnMaximize.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnMaximize.IsTab = false;
            this.btnMaximize.Location = new System.Drawing.Point(1192, -7);
            this.btnMaximize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(30)))), ((int)(((byte)(49)))));
            this.btnMaximize.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.btnMaximize.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMaximize.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnMaximize.selected = false;
            this.btnMaximize.Size = new System.Drawing.Size(38, 36);
            this.btnMaximize.TabIndex = 3;
            this.btnMaximize.TabStop = false;
            this.btnMaximize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMaximize.Textcolor = System.Drawing.Color.White;
            this.btnMaximize.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(169)))), ((int)(((byte)(23)))));
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(30)))), ((int)(((byte)(49)))));
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimize.BorderRadius = 0;
            this.btnMinimize.ButtonText = "";
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.DisabledColor = System.Drawing.Color.Gray;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMinimize.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Iconimage")));
            this.btnMinimize.Iconimage_right = null;
            this.btnMinimize.Iconimage_right_Selected = null;
            this.btnMinimize.Iconimage_Selected = null;
            this.btnMinimize.IconMarginLeft = 0;
            this.btnMinimize.IconMarginRight = 0;
            this.btnMinimize.IconRightVisible = true;
            this.btnMinimize.IconRightZoom = 0D;
            this.btnMinimize.IconVisible = true;
            this.btnMinimize.IconZoom = 50D;
            this.btnMinimize.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnMinimize.IsTab = false;
            this.btnMinimize.Location = new System.Drawing.Point(1157, -7);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(30)))), ((int)(((byte)(49)))));
            this.btnMinimize.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.btnMinimize.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMinimize.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnMinimize.selected = false;
            this.btnMinimize.Size = new System.Drawing.Size(38, 36);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMinimize.Textcolor = System.Drawing.Color.White;
            this.btnMinimize.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // pnlDtp
            // 
            this.pnlDtp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDtp.BackColor = System.Drawing.Color.Silver;
            this.pnlDtp.Controls.Add(this.lblDate);
            this.pnlDtp.Location = new System.Drawing.Point(181, 675);
            this.pnlDtp.Name = "pnlDtp";
            this.pnlDtp.Size = new System.Drawing.Size(1045, 27);
            this.pnlDtp.TabIndex = 6;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.DimGray;
            this.lblDate.Location = new System.Drawing.Point(3, 7);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(96, 17);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Date: 01/09/19";
            // 
            // btnDashboard
            // 
            this.btnDashboard.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(169)))), ((int)(((byte)(23)))));
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDashboard.BorderRadius = 0;
            this.btnDashboard.ButtonText = "DASHBOARD";
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.DisabledColor = System.Drawing.Color.Gray;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDashboard.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Iconimage")));
            this.btnDashboard.Iconimage_right = null;
            this.btnDashboard.Iconimage_right_Selected = null;
            this.btnDashboard.Iconimage_Selected = null;
            this.btnDashboard.IconMarginLeft = 0;
            this.btnDashboard.IconMarginRight = 0;
            this.btnDashboard.IconRightVisible = true;
            this.btnDashboard.IconRightZoom = 0D;
            this.btnDashboard.IconVisible = true;
            this.btnDashboard.IconZoom = 50D;
            this.btnDashboard.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDashboard.IsTab = false;
            this.btnDashboard.Location = new System.Drawing.Point(0, 1);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnDashboard.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.btnDashboard.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDashboard.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnDashboard.selected = false;
            this.btnDashboard.Size = new System.Drawing.Size(182, 48);
            this.btnDashboard.TabIndex = 3;
            this.btnDashboard.TabStop = false;
            this.btnDashboard.Text = "DASHBOARD";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDashboard.Textcolor = System.Drawing.Color.White;
            this.btnDashboard.TextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnPurchaseOrder
            // 
            this.btnPurchaseOrder.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(169)))), ((int)(((byte)(23)))));
            this.btnPurchaseOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnPurchaseOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPurchaseOrder.BorderRadius = 0;
            this.btnPurchaseOrder.ButtonText = "PURCHASE ORDER";
            this.btnPurchaseOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPurchaseOrder.DisabledColor = System.Drawing.Color.Gray;
            this.btnPurchaseOrder.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchaseOrder.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPurchaseOrder.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPurchaseOrder.Iconimage")));
            this.btnPurchaseOrder.Iconimage_right = null;
            this.btnPurchaseOrder.Iconimage_right_Selected = null;
            this.btnPurchaseOrder.Iconimage_Selected = null;
            this.btnPurchaseOrder.IconMarginLeft = 0;
            this.btnPurchaseOrder.IconMarginRight = 0;
            this.btnPurchaseOrder.IconRightVisible = true;
            this.btnPurchaseOrder.IconRightZoom = 0D;
            this.btnPurchaseOrder.IconVisible = true;
            this.btnPurchaseOrder.IconZoom = 50D;
            this.btnPurchaseOrder.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPurchaseOrder.IsTab = false;
            this.btnPurchaseOrder.Location = new System.Drawing.Point(0, 193);
            this.btnPurchaseOrder.Name = "btnPurchaseOrder";
            this.btnPurchaseOrder.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnPurchaseOrder.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.btnPurchaseOrder.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPurchaseOrder.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnPurchaseOrder.selected = false;
            this.btnPurchaseOrder.Size = new System.Drawing.Size(182, 48);
            this.btnPurchaseOrder.TabIndex = 3;
            this.btnPurchaseOrder.TabStop = false;
            this.btnPurchaseOrder.Text = "PURCHASE ORDER";
            this.btnPurchaseOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPurchaseOrder.Textcolor = System.Drawing.Color.White;
            this.btnPurchaseOrder.TextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchaseOrder.Click += new System.EventHandler(this.btnPurchaseOrder_Click);
            // 
            // btnFASM
            // 
            this.btnFASM.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(169)))), ((int)(((byte)(23)))));
            this.btnFASM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnFASM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFASM.BorderRadius = 0;
            this.btnFASM.ButtonText = "FASM";
            this.btnFASM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFASM.DisabledColor = System.Drawing.Color.Gray;
            this.btnFASM.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFASM.Iconcolor = System.Drawing.Color.Transparent;
            this.btnFASM.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnFASM.Iconimage")));
            this.btnFASM.Iconimage_right = null;
            this.btnFASM.Iconimage_right_Selected = null;
            this.btnFASM.Iconimage_Selected = null;
            this.btnFASM.IconMarginLeft = 0;
            this.btnFASM.IconMarginRight = 0;
            this.btnFASM.IconRightVisible = true;
            this.btnFASM.IconRightZoom = 0D;
            this.btnFASM.IconVisible = true;
            this.btnFASM.IconZoom = 50D;
            this.btnFASM.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFASM.IsTab = false;
            this.btnFASM.Location = new System.Drawing.Point(0, 289);
            this.btnFASM.Name = "btnFASM";
            this.btnFASM.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnFASM.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.btnFASM.OnHoverTextColor = System.Drawing.Color.White;
            this.btnFASM.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnFASM.selected = false;
            this.btnFASM.Size = new System.Drawing.Size(182, 48);
            this.btnFASM.TabIndex = 3;
            this.btnFASM.TabStop = false;
            this.btnFASM.Text = "FASM";
            this.btnFASM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFASM.Textcolor = System.Drawing.Color.White;
            this.btnFASM.TextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFASM.Click += new System.EventHandler(this.btnFASM_Click);
            // 
            // btnRegistration
            // 
            this.btnRegistration.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(169)))), ((int)(((byte)(23)))));
            this.btnRegistration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnRegistration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegistration.BorderRadius = 0;
            this.btnRegistration.ButtonText = "ITEM CODE";
            this.btnRegistration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistration.DisabledColor = System.Drawing.Color.Gray;
            this.btnRegistration.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistration.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRegistration.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnRegistration.Iconimage")));
            this.btnRegistration.Iconimage_right = null;
            this.btnRegistration.Iconimage_right_Selected = null;
            this.btnRegistration.Iconimage_Selected = null;
            this.btnRegistration.IconMarginLeft = 0;
            this.btnRegistration.IconMarginRight = 0;
            this.btnRegistration.IconRightVisible = true;
            this.btnRegistration.IconRightZoom = 0D;
            this.btnRegistration.IconVisible = true;
            this.btnRegistration.IconZoom = 50D;
            this.btnRegistration.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRegistration.IsTab = false;
            this.btnRegistration.Location = new System.Drawing.Point(0, 100);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnRegistration.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.btnRegistration.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRegistration.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnRegistration.selected = false;
            this.btnRegistration.Size = new System.Drawing.Size(182, 48);
            this.btnRegistration.TabIndex = 3;
            this.btnRegistration.TabStop = false;
            this.btnRegistration.Text = "ITEM CODE";
            this.btnRegistration.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistration.Textcolor = System.Drawing.Color.White;
            this.btnRegistration.TextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistration.Click += new System.EventHandler(this.btnRegistration_Click);
            // 
            // btnVendors
            // 
            this.btnVendors.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(169)))), ((int)(((byte)(23)))));
            this.btnVendors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnVendors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVendors.BorderRadius = 0;
            this.btnVendors.ButtonText = "VENDORS";
            this.btnVendors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVendors.DisabledColor = System.Drawing.Color.Gray;
            this.btnVendors.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVendors.Iconcolor = System.Drawing.Color.Transparent;
            this.btnVendors.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnVendors.Iconimage")));
            this.btnVendors.Iconimage_right = null;
            this.btnVendors.Iconimage_right_Selected = null;
            this.btnVendors.Iconimage_Selected = null;
            this.btnVendors.IconMarginLeft = 0;
            this.btnVendors.IconMarginRight = 0;
            this.btnVendors.IconRightVisible = true;
            this.btnVendors.IconRightZoom = 0D;
            this.btnVendors.IconVisible = true;
            this.btnVendors.IconZoom = 50D;
            this.btnVendors.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnVendors.IsTab = false;
            this.btnVendors.Location = new System.Drawing.Point(0, 51);
            this.btnVendors.Name = "btnVendors";
            this.btnVendors.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnVendors.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.btnVendors.OnHoverTextColor = System.Drawing.Color.White;
            this.btnVendors.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnVendors.selected = false;
            this.btnVendors.Size = new System.Drawing.Size(182, 48);
            this.btnVendors.TabIndex = 3;
            this.btnVendors.TabStop = false;
            this.btnVendors.Text = "VENDORS";
            this.btnVendors.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVendors.Textcolor = System.Drawing.Color.White;
            this.btnVendors.TextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVendors.Click += new System.EventHandler(this.btnVendors_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(169)))), ((int)(((byte)(23)))));
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogout.BorderRadius = 0;
            this.btnLogout.ButtonText = "LOGOUT";
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.DisabledColor = System.Drawing.Color.Gray;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLogout.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnLogout.Iconimage")));
            this.btnLogout.Iconimage_right = null;
            this.btnLogout.Iconimage_right_Selected = null;
            this.btnLogout.Iconimage_Selected = null;
            this.btnLogout.IconMarginLeft = 0;
            this.btnLogout.IconMarginRight = 0;
            this.btnLogout.IconRightVisible = true;
            this.btnLogout.IconRightZoom = 0D;
            this.btnLogout.IconVisible = true;
            this.btnLogout.IconZoom = 50D;
            this.btnLogout.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLogout.IsTab = false;
            this.btnLogout.Location = new System.Drawing.Point(0, 385);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnLogout.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.btnLogout.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLogout.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnLogout.selected = false;
            this.btnLogout.Size = new System.Drawing.Size(182, 48);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.TabStop = false;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.Textcolor = System.Drawing.Color.White;
            this.btnLogout.TextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnPurchaseRequest
            // 
            this.btnPurchaseRequest.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(169)))), ((int)(((byte)(23)))));
            this.btnPurchaseRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnPurchaseRequest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPurchaseRequest.BorderRadius = 0;
            this.btnPurchaseRequest.ButtonText = "ORDERING";
            this.btnPurchaseRequest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPurchaseRequest.DisabledColor = System.Drawing.Color.Gray;
            this.btnPurchaseRequest.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchaseRequest.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPurchaseRequest.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPurchaseRequest.Iconimage")));
            this.btnPurchaseRequest.Iconimage_right = null;
            this.btnPurchaseRequest.Iconimage_right_Selected = null;
            this.btnPurchaseRequest.Iconimage_Selected = null;
            this.btnPurchaseRequest.IconMarginLeft = 0;
            this.btnPurchaseRequest.IconMarginRight = 0;
            this.btnPurchaseRequest.IconRightVisible = true;
            this.btnPurchaseRequest.IconRightZoom = 0D;
            this.btnPurchaseRequest.IconVisible = true;
            this.btnPurchaseRequest.IconZoom = 50D;
            this.btnPurchaseRequest.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPurchaseRequest.IsTab = false;
            this.btnPurchaseRequest.Location = new System.Drawing.Point(0, 145);
            this.btnPurchaseRequest.Name = "btnPurchaseRequest";
            this.btnPurchaseRequest.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnPurchaseRequest.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.btnPurchaseRequest.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPurchaseRequest.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnPurchaseRequest.selected = false;
            this.btnPurchaseRequest.Size = new System.Drawing.Size(182, 48);
            this.btnPurchaseRequest.TabIndex = 4;
            this.btnPurchaseRequest.TabStop = false;
            this.btnPurchaseRequest.Text = "ORDERING";
            this.btnPurchaseRequest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPurchaseRequest.Textcolor = System.Drawing.Color.White;
            this.btnPurchaseRequest.TextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchaseRequest.Click += new System.EventHandler(this.btnPurchaseRequest_Click);
            // 
            // pnlButtons
            // 
            this.pnlButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.pnlButtons.Controls.Add(this.btnDelivery);
            this.pnlButtons.Controls.Add(this.btnPurchaseRequest);
            this.pnlButtons.Controls.Add(this.btnLogout);
            this.pnlButtons.Controls.Add(this.btnVendors);
            this.pnlButtons.Controls.Add(this.btnRegistration);
            this.pnlButtons.Controls.Add(this.btnAccount);
            this.pnlButtons.Controls.Add(this.btnFASM);
            this.pnlButtons.Controls.Add(this.btnPurchaseOrder);
            this.pnlButtons.Controls.Add(this.btnDashboard);
            this.pnlButtons.Location = new System.Drawing.Point(0, 55);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(182, 646);
            this.pnlButtons.TabIndex = 2;
            // 
            // btnDelivery
            // 
            this.btnDelivery.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(169)))), ((int)(((byte)(23)))));
            this.btnDelivery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnDelivery.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelivery.BorderRadius = 0;
            this.btnDelivery.ButtonText = "DELIVERY";
            this.btnDelivery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelivery.DisabledColor = System.Drawing.Color.Gray;
            this.btnDelivery.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelivery.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDelivery.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDelivery.Iconimage")));
            this.btnDelivery.Iconimage_right = null;
            this.btnDelivery.Iconimage_right_Selected = null;
            this.btnDelivery.Iconimage_Selected = null;
            this.btnDelivery.IconMarginLeft = 0;
            this.btnDelivery.IconMarginRight = 0;
            this.btnDelivery.IconRightVisible = true;
            this.btnDelivery.IconRightZoom = 0D;
            this.btnDelivery.IconVisible = true;
            this.btnDelivery.IconZoom = 50D;
            this.btnDelivery.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDelivery.IsTab = false;
            this.btnDelivery.Location = new System.Drawing.Point(0, 241);
            this.btnDelivery.Name = "btnDelivery";
            this.btnDelivery.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnDelivery.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.btnDelivery.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDelivery.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnDelivery.selected = false;
            this.btnDelivery.Size = new System.Drawing.Size(182, 48);
            this.btnDelivery.TabIndex = 5;
            this.btnDelivery.TabStop = false;
            this.btnDelivery.Text = "DELIVERY";
            this.btnDelivery.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelivery.Textcolor = System.Drawing.Color.White;
            this.btnDelivery.TextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelivery.Click += new System.EventHandler(this.btnDelivery_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(169)))), ((int)(((byte)(23)))));
            this.btnAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAccount.BorderRadius = 0;
            this.btnAccount.ButtonText = "SETTINGS";
            this.btnAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccount.DisabledColor = System.Drawing.Color.Gray;
            this.btnAccount.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAccount.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAccount.Iconimage")));
            this.btnAccount.Iconimage_right = null;
            this.btnAccount.Iconimage_right_Selected = null;
            this.btnAccount.Iconimage_Selected = null;
            this.btnAccount.IconMarginLeft = 0;
            this.btnAccount.IconMarginRight = 0;
            this.btnAccount.IconRightVisible = true;
            this.btnAccount.IconRightZoom = 0D;
            this.btnAccount.IconVisible = true;
            this.btnAccount.IconZoom = 50D;
            this.btnAccount.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAccount.IsTab = false;
            this.btnAccount.Location = new System.Drawing.Point(0, 337);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAccount.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.btnAccount.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAccount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAccount.selected = false;
            this.btnAccount.Size = new System.Drawing.Size(182, 48);
            this.btnAccount.TabIndex = 3;
            this.btnAccount.TabStop = false;
            this.btnAccount.Text = "SETTINGS";
            this.btnAccount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAccount.Textcolor = System.Drawing.Color.White;
            this.btnAccount.TextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // fasm1
            // 
            this.fasm1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fasm1.Location = new System.Drawing.Point(183, 57);
            this.fasm1.Name = "fasm1";
            this.fasm1.Size = new System.Drawing.Size(1045, 626);
            this.fasm1.TabIndex = 13;
            this.fasm1.Visible = false;
            // 
            // vendors1
            // 
            this.vendors1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vendors1.Location = new System.Drawing.Point(183, 57);
            this.vendors1.Name = "vendors1";
            this.vendors1.Size = new System.Drawing.Size(1045, 626);
            this.vendors1.TabIndex = 9;
            this.vendors1.Visible = false;
            // 
            // dashboard1
            // 
            this.dashboard1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dashboard1.Location = new System.Drawing.Point(183, 57);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(1045, 626);
            this.dashboard1.TabIndex = 7;
            this.dashboard1.Visible = false;
            // 
            // registration1
            // 
            this.registration1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.registration1.Location = new System.Drawing.Point(183, 57);
            this.registration1.Name = "registration1";
            this.registration1.Size = new System.Drawing.Size(1045, 626);
            this.registration1.TabIndex = 8;
            this.registration1.Visible = false;
            // 
            // delivery1
            // 
            this.delivery1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.delivery1.Location = new System.Drawing.Point(183, 57);
            this.delivery1.Name = "delivery1";
            this.delivery1.Size = new System.Drawing.Size(1045, 626);
            this.delivery1.TabIndex = 12;
            this.delivery1.Visible = false;
            // 
            // po1
            // 
            this.po1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.po1.Location = new System.Drawing.Point(183, 57);
            this.po1.Name = "po1";
            this.po1.Size = new System.Drawing.Size(1045, 626);
            this.po1.TabIndex = 11;
            this.po1.Visible = false;
            // 
            // pr1
            // 
            this.pr1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pr1.Location = new System.Drawing.Point(183, 57);
            this.pr1.Name = "pr1";
            this.pr1.Size = new System.Drawing.Size(1045, 626);
            this.pr1.TabIndex = 10;
            this.pr1.Visible = false;
            // 
            // acct1
            // 
            this.acct1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.acct1.Location = new System.Drawing.Point(183, 57);
            this.acct1.Name = "acct1";
            this.acct1.Size = new System.Drawing.Size(1045, 626);
            this.acct1.TabIndex = 14;
            this.acct1.Visible = false;
            this.acct1.Load += new System.EventHandler(this.acct1_Load);
            // 
            // frmAdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 701);
            this.Controls.Add(this.acct1);
            this.Controls.Add(this.fasm1);
            this.Controls.Add(this.pnlDtp);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.vendors1);
            this.Controls.Add(this.dashboard1);
            this.Controls.Add(this.registration1);
            this.Controls.Add(this.delivery1);
            this.Controls.Add(this.po1);
            this.Controls.Add(this.pr1);
            this.Name = "frmAdminDashboard";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlDtp.ResumeLayout(false);
            this.pnlDtp.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlDtp;
        private System.Windows.Forms.Label lblDate;
        public Bunifu.Framework.UI.BunifuFlatButton btnDashboard;
        public Bunifu.Framework.UI.BunifuFlatButton btnPurchaseOrder;
        public Bunifu.Framework.UI.BunifuFlatButton btnFASM;
        public Bunifu.Framework.UI.BunifuFlatButton btnRegistration;
        public Bunifu.Framework.UI.BunifuFlatButton btnVendors;
        public Bunifu.Framework.UI.BunifuFlatButton btnLogout;
        public Bunifu.Framework.UI.BunifuFlatButton btnPurchaseRequest;
        private System.Windows.Forms.Panel pnlButtons;
        public Bunifu.Framework.UI.BunifuFlatButton btnDelivery;
        private System.Windows.Forms.Label label2;
        private MainControls.Dashboard dashboard1;
        private MainControls.Registration registration1;
        private MainControls.Vendors vendors1;
        private MainControls.PR pr1;
        private MainControls.PO po1;
        private MainControls.Delivery delivery1;
        private MainControls.FASM fasm1;
        public Bunifu.Framework.UI.BunifuFlatButton btnAccount;
        private MainControls.Acct acct1;
        public Bunifu.Framework.UI.BunifuFlatButton btnMaximize;
        public Bunifu.Framework.UI.BunifuFlatButton btnMinimize;
    }
}