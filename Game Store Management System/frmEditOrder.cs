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
    public partial class frmEditOrder : Form
    {
        public frmEditOrder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Find();
        }

        public int OldQuantity = 1;

        public void Find()
        {
            if (txtInvoiceNO.Text.Trim() != "")
            {

            SqlCommand cmd = frmLogin.sqlDBConnection.CreateCommand();

            cmd.CommandText = @"SELECT (Customer.FName +' '+ Customer.LName) AS 'Customer Name', Orders.Order_NO AS 'Order NO', Game.Name AS 'Game Name', Orders.Quantity, Orders.Price, Game.ID
                                  FROM Orders INNER JOIN
                                  Game ON Orders.Game_ID = Game.ID INNER JOIN
                                  Customer INNER JOIN
                                  Invoice ON Customer.ID = Invoice.Customer_ID ON Orders.Invoice_NO = Invoice.Invoice_NO INNER JOIN
                                  Staff ON Invoice.Username = Staff.Username 
                                  WHERE(Invoice.Invoice_NO = @InvoiceNO)";

            cmd.Parameters.AddWithValue("InvoiceNO", txtInvoiceNO.Text);

            try
            {
                
                SqlDataReader reader = cmd.ExecuteReader();

                DataTable tmpTable = new DataTable();
                tmpTable.Load(reader);

                grdOrders.DataSource = tmpTable;
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }


            grdOrders.Columns[0].ReadOnly = true;
            grdOrders.Columns[1].ReadOnly = true;
            grdOrders.Columns[2].ReadOnly = true;
            grdOrders.Columns[4].ReadOnly = true;
            grdOrders.Columns[5].Visible = false;

            }
            else
            {

                MessageBox.Show("Please enter an Invoice NO!");
            }

        }


        private void grdOrders_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string Order_NO = grdOrders.Rows[grdOrders.CurrentRow.Index].Cells[1].Value.ToString();
            string NewQuantity = grdOrders.Rows[grdOrders.CurrentRow.Index].Cells[3].Value.ToString();
            string Price = grdOrders.Rows[grdOrders.CurrentRow.Index].Cells[4].Value.ToString();
            string GameID = grdOrders.Rows[grdOrders.CurrentRow.Index].Cells[5].Value.ToString();

            if (NewQuantity != "")
            {

                decimal UnitPrice = decimal.Parse(Price) / OldQuantity;

                decimal totalPrice = decimal.Parse(NewQuantity) * UnitPrice;

                SqlCommand cmd2 = frmLogin.sqlDBConnection.CreateCommand();

                cmd2.CommandText = @"Update Orders SET Quantity=@Quantity,Price=@Price WHERE Order_NO=@OrderNO";

                cmd2.Parameters.AddWithValue("Quantity", NewQuantity);
                cmd2.Parameters.AddWithValue("Price", totalPrice);
                cmd2.Parameters.AddWithValue("OrderNO", Order_NO);

                try
                {
                    SqlDataReader reader2 = cmd2.ExecuteReader();

                    reader2.Close();


                    int Quan = OldQuantity - int.Parse(NewQuantity);

                   updateQuantity(GameID, Quan);

                    Find();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }




        }

        private void grdOrders_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(grdOrders.Rows[grdOrders.CurrentRow.Index].Cells[3].Value!=null)
                OldQuantity = int.Parse(grdOrders.Rows[grdOrders.CurrentRow.Index].Cells[3].Value.ToString());
        }

        private void grdOrders_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (grdOrders.Rows[grdOrders.CurrentRow.Index].Cells[3].Value.ToString() == "")
                grdOrders.Rows[grdOrders.CurrentRow.Index].Cells[3].Value = OldQuantity;
        }

        private void grdOrders_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception.Message != "") { }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (grdOrders.CurrentRow != null)
            {
                string GameID = grdOrders.Rows[grdOrders.CurrentRow.Index].Cells[5].Value.ToString();

                string Order_NO = grdOrders.Rows[grdOrders.CurrentRow.Index].Cells[1].Value.ToString();
                string NewQuantity = grdOrders.Rows[grdOrders.CurrentRow.Index].Cells[3].Value.ToString();


                SqlCommand cmd2 = frmLogin.sqlDBConnection.CreateCommand();

                cmd2.CommandText = @"Delete from orders where order_NO=@OrderNO";

                cmd2.Parameters.AddWithValue("OrderNO", Order_NO);

                try
                {

                    SqlDataReader reader2 = cmd2.ExecuteReader();

                    reader2.Close();

                    updateQuantity(GameID, int.Parse(NewQuantity));



                    Find();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void grdOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void updateQuantity(string GameID, int Quantity)
        {

            SqlCommand cmd = frmLogin.sqlDBConnection.CreateCommand();
            cmd.CommandText = "Update Game SET Quantity=Quantity+@Quantity WHERE ID=@Game_ID";

            cmd.Parameters.AddWithValue("Game_ID", GameID);
            cmd.Parameters.AddWithValue("Quantity", Quantity);
            try
            {
                cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void txtInvoiceNO_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keypress = e.KeyChar;
            if (!char.IsDigit(keypress) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtInvoiceNO.Text.Trim() != "")
            {
                frmInvoice frmInvoice = new frmInvoice();
                frmInvoice.Invoice_NO = txtInvoiceNO.Text;

                frmInvoice.ShowDialog();
            }
            else
            {

                MessageBox.Show("Please enter an Invoice NO!");
            }
        }

        private void frmEditOrder_Load(object sender, EventArgs e)
        {

        }
    }
}
