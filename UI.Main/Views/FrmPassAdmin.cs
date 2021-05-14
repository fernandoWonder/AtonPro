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
using UI.Main.Views.PDV;

namespace UI.Main.Views
{
    public partial class FrmPassAdmin : Form
    {
        FrmPosPdv _frmPos;
        FrmPosRestaurant _frmPosRes;
        int activeConstructor;
        int POS_CONSTRUCTOR = 1;
        public FrmPassAdmin()
        {
            InitializeComponent();
        }

        public FrmPassAdmin(FrmPosPdv _frmPos)
        {
            InitializeComponent();
            this._frmPos = _frmPos;
            activeConstructor = POS_CONSTRUCTOR;
        }
        public FrmPassAdmin(FrmPosRestaurant _frmPosRes)
        {
            InitializeComponent();
            this._frmPosRes = _frmPosRes;
            activeConstructor = POS_CONSTRUCTOR;
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Close();
        }
        UserController user = new UserController();
        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
        }

        private void FrmPassAdmin_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click_1(object sender, EventArgs e)
        {

            if (textEdit1.Text.Trim() != "" && textEdit2.Text.Trim() != "")
            {
                User _user = user.verify(textEdit1.Text.Trim(), textEdit2.Text.Trim());
                if (_user != null)
                {
                    if (_user.FlagAdmin)
                    { 
                        MessageBox.Show("sucesso");
                        if (activeConstructor == POS_CONSTRUCTOR)
                        {
                            if (_frmPos != null)
                            {
                                _frmPos.setAdminActive();
                            }
                            if(_frmPosRes != null)
                            {
                                _frmPosRes.setAdminActive();
                            }
                            
                            Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Precisa ser Administrador");
                    }
                }
                else
                {
                    MessageBox.Show("Senha ou usuario errado");
                }
            }
            else
            {
                MessageBox.Show("Preencha os campos");
            }
        }
    }
}
