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
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Main.Views.Report;
using UI.Main.Views.Save;

namespace UI.Main.Views.PDV
{
    public partial class FrmPosRestaurant : Form
    {
        List<Product> products;
        CustomerController _customerController = new CustomerController();
        Image img;
        ProductsSelectedSellController _productsSelectedSellController = new ProductsSelectedSellController();
        StockController _stockController = new StockController();
        SerieController _serieController = new SerieController();
        ProductController _productController = new ProductController();
        ProductsSelectedTableController _productsSelectedTableController = new ProductsSelectedTableController();
        InvoiceController _invoiceController = new InvoiceController();
        InvoiceTypeController _invoiceTypeController = new InvoiceTypeController();
        ProductSalesController _sales = new ProductSalesController();
        CategoryController _categoryController = new CategoryController();
        Invoice _lastInvoice;
        StorageController _storeController = new StorageController();
        Table table;
        List<ProductSellectedTable> productsSelectedTables = new List<ProductSellectedTable>();
        List<ProductSellectedTable> productsSelectedTables2 = new List<ProductSellectedTable>();
        int idSerie, _codigoFaturaAtual = 1;
        string idTipoDocumento;
        int idUser = 1; // Id doUser Logado
        public int idArmazemDefault = 0; /* Aqui vira o id do armazem que o usário está a usar / se for configurado para ter mais de 1 armazem ele deve escolher armazem vai usar
                                        Ao carregar a lista de produtos, só aparecerão os produtos do armazem em trabalho e escondera a cmbArmazem em productView
                                    */
        Customer client;
        int clienteId = 1; // Cliente Final

        decimal total = 0;
        decimal totalTaxa = 0;
        Main main;
        string pathImgs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\SellerProSources\\";
        public FrmPosRestaurant(Main main)
        {
            InitializeComponent();
            
             lblUser.Text = UserCurrent.getCurrentUser().Nome;
            this.main = main;
            idUser = UserCurrent.getCurrentUser().Id;
            if (UserCurrent.getCurrentUser().FlagAdmin)
            {
                isAdminActive = true;
            }
            toGridControlProducts();
 
            getSerie();
            string hora = DateTime.Now.Hour.ToString();
            string min =     DateTime.Now.Minute.ToString();
            if (int.Parse(min) < 10)
            {
                min = "0" + min;
            }
            if (int.Parse(hora) < 10)
            {
                hora = "0" + hora;
            }
            lblHora.Text = hora + ":" + min;

        }
        public void getSerie()
        {
            idSerie = Methods.atualSerieId;
            idTipoDocumento = Methods.atualDocumentTypeId; // Estatico, para VD
        }
        public void setAdminActive()
        {
            isAdminActive = true;
        }
         private void btnAddProduct_Click(object sender, EventArgs e)
        {
            new FrmProdutoView(this).ShowDialog();
        }
        int row = -1;
        private void btnRemove_Click(object sender, EventArgs e)
        {
           
        }
        public void setCostumer(Customer client)
        {
            this.client = client;
            txtCliente.Text = client.Cliente;
           
        }
        FamilyController _familyController = new FamilyController();
        FamilyRestController _familyRestController = new FamilyRestController();
        public void toGridControlProducts()
        {
       
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\SellerProSources\\";
            CategoryController categotiaController = new CategoryController();
       
            Methods.allowPermissionFolder(path);

            products = _productController.ListALLAsNoTracking();
            gridCategory.DataSource = _familyController.ListAll();
   
         //   tileView2.RefreshData();

            List<Product> productNew = new List<Product>();

            foreach (Product item in products)
            {
               
                item.image = Image.FromFile(item.UrlImg);
                productNew.Add(item);
            }


            gridControl1.DataSource = products;
         
            gridControl1.Update();
            Methods.denyPermissionFolder(path);


        }


