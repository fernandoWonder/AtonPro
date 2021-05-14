using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Domain.Domain.Entities.Documents;

namespace UI.Main.Views.Report.ReportsViews
{
    public partial class InvoiceReportPOS : DevExpress.XtraReports.UI.XtraReport
    {
        public InvoiceReportPOS()
        {
            InitializeComponent();
        }

        public void initData(Invoice invoice)
        {
            CustomerNameData.Value = invoice.Cliente.Cliente;
            ProductSalesDataSource.DataSource = invoice.ProductsSales;
        }

    }
}
