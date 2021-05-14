using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using Appplication.Controller;
using Domain.Domain.Entities.ProductAssistant;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain.Domain.Entities.ProductStock;
using System.Reflection;
using Domain.Domain.Entities;
using Appplication.Statics;
using System.Linq;

namespace UI.Main.Views.Save
{
    public partial class FrmProducts : Form
    {
        FrmProdutoView _produtoView;
        FamilyController familyController = new FamilyController();
        StockController _stockController = new StockController();
        StorageController _storageController = new StorageController();
        TaxCodeController _taxCodeController = new TaxCodeController();
        TaxTypeController _taxTypeController = new TaxTypeController();
        ProductTypeController _productType = new ProductTypeController();
        BaseUnitController _baseUnit = new BaseUnitController();
        CategoryController _catController = new CategoryController();
        ProviderController _providerController = new ProviderController();
        CompositionController _compositionController = new CompositionController();
        CompositionProductsController _compositionProductsControlleer = new CompositionProductsController();

        TaxReasonExemptionController _taxReasonExemption = new TaxReasonExemptionController();
        ProductController _prodController = new ProductController();
        TaxType tiposTaxa;
        List<TaxReasonExemption> motivos;
        List<TaxCode> taxas;

        List<Stock> listaStock = new List<Stock>();
        List<CompositionProducts> _listProductsComposition = new List<CompositionProducts>();
        Company _currentCompany = SystemInfoCurrent.getCurrentCompany();

        OpenFileDialog urlImg;
        Image img;
        decimal ultimoPreco = 0;
        int percent = 25;
        bool txtPreco1Focus = false;

        public string variavel { get; set; }

