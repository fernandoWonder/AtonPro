using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Domain.Domain.Entities;
using Appplication.Statics;
using System.IO;
using System.Windows.Forms;

namespace UI.Main.Views.Report.ReportsViews
{
    public partial class Cabecalho : DevExpress.XtraReports.UI.XtraReport
    {
        public Cabecalho()
        {
            InitializeComponent();

            Company company = SystemInfoCurrent.getCurrentCompany();
            DataCompany.DataSource = company;
            string urlLogo = Application.StartupPath + company.UrlLogo;
            if (File.Exists(urlLogo))
            {
                xrPictureBox2.ImageUrl = urlLogo;
            }
        }

    }
}
