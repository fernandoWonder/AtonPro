using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Domain.Domain.Entities.Temp;
using Appplication.Statics;
using System.Windows.Forms;
using Domain.Domain.Entities;

namespace UI.Main.Views.Report.ReportsViews
{
    public partial class OpenReport : DevExpress.XtraReports.UI.XtraReport
    {
        public OpenReport()
        {
            InitializeComponent();
        }

        public void initDate(Turno t)
        {
            lblValor.Text = t.Caixa.ToString(); ;
            lblUser.Text = UserCurrent.getCurrentUser().Nome;
            lblDataHora.Text = t.Data.ToString();
            string rootPath = Application.StartupPath;

            Company company = SystemInfoCurrent.getCurrentCompany();
    
            xrlblCompany.Text = company.Empresa;
            xrlblNif.Text = "NIF: " + company.Nif;
            xrlblTel.Text = "Telefone: " + company.Tel;
    

        }

    }
}
