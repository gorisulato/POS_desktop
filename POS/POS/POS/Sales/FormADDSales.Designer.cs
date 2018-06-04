namespace POS
{
    partial class FormADDSales
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
            this.Detail = new System.Windows.Forms.Panel();
            this.dg_detail = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_delete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_edit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_discount = new AltoControls.AltoNMUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_qty = new AltoControls.AltoNMUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_items_show = new AltoControls.AltoTextBox();
            this.btn_search_LOV = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_addItems = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txt_items_id = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.upper_panel = new System.Windows.Forms.Panel();
            this.btn_Batal = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_exit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.ds_salesdetail = new System.Windows.Forms.BindingSource(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.lbl_sales_Number = new System.Windows.Forms.Label();
            this.txt_salesNumber = new AltoControls.AltoTextBox();
            this.lbl_Sales_Date = new System.Windows.Forms.Label();
            this.dt_salesdate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.lbl_total = new System.Windows.Forms.Label();
            this.total_sales = new AltoControls.AltoTextBox();
            this.btn_addDetails = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txt_customer_id = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_customer_show = new AltoControls.AltoTextBox();
            this.lbl_customer = new System.Windows.Forms.Label();
            this.btn_LovCustomer = new Bunifu.Framework.UI.BunifuImageButton();
            this.txt_sales_discount = new AltoControls.AltoNMUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.Main = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_clear = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_update_master = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cb_idpayment = new Bunifu.Framework.UI.BunifuDropdown();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_paymentType = new Bunifu.Framework.UI.BunifuDropdown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_change = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_pay = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txt_change = new AltoControls.AltoTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_payment = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_paymentamount = new AltoControls.AltoTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Detail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_detail)).BeginInit();
            this.panel1.SuspendLayout();
            this.upper_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds_salesdetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_LovCustomer)).BeginInit();
            this.Main.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_clear)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Detail
            // 
            this.Detail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Detail.Controls.Add(this.dg_detail);
            this.Detail.Controls.Add(this.panel1);
            this.Detail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Detail.Location = new System.Drawing.Point(0, 453);
            this.Detail.Name = "Detail";
            this.Detail.Size = new System.Drawing.Size(902, 297);
            this.Detail.TabIndex = 1;
            // 
            // dg_detail
            // 
            this.dg_detail.AllowUserToAddRows = false;
            this.dg_detail.AllowUserToDeleteRows = false;
            this.dg_detail.AllowUserToOrderColumns = true;
            this.dg_detail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_detail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_detail.Location = new System.Drawing.Point(0, 74);
            this.dg_detail.Name = "dg_detail";
            this.dg_detail.ReadOnly = true;
            this.dg_detail.Size = new System.Drawing.Size(900, 221);
            this.dg_detail.TabIndex = 1;
            this.dg_detail.SelectionChanged += new System.EventHandler(this.dg_detail_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Controls.Add(this.btn_edit);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_discount);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_qty);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_items_show);
            this.panel1.Controls.Add(this.btn_search_LOV);
            this.panel1.Controls.Add(this.btn_addItems);
            this.panel1.Controls.Add(this.txt_items_id);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 74);
            this.panel1.TabIndex = 0;
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
            this.btn_delete.Location = new System.Drawing.Point(802, 25);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_delete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_delete.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_delete.selected = false;
            this.btn_delete.Size = new System.Drawing.Size(91, 33);
            this.btn_delete.TabIndex = 213;
            this.btn_delete.Text = "Hapus Item";
            this.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_delete.Textcolor = System.Drawing.Color.White;
            this.btn_delete.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
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
            this.btn_edit.Location = new System.Drawing.Point(698, 25);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_edit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_edit.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_edit.selected = false;
            this.btn_edit.Size = new System.Drawing.Size(98, 33);
            this.btn_edit.TabIndex = 212;
            this.btn_edit.Text = "Edit Item";
            this.btn_edit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_edit.Textcolor = System.Drawing.Color.White;
            this.btn_edit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label4.Location = new System.Drawing.Point(473, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 211;
            this.label4.Text = "Discount";
            // 
            // txt_discount
            // 
            this.txt_discount.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.txt_discount.Location = new System.Drawing.Point(467, 25);
            this.txt_discount.Name = "txt_discount";
            this.txt_discount.SignColor = System.Drawing.Color.White;
            this.txt_discount.Size = new System.Drawing.Size(89, 33);
            this.txt_discount.TabIndex = 210;
            this.txt_discount.Text = "altoNMUpDown2";
            this.txt_discount.Value = 0D;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label3.Location = new System.Drawing.Point(378, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 17);
            this.label3.TabIndex = 209;
            this.label3.Text = "Qty";
            // 
            // txt_qty
            // 
            this.txt_qty.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.txt_qty.Location = new System.Drawing.Point(372, 25);
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.SignColor = System.Drawing.Color.White;
            this.txt_qty.Size = new System.Drawing.Size(89, 33);
            this.txt_qty.TabIndex = 208;
            this.txt_qty.Text = "altoNMUpDown1";
            this.txt_qty.Value = 0D;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label2.Location = new System.Drawing.Point(17, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 17);
            this.label2.TabIndex = 207;
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
            this.txt_items_show.Location = new System.Drawing.Point(11, 25);
            this.txt_items_show.Name = "txt_items_show";
            this.txt_items_show.Radius = 6;
            this.txt_items_show.Size = new System.Drawing.Size(210, 33);
            this.txt_items_show.TabIndex = 205;
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
            this.btn_search_LOV.Location = new System.Drawing.Point(252, 25);
            this.btn_search_LOV.Name = "btn_search_LOV";
            this.btn_search_LOV.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_search_LOV.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_search_LOV.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_search_LOV.selected = false;
            this.btn_search_LOV.Size = new System.Drawing.Size(107, 33);
            this.btn_search_LOV.TabIndex = 206;
            this.btn_search_LOV.Text = "Cari Item";
            this.btn_search_LOV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_search_LOV.Textcolor = System.Drawing.Color.White;
            this.btn_search_LOV.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search_LOV.Click += new System.EventHandler(this.btn_search_LOV_Click);
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
            this.btn_addItems.Location = new System.Drawing.Point(587, 25);
            this.btn_addItems.Name = "btn_addItems";
            this.btn_addItems.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_addItems.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_addItems.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_addItems.selected = false;
            this.btn_addItems.Size = new System.Drawing.Size(105, 33);
            this.btn_addItems.TabIndex = 203;
            this.btn_addItems.Text = "Tambah Item";
            this.btn_addItems.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_addItems.Textcolor = System.Drawing.Color.White;
            this.btn_addItems.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addItems.Click += new System.EventHandler(this.btn_addItems_Click);
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
            this.txt_items_id.Location = new System.Drawing.Point(226, 27);
            this.txt_items_id.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_items_id.Name = "txt_items_id";
            this.txt_items_id.Size = new System.Drawing.Size(10, 31);
            this.txt_items_id.TabIndex = 204;
            this.txt_items_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_items_id.Visible = false;
            // 
            // upper_panel
            // 
            this.upper_panel.BackgroundImage = global::POS.Properties.Resources.upper;
            this.upper_panel.Controls.Add(this.btn_Batal);
            this.upper_panel.Controls.Add(this.btn_exit);
            this.upper_panel.Controls.Add(this.label1);
            this.upper_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.upper_panel.Location = new System.Drawing.Point(0, 0);
            this.upper_panel.Name = "upper_panel";
            this.upper_panel.Size = new System.Drawing.Size(902, 66);
            this.upper_panel.TabIndex = 0;
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
            this.btn_Batal.Location = new System.Drawing.Point(632, 12);
            this.btn_Batal.Name = "btn_Batal";
            this.btn_Batal.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Batal.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Batal.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Batal.selected = false;
            this.btn_Batal.Size = new System.Drawing.Size(128, 42);
            this.btn_Batal.TabIndex = 4;
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
            this.btn_exit.Location = new System.Drawing.Point(766, 12);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_exit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_exit.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_exit.selected = false;
            this.btn_exit.Size = new System.Drawing.Size(128, 42);
            this.btn_exit.TabIndex = 5;
            this.btn_exit.Text = "Keluar";
            this.btn_exit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exit.Textcolor = System.Drawing.Color.White;
            this.btn_exit.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Penjualan";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.upper_panel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // lbl_sales_Number
            // 
            this.lbl_sales_Number.AutoSize = true;
            this.lbl_sales_Number.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lbl_sales_Number.Location = new System.Drawing.Point(12, 28);
            this.lbl_sales_Number.Name = "lbl_sales_Number";
            this.lbl_sales_Number.Size = new System.Drawing.Size(109, 17);
            this.lbl_sales_Number.TabIndex = 0;
            this.lbl_sales_Number.Text = "Nomor Penjualan";
            // 
            // txt_salesNumber
            // 
            this.txt_salesNumber.ALG = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_salesNumber.BackColor = System.Drawing.Color.Transparent;
            this.txt_salesNumber.Br = System.Drawing.Color.White;
            this.txt_salesNumber.Enabled = false;
            this.txt_salesNumber.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_salesNumber.ForeColor = System.Drawing.Color.DimGray;
            this.txt_salesNumber.Location = new System.Drawing.Point(6, 50);
            this.txt_salesNumber.Name = "txt_salesNumber";
            this.txt_salesNumber.Radius = 6;
            this.txt_salesNumber.Size = new System.Drawing.Size(196, 33);
            this.txt_salesNumber.TabIndex = 1;
            // 
            // lbl_Sales_Date
            // 
            this.lbl_Sales_Date.AutoSize = true;
            this.lbl_Sales_Date.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lbl_Sales_Date.Location = new System.Drawing.Point(12, 104);
            this.lbl_Sales_Date.Name = "lbl_Sales_Date";
            this.lbl_Sales_Date.Size = new System.Drawing.Size(113, 17);
            this.lbl_Sales_Date.TabIndex = 2;
            this.lbl_Sales_Date.Text = "Tanggal Penjualan";
            // 
            // dt_salesdate
            // 
            this.dt_salesdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dt_salesdate.BorderRadius = 0;
            this.dt_salesdate.ForeColor = System.Drawing.Color.White;
            this.dt_salesdate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dt_salesdate.FormatCustom = null;
            this.dt_salesdate.Location = new System.Drawing.Point(4, 132);
            this.dt_salesdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dt_salesdate.Name = "dt_salesdate";
            this.dt_salesdate.Size = new System.Drawing.Size(196, 33);
            this.dt_salesdate.TabIndex = 3;
            this.dt_salesdate.Value = new System.DateTime(2018, 5, 29, 1, 20, 4, 627);
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lbl_total.Location = new System.Drawing.Point(303, 104);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(95, 17);
            this.lbl_total.TabIndex = 4;
            this.lbl_total.Text = "Total Penjualan";
            // 
            // total_sales
            // 
            this.total_sales.ALG = System.Windows.Forms.HorizontalAlignment.Left;
            this.total_sales.BackColor = System.Drawing.Color.Transparent;
            this.total_sales.Br = System.Drawing.Color.White;
            this.total_sales.Enabled = false;
            this.total_sales.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.total_sales.ForeColor = System.Drawing.Color.DimGray;
            this.total_sales.Location = new System.Drawing.Point(297, 132);
            this.total_sales.Name = "total_sales";
            this.total_sales.Radius = 6;
            this.total_sales.Size = new System.Drawing.Size(164, 33);
            this.total_sales.TabIndex = 5;
            // 
            // btn_addDetails
            // 
            this.btn_addDetails.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_addDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_addDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_addDetails.BorderRadius = 0;
            this.btn_addDetails.ButtonText = "Tambah Detail";
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
            this.btn_addDetails.Location = new System.Drawing.Point(10, 346);
            this.btn_addDetails.Name = "btn_addDetails";
            this.btn_addDetails.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_addDetails.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_addDetails.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_addDetails.selected = false;
            this.btn_addDetails.Size = new System.Drawing.Size(107, 33);
            this.btn_addDetails.TabIndex = 204;
            this.btn_addDetails.Text = "Tambah Detail";
            this.btn_addDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_addDetails.Textcolor = System.Drawing.Color.White;
            this.btn_addDetails.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addDetails.Load += new System.EventHandler(this.btn_addDetails_Load);
            this.btn_addDetails.Click += new System.EventHandler(this.btn_addDetails_Click);
            // 
            // txt_customer_id
            // 
            this.txt_customer_id.BorderColorFocused = System.Drawing.Color.Blue;
            this.txt_customer_id.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_customer_id.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txt_customer_id.BorderThickness = 3;
            this.txt_customer_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_customer_id.Enabled = false;
            this.txt_customer_id.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_customer_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_customer_id.isPassword = false;
            this.txt_customer_id.Location = new System.Drawing.Point(200, 195);
            this.txt_customer_id.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_customer_id.Name = "txt_customer_id";
            this.txt_customer_id.Size = new System.Drawing.Size(10, 31);
            this.txt_customer_id.TabIndex = 208;
            this.txt_customer_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_customer_id.Visible = false;
            // 
            // txt_customer_show
            // 
            this.txt_customer_show.ALG = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_customer_show.BackColor = System.Drawing.Color.Transparent;
            this.txt_customer_show.Br = System.Drawing.Color.White;
            this.txt_customer_show.Enabled = false;
            this.txt_customer_show.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.txt_customer_show.ForeColor = System.Drawing.Color.DimGray;
            this.txt_customer_show.Location = new System.Drawing.Point(4, 195);
            this.txt_customer_show.Name = "txt_customer_show";
            this.txt_customer_show.Radius = 6;
            this.txt_customer_show.Size = new System.Drawing.Size(198, 33);
            this.txt_customer_show.TabIndex = 209;
            // 
            // lbl_customer
            // 
            this.lbl_customer.AutoSize = true;
            this.lbl_customer.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lbl_customer.Location = new System.Drawing.Point(12, 172);
            this.lbl_customer.Name = "lbl_customer";
            this.lbl_customer.Size = new System.Drawing.Size(64, 17);
            this.lbl_customer.TabIndex = 210;
            this.lbl_customer.Text = "Customer";
            // 
            // btn_LovCustomer
            // 
            this.btn_LovCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_LovCustomer.Image = global::POS.Properties.Resources.guest_list_white;
            this.btn_LovCustomer.ImageActive = null;
            this.btn_LovCustomer.Location = new System.Drawing.Point(207, 195);
            this.btn_LovCustomer.Name = "btn_LovCustomer";
            this.btn_LovCustomer.Size = new System.Drawing.Size(49, 31);
            this.btn_LovCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_LovCustomer.TabIndex = 211;
            this.btn_LovCustomer.TabStop = false;
            this.btn_LovCustomer.Zoom = 10;
            this.btn_LovCustomer.Click += new System.EventHandler(this.btn_LovCustomer_Click);
            // 
            // txt_sales_discount
            // 
            this.txt_sales_discount.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.txt_sales_discount.Location = new System.Drawing.Point(297, 50);
            this.txt_sales_discount.Name = "txt_sales_discount";
            this.txt_sales_discount.SignColor = System.Drawing.Color.White;
            this.txt_sales_discount.Size = new System.Drawing.Size(164, 33);
            this.txt_sales_discount.TabIndex = 212;
            this.txt_sales_discount.Text = "altoNMUpDown2";
            this.txt_sales_discount.Value = 0D;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label5.Location = new System.Drawing.Point(303, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 17);
            this.label5.TabIndex = 213;
            this.label5.Text = "Discount Penjualan (%)";
            // 
            // Main
            // 
            this.Main.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Main.Controls.Add(this.btn_addDetails);
            this.Main.Controls.Add(this.groupBox2);
            this.Main.Controls.Add(this.groupBox1);
            this.Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main.Location = new System.Drawing.Point(0, 66);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(902, 387);
            this.Main.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_clear);
            this.groupBox2.Controls.Add(this.btn_update_master);
            this.groupBox2.Controls.Add(this.cb_idpayment);
            this.groupBox2.Controls.Add(this.txt_customer_id);
            this.groupBox2.Controls.Add(this.txt_salesNumber);
            this.groupBox2.Controls.Add(this.txt_customer_show);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lbl_customer);
            this.groupBox2.Controls.Add(this.lbl_sales_Number);
            this.groupBox2.Controls.Add(this.total_sales);
            this.groupBox2.Controls.Add(this.cb_paymentType);
            this.groupBox2.Controls.Add(this.btn_LovCustomer);
            this.groupBox2.Controls.Add(this.lbl_Sales_Date);
            this.groupBox2.Controls.Add(this.lbl_total);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_sales_discount);
            this.groupBox2.Controls.Add(this.dt_salesdate);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.groupBox2.Location = new System.Drawing.Point(10, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(470, 337);
            this.groupBox2.TabIndex = 217;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Penjualan";
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_clear.Image = global::POS.Properties.Resources.Cancel_white;
            this.btn_clear.ImageActive = null;
            this.btn_clear.Location = new System.Drawing.Point(252, 195);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(28, 31);
            this.btn_clear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_clear.TabIndex = 218;
            this.btn_clear.TabStop = false;
            this.btn_clear.Zoom = 10;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_update_master
            // 
            this.btn_update_master.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_update_master.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_update_master.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_update_master.BorderRadius = 0;
            this.btn_update_master.ButtonText = "Perbarui Data Penjualan";
            this.btn_update_master.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update_master.DisabledColor = System.Drawing.Color.Gray;
            this.btn_update_master.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_update_master.Iconimage = global::POS.Properties.Resources.edit_white;
            this.btn_update_master.Iconimage_right = null;
            this.btn_update_master.Iconimage_right_Selected = null;
            this.btn_update_master.Iconimage_Selected = null;
            this.btn_update_master.IconMarginLeft = 0;
            this.btn_update_master.IconMarginRight = 0;
            this.btn_update_master.IconRightVisible = true;
            this.btn_update_master.IconRightZoom = 0D;
            this.btn_update_master.IconVisible = true;
            this.btn_update_master.IconZoom = 90D;
            this.btn_update_master.IsTab = false;
            this.btn_update_master.Location = new System.Drawing.Point(297, 269);
            this.btn_update_master.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_update_master.Name = "btn_update_master";
            this.btn_update_master.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_update_master.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_update_master.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_update_master.selected = false;
            this.btn_update_master.Size = new System.Drawing.Size(153, 45);
            this.btn_update_master.TabIndex = 217;
            this.btn_update_master.Text = "Perbarui Data Penjualan";
            this.btn_update_master.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_update_master.Textcolor = System.Drawing.Color.White;
            this.btn_update_master.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update_master.Click += new System.EventHandler(this.btn_update_master_Click);
            // 
            // cb_idpayment
            // 
            this.cb_idpayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cb_idpayment.BorderRadius = 3;
            this.cb_idpayment.DisabledColor = System.Drawing.Color.Gray;
            this.cb_idpayment.ForeColor = System.Drawing.Color.White;
            this.cb_idpayment.Items = new string[0];
            this.cb_idpayment.Location = new System.Drawing.Point(208, 292);
            this.cb_idpayment.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cb_idpayment.Name = "cb_idpayment";
            this.cb_idpayment.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cb_idpayment.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cb_idpayment.selectedIndex = -1;
            this.cb_idpayment.Size = new System.Drawing.Size(10, 10);
            this.cb_idpayment.TabIndex = 216;
            this.cb_idpayment.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label6.Location = new System.Drawing.Point(12, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 17);
            this.label6.TabIndex = 215;
            this.label6.Text = "Metode Pembayaran";
            // 
            // cb_paymentType
            // 
            this.cb_paymentType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cb_paymentType.BorderRadius = 3;
            this.cb_paymentType.DisabledColor = System.Drawing.Color.Gray;
            this.cb_paymentType.ForeColor = System.Drawing.Color.White;
            this.cb_paymentType.Items = new string[0];
            this.cb_paymentType.Location = new System.Drawing.Point(4, 269);
            this.cb_paymentType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_paymentType.Name = "cb_paymentType";
            this.cb_paymentType.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cb_paymentType.onHoverColor = System.Drawing.Color.Teal;
            this.cb_paymentType.selectedIndex = -1;
            this.cb_paymentType.Size = new System.Drawing.Size(198, 33);
            this.cb_paymentType.TabIndex = 214;
            this.cb_paymentType.onItemSelected += new System.EventHandler(this.cb_paymentType_onItemSelected);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_change);
            this.groupBox1.Controls.Add(this.btn_pay);
            this.groupBox1.Controls.Add(this.txt_change);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lbl_payment);
            this.groupBox1.Controls.Add(this.txt_paymentamount);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.groupBox1.Location = new System.Drawing.Point(497, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 337);
            this.groupBox1.TabIndex = 216;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pembayaran";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lbl_change
            // 
            this.lbl_change.AutoSize = true;
            this.lbl_change.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_change.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_change.Location = new System.Drawing.Point(17, 195);
            this.lbl_change.Name = "lbl_change";
            this.lbl_change.Size = new System.Drawing.Size(244, 54);
            this.lbl_change.TabIndex = 13;
            this.lbl_change.Text = "lorem ipsum";
            // 
            // btn_pay
            // 
            this.btn_pay.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_pay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_pay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_pay.BorderRadius = 0;
            this.btn_pay.ButtonText = "Bayar";
            this.btn_pay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pay.DisabledColor = System.Drawing.Color.Gray;
            this.btn_pay.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_pay.Iconimage = global::POS.Properties.Resources.checkout_white;
            this.btn_pay.Iconimage_right = null;
            this.btn_pay.Iconimage_right_Selected = null;
            this.btn_pay.Iconimage_Selected = null;
            this.btn_pay.IconMarginLeft = 0;
            this.btn_pay.IconMarginRight = 0;
            this.btn_pay.IconRightVisible = true;
            this.btn_pay.IconRightZoom = 0D;
            this.btn_pay.IconVisible = true;
            this.btn_pay.IconZoom = 90D;
            this.btn_pay.IsTab = false;
            this.btn_pay.Location = new System.Drawing.Point(267, 269);
            this.btn_pay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_pay.Name = "btn_pay";
            this.btn_pay.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_pay.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_pay.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_pay.selected = false;
            this.btn_pay.Size = new System.Drawing.Size(113, 45);
            this.btn_pay.TabIndex = 12;
            this.btn_pay.Text = "Bayar";
            this.btn_pay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_pay.Textcolor = System.Drawing.Color.White;
            this.btn_pay.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pay.Click += new System.EventHandler(this.btn_pay_Click);
            // 
            // txt_change
            // 
            this.txt_change.ALG = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_change.BackColor = System.Drawing.Color.Transparent;
            this.txt_change.Br = System.Drawing.Color.White;
            this.txt_change.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_change.ForeColor = System.Drawing.Color.DimGray;
            this.txt_change.Location = new System.Drawing.Point(353, 172);
            this.txt_change.Name = "txt_change";
            this.txt_change.Radius = 6;
            this.txt_change.Size = new System.Drawing.Size(16, 47);
            this.txt_change.TabIndex = 11;
            this.txt_change.TabStop = false;
            this.txt_change.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label9.Location = new System.Drawing.Point(21, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "Kembalian";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label8.Location = new System.Drawing.Point(12, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Total Yang Harus Dibayarkan";
            // 
            // lbl_payment
            // 
            this.lbl_payment.AutoSize = true;
            this.lbl_payment.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_payment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_payment.Location = new System.Drawing.Point(6, 45);
            this.lbl_payment.Name = "lbl_payment";
            this.lbl_payment.Size = new System.Drawing.Size(244, 54);
            this.lbl_payment.TabIndex = 8;
            this.lbl_payment.Text = "lorem ipsum";
            // 
            // txt_paymentamount
            // 
            this.txt_paymentamount.ALG = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_paymentamount.BackColor = System.Drawing.Color.Transparent;
            this.txt_paymentamount.Br = System.Drawing.Color.White;
            this.txt_paymentamount.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_paymentamount.ForeColor = System.Drawing.Color.DimGray;
            this.txt_paymentamount.Location = new System.Drawing.Point(15, 132);
            this.txt_paymentamount.Name = "txt_paymentamount";
            this.txt_paymentamount.Radius = 6;
            this.txt_paymentamount.Size = new System.Drawing.Size(164, 33);
            this.txt_paymentamount.TabIndex = 7;
            this.txt_paymentamount.TextChanged += new System.EventHandler(this.txt_paymentamount_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label7.Location = new System.Drawing.Point(21, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Jumlah Pembayaran";
            // 
            // FormADDSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(902, 750);
            this.Controls.Add(this.Main);
            this.Controls.Add(this.Detail);
            this.Controls.Add(this.upper_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormADDSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormADDSales";
            this.Load += new System.EventHandler(this.FormADDSales_Load);
            this.Detail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_detail)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.upper_panel.ResumeLayout(false);
            this.upper_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds_salesdetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_LovCustomer)).EndInit();
            this.Main.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_clear)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel upper_panel;
        private System.Windows.Forms.Panel Detail;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Batal;
        private Bunifu.Framework.UI.BunifuFlatButton btn_exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource ds_salesdetail;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton btn_search_LOV;
        private AltoControls.AltoTextBox txt_items_show;
        public Bunifu.Framework.UI.BunifuMetroTextbox txt_items_id;
        private Bunifu.Framework.UI.BunifuFlatButton btn_addItems;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.DataGridView dg_detail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private AltoControls.AltoNMUpDown txt_discount;
        private System.Windows.Forms.Label label3;
        private AltoControls.AltoNMUpDown txt_qty;
        private System.Windows.Forms.Panel Main;
        private System.Windows.Forms.Label label5;
        private AltoControls.AltoNMUpDown txt_sales_discount;
        private Bunifu.Framework.UI.BunifuImageButton btn_LovCustomer;
        private System.Windows.Forms.Label lbl_customer;
        private AltoControls.AltoTextBox txt_customer_show;
        public Bunifu.Framework.UI.BunifuMetroTextbox txt_customer_id;
        private Bunifu.Framework.UI.BunifuFlatButton btn_addDetails;
        private AltoControls.AltoTextBox total_sales;
        private System.Windows.Forms.Label lbl_total;
        private Bunifu.Framework.UI.BunifuDatepicker dt_salesdate;
        private System.Windows.Forms.Label lbl_Sales_Date;
        private AltoControls.AltoTextBox txt_salesNumber;
        private System.Windows.Forms.Label lbl_sales_Number;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuDropdown cb_paymentType;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_payment;
        private AltoControls.AltoTextBox txt_paymentamount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private AltoControls.AltoTextBox txt_change;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuDropdown cb_idpayment;
        private Bunifu.Framework.UI.BunifuFlatButton btn_pay;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_change;
        private Bunifu.Framework.UI.BunifuFlatButton btn_delete;
        private Bunifu.Framework.UI.BunifuFlatButton btn_edit;
        private Bunifu.Framework.UI.BunifuFlatButton btn_update_master;
        private Bunifu.Framework.UI.BunifuImageButton btn_clear;
    }
}