namespace POS.Master.Customer
{
    partial class FormAddCustomer
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
            this.upper_panel = new System.Windows.Forms.Panel();
            this.btn_exit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.txt_membercode = new AltoControls.AltoTextBox();
            this.lbl_sales_Number = new System.Windows.Forms.Label();
            this.txt_cusname = new AltoControls.AltoTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_alamat = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_tempatlahir = new AltoControls.AltoTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dt_tgllahir = new Bunifu.Framework.UI.BunifuDatepicker();
            this.txt_point = new AltoControls.AltoNMUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_save = new Bunifu.Framework.UI.BunifuFlatButton();
            this.upper_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // upper_panel
            // 
            this.upper_panel.BackgroundImage = global::POS.Properties.Resources.upper;
            this.upper_panel.Controls.Add(this.btn_exit);
            this.upper_panel.Controls.Add(this.label1);
            this.upper_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.upper_panel.Location = new System.Drawing.Point(0, 0);
            this.upper_panel.Name = "upper_panel";
            this.upper_panel.Size = new System.Drawing.Size(654, 66);
            this.upper_panel.TabIndex = 1;
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
            this.btn_exit.Location = new System.Drawing.Point(513, 12);
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
            this.label1.Size = new System.Drawing.Size(158, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.upper_panel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // txt_membercode
            // 
            this.txt_membercode.ALG = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_membercode.BackColor = System.Drawing.Color.Transparent;
            this.txt_membercode.Br = System.Drawing.Color.White;
            this.txt_membercode.Enabled = false;
            this.txt_membercode.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_membercode.ForeColor = System.Drawing.Color.DimGray;
            this.txt_membercode.Location = new System.Drawing.Point(15, 119);
            this.txt_membercode.Name = "txt_membercode";
            this.txt_membercode.Radius = 6;
            this.txt_membercode.Size = new System.Drawing.Size(196, 33);
            this.txt_membercode.TabIndex = 3;
            // 
            // lbl_sales_Number
            // 
            this.lbl_sales_Number.AutoSize = true;
            this.lbl_sales_Number.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lbl_sales_Number.Location = new System.Drawing.Point(21, 97);
            this.lbl_sales_Number.Name = "lbl_sales_Number";
            this.lbl_sales_Number.Size = new System.Drawing.Size(93, 17);
            this.lbl_sales_Number.TabIndex = 2;
            this.lbl_sales_Number.Text = "Member Code";
            // 
            // txt_cusname
            // 
            this.txt_cusname.ALG = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_cusname.BackColor = System.Drawing.Color.Transparent;
            this.txt_cusname.Br = System.Drawing.Color.White;
            this.txt_cusname.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_cusname.ForeColor = System.Drawing.Color.DimGray;
            this.txt_cusname.Location = new System.Drawing.Point(15, 194);
            this.txt_cusname.Name = "txt_cusname";
            this.txt_cusname.Radius = 6;
            this.txt_cusname.Size = new System.Drawing.Size(196, 33);
            this.txt_cusname.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label2.Location = new System.Drawing.Point(21, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nama Customer";
            // 
            // txt_alamat
            // 
            this.txt_alamat.Location = new System.Drawing.Point(15, 278);
            this.txt_alamat.Name = "txt_alamat";
            this.txt_alamat.Size = new System.Drawing.Size(330, 96);
            this.txt_alamat.TabIndex = 6;
            this.txt_alamat.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label3.Location = new System.Drawing.Point(21, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Alamat";
            // 
            // txt_tempatlahir
            // 
            this.txt_tempatlahir.ALG = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_tempatlahir.BackColor = System.Drawing.Color.Transparent;
            this.txt_tempatlahir.Br = System.Drawing.Color.White;
            this.txt_tempatlahir.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_tempatlahir.ForeColor = System.Drawing.Color.DimGray;
            this.txt_tempatlahir.Location = new System.Drawing.Point(379, 110);
            this.txt_tempatlahir.Name = "txt_tempatlahir";
            this.txt_tempatlahir.Radius = 6;
            this.txt_tempatlahir.Size = new System.Drawing.Size(196, 33);
            this.txt_tempatlahir.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label4.Location = new System.Drawing.Point(385, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tempat Lahir";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label5.Location = new System.Drawing.Point(385, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tanggal Lahir";
            // 
            // dt_tgllahir
            // 
            this.dt_tgllahir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dt_tgllahir.BorderRadius = 0;
            this.dt_tgllahir.ForeColor = System.Drawing.Color.White;
            this.dt_tgllahir.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dt_tgllahir.FormatCustom = null;
            this.dt_tgllahir.Location = new System.Drawing.Point(379, 194);
            this.dt_tgllahir.Name = "dt_tgllahir";
            this.dt_tgllahir.Size = new System.Drawing.Size(196, 33);
            this.dt_tgllahir.TabIndex = 11;
            this.dt_tgllahir.Value = new System.DateTime(2018, 6, 30, 15, 44, 24, 664);
            // 
            // txt_point
            // 
            this.txt_point.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.txt_point.Location = new System.Drawing.Point(379, 278);
            this.txt_point.Name = "txt_point";
            this.txt_point.SignColor = System.Drawing.Color.White;
            this.txt_point.Size = new System.Drawing.Size(196, 30);
            this.txt_point.TabIndex = 12;
            this.txt_point.Text = "altoNMUpDown1";
            this.txt_point.Value = 0D;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label6.Location = new System.Drawing.Point(385, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Point";
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
            this.btn_save.Location = new System.Drawing.Point(447, 332);
            this.btn_save.Name = "btn_save";
            this.btn_save.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_save.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_save.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_save.selected = false;
            this.btn_save.Size = new System.Drawing.Size(128, 42);
            this.btn_save.TabIndex = 14;
            this.btn_save.Text = "Simpan";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Textcolor = System.Drawing.Color.White;
            this.btn_save.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // FormAddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(654, 414);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_point);
            this.Controls.Add(this.dt_tgllahir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_tempatlahir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_alamat);
            this.Controls.Add(this.txt_cusname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_membercode);
            this.Controls.Add(this.lbl_sales_Number);
            this.Controls.Add(this.upper_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAddCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAddCustomer";
            this.Load += new System.EventHandler(this.FormAddCustomer_Load);
            this.upper_panel.ResumeLayout(false);
            this.upper_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel upper_panel;
        private Bunifu.Framework.UI.BunifuFlatButton btn_exit;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private AltoControls.AltoTextBox txt_cusname;
        private System.Windows.Forms.Label label2;
        private AltoControls.AltoTextBox txt_membercode;
        private System.Windows.Forms.Label lbl_sales_Number;
        private System.Windows.Forms.Label label6;
        private AltoControls.AltoNMUpDown txt_point;
        private Bunifu.Framework.UI.BunifuDatepicker dt_tgllahir;
        private System.Windows.Forms.Label label5;
        private AltoControls.AltoTextBox txt_tempatlahir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txt_alamat;
        private Bunifu.Framework.UI.BunifuFlatButton btn_save;
    }
}