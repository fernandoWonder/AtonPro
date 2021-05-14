using Appplication.Controller;
using Appplication.Statics;
using Domain.Domain.Entities;
using Domain.Domain.Entities.Documents;
using Domain.Domain.Entities.Financial;
using Domain.Domain.Entities.ProductStock;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Main.Views.Save;

namespace UI.Main.Views
{
    public partial class FrmEntryProducts : DevExpress.XtraEditors.XtraForm
    {
        StockController _stockController;
        StorageController _storageController;
        ProviderController _providerController;
        ProductEntryController _productEntry;
        ProductController _productController = new ProductController(); 
        PaymentMechanismController _paymentController = new PaymentMechanismController();
        CurrentAccountSystemController _currentAccountController = new CurrentAccountSystemController();

        int idArmazem = 0;


        
        public void toGridEntryProducts()
        {
            gdvGridEntryProducts.DataSource = _productEntry.view1("");
     //       gridViewProducts.Columns["id"].Visible = false;
            gdvGridEntryProducts.Update();
        }

        public FrmEntryProducts()
        {
            InitializeComponent();
    
            initialize();

           
        }

        public void initialize()
        {
           
            _stockController = new StockController();
            _providerController = new ProviderController();
            _storageController = new StorageController();
            _productEntry = new ProductEntryController();

            searchLookUpProvider.Properties.DataSource = _providerController.view3("");

            _storageController.List().ForEach(item => cmbStorage.Properties.Items.Add(item.Armazem));
            if (cmbStorage.Properties.Items.Count > 0)
                cmbStorage.SelectedIndex = 0;

            _paymentController.ListALL().ForEach(item => MethodsTable.combosAdd(cmbPayment ,item.Descricao));
            MethodsTable.itensCombosMaiorZeroSelect(cmbPayment);
            _currentAccountController.ListALL().ForEach(item => MethodsTable.combosAdd(cmbAccount, item.Descricao + " - " + item.NumeroConta));
            MethodsTable.itensCombosMaiorZeroSelect(cmbAccount);
            toGridEntryProducts();
        }

        Stock stock;

        public void cleanFields()
        {
            txtTaxa.Text = "0";
            txtQdade.Text = "0";
            txtPreco.Text = "0";
            txtLucro.Text = "0";
            txtPrecoMedio.Text = "";
            txtUltimoPreco.Text = "";
            txtTotal.Text = "0";
            txtPrecoVenda.Text = "0";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
         
        }

        private void txtQdade_EditValueChanged(object sender, EventArgs e)
        {
          
        }

        public decimal percentagemCalc(decimal value, decimal taxa)
        {
            return (value * (taxa/100 +1));
        }

        public decimal percentagemCalcReverse(decimal preco, decimal taxa)
        {
            return decimal.Parse(txtCiva.Text)/(taxa/100 + 1);
        }

        private void txtPrecoVenda_EditValueChanged(object sender, EventArgs e)
        {
           
        }
        
        private void cmbStorage_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void searchLUpProduct_EditValueChanged(object sender, EventArgs e)
        {
            
          
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gdvGridEntryProducts_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
          
        }

        private void txtQdade_EditValueChanged_1(object sender, EventArgs e)
        {
            try
            {
                txtTotal.Text = (decimal.Parse(txtPreco.Text) * decimal.Parse(txtQdade.Text)).ToString();
            }
            catch (Exception)
            {
                 
            }
        }

        private void searchLUpProduct_EditValueChanged_1(object sender, EventArgs e)
        {
            cleanFields();
            int idProduct = 0;
            if (searchLUpProduct.Text != "" && searchLUpProduct.Text != "Produto")
            {
         
                txtTaxa.Text = searchLUpProduct.Properties.View.GetFocusedRowCellValue("Taxa").ToString();
                idProduct = Convert.ToInt16(searchLUpProduct.Properties.View.GetFocusedRowCellValue("Id").ToString());
                stock = _stockController.getStockArmazemProduct(idProduct, idArmazem);

               

                txtPrecoAtual.Text = stock.Produto.Preco1.ToString();
                txtUltimoPreco.Text = stock.UltimoPreco.ToString();
                txtPrecoMedio.Text = stock.PrecoMedio.ToString();
            }
          

        }

        private void txtLucro_EditValueChanged_1(object sender, EventArgs e)
        {
            decimal precoVenda = percentagemCalc(decimal.Parse(txtPreco.Text), decimal.Parse(txtLucro.Text));
            txtPrecoVenda.Text = precoVenda.ToString("F2");
            if (txtTaxa.Text == "")
                txtTaxa.Text = "0";
            txtCiva.Text = percentagemCalc(decimal.Parse(txtPrecoVenda.Text), decimal.Parse(txtTaxa.Text)) + "";

        }

