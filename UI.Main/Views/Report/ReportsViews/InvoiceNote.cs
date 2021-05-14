using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Domain.Domain.Entities.Documents;
using Appplication.Statics;
using System.Linq;

namespace UI.Main.Views.Report.ReportsViews
{
    public partial class InvoiceNote : DevExpress.XtraReports.UI.XtraReport
    {
        public InvoiceNote()
        {
            InitializeComponent();
        }

        Invoice invoice;
        public void initData(Invoice iv)
        {
            invoice = iv;

            xrSubreportCompany.ReportSource = new Cabecalho();
            xrSubreportMotivos.ReportSource = new MotivosIsencaoReport(invoice.ProductsSales.ToList());
            //nameClient.Value = invoice.Cliente.Cliente;
            InvoiceDataSource.DataSource = invoice.ProductsSales.ToList();
            string ve = ConverteParaExtenso.toExtenso(invoice.TotalGeral);
            xrLabelExtenso.Text = ve.Substring(0, 1).ToUpper() + ve.Substring(1);
        }

        private void InvoiceNote_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (invoice.OriginalFeita)
                xrLabelVia.Text = "Cópia";
            else
                xrLabelVia.Text = "Original";
            xrLabelDataImpressao.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
    }
}
