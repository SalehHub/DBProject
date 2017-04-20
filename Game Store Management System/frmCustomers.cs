using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Store_Management_System
{
    public partial class frmCustomers : Form
    {
        public frmCustomers()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            gbadd.Visible = true;
            btnUpdate.Visible = false;
            btnSave.Visible = true;
            txtEmail.Text = "";
            txtFName.Text = "";
            txtLName.Text = "";

        }
        public string CusID;
        private void btnEdit_Click(object sender, EventArgs e)
        {
            gbadd.Visible = true;
            btnSave.Visible = false;
            btnUpdate.Visible = true;


            CusID = dgUsers.Rows[dgUsers.CurrentRow.Index].Cells[0].Value.ToString();
            string FName = dgUsers.Rows[dgUsers.CurrentRow.Index].Cells[1].Value.ToString();
            string LName = dgUsers.Rows[dgUsers.CurrentRow.Index].Cells[2].Value.ToString();
            string Email = dgUsers.Rows[dgUsers.CurrentRow.Index].Cells[3].Value.ToString();

            txtFName.Text = FName;
            txtLName.Text = LName;
            txtEmail.Text = Email;



        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            gbadd.Visible = false;
            txtEmail.Text = "";
            txtFName.Text = "";
            txtLName.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //int i;
            string FName = txtFName.Text;
            string LName = txtLName.Text;
            string Email = txtEmail.Text;


            SqlCommand cmd = frmLogin.sqlDBConnection.CreateCommand();
            if (validateAddNewCustomer())
            {

                cmd.CommandText = "Update Customer SET FName=@FName,LName=@LName,Email=@Email WHERE ID=@ID;";


                cmd.Parameters.AddWithValue("FName", FName);
                cmd.Parameters.AddWithValue("LName", LName);
                cmd.Parameters.AddWithValue("Email", Email.Trim());
                cmd.Parameters.AddWithValue("ID", Convert.ToInt32(CusID));


                try
                {
                   cmd.ExecuteNonQuery();

                    //MessageBox.Show(i.ToString());

                    txtFName.Text = "";
                    txtLName.Text = "";
                    txtEmail.Text = "";



                    btnAdd.Visible = true;
                    gbadd.Visible = false;

                    showAllCustomers();
                    btnEdit.Visible = true;


                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    


        private void btnSave_Click(object sender, EventArgs e)
        {

            if (validateAddNewCustomer())
            {


                string FName = txtFName.Text;
                string LName = txtLName.Text;
                string Email = txtEmail.Text;


                SqlCommand cmd = frmLogin.sqlDBConnection.CreateCommand();
                cmd.CommandText = "INSERT INTO Customer(FName,LName,Email) VALUES(@FName,@LName,@Email)";
                cmd.Parameters.AddWithValue("FName", FName);
                cmd.Parameters.AddWithValue("LName", LName);
                cmd.Parameters.AddWithValue("Email", Email.Trim());

                try
                {
                    cmd.ExecuteScalar();

                    txtFName.Text = "";
                    txtLName.Text = "";
                    txtEmail.Text = "";



                    btnAdd.Visible = true;
                    gbadd.Visible = false;
                    btnEdit.Visible = true;

                    showAllCustomers();


                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


        }

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            showAllCustomers();
        }

        private bool validateAddNewCustomer()
        {
            string FName = txtFName.Text;
            string LName = txtFName.Text;
            string Email = txtEmail.Text;


            if (FName.Trim().Length < 3)
            {

                MessageBox.Show("Please enter more than 3 characters for the First name.");

                return false;

            }

            /*
            if (FName.Trim().Length < 3)
            {

                MessageBox.Show("Please enter more than 3 characters for the Email.");

                return false;

            }
            */

            Regex reg = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");

            if (!reg.IsMatch(txtEmail.Text))
            {
                MessageBox.Show(txtEmail.Text + " Is not a valid email .", "Attention");

                return false;
            }


            return true;

        }

        /*
        private bool validateEditUserForm()
        {
            string UserFName = txtFName.Text;
            string FName = txtEmail.Text;


            if (UserFName.Trim().Length < 3)
            {

                MessageBox.Show("Please enter more than 3 characters for the FName.");

                return false;

            }

            if (FName.Trim().Length < 3)
            {

                MessageBox.Show("Please enter more than 3 characters for the email.");

                return false;

            }

            Regex reg = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");

            if (!reg.IsMatch(txtEmail.Text))
            {
                MessageBox.Show(txtEmail.Text + " Is not a valid email .", "Attention");

                return false;
            }


            return true;

        }
        */

        //Load all users to the data grid 
        private void showAllCustomers()
        {
            SqlCommand cmd2 = frmLogin.sqlDBConnection.CreateCommand();
            cmd2.CommandText = "SELECT ID as ID, FName AS 'First name', LName AS 'Last name',Email As Email FROM Customer;";

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgUsers.CurrentRow != null)
            {
                string ID = dgUsers.Rows[dgUsers.CurrentRow.Index].Cells[0].Value.ToString();
                string FName = dgUsers.Rows[dgUsers.CurrentRow.Index].Cells[1].Value.ToString();
                string LName = dgUsers.Rows[dgUsers.CurrentRow.Index].Cells[2].Value.ToString();
                string Email = dgUsers.Rows[dgUsers.CurrentRow.Index].Cells[3].Value.ToString();




                if (MessageBox.Show("Are you sure you want to delete this user?\n\nFirst name: " + FName
                   , "Danger", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    SqlCommand cmd = frmLogin.sqlDBConnection.CreateCommand();
                    cmd.CommandText = "DELETE FROM Customer WHERE ID = @ID;";
                    cmd.Parameters.AddWithValue("ID", ID);

                    try
                    {
                        cmd.ExecuteScalar();

                        showAllCustomers();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
            }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            SqlCommand cmd2 = frmLogin.sqlDBConnection.CreateCommand();
            cmd2.CommandText = "SELECT ID AS ID,FName As 'First name',LName As 'Last name',Email AS Email FROM Customer WHERE FName LIKE @Search or LName LIKE @Search or Email LIKE @Search or ID LIKE @Search;";

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

        private void txtName_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gbadd_Enter(object sender, EventArgs e)
        {

        }

        private void txtLName_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
    }

