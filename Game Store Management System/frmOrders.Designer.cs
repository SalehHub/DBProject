namespace Game_Store_Management_System
{
    partial class frmOrders
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
            this.txtGameID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.grdOrderList = new System.Windows.Forms.DataGridView();
            this.GameID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GameName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gameplatform = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.txtQu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCusID = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblInovice = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.lblCustInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrderList)).BeginInit();
            this.SuspendLayout();
            // 
            // txtGameID
            // 
            this.txtGameID.Location = new System.Drawing.Point(177, 55);
            this.txtGameID.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtGameID.Name = "txtGameID";
            this.txtGameID.Size = new System.Drawing.Size(244, 39);
            this.txtGameID.TabIndex = 0;
            this.txtGameID.TextChanged += new System.EventHandler(this.txtGameID_TextChanged);
            this.txtGameID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGameID_KeyDown);
            this.txtGameID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGameID_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Game ID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(177, 164);
            this.button1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(244, 75);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add game";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grdOrderList
            // 
            this.grdOrderList.AllowUserToAddRows = false;
            this.grdOrderList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdOrderList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdOrderList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.grdOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOrderList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GameID,
            this.GameName,
            this.Gameplatform,
            this.UnitPrice,
            this.Quantity,
            this.Price});
            this.grdOrderList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grdOrderList.Location = new System.Drawing.Point(17, 276);
            this.grdOrderList.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.grdOrderList.Name = "grdOrderList";
            this.grdOrderList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.grdOrderList.Size = new System.Drawing.Size(1202, 345);
            this.grdOrderList.TabIndex = 3;
            this.grdOrderList.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdOrderList_CellValueChanged);
            // 
            // GameID
            // 
            this.GameID.HeaderText = "Game ID";
            this.GameID.Name = "GameID";
            this.GameID.ReadOnly = true;
            // 
            // GameName
            // 
            this.GameName.HeaderText = "Game name";
            this.GameName.Name = "GameName";
            this.GameName.ReadOnly = true;
            // 
            // Gameplatform
            // 
            this.Gameplatform.HeaderText = "Game platform";
            this.Gameplatform.Name = "Gameplatform";
            this.Gameplatform.ReadOnly = true;
            // 
            // UnitPrice
            // 
            this.UnitPrice.HeaderText = "Unit price";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(17, 628);
            this.btnCheckout.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(153, 62);
            this.btnCheckout.TabIndex = 4;
            this.btnCheckout.Text = "Check out";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // txtQu
            // 
            this.txtQu.Location = new System.Drawing.Point(177, 111);
            this.txtQu.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtQu.Name = "txtQu";
            this.txtQu.Size = new System.Drawing.Size(244, 39);
            this.txtQu.TabIndex = 5;
            this.txtQu.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 33);
            this.label2.TabIndex = 6;
            this.label2.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(491, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 33);
            this.label3.TabIndex = 8;
            this.label3.Text = "Customer ID";
            // 
            // txtCusID
            // 
            this.txtCusID.Location = new System.Drawing.Point(664, 57);
            this.txtCusID.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtCusID.Name = "txtCusID";
            this.txtCusID.Size = new System.Drawing.Size(244, 39);
            this.txtCusID.TabIndex = 7;
            this.txtCusID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCusID_KeyPress);
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(997, 631);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(222, 39);
            this.txtTotal.TabIndex = 9;
            // 
            // lblInovice
            // 
            this.lblInovice.AutoSize = true;
            this.lblInovice.Location = new System.Drawing.Point(222, 644);
            this.lblInovice.Name = "lblInovice";
            this.lblInovice.Size = new System.Drawing.Size(137, 33);
            this.lblInovice.TabIndex = 10;
            this.lblInovice.Text = "Invoice_no";
            this.lblInovice.Visible = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(912, 637);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 33);
            this.label4.TabIndex = 11;
            this.label4.Text = "Total:";
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(1086, 219);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(133, 47);
            this.btnDel.TabIndex = 12;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(919, 55);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 42);
            this.btnFind.TabIndex = 13;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // lblCustInfo
            // 
            this.lblCustInfo.AutoSize = true;
            this.lblCustInfo.Location = new System.Drawing.Point(658, 114);
            this.lblCustInfo.Name = "lblCustInfo";
            this.lblCustInfo.Size = new System.Drawing.Size(174, 33);
            this.lblCustInfo.TabIndex = 14;
            this.lblCustInfo.Text = "Customer Info";
            // 
            // frmOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 765);
            this.Controls.Add(this.lblCustInfo);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblInovice);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCusID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtQu);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.grdOrderList);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGameID);
            this.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "frmOrders";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.frmOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdOrderList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGameID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView grdOrderList;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.TextBox txtQu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn GameID;
        private System.Windows.Forms.DataGridViewTextBoxColumn GameName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gameplatform;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCusID;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblInovice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label lblCustInfo;
    }
}