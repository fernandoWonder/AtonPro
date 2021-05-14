using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Domain.Domain.Entities;
using System.Collections.Generic;
using UI.Main.Views.Report.ReportsViews;

namespace UI.Main.Views.Report
{
    public partial class ClienteReport : DevExpress.XtraReports.UI.XtraReport
    {
        public ClienteReport()
        {
            InitializeComponent();
            xrSubreportCompany.ReportSource = new Cabecalho();
        }
        public void initDate(List<Customer> customers)
        {
            objectDataSource1.DataSource = customers;
        }
    }
}
