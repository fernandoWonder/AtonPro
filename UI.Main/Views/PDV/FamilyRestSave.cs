using Appplication.Controller;
using Domain.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Main.Views.PDV
{
    public partial class FamilyRestSave : Form
    {
        public FamilyRestSave()
        {
            InitializeComponent();
        }
        ProductController _products = new ProductController();
        FamilyController _familyController = new FamilyController();
        FrmFamilyRest _frm;
        public FamilyRestSave(FrmFamilyRest _frm)
        {
            InitializeComponent();
            this._frm = _frm;
    
            searchLookUpEdit2.Properties.DataSource = _products.view3("");
            searchLookUpEdit1.Properties.DataSource = _familyController.ListAll();      
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (searchLookUpEdit1.Text.Trim()!="" && searchLookUpEdit2.Text !="")
            {
               if (_frm!=null)
                  {
                      FamilyRestController _familyController = new FamilyRestController();

                           _familyController.insert(new FamilyRest() {
                                FamiliaId = int.Parse(searchLookUpEdit1.Properties.View.GetFocusedRowCellValue("Id").ToString()),
                                ProductoId = int.Parse(searchLookUpEdit2.Properties.View.GetFocusedRowCellValue("Id").ToString())
                            });
                        
                            Close();
                        }
            }
            else
            {
                MessageBox.Show("Preencha o campo");
            }
         
        }
    }
}
