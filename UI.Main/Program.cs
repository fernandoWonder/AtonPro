using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Main.Views.PDV;

namespace UI.Main
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new Views.SplashNew());
            Application.Run(new Views.Loading());

            //Application.Run(new PDV());
            //Application.Run(new Views.Report.FornsViewGrid.FrmInvoicesViewGrid());
            //Application.Run(new Views.Save.FrmFornecedorSave());
            //Application.Run(new Views.Save.FrmProducts());
        }
    }
}
