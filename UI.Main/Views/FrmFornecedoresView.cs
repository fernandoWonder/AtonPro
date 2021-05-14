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
using UI.Main.Views.Save;

namespace UI.Main.Views
{
    public partial class FrmFornecedoresView : DevExpress.XtraEditors.XtraForm
    {
        FrmProducts _frmProducts = null;

        public int ctor = 1;

        ProviderController _providerController = new ProviderController();
        public FrmFornecedoresView()
        {
            InitializeComponent();
            ctor = 1;
            toGvdProviderControl();
        }

        public FrmFornecedoresView(FrmProducts productAdd)
        {
            InitializeComponent();
            ctor = 2;
            _frmProducts = productAdd;
            toGvdProviderControlWithProducts();
        }

        public void toGvdProviderControl()
        {
            gdvProviderControl.DataSource = _providerController.view1("");
            gdvProviderControl.Update();
        }

        public void toGvdProviderControlWithProducts()
        {
            gdvProviderControl.DataSource = _providerController.view3("");
            gdvProviderControl.Update();
        }
        private void btnProviderAdd_Click(object sender, EventArgs e)
        {
            new FrmFornecedorSave(this).ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Provider provider = _providerController.getOne(MethodsTable.getCellValueRowSelectedIdInt(gridView1));
            if(provider != null && MethodsTable.messageDelete())
            {
                if (_providerController.delete(provider) == 0)
                {
                    MethodsTable.messageJaOperou();
                    _providerController.Dispose();
                    _providerController = new ProviderController();
                }
                else
                {
                    Methods.playSuccess();
                    toGvdProviderControl();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }
    }
}
