using Appplication.Controller;
using Domain.Domain.Entities;
using System;
using System.Windows.Forms;

namespace UI.Main.Views.Save
{
    public partial class FrmFornecedorSave : DevExpress.XtraEditors.XtraForm
    {
        FrmFornecedoresView _frmProviderView;
        FrmCostumersView _frmCustomerView;

        CityController _cityController = new CityController();
        ProviderController _providerController;
        CustomerController _customerController;

        Customer _customerEding = null;

        int qualCtor = 1; bool fornecedor;
        public FrmFornecedorSave(bool Fornecedor)
        {
            InitializeComponent();
            toCmbCity();
            fornecedor = Fornecedor;
            if (!fornecedor)
            {
                this.Text = "ClienteSave";
                lblTitle.Text = "Cliente";
                pnlCostumer.Visible = true;
                _customerController = new CustomerController();
            }else
                _providerController = new ProviderController();
            
        }

        public FrmFornecedorSave(FrmFornecedoresView frmFornecedorView)
        {
            InitializeComponent();
            qualCtor = 2;
            _providerController = new ProviderController();
            toCmbCity();
            _frmProviderView = frmFornecedorView;
        }
        
        public FrmFornecedorSave(FrmCostumersView frmCustomersView, int customerID)
        {
            InitializeComponent();

            qualCtor = 3;
            this.Text = "ClienteSave";
            lblTitle.Text = "Cliente";
            pnlCostumer.Visible = true;
            _customerController = new CustomerController();

            if(customerID > 0)
            {
                _customerEding = _customerController.getOne(customerID);
                fullCustomerDataToEdit();
            }
                
            toCmbCity();
            _frmCustomerView = frmCustomersView;
        }

        private void fullCustomerDataToEdit()
        {
            mskTxtPostal.Text = _customerEding.Postal;
            txtAddress.Text = _customerEding.Endereco;
            txtEmail.Text = _customerEding.Email;
            txtFax.Text = _customerEding.Fax;
            txtNif.Text = _customerEding.Nif;
            txtTel.Text = _customerEding.Tel;
            txtProvider.Text = _customerEding.Cliente;
            cmbCity.SelectedText = _customerEding.Cidade.Cidade;
            cmbSexo.SelectedText = _customerEding.Sexo;

            if (_customerEding.Faturas.Count > 0)
            {
                if (_customerEding.Nif.Contains("999999"))
                {
                    txtProvider.Enabled = false;
                }
                else
                {
                    txtNif.Enabled = false;
                }
            }

        }

        public void toCmbCity()
        {
            cmbCity.Properties.Items.Clear();
            _cityController.ListALLAsNoTracking().ForEach(item => cmbCity.Properties.Items.Add(item.Cidade));
            if (cmbCity.Properties.Items.Count > 0)
                cmbCity.SelectedIndex = 0;
        }

        public bool haveEmptyField()
        {
            if(txtProvider.Text.Trim() != "" && txtTel.Text.Trim() != "" && txtAddress.Text.Trim() != "")
                return false;
            return true;
        }

        int cityID;
        private void btnSave_Click(object sender, EventArgs e)
        {
             }

        private void saveCustomer()
        {
            Customer customer = new Customer()
            {
                CidadeId = cityID,
                Cliente = txtProvider.Text.Trim(),
                Nif = txtNif.Text.Trim() == string.Empty || txtNif.Text.Length < 8 ? "999999999" : txtNif.Text,
                Email = txtEmail.Text.Trim(),
                Endereco = txtAddress.Text.Trim(),
                Tel = txtTel.Text.Trim(),
                Sexo = cmbSexo.SelectedIndex == 0 ? "M" : "F",
                DataNascimento = dtpDataNascimento.Value,
                Postal = mskTxtPostal.Text.Trim() != "" ? mskTxtPostal.Text : "",
                Fax = txtFax.Text.Trim() != "" ? txtFax.Text.Trim() : ""
            };

           /* if (_customerController.insert(customer) == 0)
                MessageBox.Show("Erro ao inserir cliente...");
            */
            if (_customerEding != null)
            {
                customer.Id = _customerEding.Id;
                _customerController.Dispose();
                _customerController = new CustomerController();
                _customerController.update(customer);
            }
            else
                _customerController.insert(customer);

            if(qualCtor == 3)
                _frmCustomerView.toGridControlCustomers();
        }
        private void saveProvider()
        {
            Provider provider = new Provider()
            {
                CidadeId = cityID,
                Fornecedor = txtProvider.Text.Trim(),
                Nif = txtNif.Text.Trim() == string.Empty || txtNif.Text.Length < 8 ? "999999999" : txtNif.Text,
                Email = txtEmail.Text.Trim(),
                Endereco = txtAddress.Text.Trim(),
                Tel = txtTel.Text.Trim(),
                Postal = mskTxtPostal.Text.Trim() != "" ? mskTxtPostal.Text : "",
                UrlSite = txtUrlSite.Text.Trim() != "" ? txtUrlSite.Text.Trim() : "",
                Fax = txtFax.Text.Trim() != "" ? txtFax.Text.Trim() : ""
            };

            if (_providerController.insert(provider) == 0)
                MessageBox.Show("Erro ao inserir...");

            if (qualCtor == 2)
            {
                if (_frmProviderView.ctor == 2)
                    _frmProviderView.toGvdProviderControlWithProducts();
                else if (_frmProviderView.ctor == 1)
                    _frmProviderView.toGvdProviderControl();
            }
        }

        private void clearFields()
        {
            mskTxtPostal.Text = "";
            txtAddress.Text = "";
            txtEmail.Text = "";
            txtFax.Text = "";
            txtNif.Text = "";
            txtTel.Text = "";
            txtProvider.Text = "";
            txtUrlSite.Text = "";
            cmbCity.SelectedIndex = 0;
            cmbSexo.SelectedIndex = 0;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            cityID = _cityController.ListALLAsNoTracking()[cmbCity.SelectedIndex].Id;
            if (!haveEmptyField())
            {
                if (qualCtor == 2 || fornecedor)
                {
                    saveProvider();
                }
                else if (qualCtor == 3 || !fornecedor)
                {
                    saveCustomer();
                }
                Close();

                clearFields();
            }
            else
                MessageBox.Show("Preencha todos os campos obrigatórios *");

        }

        private void btnNewCity_Click(object sender, EventArgs e)
        {

        }
    }
}
