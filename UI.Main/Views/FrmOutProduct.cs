using Appplication.Controller;
using Domain.Domain.Entities.Documents;
using Domain.Domain.Entities.ProductStock;
using System;
using System.Windows.Forms;

namespace UI.Main.Views
{
    public partial class FrmOutProduct : DevExpress.XtraEditors.XtraForm
    {
        StockController _stockController = new StockController();
        StorageController _storageComtroller = new StorageController();
        ProductRetreatController _retretController = new ProductRetreatController();
        int idArmazem = 0;

        public FrmOutProduct()
        {
            InitializeComponent();
            initialize();
        }

        public void initialize()
        {
            _storageComtroller.List().ForEach(c => cmbArmazem.Properties.Items.Add(c.Armazem));
            if (cmbArmazem.Properties.Items.Count > 0)
                cmbArmazem.SelectedIndex = 0;
        }

        private void cmbArmazem_SelectedIndexChanged(object sender, EventArgs e)
        {
            idArmazem = (cmbArmazem.SelectedIndex != -1) 
                ? _storageComtroller.List()[cmbArmazem.SelectedIndex].Id : 0;
            searchLUpProduct.Properties.DataSource = _stockController.viewProductStockArmazemForEntryAndRetreat(idArmazem);
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
          
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (searchLUpProduct.Text != "Id_Produto" && searchLUpProduct.Text != "" && txtQuabtidade.Text != "0" && txtMotivo.Text.Trim() != "")
            {
                ProductRetreat prodRetreat = new ProductRetreat()
                {
                    ArmazemId = idArmazem,
                    ProdutoId = Convert.ToInt16(searchLUpProduct.Properties.View.GetFocusedRowCellValue("Id").ToString()),
                    Quantidade = Convert.ToInt16(txtQuabtidade.Text),
                    Motivo = txtMotivo.Text,
                    DataCadastro = DateTime.Now
                };

                Stock st = _stockController.getStockArmazemProduct(prodRetreat.ProdutoId, prodRetreat.ArmazemId);
                st.Quantidade -= prodRetreat.Quantidade;

                if (_retretController.insert(prodRetreat) > 0)
                {
                    _stockController.update(st);
                    txtMotivo.Clear();
                    txtQuabtidade.Text = "0";
                    cmbArmazem.Focus();
                }
                Close();
            }
            else
                MessageBox.Show("Preencha todos os campos..!");
        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
