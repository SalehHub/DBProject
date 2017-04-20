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
            groupBox1.Visible = false;
        }

        public void showAllInvoices()
        {

            SqlCommand cmd = frmLogin.sqlDBConnection.CreateCommand();

            cmd.CommandText = @"SELECT (Customer.FName +' '+ Customer.LName) AS 'Customer_Name', Invoice.Invoice_NO AS 'Invoice_NO', Invoice.Date, Invoice.Total, (Staff.FName +' '+ Staff.LName) AS 'Staff_Name', Invoice.Customer_ID , Invoice.Username
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
                grdInvoices.Columns[6].Visible = false;
                grdInvoices.Columns[5].Visible = false;

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
            //(grdInvoices.DataSource as DataTable).DefaultView.RowFilter = string.Format("Customer_Name LIKE '%{0}%'", txtInvoiceNO.Text);

        }

        private void btnFind_Click(object sender, EventArgs e)
        {

            switch (cBoxes())
            {
                case 0:
                    MessageBox.Show("Please select an option!");
                    break;
                case 1:

                  
                    try
                    {

                        (grdInvoices.DataSource as DataTable).DefaultView.RowFilter = string.Format(" Invoice_NO = {0} ", txtInvoiceNO.Text);
                    }
                    catch (Exception es)
                    {
                        (grdInvoices.DataSource as DataTable).DefaultView.RowFilter = string.Format("Customer_Name LIKE '%{0}%' OR Staff_Name LIKE '%{0}%' ", txtInvoiceNO.Text);

                    }
                    break;
                case 2:
                    (grdInvoices.DataSource as DataTable).DefaultView.RowFilter = string.Format("Date >= '{0}' And Date <='{1}'", dcFrom.Value.ToShortDateString(), DateTime.Parse(dcTo.Value.ToShortDateString()).AddHours(24));
                    break;
                case 3:
                    (grdInvoices.DataSource as DataTable).DefaultView.RowFilter = string.Format("(Customer_Name LIKE '%{0}%' OR  Staff_Name LIKE '%{0}%') AND Date >= '{1}' And Date <='{2}'", txtInvoiceNO.Text, dcFrom.Value.ToShortDateString(), DateTime.Parse(dcTo.Value.ToShortDateString()).AddHours(24));
                    break;
            }
            //(grdInvoices.DataSource as DataTable).DefaultView.RowFilter = string.Format("Date >= '{0}' And Date <='{1}'", dcFrom.Value.ToShortDateString(), DateTime.Parse(dcTo.Value.ToShortDateString()).AddHours(24));
        }



        private void button1_Click(object sender, EventArgs e)
        {
            (grdInvoices.DataSource as DataTable).DefaultView.RowFilter = String.Empty;

        }

        private void cbOther_CheckedChanged(object sender, EventArgs e)
        {
           cBoxes();
        }

        public int cBoxes()
        {
            int s = 0;
            if (cbOther.Checked && !cbDate.Checked)
            {
                txtInvoiceNO.Enabled = true;
                label2.Visible = true;
                dcFrom.Enabled = false;
                dcTo.Enabled = false;
                s = 1;
                return s;
            }
            else if (!cbOther.Checked && cbDate.Checked)
            {
                txtInvoiceNO.Enabled = false;
                label2.Visible = false;
                dcFrom.Enabled = true;
                dcTo.Enabled = true;
                s = 2;
                return s;
            }
            else if (cbOther.Checked && cbDate.Checked)
            {
                txtInvoiceNO.Enabled = true;
                label2.Visible = true;
                dcFrom.Enabled = true;
                dcTo.Enabled = true;
                s = 3;
                return s;
            } 
            else
            {
                txtInvoiceNO.Enabled = false;
                label2.Visible = false;
                dcFrom.Enabled = false;
                dcTo.Enabled = false;
                return s;
            }       
                  }

        private void cbDate_CheckedChanged(object sender, EventArgs e)
        {
            cBoxes();
        }

        private void txtInvoiceNO_KeyPress(object sender, KeyPressEventArgs e)
        {
            string ch1 = "'";
            string ch2 = "[";
            string ch3 = "]";

            if (e.KeyChar == char.Parse(ch1) || e.KeyChar == char.Parse(ch2) || e.KeyChar == char.Parse(ch3))
            {
                e.Handled = true;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            cbStaff.Items.Clear();

            string invoID = grdInvoices.Rows[grdInvoices.CurrentRow.Index].Cells[1].Value.ToString();
            string cusID = grdInvoices.Rows[grdInvoices.CurrentRow.Index].Cells[5].Value.ToString();
            string staffID = grdInvoices.Rows[grdInvoices.CurrentRow.Index].Cells[6].Value.ToString();
           // string staffName = grdInvoices.Rows[grdInvoices.CurrentRow.Index].Cells[4].Value.ToString();
            

            groupBox1.Text = "Updete Invoice#" + invoID;

            SqlCommand cmd = frmLogin.sqlDBConnection.CreateCommand();
            cmd.CommandText = "Select Username FROM Staff where Username !='sys' ";

            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
              
                while (reader.Read())
                {
                    cbStaff.Items.Add(reader.GetString(0));
                }

                cbStaff.Text = staffID;
                txtCusID.Text = cusID;
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = frmLogin.sqlDBConnection.CreateCommand();
            cmd.CommandText = "Update Invoice set Customer_ID=@CusID, Username=@Staffus where Invoice_NO=@invID ";
            cmd.Parameters.AddWithValue("CusID", txtCusID.Text);
            cmd.Parameters.AddWithValue("Staffus", cbStaff.Text);
            cmd.Parameters.AddWithValue("invID", grdInvoices.Rows[grdInvoices.CurrentRow.Index].Cells[1].Value.ToString());

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Invoice has been updated");
                showAllInvoices();
            }

            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void grdInvoices_SelectionChanged(object sender, EventArgs e)
        {
            groupBox1.Text = "Updete Invoice#" + grdInvoices.Rows[grdInvoices.CurrentRow.Index].Cells[1].Value.ToString();
            txtCusID.Text = grdInvoices.Rows[grdInvoices.CurrentRow.Index].Cells[5].Value.ToString();
            cbStaff.Text  = grdInvoices.Rows[grdInvoices.CurrentRow.Index].Cells[6].Value.ToString();

        }
    }
}
