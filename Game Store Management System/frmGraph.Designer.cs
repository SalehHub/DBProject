namespace Game_Store_Management_System
{
    partial class frmGraph
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource13 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.dtGraphBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GameStore2DataSet = new Game_Store_Management_System.GameStore2DataSet();
            this.dtGraphTableAdapter = new Game_Store_Management_System.GameStore2DataSetTableAdapters.dtGraphTableAdapter();
            this.lblHiMonth = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGraphBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameStore2DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource13.Name = "DataSet1Graph";
            reportDataSource13.Value = this.dtGraphBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource13);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Game_Store_Management_System.Graph.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 152);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(690, 441);
            this.reportViewer1.TabIndex = 0;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(83, 30);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(179, 39);
            this.txtYear.TabIndex = 1;
            this.txtYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYear_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Year";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(268, 24);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(132, 51);
            this.btnFind.TabIndex = 3;
            this.btnFind.Text = "Get";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtGraphBindingSource
            // 
            this.dtGraphBindingSource.DataMember = "dtGraph";
            this.dtGraphBindingSource.DataSource = this.GameStore2DataSet;
            // 
            // GameStore2DataSet
            // 
            this.GameStore2DataSet.DataSetName = "GameStore2DataSet";
            this.GameStore2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtGraphTableAdapter
            // 
            this.dtGraphTableAdapter.ClearBeforeFill = true;
            // 
            // lblHiMonth
            // 
            this.lblHiMonth.AutoSize = true;
            this.lblHiMonth.Location = new System.Drawing.Point(6, 92);
            this.lblHiMonth.Name = "lblHiMonth";
            this.lblHiMonth.Size = new System.Drawing.Size(995, 33);
            this.lblHiMonth.TabIndex = 4;
            this.lblHiMonth.Text = "______________________________________________________________________";
            // 
            // frmGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 605);
            this.Controls.Add(this.lblHiMonth);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmGraph";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graph";
            ((System.ComponentModel.ISupportInitialize)(this.dtGraphBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameStore2DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.BindingSource dtGraphBindingSource;
        private GameStore2DataSet GameStore2DataSet;
        private GameStore2DataSetTableAdapters.dtGraphTableAdapter dtGraphTableAdapter;
        private System.Windows.Forms.Label lblHiMonth;
    }
}