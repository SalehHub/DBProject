using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
namespace Game_Store_Management_System
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        public static SqlConnection sqlDBConnection = new SqlConnection();
        public static string userName;
        public static string userUsername;
        public static string userType;



        //Validate login form
        private bool loginvalidation()
        {
            string Username = txtUsername.Text;
            string Password = txtPassword.Text;

            if (Username == "")
            {
                MessageBox.Show("Please enter your username");
                return false;
            }

            if (Password == "")
            {
                MessageBox.Show("Please enter your password");
                return false;
            }
            return true;
        }

        private void insertLoginRecord(String Username)
        {

            SqlCommand cmd = sqlDBConnection.CreateCommand();
            cmd.CommandText = "INSERT INTO login_Record VALUES(@Username, @Date)";
            cmd.Parameters.AddWithValue("Username", Username);
            cmd.Parameters.AddWithValue("Date", DateTime.Now);
            try
            {
                cmd.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (loginvalidation())
            {
                String Username = txtUsername.Text;
                String Password = GetHashString(txtPassword.Text);

                SqlCommand cmd = sqlDBConnection.CreateCommand();
                cmd.CommandText = "SELECT * FROM Staff WHERE Username = @Username AND Password = @Password";
                cmd.Parameters.AddWithValue("Username", Username);
                cmd.Parameters.AddWithValue("Password", Password);
                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows && reader.Read())
                    {
                        userUsername = reader[0].ToString();
                        userName = reader[2].ToString();
                        userType = reader[4].ToString();
                        reader.Close();
                        insertLoginRecord(userUsername);

                        

                        frmDashboard f = new frmDashboard();

                        f.Show();
                        this.Hide();
                       
                    }
                    else
                    {
                        MessageBox.Show("The username or password is incorrect");
                    }

                    reader.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            sqlDBConnection.ConnectionString = ConfigurationManager.ConnectionStrings["GameStoreDB"].ConnectionString;
            try
            {
                sqlDBConnection.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        // Hashing passwords
        public static byte[] GetHash(string inputString)
        {
            HashAlgorithm algorithm = SHA1.Create();  // SHA1.Create()
            return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
        }
        public static string GetHashString(string inputString)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in GetHash(inputString))
                sb.Append(b.ToString("X2"));

            return sb.ToString();
        }

        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {

                btnLogin_Click(sender, e);
            }
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
