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
using UI.Main.Views.Save;

namespace UI.Main.Views
{
    public partial class FrmBankView : DevExpress.XtraEditors.XtraForm
    {
        BankController _bankController = new BankController();
        public FrmBankView()
        {
            InitializeComponent();
        }

        public void toGdv()
        {
            gdvControlBank.DataSource = _bankController.ListALL();
            gdvControlBank.RefreshDataSource();
        }

        private void FrmBankView_Load(object sender, EventArgs e)
        {
            toGdv();
        }

        private void btnNewBank_Click(object sender, EventArgs e)
        {
            new FrmBankSave(this).ShowDialog();
        }
    }
}
