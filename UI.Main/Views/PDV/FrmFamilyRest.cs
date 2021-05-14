using Appplication.Controller;
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
    public partial class FrmFamilyRest : Form
    {
        public FrmFamilyRest()
        {
            InitializeComponent();
            fillData();
        }

        private void btnAddProduto_Click(object sender, EventArgs e)
        {
            FrmFamilySabe frm = new FrmFamilySabe(this);
            frm.ShowDialog();
        }
        FamilyRestController _familyRestController = new FamilyRestController();
        FamilyController _familyController = new FamilyController();
        public void fillData()
        {
            gridControl1.DataSource = _familyController.ListAll(); ;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FamilyRestSave frm = new FamilyRestSave(this);
            frm.ShowDialog();
        }
    }
}
