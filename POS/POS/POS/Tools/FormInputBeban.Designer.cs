namespace POS.Tools
{
    partial class FormInputBeban
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_exit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txt_tahun = new AltoControls.AltoTextBox();
            this.lbl_sales_Number = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_month = new Bunifu.Framework.UI.BunifuDropdown();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_clear = new Bunifu.Framework.UI.BunifuImageButton();
            this.txt_coa_id = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_coa_show = new AltoControls.AltoTextBox();
            this.btn_Lovcoa = new Bunifu.Framework.UI.BunifuImageButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nominal = new AltoControls.AltoNMUpDown();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dg_listBeban = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editinventory = new System.Windows.Forms.ToolStripMenuItem();
            this.hapusBebanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_clear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Lovcoa)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_listBeban)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::POS.Properties.Resources.upper;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(646, 54);
            this.panel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(4, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 45);
            this.label4.TabIndex = 8;
            this.label4.Text = "Beban";
            this.label4.Click += new System.EventHandler(this.label4_Click);
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
            this.btn_exit.Location = new System.Drawing.Point(519, 6);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_exit.OnHovercolor = System.Drawing.Color.Teal;
            this.btn_exit.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_exit.selected = false;
            this.btn_exit.Size = new System.Drawing.Size(115, 42);
            this.btn_exit.TabIndex = 7;
            this.btn_exit.Text = "Keluar";
            this.btn_exit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exit.Textcolor = System.Drawing.Color.White;
            this.btn_exit.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // txt_tahun
            // 
            this.txt_tahun.ALG = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_tahun.BackColor = System.Drawing.Color.Transparent;
            this.txt_tahun.Br = System.Drawing.Color.White;
            this.txt_tahun.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_tahun.ForeColor = System.Drawing.Color.DimGray;
            this.txt_tahun.Location = new System.Drawing.Point(6, 44);
            this.txt_tahun.Name = "txt_tahun";
            this.txt_tahun.Radius = 6;
            this.txt_tahun.Size = new System.Drawing.Size(196, 33);
            this.txt_tahun.TabIndex = 5;
            this.txt_tahun.TextChanged += new System.EventHandler(this.txt_tahun_TextChanged);
            // 
            // lbl_sales_Number
            // 
            this.lbl_sales_Number.AutoSize = true;
            this.lbl_sales_Number.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lbl_sales_Number.Location = new System.Drawing.Point(10, 90);
            this.lbl_sales_Number.Name = "lbl_sales_Number";
            this.lbl_sales_Number.Size = new System.Drawing.Size(88, 17);
            this.lbl_sales_Number.TabIndex = 4;
            this.lbl_sales_Number.Text = "Bulan Periode";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label1.Location = new System.Drawing.Point(10, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tahun Periode";
            // 
            // cb_month
            // 
            this.cb_month.BackColor = System.Drawing.Color.Transparent;
            this.cb_month.BorderRadius = 3;
            this.cb_month.DisabledColor = System.Drawing.Color.Gray;
            this.cb_month.ForeColor = System.Drawing.Color.White;
            this.cb_month.Items = new string[] {
        "Januari",
        "Februari",
        "Maret",
        "April",
        "Mei",
        "Juni",
        "Juli",
        "Agustus",
        "September",
        "Oktober",
        "November",
        "Desember"};
            this.cb_month.Location = new System.Drawing.Point(6, 112);
            this.cb_month.Name = "cb_month";
            this.cb_month.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cb_month.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cb_month.selectedIndex = 0;
            this.cb_month.Size = new System.Drawing.Size(196, 35);
            this.cb_month.TabIndex = 7;
            this.cb_month.onItemSelected += new System.EventHandler(this.cb_month_onItemSelected);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label2.Location = new System.Drawing.Point(10, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Kode Akun";
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_clear.Image = global::POS.Properties.Resources.Cancel_white;
            this.btn_clear.ImageActive = null;
            this.btn_clear.Location = new System.Drawing.Point(254, 198);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(28, 31);
            this.btn_clear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_clear.TabIndex = 227;
            this.btn_clear.TabStop = false;
            this.btn_clear.Zoom = 10;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // txt_coa_id
            // 
            this.txt_coa_id.BorderColorFocused = System.Drawing.Color.Blue;
            this.txt_coa_id.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_coa_id.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txt_coa_id.BorderThickness = 3;
            this.txt_coa_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_coa_id.Enabled = false;
            this.txt_coa_id.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_coa_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_coa_id.isPassword = false;
            this.txt_coa_id.Location = new System.Drawing.Point(202, 198);
            this.txt_coa_id.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_coa_id.Name = "txt_coa_id";
            this.txt_coa_id.Size = new System.Drawing.Size(10, 31);
            this.txt_coa_id.TabIndex = 224;
            this.txt_coa_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_coa_id.Visible = false;
            // 
            // txt_coa_show
            // 
            this.txt_coa_show.ALG = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_coa_show.BackColor = System.Drawing.Color.Transparent;
            this.txt_coa_show.Br = System.Drawing.Color.White;
            this.txt_coa_show.Enabled = false;
            this.txt_coa_show.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.txt_coa_show.ForeColor = System.Drawing.Color.DimGray;
            this.txt_coa_show.Location = new System.Drawing.Point(6, 198);
            this.txt_coa_show.Name = "txt_coa_show";
            this.txt_coa_show.Radius = 6;
            this.txt_coa_show.Size = new System.Drawing.Size(198, 33);
            this.txt_coa_show.TabIndex = 225;
            // 
            // btn_Lovcoa
            // 
            this.btn_Lovcoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Lovcoa.Image = global::POS.Properties.Resources.guest_list_white;
            this.btn_Lovcoa.ImageActive = null;
            this.btn_Lovcoa.Location = new System.Drawing.Point(209, 198);
            this.btn_Lovcoa.Name = "btn_Lovcoa";
            this.btn_Lovcoa.Size = new System.Drawing.Size(49, 31);
            this.btn_Lovcoa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Lovcoa.TabIndex = 226;
            this.btn_Lovcoa.TabStop = false;
            this.btn_Lovcoa.Zoom = 10;
            this.btn_Lovcoa.Click += new System.EventHandler(this.btn_Lovcoa_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label3.Location = new System.Drawing.Point(10, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 229;
            this.label3.Text = "Nominal";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_nominal
            // 
            this.txt_nominal.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.txt_nominal.Location = new System.Drawing.Point(6, 265);
            this.txt_nominal.Name = "txt_nominal";
            this.txt_nominal.SignColor = System.Drawing.Color.White;
            this.txt_nominal.Size = new System.Drawing.Size(196, 33);
            this.txt_nominal.TabIndex = 230;
            this.txt_nominal.Text = "altoNMUpDown1";
            this.txt_nominal.Value = 0D;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Simpan";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = global::POS.Properties.Resources.Save_64px;
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
            this.bunifuFlatButton1.Location = new System.Drawing.Point(167, 313);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.Teal;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(115, 42);
            this.bunifuFlatButton1.TabIndex = 231;
            this.bunifuFlatButton1.Text = "Simpan";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_tahun);
            this.groupBox1.Controls.Add(this.bunifuFlatButton1);
            this.groupBox1.Controls.Add(this.lbl_sales_Number);
            this.groupBox1.Controls.Add(this.txt_nominal);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cb_month);
            this.groupBox1.Controls.Add(this.btn_clear);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_coa_id);
            this.groupBox1.Controls.Add(this.btn_Lovcoa);
            this.groupBox1.Controls.Add(this.txt_coa_show);
            this.groupBox1.Location = new System.Drawing.Point(12, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 359);
            this.groupBox1.TabIndex = 232;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Main Data";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Location = new System.Drawing.Point(322, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 355);
            this.groupBox2.TabIndex = 233;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List Data Yang Sudah Di Input";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dg_listBeban);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(306, 336);
            this.panel2.TabIndex = 0;
            // 
            // dg_listBeban
            // 
            this.dg_listBeban.AllowUserToAddRows = false;
            this.dg_listBeban.AllowUserToDeleteRows = false;
            this.dg_listBeban.AllowUserToOrderColumns = true;
            this.dg_listBeban.BackgroundColor = System.Drawing.Color.White;
            this.dg_listBeban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_listBeban.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_listBeban.Location = new System.Drawing.Point(0, 0);
            this.dg_listBeban.Name = "dg_listBeban";
            this.dg_listBeban.ReadOnly = true;
            this.dg_listBeban.Size = new System.Drawing.Size(306, 336);
            this.dg_listBeban.TabIndex = 0;
            this.dg_listBeban.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_listBeban_CellClick);
            this.dg_listBeban.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dg_listBeban_CellMouseUp);
            this.dg_listBeban.SelectionChanged += new System.EventHandler(this.dg_listBeban_SelectionChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editinventory,
            this.hapusBebanToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 70);
            // 
            // editinventory
            // 
            this.editinventory.Image = global::POS.Properties.Resources.edit;
            this.editinventory.Name = "editinventory";
            this.editinventory.Size = new System.Drawing.Size(152, 22);
            this.editinventory.Text = "Edit Beban";
            this.editinventory.Click += new System.EventHandler(this.editinventory_Click);
            // 
            // hapusBebanToolStripMenuItem
            // 
            this.hapusBebanToolStripMenuItem.Image = global::POS.Properties.Resources.delete_grey;
            this.hapusBebanToolStripMenuItem.Name = "hapusBebanToolStripMenuItem";
            this.hapusBebanToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hapusBebanToolStripMenuItem.Text = "Hapus Beban";
            this.hapusBebanToolStripMenuItem.Click += new System.EventHandler(this.hapusBebanToolStripMenuItem_Click);
            // 
            // FormInputBeban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(646, 427);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormInputBeban";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInputBeban";
            this.Load += new System.EventHandler(this.FormInputBeban_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_clear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Lovcoa)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_listBeban)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_exit;
        private System.Windows.Forms.Label label1;
        private AltoControls.AltoTextBox txt_tahun;
        private System.Windows.Forms.Label lbl_sales_Number;
        private Bunifu.Framework.UI.BunifuDropdown cb_month;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuImageButton btn_clear;
        public Bunifu.Framework.UI.BunifuMetroTextbox txt_coa_id;
        private AltoControls.AltoTextBox txt_coa_show;
        private Bunifu.Framework.UI.BunifuImageButton btn_Lovcoa;
        private AltoControls.AltoNMUpDown txt_nominal;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dg_listBeban;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editinventory;
        private System.Windows.Forms.ToolStripMenuItem hapusBebanToolStripMenuItem;
    }
}