using Appplication.Controller;
using Appplication.Statics;
using Domain.Domain.Entities.Temp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Main.Views.Report;

namespace UI.Main.Views
{
    public partial class FrmCaixa : Form
    {
        public FrmCaixa()
        {
            InitializeComponent();
            fillData();
          
        }
        public void setButtonFalse()
        {
            btnOpenClose.ButtonText = "Fechar Caixa";
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            
            if (TurnoCurrent.getTurnoCurrent() == null)
            {
                frmOpenBox frmOpen = new frmOpenBox(this);
                frmOpen.ShowDialog();
            }
            else
            {
                if (MessageBox.Show("Fechar o Caixa ? ","Fechar caixa",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
                {
                    FrmReportView frm = new FrmReportView();
                    Turno t = TurnoCurrent.getTurnoCurrent();
                    t.DataF = DateTime.Now;
                    t.HoraF = DateTime.Now.ToShortTimeString();
                    t.Estado = "Fechado";
                    new TurnoController().update(t);
                    fillData();
                    btnOpenClose.ButtonText = "Abrir Caixa";
                    frm.PrintCloseBox(t);
                    TurnoCurrent.initialize(null);
                }
                else
                {
                    return;
                }
            }

        }
        public void fillData()
        {
            List<Turno> list = new TurnoController().ListALL();
            
            list.Reverse();
            gridControl1.DataSource = list;
        }

        private void FrmCaixa_Load(object sender, EventArgs e)
        {
            if (TurnoCurrent.getTurnoCurrent()==null)
            {
                btnOpenClose.ButtonText = "Abrir Caixa";
            }
            else
            {
                btnOpenClose.ButtonText = "Fechar Caixa";
            }
        }
    }
}
