using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Threading;
using System.Web.Script.Serialization;
using System.IO;
using System.Configuration;
using Appplication.Statics;

namespace UI.Main.Views
{
    public partial class Loading : DevExpress.XtraEditors.XtraForm
    {
        public Loading()
        {
            InitializeComponent();
            labelCopyright.Text = "Copyright © 2020-" + DateTime.Now.Year.ToString();
        }

        

        private void Loading_Load(object sender, EventArgs e)
        {
             
            Thread t = new Thread(load);
            t.Start();

           
        }
        int cont = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (cont > 1)
            {
                new FrmLogin().Show();
                timer1.Enabled = false;
                Hide();
            }
            cont++;
        }

        bool error = false;
        bool finished = false;
        public void load()
        {
            try
            {
                 
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
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var conn = (ConnectionStringsSection)config.GetSection("connectionStrings");
                conn.ConnectionStrings["ConectionSellerPro"].ConnectionString = "Data Source=" + server + ";Initial Catalog=DBSellerPro;Persist Security Info=True;User ID=sa;Password=sa";
                config.Save();
                ConfigurationManager.RefreshSection("connectionStrings");
                SystemInfoCurrent.initialize();
                 
            }
            catch (System.ObjectDisposedException er)
            {
                MessageBox.Show("erro na conexão com o banco de dados,Feche e abre aplicação");
                error = true;
               
            }catch(System.Data.SqlClient.SqlException rr)
            {
                MessageBox.Show("erro");
                error = true;
            }
            catch (Exception r)
            {
                MessageBox.Show("Erro: Entre em contacto com o suporte - " + r.Message);
                error = true;
            }
            finally
            {
                finished = true;
            }
        }

  

        private void timer2_Tick(object sender, EventArgs e)
        {
             if(finished)
            {
                 if (!error)
                {
                    timer2.Enabled = false;
                    timer1.Enabled = true;
                }
                else
                { 
                    Close();
                } 
            }
           
        }
 
    }
}