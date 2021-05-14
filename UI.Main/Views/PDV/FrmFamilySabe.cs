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

namespace UI.Main.Views.PDV
{
    public partial class FrmFamilySabe : DevExpress.XtraEditors.XtraForm
    {
        public FrmFamilySabe()
        {
            InitializeComponent();
        }
        FrmFamilyRest frmFamilyRest;
        public FrmFamilySabe(FrmFamilyRest frmFamilyRest)
        {
            InitializeComponent();
            this.frmFamilyRest = frmFamilyRest;
            activeContructor = FamilyRestViewConstructor;
        }
        int activeContructor;
        int FamilyRestViewConstructor = 1;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                FamilyController _family = new FamilyController();
                _family.insert(new Family()
                {
                    family = textBox1.Text
                });
                MessageBox.Show("Cadastrado com sucesso");
                if (activeContructor == FamilyRestViewConstructor)
                {
                    frmFamilyRest.fillData();
                }
                Close();
            }
            else
            {
                MessageBox.Show("Preencha o campo correctamente");
            }
        }
    }
}