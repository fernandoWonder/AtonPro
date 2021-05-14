using Appplication.Statics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Main.Views.PDV;

namespace UI.Main.Views.Report
{
    public partial class FrmPosPrinter : Form
    {
        public FrmPosPrinter()
        {
            InitializeComponent();
            foreach (string item in PrinterSettings.InstalledPrinters)
            {
                comboBoxEdit1.Properties.Items.Add(item);
            }
        }
        Main frmMain;
        int activeConst;
        int POS = 1;
        int POSREST = 2;
        int how;

        public FrmPosPrinter(int how)
        {
            InitializeComponent();
            fillData();
            this.how = how;
            activeConst = POS;
        }

        public void fillData()
        {
             foreach (string item in PrinterSettings.InstalledPrinters)
                        {
                            comboBoxEdit1.Properties.Items.Add(item);
                        }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (comboBoxEdit1.Text != "")
            {
                Methods.PRINTER = comboBoxEdit1.Text;
                Close();
            }
            else
            {
                MessageBox.Show("Selecione uma impressora");
            }
        }
    }
}
