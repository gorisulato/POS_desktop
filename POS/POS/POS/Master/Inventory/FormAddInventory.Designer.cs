namespace POS.Master.Inventory
{
    partial class FormAddInventory
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
            this.btn_save = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_size = new AltoControls.AltoNMUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_itemname = new AltoControls.AltoTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_KodeBarang = new AltoControls.AltoTextBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.upper_panel = new System.Windows.Forms.Panel();
            this.btn_exit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_sales_Number = new System.Windows.Forms.Label();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.cb_warna = new Bunifu.Framework.UI.BunifuDropdown();
            this.cb_idwarna = new Bunifu.Framework.UI.BunifuDropdown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_stock = new AltoControls.AltoTextBox();
            this.txt_price = new AltoControls.AltoTextBox();
            this.upper_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
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
            this.btn_save.Iconimage = global::POS.Properties.Resources.Save_64px;
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
            this.btn_save.Location = new System.Drawing.Point(342, 309);
            this.btn_save.Name = "btn_save";
            this.btn_save.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_save.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_save.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_save.selected = false;
            this.btn_save.Size = new System.Drawing.Size(128, 42);
            this.btn_save.TabIndex = 28;
            this.btn_save.Text = "Simpan";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Textcolor = System.Drawing.Color.White;
            this.btn_save.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label6.Location = new System.Drawing.Point(21, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "Size";
            // 
            // txt_size
            // 
            this.txt_size.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.txt_size.Location = new System.Drawing.Point(15, 309);
            this.txt_size.Name = "txt_size";
            this.txt_size.SignColor = System.Drawing.Color.White;
            this.txt_size.Size = new System.Drawing.Size(196, 30);
            this.txt_size.TabIndex = 26;
            this.txt_size.Text = "altoNMUpDown1";
            this.txt_size.Value = 0D;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label3.Location = new System.Drawing.Point(21, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Warna";
            // 
            // txt_itemname
            // 
            this.txt_itemname.ALG = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_itemname.BackColor = System.Drawing.Color.Transparent;
            this.txt_itemname.Br = System.Drawing.Color.White;
            this.txt_itemname.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_itemname.ForeColor = System.Drawing.Color.DimGray;
            this.txt_itemname.Location = new System.Drawing.Point(15, 174);
            this.txt_itemname.Name = "txt_itemname";
            this.txt_itemname.Radius = 6;
            this.txt_itemname.Size = new System.Drawing.Size(196, 33);
            this.txt_itemname.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label2.Location = new System.Drawing.Point(21, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nama Barang";
            // 
            // txt_KodeBarang
            // 
            this.txt_KodeBarang.ALG = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_KodeBarang.BackColor = System.Drawing.Color.Transparent;
            this.txt_KodeBarang.Br = System.Drawing.Color.White;
            this.txt_KodeBarang.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_KodeBarang.ForeColor = System.Drawing.Color.DimGray;
            this.txt_KodeBarang.Location = new System.Drawing.Point(15, 107);
            this.txt_KodeBarang.Name = "txt_KodeBarang";
            this.txt_KodeBarang.Radius = 6;
            this.txt_KodeBarang.Size = new System.Drawing.Size(196, 33);
            this.txt_KodeBarang.TabIndex = 17;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.upper_panel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // upper_panel
            // 
            this.upper_panel.BackgroundImage = global::POS.Properties.Resources.upper;
            this.upper_panel.Controls.Add(this.btn_exit);
            this.upper_panel.Controls.Add(this.label1);
            this.upper_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.upper_panel.Location = new System.Drawing.Point(0, 0);
            this.upper_panel.Name = "upper_panel";
            this.upper_panel.Size = new System.Drawing.Size(482, 66);
            this.upper_panel.TabIndex = 15;
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
            this.btn_exit.Location = new System.Drawing.Point(348, 12);
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
            this.label1.Size = new System.Drawing.Size(153, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory";
            // 
            // lbl_sales_Number
            // 
            this.lbl_sales_Number.AutoSize = true;
            this.lbl_sales_Number.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lbl_sales_Number.Location = new System.Drawing.Point(21, 85);
            this.lbl_sales_Number.Name = "lbl_sales_Number";
            this.lbl_sales_Number.Size = new System.Drawing.Size(84, 17);
            this.lbl_sales_Number.TabIndex = 16;
            this.lbl_sales_Number.Text = "Kode Barang";
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this;
            // 
            // cb_warna
            // 
            this.cb_warna.BackColor = System.Drawing.Color.Transparent;
            this.cb_warna.BorderRadius = 3;
            this.cb_warna.DisabledColor = System.Drawing.Color.Gray;
            this.cb_warna.ForeColor = System.Drawing.Color.White;
            this.cb_warna.Items = new string[0];
            this.cb_warna.Location = new System.Drawing.Point(15, 240);
            this.cb_warna.Name = "cb_warna";
            this.cb_warna.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cb_warna.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cb_warna.selectedIndex = -1;
            this.cb_warna.Size = new System.Drawing.Size(196, 35);
            this.cb_warna.TabIndex = 29;
            this.cb_warna.onItemSelected += new System.EventHandler(this.cb_warna_onItemSelected);
            // 
            // cb_idwarna
            // 
            this.cb_idwarna.BackColor = System.Drawing.Color.Transparent;
            this.cb_idwarna.BorderRadius = 3;
            this.cb_idwarna.DisabledColor = System.Drawing.Color.Gray;
            this.cb_idwarna.ForeColor = System.Drawing.Color.White;
            this.cb_idwarna.Items = new string[0];
            this.cb_idwarna.Location = new System.Drawing.Point(192, 227);
            this.cb_idwarna.Name = "cb_idwarna";
            this.cb_idwarna.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cb_idwarna.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cb_idwarna.selectedIndex = -1;
            this.cb_idwarna.Size = new System.Drawing.Size(10, 10);
            this.cb_idwarna.TabIndex = 30;
            this.cb_idwarna.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label5.Location = new System.Drawing.Point(288, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "Stock";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label4.Location = new System.Drawing.Point(288, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "Price";
            // 
            // txt_stock
            // 
            this.txt_stock.ALG = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_stock.BackColor = System.Drawing.Color.Transparent;
            this.txt_stock.Br = System.Drawing.Color.White;
            this.txt_stock.Enabled = false;
            this.txt_stock.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_stock.ForeColor = System.Drawing.Color.DimGray;
            this.txt_stock.Location = new System.Drawing.Point(274, 107);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.Radius = 6;
            this.txt_stock.Size = new System.Drawing.Size(196, 33);
            this.txt_stock.TabIndex = 35;
            // 
            // txt_price
            // 
            this.txt_price.ALG = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_price.BackColor = System.Drawing.Color.Transparent;
            this.txt_price.Br = System.Drawing.Color.White;
            this.txt_price.Enabled = false;
            this.txt_price.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_price.ForeColor = System.Drawing.Color.DimGray;
            this.txt_price.Location = new System.Drawing.Point(274, 174);
            this.txt_price.Name = "txt_price";
            this.txt_price.Radius = 6;
            this.txt_price.Size = new System.Drawing.Size(196, 33);
            this.txt_price.TabIndex = 36;
            // 
            // FormAddInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(482, 406);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_stock);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_idwarna);
            this.Controls.Add(this.cb_warna);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_size);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_itemname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_KodeBarang);
            this.Controls.Add(this.lbl_sales_Number);
            this.Controls.Add(this.upper_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAddInventory";
            this.Text = "FormAddInventory";
            this.Load += new System.EventHandler(this.FormAddInventory_Load);
            this.upper_panel.ResumeLayout(false);
            this.upper_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_save;
        private System.Windows.Forms.Label label6;
        private AltoControls.AltoNMUpDown txt_size;
        private System.Windows.Forms.Label label3;
        private AltoControls.AltoTextBox txt_itemname;
        private System.Windows.Forms.Label label2;
        private AltoControls.AltoTextBox txt_KodeBarang;
        private System.Windows.Forms.Label lbl_sales_Number;
        private System.Windows.Forms.Panel upper_panel;
        private Bunifu.Framework.UI.BunifuFlatButton btn_exit;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuDropdown cb_warna;
        private Bunifu.Framework.UI.BunifuDropdown cb_idwarna;
        private System.Windows.Forms.Label label5;
        private AltoControls.AltoTextBox txt_price;
        private AltoControls.AltoTextBox txt_stock;
        private System.Windows.Forms.Label label4;
    }
}