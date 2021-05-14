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
using Domain.Domain.Entities.Temp;
using Appplication.Statics;
using Appplication.Controller;
using UI.Main.Views.Report;

namespace UI.Main.Views
{
    public partial class frmOpenBox : DevExpress.XtraEditors.XtraForm
    {
        Main m;
        FrmCaixa frmC;
        public frmOpenBox(FrmCaixa frmC)
        {
            InitializeComponent();
            this.frmC = frmC;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            // string hora = DateTime.Now.Hour <= 9 ? "0" + DateTime.Now.Hour. : DateTime.Now.Hour;
            Turno t = new Turno()
            {   
                Data = DateTime.Now,
                Estado = "Aberto",
                Hora = DateTime.Now.ToShortTimeString(),
                Caixa = decimal.Parse(textEdit1.Text),
                Abertura = decimal.Parse(textEdit1.Text),
                Tpa = 0,
                UserId = UserCurrent.getCurrentUser().Id,
                UserName = UserCurrent.getCurrentUser().Nome,
                DataF = DateTime.Now,
                HoraF = DateTime.Now.ToShortTimeString(),
                
            };
            TurnoController _turnoController = new TurnoController();
            _turnoController.insert(t);   TurnoCurrent.initialize(t);
            frmC.setButtonFalse();
            frmC.fillData();
            FrmReportView frm = new FrmReportView();
            frm.PrintOpenBox(TurnoCurrent.getTurnoCurrent());
            
            Close();
           // Hide();
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}