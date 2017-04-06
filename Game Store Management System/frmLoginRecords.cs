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
    public partial class frmLoginRecords : Form
    {
        public frmLoginRecords()
        {
            InitializeComponent();
        }

        private void showAll()
        {
            SqlCommand cmd2 = frmLogin.sqlDBConnection.CreateCommand();
            cmd2.CommandText = "SELECT username AS Username, date AS 'Login date' FROM Login_Record ORDER by date desc;";

            try
            {
                SqlDataReader reader2 = cmd2.ExecuteReader();

                DataTable tmpTable = new DataTable();
                tmpTable.Load(reader2);

                dataGridView1.DataSource = tmpTable;
                reader2.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = frmLogin.sqlDBConnection.CreateCommand();
                cmd.CommandText = "SELECT username FROM Staff;";

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cmbUsers.Items.Add(reader[0].ToString());
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }


            showAll();
            
        }

        private void cmbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            string username = cmbUsers.Text;

            SqlCommand cmd2 = frmLogin.sqlDBConnection.CreateCommand();
            cmd2.CommandText = "SELECT username AS Username, date AS 'Login date' FROM Login_Record where Username=@Username ORDER by date desc;";
            cmd2.Parameters.AddWithValue("Username",username);
            try
            {
                SqlDataReader reader2 = cmd2.ExecuteReader();

                DataTable tmpTable = new DataTable();
                tmpTable.Load(reader2);

                dataGridView1.DataSource = tmpTable;
                reader2.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showAll();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime date1 = dateTimePicker1.Value.Date;
            DateTime date2 = date1.AddHours(24);

            SqlCommand cmd2 = frmLogin.sqlDBConnection.CreateCommand();
            cmd2.CommandText = "SELECT username AS Username, date AS 'Login date' FROM Login_Record WHERE Date >= @date1 AND Date <= @date2  ORDER by date desc;";
            cmd2.Parameters.AddWithValue("date1", date1);
            cmd2.Parameters.AddWithValue("date2", date2);
            try
            {
                SqlDataReader reader2 = cmd2.ExecuteReader();

                DataTable tmpTable = new DataTable();
                tmpTable.Load(reader2);

                dataGridView1.DataSource = tmpTable;
                reader2.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
