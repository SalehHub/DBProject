using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Store_Management_System
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome, " + frmLogin.userName; //+ Properties.Settings.Default.Name;
            if (frmLogin.userType != "admin")
            {
                btnManageUsers.Visible = false;
                btnshowLoginRecords.Visible = false;
            }


            if (frmLogin.userUsername == "sys")
            {

                this.BackColor = Color.DarkGray;


            }
        }

        private void btnshowLoginRecords_Click(object sender, EventArgs e)
        {
            frmLoginRecords f = new frmLoginRecords();
            f.Show();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            frmUsers usersForm = new frmUsers();

            usersForm.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

            frmLogin.sqlDBConnection.Close();

            frmLogin frm = new frmLogin();

            
            this.Hide();

            frm.Show();

        }

        private void btnManageCust_Click(object sender, EventArgs e)
        {
            frmCustomers frm = new frmCustomers();
            frm.ShowDialog();
        }

        private void btnManageItems_Click(object sender, EventArgs e)
        {
            frmItems frm = new frmItems();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmOrders frm = new frmOrders();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            

            frmInvoice frmInvoice = new frmInvoice();
            frmInvoice.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmReport frm = new frmReport();
            frm.ShowDialog(); 
        }



        private void btnGraph_Click(object sender, EventArgs e)
        {
            frmGraph frm = new frmGraph();
            frm.ShowDialog();
        }
    }
}
