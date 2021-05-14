using Appplication.Controller;
using Domain.Domain.Entities.ProductStock;
using System;
using System.Windows.Forms;

namespace UI.Main.Views.Save
{
    public partial class FrmStoreSave : DevExpress.XtraEditors.XtraForm
    {
        StorageController sc = new StorageController();

        //Armazem _armazem; 
        FrmProducts _prod;
        int qualCtor = 1;
        int editstore = 5;
        Armazens _frmStore;
      /*  public FrmStoreSave(Armazem am)
        {
            InitializeComponent();
            _armazem = am;
            qualCtor = 2;
        }
        */
        public FrmStoreSave(FrmProducts prod)
        {
            InitializeComponent();
            _prod = prod;
            qualCtor = 3;
        }
        public FrmStoreSave(Armazens _frmStore, int id)
        {
            InitializeComponent();
            this._frmStore = _frmStore;
            qualCtor = 5;
            this.id = id;
        }
        public FrmStoreSave(Armazens _frmStore)
        {
            InitializeComponent();
            this._frmStore = _frmStore;
            qualCtor = 4;
        }
        public FrmStoreSave()
        {
            InitializeComponent();
        }
        public FrmStoreSave(string n)
        {
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
     
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
                   }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
        int id;

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            
            if (txtArmazem.Text.Trim() != "")
            {
                if (qualCtor == 5)
                {
                    Storage sto = sc.getOne(id);
                    sto.Armazem = txtArmazem.Text;
                    sto.Descricao = txtDescricao.Text;
                    sc.update(sto);
                    _frmStore.fillData();
                    Close();
                }
                else
                {
                    Storage st = new Storage() { Armazem = txtArmazem.Text.Trim(), Descricao = txtDescricao.Text.Trim() };
                    bool have = false;
                    sc.List().ForEach(c => have = (c.Armazem.ToLower() == txtArmazem.Text.Trim().ToLower()));
                    if (!have)
                    {
                        int r = sc.inserir(st);
                        if (r > 0)
                        {
                            txtArmazem.Text = "";
                            txtDescricao.Text = "";
                        }

                        if (qualCtor == 3)
                            _prod.toCombosDataInit();
                        if (qualCtor == 4)
                        {
                            _frmStore.fillData();
                        }
                        Close();
                    }
                    else
                        MessageBox.Show("O Armazem '" + txtArmazem.Text + "' Já Exixte");

                }
                }

        }

        private void bunifuImageButton2_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
