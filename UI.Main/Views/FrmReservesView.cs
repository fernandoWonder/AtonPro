using Appplication.Controller;
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
using UI.Main.Views.Save;

namespace UI.Main.Views
{
    public partial class FrmReservesView : Form
    {
        ReserveController reserveController = new ReserveController(); 

        public void fillReserves()
        {
            gdvReserves.DataSource = reserveController.view1("");
        }
        public FrmReservesView()
        {
            InitializeComponent();
            fillReserves();
            List<Reserve> reserves = reserveController.ListAll();
            foreach (Reserve item in reserves)
            {
                if (item.DataMarcada == DateTime.Now.ToShortDateString())
                {
                    MessageBox.Show("Reservas para hoje as " + item.Hora + " - " + item.Cliente);
                }
            }
        }

        private void btnAddProduto_Click(object sender, EventArgs e)
        {
            FrmReserveSave frm = new FrmReserveSave(this);
            frm.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }
    }
}
