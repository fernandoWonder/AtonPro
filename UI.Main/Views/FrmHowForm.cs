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
using UI.Main.Views.PDV;

namespace UI.Main.Views
{
    public partial class FrmHowForm : DevExpress.XtraEditors.XtraForm
    {
        public FrmHowForm()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FrmPosRestaurant frm = new FrmPosRestaurant(null);
            frm.Show();
            Hide();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            FrmPosPdv frm = new FrmPosPdv(null);
            frm.Show();
            Hide();
        }
    }
}