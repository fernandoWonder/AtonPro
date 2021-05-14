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
    public partial class FrmRoomView : Form
    {
        public FrmRoomView()
        {
            InitializeComponent();
            fill();
        }
        List<Room> rooms = new List<Room>();
        private void btnAddProduto_Click(object sender, EventArgs e)
        {
            FrmRoomReserve frm = new FrmRoomReserve();
            frm.ShowDialog();
        }

        public void fill()
        {
            for (int i = 0; i < 8; i++)
            {
                rooms.Add(new Room() { quarto = "Quarto "+i });
            }
            gdvReserves.DataSource = rooms;
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
