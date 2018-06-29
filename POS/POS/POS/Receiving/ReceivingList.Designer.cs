namespace POS.Receiving
{
    partial class ReceivingList
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
            this.ds_sales = new System.Windows.Forms.BindingSource(this.components);
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dg_Rc = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_exit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_add_Rc = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_prev = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_next = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_last = new Bunifu.Framework.UI.BunifuImageButton();
            this.searchbox = new System.Windows.Forms.Panel();
            this.btnresetsearch = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_searchPO = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dt_podatesearch = new Bunifu.Framework.UI.BunifuDatepicker();
            this.lbl_search_poDate = new System.Windows.Forms.Label();
            this.lbl_searchsalesnumber = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_search_ponumber = new AltoControls.AltoTextBox();
            this.btn_first = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtpageinfo = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.txt_pagination = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bunifuDragControl3 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelsearch = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ds_sales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Rc)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_prev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_next)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_last)).BeginInit();
            this.searchbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_first)).BeginInit();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panelsearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuImageButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.bunifuImageButton1.Image = global::POS.Properties.Resources.chevron_white;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(898, 0);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(28, 30);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 11;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dg_Rc);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(926, 258);
            this.panel1.TabIndex = 14;
            // 
            // dg_Rc
            // 
            this.dg_Rc.AllowUserToAddRows = false;
            this.dg_Rc.AllowUserToDeleteRows = false;
            this.dg_Rc.AllowUserToOrderColumns = true;
            this.dg_Rc.BackgroundColor = System.Drawing.Color.White;
            this.dg_Rc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Rc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_Rc.Location = new System.Drawing.Point(0, 0);
            this.dg_Rc.Name = "dg_Rc";
            this.dg_Rc.ReadOnly = true;
            this.dg_Rc.Size = new System.Drawing.Size(926, 258);
            this.dg_Rc.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Teal;
            this.panel4.Controls.Add(this.btn_exit);
            this.panel4.Controls.Add(this.btn_add_Rc);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 40);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(926, 56);
            this.panel4.TabIndex = 13;
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
            this.btn_exit.Location = new System.Drawing.Point(795, 10);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_exit.OnHovercolor = System.Drawing.Color.Teal;
            this.btn_exit.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_exit.selected = false;
            this.btn_exit.Size = new System.Drawing.Size(128, 40);
            this.btn_exit.TabIndex = 6;
            this.btn_exit.Text = "Keluar";
            this.btn_exit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exit.Textcolor = System.Drawing.Color.White;
            this.btn_exit.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_add_Rc
            // 
            this.btn_add_Rc.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_add_Rc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_add_Rc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_add_Rc.BorderRadius = 0;
            this.btn_add_Rc.ButtonText = "Penerimaan Baru";
            this.btn_add_Rc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_Rc.DisabledColor = System.Drawing.Color.Gray;
            this.btn_add_Rc.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_add_Rc.Iconimage = global::POS.Properties.Resources.Positive;
            this.btn_add_Rc.Iconimage_right = null;
            this.btn_add_Rc.Iconimage_right_Selected = null;
            this.btn_add_Rc.Iconimage_Selected = null;
            this.btn_add_Rc.IconMarginLeft = 0;
            this.btn_add_Rc.IconMarginRight = 0;
            this.btn_add_Rc.IconRightVisible = true;
            this.btn_add_Rc.IconRightZoom = 0D;
            this.btn_add_Rc.IconVisible = true;
            this.btn_add_Rc.IconZoom = 90D;
            this.btn_add_Rc.IsTab = false;
            this.btn_add_Rc.Location = new System.Drawing.Point(651, 10);
            this.btn_add_Rc.Name = "btn_add_Rc";
            this.btn_add_Rc.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_add_Rc.OnHovercolor = System.Drawing.Color.Teal;
            this.btn_add_Rc.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_add_Rc.selected = false;
            this.btn_add_Rc.Size = new System.Drawing.Size(138, 40);
            this.btn_add_Rc.TabIndex = 5;
            this.btn_add_Rc.Text = "Penerimaan Baru";
            this.btn_add_Rc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add_Rc.Textcolor = System.Drawing.Color.White;
            this.btn_add_Rc.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_Rc.Click += new System.EventHandler(this.btn_add_Rc_Click);
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
            // searchbox
            // 
            this.searchbox.BackColor = System.Drawing.Color.Teal;
            this.searchbox.Controls.Add(this.btnresetsearch);
            this.searchbox.Controls.Add(this.btn_searchPO);
            this.searchbox.Controls.Add(this.dt_podatesearch);
            this.searchbox.Controls.Add(this.lbl_search_poDate);
            this.searchbox.Controls.Add(this.lbl_searchsalesnumber);
            this.searchbox.Controls.Add(this.txt_search_ponumber);
            this.searchbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchbox.Location = new System.Drawing.Point(0, 30);
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(926, 10);
            this.searchbox.TabIndex = 12;
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
            this.btnresetsearch.Location = new System.Drawing.Point(546, 32);
            this.btnresetsearch.Name = "btnresetsearch";
            this.btnresetsearch.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnresetsearch.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnresetsearch.OnHoverTextColor = System.Drawing.Color.White;
            this.btnresetsearch.selected = false;
            this.btnresetsearch.Size = new System.Drawing.Size(138, 34);
            this.btnresetsearch.TabIndex = 11;
            this.btnresetsearch.Text = "Reset";
            this.btnresetsearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnresetsearch.Textcolor = System.Drawing.Color.White;
            this.btnresetsearch.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnresetsearch.Click += new System.EventHandler(this.btnresetsearch_Click);
            // 
            // btn_searchPO
            // 
            this.btn_searchPO.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_searchPO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_searchPO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_searchPO.BorderRadius = 0;
            this.btn_searchPO.ButtonText = "Search";
            this.btn_searchPO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_searchPO.DisabledColor = System.Drawing.Color.Gray;
            this.btn_searchPO.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_searchPO.Iconimage = global::POS.Properties.Resources.Search_white;
            this.btn_searchPO.Iconimage_right = null;
            this.btn_searchPO.Iconimage_right_Selected = null;
            this.btn_searchPO.Iconimage_Selected = null;
            this.btn_searchPO.IconMarginLeft = 0;
            this.btn_searchPO.IconMarginRight = 0;
            this.btn_searchPO.IconRightVisible = true;
            this.btn_searchPO.IconRightZoom = 0D;
            this.btn_searchPO.IconVisible = true;
            this.btn_searchPO.IconZoom = 50D;
            this.btn_searchPO.IsTab = false;
            this.btn_searchPO.Location = new System.Drawing.Point(402, 32);
            this.btn_searchPO.Name = "btn_searchPO";
            this.btn_searchPO.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_searchPO.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_searchPO.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_searchPO.selected = false;
            this.btn_searchPO.Size = new System.Drawing.Size(138, 34);
            this.btn_searchPO.TabIndex = 10;
            this.btn_searchPO.Text = "Search";
            this.btn_searchPO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_searchPO.Textcolor = System.Drawing.Color.White;
            this.btn_searchPO.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // dt_podatesearch
            // 
            this.dt_podatesearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dt_podatesearch.BorderRadius = 0;
            this.dt_podatesearch.ForeColor = System.Drawing.Color.White;
            this.dt_podatesearch.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dt_podatesearch.FormatCustom = null;
            this.dt_podatesearch.Location = new System.Drawing.Point(186, 32);
            this.dt_podatesearch.Name = "dt_podatesearch";
            this.dt_podatesearch.Size = new System.Drawing.Size(172, 34);
            this.dt_podatesearch.TabIndex = 9;
            this.dt_podatesearch.Value = new System.DateTime(2018, 5, 29, 0, 9, 11, 242);
            // 
            // lbl_search_poDate
            // 
            this.lbl_search_poDate.AutoSize = true;
            this.lbl_search_poDate.ForeColor = System.Drawing.Color.White;
            this.lbl_search_poDate.Location = new System.Drawing.Point(183, 16);
            this.lbl_search_poDate.Name = "lbl_search_poDate";
            this.lbl_search_poDate.Size = new System.Drawing.Size(98, 13);
            this.lbl_search_poDate.TabIndex = 8;
            this.lbl_search_poDate.Text = "Tanggal Pembelian";
            // 
            // lbl_searchsalesnumber
            // 
            this.lbl_searchsalesnumber.AutoSize = true;
            this.lbl_searchsalesnumber.ForeColor = System.Drawing.Color.White;
            this.lbl_searchsalesnumber.Location = new System.Drawing.Point(29, 16);
            this.lbl_searchsalesnumber.Name = "lbl_searchsalesnumber";
            this.lbl_searchsalesnumber.Size = new System.Drawing.Size(97, 13);
            this.lbl_searchsalesnumber.TabIndex = 7;
            this.lbl_searchsalesnumber.Text = "Nomor Penerimaan";
            // 
            // txt_search_ponumber
            // 
            this.txt_search_ponumber.ALG = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_search_ponumber.BackColor = System.Drawing.Color.Transparent;
            this.txt_search_ponumber.Br = System.Drawing.Color.White;
            this.txt_search_ponumber.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_search_ponumber.ForeColor = System.Drawing.Color.DimGray;
            this.txt_search_ponumber.Location = new System.Drawing.Point(22, 33);
            this.txt_search_ponumber.Name = "txt_search_ponumber";
            this.txt_search_ponumber.Radius = 6;
            this.txt_search_ponumber.Size = new System.Drawing.Size(135, 33);
            this.txt_search_ponumber.TabIndex = 6;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.flowLayoutPanel2);
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 354);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(926, 47);
            this.panel2.TabIndex = 11;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.txtpageinfo);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(399, 47);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // txtpageinfo
            // 
            this.txtpageinfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtpageinfo.AutoSize = true;
            this.txtpageinfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpageinfo.ForeColor = System.Drawing.Color.White;
            this.txtpageinfo.Location = new System.Drawing.Point(3, 0);
            this.txtpageinfo.Name = "txtpageinfo";
            this.txtpageinfo.Size = new System.Drawing.Size(45, 17);
            this.txtpageinfo.TabIndex = 0;
            this.txtpageinfo.Text = "label1";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btn_first);
            this.flowLayoutPanel1.Controls.Add(this.btn_prev);
            this.flowLayoutPanel1.Controls.Add(this.txt_pagination);
            this.flowLayoutPanel1.Controls.Add(this.btn_next);
            this.flowLayoutPanel1.Controls.Add(this.btn_last);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(430, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(496, 47);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // txt_pagination
            // 
            this.txt_pagination.AutoSize = true;
            this.txt_pagination.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pagination.ForeColor = System.Drawing.Color.White;
            this.txt_pagination.Location = new System.Drawing.Point(85, 0);
            this.txt_pagination.Name = "txt_pagination";
            this.txt_pagination.Size = new System.Drawing.Size(45, 17);
            this.txt_pagination.TabIndex = 5;
            this.txt_pagination.Text = "label1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(95, 26);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::POS.Properties.Resources.Edit_50px;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // bunifuDragControl3
            // 
            this.bunifuDragControl3.Fixed = true;
            this.bunifuDragControl3.Horizontal = true;
            this.bunifuDragControl3.TargetControl = this.panel4;
            this.bunifuDragControl3.Vertical = true;
            // 
            // panelsearch
            // 
            this.panelsearch.BackColor = System.Drawing.Color.Teal;
            this.panelsearch.Controls.Add(this.bunifuImageButton1);
            this.panelsearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelsearch.Location = new System.Drawing.Point(0, 0);
            this.panelsearch.Name = "panelsearch";
            this.panelsearch.Size = new System.Drawing.Size(926, 30);
            this.panelsearch.TabIndex = 10;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelsearch;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.searchbox;
            this.bunifuDragControl2.Vertical = true;
            // 
            // ReceivingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 401);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.searchbox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelsearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReceivingList";
            this.Text = "Receiving";
            this.Load += new System.EventHandler(this.Receiving_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ds_sales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_Rc)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_prev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_next)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_last)).EndInit();
            this.searchbox.ResumeLayout(false);
            this.searchbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_first)).EndInit();
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panelsearch.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource ds_sales;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dg_Rc;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuFlatButton btn_exit;
        private Bunifu.Framework.UI.BunifuFlatButton btn_add_Rc;
        private Bunifu.Framework.UI.BunifuImageButton btn_prev;
        private Bunifu.Framework.UI.BunifuImageButton btn_next;
        private Bunifu.Framework.UI.BunifuImageButton btn_last;
        private System.Windows.Forms.Panel searchbox;
        private Bunifu.Framework.UI.BunifuFlatButton btnresetsearch;
        private Bunifu.Framework.UI.BunifuFlatButton btn_searchPO;
        private Bunifu.Framework.UI.BunifuDatepicker dt_podatesearch;
        private System.Windows.Forms.Label lbl_search_poDate;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_searchsalesnumber;
        private AltoControls.AltoTextBox txt_search_ponumber;
        private Bunifu.Framework.UI.BunifuImageButton btn_first;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label txtpageinfo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label txt_pagination;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl3;
        private System.Windows.Forms.Panel panelsearch;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
    }
}