using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Domain.Domain.Entities.Documents;
using System.Collections.Generic;
using System.Linq;
using Appplication.Controller.Assistents;

namespace UI.Main.Views.Report.ReportsViews
{
    public partial class MotivosIsencaoReport : DevExpress.XtraReports.UI.XtraReport
    {
        public MotivosIsencaoReport(List<ProductSales> productsSales)
        {
            InitializeComponent();

            var listaSalesAgrupada = productsSales.GroupBy(c => c.MotivoISEId).ToList();

            TabelaImposto[] TabelaTaxas = new TabelaImposto[listaSalesAgrupada.Count];

            int i = 0;
            foreach (var item in listaSalesAgrupada)
            {
                string motivo = item.ToList()[0].MotivoISE != null? item.ToList()[0].MotivoISE.MencaoFatura : null;

                TabelaTaxas[i] = new TabelaImposto() {
                    Taxa = item.ToList()[0].Taxa,
                    Motivo = motivo,
                    TotalIncidencia = 0,
                    TotalTaxa = 0,
                };

                foreach (var item2 in item)
                {
                    TabelaTaxas[i].TotalIncidencia += item2.TotalIncidencia;
                    TabelaTaxas[i].TotalTaxa  += item2.TotalTaxa;
                }
                i++;
            }

            DataSourceMotivos.DataSource = TabelaTaxas.ToList();
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

    }
}
