using Appplication.Controller;
using Appplication.Statics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Main.Views.compras;
using UI.Main.Views.Configs;
using UI.Main.Views.Operacoes;
using UI.Main.Views.PDV;
using UI.Main.Views.Report;
using UI.Main.Views.Save;

namespace UI.Main.Views
{
    public partial class Main : Form
    {
        FrmLogin _frmLogin;
        bool appExit = true;
        public Main(FrmLogin frmLogin)
        {
            InitializeComponent();
            _frmLogin = frmLogin;
            if (new PrinterController().ListALL().Count>0)
            {
                Methods.PRINTER = new PrinterController().ListALL()[0].Print;
            }
            else
            {
                MessageBox.Show("Configure uma impressora no sistema");
                new FrmPrinter().ShowDialog();
            }
            Home home = new Home(this);
            home.MdiParent = this;
            home.Show();
            
        }
        FrmProdutoView frmProductView;
        public bool isFormInactive(Form formulario)
        {

            bool r = (formulario == null);
            if (!r)
            {
                if(!(r = formulario.IsDisposed))
                    this.ActivateMdiChild(formulario);
            }
            return r;
        }

        public void activeForm(Form formulario)
        {
            formulario.MdiParent = this;
            formulario.Show();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (isFormInactive(frmProductView))
            {
                activeForm(frmProductView = new FrmProdutoView());
            }

        }
        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (UserCurrent.getCurrentUser().FlagAdmin == true)
            {
                new FrmOutProduct().ShowDialog();
            }
            else
            {
                if (UserCurrent.getPermission().Stock)
                {
                    new FrmOutProduct().ShowDialog();
                }
                else
                {
                    MessageBox.Show("Não tem permissão para completar essa operação");
                }
            }
        }
             Armazens frm ;
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
       
