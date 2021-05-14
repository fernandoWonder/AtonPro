namespace UI.Main.Views.PDV.Operacoes
{
    partial class FrmFaturaRecibo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFaturaRecibo));
            this.btnCarregarFaturas = new DevExpress.XtraEditors.SimpleButton();
            this.lblFirstDoc = new DevExpress.XtraEditors.LabelControl();
            this.txtCodigoFatura = new DevExpress.XtraEditors.TextEdit();
            this.searchLUpCustomer = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnNewSerie = new DevExpress.XtraEditors.SimpleButton();
            this.cmbInvoiceType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbSerie = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbInvoiceName = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panelDocuments = new System.Windows.Forms.Panel();
            this.dtVencimento = new System.Windows.Forms.DateTimePicker();
            this.gdvControlProducts = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Qdade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Desconto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Preco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbConta = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTotalGeral = new DevExpress.XtraEditors.TextEdit();
            this.txtTotal = new DevExpress.XtraEditors.TextEdit();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbPaymentMechanism = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtTotDescontoProdutos = new DevExpress.XtraEditors.TextEdit();
            this.txtDesconto = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIVA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ckAuto = new DevExpress.XtraEditors.CheckEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSalvar = new DevExpress.XtraEditors.SimpleButton();
            this.label14 = new System.Windows.Forms.Label();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddProduct = new DevExpress.XtraEditors.SimpleButton();
            this.txtTroco = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.txtValorPago = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoFatura.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLUpCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbInvoiceType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSerie.Properties)).BeginInit();
            this.panelDocuments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvControlProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbConta.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalGeral.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPaymentMechanism.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotDescontoProdutos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesconto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckAuto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTroco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorPago.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCarregarFaturas
            // 
            this.btnCarregarFaturas.ImageOptions.SvgImage = global::UI.Main.Properties.Resources.actions_refresh;
            this.btnCarregarFaturas.Location = new System.Drawing.Point(309, 88);
            this.btnCarregarFaturas.Name = "btnCarregarFaturas";
            this.btnCarregarFaturas.Size = new System.Drawing.Size(36, 28);
            this.btnCarregarFaturas.TabIndex = 39;
            // 
            // lblFirstDoc
            // 
            this.lblFirstDoc.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblFirstDoc.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.lblFirstDoc.Appearance.Options.UseFont = true;
            this.lblFirstDoc.Appearance.Options.UseForeColor = true;
            this.lblFirstDoc.Location = new System.Drawing.Point(419, 75);
            this.lblFirstDoc.Name = "lblFirstDoc";
            this.lblFirstDoc.Size = new System.Drawing.Size(130, 16);
            this.lblFirstDoc.TabIndex = 47;
            this.lblFirstDoc.Text = "1º documetno da série";
            this.lblFirstDoc.Visible = false;
            // 
            // txtCodigoFatura
            // 
            this.txtCodigoFatura.Enabled = false;
            this.txtCodigoFatura.Location = new System.Drawing.Point(415, 46);
            this.txtCodigoFatura.Name = "txtCodigoFatura";
            this.txtCodigoFatura.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtCodigoFatura.Properties.Appearance.Options.UseFont = true;
            this.txtCodigoFatura.Size = new System.Drawing.Size(141, 26);
            this.txtCodigoFatura.TabIndex = 42;
            this.txtCodigoFatura.Visible = false;
            // 
            // searchLUpCustomer
            // 
            this.searchLUpCustomer.EditValue = "Cliente";
            this.searchLUpCustomer.EnterMoveNextControl = true;
            this.searchLUpCustomer.Location = new System.Drawing.Point(73, 89);
            this.searchLUpCustomer.Name = "searchLUpCustomer";
            this.searchLUpCustomer.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.searchLUpCustomer.Properties.Appearance.Options.UseFont = true;
            this.searchLUpCustomer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search)});
            this.searchLUpCustomer.Properties.NullText = "Cliente";
            this.searchLUpCustomer.Properties.PopupView = this.gridView2;
            this.searchLUpCustomer.Size = new System.Drawing.Size(230, 26);
            this.searchLUpCustomer.TabIndex = 38;
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // btnNewSerie
            // 
            this.btnNewSerie.Appearance.BackColor = System.Drawing.Color.White;
            this.btnNewSerie.Appearance.BackColor2 = System.Drawing.Color.White;
            this.btnNewSerie.Appearance.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnNewSerie.Appearance.Options.UseBackColor = true;
            this.btnNewSerie.Appearance.Options.UseFont = true;
            this.btnNewSerie.Appearance.Options.UseTextOptions = true;
            this.btnNewSerie.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnNewSerie.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnNewSerie.AppearanceDisabled.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewSerie.AppearanceDisabled.Options.UseBackColor = true;
            this.btnNewSerie.AppearanceDisabled.Options.UseFont = true;
            this.btnNewSerie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNewSerie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewSerie.ImageOptions.SvgImage = global::UI.Main.Properties.Resources.actions_addcircled;
            this.btnNewSerie.Location = new System.Drawing.Point(267, 4);
            this.btnNewSerie.Name = "btnNewSerie";
            this.btnNewSerie.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnNewSerie.Size = new System.Drawing.Size(36, 27);
            this.btnNewSerie.TabIndex = 40;
            // 
            // cmbInvoiceType
            // 
            this.cmbInvoiceType.Location = new System.Drawing.Point(74, 45);
            this.cmbInvoiceType.Name = "cmbInvoiceType";
            this.cmbInvoiceType.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.cmbInvoiceType.Properties.Appearance.Options.UseFont = true;
            this.cmbInvoiceType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbInvoiceType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbInvoiceType.Size = new System.Drawing.Size(75, 28);
            this.cmbInvoiceType.TabIndex = 37;
            // 
            // cmbSerie
            // 
            this.cmbSerie.Location = new System.Drawing.Point(74, 3);
            this.cmbSerie.Name = "cmbSerie";
            this.cmbSerie.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.cmbSerie.Properties.Appearance.Options.UseFont = true;
            this.cmbSerie.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbSerie.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbSerie.Size = new System.Drawing.Size(187, 30);
            this.cmbSerie.TabIndex = 36;
            // 
            // cbInvoiceName
            // 
            this.cbInvoiceName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbInvoiceName.Enabled = false;
            this.cbInvoiceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.cbInvoiceName.ForeColor = System.Drawing.Color.Black;
            this.cbInvoiceName.FormattingEnabled = true;
            this.cbInvoiceName.Location = new System.Drawing.Point(155, 46);
            this.cbInvoiceName.Name = "cbInvoiceName";
            this.cbInvoiceName.Size = new System.Drawing.Size(254, 28);
            this.cbInvoiceName.TabIndex = 41;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(411, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 20);
            this.label10.TabIndex = 43;
            this.label10.Text = "Codigo Fatura";
            this.label10.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(13, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 20);
            this.label12.TabIndex = 44;
            this.label12.Text = "Série";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(13, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 20);
            this.label9.TabIndex = 45;
            this.label9.Text = "tipo";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(14, 93);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 18);
            this.label13.TabIndex = 46;
            this.label13.Text = "Cliente";
            // 
            // panelDocuments
            // 
            this.panelDocuments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDocuments.Controls.Add(this.dtVencimento);
            this.panelDocuments.Controls.Add(this.gdvControlProducts);
            this.panelDocuments.Controls.Add(this.cmbConta);
            this.panelDocuments.Controls.Add(this.txtDescricao);
            this.panelDocuments.Controls.Add(this.groupBox1);
            this.panelDocuments.Controls.Add(this.label5);
            this.panelDocuments.Controls.Add(this.ckAuto);
            this.panelDocuments.Controls.Add(this.label7);
            this.panelDocuments.Controls.Add(this.btnSalvar);
            this.panelDocuments.Controls.Add(this.label14);
            this.panelDocuments.Controls.Add(this.btnClear);
            this.panelDocuments.Controls.Add(this.btnAddProduct);
            this.panelDocuments.Controls.Add(this.txtTroco);
            this.panelDocuments.Controls.Add(this.simpleButton1);
            this.panelDocuments.Controls.Add(this.txtValorPago);
            this.panelDocuments.Location = new System.Drawing.Point(0, 125);
            this.panelDocuments.Name = "panelDocuments";
            this.panelDocuments.Size = new System.Drawing.Size(988, 508);
            this.panelDocuments.TabIndex = 49;
            // 
            // dtVencimento
            // 
            this.dtVencimento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dtVencimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtVencimento.Location = new System.Drawing.Point(861, 420);
            this.dtVencimento.Name = "dtVencimento";
            this.dtVencimento.Size = new System.Drawing.Size(121, 29);
            this.dtVencimento.TabIndex = 11;
            // 
            // gdvControlProducts
            // 
            this.gdvControlProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gdvControlProducts.Location = new System.Drawing.Point(12, 15);
            this.gdvControlProducts.MainView = this.gridView1;
            this.gdvControlProducts.Name = "gdvControlProducts";
            this.gdvControlProducts.Size = new System.Drawing.Size(958, 289);
            this.gdvControlProducts.TabIndex = 4;
            this.gdvControlProducts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.Qdade,
            this.Desconto,
            this.Preco,
            this.gridColumn6,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn1});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.gridView1.GridControl = this.gdvControlProducts;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Artigo";
            this.gridColumn2.FieldName = "DescricaoProduto";
            this.gridColumn2.MinWidth = 160;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 230;
            // 
            // Qdade
            // 
            this.Qdade.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(167)))));
            this.Qdade.AppearanceHeader.Options.UseBackColor = true;
            this.Qdade.Caption = "Quantidade";
            this.Qdade.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Qdade.FieldName = "Quantidade";
            this.Qdade.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Qdade.MaxWidth = 80;
            this.Qdade.MinWidth = 70;
            this.Qdade.Name = "Qdade";
            this.Qdade.ToolTip = "Quantidade a vender";
            this.Qdade.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.Qdade.Visible = true;
            this.Qdade.VisibleIndex = 1;
            this.Qdade.Width = 80;
            // 
            // Desconto
            // 
            this.Desconto.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(167)))));
            this.Desconto.AppearanceHeader.Options.UseBackColor = true;
            this.Desconto.Caption = "Desconto";
            this.Desconto.DisplayFormat.FormatString = "F2";
            this.Desconto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Desconto.FieldName = "Desconto";
            this.Desconto.MaxWidth = 80;
            this.Desconto.MinWidth = 60;
            this.Desconto.Name = "Desconto";
            this.Desconto.Visible = true;
            this.Desconto.VisibleIndex = 3;
            this.Desconto.Width = 80;
            // 
            // Preco
            // 
            this.Preco.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(167)))));
            this.Preco.AppearanceHeader.Options.UseBackColor = true;
            this.Preco.Caption = "Preço";
            this.Preco.DisplayFormat.FormatString = "F3";
            this.Preco.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Preco.FieldName = "Preco";
            this.Preco.MaxWidth = 120;
            this.Preco.MinWidth = 80;
            this.Preco.Name = "Preco";
            this.Preco.Visible = true;
            this.Preco.VisibleIndex = 2;
            this.Preco.Width = 120;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Taxa";
            this.gridColumn6.FieldName = "Taxa";
            this.gridColumn6.MaxWidth = 60;
            this.gridColumn6.MinWidth = 60;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 4;
            this.gridColumn6.Width = 60;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "T/IVA";
            this.gridColumn10.DisplayFormat.FormatString = "F3";
            this.gridColumn10.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn10.FieldName = "TotalTaxa";
            this.gridColumn10.MaxWidth = 100;
            this.gridColumn10.MinWidth = 40;
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.OptionsColumn.AllowEdit = false;
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 6;
            this.gridColumn10.Width = 100;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Total";
            this.gridColumn11.DisplayFormat.FormatString = "F3";
            this.gridColumn11.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn11.FieldName = "Total";
            this.gridColumn11.MaxWidth = 100;
            this.gridColumn11.MinWidth = 80;
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.OptionsColumn.AllowEdit = false;
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 7;
            this.gridColumn11.Width = 100;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Total Incidência";
            this.gridColumn1.DisplayFormat.FormatString = "F3";
            this.gridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn1.FieldName = "TotalIncidencia";
            this.gridColumn1.MaxWidth = 100;
            this.gridColumn1.MinWidth = 90;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 5;
            this.gridColumn1.Width = 100;
            // 
            // cmbConta
            // 
            this.cmbConta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbConta.Location = new System.Drawing.Point(262, 309);
            this.cmbConta.Name = "cmbConta";
            this.cmbConta.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cmbConta.Properties.Appearance.Options.UseFont = true;
            this.cmbConta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbConta.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbConta.Size = new System.Drawing.Size(238, 26);
            this.cmbConta.TabIndex = 5;
            this.cmbConta.Visible = false;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(714, 336);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(268, 78);
            this.txtDescricao.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txtTotalGeral);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtTotDescontoProdutos);
            this.groupBox1.Controls.Add(this.txtDesconto);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtIVA);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(4, 340);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(496, 153);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculo";
            // 
            // txtTotalGeral
            // 
            this.txtTotalGeral.EditValue = "0";
            this.txtTotalGeral.Enabled = false;
            this.txtTotalGeral.Location = new System.Drawing.Point(385, 112);
            this.txtTotalGeral.Name = "txtTotalGeral";
            this.txtTotalGeral.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtTotalGeral.Properties.Appearance.Options.UseFont = true;
            this.txtTotalGeral.Size = new System.Drawing.Size(110, 26);
            this.txtTotalGeral.TabIndex = 4;
            // 
            // txtTotal
            // 
            this.txtTotal.EditValue = "0";
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(385, 77);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtTotal.Properties.Appearance.Options.UseFont = true;
            this.txtTotal.Size = new System.Drawing.Size(110, 26);
            this.txtTotal.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.cmbPaymentMechanism);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(271, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(224, 59);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Forma de Pagamento";
            // 
            // cmbPaymentMechanism
            // 
            this.cmbPaymentMechanism.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbPaymentMechanism.Location = new System.Drawing.Point(12, 22);
            this.cmbPaymentMechanism.Name = "cmbPaymentMechanism";
            this.cmbPaymentMechanism.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cmbPaymentMechanism.Properties.Appearance.Options.UseFont = true;
            this.cmbPaymentMechanism.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbPaymentMechanism.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbPaymentMechanism.Size = new System.Drawing.Size(206, 26);
            this.cmbPaymentMechanism.TabIndex = 0;
            // 
            // txtTotDescontoProdutos
            // 
            this.txtTotDescontoProdutos.EditValue = "0";
            this.txtTotDescontoProdutos.Enabled = false;
            this.txtTotDescontoProdutos.Location = new System.Drawing.Point(125, 33);
            this.txtTotDescontoProdutos.Name = "txtTotDescontoProdutos";
            this.txtTotDescontoProdutos.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtTotDescontoProdutos.Properties.Appearance.Options.UseFont = true;
            this.txtTotDescontoProdutos.Size = new System.Drawing.Size(137, 26);
            this.txtTotDescontoProdutos.TabIndex = 4;
            // 
            // txtDesconto
            // 
            this.txtDesconto.EditValue = "0";
            this.txtDesconto.Location = new System.Drawing.Point(125, 115);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtDesconto.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.txtDesconto.Properties.Appearance.Options.UseFont = true;
            this.txtDesconto.Properties.Appearance.Options.UseForeColor = true;
            this.txtDesconto.Properties.Mask.BeepOnError = true;
            this.txtDesconto.Properties.Mask.EditMask = "P";
            this.txtDesconto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtDesconto.Size = new System.Drawing.Size(137, 26);
            this.txtDesconto.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(4, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Desconto Prod.";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(274, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 21);
            this.label6.TabIndex = 3;
            this.label6.Text = "Total Geral";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(327, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(6, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tot. Imposto";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(5, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Desconto %";
            // 
            // txtIVA
            // 
            this.txtIVA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtIVA.Enabled = false;
            this.txtIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIVA.Location = new System.Drawing.Point(125, 78);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.Size = new System.Drawing.Size(137, 26);
            this.txtIVA.TabIndex = 2;
            this.txtIVA.Text = "0";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(588, 432);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "Pago";
            // 
            // ckAuto
            // 
            this.ckAuto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ckAuto.EditValue = true;
            this.ckAuto.Location = new System.Drawing.Point(502, 436);
            this.ckAuto.Name = "ckAuto";
            this.ckAuto.Properties.Caption = "Automático";
            this.ckAuto.Properties.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.SvgToggle1;
            this.ckAuto.Size = new System.Drawing.Size(85, 22);
            this.ckAuto.TabIndex = 6;
            this.ckAuto.ToolTip = "Preenche o campo \'Pago\' automáticamente";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(710, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 21);
            this.label7.TabIndex = 3;
            this.label7.Text = "Observação";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnSalvar.Appearance.Options.UseFont = true;
            this.btnSalvar.Appearance.Options.UseTextOptions = true;
            this.btnSalvar.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnSalvar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSalvar.ImageOptions.SvgImage")));
            this.btnSalvar.Location = new System.Drawing.Point(896, 454);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(86, 39);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Salvar";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label14.ForeColor = System.Drawing.Color.Gray;
            this.label14.Location = new System.Drawing.Point(588, 466);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 21);
            this.label14.TabIndex = 3;
            this.label14.Text = "Troco";
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnClear.Appearance.Options.UseFont = true;
            this.btnClear.Appearance.Options.UseTextOptions = true;
            this.btnClear.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnClear.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.ImageOptions.Image")));
            this.btnClear.Location = new System.Drawing.Point(800, 455);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 39);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Limpar";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddProduct.Location = new System.Drawing.Point(12, 310);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(75, 23);
            this.btnAddProduct.TabIndex = 3;
            this.btnAddProduct.Text = "Add Prodduto";
            // 
            // txtTroco
            // 
            this.txtTroco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTroco.EditValue = "0";
            this.txtTroco.Enabled = false;
            this.txtTroco.Location = new System.Drawing.Point(643, 465);
            this.txtTroco.Name = "txtTroco";
            this.txtTroco.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtTroco.Properties.Appearance.Options.UseFont = true;
            this.txtTroco.Properties.Mask.EditMask = "n";
            this.txtTroco.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTroco.Size = new System.Drawing.Size(120, 26);
            this.txtTroco.TabIndex = 4;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.simpleButton1.Location = new System.Drawing.Point(93, 310);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(104, 23);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "Remover Prodduto";
            // 
            // txtValorPago
            // 
            this.txtValorPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValorPago.EditValue = "0";
            this.txtValorPago.Location = new System.Drawing.Point(643, 430);
            this.txtValorPago.Name = "txtValorPago";
            this.txtValorPago.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtValorPago.Properties.Appearance.Options.UseFont = true;
            this.txtValorPago.Properties.Mask.BeepOnError = true;
            this.txtValorPago.Properties.Mask.EditMask = "n";
            this.txtValorPago.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtValorPago.Size = new System.Drawing.Size(120, 26);
            this.txtValorPago.TabIndex = 7;
            // 
            // FrmFaturaRecibo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(989, 637);
            this.Controls.Add(this.btnCarregarFaturas);
            this.Controls.Add(this.lblFirstDoc);
            this.Controls.Add(this.txtCodigoFatura);
            this.Controls.Add(this.searchLUpCustomer);
            this.Controls.Add(this.btnNewSerie);
            this.Controls.Add(this.cmbInvoiceType);
            this.Controls.Add(this.cmbSerie);
            this.Controls.Add(this.cbInvoiceName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.panelDocuments);
            this.Name = "FrmFaturaRecibo";
            this.Text = "FrmFaturaRecibo";
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoFatura.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLUpCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbInvoiceType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSerie.Properties)).EndInit();
            this.panelDocuments.ResumeLayout(false);
            this.panelDocuments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvControlProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbConta.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalGeral.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbPaymentMechanism.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotDescontoProdutos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesconto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckAuto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTroco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorPago.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnCarregarFaturas;
        private DevExpress.XtraEditors.LabelControl lblFirstDoc;
        private DevExpress.XtraEditors.TextEdit txtCodigoFatura;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLUpCustomer;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.SimpleButton btnNewSerie;
        private DevExpress.XtraEditors.ComboBoxEdit cmbInvoiceType;
        private DevExpress.XtraEditors.ComboBoxEdit cmbSerie;
        private System.Windows.Forms.ComboBox cbInvoiceName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panelDocuments;
        private System.Windows.Forms.DateTimePicker dtVencimento;
        private DevExpress.XtraGrid.GridControl gdvControlProducts;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn Qdade;
        private DevExpress.XtraGrid.Columns.GridColumn Desconto;
        private DevExpress.XtraGrid.Columns.GridColumn Preco;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.ComboBoxEdit cmbConta;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.TextEdit txtTotalGeral;
        private DevExpress.XtraEditors.TextEdit txtTotal;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.ComboBoxEdit cmbPaymentMechanism;
        private DevExpress.XtraEditors.TextEdit txtTotDescontoProdutos;
        private DevExpress.XtraEditors.TextEdit txtDesconto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIVA;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.CheckEdit ckAuto;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.SimpleButton btnSalvar;
        private System.Windows.Forms.Label label14;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.XtraEditors.SimpleButton btnAddProduct;
        private DevExpress.XtraEditors.TextEdit txtTroco;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit txtValorPago;
    }
}