using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Domain.Domain.Entities;
using System.Collections.Generic;

namespace UI.Main.Views.Report
{
    public partial class ProviderReporter : DevExpress.XtraReports.UI.XtraReport
    {
        public ProviderReporter()
        {
            InitializeComponent();
        }

        public void initData(List<Provider> providers)
        {
            objectDataSource1.DataSource = providers;
        }

    }
}
