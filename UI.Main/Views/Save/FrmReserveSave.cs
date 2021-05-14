using Appplication.Controller;
using Domain.Domain.Entities;
using Domain.Domain.Entities.Temp;
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
    public partial class FrmReserveSave : Form
    {  
        Customer customer;
        public FrmReserveSave()
        {
            InitializeComponent();
         
        }

        FrmReservesView frmReserve;
        public FrmReserveSave(FrmReservesView frmReserve)
        {
            InitializeComponent();
            this.frmReserve = frmReserve;
            searchLookUpTable.Properties.DataSource = _tableConstroller.ListALL();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FrmCostumersView frm = new FrmCostumersView(this);
            frm.ShowDialog();
        }

        public void setCustomer(Customer customer)
        {
            this.customer = customer;
            txtCliente.Text = customer.Cliente;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void FrmReserveSave_Load(object sender, EventArgs e)
        {
            dateToDay.Value = DateTime.Now;
            dateReserve.Value = DateTime.Now;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            save();
        }
        Table table;
        public void setMesa(Table table)
        {

        }
        public void save()
        {
             
            if (txtCliente.Text.Trim() != "" && txtHora.Text.Trim() != "" && txtFone.Text.Trim() != "" &&  searchLookUpTable.Text != "" && table!=null)
            {
               

                DateTime now = dateToDay.Value;
                DateTime rese = dateReserve.Value;
                if (customer==null)
                {
                    customer = new Customer();
                    customer.Id = 1;
                }

                Reserve reserve = new Reserve()
                {
                    Data = now.ToShortDateString(),

                    DataMarcada = rese.ToShortDateString(),
                    Cliente = txtCliente.Text,
                    Hora = txtHora.Text,
                    Contacto = txtFone.Text,
                    IdClient = customer.Id,
                    Observacoes = txtObservacoes.Text,
                    MesaId = table.Id,
              
                    
                };
               
                _reserveController.insert(reserve);
                clearFields();
                if (frmReserve != null)
                {
                    frmReserve.fillReserves();
                }
                Close();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos");
            }
        }
        public void clearFields()
        {
            txtCliente.Text = "";
            txtFone.Text = "";
            txtHora.Text = "";
            txtObservacoes.Text = "";
            searchLookUpTable.Text = "";
            customer = null;
          
        }
        ReserveController _reserveController = new ReserveController();
        TableController _tableConstroller = new TableController();
        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }

        private void searchLookUpTable_EditValueChanged(object sender, EventArgs e)
        {
            table = _tableConstroller.listForId(int.Parse(searchLookUpTable.Properties.View.GetFocusedRowCellValue("Id").ToString()));

        }
    }
}
