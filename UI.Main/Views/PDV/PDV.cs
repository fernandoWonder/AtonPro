using Appplication.Controller;
using Appplication.Statics;
using Domain.Domain.Entities;
using Domain.Domain.Entities.Documents;
using Domain.Domain.Entities.ProductStock;
using Domain.Domain.Entities.Temp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Main.Views.Report;
using UI.Main.Views.Save;

namespace UI.Main.Views.PDV
{
    public partial class PDV : Form
    {
        ProductsSelectedSellController _productsSelectedSellController = new ProductsSelectedSellController();
        StockController _stockController = new StockController();
        SerieController _serieController = new SerieController();
        ProductController _productController = new ProductController();
        InvoiceController _invoiceController = new InvoiceController();
        InvoiceTypeController _invoiceTypeController = new InvoiceTypeController();
        ProductSalesController _sales = new ProductSalesController();
        
        Invoice _lastInvoice;

        int idSerie, _codigoFaturaAtual = 1;
        string idTipoDocumento;
        int idUser = 1; // Id doUser Logado
        public int idArmazemDefault = 0; /* Aqui vira o id do armazem que o usário está a usar / se for configurado para ter mais de 1 armazem ele deve escolher armazem vai usar
                                        Ao carregar a lista de produtos, só aparecerão os produtos do armazem em trabalho e escondera a cmbArmazem em productView
                                    */

        int clienteId = 1; // Cliente Final

        decimal total = 0;
        decimal totalTaxa = 0;

        string pathImgs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\SellerProSources\\";
        public PDV()
        {

            InitializeComponent();
            idUser = UserCurrent.getCurrentUser().Id;
            getSerie();
            _codigoFaturaAtual = 1;

            if (!Directory.Exists(pathImgs))
            {
                Directory.CreateDirectory(pathImgs);
            }
            allowPermissionFolder(pathImgs);
            CalcCodigoFaturaAtual();
        }

