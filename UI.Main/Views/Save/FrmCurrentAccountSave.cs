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
    public partial class FrmCurrentAccountSave : DevExpress.XtraEditors.XtraForm
    {
        FrmCurrentAccountView _frmCurrentAccountView = null;

        CurrentAccountSystemController _currentAccountController = new CurrentAccountSystemController();
        BankController _bankController = new BankController();

        public FrmCurrentAccountSave(FrmCurrentAccountView frmAccountView)
        {
            InitializeComponent();

            _frmCurrentAccountView = frmAccountView;
            tocmb();
        }

        public FrmCurrentAccountSave()
        {
            InitializeComponent();
            tocmb();
        }

        public void save()
        {
            
            if(txtConta.Text.Trim() != "" && txtDescrição.Text.Trim() != "")
            {
                CurrentAccountSystem account = new CurrentAccountSystem()
                {
                    SaldoAbertura = decimal.Parse(txtSaldoAtual.Text),
                    FlagState = cbSatatus.SelectedIndex == 0 ? true : false,
                    Descricao = txtDescrição.Text,
                    Saldo = decimal.Parse(txtSaldoAtual.Text),
                };
                bool interno = ckContaInterna.Checked;
                if (!interno)
                {
                    account.BankId = _bankController.ListALL()[cmbBanks.SelectedIndex].Id;
                    account.DataSaldoVerificada = dtpDataVerificadaSaldo.Value;
                }

                if(_currentAccountController.insert(account) > 0)
                {
                    txtConta.Text = txtDescrição.Text = "";
                    txtSaldoAtual.Text = "0,00";
                    if(cmbBanks.Properties.Items.Count > 0)
                        cmbBanks.SelectedIndex = 0;
                    dtpDataVerificadaSaldo.Value = DateTime.Now;

                    if(_frmCurrentAccountView != null)
                        _frmCurrentAccountView.toGdv();
                }
                else
                    MessageBox.Show("Erro ao inserir");

            }else
                MessageBox.Show("Preencha os campos obrigatórios *");
        }

        private void FrmCurrentAccountSave_Load(object sender, EventArgs e)
        {
            tocmb();
        }

        public void tocmb()
        {
            cmbBanks.Properties.Items.Clear();
       //     _bankController.ListALL().ForEach(c => cmbBanks.Properties.Items.Add(c.Banco));
            foreach (var item in _bankController.ListALL())
            {
                cmbBanks.Properties.Items.Add(item.Banco);
            }
            if (cmbBanks.Properties.Items.Count > 0)
                cmbBanks.SelectedIndex = 0;
        }

        private void ckContaInterna_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
          
        }

        private void btnNewBank_Click(object sender, EventArgs e)
        {
         
        }

        private void ckContaInterna_CheckedChanged_1(object sender, EventArgs e)
        {
            if (ckContaInterna.Checked)
            {
                txtAgencia.Enabled = false;
                cmbBanks.Enabled = false;
                dtpDataVerificadaSaldo.Enabled = false;
            }
            else
            {
                txtAgencia.Enabled = true;
                cmbBanks.Enabled = true;
                dtpDataVerificadaSaldo.Enabled = true;
            }
        }

        private void btnNewBank_Click_1(object sender, EventArgs e)
        {
            new FrmBankSave(this).ShowDialog();
        }

        private void cbSatatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
         
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            if ((!ckContaInterna.Checked && cmbBanks.Properties.Items.Count > 0) || ckContaInterna.Checked)
            {
                save();
            }
            else
            {
                MessageBox.Show("A conta que desja criar não é interna, \ndeve cadastrar um primeiro um banco");
                new FrmBankSave(this).ShowDialog();
            }
        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void txtConta_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
