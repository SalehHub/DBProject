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
    public partial class frmOrders : Form
    {
        public frmOrders()
        {
            InitializeComponent();
        }

        private void txtGameID_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
           // {

           // }
        }
        private void frmOrders_Load(object sender, EventArgs e)
        {
            
        }

        private void txtGameID_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = txtGameID.Text;
            string qu = txtQu.Text;


            string GameID = "";
            string GameName = "";
            string GamePrice = "";
            string Platform = "";

            SqlCommand cmd2 = frmLogin.sqlDBConnection.CreateCommand();
            cmd2.CommandText = "SELECT * FROM Game WHERE ID = @GameID;";
            cmd2.Parameters.AddWithValue("GameID", id);


            try
            {
                SqlDataReader reader2 = cmd2.ExecuteReader();


                if (reader2.Read())
                {

                    GameID = reader2[0].ToString();
                    GameName = reader2[1].ToString();
                    GamePrice = reader2[2].ToString();
                    Platform = reader2[4].ToString();

                }

                decimal total = Decimal.Parse(GamePrice) * Decimal.Parse(qu);
                // DataTable tmpTable = new DataTable();
                //tmpTable.Load(reader2);

                //dgUsers.DataSource = tmpTable;


                string[] game = { GameID, GameName, Platform,GamePrice, qu, total.ToString() };

                grdOrderList.Rows.Add(game);

                reader2.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }




            computeTotal();

            


        }

        private void grdOrderList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            if (grdOrderList.CurrentRow != null)
            {
                string Qu = grdOrderList.Rows[grdOrderList.CurrentRow.Index].Cells[4].Value.ToString();

                string Price = grdOrderList.Rows[grdOrderList.CurrentRow.Index].Cells[3].Value.ToString();

                decimal total = decimal.Parse(Price) * decimal.Parse(Qu);
                grdOrderList.Rows[grdOrderList.CurrentRow.Index].Cells[5].Value = total;

                computeTotal();
            }
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
           // int i;
            string Qu       = grdOrderList.Rows[grdOrderList.CurrentRow.Index].Cells[0].Value.ToString();
            string Price    = grdOrderList.Rows[grdOrderList.CurrentRow.Index].Cells[3].Value.ToString();

            string cusID = txtCusID.Text;

            string total = txtTotal.Text;


            SqlCommand cmd = frmLogin.sqlDBConnection.CreateCommand();
            cmd.CommandText = "INSERT INTO Invoice(Customer_ID,Username,Total,Date) OUTPUT INSERTED.Invoice_NO VALUES(@CusID,@Username,@Total,@Date)";


            cmd.Parameters.AddWithValue("CusID", cusID);
            cmd.Parameters.AddWithValue("Username", frmLogin.userUsername);
            cmd.Parameters.AddWithValue("Total", total);
            cmd.Parameters.AddWithValue("Date", DateTime.Now.ToString());
            try
            {
                Int32 i = (Int32)cmd.ExecuteScalar();

                lblInovice.Text = i.ToString();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }




        }


        public void computeTotal()
        {

            decimal totalF = 0;
            foreach (DataGridViewRow row in grdOrderList.Rows)
            {
                if (row.Cells[5].Value != null)
                {
                    totalF += decimal.Parse(row.Cells[5].Value.ToString());
                }
            }

            txtTotal.Text = totalF.ToString();

        }
    }
}
