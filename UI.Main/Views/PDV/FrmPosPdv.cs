using Appplication.Controller;
using Appplication.Statics;
using DevExpress.Utils.DirectXPaint;
using DevExpress.Utils.Gesture;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.ImageEditor;
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
using UI.Main.Views.Save;
using DevExpress.Utils.Svg;
using DevExpress.XtraGrid;
using DevExpress.XtraEditors.Repository;
using Domain.Domain.Entities;
using System.IO;
using UI.Main.Views.Report;

namespace UI.Main.Views.PDV
{
    public partial class FrmPosPdv : Form
    {

        Customer client;
        CustomerController _customerController = new CustomerController();
        Image img;
        ProductsSelectedSellController _productsSelectedSellController = new ProductsSelectedSellController();
        StockController _stockController = new StockController();
        SerieController _serieController = new SerieController();
        ProductController _productController = new ProductController();
        InvoiceController _invoiceController = new InvoiceController();
        InvoiceTypeController _invoiceTypeController = new InvoiceTypeController();
        ProductSalesController _sales = new ProductSalesController();
        CategoryController _categoryController = new CategoryController();
        Invoice _lastInvoice;
        StorageController _storeController = new StorageController();
        Table table;
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
        public FrmPosPdv(Main main)
        {
            
            InitializeComponent();
            this.main = main;
            new FrmPosPrinter().ShowDialog();
            if (UserCurrent.getCurrentUser().FlagAdmin)
            {
                isAdminActive = true;
            }
            toGridControlProducts();
            gridCategory.DataSource = _categoryController.ListALLAsNoTracking();
            getSerie();
            string hora = DateTime.Now.Hour.ToString();
            string min =  DateTime.Now.Minute.ToString();
            if (int.Parse(min) < 10)
            {
                min = "0" + min;
            }
            if (int.Parse(hora) < 10)
            {
                hora = "0" + hora;
            }
            lblHora.Text = hora + ":" + min;
            /* PictureEdit pic = new PictureEdit();
             pic.Image = Image.FromFile(@"C:\Users\FernandoWonder\Pictures\detalhe_empresa.png");
             repositoryItemPictureEdit1.HtmlImages = pic.Image;
             //pic.EditValue = Image.FromFile("");
             RepositoryItemPictureEdit edit = new RepositoryItemPictureEdit();
             edit.HtmlImages = pic;

             edit.HtmlImages = Image.FromFile(@"C:\Users\FernandoWonder\Pictures\detalhe_empresa.png");
             */
            //cardView1.Columns["Id"].Visible = false;

        }
        int position = 0;
        private void gridControl1_Click(object sender, EventArgs e)
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
                gVProductsSelected.RefreshData();

                txtProdutoSelected.Text = st.Produto.Descricao;
                //     toCmbPreco(st.Produto);

                // toPicture(st.Produto.UrlImg);

                //    txtProduct.Text = st.Produto.Descricao;
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
                //          txtBarCodeProduct.Text = "";   
                //            txtProductCod.Text = "";

