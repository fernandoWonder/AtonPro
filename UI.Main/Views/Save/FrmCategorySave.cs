using Appplication.Controller;
using Domain.Domain.Entities.ProductAssistant;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Main.Views.Save
{
    public partial class FrmCategorySave : DevExpress.XtraEditors.XtraForm
    {
        FrmCategoy _frmCategory;

        CategoryController _categController = new CategoryController();
        int qualCtor = 1;
        public FrmCategorySave()
        {
            InitializeComponent();
        }

        public FrmCategorySave(FrmCategoy frmCategory)
        {
            InitializeComponent();
            _frmCategory = frmCategory;
            qualCtor = 2;
        }
        int idCat;
        public FrmCategorySave(FrmCategoy frmCategory,int idCat)
        {
            InitializeComponent();
            _frmCategory = frmCategory;
            qualCtor = 3;
            this.idCat = idCat;
        }

        public void save()
        {
            
            if(txtCategoria.Text.Trim() != "")
            {
                if (qualCtor==3)
                {
                    Category c = _categController.getOne(idCat);
                    c.Categoria = txtCategoria.Text;
                    c.Descricao = txtDesc.Text;
                    _categController.update(c);
                    _frmCategory.toGridControlCategory();
                }
                else
                {
                     if (_categController.insert(new Domain.Domain.Entities.ProductAssistant.Category() { Categoria = txtCategoria.Text.Trim(), Descricao = txtDesc.Text != "" ? txtDesc.Text : "" }) == 0)
                            MessageBox.Show("Erro ao inserir Categoria");
                        else
                        {
                            txtCategoria.Clear();
                            txtDesc.Clear();
                            if (qualCtor == 2)
                                _frmCategory.toGridControlCategory();
                        }
                }
               
                   
            }else
                MessageBox.Show("Preencha o campo categoria!");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            save();
        }

        private void FrmCategorySave_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            save();
            Close();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