        private void cmbStorage_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbStorage.SelectedIndex != -1)
            {
                
                idArmazem = _storageController.List()[cmbStorage.SelectedIndex].Id;
                
                searchLUpProduct.Properties.DataSource = _stockController.viewProductStockArmazemForEntryAndRetreat(idArmazem);
                cleanFields();
            }
        }
        bool txtVendaFocus = false;
        private void txtPrecoVenda_EditValueChanged_1(object sender, EventArgs e)
        {
            if (txtVendaFocus)
            {
                if (txtTaxa.Text == "")
                    txtTaxa.Text = "0";
                txtCiva.Text = percentagemCalc(decimal.Parse(txtPrecoVenda.Text), decimal.Parse(txtTaxa.Text)) + "";
                if (decimal.Parse(txtPreco.Text) != 0)
                    calcPercentLucro();
            }
        }

        private void txtPreco_EditValueChanged(object sender, EventArgs e)
        {
            decimal total = (decimal.Parse(txtPreco.Text) * decimal.Parse(txtQdade.Text));
            total += decimal.Parse(txtTaxa.Text);
            txtTotal.Text = total.ToString();

            decimal precoVenda = percentagemCalc(decimal.Parse(txtPreco.Text), decimal.Parse(txtLucro.Text));
            txtPrecoVenda.Text = precoVenda.ToString();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (!(searchLookUpProvider.Text != "" && searchLookUpProvider.Text != "Fornecedor"))
            {
                MessageBox.Show("Selecione um fornecedor..!");
            }
            else if (stock != null)
            {
                ProductEntry productEntry;
                decimal qdade = decimal.Parse(txtQdade.Text);

                stock.Quantidade += qdade;
                stock.UltimoPreco = decimal.Parse(txtPreco.Text);
                stock.PrecoMedio = (stock.PrecoMedio + stock.UltimoPreco) / 2;

                int idProvider = Convert.ToInt16(searchLookUpProvider.Properties.View.GetFocusedRowCellValue("Id").ToString());
                string idPaymentWay = _paymentController.ListALL()[cmbPayment.SelectedIndex].Id.ToString();
                int idAccounSystem = _currentAccountController.ListALLAsNoTracking()[cmbAccount.SelectedIndex].Id;

                CurrentAccountSystem account = _currentAccountController.getOne(idAccounSystem);
                account.Saldo -= decimal.Parse(txtTotal.Text);

                productEntry = new ProductEntry()
                {
                    FornecedorId = idProvider,
                    ProdutoId = stock.ProdutoId,
                    Taxa = decimal.Parse(txtTaxa.Text),
                    Preco = stock.UltimoPreco,
                    Quantidade = qdade,
                    PrecoTotal = stock.UltimoPreco * qdade,
                    ContaDebitadaId = idAccounSystem,
                    FormaPagamentoId = idPaymentWay,
                };

                if (cbAplicaNovoPreco.Checked)
                {
                    int pEntrePrecos = int.Parse(txtPentrePs.Text);
                    stock.Produto.Preco1 = decimal.Parse(txtPrecoVenda.Text);
                    stock.Produto.Preco2 = stock.Produto.Preco1 + (stock.Produto.Preco1 * pEntrePrecos / 100);
                    stock.Produto.Preco3 = stock.Produto.Preco2 + (stock.Produto.Preco2 * pEntrePrecos / 100);
                }

                if (_stockController.update(stock) == 0 || _productEntry.insert(productEntry) == 0 ||
                    _currentAccountController.update(account) == 0)
                {
                    MessageBox.Show("Houve um erro ao atualizar stock");
                }
                else
                {

                    searchLUpProduct.Text = "";
                    cleanFields();
                    Methods.playSuccess();
                    toGridEntryProducts();
                }

            }
            else
                MessageBox.Show("Selecione um Produto..!");
        }

        private void btnAddProduto_Click(object sender, EventArgs e)
        {

        }

        private void txtTaxa_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void searchLookUpProvider_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void cbAplicaNovoPreco_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtPrecoVenda_Enter(object sender, EventArgs e)
        {
            txtVendaFocus = true;
        }

        private void txtPrecoVenda_Leave(object sender, EventArgs e)
        {
            txtVendaFocus = false;
        }
        bool txtIvaFocus = false;
        private void txtCiva_EditValueChanged(object sender, EventArgs e)
        {
            if (txtIvaFocus)
            {
                if (txtTaxa.Text == "")
                    txtTaxa.Text = "0";
                txtPrecoVenda.Text = percentagemCalcReverse(decimal.Parse(txtPrecoVenda.Text), decimal.Parse(txtTaxa.Text)) + "";
                if (decimal.Parse(txtPreco.Text) != 0)
                    calcPercentLucro();
            }
        }

        private void calcPercentLucro()
        {
            txtLucro.Text = Convert.ToInt16((decimal.Parse(txtPrecoVenda.Text) - decimal.Parse(txtPreco.Text)) * 100 / decimal.Parse(txtPreco.Text)) + "";
        }

        private void txtCiva_Leave(object sender, EventArgs e)
        {
            txtIvaFocus = false;
        }

        private void txtCiva_Enter(object sender, EventArgs e)
        {
            txtIvaFocus = true;
        }
    }
}
