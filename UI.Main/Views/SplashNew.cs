using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Appplication.Statics;
using System.Threading;
using System.Web.Script.Serialization;
using System.Net;

namespace UI.Main.Views
{
    public partial class SplashNew : Form
    {
        int cont = 0;
        public SplashNew()
        {
            InitializeComponent();

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
                }
                */
                 string server = Environment.MachineName;
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var conn = (ConnectionStringsSection)config.GetSection("connectionStrings");
                conn.ConnectionStrings["ConectionSellerPro"].ConnectionString = "Data Source=" + server + ";Initial Catalog=DBSellerPro;Persist Security Info=True;User ID=sa;Password=sa";
                config.Save();
                ConfigurationManager.RefreshSection("connectionStrings");
                SystemInfoCurrent.initialize();
             ///   FrmLogin frLogin = new FrmLogin();
                // frLogin.Show();

                this.Hide();
                
            }
            catch (System.ObjectDisposedException error)
            {
                Visible = false;

                MessageBox.Show("erro na conexão com o banco de dados, verifica se o servidor está correcto");

            }
            catch (Exception r)
            {
                Visible = false;

                MessageBox.Show("Erro: Entre em contacto com o suporte - " + r.Message);
            }
            finally
            {

            }


            labelCopyright.Text = "Copyright © 2020-" + DateTime.Now.Year.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        { 
            if(cont > 2)
            {
                /*
                new FrmLogin().Show();
                timer1.Enabled = false;
                this.Hide();*/
            }
            cont++; 
        }
      

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SplashNew_Leave(object sender, EventArgs e)
        {

        }
        bool finish = false;
         private void SplashNew_Load(object sender, EventArgs e)
        {
             
          
        }
    }
}
