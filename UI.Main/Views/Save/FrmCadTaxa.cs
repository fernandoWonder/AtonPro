using Appplication.Controller;
using DevExpress.XtraEditors;
using Domain.Domain.Entities.ProductAssistant;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Main.Views.Save
{
    
    public partial class FrmCadTaxa : Form
    {
        TaxTypeController _tiposTaxa = new TaxTypeController();
        List<TaxReasonExemption> motivos;

        TaxCodeController _taxController = new TaxCodeController();
        TaxReasonExemptionController _taxISEController = new TaxReasonExemptionController();

        List<TaxCode> taxas;

        public FrmCadTaxa()
        {
            InitializeComponent();
        }

        private void FrmCadTaxa_Load(object sender, EventArgs e)
        {
            _tiposTaxa.ListALL().ForEach(c => cmbTaxType.Properties.Items.Add(c.Tipo));
            cmbTaxType.SelectedIndex = 0;
        }

        public void updateGrid()
        {
            int idTipo = cmbTaxType.SelectedIndex + 1;
            if (idTipo == 1)
            {
                taxas = _tiposTaxa.getOne(1).Taxas.ToList();
                motivos = null;
                txtTax.Enabled = true;
            }
            else
            {
                motivos = _tiposTaxa.getOne(2).MotivosIsencao.ToList();
                taxas = null;
                txtTax.Enabled = false;
            }

            if (idTipo == 1)
            {
                gridTaxs.Columns.ColumnByName("ClCodigoISE").Visible = false;
                gridTaxs.Columns.ColumnByName("ClMotivo").Visible = false;
                gridTaxs.Columns.ColumnByName("ClTaxaZero").Visible = false;

                gridTaxs.Columns.ColumnByName("ClDescricao").Visible = true;
                gridTaxs.Columns.ColumnByName("ClTaxCode").Visible = true;
                gridTaxs.Columns.ColumnByName("ClTaxaNor").Visible = true;

                lblDesc.Text = "Descricao";

                gdvControlTaxs.DataSource = taxas;
                gdvControlTaxs.RefreshDataSource();
            }
            else if(idTipo == 2)
            {
                gridTaxs.Columns.ColumnByName("ClCodigoISE").Visible = true;
                gridTaxs.Columns.ColumnByName("ClMotivo").Visible = true;
                gridTaxs.Columns.ColumnByName("ClTaxaZero").Visible = true;

                gridTaxs.Columns.ColumnByName("ClDescricao").Visible = false;
                gridTaxs.Columns.ColumnByName("ClTaxCode").Visible = false;
                gridTaxs.Columns.ColumnByName("ClTaxaNor").Visible = false;

                lblDesc.Text = "Motivo Isencao";

                gdvControlTaxs.DataSource = motivos;
                gdvControlTaxs.RefreshDataSource();
            }
        }

        private void cmbTaxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateGrid();
        }

        public void salvar()
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if(txtCode.Text != string.Empty && txtDescricao.Text != string.Empty)
            {
                if(cmbTaxType.SelectedIndex == 0)
                {
                    if(decimal.Parse(txtTax.Text) >= 1)
                    {
                        TaxCodeController _taxController = new TaxCodeController();
                        TaxCode taxcode = new TaxCode()
                        {
                            Code = txtCode.Text.Trim(),
                            Taxa = decimal.Parse(txtTax.Text),
                            Descricao = txtDescricao.Text.Trim(),
                            flagPrincipal = false,
                        };

                        bool taxaExiste = false;
                        foreach (var item in _taxController.ListALL())
                        {
                            taxaExiste = item.Taxa == taxcode.Taxa;
                            if (taxaExiste)
                                break;
                        }

                        if (taxaExiste)
                        {
                            MessageBox.Show("Já Exixte a percentagem de taxa de (" + taxcode.Taxa + "%) !\nDigite uma nova taxa para cadastrar..!");
                        }
                        else
                        {
                            _taxController.insert(taxcode);
                            _tiposTaxa = new TaxTypeController();
                            updateGrid();
                        }

                    }else
                        MessageBox.Show("A taxa não pode ser zero...");
                }
                else
                {
                    TaxReasonExemptionController _taxController = new TaxReasonExemptionController();
                    TaxReasonExemption taxReason = new TaxReasonExemption()
                    {
                        Id = txtCode.Text.Trim(),
                        MencaoFatura = txtDescricao.Text.Trim(),
                        flagPrincipal = false,
                    };

                    bool codigoExiste = false;
                    
                    foreach (var item in _taxController.ListALL())
                    {
                        codigoExiste = item.Id.Equals(taxReason.Id);
                        if (codigoExiste)
                            break;
                    }

                    if (codigoExiste)
                    {
                        MessageBox.Show("Já Exixte este código de isenta..!");
                    }
                    else
                    {
                        _taxController.insert(taxReason);
                        _tiposTaxa = new TaxTypeController();
                        updateGrid();
                    }
                }
            }
            else
            {
                MessageBox.Show("Há campos vazio..!");
            }
        }

        private void gridTaxs_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            int rowLine = e.RowHandle;

            decimal taxa = 0;
            if (e.Column.Name == "ClTaxaNor")
            {
                taxa = decimal.Parse(e.Value.ToString());
            }

            if (e.Value.ToString() == string.Empty)
                updateGrid();
            else
            {
                if (cmbTaxType.SelectedIndex == 0)
                {
                    TaxCode tax = taxas[rowLine];
                    if (tax.flagPrincipal)
                    {
                        MessageBox.Show("Esta taxa não pode ser Alterada..!");
                        updateGrid();
                    }
                    else
                    {
                        if(taxa > 0)
                        {
                            //_taxController.update(tax);
                            _tiposTaxa.update(_tiposTaxa.getOne(1));

                        }else
                            MessageBox.Show("O valor da taxa não pode ser 0..!");

                    }
                }
                else
                {
                    TaxReasonExemption ISE = motivos[rowLine];
                    if (ISE.flagPrincipal)
                    {
                        if (e.Column.Name == "CLCodigoISE")
                            MessageBox.Show("Não pode alterar o codigo das Isentas principais.!");
                        else
                        {
                           // _taxISEController.update(ISE);
                            _tiposTaxa.update(_tiposTaxa.getOne(2));
                        }

                    }
                    else
                    {
                        _tiposTaxa.update(_tiposTaxa.getOne(2));
                    }

                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int rowLine = gridTaxs.GetSelectedRows()[0];

            if (cmbTaxType.SelectedIndex == 0)
            {
                TaxCode tax = taxas[rowLine];
                if (tax.flagPrincipal)
                {
                    MessageBox.Show("Esta taxa não pode ser eliminada..!");
                }
                else
                {
                    _taxController.deleteFoId(tax.Id);
                    updateGrid();
                }
            }
            else
            {
                TaxReasonExemption ISE = motivos[rowLine];

                if (ISE.flagPrincipal)
                {
                    MessageBox.Show("Esta taxa não pode ser eliminada..!");
                }
                else
                {
                    _taxISEController.deleteFoId(ISE.Id);
                    updateGrid();
                }
            }
        }
    }
}
