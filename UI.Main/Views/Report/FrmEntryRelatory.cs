using Appplication.Controller;
using Domain.Domain.Entities.Documents;
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
    public partial class FrmEntryRelatory : Form
    {
        ProductEntryController _productEntry = new ProductEntryController();

        public FrmEntryRelatory()
        {
            InitializeComponent();
            fillData();
        }
        List<ProductEntry> prods = new List<ProductEntry>();
        public void fillData()
        {
             prods = _productEntry.view1("");
             gdvControlInvoices.DataSource = prods;
         //   gridView1.Columns["ProdutoId"].Visible = false;

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            FrmReportView rep = new FrmReportView();
            if (checkBox1.Checked)
            {
                rep.PrintReportEntryProduct(prods, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString());
            }
            else
            {
                rep.PrintReportEntryProduct(prods);
            }
            rep.Show();
        }

        private void gdvControlInvoices_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;
            }
            else
            {
                dateTimePicker2.Enabled = false;
                dateTimePicker1.Enabled = false;
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
           
            if (!checkBox1.Checked)
            {
                prods = _productEntry.view1(txtArtigo.Text);
                gdvControlInvoices.DataSource = prods;
                gdvControlInvoices.Refresh();
                gridView1.RefreshData();
            }
            else
            {
                prods = _productEntry.view3(txtArtigo.Text, dateTimePicker1.Value, dateTimePicker2.Value);
                gdvControlInvoices.DataSource = prods;
                gdvControlInvoices.Refresh();
                gridView1.RefreshData();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