        private void tileView1_ItemClick(object sender, DevExpress.XtraGrid.Views.Tile.TileViewItemClickEventArgs e)
        {
          //  int idProd = products[e.Item.RowHandle].Id;
            if (position > 1)
            {
                int idProd = productsFamily[e.Item.RowHandle].Id;
                int idStock = _stockController.getStockArmazemProduct(idProd, 0).Id;
                toGdvControlerProducts(idStock);
                
            }
            else
            {
                
                int idProd = products[e.Item.RowHandle].Id;
                int idStock = _stockController.getStockArmazemProduct(idProd, 0).Id;
                toGdvControlerProducts(idStock);
            }
           
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FrmCostumersView frmCustomer = new FrmCostumersView(this);
            frmCustomer.Show();
        }
        public void setTable(Table table)
        {
            this.table = table;
            lblMesa.Text = table.Mesa;
            updateGrid(0);
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
         
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            FrmReportView frm = new FrmReportView();
            List<ProductsSelectedSell> productsSelected = _productsSelectedSellController.ListALLAsNoTracking();
            if (productsSelected.Count>0)
            {
                if (table!=null)
                {
              
                    frm.PrintInvoiceComanda( table.Mesa,productsSelected,txtTotGeral.Text);
                //    frm.ShowDialog();
                }
                else
                {
                    frm.PrintInvoiceComanda("", productsSelected,txtTotGeral.Text);
                  //  frm.ShowDialog();
                }

            }
            else
            {
                MessageBox.Show("Não tem nenhum elemento na lista");
            }
        }
        public void print(int idFatura)
        {
            FrmReportView frm = new FrmReportView();
            frm.PrintInvoicePOSRecibo(idFatura);
           // frm.Show(); 
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
        private void clearData()
        {
            //  _productsSelectedSellController.reset();
            foreach (ProductsSelectedSell item in _productsSelectedSellController.ListALL())
            {
                _productsSelectedSellController.deleteFoId(item.Id);
            }
            lblMesa.Text = "";
            txtProdutoSelected.Text = "";
            txtTotalIncidencia.Text = "0,00";
            txtQdade.Text = "1,00";
            txtTotGeral.Text = "0,00";
            txtTotIva.Text = "0,00";
            txtValorPago.Text = "0,00";
            txtTroco.Text = "0,00";
            txtQdadeTotal.Text = "0,00";

          //  cmbPreco.Properties.Items.Clear();
           // cmbPreco.Text = "0,00";

             updateGrid(0);
            txtBarCodeProduct.Focus();
        }
        
        public void tableSelected(Table table)
        {
            foreach (ProductsSelectedSell item in _productsSelectedSellController.ListALL())
            {
                _productsSelectedSellController.deleteFoId(item.Id);
            }

            productsSelectedTables = _productsSelectedTableController.ListAll();
          
            foreach (ProductSellectedTable item in table.productsSellectedTable)
            {
                _productsSelectedSellController.insert(new ProductsSelectedSell()
                {
                    ProdutoId = item.ProdutoId,
                    StockId = item.StockId,
                    Preco = item.Preco,
                    Quantidade = item.Quantidade,
                });
                /* if (item.MesaId == table.Id)
                 {
                    // _productsSelectedTableController.removeForId(item.Id);
                     productsSelectedTables2.Add(item);
                      _productsSelectedSellController.insert(new ProductsSelectedSell()
                     {
                         ProdutoId = item.ProdutoId,
                         StockId = item.StockId,
                         Preco = item.Preco,
                         Quantidade = item.Quantidade,
                     });

                 }*/
            }
            
            lblMesa.Text = table.Mesa;
            updateGrid(0);
        }
        private void updateGrid(int selectRow)
        {
            try
            {
  string audioName = "Beep.wav";
            string path = Application.StartupPath + @"sounds/";
        
            if (File.Exists(path + audioName))
                using (SoundPlayer successSound = new SoundPlayer(path + audioName))
                {
                    successSound.Play();
        
                }
            }
            catch (Exception)
            {

            }
          

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

            if (gVProductsSelected.RowCount > selectRow)
            {
                gVProductsSelected.FocusedRowHandle = selectRow;
                txtQdade.Text = "1,00";
            }

        }
        private void salvar()
        {
            if (_productsSelectedSellController.ListALL().Count > 0)
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
                if (rbTPA.Checked)
                {
                    TurnoCurrent.getTurnoCurrent().Tpa += totGeral;
                }
                else
                {
                    TurnoCurrent.getTurnoCurrent().Caixa += totGeral;
                }

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
                 clearTable();
                clearData();
               
                CalcCodigoFaturaAtual();

                print(idFatura);
                /* }
                 catch (Exception error)
                 {
                     MessageBox.Show(error.Message);
                 }*/
            }
            else
                MessageBox.Show("Não foi selecionado nenhum artigo para venda..!");
            ///
        }
        public void clearTable()
        {
            if (table!= null )
            {
                foreach (ProductSellectedTable item in table.productsSellectedTable)
                {
                    _productsSelectedTableController.removeForId(item.Id);
                }
            }
        }
        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
           
          
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtValorPago_TextChanged(object sender, EventArgs e)
        {
           
            
            try
            {
                 if (txtValorPago.Text != "")
                    {
                         txtTroco.Text = (decimal.Parse(txtValorPago.Text) - decimal.Parse(txtTotGeral.Text)).ToString("n2");
                    }
            }
            catch (Exception r)
            {
                 
            }
        }

