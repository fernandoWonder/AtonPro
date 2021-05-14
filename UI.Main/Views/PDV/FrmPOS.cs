using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Main.Views.PDV
{
    public partial class FrmPOS : Form
    {
        public FrmPOS()
        {
            InitializeComponent();
            tabPane1.SelectedPageIndex = 0;
            this.WindowState = FormWindowState.Maximized;
            this.MinimizeBox = false; 
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabNavigationPage1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {

        }
    }
}
