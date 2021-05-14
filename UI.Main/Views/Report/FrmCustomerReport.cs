using Appplication.Controller;
using Domain.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Main.Views.Report
{
    public partial class FrmCustomerReport : Form
    {
        List<Customer> customer = new List<Customer>();
        public FrmCustomerReport()
        {
            InitializeComponent();
       
            gdvControlCustomers.DataSource = _customerController.view1("");
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }
        CustomerController _customerController = new CustomerController();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            gdvControlCustomers.DataSource = _customerController.view4(textBox1.Text);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            FrmReportView frm = new FrmReportView();
            frm.PrintCliente(_customerController.view4(textBox1.Text));
            frm.Show();
        }
    }
}
