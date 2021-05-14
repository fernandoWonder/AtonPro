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
using Domain.Domain.Entities;
using UI.Main.Views.PDV;

namespace UI.Main.Views.Save
{
    public partial class FrmTableSave : DevExpress.XtraEditors.XtraForm
    {
        public FrmTableSave()
        {
            InitializeComponent();
        }
        int idMesa =0;
        
        public FrmTableSave(int idMesa,FrmTable frmTable)
        {
            InitializeComponent();
            this.frmTable = frmTable;
            this.idMesa = idMesa;
            Table t = _tableController.listForId(idMesa);
            textEdit1.Text = t.Mesa;
            activeContructor = tableConstructor;
        }
        int activeContructor = 1;
        int tableConstructor = 2;
        FrmSerieSave frmSave;
        public FrmTableSave(int id,FrmTableSave frmSave)
        {
            
        }
        FrmTable frmTable;
        public FrmTableSave(FrmTable frmTable)
        {
            InitializeComponent();
            this.frmTable = frmTable;
            activeContructor = tableConstructor;
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Close();
        }
        TableController _tableController = new TableController();
        
        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            if (textEdit1.Text.Trim( )!= string.Empty)
            {
                if (idMesa != 0)
                {
                    Table t = _tableController.listForId(idMesa);
                    t.Mesa = textEdit1.Text;
                    if (_tableController.update(t) > 0)
                    {

                        MessageBox.Show("Editado com sucesso");
                        if (activeContructor == tableConstructor)
                        {
                            frmTable.fillGridTable();
                            Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Algo de errado aconteceu");
                    }
                }
                else
                {
                     Table t = new Table()
                     {
                        Mesa = textEdit1.Text,    
                     };
                
                     if (_tableController.insert(t)>0)
                     {
                        MessageBox.Show("cadastrado com sucesso");
                        if (activeContructor==tableConstructor)
                        {
                            frmTable.fillGridTable();
                            Close();
                        } 
                    }
                    else
                    {
                        MessageBox.Show("Algo de errado aconteceu");
                    }
                }
               
            }
            else
            {
                MessageBox.Show("Preencha os campos");
            }
        }
    }
}