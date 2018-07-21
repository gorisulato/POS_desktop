namespace POS.Master.Customer
{
    partial class FormCustomer
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editcustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.txtpageinfo = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_first = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_prev = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_next = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_last = new Bunifu.Framework.UI.BunifuImageButton();
            this.txt_pagination = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dg_cust = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_exit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_add_sales = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lbl_searchsalesnumber = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_cusnome = new AltoControls.AltoTextBox();
            this.searchbox = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_membercode = new AltoControls.AltoTextBox();
            this.btnresetsearch = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_search = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelsearch = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.ds_sales = new System.Windows.Forms.BindingSource(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_first)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_prev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_next)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_last)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_cust)).BeginInit();
            this.panel4.SuspendLayout();
            this.searchbox.SuspendLayout();
            this.panelsearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_sales)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editcustomer});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(150, 26);
            // 
            // editcustomer
            // 
            this.editcustomer.Name = "editcustomer";
            this.editcustomer.Size = new System.Drawing.Size(149, 22);
            this.editcustomer.Text = "Edit Customer";
            this.editcustomer.Click += new System.EventHandler(this.editcustomer_Click);
            // 
            // txtpageinfo
            // 
            this.txtpageinfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtpageinfo.AutoSize = true;
            this.txtpageinfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpageinfo.ForeColor = System.Drawing.Color.White;
            this.txtpageinfo.Location = new System.Drawing.Point(85, 4);
            this.txtpageinfo.Name = "txtpageinfo";
            this.txtpageinfo.Size = new System.Drawing.Size(45, 17);
            this.txtpageinfo.TabIndex = 0;
            this.txtpageinfo.Text = "label1";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btn_first);
            this.flowLayoutPanel1.Controls.Add(this.btn_prev);
            this.flowLayoutPanel1.Controls.Add(this.txtpageinfo);
            this.flowLayoutPanel1.Controls.Add(this.btn_next);
            this.flowLayoutPanel1.Controls.Add(this.btn_last);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(638, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(253, 47);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btn_first
            // 
            this.btn_first.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_first.Image = global::POS.Properties.Resources.first_white;
            this.btn_first.ImageActive = null;
            this.btn_first.Location = new System.Drawing.Point(3, 3);
            this.btn_first.Name = "btn_first";
            this.btn_first.Size = new System.Drawing.Size(35, 20);
            this.btn_first.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_first.TabIndex = 0;
            this.btn_first.TabStop = false;
            this.btn_first.Zoom = 10;
            this.btn_first.Click += new System.EventHandler(this.btn_first_Click);
            // 
            // btn_prev
            // 
            this.btn_prev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_prev.Image = global::POS.Properties.Resources.prev_white;
            this.btn_prev.ImageActive = null;
            this.btn_prev.Location = new System.Drawing.Point(44, 3);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(35, 20);
            this.btn_prev.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_prev.TabIndex = 1;
            this.btn_prev.TabStop = false;
            this.btn_prev.Zoom = 10;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_next.Image = global::POS.Properties.Resources.next_white;
            this.btn_next.ImageActive = null;
            this.btn_next.Location = new System.Drawing.Point(136, 3);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(35, 20);
            this.btn_next.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_next.TabIndex = 3;
            this.btn_next.TabStop = false;
            this.btn_next.Zoom = 10;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_last
            // 
            this.btn_last.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_last.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_last.Image = global::POS.Properties.Resources.last_white;
            this.btn_last.ImageActive = null;
            this.btn_last.Location = new System.Drawing.Point(177, 3);
            this.btn_last.Name = "btn_last";
            this.btn_last.Size = new System.Drawing.Size(35, 20);
            this.btn_last.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_last.TabIndex = 4;
            this.btn_last.TabStop = false;
            this.btn_last.Zoom = 10;
            this.btn_last.Click += new System.EventHandler(this.btn_last_Click);
            // 
            // txt_pagination
            // 
            this.txt_pagination.AutoSize = true;
            this.txt_pagination.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pagination.ForeColor = System.Drawing.Color.White;
            this.txt_pagination.Location = new System.Drawing.Point(3, 0);
            this.txt_pagination.Name = "txt_pagination";
            this.txt_pagination.Size = new System.Drawing.Size(45, 17);
            this.txt_pagination.TabIndex = 5;
            this.txt_pagination.Text = "label1";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.txt_pagination);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(399, 47);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.flowLayoutPanel2);
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 303);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(891, 47);
            this.panel2.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dg_cust);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(891, 350);
            this.panel1.TabIndex = 8;
            // 
            // dg_cust
            // 
            this.dg_cust.AllowUserToAddRows = false;
            this.dg_cust.AllowUserToDeleteRows = false;
            this.dg_cust.AllowUserToOrderColumns = true;
            this.dg_cust.BackgroundColor = System.Drawing.Color.White;
            this.dg_cust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_cust.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_cust.Location = new System.Drawing.Point(0, 0);
            this.dg_cust.Name = "dg_cust";
            this.dg_cust.ReadOnly = true;
            this.dg_cust.Size = new System.Drawing.Size(891, 350);
            this.dg_cust.TabIndex = 2;
            this.dg_cust.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_cust_CellClick);
            this.dg_cust.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dg_cust_CellMouseUp);
            this.dg_cust.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dg_cust_DataBindingComplete);
            this.dg_cust.SelectionChanged += new System.EventHandler(this.dg_cust_SelectionChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Teal;
            this.panel4.Controls.Add(this.btn_exit);
            this.panel4.Controls.Add(this.btn_add_sales);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 40);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(891, 56);
            this.panel4.TabIndex = 7;
            // 
            // btn_exit
            // 
            this.btn_exit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_exit.BorderRadius = 0;
            this.btn_exit.ButtonText = "Keluar";
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.DisabledColor = System.Drawing.Color.Gray;
            this.btn_exit.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_exit.Iconimage = global::POS.Properties.Resources.Clock_white;
            this.btn_exit.Iconimage_right = null;
            this.btn_exit.Iconimage_right_Selected = null;
            this.btn_exit.Iconimage_Selected = null;
            this.btn_exit.IconMarginLeft = 0;
            this.btn_exit.IconMarginRight = 0;
            this.btn_exit.IconRightVisible = true;
            this.btn_exit.IconRightZoom = 0D;
            this.btn_exit.IconVisible = true;
            this.btn_exit.IconZoom = 90D;
            this.btn_exit.IsTab = false;
            this.btn_exit.Location = new System.Drawing.Point(760, 6);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_exit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_exit.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_exit.selected = false;
            this.btn_exit.Size = new System.Drawing.Size(128, 40);
            this.btn_exit.TabIndex = 6;
            this.btn_exit.Text = "Keluar";
            this.btn_exit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exit.Textcolor = System.Drawing.Color.White;
            this.btn_exit.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_add_sales
            // 
            this.btn_add_sales.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_add_sales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_add_sales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_add_sales.BorderRadius = 0;
            this.btn_add_sales.ButtonText = "Tambah Customer";
            this.btn_add_sales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_sales.DisabledColor = System.Drawing.Color.Gray;
            this.btn_add_sales.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_add_sales.Iconimage = global::POS.Properties.Resources.Positive;
            this.btn_add_sales.Iconimage_right = null;
            this.btn_add_sales.Iconimage_right_Selected = null;
            this.btn_add_sales.Iconimage_Selected = null;
            this.btn_add_sales.IconMarginLeft = 0;
            this.btn_add_sales.IconMarginRight = 0;
            this.btn_add_sales.IconRightVisible = true;
            this.btn_add_sales.IconRightZoom = 0D;
            this.btn_add_sales.IconVisible = true;
            this.btn_add_sales.IconZoom = 90D;
            this.btn_add_sales.IsTab = false;
            this.btn_add_sales.Location = new System.Drawing.Point(610, 6);
            this.btn_add_sales.Name = "btn_add_sales";
            this.btn_add_sales.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_add_sales.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_add_sales.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_add_sales.selected = false;
            this.btn_add_sales.Size = new System.Drawing.Size(138, 40);
            this.btn_add_sales.TabIndex = 5;
            this.btn_add_sales.Text = "Tambah Customer";
            this.btn_add_sales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add_sales.Textcolor = System.Drawing.Color.White;
            this.btn_add_sales.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_sales.Click += new System.EventHandler(this.btn_add_sales_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // lbl_searchsalesnumber
            // 
            this.lbl_searchsalesnumber.AutoSize = true;
            this.lbl_searchsalesnumber.ForeColor = System.Drawing.Color.White;
            this.lbl_searchsalesnumber.Location = new System.Drawing.Point(29, 16);
            this.lbl_searchsalesnumber.Name = "lbl_searchsalesnumber";
            this.lbl_searchsalesnumber.Size = new System.Drawing.Size(82, 13);
            this.lbl_searchsalesnumber.TabIndex = 7;
            this.lbl_searchsalesnumber.Text = "Nama Customer";
            // 
            // txt_cusnome
            // 
            this.txt_cusnome.ALG = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_cusnome.BackColor = System.Drawing.Color.Transparent;
            this.txt_cusnome.Br = System.Drawing.Color.White;
            this.txt_cusnome.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_cusnome.ForeColor = System.Drawing.Color.DimGray;
            this.txt_cusnome.Location = new System.Drawing.Point(22, 33);
            this.txt_cusnome.Name = "txt_cusnome";
            this.txt_cusnome.Radius = 6;
            this.txt_cusnome.Size = new System.Drawing.Size(135, 33);
            this.txt_cusnome.TabIndex = 6;
            // 
            // searchbox
            // 
            this.searchbox.BackColor = System.Drawing.Color.Teal;
            this.searchbox.Controls.Add(this.bunifuCustomLabel1);
            this.searchbox.Controls.Add(this.txt_membercode);
            this.searchbox.Controls.Add(this.btnresetsearch);
            this.searchbox.Controls.Add(this.btn_search);
            this.searchbox.Controls.Add(this.lbl_searchsalesnumber);
            this.searchbox.Controls.Add(this.txt_cusnome);
            this.searchbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchbox.Location = new System.Drawing.Point(0, 30);
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(891, 10);
            this.searchbox.TabIndex = 6;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(208, 16);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(73, 13);
            this.bunifuCustomLabel1.TabIndex = 14;
            this.bunifuCustomLabel1.Text = "Kode Member";
            // 
            // txt_membercode
            // 
            this.txt_membercode.ALG = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_membercode.BackColor = System.Drawing.Color.Transparent;
            this.txt_membercode.Br = System.Drawing.Color.White;
            this.txt_membercode.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_membercode.ForeColor = System.Drawing.Color.DimGray;
            this.txt_membercode.Location = new System.Drawing.Point(200, 33);
            this.txt_membercode.Name = "txt_membercode";
            this.txt_membercode.Radius = 6;
            this.txt_membercode.Size = new System.Drawing.Size(170, 33);
            this.txt_membercode.TabIndex = 13;
            // 
            // btnresetsearch
            // 
            this.btnresetsearch.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnresetsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnresetsearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnresetsearch.BorderRadius = 0;
            this.btnresetsearch.ButtonText = "Reset";
            this.btnresetsearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnresetsearch.DisabledColor = System.Drawing.Color.Gray;
            this.btnresetsearch.Iconcolor = System.Drawing.Color.Transparent;
            this.btnresetsearch.Iconimage = global::POS.Properties.Resources.reset_white;
            this.btnresetsearch.Iconimage_right = null;
            this.btnresetsearch.Iconimage_right_Selected = null;
            this.btnresetsearch.Iconimage_Selected = null;
            this.btnresetsearch.IconMarginLeft = 0;
            this.btnresetsearch.IconMarginRight = 0;
            this.btnresetsearch.IconRightVisible = true;
            this.btnresetsearch.IconRightZoom = 0D;
            this.btnresetsearch.IconVisible = true;
            this.btnresetsearch.IconZoom = 50D;
            this.btnresetsearch.IsTab = false;
            this.btnresetsearch.Location = new System.Drawing.Point(276, 90);
            this.btnresetsearch.Name = "btnresetsearch";
            this.btnresetsearch.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnresetsearch.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnresetsearch.OnHoverTextColor = System.Drawing.Color.White;
            this.btnresetsearch.selected = false;
            this.btnresetsearch.Size = new System.Drawing.Size(94, 43);
            this.btnresetsearch.TabIndex = 12;
            this.btnresetsearch.Text = "Reset";
            this.btnresetsearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnresetsearch.Textcolor = System.Drawing.Color.White;
            this.btnresetsearch.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnresetsearch.Click += new System.EventHandler(this.btnresetsearch_Click);
            // 
            // btn_search
            // 
            this.btn_search.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_search.BorderRadius = 0;
            this.btn_search.ButtonText = "Search";
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.DisabledColor = System.Drawing.Color.Gray;
            this.btn_search.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_search.Iconimage = global::POS.Properties.Resources.Search_white;
            this.btn_search.Iconimage_right = null;
            this.btn_search.Iconimage_right_Selected = null;
            this.btn_search.Iconimage_Selected = null;
            this.btn_search.IconMarginLeft = 0;
            this.btn_search.IconMarginRight = 0;
            this.btn_search.IconRightVisible = true;
            this.btn_search.IconRightZoom = 0D;
            this.btn_search.IconVisible = true;
            this.btn_search.IconZoom = 90D;
            this.btn_search.IsTab = false;
            this.btn_search.Location = new System.Drawing.Point(176, 90);
            this.btn_search.Name = "btn_search";
            this.btn_search.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_search.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_search.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_search.selected = false;
            this.btn_search.Size = new System.Drawing.Size(94, 43);
            this.btn_search.TabIndex = 10;
            this.btn_search.Text = "Search";
            this.btn_search.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_search.Textcolor = System.Drawing.Color.White;
            this.btn_search.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // panelsearch
            // 
            this.panelsearch.BackColor = System.Drawing.Color.Teal;
            this.panelsearch.Controls.Add(this.bunifuImageButton1);
            this.panelsearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelsearch.Location = new System.Drawing.Point(0, 0);
            this.panelsearch.Name = "panelsearch";
            this.panelsearch.Size = new System.Drawing.Size(891, 30);
            this.panelsearch.TabIndex = 5;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuImageButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.bunifuImageButton1.Image = global::POS.Properties.Resources.chevron_white;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(863, 0);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(28, 30);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 11;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelsearch;
            this.bunifuDragControl1.Vertical = true;
            // 
            // FormCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 446);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.searchbox);
            this.Controls.Add(this.panelsearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCustomer";
            this.Load += new System.EventHandler(this.FormCustomer_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_first)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_prev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_next)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_last)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_cust)).EndInit();
            this.panel4.ResumeLayout(false);
            this.searchbox.ResumeLayout(false);
            this.searchbox.PerformLayout();
            this.panelsearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_sales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource ds_sales;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editcustomer;
        private Bunifu.Framework.UI.BunifuImageButton btn_first;
        private Bunifu.Framework.UI.BunifuImageButton btn_prev;
        private System.Windows.Forms.Label txtpageinfo;
        private Bunifu.Framework.UI.BunifuImageButton btn_next;
        private Bunifu.Framework.UI.BunifuImageButton btn_last;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label txt_pagination;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dg_cust;
        private Bunifu.Framework.UI.BunifuFlatButton btn_exit;
        private Bunifu.Framework.UI.BunifuFlatButton btn_add_sales;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel searchbox;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private AltoControls.AltoTextBox txt_membercode;
        private Bunifu.Framework.UI.BunifuFlatButton btnresetsearch;
        private Bunifu.Framework.UI.BunifuFlatButton btn_search;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_searchsalesnumber;
        private AltoControls.AltoTextBox txt_cusnome;
        private System.Windows.Forms.Panel panelsearch;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}