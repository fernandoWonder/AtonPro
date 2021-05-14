using Appplication.Controller;
using Appplication.Statics;
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

namespace UI.Main.Views
{
    public partial class Armazens : Form
    {
        StorageController _storeController = new StorageController();
        public Armazens()
        {
            InitializeComponent();
            fillData();
        }

        private void btnNewCategory_Click(object sender, EventArgs e)
        {
            FrmStoreSave frm = new FrmStoreSave(this);
            frm.ShowDialog();

        }
        public void fillData()
        {
            gdvControlCategory.DataSource = _storeController.List() ;
            gdvCategory.Columns["FlagState"].Visible = false;
            gdvCategory.RefreshData();
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }
        int idArmazem;
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (position>=0)
            {
                idArmazem = _storeController.List()[position].Id;
                FrmStoreSave arm = new FrmStoreSave(this, idArmazem);
            }
            else
            {
                MessageBox.Show("Selecione um armazem");
            }
            position = -1;
        }
        int position = -1;
        private void btnRemoveCategory_Click(object sender, EventArgs e)
        {
            if (position >=0)
            {
                _storeController.delete(_storeController.List()[position]);
            }
            else
            {
                MessageBox.Show("Selecione o armazem");
            }
            position = -1;
        }

        private void gdvCategory_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            position = e.RowHandle;
        }

        private void gdvControlCategory_Click(object sender, EventArgs e)
        {

        }

        private void btnNewCategory_Click_1(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
           
        }

        private void btnRemoveCategory_Click_1(object sender, EventArgs e)
        {
           
        }

        private void gdvCategory_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            position = e.RowHandle;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

            if (UserCurrent.getCurrentUser().FlagAdmin == true)
            {
                FrmStoreSave frm = new FrmStoreSave(this);
                frm.ShowDialog();
            }
            else
            {
                if (UserCurrent.getPermission().Stock)
                {
                    FrmStoreSave frm = new FrmStoreSave(this);
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Não tem permissão para completar essa operação");
                }
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (position >= 0)
            {
                idArmazem = _storeController.List()[position].Id;
                FrmStoreSave arm = new FrmStoreSave(this, idArmazem);
                arm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione um armazem");
            }
            position = -1;
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            if (UserCurrent.getCurrentUser().FlagAdmin == true)
            {
                if (position >= 0)
                {
                    _storeController.deleteForId(_storeController.List()[position].Id);
                    fillData();
                }
                else
                {
                    MessageBox.Show("Selecione o armazem");
                }
            }
            else
            {
                if (UserCurrent.getPermission().Stock)
                {
                    if (position >= 0)
                    {
                        _storeController.deleteForId(_storeController.List()[position].Id);
                        fillData();
                    }
                    else
                    {
                        MessageBox.Show("Selecione o armazem");
                    }
                }
            }
            position = -1;
        }
    }
}