                            updateGrid(indexRow);
                 gdvControllerProductsSelected.DataSource = _productsSelectedSellController.ListALLAsNoTracking();
                gVProductsSelected.RefreshData();
            }

        }


       

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
           // txtBarCodeProduct.Focus();
            new FrmProdutoView(this).ShowDialog();
        }
        
        private void panel4_Paint(object sender, PaintEventArgs e)
        {
           
        }
        List<Product> product;
        public void toGridControlProducts()
        {
            // gdvProducts.DataSource = _produController.view1("");
            /* gridControl1.DataSource = _stockController.viewProductStockArmazem(0);
             cardView1.Columns["Id_Stock"].Visible = false;
             cardView1.Columns["Categoria"].Visible = false;
             cardView1.Columns["Armazem"].Visible = false;
             cardView1.Columns["Taxa"].Visible = false;
             DevExpress.XtraGrid.Columns.GridColumn grid = new DevExpress.XtraGrid.Columns.GridColumn();


             grid.Caption = "IMG";
             grid.Name = "IMG";
            cardView1.Columns["IMG"].ColumnEdit = new RepositoryItemPictureEdit();
            cardView1.Columns.Add(grid);*/

            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\SellerProSources\\";

            Methods.allowPermissionFolder(path);
            
            product = _productController.ListALLAsNoTracking();
            List<Product> productNew = new List<Product>();
            foreach (Product item in product)
            {
                item.image = Image.FromFile(item.UrlImg);
                productNew.Add(item);
            }
            gridControl1.DataSource = productNew;
          
            gridControl1.Update();
            Methods.denyPermissionFolder(path);


        }

        private void gridControl1_Click_1(object sender, EventArgs e)
        {
             
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }
        private void gridControl1_Click_2(object sender, EventArgs e)

        {
           
        }

        private void tileView1_ItemClick(object sender, DevExpress.XtraGrid.Views.Tile.TileViewItemClickEventArgs e)
        {
            
             if (position > 0)
            {
                int idProd = _productcategory[e.Item.RowHandle].Id;
                int idStock = _stockController.getStockArmazemProduct(idProd, 0).Id;
                toGdvControlerProducts(idStock);

            }
            else
            {

                int idProd = product[e.Item.RowHandle].Id;
                int idStock = _stockController.getStockArmazemProduct(idProd, 0).Id;
                toGdvControlerProducts(idStock);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            FrmTable table = new FrmTable();
            table.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
       
        public void setCostumer(Customer client)
        {
            this.client = client;
            txtCliente.Text = client.Cliente;

        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FrmCostumersView frmCustomer = new FrmCostumersView(this);
            frmCustomer.Show();
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
            }
            else
                MessageBox.Show("Não foi selecionado nenhum artigo para venda..!");
            ///
        }
        public void print(int idFatura)
        {
            FrmReportView frm = new FrmReportView();
            frm.PrintInvoicePOSRecibo(idFatura);
          //  frm.Show();
        }
        private void clearData()
        {
            _productsSelectedSellController.reset();
            _productsSelectedSellController = new ProductsSelectedSellController();

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

        private void bunifuThinButton24_Click_1(object sender, EventArgs e)
        {
            salvar();
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

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            if (  isAdminActive == false)
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
        int row = -1;
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
                if (item.Quantidade > 1 )
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
        public void setAdminActive()
        {
            isAdminActive = true;
        }
        bool isAdminActive = false;

        private void btnAddProduct_Click_1(object sender, EventArgs e)
        {
            new FrmProdutoView(this).ShowDialog();
        }

        private void ckAuto_CheckedChanged(object sender, EventArgs e)
        {
            if (ckAuto.Checked)
                txtValorPago.Text = txtTotGeral.Text;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string hora = DateTime.Now.Hour.ToString();
            string min = DateTime.Now.Minute.ToString();
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

        private void gVProductsSelected_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            row = e.RowHandle;
        }
        CategoryController category = new CategoryController();
        private void panel5_Paint(object sender, PaintEventArgs e)
        {

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

        private void txtBarCodeProduct_Enter(object sender, EventArgs e)
        {
            txtBarCodeProduct.BackColor = Color.LightSteelBlue;
        }

        private void txtBarCodeProduct_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtTotGeral_Click(object sender, EventArgs e)
        {

        }

        private void txtTotIva_Click(object sender, EventArgs e)
        {

        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void txtTotalIncidencia_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtTroco_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtQdadeTotal_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click_1(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblHora_Click(object sender, EventArgs e)
        {

        }

        private void txtCodFaturaAtual_TextChanged(object sender, EventArgs e)
        {

        }

        private void productBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void customerBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
        Main main;
        private void simpleButton2_Click(object sender, EventArgs e)
        {
           
            if (UserCurrent.getCurrentUser().FlagAdmin)
            {
                main.Show();
                Close();
            }
            else
            {
                Application.Exit();
               // Close();
            }
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void tileView2_ItemClick(object sender, DevExpress.XtraGrid.Views.Tile.TileViewItemClickEventArgs e)
        {

            position = e.Item.RowHandle;
            if (position == 0 )
            {
                gridControl1.DataSource = product;
                gridControl1.RefreshDataSource();
                tileView2.RefreshData();
            }
            else
            {
                _productcategory.Clear();
                  foreach (Product item in _categoryController.ListALL()[position].produtos)
                 {
                    _productcategory.Add(item);
                  }
                    gridControl1.DataSource = _productcategory;
                    gridControl1.RefreshDataSource();
                    tileView2.RefreshData();
            }
            /*           if (position == 0)
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

                           }*/
           
          
        }

        List<Product> _productcategory = new List<Product>();

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {
            salvar();
        }

        /*========*/
        public void getSerie()
        {
            idSerie = Methods.atualSerieId;
            idTipoDocumento = Methods.atualDocumentTypeId; // Estatico, para VD
        }
    }

     
}