        public FrmProducts(FrmProdutoView frmProd)
        {
            InitializeComponent();
            _produtoView = frmProd;
        }
        int idProd = 0;
        List<Stock> _stocks = new List<Stock>();
        public FrmProducts(FrmProdutoView frmProd,int idProd)
        {
            InitializeComponent();
            _produtoView = frmProd;
            this.idProd = idProd;
            
            Product p = _prodController.getOne(idProd);

            Methods.allowPermissionFolder(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\SellerProSources\\");
            txtCodBarras.Text = p.Codigo_Barra;
            txtCodigoProduto.Text = p.Codigo;
            txtDescricao.Text = p.Descricao;
            txtDescricao2.Text = p.Descricao2;
            txtPreco1.Text = p.Preco1.ToString();
            txtPreco2.Text = p.Preco2.ToString();
            txtPreco3.Text = p.Preco3.ToString();
            txtPercentPrice.Text = 0+"";
            pictureBox1.Image = Image.FromFile(p.UrlImg);
            txtUltimoPreco.Text = p.Preco1.ToString();
             
            foreach (Stock item in _stockController.ListALL())
            {
                if (item.ProdutoId == p.Id)
                {
                  
                    listaStock.Add(item);
                }
            }
            gdvArmazem.DataSource = listaStock;
            
            Methods.allowPermissionFolder( Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\SellerProSources\\");
        }

        private void FrmProducts_Load_1(object sender, EventArgs e)
        {
            tabPane1.SelectedPageIndex = 0;
            toCombosDataInit();

            searchLUpProvider.Properties.DisplayMember = "Fornecedor";
            searchLUpProvider.Properties.DataSource = _providerController.view3("");
            searchLookUpEdit1.Properties.DataSource = familyController.ListAll();
              

        }

        public void toGridProductsComposition(int idProduct)
        {
            bool haveAlready = false;
            Product p = _prodController.getOne(idProduct);
            
            foreach (var item in _listProductsComposition)
            {
                if (item.ProdutoId == p.Id)
                    haveAlready = true;
            }

            if (!haveAlready)
            {
                _listProductsComposition.Add(new CompositionProducts()
                {
                    Produto = p,
                    ProdutoId = p.Id,
                    Quantidade = numberQdadeProductComp.Value,
                    Descricao = txtDescriptionProductComp.Text,
                });
            }
            /*else {emitir um beep
                MessageBox.Show("O produto já faz parte da composição!");}*/

            txtDescriptionProductComp.Text = "";
            numberQdadeProductComp.Value = 0;
            updateDgvs();
        }
        private void btnInsertArmazem_Click(object sender, EventArgs e)
        {
           
        }

        public void toCombosDataInit()
        {

             // ComboBox TaxCode
            cmbTipoTaxa.Properties.Items.Clear();
            _taxTypeController.ListALLAsNoTracking().ForEach(item => cmbTipoTaxa.Properties.Items.Add(item.Tipo));
            if (_currentCompany.CompanyTypeId != 1)
            {
                cmbTipoTaxa.SelectedIndex = 1;
                cmbTipoTaxa.Enabled = false;
            }
            else
            {
                cmbTipoTaxa.SelectedIndex = 0;
                cmbTipoTaxa.Enabled = true;
            }
            
            // ComboBox Armazem
            cmbArmazem.Properties.Items.Clear();
            _storageController.List().ForEach(item => cmbArmazem.Properties.Items.Add(item.Id + " - " + item.Armazem));
            if (cmbArmazem.Properties.Items.Count > 0)
                cmbArmazem.SelectedIndex = 0;

            // ComboBox TipoProduto
            cmbTipoArtigo.Properties.Items.Clear();
            _productType.ListALLAsNoTracking().ForEach(item => cmbTipoArtigo.Properties.Items.Add(item.Descricao));
            if (cmbTipoArtigo.Properties.Items.Count > 0)
                cmbTipoArtigo.SelectedIndex = 0;

            // ComboBox Unidade
            cmbUnidade.Properties.Items.Clear();
            _baseUnit.ListALLAsNoTracking().ForEach(item => cmbUnidade.Properties.Items.Add(item.Simbolo + " - " + item.Unidade));
            if (cmbUnidade.Properties.Items.Count > 0)
                cmbUnidade.SelectedIndex = 0;

            // ComboCategoria
            cmbCategory.Properties.Items.Clear();
            _catController.ListALLAsNoTracking().ForEach(item => cmbCategory.Properties.Items.Add(item.Categoria));
            if (cmbCategory.Properties.Items.Count > 0)
                cmbCategory.SelectedIndex = 0;

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            CompositionView frm = new CompositionView();
            frm.ShowDialog();
            textBox15.Text = variavel;
        }

        private void simpleButton3_Click_1(object sender, EventArgs e)
        {
          
        }

        public string salvaImg()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\SellerProSources\\";
            if (!Directory.Exists(path))
            {
                    Directory.CreateDirectory(path);
            }
                
            string destinoNome =  path+ DateTime.Now.GetHashCode().ToString().Remove(0,1) + ".jpg";

            ////------------------------------
            Methods.allowPermissionFolder(path);
            ////------------------------------
            try
            {
                  if (urlImg != null)
                {
                    if (urlImg.FileName != "")
                        File.Copy(urlImg.FileName, destinoNome);
                    else
                    {
                        File.Copy(Application.StartupPath + @"\\default.jpg", destinoNome);
                    }
               }
                else
                {
                    if (idProd != 0)
                    {
                        destinoNome = "";
                    }
                    else
                    {
                        File.Copy(Application.StartupPath + @"\\default.jpg",destinoNome);
                    }
                                   
                }
            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }
            

            // -----------------------------
            Methods.denyPermissionFolder(path);
            //------------------------------

            return destinoNome;
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            new FrmProdutoView(this).ShowDialog();
        }

        private void cmbTaxa_SelectedIndexChanged(object sender, EventArgs e)
        {
               }

        private void btnNewArmazem_Click(object sender, EventArgs e)
        {
            new FrmStoreSave(this).ShowDialog();
        }

        private void updateDgvs()
        {
            gdvArmazem.DataSource = listaStock;
            gdvArmazem.RefreshDataSource();

            gdvProductsComposition.DataSource = _listProductsComposition;
            gdvProductsComposition.RefreshDataSource();
        }

        // ===================================================================

        /*condição que deve ir no ceil formating
        Com deve Express não é preciso
        if ((dgv1.Rows[e.RowIndex].DataBoundItem != null) && (dgv1.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
         {
             e.Value = BindProperty(dgv1.Rows[e.RowIndex].DataBoundItem, dgv1.Columns[e.ColumnIndex].DataPropertyName);
         }
        private string BindProperty(object property, string propertyName)
        {
            string retValue = "";
            if (propertyName.Contains("."))
            {
                PropertyInfo[] arrayProperties;
                string leftPropertyName;
                leftPropertyName = propertyName.Substring(0, propertyName.IndexOf("."));
                arrayProperties = property.GetType().GetProperties();
                foreach (PropertyInfo propertyInfo in arrayProperties)
                {
                    if (propertyInfo.Name == leftPropertyName)
                    {
                        retValue = BindProperty(
                          propertyInfo.GetValue(property, null),
                          propertyName.Substring(propertyName.IndexOf(".") + 1));
                        break;
                    }
                }
            }
            else
            {
                Type propertyType;
                PropertyInfo propertyInfo;
                propertyType = property.GetType();
                propertyInfo = propertyType.GetProperty(propertyName);
                retValue = propertyInfo.GetValue(property, null).ToString();
            }
            return retValue;
        }
        */
        public int percentCalcReverve(decimal preco, decimal ultimoPreco)
        {
            decimal percentagem = 0;
            decimal acrescimo = preco - ultimoPreco;
            try
            {
                if(ultimoPreco != 0)
                    percentagem = acrescimo * 100 / ultimoPreco;
            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }
            return Convert.ToInt16(percentagem);
        }

        public decimal percentCalc(decimal value, decimal percent)
        {
            return (value * percent / 100);
        }

        public void calculaPrecoTaxa()
        {
            decimal taxa;
            if (cmbTipoTaxa.SelectedIndex == 0)
            {
                taxa = taxas[cmbTaxCode.SelectedIndex].Taxa;
            }
            else
            {
                taxa = 0;
            }
            txtPreco1Civa.Text = decimal.Parse(txtPreco1.Text) + percentCalc(decimal.Parse(txtPreco1.Text), taxa) + "";
            txtPreco2Civa.Text = decimal.Parse(txtPreco2.Text) + percentCalc(decimal.Parse(txtPreco2.Text), taxa) + "";
            txtPreco3Civa.Text = decimal.Parse(txtPreco3.Text) + percentCalc(decimal.Parse(txtPreco3.Text), taxa) + "";
        }

        public void calcualPreco()
        {
            txtPreco1.Text = ultimoPreco + percentCalc(ultimoPreco, percent) + "";
            calculaPreco23();
        }

        public void calculaPreco23()
        {
            txtPreco2.Text = decimal.Parse(txtPreco1.Text) + percentCalc(decimal.Parse(txtPreco1.Text), int.Parse(txtPercentBetweenPrices.Text)) + "";
            txtPreco3.Text = decimal.Parse(txtPreco2.Text) + percentCalc(decimal.Parse(txtPreco2.Text), int.Parse(txtPercentBetweenPrices.Text)) + "";
        }

        private void txtUltimoPreco_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txtPercentPrice_TextChanged(object sender, EventArgs e)
        {
            if(!txtPreco1Focus)
            {
                if (txtPercentPrice.Text != "-")
                {
                    percent = Convert.ToInt16(txtPercentPrice.Text);
                    calcualPreco();
                    calculaPrecoTaxa();
                }
                else
                {
                    percent = int.Parse(txtPercentPrice.Text);
                    calcualPreco();
                    calculaPrecoTaxa();
                }
            }
        }

        private void txtPreco1_TextChanged(object sender, EventArgs e)
        {
            if(txtPreco1Focus)
            {
                txtPercentPrice.Text = percentCalcReverve(decimal.Parse(txtPreco1.Text), ultimoPreco) + "";
                calculaPreco23();
                calculaPrecoTaxa();
            }
        }

        private void txtPercentPrice_Enter(object sender, EventArgs e)
        {
            txtPreco1Focus = false;
        }

        private void txtPreco1_Enter(object sender, EventArgs e)
        {
            txtPreco1Focus = true;
        }

        public bool haveEmptyField()
        {
            if(txtDescricao.Text.Trim() != "")
                return false;

            return true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
           }

        private void Clear()
        {
            txtDescricao.Text = "";
            txtDescricao2.Text = "";
            txtCodBarras.Text = "";
            txtCodigoProduto.Text = "";
            cmbMoveStock.SelectedIndex = 0;
            cmbMoveStock.SelectedIndex = 0;
            cmbCategory.SelectedIndex = 0;
            cmbUnidade.SelectedIndex = 0;
            cmbTipoArtigo.SelectedIndex = 0;
            cmbArmazem.SelectedIndex = 0;
            txtUltimoPreco.Text = "0";
           
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\SellerProSources\\";
            Methods.allowPermissionFolder(path);
            try
            {
                if (File.Exists(path + "default.png"))
                    pictureBox1.Image = Image.FromFile(path + "default.png");
                Methods.denyPermissionFolder(path);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            pictureBox1.Image = UI.Main.Properties.Resources._default;
            urlImg = null;
            


            gridViewSearchLookUpProvider.SelectRow(0);

            gridViewArmazem.SelectRow(0);

            _listProductsComposition.Clear();
            listaStock.Clear();
            updateDgvs();
            tabPane1.SelectedPage = tabNavigationPage1;
        }

        private void txtPreco2_EditValueChanged(object sender, EventArgs e)
        {
            int taxa;
            if (cmbTipoTaxa.SelectedIndex == 0)
            {
                taxa = 14;
            }
            else
            {
                taxa = 0;
            }
            txtPreco2Civa.Text = decimal.Parse(txtPreco2.Text) + percentCalc(decimal.Parse(txtPreco2.Text), taxa) + "";
        }

        private void txtPreco3_EditValueChanged(object sender, EventArgs e)
        {
            int taxa;
            if (cmbTipoTaxa.SelectedIndex == 0)
            {
                taxa = 14;
            }
            else
            {
                taxa = 0;
            }
            txtPreco3Civa.Text = decimal.Parse(txtPreco3.Text) + percentCalc(decimal.Parse(txtPreco3.Text), taxa) + "";
        }

        private void txtPercentBetweenPrices_EditValueChanged(object sender, EventArgs e)
        {
            calculaPreco23();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void btnChosseImage_Click(object sender, EventArgs e)
        {
           
        }

        private void btnNewArmazem_Click_1(object sender, EventArgs e)
        {
            FrmStoreSave frm = new FrmStoreSave(this);
            frm.ShowDialog();
            
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnInsertArmazem_Click_1(object sender, EventArgs e)
        {

        }
     

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            string pathImgs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\SellerProSources\\";
          
            if (!Directory.Exists(pathImgs))
            {
                Directory.CreateDirectory(pathImgs);
            }
            Methods.allowPermissionFolder(pathImgs);

            using (urlImg = new OpenFileDialog())
            {
                if (urlImg.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(urlImg.FileName))
                    {
                        pictureBox1.Image = Image.FromFile(urlImg.FileName);
                    }
                    else
                    {

                        if (File.Exists(pathImgs + "\\default.png"))
                            pictureBox1.Image = UI.Main.Properties.Resources._default;
                        else
                            pictureBox1.Image = pictureBox1.ErrorImage;
                    }
                  
                }
                Methods.denyPermissionFolder(pathImgs);
            }
        }
     

        private void btnOpenProductList_Click(object sender, EventArgs e)
        {
            new FrmProdutoView(this).ShowDialog();
        }
        List<Stock> novaStock = new List<Stock>();

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Storage st = _storageController.List()[cmbArmazem.SelectedIndex];

            bool exist = false;

            foreach (var item in listaStock)
            {
                if (item.ArmazemId == st.Id)
                    exist = true;
            }

            if (!exist)
            {
                Stock stock = new Stock()
                {
                    ArmazemId = st.Id,
                    Armazem = st,
                    MinStock = Convert.ToInt16(numberMin.Value),
                    MaxStock = Convert.ToInt32(numberMax.Value),
                    Quantidade = Convert.ToInt32(numberQdadeProductArmazem.Value)
                };

                listaStock.Add(stock);
                updateDgvs();

                numberMin.Value = 0;
                numberQdadeProductArmazem.Value = 0;
                numberMax.Value = 999999999;
            }

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }

        private void tabNavigationPage7_Paint(object sender, PaintEventArgs e)
        {

        }
        FamilyRestController _familyController = new FamilyRestController();
        /*
        _familyController.insert(new FamilyRest()
        {
            FamiliaId = int.Parse(searchLookUpEdit1.Properties.View.GetFocusedRowCellValue("Id").ToString()),
                                ProductoId = int.Parse(searchLookUpEdit2.Properties.View.GetFocusedRowCellValue("Id").ToString())
                            });
                        
                            C*/
        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            if (!(listaStock.Count > 0))
                MessageBox.Show("Escolha pelo menos um armazem");
            else if (idProd != 0)
            {
                Product prod = _prodController.getOne(idProd);
                int categriaID = _catController.ListALLAsNoTracking()[cmbCategory.SelectedIndex].Id;
                decimal preco1 = txtPreco1.Text.Trim() != "" ? decimal.Parse(txtPreco1.Text.Trim()) : 0;
                decimal preco2 = txtPreco2.Text.Trim() != "" ? decimal.Parse(txtPreco2.Text.Trim()) : 0;
                decimal preco3 = txtPreco3.Text.Trim() != "" ? decimal.Parse(txtPreco3.Text.Trim()) : 0;

                int codigoTaxa;
                string motivoISEID = null;

                if (cmbTipoTaxa.SelectedIndex == 1)
                {
                    motivoISEID = motivos[cmbTaxCode.SelectedIndex].Id; //_taxReasonExemption.getForReason(cmbTaxCode.Text).Id;
                    codigoTaxa = motivos[cmbTaxCode.SelectedIndex].CodigoTaxaId;
                } 
                else
                {
                    codigoTaxa = tiposTaxa.Taxas.ToList()[cmbTaxCode.SelectedIndex].Id;
                }

                int? fornecedorId = null;
                if (searchLUpProvider.Text != "" && !searchLUpProvider.Text.Contains("Id"))
                    fornecedorId = int.Parse(MethodsTable.getFocusedCellValue(searchLUpProvider.Properties.View, "Id"));
                string destinoName = salvaImg();
                string url;
                 if (destinoName == "")
                {
                    destinoName = prod.UrlImg;
                }
               
                prod.Descricao = txtDescricao.Text;
                 prod.Descricao2 = txtDescricao2.Text.Trim() != "" ? txtDescricao2.Text.Trim() : "";
                prod.Codigo = txtCodigoProduto.Text.Trim() != "" ? txtCodigoProduto.Text.Trim() : "";
                prod.Codigo_Barra = txtCodBarras.Text.Trim() != "" ? txtCodBarras.Text.Trim() : "";

                prod.CategoriaId = categriaID;

                prod.TipoArtigoId = _productType.ListALLAsNoTracking()[cmbTipoArtigo.SelectedIndex].Id;
                prod.UnidadeBaseId = _baseUnit.ListALLAsNoTracking()[cmbUnidade.SelectedIndex].Id;
                prod.Preco1 = preco1;
                prod.Preco2 = preco2;
                prod.Preco3 = preco3;
                prod.Move_Stock = cmbMoveStock.SelectedIndex == 0 ? true : false;
                    prod.DataExpiracao = dtpDataExpiracao.Value;
                prod.UrlImg = destinoName;
                

                if (_prodController.update(prod) == 0)
                    MessageBox.Show("Erro ao atualizar produto");
                else
                {
                    txtUltimoPreco.Text = txtUltimoPreco.Text.ToString().Replace(".", ",");
                    decimal ultimoP = decimal.Parse(txtUltimoPreco.Text.ToString());
                    int lastProductId = prod.Id;
                  /*foreach (Stock item in _stockController.ListALL())
                    {
                        foreach (Stock item2  in listaStock)
                        {
                          if (item.Id == item2.Id && item.ProdutoId == idProd )
                            {
                                _stockController.update(item2);
                            }
                            else
                            {
                                _stockController.insert(item2);
                            }
                        }
                      
                        
                    }
                    */
                  /*  _compositionController.insert(new Composition()
                    {
                        ProdutoId = lastProductId,
                    });

                    int idComposition = _compositionController.getLast().Id;

                    foreach (var item in _listProductsComposition)
                    {
                        item.Produto = null;
                        item.ComposicaoId = idComposition;

                        _compositionProductsControlleer.insert(item);
                    }
                    */
                    
                   
                    try
                    {
                        if (searchLookUpEdit1.Text != "")
                        {
                            int id = _prodController.getLast().Id;
                            _familyController.insert(new FamilyRest()
                            {
                                FamiliaId = int.Parse(searchLookUpEdit1.Properties.View.GetFocusedRowCellValue("Id").ToString()),
                                ProductoId = id
                            });
                        }
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show("A familia de produto não foi cadastrado");
                    }

                    Clear();

                    //   Methods.playSuccess();
                    _produtoView.toGridControlProducts();
                    Close();
                }
                ///////
            }
            else if (!haveEmptyField())
            {
                Product product;
                int categriaID = _catController.ListALLAsNoTracking()[cmbCategory.SelectedIndex].Id;
                decimal preco1 = txtPreco1.Text.Trim() != "" ? decimal.Parse(txtPreco1.Text.Trim()) : 0;
                decimal preco2 = txtPreco2.Text.Trim() != "" ? decimal.Parse(txtPreco2.Text.Trim()) : 0;
                decimal preco3 = txtPreco3.Text.Trim() != "" ? decimal.Parse(txtPreco3.Text.Trim()) : 0;

                int codigoTaxa;
                string motivoISEID = null;

                if (cmbTipoTaxa.SelectedIndex == 1)
                {
                    motivoISEID = motivos[cmbTaxCode.SelectedIndex].Id; //_taxReasonExemption.getForReason(cmbTaxCode.Text).Id;
                    codigoTaxa = motivos[cmbTaxCode.SelectedIndex].CodigoTaxaId;
                }
                else
                {
                    codigoTaxa = tiposTaxa.Taxas.ToList()[cmbTaxCode.SelectedIndex].Id;
                }

                int? fornecedorId = null;
                if (searchLUpProvider.Text != "" && !searchLUpProvider.Text.Contains("Id"))
                    fornecedorId = int.Parse(MethodsTable.getFocusedCellValue(searchLUpProvider.Properties.View, "Id"));

                product = new Product()
                {

                    Descricao = txtDescricao.Text,
                    Descricao2 = txtDescricao2.Text.Trim() != "" ? txtDescricao2.Text.Trim() : "",
                    Codigo = txtCodigoProduto.Text.Trim() != "" ? txtCodigoProduto.Text.Trim() : "",
                    Codigo_Barra = txtCodBarras.Text.Trim() != "" ? txtCodBarras.Text.Trim() : "",
                    CategoriaId = categriaID,
                    TipoArtigoId = _productType.ListALLAsNoTracking()[cmbTipoArtigo.SelectedIndex].Id,
                    UnidadeBaseId = _baseUnit.ListALLAsNoTracking()[cmbUnidade.SelectedIndex].Id,
                    Preco1 = preco1,
                    Preco2 = preco2,
                    Preco3 = preco3,
                    FornecdorId = fornecedorId,
                    FlagState = true,
                    CodigoTaxaId = codigoTaxa,
                    Move_Stock = cmbMoveStock.SelectedIndex == 0 ? true : false,
                    MotivoISEId = motivoISEID,
                    //FornecdorId = 0,

                    DataExpiracao = dtpDataExpiracao.Value,
                    UrlImg = salvaImg(),
                };

                if (_prodController.insert(product) == 0)
                    MessageBox.Show("Erro ao inserir produto");
                else
                {
                    txtUltimoPreco.Text = txtUltimoPreco.Text.ToString().Replace(".", ",");
                    decimal ultimoP = decimal.Parse(txtUltimoPreco.Text.ToString());
                    int lastProductId = _prodController.ListALLAsNoTracking()[(_prodController.ListALLAsNoTracking().Count - 1)].Id;
                    foreach (var item in listaStock)
                    {
                        item.Armazem = null;
                        item.ProdutoId = lastProductId;
                        item.UltimoPreco = ultimoP;
                        item.PrecoMedio = item.UltimoPreco;

                        _stockController.insert(item);
                    }

                    _compositionController.insert(new Composition()
                    {
                        ProdutoId = lastProductId,
                    });

                    int idComposition = _compositionController.getLast().Id;

                    foreach (var item in _listProductsComposition)
                    {
                        item.Produto = null;
                        item.ComposicaoId = idComposition;

                        _compositionProductsControlleer.insert(item);
                    }

                    _produtoView.toGridControlProducts();
                    try
                    {
                        if (searchLookUpEdit1.Text != "")
                           {
                            int id = _prodController.getLast().Id;
                               _familyController.insert(new FamilyRest()
                               {
                                   FamiliaId = int.Parse(searchLookUpEdit1.Properties.View.GetFocusedRowCellValue("Id").ToString()),
                                   ProductoId = id
                               });
                           }
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show("A familia de produto não foi cadastrado");        
                    }
                    
                    Clear();
                    
                    Methods.playSuccess();
                }

            }
            else
                MessageBox.Show("Preencha os campos obrigatórios *");

        }

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            Clear();
        }