            if (isFormInactive(frm))
            {
                frm = new Armazens();
                frm.MdiParent = this;
                frm.Show();
            }

        }
        FrmCategoy frmCategory;
        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (isFormInactive(frmCategory))
            {
                frmCategory = new FrmCategoy();
                frmCategory.MdiParent = this;
                frmCategory.Show();
            }
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PDV.PDV frm = new PDV.PDV();
            frm.Show();
        }
        FrmCostumersView frmCosutumer;
        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (isFormInactive(frmCosutumer))
            {
                activeForm(frmCosutumer = new FrmCostumersView());
            }


        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {
            
        }

        private void barButtonItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
             
        }

        private void barButtonItem20_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        FrmCustomerReport frmCR;
        private void barButtonItem21_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (isFormInactive(frmCR))
            {
                activeForm(frmCR = new FrmCustomerReport());
            }
            
        }
        FrmEntryRelatory frmEntryR;
        private void barButtonItem25_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (isFormInactive(frmEntryR))
            {
                activeForm(frmEntryR = new FrmEntryRelatory());
            }
            
        }
        FrmFornecedoresView frmFornecedor ;
        
        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (isFormInactive(frmFornecedor))
            {
                activeForm(frmFornecedor = new FrmFornecedoresView());
            }

        }
        FrmEntryProducts frmEntry;
        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (UserCurrent.getCurrentUser().FlagAdmin == true)
            {
                StorageController _storageController = new StorageController();
                ProviderController _providerController = new ProviderController();

                if (_providerController.ListALLAsNoTracking().Count > 0)
                {
                    if (_storageController.List().Count > 0)
                    {
                        if (isFormInactive(frmEntry))
                        {
                            frmEntry = new FrmEntryProducts();
                            frmEntry.MdiParent = this;
                            frmEntry.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nenhum armazem encontrado \nInsira um armazem primeiro");
                        new FrmStoreSave().ShowDialog();
                    }

                }
                else
                {
                    MessageBox.Show("Nenhum Fornecedor encontrado \nInsira um Fornecedor primeiro");
                    new FrmFornecedorSave(true).ShowDialog();
                }
            }
            else
            {
                if (UserCurrent.getPermission().Stock)
                {
                    StorageController _storageController = new StorageController();
                    ProviderController _providerController = new ProviderController();

                    if (_providerController.ListALLAsNoTracking().Count > 0)
                    {
                        if (_storageController.List().Count > 0)
                        {
                            if (isFormInactive(frmEntry))
                            {
                                frmEntry = new FrmEntryProducts();
                                frmEntry.MdiParent = this;
                                frmEntry.Show();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Nenhum armazem encontrado \nInsira um armazem primeiro");
                            new FrmStoreSave().ShowDialog();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Nenhum Fornecedor encontrado \nInsira um Fornecedor primeiro");
                        new FrmFornecedorSave(true).ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Não tem permissão para completar essa operação");
                }
            }

        }

        private void barButtonItem14_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (UserCurrent.getCurrentUser().FlagAdmin == true)
            {
                new FrmSerieSave().ShowDialog();
            }
            else
            {
                if (UserCurrent.getPermission().Stock)
                {
                    new FrmSerieSave().ShowDialog();
                }
                else
                {
                    MessageBox.Show("Não tem permissão para completar essa operação");
                }
            }
        }

        private void barButtonItem22_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ProviderController _provider = new ProviderController();
            FrmReportView frmViewReporter = new FrmReportView();
            frmViewReporter.PrintProvider(_provider.ListALL());
            frmViewReporter.ShowDialog();
        }

        private void timerSystemDate_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("dd-MM-yyyy hh:mm");
        }

        private void Main_Load(object sender, EventArgs e)
        {
            lblUserCurrent.Text = UserCurrent.getCurrentUser().Usuario;
           
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (appExit)
            {
                Application.Exit();
                UserCurrent.logOf();
            }
        }

        private void btnListInvoices_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Report.FormsViewGrid.FrmInvoicesViewGrid frmInvoicesView = new Report.FormsViewGrid.FrmInvoicesViewGrid();
            frmInvoicesView.MdiParent = this;
            frmInvoicesView.Show();
        }

        private void btnPOS_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (UserCurrent.getCurrentUser().FlagAdmin == true)
            {
                if (new SerieController().ListALL().Count > 0)
                {
                    FrmPosPdv frmPost = new FrmPosPdv(this);
                    frmPost.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Cadastre uma serie no sistema");
                }
            }
            else
            {
                if (UserCurrent.getPermission().Stock)
                {
                    if (new SerieController().ListALL().Count > 0)
                    {
                        FrmPosPdv frmPost = new FrmPosPdv(this);
                        frmPost.Show();
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("Cadastre uma serie no sistema");
                    }
                }
                else
                {
                    MessageBox.Show("Não tem permissão para completar essa operação");
                }
            }
        }

        private void btnUsers_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmUsersView frmUserView = new FrmUsersView();
            frmUserView.MdiParent = this;
            frmUserView.Show();
        }

        private void btnLogOf_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            appExit = false;
            if (MessageBox.Show("Deseja terminar Sessão..?", "Terminar Sessão", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                UserCurrent.logOf();
                _frmLogin.Show();
                Close();
            }
            else
                appExit = true;
        }

        private void btnCompany_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmCompany frmCompany = new FrmCompany();
            frmCompany.MdiParent = this;
            frmCompany.Show();
        }

        private void btnCurrentAccount_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmCurrentAccountView frmCA = new FrmCurrentAccountView();
            frmCA.MdiParent = this;
            frmCA.Show();
        }

        private void btnBank_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmBankView frmB = new FrmBankView();
            frmB.MdiParent = this;
            frmB.Show();
        }

        private void btnContasConfig_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FmrCurrentAccountConfigView frmCurrentAccountConfig = new FmrCurrentAccountConfigView();
            frmCurrentAccountConfig.MdiParent = this;
            frmCurrentAccountConfig.Show();
        }

        private void btnSaftExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new FrmSaftExport().ShowDialog();
        }

        private void barButtonItem32_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmCadTaxa frmCadTaxa = new FrmCadTaxa();
            frmCadTaxa.MdiParent = this;
            frmCadTaxa.Show();
        }
        FrmInvoicesForCreditNote frmInvoiceCredite;
        private void btnNDC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (UserCurrent.getCurrentUser().FlagAdmin == true)
            {
                if (isFormInactive(frmInvoiceCredite))
                {
                    activeForm(frmInvoiceCredite = new FrmInvoicesForCreditNote());
                }
            }
            else
            {
                if (UserCurrent.getPermission().Stock)
                {
                    if (isFormInactive(frmInvoiceCredite))
                    {
                        activeForm(frmInvoiceCredite = new FrmInvoicesForCreditNote());
                    }
                }
                else
                {
                    MessageBox.Show("Não tem permissão para completar essa operação");
                }
            }


        }
        FrmOutProdsView frmOutView;
        private void Sa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (isFormInactive(frmOutView))
            {
                activeForm(frmOutView = new FrmOutProdsView());
            }
        }

        private void barButtonItem33_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Report.FormsViewGrid.FrmInvoicesViewGrid frmInvoicesView = new Report.FormsViewGrid.FrmInvoicesViewGrid();
            frmInvoicesView.MdiParent = this;
            frmInvoicesView.Show();
        }

        private void barButtonItem40_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmTable frm = new FrmTable();
            frm.Show();
        }

        private void barButtonItem42_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (UserCurrent.getCurrentUser().FlagAdmin == true)
            {
                if (new SerieController().ListALL().Count > 0)
                {
                    if (TurnoCurrent.getTurnoCurrent()==null)
                    {
                        MessageBox.Show("Abra o Caixa Primeiro");
                    }
                    else
                    {
                         FrmPosRestaurant frmPos = new FrmPosRestaurant(this);
                            frmPos.Show();
                            Hide();
                     }
                  
                    
                }
                else
                {
                    MessageBox.Show("Cadastre uma serie no sistema");
                }
            }
            else
            {
                if (UserCurrent.getPermission().Venda)
                {
                    if (new SerieController().ListALL().Count > 0)
                    {
                        if (new TableController().ListALL().Count > 0)
                        {
                            FrmPosRestaurant frmPos = new FrmPosRestaurant(this);
                            frmPos.Show();
                            Hide();
                        }
                        else
                        {
                            MessageBox.Show("Cadastre pelo menos uma(1) mesa");
                        }


                    }
                    else
                    {
                        MessageBox.Show("Cadastre uma serie no sistema");
                    }
                }
                else
                {
                    MessageBox.Show("Não tem permissão para completar essa operação");
                }
            }
        }

        private void barButtonItem43_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmReservesView frm = new FrmReservesView();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem45_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmReserveRoom frm = new FrmReserveRoom();
            frm.ShowDialog();
        }

        private void barButtonItem44_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmRoomView frm = new FrmRoomView();
          
            frm.ShowDialog();
        }

        private void barButtonItem47_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmFamilyRest frm = new FrmFamilyRest();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barHeaderItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem28_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        FrmInvoiceCompra frmIvConmpra;
        private void btnFaturapCompra_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (isFormInactive(frmIvConmpra))
                activeForm(frmIvConmpra = new FrmInvoiceCompra());
        }

        private void barButtonItem48_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new FrmPermissionsView().ShowDialog();
        }

        private void barButtonItem54_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmCaixa frmC = new FrmCaixa();
            frmC.MdiParent = this;
            frmC.Show();
        }

        private void barButtonItem55_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem24_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }

        private void barButtonItem31_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem56_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            FrmPrinter frm = new FrmPrinter();
            frm.ShowDialog();
        }
        public void openInvoiceForm(string type, FrmInvoice frm)
        {
            if (UserCurrent.getCurrentUser().FlagAdmin == true)
            {
                if (isFormInactive(frm))
                {
                    activeForm(frm = new FrmInvoice(type));
                }
            }
            else
            {
                if (UserCurrent.getPermission().Venda)
                {
                    if (isFormInactive(frm))
                    {
                        activeForm(frm = new FrmInvoice(type));
                    }
                }
                else
                {
                    MessageBox.Show("Não tem permissão para completar essa operação");
                }
            }
        }

        FrmInvoice frmFt;
        FrmInvoice frmRc;
        FrmInvoice frmFr;
        FrmInvoice frmPP;
        private void barButtonItem61_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (isFormInactive(frmFt))
                activeForm(frmFt = new FrmInvoice("FT"));
            //openInvoiceForm("FT", frmFt);
        }

        private void barButtonItem59_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           // frmRc = new FrmInvoice();
            if (isFormInactive(frmRc))
                activeForm(frmRc = new FrmInvoice("RC"));
          //  openInvoiceForm("RC", frmRc);
        }

        private void barButtonItem60_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (isFormInactive(frmPP))
                activeForm(frmPP = new FrmInvoice("PP"));
            //openInvoiceForm("PP", frmPP);
        }

        private void btnOpercaoFatura_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (isFormInactive(frmFr))
                activeForm(frmFr = new FrmInvoice("FR"));
            //openInvoiceForm("FR", frmFr);
        }

    }
}
