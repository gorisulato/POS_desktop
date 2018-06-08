namespace POS.Receiving
{
    partial class FormAddReceiveing
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
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel_detail = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dg_rc_detail = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_delete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_edit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_qty = new AltoControls.AltoNMUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_items_show = new AltoControls.AltoTextBox();
            this.btn_search_LOV = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_addItems = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txt_items_id = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btn_addDetails = new Bunifu.Framework.UI.BunifuFlatButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_clearPo = new Bunifu.Framework.UI.BunifuImageButton();
            this.txt_po_id = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_Po_show = new AltoControls.AltoTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_lov_po = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_clear = new Bunifu.Framework.UI.BunifuImageButton();
            this.txt_supplier_id = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_supplier_show = new AltoControls.AltoTextBox();
            this.lbl_customer = new System.Windows.Forms.Label();
            this.btn_LovSupp = new Bunifu.Framework.UI.BunifuImageButton();
            this.lbl_Rc_date = new System.Windows.Forms.Label();
            this.dt_Rcdate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.txt_RcNo = new AltoControls.AltoTextBox();
            this.lbl_rc_no = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Batal = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_exit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel_detail.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_rc_detail)).BeginInit();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_clearPo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_lov_po)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_clear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_LovSupp)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Edit Data Pembelian";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = global::POS.Properties.Resources.edit_white;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(163, 312);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.Teal;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(135, 33);
            this.bunifuFlatButton1.TabIndex = 212;
            this.bunifuFlatButton1.Text = "Edit Data Pembelian";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // panel_detail
            // 
            this.panel_detail.Controls.Add(this.groupBox2);
            this.panel_detail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_detail.Location = new System.Drawing.Point(0, 349);
            this.panel_detail.Name = "panel_detail";
            this.panel_detail.Size = new System.Drawing.Size(902, 265);
            this.panel_detail.TabIndex = 211;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.panel4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(902, 251);
            this.groupBox2.TabIndex = 207;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detail Penerimaan";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dg_rc_detail);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 83);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(896, 165);
            this.panel3.TabIndex = 1;
            // 
            // dg_rc_detail
            // 
            this.dg_rc_detail.AllowUserToAddRows = false;
            this.dg_rc_detail.AllowUserToDeleteRows = false;
            this.dg_rc_detail.AllowUserToOrderColumns = true;
            this.dg_rc_detail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_rc_detail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_rc_detail.Location = new System.Drawing.Point(0, 0);
            this.dg_rc_detail.Name = "dg_rc_detail";
            this.dg_rc_detail.Size = new System.Drawing.Size(896, 165);
            this.dg_rc_detail.TabIndex = 0;
            this.dg_rc_detail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_rc_detail_CellContentClick);
            this.dg_rc_detail.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_rc_detail_CellValueChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_delete);
            this.panel4.Controls.Add(this.btn_edit);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.txt_qty);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.txt_items_show);
            this.panel4.Controls.Add(this.btn_search_LOV);
            this.panel4.Controls.Add(this.btn_addItems);
            this.panel4.Controls.Add(this.txt_items_id);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 16);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(896, 67);
            this.panel4.TabIndex = 0;
            // 
            // btn_delete
            // 
            this.btn_delete.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_delete.BorderRadius = 0;
            this.btn_delete.ButtonText = "Hapus Item";
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.DisabledColor = System.Drawing.Color.Gray;
            this.btn_delete.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_delete.Iconimage = global::POS.Properties.Resources.delete_white;
            this.btn_delete.Iconimage_right = null;
            this.btn_delete.Iconimage_right_Selected = null;
            this.btn_delete.Iconimage_Selected = null;
            this.btn_delete.IconMarginLeft = 0;
            this.btn_delete.IconMarginRight = 0;
            this.btn_delete.IconRightVisible = true;
            this.btn_delete.IconRightZoom = 0D;
            this.btn_delete.IconVisible = true;
            this.btn_delete.IconZoom = 90D;
            this.btn_delete.IsTab = false;
            this.btn_delete.Location = new System.Drawing.Point(684, 27);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_delete.OnHovercolor = System.Drawing.Color.Teal;
            this.btn_delete.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_delete.selected = false;
            this.btn_delete.Size = new System.Drawing.Size(91, 33);
            this.btn_delete.TabIndex = 224;
            this.btn_delete.Text = "Hapus Item";
            this.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_delete.Textcolor = System.Drawing.Color.White;
            this.btn_delete.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_edit
            // 
            this.btn_edit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_edit.BorderRadius = 0;
            this.btn_edit.ButtonText = "Edit Item";
            this.btn_edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_edit.DisabledColor = System.Drawing.Color.Gray;
            this.btn_edit.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_edit.Iconimage = global::POS.Properties.Resources.edit_white;
            this.btn_edit.Iconimage_right = null;
            this.btn_edit.Iconimage_right_Selected = null;
            this.btn_edit.Iconimage_Selected = null;
            this.btn_edit.IconMarginLeft = 0;
            this.btn_edit.IconMarginRight = 0;
            this.btn_edit.IconRightVisible = true;
            this.btn_edit.IconRightZoom = 0D;
            this.btn_edit.IconVisible = true;
            this.btn_edit.IconZoom = 90D;
            this.btn_edit.IsTab = false;
            this.btn_edit.Location = new System.Drawing.Point(580, 27);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_edit.OnHovercolor = System.Drawing.Color.Teal;
            this.btn_edit.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_edit.selected = false;
            this.btn_edit.Size = new System.Drawing.Size(98, 33);
            this.btn_edit.TabIndex = 223;
            this.btn_edit.Text = "Edit Item";
            this.btn_edit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_edit.Textcolor = System.Drawing.Color.White;
            this.btn_edit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label3.Location = new System.Drawing.Point(370, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 17);
            this.label3.TabIndex = 220;
            this.label3.Text = "Qty";
            // 
            // txt_qty
            // 
            this.txt_qty.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.txt_qty.Location = new System.Drawing.Point(364, 27);
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.SignColor = System.Drawing.Color.White;
            this.txt_qty.Size = new System.Drawing.Size(89, 33);
            this.txt_qty.TabIndex = 219;
            this.txt_qty.Text = "altoNMUpDown1";
            this.txt_qty.Value = 0D;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label2.Location = new System.Drawing.Point(9, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 17);
            this.label2.TabIndex = 218;
            this.label2.Text = "Item Yang Akan Ditambah";
            // 
            // txt_items_show
            // 
            this.txt_items_show.ALG = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_items_show.BackColor = System.Drawing.Color.Transparent;
            this.txt_items_show.Br = System.Drawing.Color.White;
            this.txt_items_show.Enabled = false;
            this.txt_items_show.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.txt_items_show.ForeColor = System.Drawing.Color.DimGray;
            this.txt_items_show.Location = new System.Drawing.Point(3, 27);
            this.txt_items_show.Name = "txt_items_show";
            this.txt_items_show.Radius = 6;
            this.txt_items_show.Size = new System.Drawing.Size(210, 33);
            this.txt_items_show.TabIndex = 216;
            // 
            // btn_search_LOV
            // 
            this.btn_search_LOV.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_search_LOV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_search_LOV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_search_LOV.BorderRadius = 0;
            this.btn_search_LOV.ButtonText = "Cari Item";
            this.btn_search_LOV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search_LOV.DisabledColor = System.Drawing.Color.Gray;
            this.btn_search_LOV.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_search_LOV.Iconimage = global::POS.Properties.Resources.Search_white;
            this.btn_search_LOV.Iconimage_right = null;
            this.btn_search_LOV.Iconimage_right_Selected = null;
            this.btn_search_LOV.Iconimage_Selected = null;
            this.btn_search_LOV.IconMarginLeft = 0;
            this.btn_search_LOV.IconMarginRight = 0;
            this.btn_search_LOV.IconRightVisible = true;
            this.btn_search_LOV.IconRightZoom = 0D;
            this.btn_search_LOV.IconVisible = true;
            this.btn_search_LOV.IconZoom = 90D;
            this.btn_search_LOV.IsTab = false;
            this.btn_search_LOV.Location = new System.Drawing.Point(244, 27);
            this.btn_search_LOV.Name = "btn_search_LOV";
            this.btn_search_LOV.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_search_LOV.OnHovercolor = System.Drawing.Color.Teal;
            this.btn_search_LOV.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_search_LOV.selected = false;
            this.btn_search_LOV.Size = new System.Drawing.Size(107, 33);
            this.btn_search_LOV.TabIndex = 217;
            this.btn_search_LOV.Text = "Cari Item";
            this.btn_search_LOV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_search_LOV.Textcolor = System.Drawing.Color.White;
            this.btn_search_LOV.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_addItems
            // 
            this.btn_addItems.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_addItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_addItems.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_addItems.BorderRadius = 0;
            this.btn_addItems.ButtonText = "Tambah Item";
            this.btn_addItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addItems.DisabledColor = System.Drawing.Color.Gray;
            this.btn_addItems.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_addItems.Iconimage = global::POS.Properties.Resources.Add_white;
            this.btn_addItems.Iconimage_right = null;
            this.btn_addItems.Iconimage_right_Selected = null;
            this.btn_addItems.Iconimage_Selected = null;
            this.btn_addItems.IconMarginLeft = 0;
            this.btn_addItems.IconMarginRight = 0;
            this.btn_addItems.IconRightVisible = true;
            this.btn_addItems.IconRightZoom = 0D;
            this.btn_addItems.IconVisible = true;
            this.btn_addItems.IconZoom = 90D;
            this.btn_addItems.IsTab = false;
            this.btn_addItems.Location = new System.Drawing.Point(469, 27);
            this.btn_addItems.Name = "btn_addItems";
            this.btn_addItems.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_addItems.OnHovercolor = System.Drawing.Color.Teal;
            this.btn_addItems.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_addItems.selected = false;
            this.btn_addItems.Size = new System.Drawing.Size(105, 33);
            this.btn_addItems.TabIndex = 214;
            this.btn_addItems.Text = "Tambah Item";
            this.btn_addItems.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_addItems.Textcolor = System.Drawing.Color.White;
            this.btn_addItems.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txt_items_id
            // 
            this.txt_items_id.BorderColorFocused = System.Drawing.Color.Blue;
            this.txt_items_id.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_items_id.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txt_items_id.BorderThickness = 3;
            this.txt_items_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_items_id.Enabled = false;
            this.txt_items_id.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_items_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_items_id.isPassword = false;
            this.txt_items_id.Location = new System.Drawing.Point(218, 29);
            this.txt_items_id.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_items_id.Name = "txt_items_id";
            this.txt_items_id.Size = new System.Drawing.Size(10, 31);
            this.txt_items_id.TabIndex = 215;
            this.txt_items_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_items_id.Visible = false;
            // 
            // btn_addDetails
            // 
            this.btn_addDetails.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_addDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_addDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_addDetails.BorderRadius = 0;
            this.btn_addDetails.ButtonText = "(F3)Tambah Detail";
            this.btn_addDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addDetails.DisabledColor = System.Drawing.Color.Gray;
            this.btn_addDetails.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_addDetails.Iconimage = global::POS.Properties.Resources.Add_white;
            this.btn_addDetails.Iconimage_right = null;
            this.btn_addDetails.Iconimage_right_Selected = null;
            this.btn_addDetails.Iconimage_Selected = null;
            this.btn_addDetails.IconMarginLeft = 0;
            this.btn_addDetails.IconMarginRight = 0;
            this.btn_addDetails.IconRightVisible = true;
            this.btn_addDetails.IconRightZoom = 0D;
            this.btn_addDetails.IconVisible = true;
            this.btn_addDetails.IconZoom = 90D;
            this.btn_addDetails.IsTab = false;
            this.btn_addDetails.Location = new System.Drawing.Point(12, 312);
            this.btn_addDetails.Name = "btn_addDetails";
            this.btn_addDetails.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_addDetails.OnHovercolor = System.Drawing.Color.Teal;
            this.btn_addDetails.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_addDetails.selected = false;
            this.btn_addDetails.Size = new System.Drawing.Size(135, 33);
            this.btn_addDetails.TabIndex = 210;
            this.btn_addDetails.Text = "(F3)Tambah Detail";
            this.btn_addDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_addDetails.Textcolor = System.Drawing.Color.White;
            this.btn_addDetails.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addDetails.Click += new System.EventHandler(this.btn_addDetails_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_clearPo);
            this.groupBox1.Controls.Add(this.txt_po_id);
            this.groupBox1.Controls.Add(this.txt_Po_show);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_lov_po);
            this.groupBox1.Controls.Add(this.btn_clear);
            this.groupBox1.Controls.Add(this.txt_supplier_id);
            this.groupBox1.Controls.Add(this.txt_supplier_show);
            this.groupBox1.Controls.Add(this.lbl_customer);
            this.groupBox1.Controls.Add(this.btn_LovSupp);
            this.groupBox1.Controls.Add(this.lbl_Rc_date);
            this.groupBox1.Controls.Add(this.dt_Rcdate);
            this.groupBox1.Controls.Add(this.txt_RcNo);
            this.groupBox1.Controls.Add(this.lbl_rc_no);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(902, 252);
            this.groupBox1.TabIndex = 209;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Penerimaan";
            // 
            // btn_clearPo
            // 
            this.btn_clearPo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_clearPo.Image = global::POS.Properties.Resources.Cancel_white;
            this.btn_clearPo.ImageActive = null;
            this.btn_clearPo.Location = new System.Drawing.Point(572, 55);
            this.btn_clearPo.Name = "btn_clearPo";
            this.btn_clearPo.Size = new System.Drawing.Size(28, 31);
            this.btn_clearPo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_clearPo.TabIndex = 228;
            this.btn_clearPo.TabStop = false;
            this.btn_clearPo.Zoom = 10;
            // 
            // txt_po_id
            // 
            this.txt_po_id.BorderColorFocused = System.Drawing.Color.Blue;
            this.txt_po_id.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_po_id.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txt_po_id.BorderThickness = 3;
            this.txt_po_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_po_id.Enabled = false;
            this.txt_po_id.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_po_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_po_id.isPassword = false;
            this.txt_po_id.Location = new System.Drawing.Point(520, 55);
            this.txt_po_id.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_po_id.Name = "txt_po_id";
            this.txt_po_id.Size = new System.Drawing.Size(10, 31);
            this.txt_po_id.TabIndex = 224;
            this.txt_po_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_po_id.Visible = false;
            // 
            // txt_Po_show
            // 
            this.txt_Po_show.ALG = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Po_show.BackColor = System.Drawing.Color.Transparent;
            this.txt_Po_show.Br = System.Drawing.Color.White;
            this.txt_Po_show.Enabled = false;
            this.txt_Po_show.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.txt_Po_show.ForeColor = System.Drawing.Color.DimGray;
            this.txt_Po_show.Location = new System.Drawing.Point(324, 55);
            this.txt_Po_show.Name = "txt_Po_show";
            this.txt_Po_show.Radius = 6;
            this.txt_Po_show.Size = new System.Drawing.Size(198, 33);
            this.txt_Po_show.TabIndex = 225;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label1.Location = new System.Drawing.Point(330, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 226;
            this.label1.Text = "Nomor Pembelian";
            // 
            // btn_lov_po
            // 
            this.btn_lov_po.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_lov_po.Image = global::POS.Properties.Resources.guest_list_white;
            this.btn_lov_po.ImageActive = null;
            this.btn_lov_po.Location = new System.Drawing.Point(527, 55);
            this.btn_lov_po.Name = "btn_lov_po";
            this.btn_lov_po.Size = new System.Drawing.Size(49, 31);
            this.btn_lov_po.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_lov_po.TabIndex = 227;
            this.btn_lov_po.TabStop = false;
            this.btn_lov_po.Zoom = 10;
            this.btn_lov_po.Click += new System.EventHandler(this.btn_lov_po_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_clear.Image = global::POS.Properties.Resources.Cancel_white;
            this.btn_clear.ImageActive = null;
            this.btn_clear.Location = new System.Drawing.Point(260, 192);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(28, 31);
            this.btn_clear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_clear.TabIndex = 223;
            this.btn_clear.TabStop = false;
            this.btn_clear.Zoom = 10;
            // 
            // txt_supplier_id
            // 
            this.txt_supplier_id.BorderColorFocused = System.Drawing.Color.Blue;
            this.txt_supplier_id.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_supplier_id.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txt_supplier_id.BorderThickness = 3;
            this.txt_supplier_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_supplier_id.Enabled = false;
            this.txt_supplier_id.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_supplier_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_supplier_id.isPassword = false;
            this.txt_supplier_id.Location = new System.Drawing.Point(208, 192);
            this.txt_supplier_id.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_supplier_id.Name = "txt_supplier_id";
            this.txt_supplier_id.Size = new System.Drawing.Size(10, 31);
            this.txt_supplier_id.TabIndex = 219;
            this.txt_supplier_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_supplier_id.Visible = false;
            // 
            // txt_supplier_show
            // 
            this.txt_supplier_show.ALG = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_supplier_show.BackColor = System.Drawing.Color.Transparent;
            this.txt_supplier_show.Br = System.Drawing.Color.White;
            this.txt_supplier_show.Enabled = false;
            this.txt_supplier_show.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.txt_supplier_show.ForeColor = System.Drawing.Color.DimGray;
            this.txt_supplier_show.Location = new System.Drawing.Point(12, 192);
            this.txt_supplier_show.Name = "txt_supplier_show";
            this.txt_supplier_show.Radius = 6;
            this.txt_supplier_show.Size = new System.Drawing.Size(198, 33);
            this.txt_supplier_show.TabIndex = 220;
            // 
            // lbl_customer
            // 
            this.lbl_customer.AutoSize = true;
            this.lbl_customer.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lbl_customer.Location = new System.Drawing.Point(18, 165);
            this.lbl_customer.Name = "lbl_customer";
            this.lbl_customer.Size = new System.Drawing.Size(56, 17);
            this.lbl_customer.TabIndex = 221;
            this.lbl_customer.Text = "Supplier";
            // 
            // btn_LovSupp
            // 
            this.btn_LovSupp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_LovSupp.Image = global::POS.Properties.Resources.guest_list_white;
            this.btn_LovSupp.ImageActive = null;
            this.btn_LovSupp.Location = new System.Drawing.Point(215, 192);
            this.btn_LovSupp.Name = "btn_LovSupp";
            this.btn_LovSupp.Size = new System.Drawing.Size(49, 31);
            this.btn_LovSupp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_LovSupp.TabIndex = 222;
            this.btn_LovSupp.TabStop = false;
            this.btn_LovSupp.Zoom = 10;
            this.btn_LovSupp.Click += new System.EventHandler(this.btn_LovSupp_Click);
            // 
            // lbl_Rc_date
            // 
            this.lbl_Rc_date.AutoSize = true;
            this.lbl_Rc_date.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lbl_Rc_date.Location = new System.Drawing.Point(18, 98);
            this.lbl_Rc_date.Name = "lbl_Rc_date";
            this.lbl_Rc_date.Size = new System.Drawing.Size(126, 17);
            this.lbl_Rc_date.TabIndex = 4;
            this.lbl_Rc_date.Text = "Tanggal Penerimaan";
            // 
            // dt_Rcdate
            // 
            this.dt_Rcdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dt_Rcdate.BorderRadius = 0;
            this.dt_Rcdate.ForeColor = System.Drawing.Color.White;
            this.dt_Rcdate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dt_Rcdate.FormatCustom = null;
            this.dt_Rcdate.Location = new System.Drawing.Point(12, 126);
            this.dt_Rcdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dt_Rcdate.Name = "dt_Rcdate";
            this.dt_Rcdate.Size = new System.Drawing.Size(196, 33);
            this.dt_Rcdate.TabIndex = 5;
            this.dt_Rcdate.Value = new System.DateTime(2018, 5, 29, 1, 20, 4, 627);
            // 
            // txt_RcNo
            // 
            this.txt_RcNo.ALG = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_RcNo.BackColor = System.Drawing.Color.Transparent;
            this.txt_RcNo.Br = System.Drawing.Color.White;
            this.txt_RcNo.Enabled = false;
            this.txt_RcNo.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_RcNo.ForeColor = System.Drawing.Color.DimGray;
            this.txt_RcNo.Location = new System.Drawing.Point(12, 55);
            this.txt_RcNo.Name = "txt_RcNo";
            this.txt_RcNo.Radius = 6;
            this.txt_RcNo.Size = new System.Drawing.Size(196, 33);
            this.txt_RcNo.TabIndex = 3;
            // 
            // lbl_rc_no
            // 
            this.lbl_rc_no.AutoSize = true;
            this.lbl_rc_no.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lbl_rc_no.Location = new System.Drawing.Point(18, 28);
            this.lbl_rc_no.Name = "lbl_rc_no";
            this.lbl_rc_no.Size = new System.Drawing.Size(122, 17);
            this.lbl_rc_no.TabIndex = 2;
            this.lbl_rc_no.Text = "Nomor Penerimaan";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::POS.Properties.Resources.upper;
            this.panel1.Controls.Add(this.btn_Batal);
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(902, 54);
            this.panel1.TabIndex = 208;
            // 
            // btn_Batal
            // 
            this.btn_Batal.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Batal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Batal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Batal.BorderRadius = 0;
            this.btn_Batal.ButtonText = "Batal";
            this.btn_Batal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Batal.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Batal.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Batal.Iconimage = global::POS.Properties.Resources.Cancel_white;
            this.btn_Batal.Iconimage_right = null;
            this.btn_Batal.Iconimage_right_Selected = null;
            this.btn_Batal.Iconimage_Selected = null;
            this.btn_Batal.IconMarginLeft = 0;
            this.btn_Batal.IconMarginRight = 0;
            this.btn_Batal.IconRightVisible = true;
            this.btn_Batal.IconRightZoom = 0D;
            this.btn_Batal.IconVisible = true;
            this.btn_Batal.IconZoom = 90D;
            this.btn_Batal.IsTab = false;
            this.btn_Batal.Location = new System.Drawing.Point(633, 6);
            this.btn_Batal.Name = "btn_Batal";
            this.btn_Batal.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Batal.OnHovercolor = System.Drawing.Color.Teal;
            this.btn_Batal.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Batal.selected = false;
            this.btn_Batal.Size = new System.Drawing.Size(128, 42);
            this.btn_Batal.TabIndex = 6;
            this.btn_Batal.Text = "Batal";
            this.btn_Batal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Batal.Textcolor = System.Drawing.Color.White;
            this.btn_Batal.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Batal.Click += new System.EventHandler(this.btn_Batal_Click);
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
            this.btn_exit.Location = new System.Drawing.Point(767, 6);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_exit.OnHovercolor = System.Drawing.Color.Teal;
            this.btn_exit.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_exit.selected = false;
            this.btn_exit.Size = new System.Drawing.Size(128, 42);
            this.btn_exit.TabIndex = 7;
            this.btn_exit.Text = "Keluar";
            this.btn_exit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exit.Textcolor = System.Drawing.Color.White;
            this.btn_exit.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // FormAddReceiveing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(902, 614);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.panel_detail);
            this.Controls.Add(this.btn_addDetails);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAddReceiveing";
            this.Text = "FormAddReceiveing";
            this.Load += new System.EventHandler(this.FormAddReceiveing_Load);
            this.panel_detail.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_rc_detail)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_clearPo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_lov_po)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_clear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_LovSupp)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.Panel panel_detail;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dg_rc_detail;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuFlatButton btn_delete;
        private Bunifu.Framework.UI.BunifuFlatButton btn_edit;
        private System.Windows.Forms.Label label3;
        private AltoControls.AltoNMUpDown txt_qty;
        private System.Windows.Forms.Label label2;
        private AltoControls.AltoTextBox txt_items_show;
        private Bunifu.Framework.UI.BunifuFlatButton btn_search_LOV;
        private Bunifu.Framework.UI.BunifuFlatButton btn_addItems;
        public Bunifu.Framework.UI.BunifuMetroTextbox txt_items_id;
        private Bunifu.Framework.UI.BunifuFlatButton btn_addDetails;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuImageButton btn_clear;
        public Bunifu.Framework.UI.BunifuMetroTextbox txt_supplier_id;
        private AltoControls.AltoTextBox txt_supplier_show;
        private System.Windows.Forms.Label lbl_customer;
        private Bunifu.Framework.UI.BunifuImageButton btn_LovSupp;
        private System.Windows.Forms.Label lbl_Rc_date;
        private Bunifu.Framework.UI.BunifuDatepicker dt_Rcdate;
        private AltoControls.AltoTextBox txt_RcNo;
        private System.Windows.Forms.Label lbl_rc_no;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Batal;
        private Bunifu.Framework.UI.BunifuFlatButton btn_exit;
        private Bunifu.Framework.UI.BunifuImageButton btn_clearPo;
        public Bunifu.Framework.UI.BunifuMetroTextbox txt_po_id;
        private AltoControls.AltoTextBox txt_Po_show;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton btn_lov_po;
    }
}