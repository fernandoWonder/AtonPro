using Appplication.Controller;
using Domain.Domain.Entities.Documents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Main.Views.Operacoes;

namespace UI.Main.Views.Save
{
    public partial class FrmSerieSave : DevExpress.XtraEditors.XtraForm
    {
        FrmInvoice _frmInoice;

        SerieController _serieController = new SerieController();

        int qualCtor = 1;
        public FrmSerieSave()
        {
            InitializeComponent();
        }

        public FrmSerieSave(FrmInvoice frmInvoice)
        {
            InitializeComponent();
            qualCtor = 2;
            _frmInoice = frmInvoice;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (txtSerie.Text.Trim() != "")
            {
                _serieController.insert(new Series()
                {
                    Serie = txtSerie.Text.Trim(),
                    AnoInicio = dtpDataInicio.Value,
                    AnoTermino = dtpDataFim.Value
                });

                txtSerie.Text = "";
                if (qualCtor == 2)
                {
                    _frmInoice.serieUpdate();
                    Close();
                }
                Close();
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
