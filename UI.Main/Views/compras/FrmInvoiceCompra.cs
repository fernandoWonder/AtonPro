using Appplication.Controller;
using Domain.Domain.Entities;
using Domain.Domain.Entities.Documents;
using Domain.Domain.Entities.ProductStock;
using Domain.Domain.Entities.Temp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Main.Views.compras
{
    public partial class FrmInvoiceCompra : Form
    {
        StockController _stockController;
        StorageController _storageController;
        ProviderController _providerController;
        ProductEntryController _productEntry;
        ProductController _productController = new ProductController();
        PaymentMechanismController _paymentController = new PaymentMechanismController();
        CurrentAccountSystemController _currentAccountController = new CurrentAccountSystemController();
        Stock stock;

        int idArmazem = 0;
        int idProvider = 0;



        StockController _stock = new StockController();
        Invoice lastInvoice;

        List<ProductsSelectedSell> __listaSelected = new List<ProductsSelectedSell>();

        int _codigoFaturaAtual = 1;
        int idSerie = 0;
        int ClienteID;
        Customer cliente;
        string idTipoDocumento = "0";
        decimal totalIncidencia = 0;
        decimal TotalIva = 0;
        decimal totDescontoProducts = 0;
        decimal descontoFatura = 0;
        decimal valorPago = 0;
        decimal troco = 0;
        decimal totGeral = 0;
        string obs = "";

        public FrmInvoiceCompra()
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
        }

      /*  public void toGridEntryProducts()
        {
            gdvGridEntryProducts.DataSource = _productEntry.view1("");
            //       gridViewProducts.Columns["id"].Visible = false;
            gdvGridEntryProducts.Update();
        }*/

        public decimal percentagemCalc(decimal value, decimal porCento)
        {
            return (value * porCento / 100) + value;
        }

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

        private void cmbStorage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStorage.SelectedIndex != -1)
            {
                idArmazem = _storageController.List()[cmbStorage.SelectedIndex].Id;

                searchLUpProduct.Properties.DataSource = _stockController.viewProductStockArmazemForEntryAndRetreat(idArmazem);
                cleanFields();
            }
        }

        private void txtPrecoVenda_EditValueChanged(object sender, EventArgs e)
        {
            if (txtTaxa.Text == "")
                txtTaxa.Text = "0";
            txtCiva.Text = percentagemCalc(decimal.Parse(txtPrecoVenda.Text), decimal.Parse(txtTaxa.Text)) + "";
            if (decimal.Parse(txtPreco.Text) != 0)
                txtLucro.Text = Convert.ToInt16((decimal.Parse(txtPrecoVenda.Text) - decimal.Parse(txtPreco.Text)) * 100 / decimal.Parse(txtPreco.Text)) + "";
        }

        private void txtPreco_EditValueChanged(object sender, EventArgs e)
        {
            decimal total = (decimal.Parse(txtPreco.Text) * decimal.Parse(txtQdade.Text));
            total += total * decimal.Parse(txtTaxa.Text);
            txtTotal.Text = total.ToString();

            decimal precoVenda = percentagemCalc(decimal.Parse(txtPreco.Text), decimal.Parse(txtLucro.Text));
            txtPrecoVenda.Text = precoVenda.ToString();
        }

        private void bunifuBtnSave_Click(object sender, EventArgs e)
        {
            /*
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
                */
        }

        private void txtLucro_EditValueChanged(object sender, EventArgs e)
        {
            decimal precoVenda = percentagemCalc(decimal.Parse(txtPreco.Text), decimal.Parse(txtLucro.Text));
            txtPrecoVenda.Text = precoVenda.ToString();
        }

        private void searchLUpProduct_EditValueChanged(object sender, EventArgs e)
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

        private void txtQdade_EditValueChanged(object sender, EventArgs e)
        {
            txtTotal.Text = (decimal.Parse(txtPreco.Text) * decimal.Parse(txtQdade.Text)).ToString();
        }

        private void searchLookUpProvider_EditValueChanged(object sender, EventArgs e)
        {
            idProvider = Convert.ToInt16(searchLookUpProvider.Properties.View.GetFocusedRowCellValue("Id").ToString());
            txtSaldoProvider.Text = _providerController.getSaldo(idProvider).ToString("F2");
        }
    }
}
