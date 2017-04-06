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
            txtPoints.Visible = false;
            lblPoints.Visible = false;
            txtEmail.Text = "";
            txtName.Text = "";

        }
        public string CusID;
        private void btnEdit_Click(object sender, EventArgs e)
        {
            gbadd.Visible = true;
            btnSave.Visible = false;
            btnUpdate.Visible = true;
            txtPoints.Visible = true;
            lblPoints.Visible = true;


            CusID = dgUsers.Rows[dgUsers.CurrentRow.Index].Cells[0].Value.ToString();
            string name = dgUsers.Rows[dgUsers.CurrentRow.Index].Cells[1].Value.ToString();
            string email = dgUsers.Rows[dgUsers.CurrentRow.Index].Cells[2].Value.ToString();
            string points = dgUsers.Rows[dgUsers.CurrentRow.Index].Cells[3].Value.ToString();

            txtName.Text = name;
            txtEmail.Text = email;
            txtPoints.Text = points;



        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            gbadd.Visible = false;
            txtEmail.Text = "";
            txtName.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //int i;
            string Name = txtName.Text;
            string Email = txtEmail.Text;


            SqlCommand cmd = frmLogin.sqlDBConnection.CreateCommand();
            if (validateAddNewCustomer())
            {

                cmd.CommandText = "Update Customers SET Name=@Name,Email=@email, Points=@Points WHERE ID=@Id;";


                cmd.Parameters.AddWithValue("Name", Name);
                cmd.Parameters.AddWithValue("email", Email.Trim());
                cmd.Parameters.AddWithValue("Points", Convert.ToInt32(txtPoints.Text));
                cmd.Parameters.AddWithValue("ID", Convert.ToInt32(CusID));


                try
                {
                   cmd.ExecuteNonQuery();

                    //MessageBox.Show(i.ToString());

                    txtName.Text = "";
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


                string Name = txtName.Text;
                string Email = txtEmail.Text;


                SqlCommand cmd = frmLogin.sqlDBConnection.CreateCommand();
                cmd.CommandText = "INSERT INTO Customers(Name,Email) VALUES(@Name,@email)";
                cmd.Parameters.AddWithValue("Name", Name);
                cmd.Parameters.AddWithValue("email", Email.Trim());

                try
                {
                    cmd.ExecuteScalar();

                    txtName.Text = "";
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
            string Username = txtName.Text;
            string Name = txtEmail.Text;


            if (Username.Trim().Length < 3)
            {

                MessageBox.Show("Please enter more than 3 characters for the Name.");

                return false;

            }

            if (Name.Trim().Length < 3)
            {

                MessageBox.Show("Please enter more than 3 characters for the Email.");

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

        /*
        private bool validateEditUserForm()
        {
            string Username = txtName.Text;
            string Name = txtEmail.Text;


            if (Username.Trim().Length < 3)
            {

                MessageBox.Show("Please enter more than 3 characters for the Name.");

                return false;

            }

            if (Name.Trim().Length < 3)
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
            cmd2.CommandText = "SELECT ID as ID, name AS Name,email As Email,points AS Points FROM Customers;";

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
            string ID = dgUsers.Rows[dgUsers.CurrentRow.Index].Cells[0].Value.ToString();
            string name = dgUsers.Rows[dgUsers.CurrentRow.Index].Cells[1].Value.ToString();
            string email = dgUsers.Rows[dgUsers.CurrentRow.Index].Cells[2].Value.ToString();

          
            

                if (MessageBox.Show("Are you sure you want to delete this user?\n\nName: " + name
                   , "Fuck you", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    SqlCommand cmd = frmLogin.sqlDBConnection.CreateCommand();
                    cmd.CommandText = "DELETE FROM Customers WHERE ID = @ID;";
                    cmd.Parameters.AddWithValue("ID",ID );

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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            SqlCommand cmd2 = frmLogin.sqlDBConnection.CreateCommand();
            cmd2.CommandText = "SELECT ID AS ID,name As Name,Email AS Email FROM Customers WHERE Name LIKE @Search or Email LIKE @Search or ID LIKE @Search;";

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
    }
    }

