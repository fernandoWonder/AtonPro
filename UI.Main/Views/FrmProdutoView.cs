using Appplication.Controller;
using Appplication.Statics;
using Domain.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Main.Views.Operacoes;
using UI.Main.Views.PDV;

namespace UI.Main.Views.Save
{
    public partial class FrmProdutoView : DevExpress.XtraEditors.XtraForm
    {
        FrmProducts _frmProducts;
        FrmInvoice _frmInvoice;

        ProductController _produController = new ProductController();
        StockController _stockController = new StockController();
        StorageController _storageController = new StorageController();
        FrmPosRestaurant _frmPosRestaurant;
        int idArmazem = 0;
        private int indexGrid;

        int constructorAtivo = 1;

        const int ContrutorInvoiceAddProduct = 3;
        const int ContrutorProduct_AddProductComposition = 2;
        const int construtorPDVRestaurant = 5;
        const int construtorPDV = 4;
        
        public FrmProdutoView()
        {
            InitializeComponent();
            toGridControlProducts();
        }
        public FrmProdutoView(FrmPosRestaurant _frmPosRestaurant)
        {
            InitializeComponent();
            toGridControlProducts();

            this._frmPosRestaurant = _frmPosRestaurant;
            btnAddProduto.Visible = false;
            btnEdit.Visible = false;
            btnDeleteProduct.Visible = false;

            constructorAtivo = construtorPDVRestaurant;
        }

        PDV.PDV _frmPdv;
        PDV.FrmPosPdv frmPosPdv;
        public FrmProdutoView(PDV.PDV frmPdv)
        {
            InitializeComponent();
            toGridControlProducts();

            _frmPdv = frmPdv;
            btnAddProduto.Visible = false;
            btnEdit.Visible = false;
            btnDeleteProduct.Visible = false;

            constructorAtivo = construtorPDV;
        }
        public FrmProdutoView(PDV.FrmPosPdv frmPdv)
        {
            InitializeComponent();
            toGridControlProducts();

            frmPosPdv = frmPdv;
            btnAddProduto.Visible = false;
            btnEdit.Visible = false;
            btnDeleteProduct.Visible = false;

            constructorAtivo = construtorPDV;
        }

        public FrmProdutoView(FrmProducts frmProducts)
        {
            InitializeComponent();
            toGridControlProducts();
            _frmProducts = frmProducts;
            constructorAtivo = ContrutorProduct_AddProductComposition;
            // Construtor chamado em prodductsAdd na escolha de composição
        }

        public FrmProdutoView(FrmInvoice frmInvoice)
        {
            InitializeComponent();
            toGridControlProducts();

            _frmInvoice = frmInvoice;
            constructorAtivo = ContrutorInvoiceAddProduct;
            btnAddProduto.Visible = false;
            btnEdit.Visible = false;
            btnDeleteProduct.Visible = false;
        }

      /*  public void toComboArmazem()
        {
            cmbArmazem.Properties.Items.Clear();
            cmbArmazem.Properties.Items.Add("Todos");
            // Nota: quando o select não for 0, ao ir buscar o armazem devo decrementar 1 devido ao primeiro item acrescido
            _storageController.List().ForEach(item => cmbArmazem.Properties.Items.Add(item.Armazem));
            cmbArmazem.SelectedIndex = 0;

           /* if(constructorAtivo == construtorPDV)
            {
                cmbArmazem.Enabled = false;
                int i = 0;
                if(cmbArmazem.Properties.Items.Count > 0)
                    foreach (var item in _storageController.List())
                    {
                        if(item.Id == _frmPdv.idArmazemDefault)
                        {
                            cmbArmazem.SelectedIndex = (i + 1);
                            break;
                        }
                        i++;
                    }
         }    }*/

       
       ProductController _prodController = new ProductController();
        public void toGridControlProducts()
        {
            
             //  gdvControlProducts.DataSource = _produController.view1("");
            _stockController = null;
            _stockController = new StockController();
            gdvControlProducts.DataSource = _stockController.viewProductStockArmazemProduct(idArmazem,txtProduto.Text);
          //  gridViewProducts.Columns["Id_Stock"].Visible = false;
            gridViewProducts.RefreshData();
            
            /*_prodController = null;
            _prodController = new ProductController();
            gdvControlProducts.DataSource = _prodController.ListALL();
            
            gridViewProducts.RefreshData();
            */
        }

