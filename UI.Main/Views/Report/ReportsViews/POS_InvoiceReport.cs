using Domain.Domain.Entities.Documents;
using Appplication.Statics;
using Domain.Domain.Entities;
using System.Windows.Forms;
using System.IO;

namespace UI.Main.Views.Report.ReportsViews
{
    public partial class POS_InvoiceReport : DevExpress.XtraReports.UI.XtraReport
    {
        public POS_InvoiceReport()
        {
            InitializeComponent();
        }

        public void initData(Invoice invoiceData)
        {
            string rootPath = Application.StartupPath;

            Company company = SystemInfoCurrent.getCurrentCompany();
            invoiceDataSource.DataSource = invoiceData;
            xrlblCompany.Text = company.Empresa;
            xrlblNif.Text = "NIF: " + company.Nif;
            xrlblTel.Text = "Telefone: " + company.Tel;
            xrlblAddress.Text += company.Endereco;

            if (File.Exists(rootPath + company.UrlLogo))
            {
                xrPictureLogo.ImageUrl = rootPath + company.UrlLogo;
            }

            

            // xrlblSite.Text = company.UrlSite;
            xrlblSite.Text = "Software de gestão desenvolvido e assistido pela Fenitech Soluctions, " + SystemInfoCurrent.SystemInfo.UrlSite;
        }

    }
}
