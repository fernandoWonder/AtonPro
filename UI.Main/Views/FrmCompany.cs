using Appplication.Controller;
using Appplication.Statics;
using Domain.Domain.Entities;
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

namespace UI.Main.Views
{
    public partial class FrmCompany : DevExpress.XtraEditors.XtraForm
    {
        CompanyTypeController _companyTypeController = new CompanyTypeController();
        CompanyController _companyController;
        CityController _cityController = new CityController();
        InvoiceController _invoices = new InvoiceController();

        Company cp = SystemInfoCurrent.getCurrentCompany();
        OpenFileDialog urlLogo;
        Image imgLogo;
        string rootPath = Application.StartupPath;

        public FrmCompany()
        {
            InitializeComponent();

            toCmbs();
            
            txtAddress.Text = cp.Endereco;
            txtEmail.Text = cp.Email;
            txtNome.Text = cp.Empresa;
            txtFax1.Text = cp.Tel;

            TxtNIF.Text = cp.Nif;

            txtSite.Text = cp.UrlSite;
            txtFax1.Text = cp.Fax;
            txtFax2.Text = cp.Fax2;
            txtTel.Text = cp.Tel1;
            txtComercialNumber.Text = cp.CompanyID;
            txtContaBanco1.Text = cp.ContaBanco1;
            txtContaBanco2.Text = cp.ContaBanco2;

            if (_invoices.ListALLAsNoTracking().Count > 0)
            {
                TxtNIF.Enabled = false;
            }
            

            if (File.Exists(rootPath + cp.UrlLogo))
            {
                imgLogo = Image.FromFile(rootPath + cp.UrlLogo);
                pictureBox1.Image = imgLogo;
            }

        }

        private void btnSaveCompany_Click(object sender, EventArgs e)
        {
            
        }

        public bool haveEmptyField()
        {
            if (txtAddress.Text.Trim() != "" && txtEmail.Text.Trim() != "" && txtNome.Text.Trim() != "" 
                && TxtNIF.Text.Trim() != "" && txtTel.Text.Trim() != "")
                return false;
            return true;
        }

        public void toCmbs()
        {
            cmbEmpresa.Properties.Items.Clear();
            cmbCity.Properties.Items.Clear();

            _cityController.ListALL().ForEach(c => cmbCity.Properties.Items.Add(c.Cidade));
            _companyTypeController.ListALL().ForEach(c => cmbEmpresa.Properties.Items.Add(c.Tipo));
            cmbEmpresa.SelectedItem = _companyTypeController.getOne(cp.CompanyTypeId).Tipo;

            if (cmbCity.Properties.Items.Count > 0)
                cmbCity.SelectedIndex = 0;
        }

        public void save()
        {
            _companyController = new CompanyController();
            if (!haveEmptyField())
            {
                Company company = new Company()
                {
                    Id = cp.Id,
                    Empresa = txtNome.Text,
                    Nif = TxtNIF.Text,
                    CompanyID = txtComercialNumber.Text == string.Empty ? "NA" : txtComercialNumber.Text,
                    Email = txtEmail.Text,
                    Endereco = txtAddress.Text,
                    Tel = txtTel.Text,
                    Tel1 = txtTel2.Text,
                    Fax = txtFax1.Text,
                    Fax2 = txtFax2.Text,
                    UrlSite = txtSite.Text,
                    ContaBanco1 = txtContaBanco1.Text,
                    ContaBanco2 = txtContaBanco2.Text,

                    CidadeId = _cityController.ListALL()[cmbCity.SelectedIndex].Id,
                    CompanyTypeId = _companyTypeController.ListALL()[cmbEmpresa.SelectedIndex].Id,
                    UrlLogo = @"\Logo\logo.png",
                };

                _companyController.update(company);
                SystemInfoCurrent.setCurrentCompany(company);
                Focus();
                panel1.Enabled = false;
                Focus();
            }
            else
                MessageBox.Show("Preencha todos os campos obrigatórios");
        }

        bool keyControl = false;
        private void FrmCompany_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Control || e.KeyCode == Keys.ControlKey)
            {
                keyControl = true;
            }
            if(e.KeyCode == Keys.A && keyControl)
            {
                panel1.Enabled = true;
            }
        }

        private void FrmCompany_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Control || e.KeyCode == Keys.ControlKey)
                keyControl = false;
        }

        private void btnAddLogo_Click(object sender, EventArgs e)
        {
            using(urlLogo = new OpenFileDialog())
            {
                if(urlLogo.ShowDialog() == DialogResult.OK)
                {
                    imgLogo = Image.FromFile(urlLogo.FileName);
                    pictureBox1.Image = imgLogo;
                }
            }
        }

        private void salvaLogo()
        {
            try
            {
                if(urlLogo != null)
                {
                    if (!Directory.Exists(rootPath + @"\Logo"))
                        Directory.CreateDirectory(rootPath + @"\Logo");
                    if(urlLogo.FileName != string.Empty)
                    {
                        File.Delete(rootPath + @"\Logo\logo.png");
                        File.Copy(urlLogo.FileName, rootPath + @"\Logo\logo.png");
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void txtTel_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            salvaLogo();
            save();
        }
    }
}
