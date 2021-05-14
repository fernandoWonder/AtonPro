using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Domain.Domain.Entities.Documents;
using Appplication.Statics;
using System.Collections.Generic;
using System.Linq;

namespace UI.Main.Views.Report.ReportsViews
{
    public partial class ReciboReport : DevExpress.XtraReports.UI.XtraReport
    {
        public ReciboReport()
        {
            InitializeComponent();
        }

        public void initData(Recibo recibo)
        {
            xrSubreportCompany.ReportSource = new Cabecalho();
            xrSubreportPayments.ReportSource = new PaymentsReciboReport(recibo.Payments.ToList());

            DataSourceRecibo.DataSource = recibo;
            string ve = ConverteParaExtenso.toExtenso(recibo.TotalRecibo);
            xrLabelExtenso.Text = ve.Substring(0, 1).ToUpper() + ve.Substring(1);
        }

    }
}
