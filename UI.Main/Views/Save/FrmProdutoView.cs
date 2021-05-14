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
    public partial class FrmProdutoView : Form
    {
        public int ass { set; get; }
        public FrmProdutoView()
        {
            InitializeComponent();
        }


        private void simpleButton2_Click(object sender, EventArgs e)
        {
            ass = 2;
            FrmProducts frm = new FrmProducts();
            frm.ShowDialog();
           
        }

        private void FrmProdutoView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eFTeste2DataSet.Livro' table. You can move, or remove it, as needed.
         //   this.livroTableAdapter.Fill(this.eFTeste2DataSet.Livro);

        }
    }
}
