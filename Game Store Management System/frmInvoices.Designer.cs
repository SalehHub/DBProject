namespace Game_Store_Management_System
{
    partial class frmInvoices
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
            this.btnInvoice = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtInvoiceNO = new System.Windows.Forms.TextBox();
            this.grdInvoices = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdInvoices)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInvoice
            // 
            this.btnInvoice.Location = new System.Drawing.Point(609, 6);
            this.btnInvoice.Margin = new System.Windows.Forms.Padding(6);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(204, 64);
            this.btnInvoice.TabIndex = 21;
            this.btnInvoice.Text = "Print Invoice";
            this.btnInvoice.UseVisualStyleBackColor = true;
            this.btnInvoice.Click += new System.EventHandler(this.btnInvoice_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-149, -19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 33);
            this.label1.TabIndex = 20;
            this.label1.Text = "Invoice NO:";
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(927, 6);
            this.btnDel.Margin = new System.Windows.Forms.Padding(6);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(204, 64);
            this.btnDel.TabIndex = 19;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(330, 6);
            this.btnFind.Margin = new System.Windows.Forms.Padding(6);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(159, 64);
            this.btnFind.TabIndex = 18;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // txtInvoiceNO
            // 
            this.txtInvoiceNO.Location = new System.Drawing.Point(63, 20);
            this.txtInvoiceNO.Margin = new System.Windows.Forms.Padding(6);
            this.txtInvoiceNO.Name = "txtInvoiceNO";
            this.txtInvoiceNO.Size = new System.Drawing.Size(255, 39);
            this.txtInvoiceNO.TabIndex = 17;
            this.txtInvoiceNO.TextChanged += new System.EventHandler(this.txtInvoiceNO_TextChanged);
            // 
            // grdInvoices
            // 
            this.grdInvoices.AllowUserToAddRows = false;
            this.grdInvoices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdInvoices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdInvoices.CausesValidation = false;
            this.grdInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdInvoices.Location = new System.Drawing.Point(15, 147);
            this.grdInvoices.Margin = new System.Windows.Forms.Padding(6);
            this.grdInvoices.Name = "grdInvoices";
            this.grdInvoices.RowTemplate.Height = 24;
            this.grdInvoices.ShowCellErrors = false;
            this.grdInvoices.ShowRowErrors = false;
            this.grdInvoices.Size = new System.Drawing.Size(1116, 465);
            this.grdInvoices.TabIndex = 16;
            // 
            // frmInvoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 627);
            this.Controls.Add(this.btnInvoice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtInvoiceNO);
            this.Controls.Add(this.grdInvoices);
            this.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmInvoices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoices";
            this.Load += new System.EventHandler(this.frmInvoices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdInvoices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInvoice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtInvoiceNO;
        private System.Windows.Forms.DataGridView grdInvoices;
    }
}