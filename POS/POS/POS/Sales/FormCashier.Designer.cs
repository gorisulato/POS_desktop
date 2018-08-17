namespace POS.Sales
{
    partial class FormCashier
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
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_addItems = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_qty = new AltoControls.AltoNMUpDown();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_items_show = new AltoControls.AltoTextBox();
            this.txt_items_id = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_salesNumber = new AltoControls.AltoTextBox();
            this.lbl_sales_Number = new System.Windows.Forms.Label();
            this.lbl_Sales_Date = new System.Windows.Forms.Label();
            this.dt_salesdate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_payment_afterdiscount = new AltoControls.AltoTextBox();
            this.txt_sales_discount = new AltoControls.AltoTextBox();
            this.total_sales = new AltoControls.AltoTextBox();
            this.btn_pay = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lbl_change = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_change = new AltoControls.AltoTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_payment = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_paymentamount = new AltoControls.AltoTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cb_paymentType = new Bunifu.Framework.UI.BunifuDropdown();
            this.txt_approvalcode = new AltoControls.AltoTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_idpayment = new Bunifu.Framework.UI.BunifuDropdown();
            this.txt_cardno = new AltoControls.AltoTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dg_detail = new System.Windows.Forms.DataGridView();
            this.upper_panel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_save = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_print = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Batal = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_exit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_detail)).BeginInit();
            this.upper_panel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.groupBox1);
            this.flowLayoutPanel2.Controls.Add(this.groupBox2);
            this.flowLayoutPanel2.Controls.Add(this.groupBox3);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 66);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(894, 531);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_addItems);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_qty);
            this.groupBox1.Controls.Add(this.bunifuImageButton1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_items_show);
            this.groupBox1.Controls.Add(this.txt_items_id);
            this.groupBox1.Controls.Add(this.txt_salesNumber);
            this.groupBox1.Controls.Add(this.lbl_sales_Number);
            this.groupBox1.Controls.Add(this.lbl_Sales_Date);
            this.groupBox1.Controls.Add(this.dt_salesdate);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 307);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Penjualan";
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
            this.btn_addItems.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btn_addItems.IconZoom = 60D;
            this.btn_addItems.IsTab = false;
            this.btn_addItems.Location = new System.Drawing.Point(227, 206);
            this.btn_addItems.Margin = new System.Windows.Forms.Padding(5);
            this.btn_addItems.Name = "btn_addItems";
            this.btn_addItems.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_addItems.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_addItems.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_addItems.selected = false;
            this.btn_addItems.Size = new System.Drawing.Size(128, 25);
            this.btn_addItems.TabIndex = 214;
            this.btn_addItems.Text = "Tambah Item";
            this.btn_addItems.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_addItems.Textcolor = System.Drawing.Color.White;
            this.btn_addItems.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addItems.Click += new System.EventHandler(this.btn_addItems_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label3.Location = new System.Drawing.Point(18, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 17);
            this.label3.TabIndex = 213;
            this.label3.Text = "Qty";
            // 
            // txt_qty
            // 
            this.txt_qty.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.txt_qty.Location = new System.Drawing.Point(12, 206);
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.SignColor = System.Drawing.Color.White;
            this.txt_qty.Size = new System.Drawing.Size(196, 25);
            this.txt_qty.TabIndex = 212;
            this.txt_qty.Text = "altoNMUpDown1";
            this.txt_qty.Value = 0D;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuImageButton1.Image = global::POS.Properties.Resources.Search_white;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(214, 153);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(43, 25);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 211;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label2.Location = new System.Drawing.Point(18, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 210;
            this.label2.Text = "Item";
            // 
            // txt_items_show
            // 
            this.txt_items_show.ALG = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_items_show.BackColor = System.Drawing.Color.Transparent;
            this.txt_items_show.Br = System.Drawing.Color.White;
            this.txt_items_show.Enabled = false;
            this.txt_items_show.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.txt_items_show.ForeColor = System.Drawing.Color.DimGray;
            this.txt_items_show.Location = new System.Drawing.Point(12, 153);
            this.txt_items_show.Name = "txt_items_show";
            this.txt_items_show.Radius = 6;
            this.txt_items_show.Size = new System.Drawing.Size(196, 25);
            this.txt_items_show.TabIndex = 209;
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
            this.txt_items_id.Location = new System.Drawing.Point(262, 153);
            this.txt_items_id.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_items_id.Name = "txt_items_id";
            this.txt_items_id.Size = new System.Drawing.Size(10, 32);
            this.txt_items_id.TabIndex = 208;
            this.txt_items_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_items_id.Visible = false;
            // 
            // txt_salesNumber
            // 
            this.txt_salesNumber.ALG = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_salesNumber.BackColor = System.Drawing.Color.Transparent;
            this.txt_salesNumber.Br = System.Drawing.Color.White;
            this.txt_salesNumber.Enabled = false;
            this.txt_salesNumber.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_salesNumber.ForeColor = System.Drawing.Color.DimGray;
            this.txt_salesNumber.Location = new System.Drawing.Point(12, 49);
            this.txt_salesNumber.Name = "txt_salesNumber";
            this.txt_salesNumber.Radius = 6;
            this.txt_salesNumber.Size = new System.Drawing.Size(196, 24);
            this.txt_salesNumber.TabIndex = 5;
            // 
            // lbl_sales_Number
            // 
            this.lbl_sales_Number.AutoSize = true;
            this.lbl_sales_Number.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lbl_sales_Number.Location = new System.Drawing.Point(18, 27);
            this.lbl_sales_Number.Name = "lbl_sales_Number";
            this.lbl_sales_Number.Size = new System.Drawing.Size(109, 17);
            this.lbl_sales_Number.TabIndex = 4;
            this.lbl_sales_Number.Text = "Nomor Penjualan";
            // 
            // lbl_Sales_Date
            // 
            this.lbl_Sales_Date.AutoSize = true;
            this.lbl_Sales_Date.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lbl_Sales_Date.Location = new System.Drawing.Point(20, 79);
            this.lbl_Sales_Date.Name = "lbl_Sales_Date";
            this.lbl_Sales_Date.Size = new System.Drawing.Size(113, 17);
            this.lbl_Sales_Date.TabIndex = 6;
            this.lbl_Sales_Date.Text = "Tanggal Penjualan";
            // 
            // dt_salesdate
            // 
            this.dt_salesdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dt_salesdate.BorderRadius = 0;
            this.dt_salesdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_salesdate.ForeColor = System.Drawing.Color.White;
            this.dt_salesdate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dt_salesdate.FormatCustom = null;
            this.dt_salesdate.Location = new System.Drawing.Point(12, 101);
            this.dt_salesdate.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dt_salesdate.Name = "dt_salesdate";
            this.dt_salesdate.Size = new System.Drawing.Size(196, 24);
            this.dt_salesdate.TabIndex = 7;
            this.dt_salesdate.Value = new System.DateTime(2018, 5, 29, 1, 20, 4, 627);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_payment_afterdiscount);
            this.groupBox2.Controls.Add(this.txt_sales_discount);
            this.groupBox2.Controls.Add(this.total_sales);
            this.groupBox2.Controls.Add(this.btn_pay);
            this.groupBox2.Controls.Add(this.lbl_change);
            this.groupBox2.Controls.Add(this.txt_change);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lbl_payment);
            this.groupBox2.Controls.Add(this.txt_paymentamount);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.cb_paymentType);
            this.groupBox2.Controls.Add(this.txt_approvalcode);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cb_idpayment);
            this.groupBox2.Controls.Add(this.txt_cardno);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(372, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(504, 307);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Payment";
            // 
            // txt_payment_afterdiscount
            // 
            this.txt_payment_afterdiscount.ALG = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_payment_afterdiscount.BackColor = System.Drawing.Color.Transparent;
            this.txt_payment_afterdiscount.Br = System.Drawing.Color.White;
            this.txt_payment_afterdiscount.Enabled = false;
            this.txt_payment_afterdiscount.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_payment_afterdiscount.ForeColor = System.Drawing.Color.DimGray;
            this.txt_payment_afterdiscount.Location = new System.Drawing.Point(194, 260);
            this.txt_payment_afterdiscount.Name = "txt_payment_afterdiscount";
            this.txt_payment_afterdiscount.Radius = 6;
            this.txt_payment_afterdiscount.Size = new System.Drawing.Size(10, 29);
            this.txt_payment_afterdiscount.TabIndex = 237;
            // 
            // txt_sales_discount
            // 
            this.txt_sales_discount.ALG = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_sales_discount.BackColor = System.Drawing.Color.Transparent;
            this.txt_sales_discount.Br = System.Drawing.Color.White;
            this.txt_sales_discount.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_sales_discount.ForeColor = System.Drawing.Color.DimGray;
            this.txt_sales_discount.Location = new System.Drawing.Point(8, 213);
            this.txt_sales_discount.Name = "txt_sales_discount";
            this.txt_sales_discount.Radius = 6;
            this.txt_sales_discount.Size = new System.Drawing.Size(196, 25);
            this.txt_sales_discount.TabIndex = 236;
            this.txt_sales_discount.TextChanged += new System.EventHandler(this.txt_sales_discount_TextChanged);
            this.txt_sales_discount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sales_discount_KeyPress);
            // 
            // total_sales
            // 
            this.total_sales.ALG = System.Windows.Forms.HorizontalAlignment.Left;
            this.total_sales.BackColor = System.Drawing.Color.Transparent;
            this.total_sales.Br = System.Drawing.Color.White;
            this.total_sales.Enabled = false;
            this.total_sales.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.total_sales.ForeColor = System.Drawing.Color.DimGray;
            this.total_sales.Location = new System.Drawing.Point(8, 256);
            this.total_sales.Name = "total_sales";
            this.total_sales.Radius = 6;
            this.total_sales.Size = new System.Drawing.Size(164, 33);
            this.total_sales.TabIndex = 235;
            this.total_sales.TextChanged += new System.EventHandler(this.total_sales_TextChanged);
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
            this.btn_pay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_pay.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_pay.Iconimage = global::POS.Properties.Resources.Money_48px;
            this.btn_pay.Iconimage_right = null;
            this.btn_pay.Iconimage_right_Selected = null;
            this.btn_pay.Iconimage_Selected = null;
            this.btn_pay.IconMarginLeft = 0;
            this.btn_pay.IconMarginRight = 0;
            this.btn_pay.IconRightVisible = true;
            this.btn_pay.IconRightZoom = 0D;
            this.btn_pay.IconVisible = true;
            this.btn_pay.IconZoom = 70D;
            this.btn_pay.IsTab = false;
            this.btn_pay.Location = new System.Drawing.Point(352, 231);
            this.btn_pay.Name = "btn_pay";
            this.btn_pay.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_pay.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_pay.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_pay.selected = false;
            this.btn_pay.Size = new System.Drawing.Size(113, 42);
            this.btn_pay.TabIndex = 234;
            this.btn_pay.Text = "Bayar";
            this.btn_pay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_pay.Textcolor = System.Drawing.Color.White;
            this.btn_pay.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pay.Click += new System.EventHandler(this.btn_pay_Click);
            // 
            // lbl_change
            // 
            this.lbl_change.AutoSize = true;
            this.lbl_change.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_change.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_change.Location = new System.Drawing.Point(228, 161);
            this.lbl_change.Name = "lbl_change";
            this.lbl_change.Size = new System.Drawing.Size(244, 54);
            this.lbl_change.TabIndex = 233;
            this.lbl_change.Text = "lorem ipsum";
            // 
            // txt_change
            // 
            this.txt_change.ALG = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_change.BackColor = System.Drawing.Color.Transparent;
            this.txt_change.Br = System.Drawing.Color.White;
            this.txt_change.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_change.ForeColor = System.Drawing.Color.DimGray;
            this.txt_change.Location = new System.Drawing.Point(422, 110);
            this.txt_change.Name = "txt_change";
            this.txt_change.Radius = 6;
            this.txt_change.Size = new System.Drawing.Size(16, 47);
            this.txt_change.TabIndex = 232;
            this.txt_change.TabStop = false;
            this.txt_change.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label9.Location = new System.Drawing.Point(238, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 17);
            this.label9.TabIndex = 231;
            this.label9.Text = "Kembalian";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label8.Location = new System.Drawing.Point(227, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 17);
            this.label8.TabIndex = 230;
            this.label8.Text = "Total Yang Harus Dibayarkan";
            // 
            // lbl_payment
            // 
            this.lbl_payment.AutoSize = true;
            this.lbl_payment.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_payment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_payment.Location = new System.Drawing.Point(221, 26);
            this.lbl_payment.Name = "lbl_payment";
            this.lbl_payment.Size = new System.Drawing.Size(244, 54);
            this.lbl_payment.TabIndex = 229;
            this.lbl_payment.Text = "lorem ipsum";
            // 
            // txt_paymentamount
            // 
            this.txt_paymentamount.ALG = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_paymentamount.BackColor = System.Drawing.Color.Transparent;
            this.txt_paymentamount.Br = System.Drawing.Color.White;
            this.txt_paymentamount.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_paymentamount.ForeColor = System.Drawing.Color.DimGray;
            this.txt_paymentamount.Location = new System.Drawing.Point(230, 104);
            this.txt_paymentamount.Name = "txt_paymentamount";
            this.txt_paymentamount.Radius = 6;
            this.txt_paymentamount.Size = new System.Drawing.Size(164, 25);
            this.txt_paymentamount.TabIndex = 228;
            this.txt_paymentamount.TextChanged += new System.EventHandler(this.txt_paymentamount_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label7.Location = new System.Drawing.Point(234, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 17);
            this.label7.TabIndex = 227;
            this.label7.Text = "Jumlah Pembayaran";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label11.Location = new System.Drawing.Point(16, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 17);
            this.label11.TabIndex = 226;
            this.label11.Text = "Approval Code";
            // 
            // cb_paymentType
            // 
            this.cb_paymentType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cb_paymentType.BorderRadius = 3;
            this.cb_paymentType.DisabledColor = System.Drawing.Color.Gray;
            this.cb_paymentType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_paymentType.ForeColor = System.Drawing.Color.White;
            this.cb_paymentType.Items = new string[0];
            this.cb_paymentType.Location = new System.Drawing.Point(8, 49);
            this.cb_paymentType.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cb_paymentType.Name = "cb_paymentType";
            this.cb_paymentType.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cb_paymentType.onHoverColor = System.Drawing.Color.Teal;
            this.cb_paymentType.selectedIndex = -1;
            this.cb_paymentType.Size = new System.Drawing.Size(196, 24);
            this.cb_paymentType.TabIndex = 217;
            this.cb_paymentType.onItemSelected += new System.EventHandler(this.cb_paymentType_onItemSelected);
            // 
            // txt_approvalcode
            // 
            this.txt_approvalcode.ALG = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_approvalcode.BackColor = System.Drawing.Color.Transparent;
            this.txt_approvalcode.Br = System.Drawing.Color.White;
            this.txt_approvalcode.Enabled = false;
            this.txt_approvalcode.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.txt_approvalcode.ForeColor = System.Drawing.Color.DimGray;
            this.txt_approvalcode.Location = new System.Drawing.Point(8, 161);
            this.txt_approvalcode.Name = "txt_approvalcode";
            this.txt_approvalcode.Radius = 6;
            this.txt_approvalcode.Size = new System.Drawing.Size(196, 25);
            this.txt_approvalcode.TabIndex = 225;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label6.Location = new System.Drawing.Point(17, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 17);
            this.label6.TabIndex = 218;
            this.label6.Text = "Metode Pembayaran";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label5.Location = new System.Drawing.Point(16, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 17);
            this.label5.TabIndex = 224;
            this.label5.Text = "Discount Penjualan (%)";
            // 
            // cb_idpayment
            // 
            this.cb_idpayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cb_idpayment.BorderRadius = 3;
            this.cb_idpayment.DisabledColor = System.Drawing.Color.Gray;
            this.cb_idpayment.ForeColor = System.Drawing.Color.White;
            this.cb_idpayment.Items = new string[0];
            this.cb_idpayment.Location = new System.Drawing.Point(187, 29);
            this.cb_idpayment.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.cb_idpayment.Name = "cb_idpayment";
            this.cb_idpayment.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cb_idpayment.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cb_idpayment.selectedIndex = -1;
            this.cb_idpayment.Size = new System.Drawing.Size(17, 16);
            this.cb_idpayment.TabIndex = 219;
            this.cb_idpayment.Visible = false;
            // 
            // txt_cardno
            // 
            this.txt_cardno.ALG = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_cardno.BackColor = System.Drawing.Color.Transparent;
            this.txt_cardno.Br = System.Drawing.Color.White;
            this.txt_cardno.Enabled = false;
            this.txt_cardno.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_cardno.ForeColor = System.Drawing.Color.DimGray;
            this.txt_cardno.Location = new System.Drawing.Point(8, 104);
            this.txt_cardno.Name = "txt_cardno";
            this.txt_cardno.Radius = 6;
            this.txt_cardno.Size = new System.Drawing.Size(196, 25);
            this.txt_cardno.TabIndex = 221;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label10.Location = new System.Drawing.Point(16, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 17);
            this.label10.TabIndex = 222;
            this.label10.Text = "Nomor Kartu";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dg_detail);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(3, 316);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(873, 170);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data Items";
            // 
            // dg_detail
            // 
            this.dg_detail.AllowUserToAddRows = false;
            this.dg_detail.AllowUserToDeleteRows = false;
            this.dg_detail.AllowUserToOrderColumns = true;
            this.dg_detail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_detail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_detail.Location = new System.Drawing.Point(3, 25);
            this.dg_detail.Name = "dg_detail";
            this.dg_detail.ReadOnly = true;
            this.dg_detail.Size = new System.Drawing.Size(867, 142);
            this.dg_detail.TabIndex = 3;
            // 
            // upper_panel
            // 
            this.upper_panel.BackgroundImage = global::POS.Properties.Resources.upper;
            this.upper_panel.Controls.Add(this.flowLayoutPanel1);
            this.upper_panel.Controls.Add(this.label1);
            this.upper_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.upper_panel.Location = new System.Drawing.Point(0, 0);
            this.upper_panel.Name = "upper_panel";
            this.upper_panel.Size = new System.Drawing.Size(894, 66);
            this.upper_panel.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.btn_save);
            this.flowLayoutPanel1.Controls.Add(this.btn_print);
            this.flowLayoutPanel1.Controls.Add(this.btn_Batal);
            this.flowLayoutPanel1.Controls.Add(this.btn_exit);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(432, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(462, 66);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // btn_save
            // 
            this.btn_save.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_save.BorderRadius = 0;
            this.btn_save.ButtonText = "Simpan";
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.DisabledColor = System.Drawing.Color.Gray;
            this.btn_save.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_save.Iconimage = global::POS.Properties.Resources.save_white;
            this.btn_save.Iconimage_right = null;
            this.btn_save.Iconimage_right_Selected = null;
            this.btn_save.Iconimage_Selected = null;
            this.btn_save.IconMarginLeft = 0;
            this.btn_save.IconMarginRight = 0;
            this.btn_save.IconRightVisible = true;
            this.btn_save.IconRightZoom = 0D;
            this.btn_save.IconVisible = true;
            this.btn_save.IconZoom = 90D;
            this.btn_save.IsTab = false;
            this.btn_save.Location = new System.Drawing.Point(3, 3);
            this.btn_save.Name = "btn_save";
            this.btn_save.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_save.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_save.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_save.selected = false;
            this.btn_save.Size = new System.Drawing.Size(102, 42);
            this.btn_save.TabIndex = 7;
            this.btn_save.Text = "Simpan";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Textcolor = System.Drawing.Color.White;
            this.btn_save.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_print
            // 
            this.btn_print.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_print.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_print.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_print.BorderRadius = 0;
            this.btn_print.ButtonText = "Cetak Faktur";
            this.btn_print.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_print.DisabledColor = System.Drawing.Color.Gray;
            this.btn_print.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_print.Iconimage = global::POS.Properties.Resources.Print_100px;
            this.btn_print.Iconimage_right = null;
            this.btn_print.Iconimage_right_Selected = null;
            this.btn_print.Iconimage_Selected = null;
            this.btn_print.IconMarginLeft = 0;
            this.btn_print.IconMarginRight = 0;
            this.btn_print.IconRightVisible = true;
            this.btn_print.IconRightZoom = 0D;
            this.btn_print.IconVisible = true;
            this.btn_print.IconZoom = 90D;
            this.btn_print.IsTab = false;
            this.btn_print.Location = new System.Drawing.Point(111, 3);
            this.btn_print.Name = "btn_print";
            this.btn_print.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_print.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_print.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_print.selected = false;
            this.btn_print.Size = new System.Drawing.Size(102, 42);
            this.btn_print.TabIndex = 6;
            this.btn_print.Text = "Cetak Faktur";
            this.btn_print.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_print.Textcolor = System.Drawing.Color.White;
            this.btn_print.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
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
            this.btn_Batal.Location = new System.Drawing.Point(219, 3);
            this.btn_Batal.Name = "btn_Batal";
            this.btn_Batal.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Batal.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Batal.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Batal.selected = false;
            this.btn_Batal.Size = new System.Drawing.Size(102, 42);
            this.btn_Batal.TabIndex = 4;
            this.btn_Batal.Text = "Batal";
            this.btn_Batal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Batal.Textcolor = System.Drawing.Color.White;
            this.btn_Batal.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Batal.Visible = false;
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
            this.btn_exit.Location = new System.Drawing.Point(327, 3);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_exit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_exit.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_exit.selected = false;
            this.btn_exit.Size = new System.Drawing.Size(102, 42);
            this.btn_exit.TabIndex = 5;
            this.btn_exit.Text = "Keluar";
            this.btn_exit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exit.Textcolor = System.Drawing.Color.White;
            this.btn_exit.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.label1.Size = new System.Drawing.Size(88, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kasir";
            // 
            // FormCashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(894, 597);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.upper_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCashier";
            this.Text = "FormCashier";
            this.Load += new System.EventHandler(this.FormCashier_Load);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_detail)).EndInit();
            this.upper_panel.ResumeLayout(false);
            this.upper_panel.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel upper_panel;
        private Bunifu.Framework.UI.BunifuFlatButton btn_print;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Batal;
        private Bunifu.Framework.UI.BunifuFlatButton btn_exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private AltoControls.AltoTextBox txt_salesNumber;
        private System.Windows.Forms.Label lbl_sales_Number;
        private System.Windows.Forms.Label lbl_Sales_Date;
        private Bunifu.Framework.UI.BunifuDatepicker dt_salesdate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private Bunifu.Framework.UI.BunifuDropdown cb_paymentType;
        private AltoControls.AltoTextBox txt_approvalcode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuDropdown cb_idpayment;
        private AltoControls.AltoTextBox txt_cardno;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private AltoControls.AltoTextBox txt_items_show;
        public Bunifu.Framework.UI.BunifuMetroTextbox txt_items_id;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Label label3;
        private AltoControls.AltoNMUpDown txt_qty;
        private Bunifu.Framework.UI.BunifuFlatButton btn_addItems;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_change;
        private AltoControls.AltoTextBox txt_change;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_payment;
        private AltoControls.AltoTextBox txt_paymentamount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dg_detail;
        private Bunifu.Framework.UI.BunifuFlatButton btn_pay;
        private Bunifu.Framework.UI.BunifuFlatButton btn_save;
        private AltoControls.AltoTextBox total_sales;
        private AltoControls.AltoTextBox txt_sales_discount;
        private AltoControls.AltoTextBox txt_payment_afterdiscount;
    }
}