using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using Domain.Domain.Entities.Documents;

namespace UI.Main.Views.Report.ReportsViews
{
    public partial class PaymentsReciboReport : DevExpress.XtraReports.UI.XtraReport
    {
        public PaymentsReciboReport(List<PaymentsRecibos> payments)
        {
            InitializeComponent();

            DataSourcePayments.DataSource = payments;
        }

    }
}
