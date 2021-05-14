using Appplication.Controller;
using Appplication.Statics;
using Domain.Domain.Entities.ProductAssistant;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Main.Views.Save
{
    public partial class FrmCategoy : DevExpress.XtraEditors.XtraForm
    {
        CategoryController _categController = new CategoryController();
        public FrmCategoy()
        {
            InitializeComponent();
        }

        private void FrmCategoy_Load(object sender, EventArgs e)
        {
            toGridControlCategory();
        }


        public void toGridControlCategory()
        {
            _categController = null;
            _categController = new CategoryController();
            gdvControlCategory.DataSource = _categController.view1("");
            gdvControlCategory.RefreshDataSource();
        }

        private void btnNewCategory_Click(object sender, EventArgs e)
        {
            if (UserCurrent.getCurrentUser().FlagAdmin == true)
            {
                new FrmCategorySave(this).ShowDialog();

            }
            else
            {
                if (UserCurrent.getPermission().Stock)
                {
                    new FrmCategorySave(this).ShowDialog();
                }
                else
                {
                    MessageBox.Show("Não tem permissão para completar essa operação");
                }
            }
        }

        private void btnRemoveCategory_Click(object sender, EventArgs e)
        {
            if (position>=0)
            {
                if (MethodsTable.messageDelete())
                {
                    Category category = _categController.getOne(MethodsTable.getCellValueRowSelectedIdInt(gdvCategory));
                    if (_categController.delete(category) == 0)
                    {
                        MethodsTable.messageIsUsage();
                    }
                    toGridControlCategory();
                }
            }
            else
            {
                MessageBox.Show("Selecione categoria");
            }
            position = -1;
    
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (position >=0)
            {
                int idCat = _categController.getOne(MethodsTable.getCellValueRowSelectedIdInt(gdvCategory)).Id;
                FrmCategorySave cat = new FrmCategorySave(this,idCat);
                cat.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione uma categoria");
            }
        }
        int position = -1;

        private void gdvCategory_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            position = e.RowHandle;
        }
    }
     
}
