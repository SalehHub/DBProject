using Microsoft.Reporting.WinForms;
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
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }



        private void btnGenerate_Click(object sender, EventArgs e)
        {

            if (!cbCusID.Checked && cbDates.Checked)

            {
                DateTime to = calaTo.Value.Date;
                to = to.AddHours(24);
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "Game_Store_Management_System.AllOrders.rdlc";
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DSOrders", dtOrdersReportBindingSource));
                this.dtOrdersReportTableAdapter.ListOfOrders(this.DSOrdersReport.dtOrdersReport, calaFrom.Value.Date, to);
                this.reportViewer1.RefreshReport();


            }

            else if (cbCusID.Checked && !cbDates.Checked)
            {
                if (txtCusID.Text.Trim() != "")
                {
                    int cusid = int.Parse(txtCusID.Text.Trim());

                    this.reportViewer1.LocalReport.ReportEmbeddedResource = "Game_Store_Management_System.CustOrders.rdlc";
                    this.reportViewer1.LocalReport.DataSources.Clear();
                    this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dtOrdersByCustIDBindingSource));
                    this.dtOrdersByCustIDTableAdapter1.OrdersByCusID(this.DSOrdersReport.dtOrdersByCustID, cusid);
                    this.reportViewer1.RefreshReport();
                }
                else {
                    MessageBox.Show("Please enter a customer ID");
                }

            }

            else if (cbCusID.Checked && cbDates.Checked)
            {
                if (txtCusID.Text.Trim() != "")
                {
                    DateTime to = calaTo.Value.Date;
                    to = to.AddHours(24);
                    int cusid = int.Parse(txtCusID.Text.Trim());

                    this.reportViewer1.LocalReport.ReportEmbeddedResource = "Game_Store_Management_System.CustAndDatesOrders.rdlc";
                    this.reportViewer1.LocalReport.DataSources.Clear();
                    this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DSOrdersCusAndDate", dtOrderCusAndDateBindingSource));
                    this.dtOrderCusAndDateTableAdapter.OrdersCusAndDate(this.DSOrdersReport.dtOrderCusAndDate,calaFrom.Value.Date , to , cusid );
                    this.reportViewer1.RefreshReport();
                }
                else
                {
                    MessageBox.Show("Please enter a customer ID");
                }
            }

            else
                MessageBox.Show("Chooose at leaset one option mofak");
        }


        private void cbCusID_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCusID.Checked)
                txtCusID.Enabled = true;
            else
                txtCusID.Enabled = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDates.Checked)
            {
                calaFrom.Enabled = true;
                calaTo.Enabled = true;
            }
            else
            {
                calaFrom.Enabled = false;
                calaTo.Enabled = false;
            }
                
        }

        private void txtCusID_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keypress = e.KeyChar;
            if (!char.IsDigit(keypress) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtCusID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
