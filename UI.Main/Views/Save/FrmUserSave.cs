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
    public partial class FrmUserSave : Form
    {
        CityController _cityController = new CityController();
        UserController _userController = new UserController();
        FrmUsersView _frmUserView;
        public FrmUserSave(FrmUsersView frmUserView)
        {
            InitializeComponent();
            _frmUserView = frmUserView;
        }

        public void toCmbCity()
        {
            cmbCity.Properties.Items.Clear();
            _cityController.ListALLAsNoTracking().ForEach(item => cmbCity.Properties.Items.Add(item.Cidade));
            if (cmbCity.Properties.Items.Count > 0)
                cmbCity.SelectedIndex = 0;
        }

        public bool haveEmptyField()
        {
            bool r = true;
            if (txtNome.Text.Trim() != "" && txtEmail.Text.Trim() != "" && txtTel.Text.Trim() != "" &&
                txtAddress.Text.Trim() != "" && mskTxtBI.Text.Trim() != "" && txtUser.Text.Trim() != "")
                r = false;
            if (!txtSenha.Text.Trim().Equals(txtSenha2.Text))
                r = true;
            return r;
        }
        private void FrmUserSave_Load(object sender, EventArgs e)
        {
            toCmbCity();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
          
        }
        private void clearField()
        {
            txtSenha.Text = "";
            txtSenha2.Text = "";
            txtEmail.Text = "";
            mskTxtBI.Text = "";
            txtAddress.Text = "";
            txtTel.Text = "";
            txtNome.Text = "";
            txtUser.Text = "";
            cmbCity.SelectedIndex = 0;
            cmbSexo.SelectedIndex = 0;
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void txtSenha2_EditValueChanged(object sender, EventArgs e)
        {
            if (txtSenha.Text != txtSenha2.Text)
                lblSenhaDiferente.Visible = true;
            else
                lblSenhaDiferente.Visible = false;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            int cityID = _cityController.ListALLAsNoTracking()[cmbCity.SelectedIndex].Id;
            if (!haveEmptyField())
            {
                User user = new User()
                {
                    CidadeId = cityID,
                    Nome = txtNome.Text.Trim(),
                    Bi = mskTxtBI.Text != "" && mskTxtBI.Text.Length >= 9 ? mskTxtBI.Text.Remove(0, 4).Trim() : "",
                    Email = txtEmail.Text.Trim(),
                    DataNascimento = dtpDataNascimento.Value,
                    Sexo = cmbSexo.SelectedIndex == 0 ? "M" : "F",

                    Endereco = txtAddress.Text.Trim(),
                    Tel = txtTel.Text.Trim(),
                    Usuario = txtUser.Text,
                    Senha = txtSenha.Text,

                    FlagAdmin = cmbAcesso.SelectedIndex == 0 ? true : false,
                  //  FlagStandard = cmbAcesso.SelectedIndex == 0 ? true : false,
                };

                if (_userController.salvar(user) == 0)
                    MessageBox.Show("Erro ao inserir...");
                else
                {
                    /* Colocar aqui o código para atualiar a grid user
                        if (_frmProviderView.ctor == 2)
                            _frmProviderView.toGvdProviderControlWithProducts();*/
                }
                /*  }*/

                PermissionController _permissionController = new PermissionController();
                if (cmbAcesso.SelectedIndex == 1)
                {
                    _permissionController.insert(new Permission() {
                          Stock = prStock.Checked,
                          Venda = prVendas.Checked,
                          UsuarioId = _userController.getLast().Id,
                    });
                }

                _frmUserView.updateGrid();
                


                clearField();
                Close();
            }
            else
                MessageBox.Show("Preencha todos campos obrigatórios *");
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbAcesso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAcesso.SelectedIndex == 1)
            {
                prVendas.Enabled = true;
                prStock.Enabled = true;
            }
            else
            {
                prVendas.Enabled =false;
                prStock.Enabled = false;
            }
        }
    }
}
