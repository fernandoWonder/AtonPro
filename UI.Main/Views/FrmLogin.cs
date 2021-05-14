using Appplication.Controller;
using Appplication.Statics;
using Domain.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using UI.Main.Views.Save;

namespace UI.Main.Views
{
    public partial class FrmLogin : DevExpress.XtraEditors.XtraForm
    {
        UserController usController = new UserController();
        public FrmLogin()
        {
            InitializeComponent();
            usController.ListAllAsNotracking();
        }

        bool hint = true;
        bool hint2 = true;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (hint)
            {
                txtUser.Text = txtUser.Text.Substring(0, 1);
                txtUser.ForeColor = Color.Black;
                txtUser.Select(1, 1);
                hint = false;
            }
            else if (txtUser.Text == "")
            {
                txtUser.ForeColor = Color.Gray;
                txtUser.Text = "Usuário";
                hint = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (hint2)
            {
                txtPassword.Text = txtPassword.Text.Substring(0, 1);
                txtPassword.ForeColor = Color.Black;
                txtPassword.Select(1, 1);
                hint2 = false;
                txtPassword.UseSystemPasswordChar = true;
            }
            else if (txtPassword.Text == "")
            {
                txtPassword.ForeColor = Color.Gray;
                txtPassword.Text = "Senha";
                hint2 = true;
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        // Hint Congig
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // char c = Convert.ToChar(e.KeyValue);
            char c = e.KeyChar;
            if (!(char.IsLetter(c) || char.IsDigit(c)) && hint)
                e.Handled = true;

        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Left || e.KeyCode == Keys.Right ||
                e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Delete) && hint)
                e.Handled = true;
            if (e.KeyCode == Keys.Enter)
            {
                ProcessTabKey(true);
            }
        }

        private void textBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (hint)
                (sender as TextBox).Select(0, 0);
        }

        private void textBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (hint)
                (sender as TextBox).Select(0, 0);
        }

        // Hint lo
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // char c = Convert.ToChar(e.KeyValue);
            char c = e.KeyChar;
            if (!(char.IsLetter(c) || char.IsDigit(c)) && hint2)
                e.Handled = true;

        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Left || e.KeyCode == Keys.Right ||
                e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Delete) && hint2)
                e.Handled = true;
            if (e.KeyCode == Keys.Enter)
                bunifuThinButton24_Click(sender, e);
        }

        private void textBox2_MouseDown(object sender, MouseEventArgs e)
        {
            if (hint2)
                (sender as TextBox).Select(0, 0);
        }

        private void textBox2_MouseMove(object sender, MouseEventArgs e)
        {
            if (hint2)
                (sender as TextBox).Select(0, 0);
        }

        // Propriedade do focus
        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (hint2)
                txtPassword.Select(0, 0);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (hint)
                txtUser.Select(0, 0);
        }

        private void FrmLogin_Shown(object sender, EventArgs e)
        {
            txtUser.Select(0, 0);
        }

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            if (txtUser.Text.Trim() != "" && !hint)
            {
                if (txtPassword.Text.Trim() != "" && !hint2)
                {
                    System.Configuration.Configuration c = System.Configuration.ConfigurationManager.OpenExeConfiguration(System.Configuration.ConfigurationUserLevel.None);
                    User us;
                    try
                    {
                        if (UserCurrent.getCurrentUser() != null)
                            usController = new UserController();

                        us = usController.Logar(txtUser.Text, txtPassword.Text);
                        if (us != null)
                        {
                            SystemInfoCurrent.initialize();

                            UserCurrent.initialize(us);
                            if (us.FlagFirstLogin)
                                new FrmUserFirstLogin(us, this).Show();
                            else
                            {
                                new Main(this).Show();
                            }
                                txtUser.Focus();
                            txtUser.Select(0, 0);
                            Hide();
                            txtPassword.Clear();
                            txtUser.Clear();
                        }
                        else
                        {
                            MessageBox.Show("usuario ou senha incorrestos,\n TRY AGAIN");
                            txtPassword.Clear();
                            txtUser.Clear();
                            txtUser.Focus();
                        }
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message);
                        us = null;
                    }
                }
                else
                {
                    MessageBox.Show("Insira a senha");
                    txtPassword.Focus();
                }
            }
            else
            {
                MessageBox.Show("Insira o usuario");
            }

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
