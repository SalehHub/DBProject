namespace Game_Store_Management_System
{
    partial class frmReport
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
            this.dtOrderCusAndDateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DSOrdersReport = new Game_Store_Management_System.DSOrdersReport();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label2 = new System.Windows.Forms.Label();
            this.calaTo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.calaFrom = new System.Windows.Forms.DateTimePicker();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtCusID = new System.Windows.Forms.TextBox();
            this.cbDates = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCusID = new System.Windows.Forms.CheckBox();
            this.dtOrdersByCustIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtOrdersReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtOrdersReportTableAdapter1 = new Game_Store_Management_System.DSOrdersReportTableAdapters.dtOrdersReportTableAdapter();
            this.dtOrdersReportTableAdapter = new Game_Store_Management_System.DSOrdersReportTableAdapters.dtOrdersReportTableAdapter();
            this.dtOrdersByCustIDTableAdapter1 = new Game_Store_Management_System.DSOrdersReportTableAdapters.dtOrdersByCustIDTableAdapter();
            this.dtOrdersByCustIDTableAdapter = new Game_Store_Management_System.DSOrdersReportTableAdapters.dtOrdersByCustIDTableAdapter();
            this.dtOrderCusAndDateTableAdapter = new Game_Store_Management_System.DSOrdersReportTableAdapters.dtOrderCusAndDateTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtOrderCusAndDateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSOrdersReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtOrdersByCustIDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtOrdersReportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtOrderCusAndDateBindingSource
            // 
            this.dtOrderCusAndDateBindingSource.DataMember = "dtOrderCusAndDate";
            this.dtOrderCusAndDateBindingSource.DataSource = this.DSOrdersReport;
            // 
            // DSOrdersReport
            // 
            this.DSOrdersReport.DataSetName = "DSOrdersReport";
            this.DSOrdersReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DSOrdersCusAndDate";
            reportDataSource1.Value = this.dtOrderCusAndDateBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Game_Store_Management_System.Report4.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(15, 187);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(6);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(743, 371);
            this.reportViewer1.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 33);
            this.label2.TabIndex = 18;
            this.label2.Text = "TO";
            // 
            // calaTo
            // 
            this.calaTo.CustomFormat = "MM/dd/yyyy";
            this.calaTo.Enabled = false;
            this.calaTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.calaTo.Location = new System.Drawing.Point(308, 130);
            this.calaTo.Margin = new System.Windows.Forms.Padding(6);
            this.calaTo.Name = "calaTo";
            this.calaTo.Size = new System.Drawing.Size(191, 39);
            this.calaTo.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 33);
            this.label1.TabIndex = 20;
            this.label1.Text = "From";
            // 
            // calaFrom
            // 
            this.calaFrom.CustomFormat = "MM/dd/yyyy";
            this.calaFrom.Enabled = false;
            this.calaFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.calaFrom.Location = new System.Drawing.Point(79, 130);
            this.calaFrom.Margin = new System.Windows.Forms.Padding(6);
            this.calaFrom.Name = "calaFrom";
            this.calaFrom.Size = new System.Drawing.Size(202, 39);
            this.calaFrom.TabIndex = 19;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(611, 123);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(152, 46);
            this.btnGenerate.TabIndex = 21;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtCusID
            // 
            this.txtCusID.Enabled = false;
            this.txtCusID.Location = new System.Drawing.Point(236, 23);
            this.txtCusID.Name = "txtCusID";
            this.txtCusID.Size = new System.Drawing.Size(180, 39);
            this.txtCusID.TabIndex = 22;
            this.txtCusID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCusID_KeyPress);
            // 
            // cbDates
            // 
            this.cbDates.AutoSize = true;
            this.cbDates.Location = new System.Drawing.Point(49, 144);
            this.cbDates.Name = "cbDates";
            this.cbDates.Size = new System.Drawing.Size(18, 17);
            this.cbDates.TabIndex = 24;
            this.cbDates.UseVisualStyleBackColor = true;
            this.cbDates.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 33);
            this.label3.TabIndex = 25;
            this.label3.Text = "Customer ID";
            // 
            // cbCusID
            // 
            this.cbCusID.AutoSize = true;
            this.cbCusID.Location = new System.Drawing.Point(49, 34);
            this.cbCusID.Name = "cbCusID";
            this.cbCusID.Size = new System.Drawing.Size(18, 17);
            this.cbCusID.TabIndex = 26;
            this.cbCusID.UseVisualStyleBackColor = true;
            this.cbCusID.CheckedChanged += new System.EventHandler(this.cbCusID_CheckedChanged);
            // 
            // dtOrdersByCustIDBindingSource
            // 
            this.dtOrdersByCustIDBindingSource.DataMember = "dtOrdersByCustID";
            this.dtOrdersByCustIDBindingSource.DataSource = this.DSOrdersReport;
            // 
            // dtOrdersReportBindingSource
            // 
            this.dtOrdersReportBindingSource.DataMember = "dtOrdersReport";
            this.dtOrdersReportBindingSource.DataSource = this.DSOrdersReport;
            // 
            // dtOrdersReportTableAdapter1
            // 
            this.dtOrdersReportTableAdapter1.ClearBeforeFill = true;
            // 
            // dtOrdersReportTableAdapter
            // 
            this.dtOrdersReportTableAdapter.ClearBeforeFill = true;
            // 
            // dtOrdersByCustIDTableAdapter1
            // 
            this.dtOrdersByCustIDTableAdapter1.ClearBeforeFill = true;
            // 
            // dtOrdersByCustIDTableAdapter
            // 
            this.dtOrdersByCustIDTableAdapter.ClearBeforeFill = true;
            // 
            // dtOrderCusAndDateTableAdapter
            // 
            this.dtOrderCusAndDateTableAdapter.ClearBeforeFill = true;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 573);
            this.Controls.Add(this.cbCusID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbDates);
            this.Controls.Add(this.txtCusID);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calaFrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.calaTo);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmReport";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";
            ((System.ComponentModel.ISupportInitialize)(this.dtOrderCusAndDateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSOrdersReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtOrdersByCustIDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtOrdersReportBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker calaTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker calaFrom;
        private System.Windows.Forms.Button btnGenerate;
        private DSOrdersReportTableAdapters.dtOrdersReportTableAdapter dtOrdersReportTableAdapter1;
        private System.Windows.Forms.BindingSource dtOrdersReportBindingSource;
        private DSOrdersReport DSOrdersReport;
        private DSOrdersReportTableAdapters.dtOrdersReportTableAdapter dtOrdersReportTableAdapter;
        private System.Windows.Forms.TextBox txtCusID;
        private DSOrdersReportTableAdapters.dtOrdersByCustIDTableAdapter dtOrdersByCustIDTableAdapter1;
        private System.Windows.Forms.CheckBox cbDates;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbCusID;
        private System.Windows.Forms.BindingSource dtOrdersByCustIDBindingSource;
        private DSOrdersReportTableAdapters.dtOrdersByCustIDTableAdapter dtOrdersByCustIDTableAdapter;
        private System.Windows.Forms.BindingSource dtOrderCusAndDateBindingSource;
        private DSOrdersReportTableAdapters.dtOrderCusAndDateTableAdapter dtOrderCusAndDateTableAdapter;
    }
}