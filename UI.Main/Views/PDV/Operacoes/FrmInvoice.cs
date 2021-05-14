using Appplication.Controller;
using Appplication.Statics;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using Domain.Domain.Entities;
using Domain.Domain.Entities.Documents;
using Domain.Domain.Entities.Financial;
using Domain.Domain.Entities.ProductStock;
using Domain.Domain.Entities.Temp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Main.Views.Report;
using UI.Main.Views.Save;

namespace UI.Main.Views.Operacoes
{
    public partial class FrmInvoice : Form
    {
        
        PaymentMechanismController _paymentWays = new PaymentMechanismController();
        SerieController _serieController = new SerieController();
        InvoiceTypeController _invoiceTypeController = new InvoiceTypeController();
        InvoiceController _invoiceController = new InvoiceController();
        ProductEntryController _productEntryController = new ProductEntryController();
        CustomerController _customerController = new CustomerController();
        ProductSalesController _sales = new ProductSalesController();
        ProductsSelectedSellController _productsSelectedSellController = new ProductsSelectedSellController();
        ConfigCurrentAccountController _configAccountController = new ConfigCurrentAccountController();
        CurrentAccountSystemController _currentAcountSystemController = new CurrentAccountSystemController();

        ProductController _products = new ProductController();

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

        public FrmInvoice()
        {
            InitializeComponent();
            initialize();

            //Stock stock = _stock.getStockArmazemProduct()
        }
        
        public FrmInvoice(string ft)
        {
            InitializeComponent();
            initialize();
            cmbInvoiceType.Text = ft;
            this.Text = cbInvoiceName.Text;
            //Stock stock = _stock.getStockArmazemProduct()
        }

