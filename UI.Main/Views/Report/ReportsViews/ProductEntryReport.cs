using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using Domain.Domain.Entities.Documents;

namespace UI.Main.Views.Report.ReportsViews
{
    public partial class ProductEntryReport : DevExpress.XtraReports.UI.XtraReport
    {
        public ProductEntryReport()
        {
            InitializeComponent();
            xrSubreportCompany.ReportSource = new Cabecalho();
        }
        public void setDate(List<ProductEntry> produts,string dataInicial,string dataFinal)
        {
            
            dataInit.Text = dataInicial;
            dataFin.Text = dataFinal;
            objectDataSource1.DataSource = produts;
        }
        public void setDate(List<ProductEntry> produts)
        {

            dataInit.Visible = false;
            dataFin.Visible = false;
            xrLabel2.Visible = false;
            xrLabel4.Visible = false;
            objectDataSource1.DataSource = produts;
        }

    }
}
