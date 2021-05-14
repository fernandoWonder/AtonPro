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
using Appplication.Controller;
using Domain.Domain.Entities.Temp;
using Appplication.Statics;

namespace UI.Main.Views
{
    public partial class FrmClose : DevExpress.XtraEditors.XtraForm
    {
        FrmCaixa frmC;
        public FrmClose(FrmCaixa frmC)
        {
            InitializeComponent();
            this.frmC = frmC;
            List<Turno> t = new List<Turno>();
            t.Add(new TurnoController().getLast());
            gridControl1.DataSource = t;

        }

        private void btnOpenClose_Click(object sender, EventArgs e)
        {
            Turno t = TurnoCurrent.getTurnoCurrent();
            t.Estado = "Fechado";
            new TurnoController().update(t);
            TurnoCurrent.initialize(null);
            frmC.fillData();
            Close();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}