        public void getSerie()
        {
            idSerie = Methods.atualSerieId;
            idTipoDocumento = Methods.atualDocumentTypeId; // Estatico, para VD
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void allowPermissionFolder(string path)
        {
            System.Security.AccessControl.DirectorySecurity b = new System.Security.AccessControl.DirectorySecurity();
            b.SetAccessRuleProtection(false, true);
            Directory.SetAccessControl(path, b);
        }

        public void denyPermissionFolder(string path)
        {
            if (!Directory.Exists(pathImgs))
            {
                Directory.CreateDirectory(pathImgs);
            }

            System.Security.AccessControl.DirectorySecurity b = new System.Security.AccessControl.DirectorySecurity();
            b.SetAccessRuleProtection(true, true);
            Directory.SetAccessControl(path, b);
        }

        public void toCmbPreco(Product p)
        {
            cmbPreco.Properties.Items.Clear();

            // --------------------------------------------------
            cmbPreco.Properties.Items.Add(p.Preco1);
            cmbPreco.Properties.Items.Add(p.Preco2);
            cmbPreco.Properties.Items.Add(p.Preco3);
            cmbPreco.SelectedIndex = 0;
        }

        // Add To ListSelected  / Posteriormente aqui tirar a lista de selecionados na BD
        public void toGdvControlerProducts(int idStock)
        {
            Stock st = _stockController.getOne(idStock);
            ProductsSelectedSell pSelectedSell = null;
           
            bool haveAlready = false;

            int indexRow = 0;
            foreach (var item in _productsSelectedSellController.ListALL())
            {
                if (item.ProdutoId == st.ProdutoId)
                {
                    haveAlready = true;
                    pSelectedSell = item;
                    break;
                }
                indexRow++;
            }

            if (!haveAlready)
            {

                _productsSelectedSellController.insert(new ProductsSelectedSell() {
                    ProdutoId = st.ProdutoId,
                    StockId = st.Id,
                    Preco = st.Produto.Preco1,
                    Quantidade = decimal.Parse(txtQdade.Text),
                });

                updateGrid(indexRow);
                toCmbPreco(st.Produto);

                toPicture(st.Produto.UrlImg);

                txtProduct.Text = st.Produto.Descricao;
                txtBarCodeProduct.Text = "";
                txtProductCod.Text = "";

                // --------------------------------------------------
            }
            else 
            {
                // Se já existir aumentar só a quantidade
                // Colocar depois uma configuração se ao clicar no produto existente substituir ou acrescer a qdade

                pSelectedSell.Quantidade += decimal.Parse(txtQdade.Text);
                _productsSelectedSellController.update(pSelectedSell);

                toCmbPreco(st.Produto);
                toPicture(st.Produto.UrlImg);

                txtProduct.Text = st.Produto.Descricao;
                txtBarCodeProduct.Text = "";
                txtProductCod.Text = "";

                updateGrid(indexRow);
            }

        }

        private void toPicture(string urlImg)
        {
            if (File.Exists(urlImg))
            {
                pictureProduct.Image = Image.FromFile(urlImg);
            }
            else
            {

                if (File.Exists(pathImgs + "\\default.png"))
                    pictureProduct.Image = Image.FromFile( pathImgs + "\\default.png");
                else
                    pictureProduct.Image  = pictureProduct.ErrorImage;
            }
        }

        private void updateGrid(int selectRow)
        {
            gdvControllerProductsSelected.DataSource = _productsSelectedSellController.ListALLAsNoTracking();
            gVProductsSelected.RefreshData();

            total = 0;
            totalTaxa = 0;
            decimal totQuant = 0;
            foreach (var item in _productsSelectedSellController.ListALLAsNoTracking())
            {
                totalTaxa += _productController.getOne(item.ProdutoId).CodigoTaxa.Taxa * (item.Preco * item.Quantidade) / 100;
                total += (item.Preco * item.Quantidade);
                totQuant += item.Quantidade;
            }

            txtTotIva.Text = totalTaxa.ToString("N2");
            txtTotalIncidencia.Text = total.ToString("N2");
            txtTotGeral.Text = (totalTaxa + total).ToString("n2");

            txtQdadeTotal.Text = totQuant.ToString("n2");
            if (ckAuto.Checked)
                txtValorPago.Text = txtTotGeral.Text;

            if(gVProductsSelected.RowCount > selectRow)
            {
                gVProductsSelected.FocusedRowHandle = selectRow;
                txtQdade.Text = "1,00";
            }

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            txtBarCodeProduct.Focus();
            new FrmProdutoView(this).ShowDialog();
        }

        private void txtBarCodeProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                string barraCode = txtBarCodeProduct.Text;
                txtBarCodeProduct.Text = "";

                Product p = _productController.getForCodigoBarra(barraCode);

                if(p != null)
                {
                    Stock st = _stockController.getStockArmazemProduct(p.Id, idArmazemDefault);
                    if (st != null)
                        toGdvControlerProducts(st.Id);
                }

            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(gVProductsSelected.RowCount > 0)
            {
                int rowSelected = gVProductsSelected.GetSelectedRows()[0];
                _productsSelectedSellController.delete(_productsSelectedSellController.ListALL()[rowSelected]);

                if (_productsSelectedSellController.ListALLAsNoTracking().Count > 0)
                {
                    // a linha seleciona passa a ser a asseguir da linha apagada
                    if ((rowSelected + 1) < gVProductsSelected.RowCount && rowSelected != 0)
                        rowSelected += 1;
                    else if (rowSelected > 0)
                        rowSelected -= 1;
                    // 
                    updateGrid(rowSelected);

                    rowSelected = gVProductsSelected.GetSelectedRows()[0];

                    ProductsSelectedSell ps = _productsSelectedSellController.ListALL()[rowSelected];
                    Product p = _productController.getOne(ps.ProdutoId);

                    toCmbPreco(p);
                    cmbPreco.Text = ps.Preco.ToString("n2");

                    txtProduct.Text = p.Descricao;
                    txtQdade.Text = ps.Quantidade.ToString("n2");
                    toPicture(p.UrlImg);

                    txtBarCodeProduct.Focus();
                }
                else
                {
                    clearData();
                }
            }
            
        }

