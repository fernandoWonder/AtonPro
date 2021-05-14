using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Domain.Domain.Entities.Temp;
using Appplication.Statics;
using Domain.Domain.Entities;
using System.Windows.Forms;

namespace UI.Main.Views.Report.ReportsViews
{
    public partial class CloseReport : DevExpress.XtraReports.UI.XtraReport
    {
        public CloseReport()
        {
            InitializeComponent();
        }

        public void initData(Turno t)
        {

            lblValor.Text = t.Caixa.ToString();
            lblTpa.Text = t.Tpa.ToString();
            lblUser.Text = UserCurrent.getCurrentUser().Nome;
            lblDataHora.Text = t.Data.ToShortDateString() + "-" +t.Hora ;
            lblDateFinal.Text = t.DataF.ToShortDateString() + "-" + t.HoraF;
            string rootPath = Application.StartupPath;

            Company company = SystemInfoCurrent.getCurrentCompany();

            xrlblCompany.Text = company.Empresa;
            xrlblNif.Text = "NIF: " + company.Nif;
            xrlblTel.Text = "Telefone: " + company.Tel;

        }

    }
}
