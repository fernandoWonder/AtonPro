using Appplication.Controller;
using Domain.Domain.Entities;
using Domain.Domain.Entities.Documents;
using Domain.Domain.Entities.Temp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Main.Views.Operacoes;
using UI.Main.Views.Report.ReportsViews;
using System.Drawing.Printing;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using System.Threading;
using Appplication.Statics;

namespace UI.Main.Views.Report
{
    public partial class FrmReportView : Form
    {
        public FrmReportView()
        {
            InitializeComponent();
        }

        private void documentViewer1_Load(object sender, EventArgs e)
        {

        }

        FrmCreditOrDebitNote _frmCreditNote;

        public void PrintInvoce(int idFatura, FrmCreditOrDebitNote frmCreditNote)
        {
            _frmCreditNote = frmCreditNote;
            // Nota de credito
            InvoiceController invC = new InvoiceController();
            Invoice invoice = invC.getOne(idFatura);

            InvoiceNote rep = new InvoiceNote();
            rep.initData(invoice);
            documentViewer1.DocumentSource = rep;
            rep.CreateDocument();

            if (!invoice.OriginalFeita)
            {
                invoice.OriginalFeita = true;
                invC.update(invoice);
            }
        }

        public void autoPrintDocument(XtraReport rep)
        {
            
            rep.CreateDocument();
            PrintToolBase toolPrint = new PrintToolBase(rep.PrintingSystem);
            toolPrint.Print(Methods.PRINTER);
          
        }
        public void PrintReportEntryProduct(List<ProductEntry>prods,string dateInit,string dateFinsh)
        {
            ProductEntryReport rep = new ProductEntryReport();
            rep.setDate(prods,dateInit,dateFinsh);
            rep.CreateDocument();
            documentViewer1.DocumentSource = rep;
            
        }
        public void PrintReportEntryProduct(List<ProductEntry> prods)
        {
            ProductEntryReport rep = new ProductEntryReport();
            rep.setDate(prods);
            rep.CreateDocument();
            documentViewer1.DocumentSource = rep;

        }
        public void PrintReportReatreatProduct(List<ProductRetreat> prods)
        {
            ReatretReport rep = new ReatretReport();
            rep.initDate(prods);
            rep.CreateDocument();
            documentViewer1.DocumentSource = rep;
        }
        public void PrintReportReatreatProduct(List<ProductRetreat> prods, string date1 ,string date2)
        {
            ReatretReport rep = new ReatretReport();
            rep.initDate(prods,date1,date2);
            rep.CreateDocument();
            documentViewer1.DocumentSource = rep;
        }
        public void PrintInvoce(int idFatura)
        {
            InvoiceController invC = new InvoiceController();
            Invoice invoice = invC.getOne(idFatura);

            if(invoice.TipoDocumentoId == "10") // Nota de Credito
            {
                InvoiceNote rep = new InvoiceNote();
                rep.initData(invoice);
                documentViewer1.DocumentSource = rep;
                rep.CreateDocument();

                if (!invoice.OriginalFeita)
                {
                    invoice.OriginalFeita = true;
                    invC.update(invoice);
                }

                

            }
            else if (invoice.TipoDocumento.Tipo == "RC")
            {
                ReciboReport rep = new ReciboReport();
                Recibo recibo = new ReciboController().getForDocumentId(invoice.Id);

                rep.initData(recibo);
                documentViewer1.DocumentSource = rep;
                rep.CreateDocument();

                if (!invoice.OriginalFeita)
                {
                    invoice.OriginalFeita = true;
                    invC.update(invoice);
                }
            }
            else
            {
                InvoiceReport rep = new InvoiceReport();
                rep.initDate(invoice);
                rep.CreateDocument();
                if (!invoice.OriginalFeita)
                {
                    invoice.OriginalFeita = true;
                    invC.update(invoice);
                }
                InvoiceReport rep2 = new InvoiceReport();
                rep2.initDate(invoice);
                rep2.CreateDocument();

                rep.ModifyDocument(x => { x.AddPages(rep2.Pages); });
                /*foreach (DevExpress.XtraReports.Parameters.Parameter item in rep.Parameters)
                {
                    item.Visible = false;
                }*/

                documentViewer1.DocumentSource = rep;
             

              

            }

            
        }

        public void PrintInvoicePOSRecibo(int idFatura)
        {
            Invoice invoice = new InvoiceController().getOne(idFatura);
            POS_InvoiceReport invoiceReportPOS = new POS_InvoiceReport();

            invoiceReportPOS.initData(invoice);

            // documentViewer1.DocumentSource = invoiceReportPOS; // Para Preview
            // autoPrintDocument(invoiceReportPOS);

            autoPrintDocument(invoiceReportPOS);

        }
        public void PrintOpenBox(Turno t)
        {
            
            OpenReport invoiceReportPOS = new OpenReport();
            invoiceReportPOS.initDate(t);
            // documentViewer1.DocumentSource = invoiceReportPOS; // Para Preview
            // autoPrintDocument(invoiceReportPOS);
            autoPrintDocument(invoiceReportPOS);

        }
        public void PrintCloseBox(Turno t)
        {

            CloseReport invoiceReportPOS = new CloseReport();
            invoiceReportPOS.initData(t);
            // documentViewer1.DocumentSource = invoiceReportPOS; // Para Preview
            // autoPrintDocument(invoiceReportPOS);
            autoPrintDocument(invoiceReportPOS);

        }


        public void PrintInvoiceComanda(string table,List<ProductsSelectedSell> prods,string tot)
        {
            
            ComandaReport comandaPosReport = new ComandaReport();
            comandaPosReport.iniData(prods,table,tot);
                  
              autoPrintDocument(comandaPosReport);
           // documentViewer1.DocumentSource = comandaPosReport;
           //   autoPrintDocument(comandaPosReport); //
            
        }

        public void PrintCliente(List<Customer> customers) {
 
            ClienteReport clientReporter = new ClienteReport();
            clientReporter.initDate(customers);
            documentViewer1.DocumentSource = clientReporter;
           // autoPrintDocument(clientReporter); //
            clientReporter.CreateDocument();
        }

        public void PrintProvider(List<Provider> providers)
        {
            ProviderReporter providerReporter = new ProviderReporter();
            providerReporter.initData(providers);
            documentViewer1.DocumentSource = providerReporter;
            // autoPrintDocument(providerReporter); //
            providerReporter.CreateDocument();
        }

        private void FrmReport3_Load(object sender, EventArgs e)
        {

        }

        private void FrmReportView_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(_frmCreditNote != null)
                _frmCreditNote.Close();
        }

        private void bbiPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }
    }
}