        private void clearData()
        {
            _productsSelectedSellController.reset();
            _productsSelectedSellController = new ProductsSelectedSellController();

            txtProduct.Text = "";
            txtTotalIncidencia.Text = "0,00";
            txtQdade.Text = "1,00";
            txtTotGeral.Text = "0,00";
            txtTotIva.Text = "0,00";
            txtValorPago.Text = "0,00";
            txtTroco.Text = "0,00";
            txtQdadeTotal.Text = "0,00";

            cmbPreco.Properties.Items.Clear();
            cmbPreco.Text = "0,00";

            toPicture("#");
            updateGrid(0);
            txtBarCodeProduct.Focus();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja limpar os dados da tabela..?", "Limpar Seleção", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                clearData();
            }
            else
                txtBarCodeProduct.Focus();
        }

        private void PDV_FormClosing(object sender, FormClosingEventArgs e)
        {
            denyPermissionFolder(pathImgs);
        }

        private void btnFinalizarVenda_Click(object sender, EventArgs e)
        {
            salvar();
        }

        private void salvar()
        {
            if(_productsSelectedSellController.ListALL().Count > 0)
            {
                /*try
                {*/
                    // Antes de inserir calcula novamente o código da fatura atual/ se forem muitos computadores um já pode ter usado aquele código
                    CalcCodigoFaturaAtual();
                    decimal totGeral = total + totalTaxa;
                    int idFatura;
                    string idpayment = "NU";

                    if (rbTPA.Checked)
                    {
                        idpayment = "CC";
                    }

                    string invoiceNo = _invoiceTypeController.getOne(idTipoDocumento).Tipo + " " + _serieController.getOne(idSerie).Serie + "/" + _codigoFaturaAtual;
                    DateTime dataAtual = DateTime.Now;

                    //string GrossTotal = (TotalIva + totalIncidencia).ToString("F").Replace(',', '.');
                    string GrossTotal = (totGeral).ToString("F3").Replace(',', '.');
                    //   string dadosHash2 = dataAtual.ToString("yyyy-MM-dd") + ";" + dataAtual.ToString("yyyy-MM-ddTHH:mm") + ";" + invoiceNo + ";" + (TotalIva + totalIncidencia).ToString("N2").Replace(",", ".") + ";";
                    string dadosHash = dataAtual.ToString("yyyy-MM-dd") + ";" + dataAtual.ToString("yyyy-MM-ddTHH:mm:ss") + ";" + invoiceNo + ";" + GrossTotal + ";";
                    dadosHash += _lastInvoice != null ? _lastInvoice.Hash : "";
                    //dadosHash = lastInvoice != null ? dadosHash + lastInvoice.Hash : dadosHash;
                    string Hash = Methods.gerarHash(dadosHash, invoiceNo);

                    Invoice invoice = new Invoice()
                    {
                        InvoiceDate = DateTime.Now.ToString("yyyy-MM-dd"),
                        Codigo = _codigoFaturaAtual,
                        ClienteId = clienteId,
                        SeriesId = idSerie,
                        InvoiceNo = invoiceNo,
                        TipoDocumentoId = idTipoDocumento,
                        Desconto = decimal.Parse(txtDesconto.Text),
                        TotalImposto = totalTaxa,
                        TotalIncidencia = total,
                        UserId = idUser,
                        Troco = decimal.Parse(txtTroco.Text),
                        ValorPago = decimal.Parse(txtValorPago.Text),
                        FormaPagamentoId = idpayment,
                        TotalLiquidar = 0,
                        Hash = Hash,
                        DataCadastro = dataAtual,
                    };

                    ConfigCurrentAccountController _configAccountUserController = new ConfigCurrentAccountController();
                    ConfigCurrentAccount configAccount = _configAccountUserController.ListForUserIdPaymentId(idUser, idpayment);

                    if (configAccount != null)
                        _invoiceController.insert(invoice, idUser, configAccount.CurrentAccountId);
                    else
                        _invoiceController.insert(invoice, idUser, 1); // Se não tiver definido nenhuma conta entra na caixa geral


                    invoice = _invoiceController.getForInvoiceNo(invoiceNo);
                    idFatura = invoice.Id;

                    if (idFatura == 0)
                        MessageBox.Show("Fatura Nula");

                    
                    foreach (var item in _productsSelectedSellController.ListALL())
                    {
                        try
                        {
                            //Stock stock = _stockController.getStockArmazemProduct(item.ProdutoId, idArmazemDefault);
                            Stock stock = _stockController.getOne(item.StockId);
                            stock.Quantidade -= item.Quantidade;
                            _stockController.update(stock);

                            string movitoISE = null;

                            Product product = _productController.getOne(item.ProdutoId);
                            if (product.MotivoISEId != null)
                                movitoISE = product.MotivoISE.MencaoFatura;

                            ProductSales productSale = new ProductSales()
                            {
                                Preco = item.Preco,
                                FaturaId = idFatura,
                                ProductId = item.ProdutoId,
                                Desconto = item.Desconto,
                                StockId = item.StockId,
                                Descricao_Produto = product.Descricao,
                                Quantidade = item.Quantidade,
                                Taxa = product.CodigoTaxa.Taxa,
                                Unidade = product.UnidadeBase.Simbolo,
                                MotivoIsencao = movitoISE,
                                MotivoISEId = product.MotivoISEId,
                            };

                            _sales.insert(productSale);
                        }
                        catch (Exception error)
                        {
                            MessageBox.Show(error.Message);
                        }
                    }

                    clearData();
                    CalcCodigoFaturaAtual();

                    print(idFatura);
               /* }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }*/
            }else
                MessageBox.Show("Não foi selecionado nenhum artigo para venda..!");
            ///
        }

