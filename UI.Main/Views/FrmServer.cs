using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Appplication.Statics;
using System.IO;

namespace UI.Main.Views
{
    public partial class FrmServer : Form
    {
        public FrmServer()
        {
            InitializeComponent();


            //////////
         /*   string path = Application.StartupPath + @"/config";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
                StreamWriter str = new StreamWriter(path + @"/config.json", false, Encoding.Default);
                str.WriteLine("{ ");
                str.WriteLine(" \"config\" : { ");
                str.WriteLine(" \"server\" : \"SERVER\"");
                str.WriteLine("}");
                str.WriteLine("}");
                str.Dispose();
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Trim() != "")
                {
                    var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    var conn = (ConnectionStringsSection)config.GetSection("connectionStrings");
                    conn.ConnectionStrings["ConectionSellerPro"].ConnectionString = "Data Source=" + textBox1.Text + ";Initial Catalog=DBSellerPro;Persist Security Info=True;User ID=sa;Password=sa";
                    config.Save();
                    ConfigurationManager.RefreshSection("connectionStrings");

                    SystemInfoCurrent.initialize();
                    new FrmLogin().Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Prencha o campo");

                }

            }
            catch (Exception r)
            {
                MessageBox.Show("error: " + r.Message);
                
            }
        }
    }
}