        private void txtBarCodeProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string barraCode = txtBarCodeProduct.Text;
                txtBarCodeProduct.Text = "";

                Product p = _productController.getForCodigoBarra(barraCode);

                if (p != null)
                {
                    Stock st = _stockController.getStockArmazemProduct(p.Id, idArmazemDefault);
                    if (st != null)
                        toGdvControlerProducts(st.Id);
                }

            }
        }

        private void txtProductCod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
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

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
         
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            FrmTable frm = new FrmTable(this, 1);
            frm.ShowDialog();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            ProductSellectedTable prod;
            bool have = false;

            if (table!=null)
            {
                foreach (ProductSellectedTable item in table.productsSellectedTable)
                {
                    _productsSelectedTableController.removeForId(item.Id);
                }

                foreach (ProductsSelectedSell item in _productsSelectedSellController.ListALL())
                {
                    prod = new ProductSellectedTable()
                    {
                        ProdutoId = item.ProdutoId,
                        StockId = item.StockId,
                        Preco = item.Preco,
                        Quantidade = item.Quantidade,
                        data = DateTime.Now.ToShortDateString(),
                        MesaId = table.Id,

                    };
                    _productsSelectedTableController.insert(prod);
                }
                /*
                  foreach (ProductsSelectedSell item in _productsSelectedSellController.ListALL())
                   {
                        int idStock = _stockController.getStockArmazemProduct(item.ProdutoId, 0).Id;

                        foreach (var item2 in _productsSelectedTableController.ListAll())
                        {
                            if (item2.ProdutoId == item.ProdutoId)
                            {
                                 item2.Quantidade = item.Quantidade;
                                 _productsSelectedTableController.update(item2);
                                have = true;
                                break;
                            }
                        }
                    if (!have)
                    {
                        prod = new ProductSellectedTable()
                        {
                            ProdutoId = item.ProdutoId,
                            StockId = idStock,
                            Preco = item.Preco,
                            Quantidade = item.Quantidade,
                            data = DateTime.Now.ToShortDateString(),
                            MesaId = table.Id,
                        
                        };
                        _productsSelectedTableController.insert(prod);
                    }
                    _productsSelectedSellController.deleteFoId(item.Id);
                */
                table = null;
                clearData();
                updateGrid(0);
               
            }
            else
            {
                MessageBox.Show("Escolha uma mesa");
            }
          
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            string hora = DateTime.Now.Hour.ToString();
            string min =  DateTime.Now.Minute.ToString();
             if (int.Parse(min)<10)
            {
                min = "0"+min;
            }
            if (int.Parse(hora)<10)
            {
                hora = "0" + hora;
            }
            lblHora.Text = hora + ":"+min;
           
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            FrmTable frm = new FrmTable(this, 2);
            frm.ShowDialog();
        }

        private void gdvControllerProductsSelected_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }
        int idSelctedSell;
        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            
             
        }
      
        bool isAdminActive = false;
        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
         
                if (table ==null)
                {
                    MessageBox.Show("Escolha uma mesa");
                }
                else
                {
                    if (isAdminActive == false)
                    {
                        FrmPassAdmin frm = new FrmPassAdmin(this);
                        frm.ShowDialog();
                    }
                    else
                    {
                         FrmTransferirProducts frm = new FrmTransferirProducts(table.Id,this);
                         frm.ShowDialog();
                      
                          
                    }
                }  
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (UserCurrent.getCurrentUser().FlagAdmin)
            {
                main.Show();
                Close();
            }
            else
            {
                Close();
            }
        }

        private void FrmPosRestaurant_Load(object sender, EventArgs e)
        {

        }

        private void gridView1_FocusedColumnChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs e)
        {

        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            MessageBox.Show("");
        }

        private void gVProductsSelected_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            idSelctedSell = e.RowHandle;
        }
        int position = -1;
        private void bunifuThinButton22_Click_1(object sender, EventArgs e)
        {
         }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
        List<Product> productsFamily = new List<Product>();
        private void tileView2_ItemClick(object sender, DevExpress.XtraGrid.Views.Tile.TileViewItemClickEventArgs e)
        {
            position = e.Item.RowHandle;
            if (position == 0)
            {
                gridControl1.DataSource = products;
                gridControl1.RefreshDataSource();
                tileView2.RefreshData();
            }
            else
            {
                productsFamily.Clear();
                foreach (FamilyRest family in _familyController.listForId(_familyController.ListAll()[position].Id).familias)
                {
                    foreach (Product product in products)
                    {
                        if (family.ProductoId == product.Id)
                        {
                            productsFamily.Add(product);
                        }
                    }

                }
                gridControl1.DataSource = productsFamily;
                gridControl1.RefreshDataSource();
                tileView2.RefreshData();
            }
        }

        private void gVProductsSelected_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            row = e.RowHandle;
        }

        private void gridCategory_Click(object sender, EventArgs e)
        {

        }

        private void rbTPA_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (UserCurrent.getCurrentUser().FlagAdmin)
            {
                main.Show();
                Close();
            }
            else
            {
                Close();
            }
        }

        private void ckAuto_CheckedChanged(object sender, EventArgs e)
        {
            if (ckAuto.Checked)
                txtValorPago.Text = txtTotGeral.Text;
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

            if (table != null)
            {
                DialogResult dialog = MessageBox.Show("Liberar a mesa?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    lblMesa.Text = "";

                    salvar();
                    table = null;
                }

            }
            else
            {
                MessageBox.Show("Selecione uma mesa");
            }
        }

        private void rbNu_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click_1(object sender, EventArgs e)
        {
            if (row >= 0)
            {

                if (isAdminActive == false)
                {
                    FrmPassAdmin frm = new FrmPassAdmin(this);
                    frm.ShowDialog();
                }
                else
                {
                    ProductsSelectedSell item = _productsSelectedSellController.ListALL()[gVProductsSelected.FocusedRowHandle];

                    if (item.Quantidade > 1)
                    {
                        item.Quantidade--;
                        _productsSelectedSellController.update(item);
                    }
                    else
                    {
                        _productsSelectedSellController.delete(item);
                    }
                    updateGrid(gVProductsSelected.FocusedRowHandle);
                }
            }
            else
            {
                MessageBox.Show("Selecione um produto");
            }
            row = -1;
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            if (isAdminActive == false)
            {
                FrmPassAdmin frm = new FrmPassAdmin(this);
                frm.ShowDialog();
            }
            else
            {

                foreach (ProductsSelectedSell item in _productsSelectedSellController.ListALL())
                {
                    _productsSelectedSellController.delete(item);
                }
                updateGrid(0);
            }
        }

        private void gVProductsSelected_ItemClick(object sender, DevExpress.XtraGrid.Views.Tile.TileViewItemClickEventArgs e)
        {
            row = e.Item.RowHandle;
        }

        private void txtDesconto_TextChanged(object sender, EventArgs e)
        {

        }

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
                _productsSelectedSellController.insert(new ProductsSelectedSell()
                {
                    ProdutoId = st.ProdutoId,
                    StockId = st.Id,
                    Preco = st.Produto.Preco1,
                    Quantidade = decimal.Parse(txtQdade.Text),
                });

                gdvControllerProductsSelected.DataSource = _productsSelectedSellController.ListALLAsNoTracking();     
                gdvControllerProductsSelected.DataSource = _productsSelectedSellController.ListALLAsNoTracking();
                gVProductsSelected.RefreshData();
                txtProdutoSelected.Text = st.Produto.Descricao;
                //     toCmbPreco(st.Produto);

                // toPicture(st.Produto.UrlImg);

                // txtProduct.Text = st.Produto.Descricao;
                    txtBarCodeProduct.Text = "";
                    txtProductCod.Text = "";

                // --------------------------------------------------
                updateGrid(indexRow);
            }
            else
            {
                // Se já existir aumentar só a quantidade
                // Colocar depois uma configuração se ao clicar no produto existente substituir ou acrescer a qdade

                pSelectedSell.Quantidade += decimal.Parse(txtQdade.Text);
                _productsSelectedSellController.update(pSelectedSell);
                txtProdutoSelected.Text = st.Produto.Descricao;
                //    toCmbPreco(st.Produto);
                //      toPicture(st.Produto.UrlImg);

                //        txtProduct.Text = st.Produto.Descricao;
                //        txtBarCodeProduct.Text = "";   
                //        txtProductCod.Text = "";

         
                gdvControllerProductsSelected.DataSource = _productsSelectedSellController.ListALLAsNoTracking();
                gVProductsSelected.RefreshData();
                updateGrid(indexRow);
            }

        }



    }
}