        private void FrmProdutoView_Load(object sender, EventArgs e)
        {
            //toComboArmazem();
        }

        private void btnAddProduto_Click(object sender, EventArgs e)
        {
            if (UserCurrent.getCurrentUser().FlagAdmin == true )
            {
                new FrmProducts(this).ShowDialog();
            }
            else
            {
                if (UserCurrent.getPermission().Stock)
                {
                    new FrmProducts(this).ShowDialog();
                }
                else
                {
                    MessageBox.Show("Não tem permissão para completar essa operação");
                }
            }
        }

        /*private void cmbArmazem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbArmazem.SelectedIndex != 0)
            {
                idArmazem = _storageController.List()[(cmbArmazem.SelectedIndex - 1)].Id;
                toGridControlProducts();
            }
            else
            {
                idArmazem = 0;
                toGridControlProducts();
            }
        }*/

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            /*indexGrid = e.RowHandle;
            var valorCelula = gridViewProducts.GetRowCellValue(indexGrid, gridViewProducts.Columns["Id"]);*/
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            position = e.RowHandle;
            indexGrid = e.RowHandle;
            var valorCelula = gridViewProducts.GetRowCellValue(indexGrid, gridViewProducts.Columns["Id_Stock"]);
            //MessageBox.Show("Id_Stock = " + valorCelula.ToString());
            if (constructorAtivo == ContrutorInvoiceAddProduct)
            {
                valorCelula = gridViewProducts.GetRowCellValue(indexGrid, gridViewProducts.Columns["Id_Stock"]);
                _frmInvoice.addToList(Convert.ToInt16(valorCelula));
                Close();
            }else if(constructorAtivo == ContrutorProduct_AddProductComposition)
            {
                valorCelula = gridViewProducts.GetRowCellValue(indexGrid, gridViewProducts.Columns["Id"]);
                _frmProducts.toGridProductsComposition(Convert.ToInt16(valorCelula));
                Close();
            }
            else if (constructorAtivo == construtorPDV)
            {
                valorCelula = gridViewProducts.GetRowCellValue(indexGrid, gridViewProducts.Columns["Id_Stock"]);
                // Tirar mais essa verificação pois haverá um único pdv (POS)
                if(_frmPdv == null)
                {
                    frmPosPdv.toGdvControlerProducts(Convert.ToInt16(valorCelula));
                }
                else
                {
                    _frmPdv.toGdvControlerProducts(Convert.ToInt16(valorCelula));
                }

                Close();
            }
            else if (constructorAtivo == construtorPDVRestaurant)
            {
                _frmPosRestaurant.toGdvControlerProducts(Convert.ToInt16(valorCelula));
                Close();
            }

        }

        private void gdvControlProducts_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (position >=0)
            { 
                 if (MethodsTable.messageDelete())
                   {
                         Product product = _produController.getOne(MethodsTable.getCellValueRowSelectedIdInt(gridViewProducts));
                        try
                        {
                            _produController.removeProduct(product);
                        }
                        catch (Exception error)
                        {
                            MessageBox.Show("Este produto não pode ser eliminado, por fazer parte de documentos emitidos..!\n" + error.Message);
                        }
                Methods.playSuccess();
                toGridControlProducts();
            }
            }
            else
            {
                MessageBox.Show("Selecione um produto");
            }
           
        }
        int idProd;
        int position = -1;
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (position>=0)
            {
                if (UserCurrent.getCurrentUser().FlagAdmin == true)
                {
                    idProd = MethodsTable.getCellValueRowSelectedIdInt(gridViewProducts);
                    new FrmProducts(this,idProd).ShowDialog();
                }
                else
                {
                    if (UserCurrent.getPermission().Stock)
                    {
                        idProd = MethodsTable.getCellValueRowSelectedIdInt(gridViewProducts);
                        if (position >= 0)
                        {
                            idProd = MethodsTable.getCellValueRowSelectedIdInt(gridViewProducts);
                            new FrmProducts(this, idProd).ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Selecione o produto");
                        }
                    }
            }
            }
            
            position = -1;
         ///  
        }

        private void txtProduto_EditValueChanged(object sender, EventArgs e)
        {
            toGridControlProducts();
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
