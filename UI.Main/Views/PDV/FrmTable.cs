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
using UI.Main.Views.Save;

namespace UI.Main.Views.PDV
{
    public partial class FrmTable : Form
    {
        List<Table> mesa = new List<Table>();
        List<TablesOcupad> tablesOcupads = new List<TablesOcupad>();
        const int POSCONSTRUCTOR = 1;
        int activeConstructor = 0;
        FrmPosRestaurant frmPos;
        TableController _tableController = new TableController();
        ProductsSelectedTableController _productsSelectedTableController = new ProductsSelectedTableController();
        int function;
        public FrmTable()
        {
            InitializeComponent();
            fillGridTable();
        }
        public FrmTable(FrmPosRestaurant frmPos,int function)
        {
            InitializeComponent();
            fillGridTable();
            this.frmPos = frmPos;
            activeConstructor = POSCONSTRUCTOR;
             this.function = function;
            btnAddProduto.Visible = false;
        }
       

        public void fillGridTable()
        {

            ////vai buscar as mesas no banco de dados
            /*
            for (int i = 0; i < 20; i++)
            {
                Table t = new Table("Mesa "+i);
                t.Id = i;
                t.Image = UI.Main.Properties.Resources.Table_52_blue1;
                mesa.Add(t);
            }

            apenas para teste // enchear com algumas mesas ocupadas
             
            for (int i = 0; i < 8; i++)
            {
//                o resto de divisao é para fazer alternancia de ocupadas /// apenas para estiticas
                if (i % 2 == 0)
                {
                   TablesOcupad table = new TablesOcupad(i, "");
                   tablesOcupads.Add(table);
                }
            }


            for (int i = 0; i < mesa.Count; i++)
            {
                    foreach (TablesOcupad item in tablesOcupads)
                    {
                        if (mesa[i].Id == item.id)
                        {
                            mesa[i].Image = UI.Main.Properties.Resources.table_red;
                        }
                    }   
            }*/
             mesa = _tableController.ListALL();
            foreach (Table t in mesa)
            {
                t.Image = UI.Main.Properties.Resources.Table_52_blue1;
                foreach (ProductSellectedTable item in _productsSelectedTableController.ListAll())
                {
                    if (item.MesaId == t.Id)
                    {
                        t.Image = UI.Main.Properties.Resources.table_red;
                        break;
                    }
                }
            }
            gridControl1.DataSource = mesa ;
            tileView1.RefreshData();
            
        }
      
        public Boolean isOcupad(int id)
        {
            foreach (ProductSellectedTable item in _productsSelectedTableController.ListAll())
            {
                if (item.MesaId == id)
                {
                    return true;
                }
            }
            return false;
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddProduto_Click(object sender, EventArgs e)
        {
            FrmTableSave frm = new FrmTableSave(this);
            frm.ShowDialog();
            
        }

        private void tileView1_ItemClick(object sender, DevExpress.XtraGrid.Views.Tile.TileViewItemClickEventArgs e)
        {
            Table t = mesa[e.Item.RowHandle];
            idMesa = t.Id;
            switch (activeConstructor)
            {
                case POSCONSTRUCTOR:
                    if (function == 2)
                    {
                        if (isOcupad(idMesa))
                        {
                             frmPos.tableSelected(t);
                             frmPos.setTable(t);
                        }
                        else
                        {
                            MessageBox.Show("Essa mesa não está em utilização ");
                        }
                       
                    }
                    else 
                    {
                        if (isOcupad(idMesa))
                        {
                            MessageBox.Show("Essa mesa está ocupada");
                        }
                        else
                        {
                            frmPos.setTable(t);
                        } 
                       
                    }
                   
                    Close();
                   
                    break;
                default:
                    break;
            }
        }
        int idMesa = 0;
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (idMesa != 0)
                {
                    FrmTableSave frmTable = new FrmTableSave(idMesa,this);
                    frmTable.ShowDialog();
                    gridControl1.DataSource = null;
                    fillGridTable();
                     
                }
                else
                {
                    MessageBox.Show("Selecione uma mesa");
                }
            }
            catch (Exception rr)
            {
                MessageBox.Show(rr.Message);
            }
        }

        private void gridControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           
        }
    }
}
