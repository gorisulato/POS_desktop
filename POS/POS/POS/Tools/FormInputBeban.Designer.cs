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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_clear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Lovcoa)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(335, 54);
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
            this.btn_exit.Location = new System.Drawing.Point(208, 3);
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
            this.txt_tahun.Location = new System.Drawing.Point(12, 88);
            this.txt_tahun.Name = "txt_tahun";
            this.txt_tahun.Radius = 6;
            this.txt_tahun.Size = new System.Drawing.Size(196, 33);
            this.txt_tahun.TabIndex = 5;
            // 
            // lbl_sales_Number
            // 
            this.lbl_sales_Number.AutoSize = true;
            this.lbl_sales_Number.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lbl_sales_Number.Location = new System.Drawing.Point(16, 134);
            this.lbl_sales_Number.Name = "lbl_sales_Number";
            this.lbl_sales_Number.Size = new System.Drawing.Size(88, 17);
            this.lbl_sales_Number.TabIndex = 4;
            this.lbl_sales_Number.Text = "Bulan Periode";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label1.Location = new System.Drawing.Point(16, 63);
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
            this.cb_month.Location = new System.Drawing.Point(12, 156);
            this.cb_month.Name = "cb_month";
            this.cb_month.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cb_month.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cb_month.selectedIndex = 0;
            this.cb_month.Size = new System.Drawing.Size(196, 35);
            this.cb_month.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label2.Location = new System.Drawing.Point(16, 211);
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
            this.btn_clear.Location = new System.Drawing.Point(260, 242);
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
            this.txt_coa_id.Location = new System.Drawing.Point(208, 242);
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
            this.txt_coa_show.Location = new System.Drawing.Point(12, 242);
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
            this.btn_Lovcoa.Location = new System.Drawing.Point(215, 242);
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
            this.label3.Location = new System.Drawing.Point(16, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 229;
            this.label3.Text = "Nominal";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_nominal
            // 
            this.txt_nominal.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.txt_nominal.Location = new System.Drawing.Point(12, 309);
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
            this.bunifuFlatButton1.Location = new System.Drawing.Point(173, 357);
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
            // FormInputBeban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(335, 411);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.txt_nominal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.txt_coa_id);
            this.Controls.Add(this.txt_coa_show);
            this.Controls.Add(this.btn_Lovcoa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_month);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_tahun);
            this.Controls.Add(this.lbl_sales_Number);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormInputBeban";
            this.Text = "FormInputBeban";
            this.Load += new System.EventHandler(this.FormInputBeban_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_clear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Lovcoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}