namespace POS.Reports
{
    partial class RPT_LossProfitViewer
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_submit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txt_year = new AltoControls.AltoTextBox();
            this.cb_month = new Bunifu.Framework.UI.BunifuDropdown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lossprofitviewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btn_submit);
            this.panel1.Controls.Add(this.txt_year);
            this.panel1.Controls.Add(this.cb_month);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(718, 82);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label1.Location = new System.Drawing.Point(223, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 219;
            this.label1.Text = "Periode Tahun";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 17);
            this.label6.TabIndex = 218;
            this.label6.Text = "Periode Bulan";
            // 
            // btn_submit
            // 
            this.btn_submit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_submit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_submit.BorderRadius = 0;
            this.btn_submit.ButtonText = "Submit";
            this.btn_submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_submit.DisabledColor = System.Drawing.Color.Gray;
            this.btn_submit.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_submit.Iconimage = global::POS.Properties.Resources.Add_white;
            this.btn_submit.Iconimage_right = null;
            this.btn_submit.Iconimage_right_Selected = null;
            this.btn_submit.Iconimage_Selected = null;
            this.btn_submit.IconMarginLeft = 0;
            this.btn_submit.IconMarginRight = 0;
            this.btn_submit.IconRightVisible = true;
            this.btn_submit.IconRightZoom = 0D;
            this.btn_submit.IconVisible = true;
            this.btn_submit.IconZoom = 90D;
            this.btn_submit.IsTab = false;
            this.btn_submit.Location = new System.Drawing.Point(396, 32);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_submit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_submit.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_submit.selected = false;
            this.btn_submit.Size = new System.Drawing.Size(142, 33);
            this.btn_submit.TabIndex = 216;
            this.btn_submit.Text = "Submit";
            this.btn_submit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_submit.Textcolor = System.Drawing.Color.White;
            this.btn_submit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // txt_year
            // 
            this.txt_year.ALG = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_year.BackColor = System.Drawing.Color.Transparent;
            this.txt_year.Br = System.Drawing.Color.White;
            this.txt_year.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_year.ForeColor = System.Drawing.Color.DimGray;
            this.txt_year.Location = new System.Drawing.Point(226, 32);
            this.txt_year.Name = "txt_year";
            this.txt_year.Radius = 6;
            this.txt_year.Size = new System.Drawing.Size(164, 33);
            this.txt_year.TabIndex = 215;
            // 
            // cb_month
            // 
            this.cb_month.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cb_month.BorderRadius = 3;
            this.cb_month.DisabledColor = System.Drawing.Color.Gray;
            this.cb_month.ForeColor = System.Drawing.Color.White;
            this.cb_month.Items = new string[] {
        "January",
        "February",
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
            this.cb_month.Location = new System.Drawing.Point(12, 32);
            this.cb_month.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_month.Name = "cb_month";
            this.cb_month.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cb_month.onHoverColor = System.Drawing.Color.Teal;
            this.cb_month.selectedIndex = 0;
            this.cb_month.Size = new System.Drawing.Size(198, 33);
            this.cb_month.TabIndex = 217;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lossprofitviewer);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(718, 298);
            this.panel2.TabIndex = 1;
            // 
            // lossprofitviewer
            // 
            this.lossprofitviewer.ActiveViewIndex = -1;
            this.lossprofitviewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lossprofitviewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.lossprofitviewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lossprofitviewer.Location = new System.Drawing.Point(0, 0);
            this.lossprofitviewer.Name = "lossprofitviewer";
            this.lossprofitviewer.ShowGroupTreeButton = false;
            this.lossprofitviewer.ShowParameterPanelButton = false;
            this.lossprofitviewer.Size = new System.Drawing.Size(718, 298);
            this.lossprofitviewer.TabIndex = 1;
            this.lossprofitviewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // RPT_LossProfitViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 380);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "RPT_LossProfitViewer";
            this.Text = "RPT_LossProfitViewer";
            this.Load += new System.EventHandler(this.RPT_LossProfitViewer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer lossprofitviewer;
        private Bunifu.Framework.UI.BunifuFlatButton btn_submit;
        private AltoControls.AltoTextBox txt_year;
        private Bunifu.Framework.UI.BunifuDropdown cb_month;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
    }
}