        public void print(int idFatura)
        {
            FrmReportView frm = new FrmReportView();
            frm.PrintInvoicePOSRecibo(idFatura);
            //frm.Show();
        }

        public void CalcCodigoFaturaAtual()
        {
            _lastInvoice = null;
            
            _codigoFaturaAtual = 1;
            _lastInvoice = _invoiceController.lastInvoiceInSerieAndType(idSerie, idTipoDocumento);

            if (_lastInvoice != null)
                _codigoFaturaAtual += _lastInvoice.Codigo;
            txtCodFaturaAtual.Text = _codigoFaturaAtual + "";
        }

        private void txtValorPago_EditValueChanged(object sender, EventArgs e)
        {
            txtTroco.Text = (decimal.Parse(txtValorPago.Text) - decimal.Parse(txtTotGeral.Text)).ToString("n2");
        }

        private void ckAuto_CheckedChanged(object sender, EventArgs e)
        {
            if (ckAuto.Checked)
                txtValorPago.Text = txtTotGeral.Text;
        }

        private void gVProductsSelected_KeyDown(object sender, KeyEventArgs e)
        {
            List<Keys> keysDirection = new List<Keys>();
            keysDirection.Add(Keys.Left);
            keysDirection.Add(Keys.Right);
            keysDirection.Add(Keys.Up);
            keysDirection.Add(Keys.Down);

            if (keysDirection.Contains(e.KeyCode))
                e.Handled = true;
        }

        Product rowProduct;
        ProductsSelectedSell rowProductSelectedSell;

        private void gVProductsSelected_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            int indexRow = e.RowHandle;
            var qdade = gVProductsSelected.GetRowCellValue(indexRow, gVProductsSelected.Columns["Quantidade"]);
            var idProduto = gVProductsSelected.GetRowCellValue(indexRow, gVProductsSelected.Columns["ProdutoId"]);

            rowProduct = _productController.getOne(Convert.ToInt16(idProduto));
            rowProductSelectedSell = _productsSelectedSellController.ListALL()[indexRow];

            txtProduct.Text = rowProduct.Descricao;
            toCmbPreco(rowProduct);
            cmbPreco.Text = rowProductSelectedSell.Preco.ToString();

