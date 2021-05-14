using Appplication.Controller;
using Appplication.Statics;
using DevExpress.XtraEditors;
using Domain.Domain.Entities;
using Domain.Domain.Entities.Documents;
using Domain.Domain.Entities.Financial;
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
using UI.Main.Views.Report;

namespace UI.Main.Views.Operacoes
{
    public partial class FrmCreditOrDebitNote : Form
    {
        int _idInvoice;
        InvoiceController _invoiceController = new InvoiceController();
        InvoiceTypeController _invoiceTypeController = new InvoiceTypeController();
        ProductSalesController _sales = new ProductSalesController();
        StockController _stock = new StockController();
        ProductsSelectedSell _produtctsList = new ProductsSelectedSell();
        InvoiceNoteReasonController _noteReasonController = new InvoiceNoteReasonController();
        InvoiceNoteOperationController _noteOperatioController = new InvoiceNoteOperationController();
        List<ProductSales> __productSales = new List<ProductSales>();

        Invoice _invoiceCorrigir;
        Invoice _invoiceNota;
        Invoice lastInvoice;

        decimal totalIncidencia;
        decimal TotalIva;
        decimal totDescontoProducts;
        //decimal descontoFatura;
        decimal totGeral;
        SerieController _serieController = new SerieController();
        int idSerie;
        string idTipoDocumento;
        int _codigoFaturaAtual;
        string invoiceNo;
        FrmInvoicesForCreditNote _frmInvoiceForCreditNote;

        public FrmCreditOrDebitNote(int invoiceNo, FrmInvoicesForCreditNote frmInvoiceForCreditNote)
        {
            InitializeComponent();

            _idInvoice = invoiceNo;
            _frmInvoiceForCreditNote = frmInvoiceForCreditNote;
        }

        private void FrmCreditOrDebitNote_Load(object sender, EventArgs e)
        {
            _invoiceCorrigir = _invoiceController.getOne(_idInvoice);
            __productSales = _invoiceCorrigir.ProductsSales.ToList();
            preencheDados();            
        }

        public void preencheDados()
        {
            lblFatauraAlterar.Text = _invoiceCorrigir.InvoiceNo;

            txtCliente.Text = _invoiceCorrigir.Cliente.Cliente;
            textNif.Text = _invoiceCorrigir.Cliente.Nif;
            textTel.Text = _invoiceCorrigir.Cliente.Tel;
            txtEnd.Text = _invoiceCorrigir.Cliente.Endereco;
            toCombos();
            updateTots();
        }

        public void toGridView()
        {
            gdvControlProducts.DataSource =__productSales;
            gdvControlProducts.RefreshDataSource();
        }

        public void toCombos()
        {
            _noteOperatioController.ListALLAsNoTracking().ForEach(c => cmbTipoOperacaoNota.Properties.Items.Add(c.Operacao));
            _noteReasonController.ListALLAsNoTracking().ForEach(c => cmbMotivoNota.Properties.Items.Add(c.Razao));
            cmbTipoOperacaoNota.SelectedIndex = 0;
            cmbMotivoNota.SelectedIndex = 0;
        }

        private void cmbTipoNota_SelectedIndexChanged(object sender, EventArgs e)
        {
            if((sender as ComboBoxEdit).SelectedIndex == 1)
            {
                btnRemoveProduct.Enabled = false;
            }
            else
            {
                btnRemoveProduct.Enabled = true;
            }
        }

        private void gridProducts_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            _invoiceCorrigir = new InvoiceController().getOne(_idInvoice);
            if (e.Column.Name == "Qdade")
            {
                int value = Convert.ToInt16(e.Value);
                if (value <= 0 || value > _invoiceCorrigir.ProductsSales.ToList()[e.RowHandle].Quantidade )
                {
                    __productSales[e.RowHandle].Quantidade = _invoiceCorrigir.ProductsSales.ToList()[e.RowHandle].Quantidade;
                    toGridView();
                }
            }
            if (e.Column.Name == "Preco")
            {
                int value = Convert.ToInt16(e.Value);
                if (value <= 0)
                {
                    MessageBox.Show("O preço não pode ser negativo");

                    __productSales[e.RowHandle].Preco = _invoiceCorrigir.ProductsSales.ToList()[e.RowHandle].Preco;
                    toGridView();
                }
            }
            if (e.Column.Name == "Desconto")
            {
                int value = Convert.ToInt16(e.Value);
                if (value < 0 || value > 100)
                {
                    __productSales[e.RowHandle].Desconto = _invoiceCorrigir.ProductsSales.ToList()[e.RowHandle].Desconto;
                    toGridView();
                }
            }
            updateTots();
        }

        public void updateTots()
        {
            toGridView();

            totalIncidencia = 0;
            TotalIva = 0;
            totDescontoProducts = 0;

            foreach (var item in __productSales)
            {
                totalIncidencia += item.TotalIncidencia;
                totDescontoProducts += item.ValorDesconto;
                TotalIva += item.TotalTaxa;
            }

            totGeral = totalIncidencia + TotalIva;

            toTotals();
        }

        public void toTotals()
        {
            lblDescLinhas.Text = "Desc/Linhas: " + totDescontoProducts.ToString("N2");
            lblIva.Text = "Iva: " +  TotalIva.ToString("N2");
            lblIncid.Text = "Incid: " + totalIncidencia.ToString("N2");

            lblTotal.Text = "Total: " + totGeral.ToString("N2");
        }

