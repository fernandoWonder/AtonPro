using Appplication.Controller;
using System;
using System.Windows.Forms;

namespace UI.Main.Views.Save
{
    public partial class Armazem : DevExpress.XtraEditors.XtraForm
    {
        StorageController st = new StorageController();
        public Armazem()
        {
            InitializeComponent();
            preenche();
        }

        public void preenche()
        {
            gdvArmazem.DataSource = st.view1("");
        }
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            new FrmStoreSave(this).ShowDialog();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