        private void cmbTipoTaxa_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbTaxCode.Properties.Items.Clear();
            cmbTaxCode.SelectedIndex = -1;
            //TaxCode t = tCodeController.ListALL()[cmbTaxa.SelectedIndex];
            int idTaxCode = Convert.ToInt16(_taxCodeController.ListALL()[cmbTipoTaxa.SelectedIndex].Id);

            tiposTaxa = _taxTypeController.getOne(cmbTipoTaxa.SelectedIndex + 1);

            if (_currentCompany.CompanyTypeId == 2)
            {
                motivos = tiposTaxa.MotivosIsencao.Where(c => c.RegimeSimplificado).ToList();
            }
            else if (_currentCompany.CompanyTypeId == 3)
            {
                motivos = tiposTaxa.MotivosIsencao.Where(c => c.RegimeExclusao).ToList();
            }
            else
            {
                motivos = tiposTaxa.MotivosIsencao.ToList();
                taxas = tiposTaxa.Taxas.ToList();
            }

            //List <TaxReasonExemption> motivos = _taxCodeController.listaMotivos(idTaxCode);
            if (motivos.Count > 0)
            {
                motivos.ForEach(item => cmbTaxCode.Properties.Items.Add("[0.00%] [" + item.Id + "] " + item.MencaoFatura));
                cmbTaxCode.SelectedIndex = 0;
            }
            else if (idTaxCode == 1)
            {
                taxas.ForEach(c => cmbTaxCode.Properties.Items.Add(c.Taxa + "%" + " - " + c.Descricao));
                cmbTaxCode.SelectedIndex = 0;
            }