        public void salvar()
        {
            CalcCodigoFaturaAtual();

            DateTime dataAtual = DateTime.Now;

            string GrossTotal = (totGeral).ToString().Replace(',', '.');
            //   string dadosHash2 = dataAtual.ToString("yyyy-MM-dd") + ";" + dataAtual.ToString("yyyy-MM-ddTHH:mm") + ";" + invoiceNo + ";" + (TotalIva + totalIncidencia).ToString("N2").Replace(",", ".") + ";";
            string dadosHash = dataAtual.ToString("yyyy-MM-dd") + ";" + dataAtual.ToString("yyyy-MM-ddTHH:mm:ss") + ";" + invoiceNo + ";" + GrossTotal + ";";
            dadosHash += lastInvoice != null ? lastInvoice.Hash : "";

            string Hash = Methods.gerarHash(dadosHash, invoiceNo);


            _invoiceNota = new Invoice()
            {
                ClienteId = _invoiceCorrigir.ClienteId, // Trocar depois, pois o motivo da nota pode erro no cliente
                Codigo = _codigoFaturaAtual,
                Desconto = totDescontoProducts,
                InvoiceDate = dataAtual.ToString("yyyy-MM-dd"),
                InvoiceNo = invoiceNo,
                TipoDocumentoId = idTipoDocumento,
                RazaoNota = cmbMotivoNota.Text,
                SeriesId = idSerie,
                TipoOperacaoId = (cmbTipoOperacaoNota.SelectedIndex + 1),
                TotalImposto = TotalIva,
                TotalIncidencia = totalIncidencia,
                UserId = UserCurrent.getCurrentUser().Id,
                Hash = Hash,
                Referencia = _invoiceCorrigir.InvoiceNo,
                FormaPagamentoId = _invoiceCorrigir.FormaPagamentoId,
            };

            int r = _invoiceController.insert(_invoiceNota);

            _invoiceNota = _invoiceController.getForInvoiceNo(invoiceNo);


            int idFatura = _invoiceNota != null ? _invoiceNota.Id : 0;

            if (idFatura == 0)
                MessageBox.Show("Fatura Nula");
            //_invoiceController.Dispose();
            //_invoiceController = new InvoiceController();

            foreach (var item in __productSales)
            {
                Stock stock = _stock.getStockArmazemProduct(item.ProductId, item.Stock.ArmazemId);
                stock.Quantidade += item.Quantidade;
                _stock.update(stock);

                ProductSales productSale = new ProductSales()
                {
                    Desconto = item.Desconto,
                    FaturaId = idFatura,
                    MotivoIsencao = item.MotivoIsencao,
                    Descricao_Produto = item.Product.Descricao,
                    ProductId = item.ProductId,
                    Quantidade = item.Quantidade,
                    StockId = item.StockId,
                    Taxa = item.Taxa,
                    Unidade = item.Unidade,
                    Preco = item.Preco,
                    Observacao = item.Observacao,
                    MotivoISEId = item.MotivoISEId,
                };
                _sales.insert(productSale);
            }

            //__listaSelected.Clear();
         //   gdvControlProducts.DataSource = __listaSelected;
            gdvControlProducts.RefreshDataSource();
            CalcCodigoFaturaAtual();
            print(idFatura);
        }

        public void print(int idFatura)
        {
            FrmReportView frm = new FrmReportView();
            
            frm.PrintInvoce(idFatura, this);
            frm.Show();
        }

        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
           

        }

        public void CalcCodigoFaturaAtual()
        {
            // "9" - Nota Debito,  "10" - Nota Credito
            idSerie = _invoiceCorrigir.SeriesId;

            idTipoDocumento = "10";

            _codigoFaturaAtual = 1;

            lastInvoice = _invoiceController.lastInvoiceInSerieAndType(idSerie, idTipoDocumento);

            if (lastInvoice != null)
            {
                _codigoFaturaAtual += lastInvoice.Codigo;
            }

            
            invoiceNo = _invoiceTypeController.getOne(idTipoDocumento).Tipo + " " + _invoiceCorrigir.Series.Serie + "/" + _codigoFaturaAtual;
            lblNotaNo.Text = invoiceNo;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!Methods.verificaData())
            {
                MessageBox.Show("Verifique se a data do Sistema está correta..!");
            }
            else
            {
                salvar();
                _invoiceController = new InvoiceController();
                _invoiceCorrigir = _invoiceController.getOne(_idInvoice);
                _invoiceCorrigir.Corrigido = true;
                _invoiceController.update(_invoiceCorrigir);
                _frmInvoiceForCreditNote.upDateGrid();
            }

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnNewMotivo_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (!Methods.verificaData())
            {
                MessageBox.Show("Verifique se a data do Sistema está correta..!");
            }
            else
            {
                salvar();
                _invoiceController = new InvoiceController();
                _invoiceCorrigir = _invoiceController.getOne(_idInvoice);
                _invoiceCorrigir.Corrigido = true;
                _invoiceController.update(_invoiceCorrigir);
                _frmInvoiceForCreditNote.upDateGrid();
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            if (gridProducts.RowCount > 1)
            {
                int row = gridProducts.GetSelectedRows()[0];
                __productSales.RemoveAt(row);
                updateTots();
                cmbTipoOperacaoNota.Enabled = false;
            }
            else
            {
                if (DialogResult.Yes == MessageBox.Show("Deseja cancelar a nota de credito..?", "Cancelar", MessageBoxButtons.YesNo))
                {
                    this.Close();
                }
            }
        }
    }
}
