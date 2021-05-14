using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Main.Views.PDV;

namespace UI.Main.Views
{
    public partial class FrmverifySenha : Form
    {
        int activeContructor =0;
        int transferConstructor = 1;

        int removeProductContructor;
        public FrmverifySenha()
        {
            InitializeComponent();
        }
        FrmPosRestaurant frmPosRest;
        int ident = 0;
        public FrmverifySenha(FrmPosRestaurant frmPosRest,int ident)
        {
            InitializeComponent();
            this.frmPosRest = frmPosRest;
            activeContructor = transferConstructor;
            this.ident = ident;
        }
        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            if (textEdit1.Text != "")
            {
                switch (activeContructor)
                {
                    case 1:
                        if (ident !=0 )
                        {
                              new FrmTransferirProducts().ShowDialog();
                        }
                      
                        Close();
                        break;
                    default:
                        break;
                }
            }
            else
            {
                MessageBox.Show("Preencha o campo");
            }
        }
    }
}
