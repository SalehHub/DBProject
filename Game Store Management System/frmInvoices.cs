using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Store_Management_System
{
    public partial class frmInvoices : Form
    {
        public frmInvoices()
        {
            InitializeComponent();
        }

        private void frmInvoices_Load(object sender, EventArgs e)
        {
            showAllInvoices();
        }

        public void showAllInvoices()
        {

            SqlCommand cmd = frmLogin.sqlDBConnection.CreateCommand();

            cmd.CommandText = @"SELECT (Customer.FName +' '+ Customer.LName) AS 'Customer Name', Invoice.Invoice_NO AS 'Invoice NO', Invoice.Date, Invoice.Total, (Staff.FName +' '+ Staff.LName) AS 'Staff Name'
                                  FROM Invoice INNER JOIN
                                  Customer ON Invoice.Customer_ID = Customer.ID INNER JOIN
                                  Staff ON Invoice.Username = Staff.Username";


            cmd.Parameters.AddWithValue("InvoiceNO", txtInvoiceNO.Text);

            try
            {

                SqlDataReader reader = cmd.ExecuteReader();

                DataTable tmpTable = new DataTable();
                tmpTable.Load(reader);

                grdInvoices.DataSource = tmpTable;
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (grdInvoices.CurrentRow != null)
            {
                string InvoiceNO = grdInvoices.Rows[grdInvoices.CurrentRow.Index].Cells[1].Value.ToString();


                if (MessageBox.Show("Are you sure you want to delete this Invoice and all its orders?\n\nInvoice NO: " + InvoiceNO
                   , "Danger", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    SqlCommand cmd = frmLogin.sqlDBConnection.CreateCommand();
                    cmd.CommandText = "DELETE FROM Invoice WHERE Invoice_NO = @InvoiceNO;";
                    cmd.Parameters.AddWithValue("InvoiceNO", InvoiceNO);

                    try
                    {
                        cmd.ExecuteScalar();

                        showAllInvoices();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            if (grdInvoices.CurrentRow != null)
            {
                string InvoiceNO = grdInvoices.Rows[grdInvoices.CurrentRow.Index].Cells[1].Value.ToString();

                frmInvoice frmInvoice = new frmInvoice();
                frmInvoice.Invoice_NO = InvoiceNO;

                frmInvoice.ShowDialog();
            }
            else
            {

                MessageBox.Show("Please select an invoice to print!");
            }
        }

        private void txtInvoiceNO_TextChanged(object sender, EventArgs e)
        {
            (grdInvoices.DataSource as DataTable).DefaultView.RowFilter = string.Format("'Customer Name' LIKE '%{0}%'", txtInvoiceNO.Text);

        }
    }
}
