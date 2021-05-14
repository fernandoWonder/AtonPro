using Appplication.Statics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace UI.Main.Views
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }
        int cont = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (cont>4)
            {
               // timer1.Enabled = false;
                //new FrmLogin().Show();
                Hide();
            }
            cont++;
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            try
            {
                /*
                string path = Application.StartupPath + @"/config.json";
                var json = new JavaScriptSerializer();
                StreamReader reader = new StreamReader(path);
                string jsons = "";
                string server = "";
                while (!reader.EndOfStream)
                {
                    jsons += reader.ReadLine().ToString();

                }
                dynamic datas = json.DeserializeObject(jsons);
                reader.Dispose();

                foreach (KeyValuePair<string, object> item in datas)
                {
                    server = item.Value as string;
                }*//*
              */
                string server = Environment.MachineName;
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var conn = (ConnectionStringsSection)config.GetSection("connectionStrings");
                conn.ConnectionStrings["ConectionSellerPro"].ConnectionString = "Data Source=" + server + ";Initial Catalog=DBSellerPro;Persist Security Info=True;User ID=sa;Password=sa";
                config.Save();
                ConfigurationManager.RefreshSection("connectionStrings");
                SystemInfoCurrent.initialize();
                new FrmLogin().Show();
                Hide();
                //this.WindowState = FormWindowState.Minimized;
            
            }
            catch (System.ObjectDisposedException error)
            {
                Close();

                MessageBox.Show("erro na conexão com o banco de dados, verifica se o servidor está correcto");

            }
            catch (Exception r)
            {
                Close();

                MessageBox.Show("Erro: Entre em contacto com o suporte - " + r.Message);
            }
            finally
            {

            }


            labelCopyright.Text = "Copyright © 2020-" + DateTime.Now.Year.ToString();
        }
    }
}
