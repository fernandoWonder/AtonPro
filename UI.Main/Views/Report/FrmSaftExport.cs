using Appplication.Statics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Main.Views.Report
{
    public partial class FrmSaftExport : DevExpress.XtraEditors.XtraForm
    {
        public FrmSaftExport()
        {
            InitializeComponent();

            dtpDataFim.MaxDate = DateTime.Now;
            dtpDataInicio.MaxDate = DateTime.Now;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(txtPasta.Text))
            {
                Directory.CreateDirectory(txtPasta.Text);
            }
            if(Methods.exportarSaft(txtFileName.Text.Trim(), txtPasta.Text, dtpDataInicio.Value, dtpDataFim.Value))
            {
                Methods.playSuccess();
            }
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtPasta.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void txtPasta_DoubleClick(object sender, EventArgs e)
        {
            btnPath_Click(sender, e);
        }

    }
}
