using System;
using System.Windows.Forms;

namespace Game_Store_Management_System
{
    public partial class frmInvoice : Form
    {
        public frmInvoice()
        {
            InitializeComponent();
        }

        public string Invoice_NO;

        private void frmInvoice_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DSInvoice._InvoiceDataTable' table. You can move, or remove it, as needed.
            this.invoiceDataTableTableAdapter.GetInvoice(this.DSInvoice._InvoiceDataTable,int.Parse(Invoice_NO));

            repInvoice.RefreshReport();
            this.Text = "Invoice#" + Invoice_NO;
            repInvoice.LocalReport.DisplayName= "Invoice#" + Invoice_NO;
        }

    }
}
