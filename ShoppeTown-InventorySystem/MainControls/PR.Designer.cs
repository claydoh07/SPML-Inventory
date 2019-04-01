namespace ShoppeTown_InventorySystem.MainControls
{
    partial class PR
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PR));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSearch = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtSearch = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSend = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEditPR = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDeletePR = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAddPR = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dgv_PR = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PR)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(89)))), ((int)(((byte)(5)))));
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.BorderRadius = 0;
            this.btnSearch.ButtonText = "";
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.DisabledColor = System.Drawing.Color.Gray;
            this.btnSearch.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSearch.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSearch.Iconimage")));
            this.btnSearch.Iconimage_right = null;
            this.btnSearch.Iconimage_right_Selected = null;
            this.btnSearch.Iconimage_Selected = null;
            this.btnSearch.IconMarginLeft = 0;
            this.btnSearch.IconMarginRight = 0;
            this.btnSearch.IconRightVisible = true;
            this.btnSearch.IconRightZoom = 0D;
            this.btnSearch.IconVisible = true;
            this.btnSearch.IconZoom = 50D;
            this.btnSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSearch.IsTab = false;
            this.btnSearch.Location = new System.Drawing.Point(311, 20);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnSearch.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(103)))), ((int)(((byte)(6)))));
            this.btnSearch.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSearch.selected = false;
            this.btnSearch.Size = new System.Drawing.Size(40, 40);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.TabStop = false;
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.Textcolor = System.Drawing.Color.White;
            this.btnSearch.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Gray;
            this.txtSearch.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearch.HintText = "Search Here...";
            this.txtSearch.isPassword = false;
            this.txtSearch.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(89)))), ((int)(((byte)(5)))));
            this.txtSearch.LineIdleColor = System.Drawing.Color.DarkGray;
            this.txtSearch.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(119)))), ((int)(((byte)(6)))));
            this.txtSearch.LineThickness = 3;
            this.txtSearch.Location = new System.Drawing.Point(11, 20);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(338, 39);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(89)))), ((int)(((byte)(5)))));
            this.bunifuFlatButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Refresh";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 60D;
            this.bunifuFlatButton1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(563, 0);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(103)))), ((int)(((byte)(6)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(108, 24);
            this.bunifuFlatButton1.TabIndex = 12;
            this.bunifuFlatButton1.TabStop = false;
            this.bunifuFlatButton1.Text = "Refresh";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bunifuFlatButton1);
            this.panel1.Location = new System.Drawing.Point(356, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(677, 26);
            this.panel1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "PURCHASE REQUEST";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.btnSend);
            this.groupBox1.Controls.Add(this.btnEditPR);
            this.groupBox1.Controls.Add(this.btnDeletePR);
            this.groupBox1.Controls.Add(this.btnAddPR);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 547);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manage";
            // 
            // btnSend
            // 
            this.btnSend.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(89)))), ((int)(((byte)(5)))));
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSend.BorderRadius = 0;
            this.btnSend.ButtonText = "&SEND TO PURCHASE ORDER";
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.DisabledColor = System.Drawing.Color.Gray;
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSend.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSend.Iconimage")));
            this.btnSend.Iconimage_right = null;
            this.btnSend.Iconimage_right_Selected = null;
            this.btnSend.Iconimage_Selected = null;
            this.btnSend.IconMarginLeft = 0;
            this.btnSend.IconMarginRight = 0;
            this.btnSend.IconRightVisible = true;
            this.btnSend.IconRightZoom = 0D;
            this.btnSend.IconVisible = true;
            this.btnSend.IconZoom = 50D;
            this.btnSend.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSend.IsTab = false;
            this.btnSend.Location = new System.Drawing.Point(12, 76);
            this.btnSend.Margin = new System.Windows.Forms.Padding(9, 6, 9, 6);
            this.btnSend.Name = "btnSend";
            this.btnSend.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnSend.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(103)))), ((int)(((byte)(6)))));
            this.btnSend.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSend.selected = false;
            this.btnSend.Size = new System.Drawing.Size(316, 39);
            this.btnSend.TabIndex = 18;
            this.btnSend.TabStop = false;
            this.btnSend.Text = "&SEND TO PURCHASE ORDER";
            this.btnSend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSend.Textcolor = System.Drawing.Color.White;
            this.btnSend.TextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnEditPR
            // 
            this.btnEditPR.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(89)))), ((int)(((byte)(5)))));
            this.btnEditPR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnEditPR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditPR.BorderRadius = 0;
            this.btnEditPR.ButtonText = "EDIT";
            this.btnEditPR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditPR.DisabledColor = System.Drawing.Color.Gray;
            this.btnEditPR.Enabled = false;
            this.btnEditPR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditPR.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEditPR.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEditPR.Iconimage")));
            this.btnEditPR.Iconimage_right = null;
            this.btnEditPR.Iconimage_right_Selected = null;
            this.btnEditPR.Iconimage_Selected = null;
            this.btnEditPR.IconMarginLeft = 0;
            this.btnEditPR.IconMarginRight = 0;
            this.btnEditPR.IconRightVisible = true;
            this.btnEditPR.IconRightZoom = 0D;
            this.btnEditPR.IconVisible = true;
            this.btnEditPR.IconZoom = 50D;
            this.btnEditPR.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEditPR.IsTab = false;
            this.btnEditPR.Location = new System.Drawing.Point(12, 125);
            this.btnEditPR.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnEditPR.Name = "btnEditPR";
            this.btnEditPR.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnEditPR.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(103)))), ((int)(((byte)(6)))));
            this.btnEditPR.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEditPR.selected = false;
            this.btnEditPR.Size = new System.Drawing.Size(316, 39);
            this.btnEditPR.TabIndex = 15;
            this.btnEditPR.TabStop = false;
            this.btnEditPR.Text = "EDIT";
            this.btnEditPR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEditPR.Textcolor = System.Drawing.Color.White;
            this.btnEditPR.TextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnDeletePR
            // 
            this.btnDeletePR.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(89)))), ((int)(((byte)(5)))));
            this.btnDeletePR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnDeletePR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeletePR.BorderRadius = 0;
            this.btnDeletePR.ButtonText = "DELETE";
            this.btnDeletePR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeletePR.DisabledColor = System.Drawing.Color.Gray;
            this.btnDeletePR.Enabled = false;
            this.btnDeletePR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePR.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDeletePR.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDeletePR.Iconimage")));
            this.btnDeletePR.Iconimage_right = null;
            this.btnDeletePR.Iconimage_right_Selected = null;
            this.btnDeletePR.Iconimage_Selected = null;
            this.btnDeletePR.IconMarginLeft = 0;
            this.btnDeletePR.IconMarginRight = 0;
            this.btnDeletePR.IconRightVisible = true;
            this.btnDeletePR.IconRightZoom = 0D;
            this.btnDeletePR.IconVisible = true;
            this.btnDeletePR.IconZoom = 50D;
            this.btnDeletePR.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDeletePR.IsTab = false;
            this.btnDeletePR.Location = new System.Drawing.Point(12, 173);
            this.btnDeletePR.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.btnDeletePR.Name = "btnDeletePR";
            this.btnDeletePR.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnDeletePR.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(103)))), ((int)(((byte)(6)))));
            this.btnDeletePR.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDeletePR.selected = false;
            this.btnDeletePR.Size = new System.Drawing.Size(316, 39);
            this.btnDeletePR.TabIndex = 16;
            this.btnDeletePR.TabStop = false;
            this.btnDeletePR.Text = "DELETE";
            this.btnDeletePR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDeletePR.Textcolor = System.Drawing.Color.White;
            this.btnDeletePR.TextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnAddPR
            // 
            this.btnAddPR.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(89)))), ((int)(((byte)(5)))));
            this.btnAddPR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAddPR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddPR.BorderRadius = 0;
            this.btnAddPR.ButtonText = "&ADD PURCHASE REQUEST";
            this.btnAddPR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPR.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddPR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPR.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddPR.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAddPR.Iconimage")));
            this.btnAddPR.Iconimage_right = null;
            this.btnAddPR.Iconimage_right_Selected = null;
            this.btnAddPR.Iconimage_Selected = null;
            this.btnAddPR.IconMarginLeft = 0;
            this.btnAddPR.IconMarginRight = 0;
            this.btnAddPR.IconRightVisible = true;
            this.btnAddPR.IconRightZoom = 0D;
            this.btnAddPR.IconVisible = true;
            this.btnAddPR.IconZoom = 50D;
            this.btnAddPR.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAddPR.IsTab = false;
            this.btnAddPR.Location = new System.Drawing.Point(12, 25);
            this.btnAddPR.Margin = new System.Windows.Forms.Padding(9, 6, 9, 6);
            this.btnAddPR.Name = "btnAddPR";
            this.btnAddPR.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAddPR.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(103)))), ((int)(((byte)(6)))));
            this.btnAddPR.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddPR.selected = false;
            this.btnAddPR.Size = new System.Drawing.Size(316, 39);
            this.btnAddPR.TabIndex = 17;
            this.btnAddPR.TabStop = false;
            this.btnAddPR.Text = "&ADD PURCHASE REQUEST";
            this.btnAddPR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddPR.Textcolor = System.Drawing.Color.White;
            this.btnAddPR.TextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPR.Click += new System.EventHandler(this.btnAddPR_Click);
            // 
            // dgv_PR
            // 
            this.dgv_PR.AllowUserToAddRows = false;
            this.dgv_PR.AllowUserToDeleteRows = false;
            this.dgv_PR.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_PR.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_PR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_PR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgv_PR.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_PR.BackgroundColor = System.Drawing.Color.White;
            this.dgv_PR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_PR.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_PR.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_PR.ColumnHeadersHeight = 25;
            this.dgv_PR.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_PR.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_PR.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_PR.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgv_PR.Location = new System.Drawing.Point(357, 44);
            this.dgv_PR.MultiSelect = false;
            this.dgv_PR.Name = "dgv_PR";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_PR.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_PR.RowHeadersVisible = false;
            this.dgv_PR.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_PR.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_PR.RowTemplate.Height = 10;
            this.dgv_PR.RowTemplate.ReadOnly = true;
            this.dgv_PR.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_PR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_PR.Size = new System.Drawing.Size(676, 569);
            this.dgv_PR.TabIndex = 251;
            this.dgv_PR.DoubleClick += new System.EventHandler(this.dgv_PR_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(114, 26);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // PR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_PR);
            this.Name = "PR";
            this.Size = new System.Drawing.Size(1045, 626);
            this.Load += new System.EventHandler(this.PR_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PR)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public Bunifu.Framework.UI.BunifuFlatButton btnSearch;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtSearch;
        public Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        public Bunifu.Framework.UI.BunifuFlatButton btnAddPR;
        public Bunifu.Framework.UI.BunifuFlatButton btnDeletePR;
        public Bunifu.Framework.UI.BunifuFlatButton btnEditPR;
        public Bunifu.Framework.UI.BunifuFlatButton btnSend;
        private System.Windows.Forms.DataGridView dgv_PR;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
    }
}
