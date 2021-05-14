using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Main.Views.PDV
{
    public partial class FrmPdv : Form
    {
        public FrmPdv()
        {/*
            InitializeComponent();
            data = fillDataTable(getProdutos());
            gridControl1.DataSource = data;
            tabPane1.SelectedPageIndex = 0;  */    
        }
        DataTable data = new DataTable();
        private void tabNavigationPage1_Paint(object sender, PaintEventArgs e)
        {

           
        }

        public class Produto{
            public int cod { get; set; }
            public string descricao { get; set; }
            public int quant { get; set; }
            public double preco { get; set; }

            public Produto()
            {

            }
        }

        public List<Produto> getProdutos()
        {
            List<Produto> produtos = new List<Produto>();
            Produto produt = new Produto
            {
                cod = 1,
                descricao = "Coca Cola",
                quant = 2,
                preco = 1000

            };
            Produto produt2 = new Produto
            {
                cod = 2,
                descricao = "Vinho Jp",
                quant = 3,
                preco = 2000

            };
            Produto produt3 = new Produto
            {
                cod = 3,
                descricao = "Blue Guarana",
                quant = 4,
                preco = 4000

            };
            produtos.Add(produt);
            produtos.Add(produt2);
            produtos.Add(produt3);
            return produtos;

        }

        public DataTable fillDataTable(List<Produto> produtos)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("cod");
            dataTable.Columns.Add("descricao");
            dataTable.Columns.Add("Quant");
            dataTable.Columns.Add("Preco");
            foreach (Produto product in produtos)
            {
                dataTable.Rows.Add(product.cod,product.descricao,product.quant,product.preco);
            }         

            return dataTable;
        }

        private void FrmPdv_Load(object sender, EventArgs e)
        {

        }
    }
}
