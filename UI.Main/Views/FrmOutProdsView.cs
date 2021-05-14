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
using UI.Main.Views.Report;

namespace UI.Main.Views
{
    public partial class FrmOutProdsView : Form
    {
        public FrmOutProdsView()
        {
            InitializeComponent();
            fillData("GERAL");
        }
        StorageController store = new StorageController();
        ProductRetreatController _productRetreat = new ProductRetreatController();
        public void fillData(string armazem)
        {
            prods = _productRetreat.view1(textEdit1.Text, armazem);
            gdvControlInvoices.DataSource = prods;
            comboBoxEdit1.Properties.Items.Add("GERAL");
            foreach (var item in store.List())
            {
                comboBoxEdit1.Properties.Items.Add(item.Armazem);
            }
            comboBoxEdit1.Text = armazem;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
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
        List<ProductRetreat> prods = new List<ProductRetreat>();
         private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                 
                prods = _productRetreat.view1(textEdit1.Text,comboBoxEdit1.Text);
                gdvControlInvoices.DataSource = prods;
                gdvControlInvoices.Refresh();
                gridView1.RefreshData();
            }
            else
            {
                prods = _productRetreat.view2(textEdit1.Text,comboBoxEdit1.Text, dateTimePicker1.Value, dateTimePicker2.Value);
                gdvControlInvoices.DataSource = prods;
                gdvControlInvoices.Refresh();
                gridView1.RefreshData();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
             FrmReportView rep = new FrmReportView();
            if (checkBox1.Checked)
            {
                rep.PrintReportReatreatProduct(prods, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString());
            }
            else
            {
                rep.PrintReportReatreatProduct(prods);
            }
            rep.Show();
        }
    }
}
