namespace POS.Master.Supplier
{
    partial class SupplierListData
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
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dg_supp = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_exit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_add_supplier = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelsearch = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.searchbox = new System.Windows.Forms.Panel();
            this.btnresetsearch = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_search = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lbl_searchsalesnumber = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_suppname = new AltoControls.AltoTextBox();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.EditSupplier = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteSupplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.txt_pagination = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_first = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_prev = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtpageinfo = new System.Windows.Forms.Label();
            this.btn_next = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_last = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ds_sales = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dg_supp)).BeginInit();
            this.panel4.SuspendLayout();
            this.panelsearch.SuspendLayout();
            this.searchbox.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_first)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_prev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_next)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_last)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds_sales)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // dg_supp
            // 
            this.dg_supp.AllowUserToAddRows = false;
            this.dg_supp.AllowUserToDeleteRows = false;
            this.dg_supp.AllowUserToOrderColumns = true;
            this.dg_supp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dg_supp.BackgroundColor = System.Drawing.Color.White;
            this.dg_supp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_supp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_supp.Location = new System.Drawing.Point(0, 0);
            this.dg_supp.Name = "dg_supp";
            this.dg_supp.ReadOnly = true;
            this.dg_supp.Size = new System.Drawing.Size(897, 243);
            this.dg_supp.TabIndex = 2;
            this.dg_supp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_supp_CellClick);
            this.dg_supp.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dg_supp_CellMouseUp);
            this.dg_supp.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dg_supp_DataBindingComplete);
            this.dg_supp.SelectionChanged += new System.EventHandler(this.dg_supp_SelectionChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Teal;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.btn_exit);
            this.panel4.Controls.Add(this.btn_add_supplier);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 114);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(897, 56);
            this.panel4.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "List Data Supplier";
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
            // btn_add_supplier
            // 
            this.btn_add_supplier.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_add_supplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_add_supplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_add_supplier.BorderRadius = 0;
            this.btn_add_supplier.ButtonText = "Tambah Supplier";
            this.btn_add_supplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_supplier.DisabledColor = System.Drawing.Color.Gray;
            this.btn_add_supplier.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_add_supplier.Iconimage = global::POS.Properties.Resources.Positive;
            this.btn_add_supplier.Iconimage_right = null;
            this.btn_add_supplier.Iconimage_right_Selected = null;
            this.btn_add_supplier.Iconimage_Selected = null;
            this.btn_add_supplier.IconMarginLeft = 0;
            this.btn_add_supplier.IconMarginRight = 0;
            this.btn_add_supplier.IconRightVisible = true;
            this.btn_add_supplier.IconRightZoom = 0D;
            this.btn_add_supplier.IconVisible = true;
            this.btn_add_supplier.IconZoom = 90D;
            this.btn_add_supplier.IsTab = false;
            this.btn_add_supplier.Location = new System.Drawing.Point(610, 6);
            this.btn_add_supplier.Name = "btn_add_supplier";
            this.btn_add_supplier.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_add_supplier.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_add_supplier.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_add_supplier.selected = false;
            this.btn_add_supplier.Size = new System.Drawing.Size(138, 40);
            this.btn_add_supplier.TabIndex = 5;
            this.btn_add_supplier.Text = "Tambah Supplier";
            this.btn_add_supplier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add_supplier.Textcolor = System.Drawing.Color.White;
            this.btn_add_supplier.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_supplier.Click += new System.EventHandler(this.btn_add_supplier_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelsearch;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panelsearch
            // 
            this.panelsearch.BackColor = System.Drawing.Color.Teal;
            this.panelsearch.Controls.Add(this.label2);
            this.panelsearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelsearch.Location = new System.Drawing.Point(0, 0);
            this.panelsearch.Name = "panelsearch";
            this.panelsearch.Size = new System.Drawing.Size(897, 30);
            this.panelsearch.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Search";
            // 
            // searchbox
            // 
            this.searchbox.BackColor = System.Drawing.Color.Teal;
            this.searchbox.Controls.Add(this.btnresetsearch);
            this.searchbox.Controls.Add(this.btn_search);
            this.searchbox.Controls.Add(this.lbl_searchsalesnumber);
            this.searchbox.Controls.Add(this.txt_suppname);
            this.searchbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchbox.Location = new System.Drawing.Point(0, 30);
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(897, 84);
            this.searchbox.TabIndex = 10;
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
            this.btnresetsearch.Location = new System.Drawing.Point(293, 33);
            this.btnresetsearch.Name = "btnresetsearch";
            this.btnresetsearch.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnresetsearch.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnresetsearch.OnHoverTextColor = System.Drawing.Color.White;
            this.btnresetsearch.selected = false;
            this.btnresetsearch.Size = new System.Drawing.Size(94, 33);
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
            this.btn_search.Location = new System.Drawing.Point(172, 33);
            this.btn_search.Name = "btn_search";
            this.btn_search.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_search.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_search.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_search.selected = false;
            this.btn_search.Size = new System.Drawing.Size(94, 33);
            this.btn_search.TabIndex = 10;
            this.btn_search.Text = "Search";
            this.btn_search.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_search.Textcolor = System.Drawing.Color.White;
            this.btn_search.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // lbl_searchsalesnumber
            // 
            this.lbl_searchsalesnumber.AutoSize = true;
            this.lbl_searchsalesnumber.ForeColor = System.Drawing.Color.White;
            this.lbl_searchsalesnumber.Location = new System.Drawing.Point(29, 16);
            this.lbl_searchsalesnumber.Name = "lbl_searchsalesnumber";
            this.lbl_searchsalesnumber.Size = new System.Drawing.Size(76, 13);
            this.lbl_searchsalesnumber.TabIndex = 7;
            this.lbl_searchsalesnumber.Text = "Nama Supplier";
            // 
            // txt_suppname
            // 
            this.txt_suppname.ALG = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_suppname.BackColor = System.Drawing.Color.Transparent;
            this.txt_suppname.Br = System.Drawing.Color.White;
            this.txt_suppname.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_suppname.ForeColor = System.Drawing.Color.DimGray;
            this.txt_suppname.Location = new System.Drawing.Point(22, 33);
            this.txt_suppname.Name = "txt_suppname";
            this.txt_suppname.Radius = 6;
            this.txt_suppname.Size = new System.Drawing.Size(135, 33);
            this.txt_suppname.TabIndex = 6;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this;
            // 
            // EditSupplier
            // 
            this.EditSupplier.Image = global::POS.Properties.Resources.Edit_100px;
            this.EditSupplier.Name = "EditSupplier";
            this.EditSupplier.Size = new System.Drawing.Size(153, 22);
            this.EditSupplier.Text = "Edit Supplier";
            this.EditSupplier.Click += new System.EventHandler(this.EditSupplier_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditSupplier,
            this.deleteSupplierToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(154, 48);
            // 
            // deleteSupplierToolStripMenuItem
            // 
            this.deleteSupplierToolStripMenuItem.Image = global::POS.Properties.Resources.delete_grey;
            this.deleteSupplierToolStripMenuItem.Name = "deleteSupplierToolStripMenuItem";
            this.deleteSupplierToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.deleteSupplierToolStripMenuItem.Text = "Delete Supplier";
            this.deleteSupplierToolStripMenuItem.Click += new System.EventHandler(this.deleteSupplierToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.flowLayoutPanel2);
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 413);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(897, 47);
            this.panel2.TabIndex = 13;
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btn_first);
            this.flowLayoutPanel1.Controls.Add(this.btn_prev);
            this.flowLayoutPanel1.Controls.Add(this.txtpageinfo);
            this.flowLayoutPanel1.Controls.Add(this.btn_next);
            this.flowLayoutPanel1.Controls.Add(this.btn_last);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(610, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(287, 47);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.dg_supp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 170);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(897, 243);
            this.panel1.TabIndex = 14;
            // 
            // SupplierListData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(897, 460);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.searchbox);
            this.Controls.Add(this.panelsearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SupplierListData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SupplierListData";
            this.Load += new System.EventHandler(this.SupplierListData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_supp)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panelsearch.ResumeLayout(false);
            this.panelsearch.PerformLayout();
            this.searchbox.ResumeLayout(false);
            this.searchbox.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_first)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_prev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_next)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_last)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ds_sales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.DataGridView dg_supp;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_exit;
        private Bunifu.Framework.UI.BunifuFlatButton btn_add_supplier;
        private System.Windows.Forms.Panel searchbox;
        private Bunifu.Framework.UI.BunifuFlatButton btnresetsearch;
        private Bunifu.Framework.UI.BunifuFlatButton btn_search;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_searchsalesnumber;
        private AltoControls.AltoTextBox txt_suppname;
        private System.Windows.Forms.Panel panelsearch;
        private System.Windows.Forms.BindingSource ds_sales;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.ToolStripMenuItem EditSupplier;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label txt_pagination;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Bunifu.Framework.UI.BunifuImageButton btn_first;
        private Bunifu.Framework.UI.BunifuImageButton btn_prev;
        private System.Windows.Forms.Label txtpageinfo;
        private Bunifu.Framework.UI.BunifuImageButton btn_next;
        private Bunifu.Framework.UI.BunifuImageButton btn_last;
        private System.Windows.Forms.ToolStripMenuItem deleteSupplierToolStripMenuItem;
    }
}