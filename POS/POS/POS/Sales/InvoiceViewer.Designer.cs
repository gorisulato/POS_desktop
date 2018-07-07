namespace POS.Sales
{
    partial class InvoiceViewer
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
            this.invoiceReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // invoiceReportViewer
            // 
            this.invoiceReportViewer.ActiveViewIndex = -1;
            this.invoiceReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.invoiceReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.invoiceReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.invoiceReportViewer.Location = new System.Drawing.Point(0, 0);
            this.invoiceReportViewer.Name = "invoiceReportViewer";
            this.invoiceReportViewer.ShowGroupTreeButton = false;
            this.invoiceReportViewer.ShowParameterPanelButton = false;
            this.invoiceReportViewer.Size = new System.Drawing.Size(834, 362);
            this.invoiceReportViewer.TabIndex = 0;
            // 
            // InvoiceViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 362);
            this.Controls.Add(this.invoiceReportViewer);
            this.Name = "InvoiceViewer";
            this.Text = "InvoiceViewer";
            this.Load += new System.EventHandler(this.InvoiceViewer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer invoiceReportViewer;
    }
}