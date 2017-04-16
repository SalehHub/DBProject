using System;
using Microsoft.Reporting.WinForms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;

namespace Game_Store_Management_System
{
    public partial class frmGraph : Form
    {
        public frmGraph()
        {
            InitializeComponent();
        }

        private void frmGraph_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'GameStore2DataSet.dtGraph' table. You can move, or remove it, as needed.
            //this.dtGraphTableAdapter.Fill(this.GameStore2DataSet.dtGraph);


        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (txtYear.Text.Trim().Length < 4)
            {
                MessageBox.Show("Please enter a correct year.\nFor example 2017");
            }
            else
            {

                this.dtGraphTableAdapter.Fill(this.GameStore2DataSet.dtGraph, Decimal.Parse(txtYear.Text.Trim()));

                this.reportViewer1.RefreshReport();

                //get the month of the yaer that has heighst orders 
                SqlCommand cmd = frmLogin.sqlDBConnection.CreateCommand();
                cmd.CommandText = @"Select TOP 1 YEAR(Invoice.Date) as OrderYear,  MONTH (Invoice.Date) as OrderMonth ,
                                        Count(Orders.Order_NO) as OrdersNumbers
                                        From Orders Inner Join Invoice on Orders.Invoice_NO = Invoice.Invoice_NO
                                        where Year(Invoice.date) = @Year
                                        Group by YEAR(Invoice.Date), MONTH(Invoice.Date)
                                        Order by Count(Orders.Order_NO) DESC ";

                cmd.Parameters.AddWithValue("Year", txtYear.Text.Trim());

                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows && reader.Read())
                    {

                        lblHiMonth.Text = "Month of the yaer that has heighst orders is " + CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(int.Parse(reader[1].ToString()));

                       
                    }
 reader.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keypress = e.KeyChar;
            if (!char.IsDigit(keypress) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                e.Handled = true;

               
            }

            if (txtYear.TextLength > 3 && e.KeyChar != Convert.ToChar(Keys.Back))
                {
                    e.Handled = true;
                }
        }
    }
}
