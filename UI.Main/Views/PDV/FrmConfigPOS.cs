using Appplication.Controller;
using Appplication.Statics;
using DevExpress.XtraEditors;
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

namespace UI.Main.Views.PDV
{
    public partial class FrmConfigPOS : DevExpress.XtraEditors.XtraForm
    {
        ConfigCurrentAccountController _configAccountUserController = new ConfigCurrentAccountController();
        UserController _userController = new UserController();
        SerieController _serieController = new SerieController();
        CurrentAccountSystemController _currentAccountController = new CurrentAccountSystemController();
        PaymentMechanismController _paymentWays = new PaymentMechanismController();

        PDV _pdv;
        public FrmConfigPOS(PDV pdv)
        {
            InitializeComponent();
            _pdv = pdv;
            toCmbs();
            updateGrid();
        }

        public void selecinaElemento1Cmb(ComboBoxEdit cmbEdit)
        {
            if (cmbEdit.Properties.Items.Count > 0)
                cmbEdit.SelectedIndex = 0;
        }

        public void eliminaElementosCmb(ComboBoxEdit cmbEdit)
        {
            cmbEdit.Properties.Items.Clear();
        }

        public void toCmbs()
        {
            eliminaElementosCmb(cmbUser);
            eliminaElementosCmb(cmbSerie);
            eliminaElementosCmb(cmbPaymentMechanism);
            eliminaElementosCmb(cmbAccounts);

            _serieController.ListALL().ForEach(c => cmbSerie.Properties.Items.Add(c.Serie));

            _userController.ListAllAsNotracking().ForEach(c => cmbUser.Properties.Items.Add(c.Usuario + " - " + c.Nome));

            _currentAccountController.ListALL().ForEach(c => cmbAccounts.Properties.Items.Add(c.NumeroConta + " - " + c.Descricao));

            _paymentWays.ListALL().ForEach(c => cmbPaymentMechanism.Properties.Items.Add(c.Descricao));

            selecinaElemento1Cmb(cmbAccounts);
            selecinaElemento1Cmb(cmbPaymentMechanism);
            selecinaElemento1Cmb(cmbSerie);
            selecinaElemento1Cmb(cmbUser);
        }
        public void updateGrid()
        {
            List<ConfigCurrentAccount> config = _configAccountUserController.ListForUserId(_userController.ListAllAsNotracking()[cmbUser.SelectedIndex].Id);
            gdvControlConfig.DataSource = config;
            gdvControlConfig.RefreshDataSource();
        }
        private void btnAddConfig_Click(object sender, EventArgs e)
        {
            int idUser = _userController.ListAllAsNotracking()[cmbUser.SelectedIndex].Id;
            string idPaymentMechanism = _paymentWays.ListALL()[cmbPaymentMechanism.SelectedIndex].Id;

            ConfigCurrentAccount configAccount = _configAccountUserController.ListForUserIdPaymentId(idUser, idPaymentMechanism);

            if(configAccount == null)
            {
                configAccount = new ConfigCurrentAccount();
                configAccount.CurrentAccountId = _currentAccountController.ListALLAsNoTracking()[cmbAccounts.SelectedIndex].Id;
                configAccount.PaymentMechanismId = idPaymentMechanism;
                configAccount.UserId = idUser;
                _configAccountUserController.insert(configAccount);

                _configAccountUserController.Dispose();

                _configAccountUserController = new ConfigCurrentAccountController();

            }

            updateGrid();

        }

        private void cmbUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateGrid();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            int idSerie = _serieController.ListALL()[cmbSerie.SelectedIndex].Id;
            Methods.atualSerieId = idSerie;

            Close();
            _pdv.getSerie();
        }

        private void cmbPaymentMechanism_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
