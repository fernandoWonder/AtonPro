namespace UI.Main.Views.Operacoes
{
    partial class FrmInvoicesForCreditNote
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCorrigir = new DevExpress.XtraEditors.SimpleButton();
            this.txtIdInvoice = new DevExpress.XtraEditors.TextEdit();
            this.gdvControlInvoices = new DevExpress.XtraGrid.GridControl();
            this.gridViewFaturasCliente = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ClId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Fatura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Total = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ClCorrigido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.searchLUpCustomer = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cmbCorrigido = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdInvoice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvControlInvoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFaturasCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLUpCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCorrigido.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCorrigir
            // 
            this.btnCorrigir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCorrigir.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.btnCorrigir.Appearance.Options.UseFont = true;
            this.btnCorrigir.Appearance.Options.UseTextOptions = true;
            this.btnCorrigir.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnCorrigir.Location = new System.Drawing.Point(800, 14);
            this.btnCorrigir.Name = "btnCorrigir";
            this.btnCorrigir.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnCorrigir.Size = new System.Drawing.Size(132, 23);
            this.btnCorrigir.TabIndex = 3;
            this.btnCorrigir.Text = "Corrigir";
            this.btnCorrigir.Click += new System.EventHandler(this.btnCorrigir_Click);
            // 
            // txtIdInvoice
            // 
            this.txtIdInvoice.Enabled = false;
            this.txtIdInvoice.Location = new System.Drawing.Point(12, 11);
            this.txtIdInvoice.Name = "txtIdInvoice";
            this.txtIdInvoice.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 7F);
            this.txtIdInvoice.Properties.Appearance.Options.UseFont = true;
            this.txtIdInvoice.Size = new System.Drawing.Size(35, 18);
            this.txtIdInvoice.TabIndex = 4;
            this.txtIdInvoice.Visible = false;
            // 
            // gdvControlInvoices
            // 
            this.gdvControlInvoices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gdvControlInvoices.Location = new System.Drawing.Point(12, 57);
            this.gdvControlInvoices.MainView = this.gridViewFaturasCliente;
            this.gdvControlInvoices.Name = "gdvControlInvoices";
            this.gdvControlInvoices.Size = new System.Drawing.Size(920, 512);
            this.gdvControlInvoices.TabIndex = 5;
            this.gdvControlInvoices.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewFaturasCliente});
            // 
            // gridViewFaturasCliente
            // 
            this.gridViewFaturasCliente.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ClId,
            this.Codigo,
            this.Fatura,
            this.Total,
            this.ClCorrigido});
            this.gridViewFaturasCliente.CustomizationFormBounds = new System.Drawing.Rectangle(574, 457, 252, 106);
            this.gridViewFaturasCliente.GridControl = this.gdvControlInvoices;
            this.gridViewFaturasCliente.Name = "gridViewFaturasCliente";
            this.gridViewFaturasCliente.OptionsBehavior.Editable = false;
            this.gridViewFaturasCliente.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewFaturasCliente.OptionsView.ShowGroupPanel = false;
            this.gridViewFaturasCliente.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewFaturasCliente_FocusedRowChanged);
            // 
            // ClId
            // 
            this.ClId.Caption = "Id";
            this.ClId.FieldName = "Id";
            this.ClId.Name = "ClId";
            this.ClId.OptionsColumn.AllowEdit = false;
            this.ClId.Visible = true;
            this.ClId.VisibleIndex = 0;
            this.ClId.Width = 33;
            // 
            // Codigo
            // 
            this.Codigo.Caption = "Codigo";
            this.Codigo.FieldName = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.OptionsColumn.AllowEdit = false;
            this.Codigo.Visible = true;
            this.Codigo.VisibleIndex = 1;
            this.Codigo.Width = 51;
            // 
            // Fatura
            // 
            this.Fatura.Caption = "Fatura";
            this.Fatura.FieldName = "InvoiceNo";
            this.Fatura.Name = "Fatura";
            this.Fatura.OptionsColumn.AllowEdit = false;
            this.Fatura.Visible = true;
            this.Fatura.VisibleIndex = 2;
            this.Fatura.Width = 172;
            // 
            // Total
            // 
            this.Total.Caption = "Total";
            this.Total.DisplayFormat.FormatString = "F3";
            this.Total.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Total.FieldName = "TotalGeral";
            this.Total.Name = "Total";
            this.Total.OptionsColumn.AllowEdit = false;
            this.Total.Visible = true;
            this.Total.VisibleIndex = 3;
            this.Total.Width = 71;
            // 
            // ClCorrigido
            // 
            this.ClCorrigido.Caption = "Modificada";
            this.ClCorrigido.DisplayFormat.FormatString = "F3";
            this.ClCorrigido.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.ClCorrigido.FieldName = "Corrigido";
            this.ClCorrigido.Name = "ClCorrigido";
            this.ClCorrigido.OptionsColumn.AllowEdit = false;
            this.ClCorrigido.Visible = true;
            this.ClCorrigido.VisibleIndex = 4;
            this.ClCorrigido.Width = 74;
            // 
            // searchLUpCustomer
            // 
            this.searchLUpCustomer.EditValue = "Cli";
            this.searchLUpCustomer.EnterMoveNextControl = true;
            this.searchLUpCustomer.Location = new System.Drawing.Point(191, 11);
            this.searchLUpCustomer.Name = "searchLUpCustomer";
            this.searchLUpCustomer.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.searchLUpCustomer.Properties.Appearance.Options.UseFont = true;
            this.searchLUpCustomer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search)});
            this.searchLUpCustomer.Properties.NullText = "Cliente";
            this.searchLUpCustomer.Properties.PopupView = this.gridView2;
            this.searchLUpCustomer.Size = new System.Drawing.Size(399, 26);
            this.searchLUpCustomer.TabIndex = 6;
            this.searchLUpCustomer.EditValueChanged += new System.EventHandler(this.searchLUpCustomer_EditValueChanged);
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // cmbCorrigido
            // 
            this.cmbCorrigido.EditValue = "Normal";
            this.cmbCorrigido.Location = new System.Drawing.Point(12, 11);
            this.cmbCorrigido.Name = "cmbCorrigido";
            this.cmbCorrigido.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cmbCorrigido.Properties.Appearance.Options.UseFont = true;
            this.cmbCorrigido.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCorrigido.Properties.Items.AddRange(new object[] {
            "Normal",
            "Modificadas"});
            this.cmbCorrigido.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbCorrigido.Size = new System.Drawing.Size(173, 26);
            this.cmbCorrigido.TabIndex = 7;
            this.cmbCorrigido.SelectedIndexChanged += new System.EventHandler(this.cmbCorrigido_SelectedIndexChanged);
            // 
            // FrmInvoicesForCreditNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 573);
            this.Controls.Add(this.cmbCorrigido);
            this.Controls.Add(this.searchLUpCustomer);
            this.Controls.Add(this.gdvControlInvoices);
            this.Controls.Add(this.txtIdInvoice);
            this.Controls.Add(this.btnCorrigir);
            this.Name = "FrmInvoicesForCreditNote";
            this.Text = "Nota de Crédito";
            this.Load += new System.EventHandler(this.FrmInvoicesForCreditNote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtIdInvoice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvControlInvoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFaturasCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLUpCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCorrigido.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnCorrigir;
        private DevExpress.XtraEditors.TextEdit txtIdInvoice;
        private DevExpress.XtraGrid.GridControl gdvControlInvoices;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewFaturasCliente;
        private DevExpress.XtraGrid.Columns.GridColumn ClId;
        private DevExpress.XtraGrid.Columns.GridColumn Codigo;
        private DevExpress.XtraGrid.Columns.GridColumn Fatura;
        private DevExpress.XtraGrid.Columns.GridColumn Total;
        private DevExpress.XtraGrid.Columns.GridColumn ClCorrigido;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLUpCustomer;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.ComboBoxEdit cmbCorrigido;
    }
}