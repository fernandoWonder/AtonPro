using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using Domain.Domain.Entities.Documents;

namespace UI.Main.Views.Report.ReportsViews
{
    public partial class ReatretReport : DevExpress.XtraReports.UI.XtraReport
    {
        public ReatretReport()
        {
            InitializeComponent();
            xrSubreportCompany.ReportSource = new Cabecalho();
            
        }
        public void initDate(List<ProductRetreat> prods)
        {
            objectDataSource1.DataSource = prods;
            dataFin.Visible = false;
            dataInit.Visible = false;

            xrLabel2.Visible = false;
            xrLabel4.Visible = false;
        }
        public void initDate(List<ProductRetreat> prods,string date1,string date2)
        {
            objectDataSource1.DataSource = prods;
            dataInit.Text = date1;
            dataFin.Text = date2;
        }

    }
}