            txtQdade.Text = qdade.ToString();
            toPicture(rowProduct.UrlImg);

        }

        private void cmbPreco_Leave(object sender, EventArgs e)
        {
            if (rowProductSelectedSell != null && _productsSelectedSellController.ListALL().Count > 0)
            {
                rowProductSelectedSell.Preco = decimal.Parse(cmbPreco.Text);
                _productsSelectedSellController.update(rowProductSelectedSell);

                rowProductSelectedSell.Quantidade.ToString();

                rowProductSelectedSell.Quantidade.ToString();
                updateGrid(gVProductsSelected.GetSelectedRows()[0]);
                txtBarCodeProduct.Focus();
            }
        }

        string previousInput = "";
        private void cmbPreco_TextChanged(object sender, EventArgs e)
        {

            Regex r = new Regex(@"^-{0,1}\d+\,{0,1}\d*$");
            Match m = r.Match(cmbPreco.Text);
            if (m.Success)
            {
                previousInput = cmbPreco.Text;
            }
            else
            {
                cmbPreco.Text = previousInput;
            }
        }

        bool qdadeControlKeyPressed = false;
        private void txtQdade_KeyDown(object sender, KeyEventArgs e)
        {
            // Quando clica em tab atualiza a quantidade do produto selecionado (Mouse leave) se clica em enter será a qdade do novo produto 
            if(e.KeyCode == Keys.ControlKey)
                qdadeControlKeyPressed = true;
            if (e.KeyCode == Keys.Enter)
            {
                if (!qdadeControlKeyPressed)
                {
                    txtBarCodeProduct.Focus();
                }
                else
                {
                    if (rowProductSelectedSell != null && decimal.Parse(txtQdade.Text) > 0 && _productsSelectedSellController.ListALLAsNoTracking().Count > 0)
                    {
                        rowProductSelectedSell.Quantidade = decimal.Parse(txtQdade.Text);
                        _productsSelectedSellController.update(rowProductSelectedSell);
                        updateGrid(gVProductsSelected.GetSelectedRows()[0]);
                    }
                    // Caso clique em tab, atuliza a quantidade mas o focus continua para escolher a 
                    // qdade do próximo produto, só sai quando clica em enter
                    txtQdade.Focus();
                }
                
            }
        }

        private void gVProductsSelected_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int indexRow = 0;
            if (gVProductsSelected.RowCount > 0)
            {
                indexRow = gVProductsSelected.GetSelectedRows()[0];
                var qdade = gVProductsSelected.GetRowCellValue(indexRow, gVProductsSelected.Columns["Quantidade"]);
                var idProduto = gVProductsSelected.GetRowCellValue(indexRow, gVProductsSelected.Columns["ProdutoId"]);

                rowProduct = _productController.getOne(Convert.ToInt16(idProduto));
                rowProductSelectedSell = _productsSelectedSellController.ListALL()[indexRow];

                cmbPreco.Text = rowProductSelectedSell.Preco.ToString();

                txtQdade.Text = qdade.ToString();
            }
            
        }

        private void cmbPreco_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtBarCodeProduct.Focus();
        }

        private void txtQdade_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey)
                qdadeControlKeyPressed = false;
        }

        private void txtBarCodeProduct_Enter(object sender, EventArgs e)
        {
            txtBarCodeProduct.BackColor = Color.LightSteelBlue;
        }

        private void BtnConfig_Click(object sender, EventArgs e)
        {
            new FrmConfigPOS(this).ShowDialog();
        }

        private void txtProductCod_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                string productCode = txtProductCod.Text;
                txtProductCod.Text = "";

                Product p = _productController.getForCodigoProduto(productCode);

                if (p != null)
                {
                    Stock st = _stockController.getStockArmazemProduct(p.Id, idArmazemDefault);
                    if (st != null)
                        toGdvControlerProducts(st.Id);
                }
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {

        }

        private void PDV_Load(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtBarCodeProduct_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtBarCodeProduct_EditValueChanged_1(object sender, EventArgs e)
        {

        }

        private void txtProductCod_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtBarCodeProduct_Leave(object sender, EventArgs e)
        {
            txtBarCodeProduct.BackColor = Color.WhiteSmoke;
        }

    }
}
