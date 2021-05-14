using Appplication.Controller;
using Domain.Domain.Entities.Financial;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Main.Views.Save
{
    public partial class FrmBankSave : DevExpress.XtraEditors.XtraForm
    {
        //CurrentAccountController _currentController = new CurrentAccountController();
        BankController _bankController = new BankController();
        FrmBankView _frmBankView;
        FrmCurrentAccountSave _frmCurrentAc;

        int qualCtor = 0, primeiro = 1, segundo = 2;
        public FrmBankSave(FrmBankView frmBankView)
        {
            InitializeComponent();
            _frmBankView = frmBankView;
            qualCtor = primeiro;
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

            if (txtBank.Text.Trim() != "")
            {
                Bank bank = new Bank()
                {
                    Banco = txtBank.Text.Trim()
                };

                if (_bankController.insert(bank) > 0)
                {
                    txtBank.Clear();
                    if (qualCtor == primeiro)
                        _frmBankView.toGdv();
                    if (qualCtor == segundo)
                        _frmCurrentAc.tocmb();
                }
                Close();
            }
            else MessageBox.Show("Preencha o campo com o nome do banco");

        }

        public FrmBankSave(FrmCurrentAccountSave frmCurrentAc)
        {
            InitializeComponent();
            _frmCurrentAc = frmCurrentAc;
            qualCtor = segundo;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {}

    }
}
