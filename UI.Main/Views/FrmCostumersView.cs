using Appplication.Controller;
using Appplication.Statics;
using DevExpress.DataAccess.Native.Data;
using DevExpress.Office.Utils;
using Domain.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UI.Main.Views.PDV;
using UI.Main.Views.Save;

namespace UI.Main.Views
{
    public partial class FrmCostumersView : Form { 
        CustomerController _customerController = new CustomerController();
        FrmPosRestaurant _frmPosRestaurant;
        FrmPosPdv _frmPosPdv;
        FrmReserveSave frmReserve;
        List<Customer> customers = new List<Customer>();
        const int constructorPosPdv = 3;
        const int constructorPosRestaurant = 4;
        const int construtorReserve = 5;
        int activeConstructor = 1;
        public FrmCostumersView()
        {
            InitializeComponent();
            toGridControlCustomers();
        }
        public FrmCostumersView(FrmReserveSave frmReserve)
        {
            InitializeComponent();
            toGridControlCustomers();
            this.frmReserve = frmReserve;
            activeConstructor = construtorReserve; 
        }

        public FrmCostumersView(FrmPosPdv _frmPosPdv)
        {
            InitializeComponent();
            toGridControlCustomers();
            this._frmPosPdv = _frmPosPdv;
            activeConstructor = constructorPosPdv;

        }
        public FrmCostumersView(FrmPosRestaurant _frmPosRestaurant)
        {
            InitializeComponent();
            toGridControlCustomers();
            this._frmPosRestaurant = _frmPosRestaurant;
            activeConstructor = constructorPosRestaurant;
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            new FrmFornecedorSave(this, 0).ShowDialog();
        }

        public void toGridControlCustomers()
        {
            gdvControlCustomers.DataSource = _customerController.view4(textBox1.Text);
         //   gdvControlCustomers.Update();
            gridView1.RefreshData();
        }  

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Customer customer = _customerController.getOne(MethodsTable.getCellValueRowSelectedIdInt(gridView1));
            if (customer != null && MethodsTable.messageDelete())
            {
                if(customer.Nif == "999999999" && customer.Cliente.Contains("Final"))
                {
                    System.Windows.Forms.MessageBox.Show("Consumidor final, não pode ser apagado..!");
                }
                else if (_customerController.delete(customer) == 0)
                {
                    MethodsTable.messageJaOperou();
                    _customerController.Dispose();
                    _customerController = new CustomerController();
                }
                    
                else
                {
                    Methods.playSuccess();
                    toGridControlCustomers();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int customerID = MethodsTable.getCellValueRowSelectedIdInt(gridView1);
            if(customerID != 1)
                new FrmFornecedorSave(this, customerID).ShowDialog();
            else
                System.Windows.Forms.MessageBox.Show("\"Cunsumidor Funal\" é um cliente Padrão, Não pode ser editado..!");
        }

        private void gdvControlCustomers_DoubleClick(object sender, EventArgs e)
        {
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void gridView1_Click(object sender, EventArgs e)
        {
           
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {

            int index = e.RowHandle;
          
            switch (activeConstructor)
            {
                case constructorPosRestaurant:
                    _frmPosRestaurant.setCostumer(_customerController.ListALL()[index]);
                    Close();
                    break;
                case constructorPosPdv:
                    _frmPosPdv.setCostumer(_customerController.ListALL()[index]);
                    Close();
                    break;
                case construtorReserve:
                    frmReserve.setCustomer(_customerController.ListALL()[index]);
                    Close();
                    break;
                default:
                    break;
            }
        }

        private void gdvControlCustomers_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            gdvControlCustomers.DataSource = _customerController.view3(textBox1.Text);
        }
    }
}
