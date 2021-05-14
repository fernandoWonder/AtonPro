using Appplication.Controller;
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
using UI.Main.Views.PDV;

namespace UI.Main.Views
{
    public partial class FrmTransferirProducts : Form
    {
       List<ProductSellectedTable> prods = new List<ProductSellectedTable>();
        List<ProductSellectedTable> prods2 = new List<ProductSellectedTable>();
        ProductsSelectedTableController _productSelectedControllerTable = new ProductsSelectedTableController();
        TableController _tableController = new TableController();
        FrmPosRestaurant _frm;
        int idMesa;
        public FrmTransferirProducts()
        {
            InitializeComponent();
        }
        public FrmTransferirProducts(int idMesa,FrmPosRestaurant _frm)
        {
            InitializeComponent();
            this.idMesa = idMesa;
            fillDataSources();
            this._frm = _frm;
        }

        public void fillDataSources()
        {
            //gridControl1.DataSource = _productSelectedControllerTable.view1("", idMesa);
            lblMesa.Text = "MESA " + idMesa;
             searchLookUpEdit1.Properties.DataSource = _tableController.ListALL();
            prods2 = _productSelectedControllerTable.view1("", idMesa);
            gridControl1.DataSource = prods2;
            int count = 0;
            for (int i = 0; i < count; i++)
            {
              //  ProductSellectedTable p = _productSelectedControllerTable.listForId(int.Parse(gridView1.GetRowCellValue(i, gridView1.Columns["Id"]).ToString())); 
            //    prods2.Add(p);
            }
         
           
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
       
            
                int idStoque = id;
                decimal preco = _productSelectedControllerTable.listForId(idProduct).Preco;
                bool have = false;

                if (id != 0)
                {
                    foreach (ProductSellectedTable item in prods)
                    {
                        if (item.StockId == id)
                        {
                            have = true;
                            decimal qt = decimal.Parse(prods2[gridView1.FocusedRowHandle].Quantidade.ToString());
                            if (qt>0)
                            {
                                 item.Quantidade = item.Quantidade + 1;
                                 prods2[gridView1.FocusedRowHandle].Quantidade = prods2[gridView1.FocusedRowHandle].Quantidade - 1;
                                 break;
                            }
                        }
                    }
                    if (!have)
                    {
                        prods2[gridView1.FocusedRowHandle].Quantidade = prods2[gridView1.FocusedRowHandle].Quantidade - 1;

                        prods.Add(new ProductSellectedTable()
                        {
                            productoName = _productSelectedControllerTable.listForId(idProduct).Produto.Descricao,
                            data = DateTime.Now.ToShortDateString(),
                            ProdutoId = _productSelectedControllerTable.listForId(idProduct).ProdutoId,
                            
                            Preco = preco,
                            StockId = idStoque,
                            Quantidade = 1,

                        });
                    }

                    gridControl2.DataSource = prods;
                    gridView2.RefreshData();
                    gridControl1.DataSource = prods2;
                    gridView1.RefreshData();

                
            }
        
        }
        int idProduct;

        private void searchLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmTransferirProducts_Load(object sender, EventArgs e)
        {

        }

        private void gdvControlInvoices_FocusedViewChanged(object sender, DevExpress.XtraGrid.ViewFocusEventArgs e)
        {

        }
        int id = 0;
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            index = e.FocusedRowHandle;
            id = _productSelectedControllerTable.listForId(int.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["Id"]).ToString())).StockId ;
            idProduct =  int.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["Id"]).ToString());

        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            if (searchLookUpEdit1.GetSelectedDataRow() == null || searchLookUpEdit1.GetSelectedDataRow() != null && int.Parse(searchLookUpEdit1.Properties.View.GetFocusedRowCellValue("Id").ToString()) == idMesa)
            {
                MessageBox.Show("Selecione uma mesa válida");
            }
            else
            {
                if (prods.Count > 0)
                {

                    int idMesa = int.Parse(searchLookUpEdit1.Properties.View.GetFocusedRowCellValue("Id").ToString());
                    TableController _tableController = new TableController();
                    foreach (ProductSellectedTable item in prods)
                    {
                        bool have = false;
                        item.MesaId = idMesa;
                        if (item.Quantidade > 0)
                        {
                            foreach (ProductSellectedTable item2 in _tableController.listForId(item.MesaId).productsSellectedTable)
                            {
                                if (item2.StockId == item.StockId)
                                {
                                    ProductSellectedTable pro = _productSelectedControllerTable.listForId(item2.Id);
                                    pro.Quantidade += item.Quantidade;
                                    _productSelectedControllerTable.update(pro);
                                    have = true;
                                }
                            }
                            if (!have)
                            {
                                _productSelectedControllerTable.insert(item);
                            }
                        }
                    }
                    foreach (ProductSellectedTable item in prods2)
                    {
                        if (item.Quantidade == 0)
                        {
                            _productSelectedControllerTable.remove(_productSelectedControllerTable.listForId(item.Id));
                        }
                        else
                        {
                            ProductSellectedTable pro = _productSelectedControllerTable.listForId(item.Id);
                            pro.Quantidade = item.Quantidade;
                            _productSelectedControllerTable.update(pro);
                        }


                    }
                    MessageBox.Show("Transferido com sucesso");
                    _frm.tableSelected(_tableController.listForId(this.idMesa));
                    Close();
                }
                else
                {
                    MessageBox.Show("Nenhum produto selecionado");
                }
            }
        }
        int index ;
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            ProductSellectedTable prod = prods[gridView2.FocusedRowHandle];
            if (prod.Quantidade > 0)
            {
                prod.Quantidade = prod.Quantidade - 1;
                foreach (ProductSellectedTable item in prods2)
                 {
                    if (item.StockId == prod.StockId)
                    {
                        item.Quantidade = item.Quantidade + 1; 
                    }
                }
            }
            foreach (ProductSellectedTable item in prods)
            {
                 
                 
            }
            gridControl2.DataSource = prod;
            gridControl1.DataSource = prods2;
            gridView2.RefreshData();
            gridView1.RefreshData();
          
        }
    }
}
