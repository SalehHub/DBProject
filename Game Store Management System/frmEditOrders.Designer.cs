namespace Game_Store_Management_System
{
    partial class frmEditOrders
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSetEditOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetEditOrders = new Game_Store_Management_System.DataSetEditOrders();
            this.dtEditOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtaEditOrders = new Game_Store_Management_System.DataSetEditOrdersTableAdapters.dtaEditOrders();
            this.orderNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEditOrdersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEditOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEditOrdersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderNODataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dtEditOrdersBindingSource;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(29, 180);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(770, 352);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataSetEditOrdersBindingSource
            // 
            this.dataSetEditOrdersBindingSource.DataSource = this.dataSetEditOrders;
            this.dataSetEditOrdersBindingSource.Position = 0;
            // 
            // dataSetEditOrders
            // 
            this.dataSetEditOrders.DataSetName = "DataSetEditOrders";
            this.dataSetEditOrders.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtEditOrdersBindingSource
            // 
            this.dtEditOrdersBindingSource.DataMember = "dtEditOrders";
            this.dtEditOrdersBindingSource.DataSource = this.dataSetEditOrdersBindingSource;
            // 
            // dtaEditOrders
            // 
            this.dtaEditOrders.ClearBeforeFill = true;
            // 
            // orderNODataGridViewTextBoxColumn
            // 
            this.orderNODataGridViewTextBoxColumn.DataPropertyName = "Order_NO";
            this.orderNODataGridViewTextBoxColumn.HeaderText = "Order_NO";
            this.orderNODataGridViewTextBoxColumn.Name = "orderNODataGridViewTextBoxColumn";
            this.orderNODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(29, 26);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(201, 22);
            this.textBox2.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(291, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmEditOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 629);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmEditOrders";
            this.Text = "frmEditOrders";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEditOrdersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEditOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEditOrdersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dataSetEditOrdersBindingSource;
        private DataSetEditOrders dataSetEditOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dtEditOrdersBindingSource;
        private DataSetEditOrdersTableAdapters.dtaEditOrders dtaEditOrders;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
    }
}