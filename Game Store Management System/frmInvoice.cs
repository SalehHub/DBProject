using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        }

        private void CustomerBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void repInvoice_Load(object sender, EventArgs e)
        {

        }
    }
}
