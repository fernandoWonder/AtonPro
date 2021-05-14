using Appplication.Controller;
using Domain.Domain.Entities.Documents;
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
    public partial class FrmCurrentAccountConfigs : DevExpress.XtraEditors.XtraForm
    {
        PaymentMechanismController _paymentController = new PaymentMechanismController();
        CurrentAccountSystemController _accountSystemController = new CurrentAccountSystemController();
        ConfigCurrentAccountController _configAccountPayment = new ConfigCurrentAccountController();

        public FrmCurrentAccountConfigs()
        {
            InitializeComponent();

            toCombos();
        }

        public void toCombos()
        {
            _accountSystemController.ListALL().ForEach(c => cmbAccount.Properties.Items.Add(c.Descricao));
            if (cmbAccount.Properties.Items.Count > 0)
                cmbAccount.SelectedIndex = 0;
            _paymentController.ListALL().ForEach(c => cbPaymentMechanism.Properties.Items.Add(c.Id));
            if (cbPaymentMechanism.Properties.Items.Count > 0)
                cbPaymentMechanism.SelectedIndex = 0;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            ConfigCurrentAccount configAccount = new ConfigCurrentAccount()
            {
                CurrentAccountId = _accountSystemController.ListALL()[cmbAccount.SelectedIndex].Id,
                PaymentMechanismId = _paymentController.ListALL()[cbPaymentMechanism.SelectedIndex].Id,
            };

            ConfigCurrentAccount existsConfig = _configAccountPayment.getForPaymentId(_paymentController.ListALL()[cbPaymentMechanism.SelectedIndex].Id);
            if(existsConfig == null)
                _configAccountPayment.insert(configAccount);
            else
            {
                DialogResult msbR = MessageBox.Show("Já tem a conta: " + existsConfig.CurrentAccount.Descricao +" para essa forma de pagamento, Deseja substituir?", "Substituir Conta para forma de pagamento", MessageBoxButtons.OK, MessageBoxIcon.Question);
                if(msbR == DialogResult.OK)
                {
                    existsConfig.CurrentAccountId = _accountSystemController.ListALL()[cmbAccount.SelectedIndex].Id;
                    _configAccountPayment.update(existsConfig);
                }
            }

        }

    }
}
