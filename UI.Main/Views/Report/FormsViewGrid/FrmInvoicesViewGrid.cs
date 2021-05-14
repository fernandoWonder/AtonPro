using Appplication.Controller;
using Domain.Domain.Entities.Documents;
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

namespace UI.Main.Views.Report.FormsViewGrid
{
    public partial class FrmInvoicesViewGrid : Form
    {
        InvoiceController _invoiceController = new InvoiceController();

        public FrmInvoicesViewGrid()
        {
            InitializeComponent();
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            // Funciona quando o editable está desativado
        }

        private void FrmInvoicesViewGrid_Load(object sender, EventArgs e)
        {
            invoces = _invoiceController.view2("");
            gdvControlInvoices.DataSource = invoces;
            


            if (gridView1.RowCount > 0)
            {
                txtInvoiceNo.Text = gridView1.GetRowCellValue(0, gridView1.Columns["InvoiceNo"]).ToString();
                txtIdInvoice.Text = gridView1.GetRowCellValue(0, gridView1.Columns["Id"]).ToString();
            }
        }

        private void gridView1_RowDeleted(object sender, DevExpress.Data.RowDeletedEventArgs e)
        {
            MessageBox.Show("Deleted");
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            txtInvoiceNo.Text = gridView1.GetRowCellValue(e.RowHandle, gridView1.Columns["InvoiceNo"]).ToString();
            txtIdInvoice.Text = gridView1.GetRowCellValue(e.RowHandle, gridView1.Columns["Id"]).ToString();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            int idInvoice = int.Parse(txtIdInvoice.Text);
            FrmReportView frmReport = new FrmReportView();
            frmReport.PrintInvoce(idInvoice);
            frmReport.Show();
        }

        private void gridView1_DoubleClick(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            // Colocar a opção do ponteiro do mouse, se está em celula ou não
            // MessageBox.Show("DoubleClick");
        }

        private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            if (invoces.Count > 0)
            {
                txtInvoiceNo.Text = gridView1.GetRowCellValue(e.ControllerRow, gridView1.Columns["InvoiceNo"]).ToString();
                txtIdInvoice.Text = gridView1.GetRowCellValue(e.ControllerRow, gridView1.Columns["Id"]).ToString();
     
            }
            else
            {
                MessageBox.Show("Nada");
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (invoces.Count>0)
            {
                 txtInvoiceNo.Text = gridView1.GetRowCellValue(e.FocusedRowHandle, gridView1.Columns["InvoiceNo"]).ToString();
                 txtIdInvoice.Text = gridView1.GetRowCellValue(e.FocusedRowHandle, gridView1.Columns["Id"]).ToString();
            }
            else
            {
                MessageBox.Show("Nada");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;
            }
            else
            {
                dateTimePicker2.Enabled = false;
                dateTimePicker1.Enabled = false;
            }
        }
        List<Invoice> invoces = new List<Invoice>();
        
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                invoces = _invoiceController.view2(textEdit1.Text);
                gdvControlInvoices.DataSource = invoces;
                gdvControlInvoices.Refresh();
                gridView1.RefreshData();
            }
            else
            {
                invoces = _invoiceController.view3(textEdit1.Text, dateTimePicker1.Value, dateTimePicker2.Value);
                gdvControlInvoices.DataSource = invoces;
                gdvControlInvoices.Refresh();
                gridView1.RefreshData();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