        /* public bool verificaData()
         {
             Invoice ivlast = _invoiceController.ListALLAsNoTracking().LastOrDefault();
             if(ivlast != null)
             {
                 if(ivlast.DataCadastro > DateTime.Now)
                 {
                     MessageBox.Show("Verifique se a data do Sistema está correta..!");
                     return false;
                 }
             }
             return true;
         }*/


 
        public void salvar()
        {
            //Series serie = _serieController.ListALLAsNoTracking()[cmbSerie.SelectedIndex];
            try
            {
                CalcCodigoFaturaAtual();
                obs = txtDescricao.Text;
                string invoiceNo = getInvoiceTypeTipo() + " " + _serieController.ListALLAsNoTracking()[cmbSerie.SelectedIndex].Serie + "/" + _codigoFaturaAtual;
                DateTime dataAtual = DateTime.Now;

                //string GrossTotal = (TotalIva + totalIncidencia).ToString("F").Replace(',', '.');
                string GrossTotal = (totGeral).ToString("F3").Replace(',', '.');
                //   string dadosHash2 = dataAtual.ToString("yyyy-MM-dd") + ";" + dataAtual.ToString("yyyy-MM-ddTHH:mm") + ";" + invoiceNo + ";" + (TotalIva + totalIncidencia).ToString("N2").Replace(",", ".") + ";";
                string dadosHash = dataAtual.ToString("yyyy-MM-dd") + ";" + dataAtual.ToString("yyyy-MM-ddTHH:mm:ss") + ";" + invoiceNo + ";" + GrossTotal + ";";
                dadosHash += lastInvoice != null ? lastInvoice.Hash : "";
                //dadosHash = lastInvoice != null ? dadosHash + lastInvoice.Hash : dadosHash;

                string Hash = Methods.gerarHash(dadosHash, invoiceNo);

                Invoice invoice = new Invoice()
                {
                    InvoiceDate = dataAtual.ToString("yyyy-MM-dd"),
                    Codigo = _codigoFaturaAtual,
                    ClienteId = ClienteID,
                    SeriesId = idSerie,
                    InvoiceNo = invoiceNo,
                    TipoDocumentoId = idTipoDocumento,
                    Desconto = totDescontoProducts,
                    Observacao = obs,
                    TotalImposto = TotalIva,
                    TotalIncidencia = totalIncidencia,
                    TotalLiquidar = cmbInvoiceType.Text == "FT" ? totalIncidencia + TotalIva : 0,
                    UserId = UserCurrent.getCurrentUser().Id,
                    Troco = troco,
                    ValorPago = valorPago,
                    FormaPagamentoId = cmbInvoiceType.Text == "FT" ? "CD" : cmbInvoiceType.Text == "PP" || cmbInvoiceType.Text == "FP" ? null : _paymentWays.ListALLAsNoTracking()[cmbPaymentMechanism.SelectedIndex].Id,
                    DataCadastro = dataAtual,
                    Hash = Hash,
                    DataVencimento = dtVencimento.Enabled ? dtVencimento.Value : DateTime.Now,
                    
                };
                _invoiceController.insert(invoice);

                invoice = _invoiceController.getForInvoiceNo(invoiceNo);
                int idFatura = invoice != null ? invoice.Id : 0;

                if (idFatura == 0)
                    MessageBox.Show("Fatura Nula");
                _invoiceController.Dispose();
                _invoiceController = new InvoiceController();
                /*string dadosHash = invoice.InvoiceDate + ";" + invoice.DataCadastro.ToString("yyyy-MM-ddTHH:mm:ss") + ";" + invoice.InvoiceNo + ";" + invoice.TotalGeral.ToString("N2").Replace(",", ".") + ";";
                string dadosHash2 = invoice.InvoiceDate + ";" + invoice.DataCadastro.ToString("yyyy-MM-ddTHH:mm") + ";" + invoice.InvoiceNo + ";" + invoice.TotalGeral.ToString("N2").Replace(",", ".") + ";";
                dadosHash = lastInvoice != null ? dadosHash2 + lastInvoice.Hash : dadosHash;
                invoice.Hash = Methods.gerarHash(dadosHash);*/


                CurrentAccountSystem currentAccountSystem = _currentAcountSystemController.ListALL()[cmbConta.SelectedIndex];
                currentAccountSystem.Saldo += invoice.TotalGeral;
                _currentAcountSystemController.update(currentAccountSystem);



                foreach (var item in __listaSelected)
                {
                    Stock stock = _stock.getStockArmazemProduct(item.ProdutoId, item.Stock.ArmazemId);
                    stock.Quantidade -= item.Quantidade;
                    _stock.update(stock);

                    string movitoISE = null;
                    Product product = _products.getOne(item.ProdutoId);
                    if (product.MotivoISEId != null)
                        movitoISE = product.MotivoISE.MencaoFatura;


                    ProductSales productSale = new ProductSales()
                    {
                        Preco = item.Preco,
                        FaturaId = idFatura,
                        ProductId = item.ProdutoId,
                        Desconto = item.Desconto,
                        Descricao_Produto = product.Descricao,
                        Quantidade = item.Quantidade,
                        StockId = item.StockId,
                        Taxa = product.CodigoTaxa.Taxa,
                        Unidade = product.UnidadeBase.Simbolo,
                        MotivoISEId = product.MotivoISEId,
                        MotivoIsencao = movitoISE,
                    };

                    _sales.insert(productSale);
                }

                __listaSelected.Clear();
                gdvControlProducts.DataSource = __listaSelected;
                gdvControlProducts.RefreshDataSource();
                CalcCodigoFaturaAtual();
                print(idFatura);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        public void initialize()
        {
            cmbInvoiceType.Properties.Items.Clear();
            cmbSerie.Properties.Items.Clear();
            cbInvoiceName.Items.Clear();
            cmbPaymentMechanism.Properties.Items.Clear();
            cmbConta.Properties.Items.Clear();
            cmbFormaPagamentoRecibo.Properties.Items.Clear();

            _currentAcountSystemController.ListALL().ForEach(c => cmbConta.Properties.Items.Add(c.Descricao));
            if (cmbConta.Properties.Items.Count > 0)
                cmbConta.SelectedIndex = 0;

            _serieController.ListALLAsNoTracking().ForEach(item => cmbSerie.Properties.Items.Add(item.Serie));
            _paymentWays.ListALLAsNoTracking().ForEach(item => cmbFormaPagamentoRecibo.Properties.Items.Add(item.Descricao));
            _paymentWays.ListALLAsNoTracking().ForEach(item => cmbPaymentMechanism.Properties.Items.Add(item.Descricao));
            if (cmbPaymentMechanism.Properties.Items[cmbPaymentMechanism.Properties.Items.Count - 1].ToString() == "Venda Crédito")
            {
                cmbPaymentMechanism.Properties.Items.RemoveAt(cmbPaymentMechanism.Properties.Items.Count - 1);
                cmbFormaPagamentoRecibo.Properties.Items.RemoveAt(cmbPaymentMechanism.Properties.Items.Count - 1);
            }

            foreach (var item in _invoiceTypeController.ListALLAsNoTracking().Where(c => c.Id != "10" && c.Purchase == false && c.Seller == true).ToList())
            {
                cmbInvoiceType.Properties.Items.Add(item.Tipo);
                cbInvoiceName.Items.Add(item.Descricao);
            }
            if (cmbInvoiceType.Properties.Items.Count > 0)
            {
                cmbInvoiceType.SelectedIndex = 0;
                cbInvoiceName.SelectedIndex = 0;
            }
            if (cmbSerie.Properties.Items.Count > 0)
                cmbSerie.SelectedIndex = 0;
            cmbFormaPagamentoRecibo.SelectedIndex = 0;
            toGridUpdate();

        }

        public string getInvoiceTypeId()
        {
            return _invoiceTypeController.ListALLAsNoTracking().Where(c => c.Id != "10" && c.Purchase == false && c.Seller == true).ToList()[cmbInvoiceType.SelectedIndex].Id;
        }

        public string getInvoiceTypeTipo()
        {
            return _invoiceTypeController.ListALLAsNoTracking().Where(c => c.Id != "10" && c.Purchase == false && c.Seller == true).ToList()[cmbInvoiceType.SelectedIndex].Tipo;
        }

        void toGridUpdate()
        {
            gdvControlProducts.DataSource = __listaSelected;
            gdvControlProducts.RefreshDataSource();
        }

        public void serieUpdate()
        {
            cmbSerie.Properties.Items.Clear();
            _serieController.ListALLAsNoTracking().ForEach(item => cmbSerie.Properties.Items.Add(item.Serie));
            if (cmbSerie.Properties.Items.Count > 0)
                cmbSerie.SelectedIndex = 0;
        }

        public void CalcCodigoFaturaAtual()
        {
            lblFirstDoc.Visible = false;
            if (cmbSerie.SelectedIndex != -1)
                idSerie = _serieController.ListALLAsNoTracking()[cmbSerie.SelectedIndex].Id;
            if(cmbInvoiceType.SelectedIndex != -1)
                idTipoDocumento = getInvoiceTypeId();

            _codigoFaturaAtual = 1;
            lastInvoice = _invoiceController.lastInvoiceInSerieAndType(idSerie, idTipoDocumento);
                
            if(lastInvoice != null)
            {
                _codigoFaturaAtual += lastInvoice.Codigo;
            }
            else if(idSerie > 0 && idTipoDocumento == "RC" )
            {
                lblFirstDoc.Visible = true;
            }
            txtCodigoFatura.Text = _codigoFaturaAtual + "";
        }

        private void btbLimpar_Click(object sender, EventArgs e)
        {
            clear();
        }

        public void print(int idFatura)
        {
            FrmReportView frm = new FrmReportView();
            frm.PrintInvoce(idFatura);
            frm.Show();
        }

        public void updateTots()
        {
            totalIncidencia = 0;
            TotalIva = 0;
            totDescontoProducts = 0;

            foreach (var item in __listaSelected)
            {
                totalIncidencia += item.TotalIncidencia;
                totDescontoProducts += item.ValorDesconto;
                TotalIva += item.TotalTaxa;
            }

            //totGeral = totalIncidencia + TotalIva;   
            //Desconto e feito apos somar o valor do iva
            
            totGeral = totalIncidencia + TotalIva;

            toTotals();
        }

        public void addToList(int idStock)
        {
            
            bool haveOlready = false;
            Stock stock = _stock.getOne(idStock);

            foreach (var item in __listaSelected)
            {
                if (item.ProdutoId == stock.ProdutoId)
                    haveOlready = true;
            }
            if (!haveOlready)
            {
                ProductsSelectedSell prodSelectedSell = new ProductsSelectedSell()
                {
                    ProdutoId = stock.ProdutoId,
                    Produto = stock.Produto,
                    Stock = stock,
                    StockId = stock.Id,
                    Preco = _products.getOne(stock.ProdutoId).Preco1,
                    Quantidade = 1,
                    Desconto = descontoFatura,
                };
               
                __listaSelected.Add(prodSelectedSell);
                gdvControlProducts.DataSource = __listaSelected;
                gdvControlProducts.RefreshDataSource();

                updateTots();

            }
            else
                MessageBox.Show("O produto desejado já faz parte da lista!");

        }

        public void toTotals()
        {
            txtTotDescontoProdutos.Text = totDescontoProducts.ToString("N2");
            txtIVA.Text = TotalIva.ToString("N2");
            txtTotal.Text = totalIncidencia.ToString("N2");

            txtTotalGeral.Text = totGeral.ToString("N2");

            if (ckAuto.Checked)
                txtValorPago.Text = totGeral.ToString("N2");
            else
            {
                txtValorPago.Text = "0";
            }
        }

        private void cmbInvoiceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbInvoiceName.SelectedIndex = cmbInvoiceType.SelectedIndex;
            CalcCodigoFaturaAtual();
            btnCarregarFaturas.Visible = panelRc.Visible = cmbInvoiceType.Text == "RC" || cmbInvoiceType.Text == "RE" ?  true : false;

            panelRc.Visible = cmbInvoiceType.Text == "RC" ? !(panelDocuments.Visible = false) : !(panelDocuments.Visible = true);
            if (panelRc.Visible)
            {
                if (ClienteID > 0)
                {
                    _customerController.Dispose();
                    _customerController = new CustomerController();
                    cliente = _customerController.getOne(ClienteID);
                    _clienteInvoices = cliente.Faturas.Where(c => (c.TipoDocumento.Tipo == "FT" || c.TipoDocumento.Tipo == "FR") && c.TotalLiquidar > 0).ToList();
                    gridControlFaturasCliente.DataSource = _clienteInvoices;
                    gridControlFaturasCliente.RefreshDataSource();
                    //updateFaturasClientes();
                }
            }

            if (cmbInvoiceType.Text == "FT")
            {
                cmbPaymentMechanism.Text = "Venda Crédito";
                cmbPaymentMechanism.Enabled = false;// Transferência Bancária
                dtVencimento.Enabled = true;
                txtValorPago.Enabled = false;
            }
            else if (cmbInvoiceType.Text == "FP" || cmbInvoiceType.Text == "PP")
            {
                cmbPaymentMechanism.Text = "";
                cmbPaymentMechanism.Enabled = false;// Transferência Bancária
                dtVencimento.Enabled = true;
                txtValorPago.Enabled = false;
            }
            else
            {
                cmbPaymentMechanism.SelectedIndex = 0;
                cmbPaymentMechanism.Enabled = true; // Transferência Bancária
                dtVencimento.Enabled = false;
                txtValorPago.Enabled = true;
            }

        }

        private void FrmInvoice_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eFTeste2DataSet.Livro' table. You can move, or remove it, as needed.
            
            searchLUpCustomer.Properties.DisplayMember = "Cliente";
            searchLUpCustomer.Properties.DataSource = _customerController.view3("");

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(cmbPaymentMechanism.Enabled && cmbPaymentMechanism.Text.Contains("Cr"))
            {
                MessageBox.Show("A forma de pagamento para este documento não pode a ser 'Crédito' !");
            }
            else 
            if(searchLUpCustomer.Text.Contains("Id") || searchLUpCustomer.Text == "")
                MessageBox.Show("Escolha um cliente");
            else if(gridView1.RowCount == 0)
                MessageBox.Show("Adicione pelomenos um produto à lista!");
            else if (!MethodsTable.itensCombosMaiorZero(cmbSerie))
            {
                MessageBox.Show("Nenhuma Série encotrada!");
            }
            else if (!Methods.verificaData())
            {
                MessageBox.Show("Verifique se a data do Sistema está correta..!");
            }
            else
            {
                totalIncidencia = 0;
                TotalIva = 0;
                foreach (var item in __listaSelected)
                {
                    totalIncidencia += item.TotalIncidencia;
                    TotalIva += item.TotalTaxa;
                }

                salvar();
            }
        }

