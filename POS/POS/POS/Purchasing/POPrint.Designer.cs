namespace POS.Purchasing
{
    partial class POPrint
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
            this.POReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // POReportViewer
            // 
            this.POReportViewer.ActiveViewIndex = -1;
            this.POReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.POReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.POReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.POReportViewer.Location = new System.Drawing.Point(0, 0);
            this.POReportViewer.Name = "POReportViewer";
            this.POReportViewer.ShowGroupTreeButton = false;
            this.POReportViewer.ShowParameterPanelButton = false;
            this.POReportViewer.Size = new System.Drawing.Size(823, 401);
            this.POReportViewer.TabIndex = 1;
            // 
            // POPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 401);
            this.Controls.Add(this.POReportViewer);
            this.Name = "POPrint";
            this.Text = "POPrint";
            this.Load += new System.EventHandler(this.POPrint_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer POReportViewer;
    }
}