            calculaPrecoTaxa();

            //MessageBox.Show(tCodeController.ListALL()[cmbTaxa.SelectedIndex].MotivosIsencao..ToString());

        }

        private void txtUltimoPreco_EditValueChanged(object sender, EventArgs e)
        {
            ultimoPreco = decimal.Parse(txtUltimoPreco.Text);
            calcualPreco();
            calculaPrecoTaxa();
        }

        private void txtPercentPrice_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void searchLUpProvider_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtPreco1_EditValueChanged(object sender, EventArgs e)
        {
            ultimoPreco = decimal.Parse(txtUltimoPreco.Text);
            calcualPreco();
            calculaPrecoTaxa();
        }

        private void txtPercentPrice_EditValueChanged_1(object sender, EventArgs e)
        {
            ultimoPreco = decimal.Parse(txtUltimoPreco.Text);
            calcualPreco();
            calculaPrecoTaxa();
        }

        private void txtPercentPrice_TextChanged_1(object sender, EventArgs e)
        {
            if (!txtPreco1Focus)
            {
                if (txtPercentPrice.Text != "-")
                {
                    percent = Convert.ToInt16(txtPercentPrice.Text);
                    calcualPreco();
                    calculaPrecoTaxa();
                }
                else
                {
                    percent = int.Parse(txtPercentPrice.Text);
                    calcualPreco();
                    calculaPrecoTaxa();
                }
            }
        }

        private void txtPercentBetweenPrices_EditValueChanged_1(object sender, EventArgs e)
        {
            calculaPreco23();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = UI.Main.Properties.Resources._default;
            urlImg = null;
        }

        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {

        }
        int compositionPosition = -1;
        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {            
            if (compositionPosition>=0)
            {
                _listProductsComposition.RemoveAt(compositionPosition);
                compositionPosition = -1;
            }
            else
            {
                MessageBox.Show("Selecione o produto");
            }
        }

        private void tabNavigationPage5_Paint(object sender, PaintEventArgs e)
        {

        }

        // ==============================================================================
    }
}
