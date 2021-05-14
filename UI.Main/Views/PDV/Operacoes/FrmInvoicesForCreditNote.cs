using Appplication.Controller;
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

namespace UI.Main.Views.Operacoes
{
    public partial class FrmInvoicesForCreditNote : Form
    {
        InvoiceController _invoiceController = new InvoiceController();
        CustomerController _customerController = new CustomerController();
        // bool creditado = false;
        // string invoiceNo;
        bool corrigido;
        Customer cliente;
        public int ClienteID = 0;

        public FrmInvoicesForCreditNote()
        {
            InitializeComponent();
        }
        private void FrmInvoicesForCreditNote_Load(object sender, EventArgs e)
        {
            searchLUpCustomer.Properties.DisplayMember = "Cliente";
            searchLUpCustomer.Properties.DataSource = _customerController.view3("");
        }

        private void btnCorrigir_Click(object sender, EventArgs e)
        {
            if(gridViewFaturasCliente.RowCount > 0)
            {
                FrmCreditOrDebitNote frmNote = new FrmCreditOrDebitNote(Convert.ToInt16(txtIdInvoice.Text), this);
                frmNote.ShowDialog();
            }else
                MessageBox.Show("Nenhuma fatura selecionada..!");
        }

        private void gridViewFaturasCliente_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
           // invoiceNo = gridViewFaturasCliente.GetRowCellValue(e.FocusedRowHandle, gridViewFaturasCliente.Columns["InvoiceNo"]).ToString();
           if(gridViewFaturasCliente.RowCount > 0)
                txtIdInvoice.Text = gridViewFaturasCliente.GetRowCellValue(e.FocusedRowHandle, gridViewFaturasCliente.Columns["Id"]).ToString();
        }

        public void upDateGrid()
        {
            if(ClienteID > 0)
            {
                cliente = new CustomerController().getOne(ClienteID);
                gdvControlInvoices.DataSource = cliente.Faturas.Where(c => (c.TipoDocumento.Tipo == "FT" || c.TipoDocumento.Tipo == "FR") && c.Corrigido == corrigido).ToList();
                gdvControlInvoices.RefreshDataSource();
            }
        }
        private void searchLUpCustomer_EditValueChanged(object sender, EventArgs e)
        {
            ClienteID = Convert.ToInt16(searchLUpCustomer.Properties.View.GetFocusedRowCellValue("Id").ToString());
            upDateGrid();       
        }

        private void cmbCorrigido_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbCorrigido.SelectedIndex == 0)
                corrigido = !(btnCorrigir.Enabled = true);
            else
                corrigido = !(btnCorrigir.Enabled = false);
            upDateGrid();    
        }
    }
}
