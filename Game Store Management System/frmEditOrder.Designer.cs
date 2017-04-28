namespace Game_Store_Management_System
{
    partial class frmEditOrder
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
            this.grdOrders = new System.Windows.Forms.DataGridView();
            this.txtInvoiceNO = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInvoice = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // grdOrders
            // 
            this.grdOrders.AllowUserToAddRows = false;
            this.grdOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdOrders.CausesValidation = false;
            this.grdOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOrders.Location = new System.Drawing.Point(15, 128);
            this.grdOrders.Margin = new System.Windows.Forms.Padding(6);
            this.grdOrders.Name = "grdOrders";
            this.grdOrders.RowTemplate.Height = 24;
            this.grdOrders.ShowCellErrors = false;
            this.grdOrders.ShowRowErrors = false;
            this.grdOrders.Size = new System.Drawing.Size(1033, 564);
            this.grdOrders.TabIndex = 0;
            this.grdOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdOrders_CellContentClick);
            this.grdOrders.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdOrders_CellEnter);
            this.grdOrders.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdOrders_CellLeave);
            this.grdOrders.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdOrders_CellValueChanged);
            this.grdOrders.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.grdOrders_DataError);
            // 
            // txtInvoiceNO
            // 
            this.txtInvoiceNO.Location = new System.Drawing.Point(28, 66);
            this.txtInvoiceNO.Margin = new System.Windows.Forms.Padding(6);
            this.txtInvoiceNO.Name = "txtInvoiceNO";
            this.txtInvoiceNO.Size = new System.Drawing.Size(255, 39);
            this.txtInvoiceNO.TabIndex = 1;
            this.txtInvoiceNO.TextChanged += new System.EventHandler(this.txtInvoiceNO_TextChanged);
            this.txtInvoiceNO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInvoiceNO_KeyPress);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(295, 52);
            this.btnFind.Margin = new System.Windows.Forms.Padding(6);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(159, 64);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(844, 52);
            this.btnDel.Margin = new System.Windows.Forms.Padding(6);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(204, 64);
            this.btnDel.TabIndex = 13;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 33);
            this.label1.TabIndex = 14;
            this.label1.Text = "Invoice NO:";
            // 
            // btnInvoice
            // 
            this.btnInvoice.Location = new System.Drawing.Point(614, 52);
            this.btnInvoice.Margin = new System.Windows.Forms.Padding(6);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(204, 64);
            this.btnInvoice.TabIndex = 15;
            this.btnInvoice.Text = "Print Invoice";
            this.btnInvoice.UseVisualStyleBackColor = true;
            this.btnInvoice.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmEditOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 707);
            this.Controls.Add(this.btnInvoice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtInvoiceNO);
            this.Controls.Add(this.grdOrders);
            this.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmEditOrder";
            this.Text = "Edit order";
            ((System.ComponentModel.ISupportInitialize)(this.grdOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdOrders;
        private System.Windows.Forms.TextBox txtInvoiceNO;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInvoice;
    }
}