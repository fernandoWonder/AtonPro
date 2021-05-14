using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Appplication.Controller;
using Domain.Domain.Entities;

namespace UI.Main.Views
{
    public partial class FrmPermissionsView : DevExpress.XtraEditors.XtraForm
    {
        public FrmPermissionsView()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
        PermissionController _permissionController = new PermissionController();
        List<Permission> permissions = new List<Permission>();
        private void FrmPermissionsView_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = _permissionController.ListALL();
        }
        int position = -1;
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            position = gridView1.GetSelectedRows()[0];
            string cell = gridView1.GetRowCellValue(position,gridView1.Columns["Id"]).ToString();
            if (cell != null || cell!=string.Empty)
            if (position>=0)
            { 
                bool venda = bool.Parse(gridView1.GetFocusedRowCellValue("Venda").ToString());
                bool stock = bool.Parse(gridView1.GetFocusedRowCellValue("Stock").ToString());
                Permission pemission = _permissionController.listForId(MethodsTable.getCellValueRowSelectedIdInt(gridView1));
                pemission.Venda = venda;
                pemission.Stock = stock;
                _permissionController.update(pemission);
                MessageBox.Show("Salvo com sucesso");
            }
            else
            {
                MessageBox.Show("Selecione uma linha");
            }
             
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
           
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
       
        }
    }
}