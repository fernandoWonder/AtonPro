using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using Domain.Domain.Entities.Documents;
using Appplication.Statics;
using System.Windows.Forms;
using UI.Main.Views.Report.ReportsViews;
using Appplication.Controller;
using System.Linq;

namespace UI.Main.Views.Report
{
    public partial class InvoiceReport : DevExpress.XtraReports.UI.XtraReport
    {
        public InvoiceReport()
        {
            InitializeComponent();
        }
        Invoice invoice;
        public void initDate(Invoice iv)
        {
          
            xrSubreportCompany.ReportSource = new Cabecalho();
            xrSubreportMotivos.ReportSource = new MotivosIsencaoReport(iv.ProductsSales.ToList());
            invoice = iv;
            //nameClient.Value = invoice.Cliente.Cliente;
            InvoiceDataSource.DataSource = invoice.ProductsSales;
            string ve = ConverteParaExtenso.toExtenso(invoice.TotalGeral);
            xrLabelExtenso.Text = ve.Substring(0,1).ToUpper() + ve.Substring(1);
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            /*var ob =  GetCurrentColumnValue("Preco").ToString();
            MessageBox.Show(ob.ToString());*/
           /* if (!object.Equals(GetCurrentColumnValue("xrLabel35"), GetNextColumnValue("xrLabel35")) || this.CurrentRowIndex == this.RowCount - 1)
            {
                //DtIva.Visible = true;
                //MessageBox.Show("The last record in a group");
            }*/

           /* if (xrLabel35.Value != null)
            {
                MessageBox.Show(xrLabel35.Value.ToString());
                MessageBox.Show(invoice.ProductsSales.Count.ToString());
                if (xrLabel35.Value.ToString() == invoice.ProductsSales.Count.ToString())
                {
                    DtIva.Visible = true;
                }
            }*/
        }

        private void InvoiceReport_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (invoice.TipoDocumento.Tipo == "FT" || invoice.TipoDocumento.Tipo == "FP" || invoice.TipoDocumento.Tipo == "PP")
            {
                xrLbDtVencimento.Visible = true;
                xrLbVencimento2.Visible = true;
            }

            if (invoice.OriginalFeita)
                xrLabelVia.Text = "2ª via, conforme a original";
            else
                xrLabelVia.Text = "Original";

            xrLabelDataImpressao.Text = DateTime.Now.ToString("dd/MM/yyyy");

            if (invoice.TipoDocumentoId == "18")
            {
                xrLabeFormaPagamento.Visible = false;
                xrLabeFormaPagamentoBD.Visible = false;
            }
        }
        
    }
}
