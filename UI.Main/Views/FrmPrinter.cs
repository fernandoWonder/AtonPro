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
using System.Drawing.Printing;
using Appplication.Controller;
using Domain.Domain.Entities;
using Appplication.Statics;

namespace UI.Main.Views
{
    public partial class FrmPrinter : DevExpress.XtraEditors.XtraForm
    {
        public FrmPrinter()
        {
            InitializeComponent();
            fillData();
        }
        public void fillData()
        {
            foreach (string item in PrinterSettings.InstalledPrinters)
            {
                comboBoxEdit1.Properties.Items.Add(item);
            }
            gridControl1.DataSource = _printer.ListALL();
        }
        PrinterController _printer = new PrinterController(); 
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (comboBoxEdit1.SelectedIndex >=0)
            {
                if (_printer.ListALL().Count>0)
                {
                    Printer p = _printer.ListALL()[0];
                    p.Print = comboBoxEdit1.Text;
                    _printer.update(p);
                    gridControl1.DataSource = _printer.ListALL();
                  }
                else
                {
                    _printer.insert(new Domain.Domain.Entities.Printer() { Print = comboBoxEdit1.Text });
                    
                    gridControl1.DataSource = _printer.ListALL();
                }
                Methods.PRINTER = comboBoxEdit1.Text;
            }
        }
    }
}