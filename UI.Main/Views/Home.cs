using Appplication.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Main.Views.Operacoes;
using UI.Main.Views.PDV;
using UI.Main.Views.Save;

namespace UI.Main.Views
{
    public partial class Home: Form
    {
        Main main;
        public Home(Main main)
        {
            
            InitializeComponent();
            this.main = main;

            lblDia.Text = DateTime.Now.Day.ToString();
            lblMes.Text = DateTime.Now.Month.ToString().Replace("10", "Outubro").Replace("11", "Novembro").Replace("12", "Dezembro").Replace("1", "1").Replace("2", "Fevereiro").Replace("3", "Março").Replace("4", "Abril").Replace("5", "Maio").Replace("6", "Junho").Replace("7", "Julho").Replace("8", "Agosto").Replace("9", "Setembro");
            lblAno.Text = DateTime.Now.Year.ToString();
            lblDaySemana.Text = DateTime.Now.DayOfWeek.ToString().Replace("Mondey", "Segunda").Replace("Tuesday", "Terça-Feira").Replace("Wednesday", "Quarta-Feira").Replace("Sunday", "Domingo").Replace("Saturday", "Sabado").Replace("Friday", "Sexta-Feira").Replace("Thursday", "Quinta-Feira");

        }

        private void bunifuCards1_MouseClick(object sender, MouseEventArgs e)
        {
            FrmProdutoView frm = new FrmProdutoView();
            frm.MdiParent = main;
            frm.Show();
        }

        private void bunifuCards2_MouseClick(object sender, MouseEventArgs e)
        {
            if (new SerieController().ListALL().Count > 0)
            { PDV.FrmPosPdv  frm = new PDV.FrmPosPdv((Main)this.MdiParent);
                frm.Show();
                MdiParent.Hide();
            }
            else
            {
                MessageBox.Show("Cadastre uma serie no sistema");
            }
           
        }

        private void bunifuCards3_MouseClick(object sender, MouseEventArgs e)
        {
            FrmInvoice frm = new FrmInvoice();
            frm.MdiParent = main;
            frm.Show(); 
        }

        private void bunifuCards4_MouseClick(object sender, MouseEventArgs e)
        {
            FrmEntryProducts frm = new FrmEntryProducts();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void bunifuCards3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCards4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
