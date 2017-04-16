namespace Game_Store_Management_System
{
    partial class frmInvoice
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.repInvoice = new Microsoft.Reporting.WinForms.ReportViewer();
            this.InvoiceDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DSInvoice = new Game_Store_Management_System.DSInvoice();
            this.invoiceDataTableTableAdapter = new Game_Store_Management_System.DSInvoiceTableAdapters.InvoiceDataTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSInvoice)).BeginInit();
            this.SuspendLayout();
            // 
            // repInvoice
            // 
            this.repInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSetInvoice";
            reportDataSource1.Value = this.InvoiceDataTableBindingSource;
            this.repInvoice.LocalReport.DataSources.Add(reportDataSource1);
            this.repInvoice.LocalReport.ReportEmbeddedResource = "Game_Store_Management_System.Invoice.rdlc";
            this.repInvoice.Location = new System.Drawing.Point(12, 12);
            this.repInvoice.Name = "repInvoice";
            this.repInvoice.Size = new System.Drawing.Size(642, 556);
            this.repInvoice.TabIndex = 0;
            this.repInvoice.Load += new System.EventHandler(this.repInvoice_Load);
            // 
            // InvoiceDataTableBindingSource
            // 
            this.InvoiceDataTableBindingSource.DataMember = "InvoiceDataTable";
            this.InvoiceDataTableBindingSource.DataSource = this.DSInvoice;
            // 
            // DSInvoice
            // 
            this.DSInvoice.DataSetName = "DSInvoice";
            this.DSInvoice.EnforceConstraints = false;
            this.DSInvoice.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // invoiceDataTableTableAdapter
            // 
            this.invoiceDataTableTableAdapter.ClearBeforeFill = true;
            // 
            // frmInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 580);
            this.Controls.Add(this.repInvoice);
            this.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInvoice";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice";
            this.Load += new System.EventHandler(this.frmInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSInvoice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer repInvoice;
        private DSInvoice DSInvoice;
        private DSInvoiceTableAdapters.InvoiceDataTableTableAdapter invoiceDataTableTableAdapter;
        private System.Windows.Forms.BindingSource InvoiceDataTableBindingSource;
    }
}