using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace Game_Store_Management_System
{
    public partial class frmItems : Form

    {
        public frmItems()
        {
            InitializeComponent();
        }
        public string itemID;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            gbadd.Visible = true;
            btnUpdate.Visible = false;
            btnSave.Visible = true;

            txtName.Text = "";
            txtPrice.Text = "";
            txtQu.Text = "";
            cmbPl.Text = "";


        }

        private void btnSave_Click(object sender, EventArgs e)
        { 
            if (validateAddNewItems())
            {

                decimal Price3;
                decimal.TryParse(txtPrice.Text.Replace(" ", ""), out Price3);

                string Name = txtName.Text;
                decimal Price = Price3;
                string Qu = txtQu.Text;
                string Pl = cmbPl.Text;


                SqlCommand cmd = frmLogin.sqlDBConnection.CreateCommand();
                cmd.CommandText = "INSERT INTO Game(Name,Price,Quantity,Platform) VALUES(@Name,@Price,@Qu,@Pl)";
                cmd.Parameters.AddWithValue("Name", Name.Trim());
                cmd.Parameters.AddWithValue("Price", Price);
                cmd.Parameters.AddWithValue("Qu", Qu.Trim());
                cmd.Parameters.AddWithValue("Pl", Pl.Trim());

                try
                {
                    cmd.ExecuteScalar();

                    txtName.Text = "";
                    txtPrice.Text = "";
                    txtQu.Text = "";
                    cmbPl.Text = "";



                    btnAdd.Visible = true;
                    gbadd.Visible = false;
                    btnEdit.Visible = true;

                    showAllGames();


                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void frmItems_Load(object sender, EventArgs e)
        {
            showAllGames();

            ToolTip ToolTip1 = new ToolTip();
            ToolTip1.SetToolTip(this.txtSearch, "Search by Game ID, Name or platform");

        }



        private bool validateAddNewItems()
        {

            string Name = txtName.Text;
            string Qu = txtQu.Text;
            string Pl = cmbPl.Text;

            string Price1 = txtPrice.Text.Replace(" ", "").Replace(".", "");
            int Price2;
            int.TryParse(Price1, out Price2);

            if (Price2 <= 0 )
            {


                MessageBox.Show("Please enter a valid value for the price field");

                return false;

            }

            if (Name.Trim().Length < 3)
            {

                MessageBox.Show("Please enter more than 3 characters for the Name.");

                return false;

            }
            if (Pl.Trim().Length < 2)
            {

                MessageBox.Show("Please choose a platform.");

                return false;

            }


            if (Name.Trim().Length < 3)
            {

                MessageBox.Show("Please enter more than 3 characters for the Name.");

                return false;

            }

            int q = 0;
            int.TryParse(Qu, out q);
            if ( q < 1)
            {

                MessageBox.Show("Please enter a value for Quantity");

                return false;

            }



            return true;

        }

        private void showAllGames()
        {
            SqlCommand cmd2 = frmLogin.sqlDBConnection.CreateCommand();
            cmd2.CommandText = "SELECT ID, Name,Price,Quantity,Platform FROM Game;";

            try
            {
                SqlDataReader reader2 = cmd2.ExecuteReader();

                DataTable tmpTable = new DataTable();
                tmpTable.Load(reader2);

                dgUsers.DataSource = tmpTable;
                reader2.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            gbadd.Visible = true;
            btnSave.Visible = false;
            btnUpdate.Visible = true;



            itemID = dgUsers.Rows[dgUsers.CurrentRow.Index].Cells[0].Value.ToString();
            string name = dgUsers.Rows[dgUsers.CurrentRow.Index].Cells[1].Value.ToString();
           
             decimal res=decimal.Parse(dgUsers.Rows[dgUsers.CurrentRow.Index].Cells[2].Value.ToString(), CultureInfo.InvariantCulture);
            string qu = dgUsers.Rows[dgUsers.CurrentRow.Index].Cells[3].Value.ToString();
            string pf = dgUsers.Rows[dgUsers.CurrentRow.Index].Cells[4].Value.ToString();

            txtName.Text = name;
           txtPrice.Text = res.ToString();
            txtQu.Text = qu;
            cmbPl.Text = pf;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (validateAddNewItems())
            {


                decimal Price3;
                decimal.TryParse(txtPrice.Text.Replace(" ", ""), out Price3);

                string Name = txtName.Text;
                decimal Price = Price3;
                string Qu = txtQu.Text;
                string Pl = cmbPl.Text;


                SqlCommand cmd = frmLogin.sqlDBConnection.CreateCommand();
                cmd.CommandText = "Update Game Set Name=@Name,Price=@Price,Quantity=@Qu,Platform=@Pl Where ID=@ID";
                cmd.Parameters.AddWithValue("Name", Name.Trim());
                cmd.Parameters.AddWithValue("Price", Price);
                cmd.Parameters.AddWithValue("Qu", Qu.Trim());
                cmd.Parameters.AddWithValue("Pl", Pl.Trim());
                cmd.Parameters.AddWithValue("ID", itemID);

                try
                {
                    cmd.ExecuteScalar();

                    txtName.Text = "";
                    txtPrice.Text = "";
                    txtQu.Text = "";
                    cmbPl.Text = "";



                    btnAdd.Visible = true;
                    gbadd.Visible = false;
                    btnEdit.Visible = true;

                    showAllGames();


                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string ID = dgUsers.Rows[dgUsers.CurrentRow.Index].Cells[0].Value.ToString();
            string name = dgUsers.Rows[dgUsers.CurrentRow.Index].Cells[1].Value.ToString();
            



            if (MessageBox.Show("Are you sure you want to delete this item?\n\nName: " + name
               , "Danger", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                SqlCommand cmd = frmLogin.sqlDBConnection.CreateCommand();
                cmd.CommandText = "DELETE FROM Game WHERE ID = @ID;";
                cmd.Parameters.AddWithValue("ID", ID);

                try
                {
                    cmd.ExecuteScalar();

                    showAllGames();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            SqlCommand cmd2 = frmLogin.sqlDBConnection.CreateCommand();
            cmd2.CommandText = "SELECT * From Game WHERE Name LIKE @Search or ID LIKE @Search or Platform LIKE @Search;";

            cmd2.Parameters.AddWithValue("@Search", "%" + search + "%");
            try
            {
                SqlDataReader reader2 = cmd2.ExecuteReader();

                DataTable tmpTable = new DataTable();
                tmpTable.Load(reader2);

                dgUsers.DataSource = tmpTable;
                reader2.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Only numbers
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && txtPrice.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            gbadd.Visible = false;
            btnEdit.Visible = true;
            btnAdd.Visible = true;

        }

        private void txtQu_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keypress = e.KeyChar;
            if (!char.IsDigit(keypress) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                e.Handled = true;
            }
        }
    }
    
}
