using Appplication.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Main.Views.Configs
{
    public partial class FmrCurrentAccountConfigView : DevExpress.XtraEditors.XtraForm
    {
        ConfigCurrentAccountController _accountPaymentController = new ConfigCurrentAccountController();
        public FmrCurrentAccountConfigView()
        {
            InitializeComponent();
            updateGdv();
        }

        public void updateGdv()
        {
            gdvControlAccounConfigs.DataSource = _accountPaymentController.ListALL();
            gdvControlAccounConfigs.RefreshDataSource();
        }

        private void btnNewConfig_Click(object sender, EventArgs e)
        {
            new FrmCurrentAccountConfigs().ShowDialog();
        }
    }
}
