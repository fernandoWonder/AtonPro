using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;

using Domain.Domain.Entities.Temp;

namespace UI.Main.Views.Report.ReportsViews
{
    public partial class ComandaReport : DevExpress.XtraReports.UI.XtraReport
    {
        public ComandaReport()
        {
            InitializeComponent();
        }
        public void iniData(List<ProductsSelectedSell> productsSellected, string mesa,string total)
        {
            objectDataSource1.DataSource = productsSellected;
            lblMesa.Text = mesa;
            lblTot.Text = total;
        }

    }
}