        public void clear()
        {
            cmbInvoiceType.SelectedIndex = 0;
            txtDesconto.Text = "";
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            new FrmProdutoView(this).ShowDialog();
        }

        private void cmbSerie_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcCodigoFaturaAtual();
        }

        private void txtValorPago_EditValueChanged(object sender, EventArgs e)
        {
            valorPago = decimal.Parse(txtValorPago.Text);
            troco = valorPago - decimal.Parse(txtTotalGeral.Text);
            txtTroco.Text = troco + "";
        }

        private void ckAuto_CheckedChanged(object sender, EventArgs e)
        {
            if (ckAuto.Checked)
                txtValorPago.Text = txtTotalGeral.Text;
        }

        string oldValue = "0";
        private void txtDesconto_EditValueChanged(object sender, EventArgs e)
        {
            descontoFatura = decimal.Parse(txtDesconto.Text.Replace("%", ""));
            if (descontoFatura <= 100 && descontoFatura >= 0)
            {
                oldValue = descontoFatura.ToString();
                /*for (int i = 0; i < __listaSelected.Count; i++)
                {
                    __listaSelected[i].Desconto = descontoFatura;
                }*/
                foreach (var item in __listaSelected)
                {
                    item.Desconto = descontoFatura;
                    //totDescontoProducts += item.ValorDesconto;
                    //TotalIva += item.TotalTaxa;
                }
                toGridUpdate();
                updateTots();
            }
                
            else
            {
                descontoFatura = decimal.Parse(oldValue);
                txtDesconto.Text = oldValue;
              //  updateTots();
            }
        }
        // ==================================================================================
        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if(e.Column.Name == "Qdade")
            {
                int value = Convert.ToInt16(e.Value);
                if(value <= 0)
                {
                    __listaSelected[e.RowHandle].Quantidade = 1;
                    gdvControlProducts.DataSource = __listaSelected;
                    gdvControlProducts.RefreshDataSource();
                }
            }
            if (e.Column.Name == "Preco")
            {
                decimal value = decimal.Parse(e.Value.ToString());
                if (value <= 0)
                {
                    MessageBox.Show("O preço não pode ser <= 0");

                    __listaSelected[e.RowHandle].Preco = 1;
                    gdvControlProducts.DataSource = __listaSelected;
                    gdvControlProducts.RefreshDataSource();
                }
            }
            if (e.Column.Name == "Desconto")
            {
                decimal value = decimal.Parse(e.Value.ToString());
                if (value < 0 || value > 100)
                {
                    __listaSelected[e.RowHandle].Desconto = 0;
                    gdvControlProducts.DataSource = __listaSelected;
                    gdvControlProducts.RefreshDataSource();
                }
            }
            updateTots();
        }

        private void cmbPaymentMechanism_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbConta.Properties.Items.Count > 0 && cmbPaymentMechanism.SelectedIndex != -1)
            {
                string idPaymentWay = _paymentWays.ListALL()[cmbPaymentMechanism.SelectedIndex].Id;
                ConfigCurrentAccount _acount = _configAccountController.getForPaymentId(idPaymentWay);

                string conta;
                // Caso já tenha uma conta configurada para esse tipo de pagamento, essa será a conta selecionada
                if (_acount != null)
                {
                    conta = _acount.CurrentAccount.Descricao;
                    if (cmbConta.Properties.Items.Count > 0)
                        cmbConta.SelectedItem = conta;
                }

            }
            
            
        }

        // ===================================== Recibo ================================================================
        List<Invoice> _clienteInvoices;
        List<PaymentsRecibos> _faturasSelecionadas = new List<PaymentsRecibos>();
        decimal totRecibo = 0;
        private void btnCarregarFaturas_Click(object sender, EventArgs e)
        {  
            if (ClienteID > 0)
            {
                _customerController.Dispose();
                _customerController = new CustomerController();
                cliente = _customerController.getOne(ClienteID);
                _clienteInvoices = cliente.Faturas.Where(c => c.TipoDocumento.Tipo == "FT").ToList();

                _clienteInvoices = cliente.Faturas.Where(c => c.TipoDocumento.Tipo == "FT").ToList();
                gridControlFaturasCliente.DataSource = _clienteInvoices;
                gridControlFaturasCliente.RefreshDataSource();
                //updateFaturasClientes();
            }

        }

        private void searchLUpCustomer_EditValueChanged(object sender, EventArgs e)
        {
            ClienteID = Convert.ToInt16(searchLUpCustomer.Properties.View.GetFocusedRowCellValue("Id").ToString());
            cliente = _customerController.getOne(ClienteID);

            if(cmbInvoiceType.Text == "RC" || cmbInvoiceType.Text == "RE")
            {
                _clienteInvoices = cliente.Faturas.Where(c => (c.TipoDocumento.Tipo == "FT" || c.TipoDocumento.Tipo == "FR") && c.TotalLiquidar > 0).ToList();
                updateFaturasClientes();
            }

        }

        public decimal getTaxaInvoice(Invoice iv)
        {
            decimal taxa = 0;
            foreach (var item in iv.ProductsSales.ToList())
            {
                if (item.Taxa > taxa)
                    taxa = item.Taxa;
            }
            return taxa;
        }

        private void btnAddPagamento_Click(object sender, EventArgs e)
        {
            if(_clienteInvoices.Count > 0)
            {
                int indexRow = gridViewFaturasCliente.GetSelectedRows()[0];
                bool alreadySelected = false;

                Invoice ivSelected = _clienteInvoices[indexRow];

                foreach (var item in _faturasSelecionadas)
                {
                    if (item.FaturaId == ivSelected.Id)
                        alreadySelected = true;
                }

                if (!alreadySelected)
                {
                    _faturasSelecionadas.Add(new PaymentsRecibos()
                    {
                        Descricao = "Liquidação da fatura " + ivSelected.InvoiceNo,
                        ValorPago = decimal.Parse(txtValorLiquidar.Text),
                        Taxa = getTaxaInvoice(ivSelected),
                        FaturaId = ivSelected.Id,
                        //Taxa = ivSelected.ProductsSales.Where(c => c.Taxa == 14).ToList().Count > 0 ? 14 : 0, // Depois achar uma forma de pegar a maior taxa e colocar aqui
                    });
                }

                // Cadastrar e pegar o Id da fatura - ftId

                updateFaturasSelecionadas();
            }
        }

        void updateFaturasClientes()
        {
            gridControlFaturasCliente.DataSource = _clienteInvoices;
            gridControlFaturasCliente.RefreshDataSource();
            _faturasSelecionadas.Clear();
            updateFaturasSelecionadas();
        }

        void updateFaturasSelecionadas()
        {
            gridControlFaturasSelecionadas.DataSource = _faturasSelecionadas;
            gridControlFaturasSelecionadas.RefreshDataSource();

            totRecibo = 0;
            foreach (var item in _faturasSelecionadas)
            {
                totRecibo += item.ValorPago;
            }
            lblTotalRecibo.Text = totRecibo.ToString("F3");
        }

        private void btnSaveRecibo_Click(object sender, EventArgs e)
        {
            if (!Methods.verificaData())
            {
                MessageBox.Show("Verifique se a data do Sistema está correta..!");
            }
            else if (_faturasSelecionadas.Count > 0)
            {

                CalcCodigoFaturaAtual();
                obs = txtDescricao.Text;
                string invoiceNo = getInvoiceTypeTipo() + " " + _serieController.ListALLAsNoTracking()[cmbSerie.SelectedIndex].Serie + "/" + _codigoFaturaAtual;
                DateTime dataAtual = DateTime.Now;

                //string GrossTotal = (TotalIva + totalIncidencia).ToString("F").Replace(',', '.');
                string GrossTotal = (totGeral).ToString("F3").Replace(',', '.');
                //   string dadosHash2 = dataAtual.ToString("yyyy-MM-dd") + ";" + dataAtual.ToString("yyyy-MM-ddTHH:mm") + ";" + invoiceNo + ";" + (TotalIva + totalIncidencia).ToString("N2").Replace(",", ".") + ";";
                string dadosHash = dataAtual.ToString("yyyy-MM-dd") + ";" + dataAtual.ToString("yyyy-MM-ddTHH:mm:ss") + ";" + invoiceNo + ";" + GrossTotal + ";";
                dadosHash += lastInvoice != null ? lastInvoice.Hash : "";
                //dadosHash = lastInvoice != null ? dadosHash + lastInvoice.Hash : dadosHash;

                string Hash = Methods.gerarHash(dadosHash, invoiceNo);

                Invoice documento = new Invoice()
                {
                    InvoiceDate = dataAtual.ToString("yyyy-MM-dd"),
                    Codigo = _codigoFaturaAtual,
                    ClienteId = ClienteID,
                    SeriesId = idSerie,
                    InvoiceNo = invoiceNo,
                    TipoDocumentoId = idTipoDocumento,
                    Observacao = obs,
                    UserId = UserCurrent.getCurrentUser().Id,
                    FormaPagamentoId = _paymentWays.ListALLAsNoTracking()[cmbFormaPagamentoRecibo.SelectedIndex].Id,
                    DataCadastro = dataAtual,
                    Hash = Hash,
                };
                _invoiceController.insert(documento);

                documento = _invoiceController.getForInvoiceNo(invoiceNo);
                int idFatura = documento != null ? documento.Id : 0;

                if (idFatura == 0)
                    MessageBox.Show("Fatura Nula");
                else
                {
                    _invoiceController.Dispose();
                    _invoiceController = new InvoiceController();

                }


                ReciboController _rcController = new ReciboController();

                int reciboId = 0; // Vai receber o id do recibo apos ser cadastrado


                Recibo recibo = new Recibo()
                {
                    DataUltimoEstadoPagamento = DateTime.Now,
                    DocumentoId = documento.Id,
                    UserUltimoEstadoDocumentoId = UserCurrent.getCurrentUser().Id,
                    TotalRecibo = decimal.Parse(lblTotalRecibo.Text),

                };
                _rcController.insert(recibo);
                recibo = _rcController.getForDocumentId(idFatura);

                reciboId = recibo != null ? recibo.Id : 0;

                if (reciboId == 0)
                    MessageBox.Show("Recibo Nulo");
                else
                {
                    salvarPagamentos(reciboId);
                    print(idFatura);
                    clearRecibo();
                }
            }
            else
            {
                MessageBox.Show("Nenhuma Fatura Selecionada");
            }
        }

        private void btnClearSelectedPayments_Click(object sender, EventArgs e)
        {
            _faturasSelecionadas.Clear();
            updateFaturasSelecionadas();
        }

        public void salvarPagamentos(int reciboId)
        {
            PaymentsRecibosController _paymentsRecibosController = new PaymentsRecibosController();

            // Cadastrar os pagamentos
            foreach (var item in _faturasSelecionadas)
            {
                item.ReciboId = reciboId;

                _paymentsRecibosController.insert(item);
                Invoice iv = _invoiceController.getOne(item.FaturaId);
                iv.TotalLiquidar -= item.ValorPago;
                _invoiceController.update(iv);
            }
        }

        public void clearRecibo()
        {
            _customerController.Dispose();
            _customerController = new CustomerController();

            cliente = _customerController.getOne(ClienteID);
            _clienteInvoices = cliente.Faturas.Where(c => (c.TipoDocumento.Tipo == "FT" || c.TipoDocumento.Tipo == "FR") && c.TotalLiquidar > 0).ToList();

            updateFaturasClientes();
        }

        private void gridViewFaturasSelecionadas_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            updateFaturasSelecionadas();
        }
        int row = -1;
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (row>=0)
            {
                __listaSelected.RemoveAt(gridView1.FocusedRowHandle);
                gdvControlProducts.DataSource = __listaSelected;
                gdvControlProducts.RefreshDataSource();
                updateTots();
                row = -1;
            }
            else
            {
                MessageBox.Show("Selecione o produto");
            }
            
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            row = e.RowHandle;
            
        }

        private void txtValorLiquidar_EditValueChanged(object sender, EventArgs e)
        {
            if (_clienteInvoices.Count > 0)
            {
                int indexRow = gridViewFaturasCliente.GetSelectedRows()[0];
                decimal saldoAlidar = decimal.Parse(gridViewFaturasCliente.GetRowCellValue(indexRow, "TotalLiquidar").ToString());
                if( decimal.Parse(txtValorLiquidar.Text) > saldoAlidar)
                {
                    txtValorLiquidar.Text = saldoAlidar.ToString();
                }
            }
        }

        private void gridControlFaturasCliente_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("Test Click Double");
        }

        private void gridViewFaturasCliente_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
           // int indexRow = gridViewFaturasCliente.GetSelectedRows()[0];
            txtValorLiquidar.Text = gridViewFaturasCliente.GetRowCellValue(e.RowHandle, "TotalLiquidar").ToString();
        }

        // ========================================== End Recibo ================================================================
    }

}
