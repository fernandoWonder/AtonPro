using Appplication.Controller;
using Appplication.Statics;
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

namespace UI.Main.Views.Save
{
    public partial class FrmUserFirstLogin : Form
    {
        FrmLogin _frmLogin;

        UserController _userController = new UserController();
        User _user;
        
        public FrmUserFirstLogin(User us, FrmLogin frmLogin)
        {
            InitializeComponent();

            _frmLogin = frmLogin;
            _user = us;
            txtUser.Text = _user.Usuario;
            txtSenha.Focus();
        }

        private void txtSenha2_EditValueChanged(object sender, EventArgs e)
        {
            if (txtSenha.Text != txtSenha2.Text)
                lblSenhaDiferente.Visible = true;
            else
                lblSenhaDiferente.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
        
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (!lblSenhaDiferente.Visible)
            {
                if (txtSenha.Text.Trim().Length >= 6 && txtUser.Text.Trim() != "")
                {
                    _user.Senha = txtSenha.Text;
                    _user.Usuario = txtUser.Text;
                    if (_userController.userFirstLoginUpdate(_user) > 0)
                    {
                        
                            new Main(_frmLogin).Show();
                         
                        Hide();
                    }
                    else
                        MessageBox.Show("Erro ao redefinir senha..!");
                }
                else
                    lblminimo6.ForeColor = Color.Red;

            }
            else
                MessageBox.Show("As senhas digitadas são diferentes..!");

        }
    }
}
