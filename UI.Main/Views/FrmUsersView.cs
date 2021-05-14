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
using UI.Main.Views.Save;

namespace UI.Main.Views
{
    public partial class FrmUsersView : DevExpress.XtraEditors.XtraForm
    {
        UserController _userController = new UserController();

        public FrmUsersView()
        {
            InitializeComponent();
        }

        private void FrmUsersView_Load(object sender, EventArgs e)
        {
            updateGrid();
        }
        public void updateGrid()
        {
            dgvControlUsers.DataSource = _userController.view2("");
            dgvControlUsers.RefreshDataSource();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            new FrmUserSave(this).ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            User us = _userController.getOne(MethodsTable.getCellValueRowSelectedIdInt(gridViewUsers));
            if(us.FlagAdmin)
                MessageBox.Show("Este é o usuário administrador, não pode ser apagado..!");
            else if (us.FlagLogado)
            {
                MessageBox.Show("Não pode apagar este usuário porque está logado..!");
            }
            else
            {
                if (_userController.deletar(us) == 0)
                    MethodsTable.messageJaOperou();
                else
                {
                    Methods.playSuccess();
                    updateGrid();
                }
                    
            }
        }

    }
}
