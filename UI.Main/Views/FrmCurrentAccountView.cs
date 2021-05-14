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
    public partial class FrmCurrentAccountView : DevExpress.XtraEditors.XtraForm
    {
        CurrentAccountSystemController _currentAccountController = new CurrentAccountSystemController();
        public FrmCurrentAccountView()
        {
            InitializeComponent();

            toGdv();
        }

        public void toGdv()
        {
            // Colocar depois um view
            gdvControlCurrentAccounts.DataSource = _currentAccountController.ListALL();
            gdvControlCurrentAccounts.RefreshDataSource();
        }

        private void btnNewCurrentAccount_Click(object sender, EventArgs e)
        {
            // if(new BankController().ListALL().Count > 0 )
                new FrmCurrentAccountSave(this).ShowDialog();

            /*FrmCurrentAccountSave frmCASave = */
            //frmCASave.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnNewCurrentAccount(object sender, EventArgs e)
        {

        }
    }
}
