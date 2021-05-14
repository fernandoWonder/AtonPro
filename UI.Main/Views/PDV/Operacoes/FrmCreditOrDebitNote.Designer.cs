namespace UI.Main.Views.Operacoes
{
    partial class FrmCreditOrDebitNote
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCreditOrDebitNote));
            this.gdvControlProducts = new DevExpress.XtraGrid.GridControl();
            this.gridProducts = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Qdade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Desconto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Preco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblFatauraAlterar = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCliente = new DevExpress.XtraEditors.TextEdit();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtEnd = new DevExpress.XtraEditors.TextEdit();
            this.textTel = new DevExpress.XtraEditors.TextEdit();
            this.textNif = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMotivoNota = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDescLinhas = new System.Windows.Forms.Label();
            this.cmbTipoOperacaoNota = new DevExpress.XtraEditors.ComboBoxEdit();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblIva = new System.Windows.Forms.Label();
            this.lblIncid = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblNotaNo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnRemoveProduct = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gdvControlProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCliente.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textTel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textNif.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMotivoNota.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoOperacaoNota.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.SuspendLayout();
            // 
            // gdvControlProducts
            // 
            this.gdvControlProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gdvControlProducts.Location = new System.Drawing.Point(7, 284);
            this.gdvControlProducts.MainView = this.gridProducts;
            this.gdvControlProducts.Name = "gdvControlProducts";
            this.gdvControlProducts.Size = new System.Drawing.Size(905, 347);
            this.gdvControlProducts.TabIndex = 5;
            this.gdvControlProducts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridProducts});
            // 
            // gridProducts
            // 
            this.gridProducts.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.Qdade,
            this.Desconto,
            this.Preco,
            this.gridColumn6,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn1});
            this.gridProducts.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.gridProducts.GridControl = this.gdvControlProducts;
            this.gridProducts.Name = "gridProducts";
            this.gridProducts.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridProducts.OptionsView.ShowGroupPanel = false;
            this.gridProducts.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridProducts_CellValueChanged);
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
            this.Preco.FieldName = "Preco";
            this.Preco.GroupFormat.FormatString = "F3";
            this.Preco.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
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
            this.gridColumn6.GroupFormat.FormatString = "F2";
            this.gridColumn6.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
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
            this.gridColumn10.FieldName = "TotalTaxa";
            this.gridColumn10.GroupFormat.FormatString = "F3";
            this.gridColumn10.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
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
            this.gridColumn11.FieldName = "Total";
            this.gridColumn11.GroupFormat.FormatString = "F3";
            this.gridColumn11.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
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
            this.gridColumn1.FieldName = "TotalIncidencia";
            this.gridColumn1.GroupFormat.FormatString = "F3";
            this.gridColumn1.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn1.MaxWidth = 100;
            this.gridColumn1.MinWidth = 90;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 5;
            this.gridColumn1.Width = 100;
            // 
            // lblFatauraAlterar
            // 
            this.lblFatauraAlterar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFatauraAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFatauraAlterar.ForeColor = System.Drawing.Color.Red;
            this.lblFatauraAlterar.Location = new System.Drawing.Point(17, 128);
            this.lblFatauraAlterar.Name = "lblFatauraAlterar";
            this.lblFatauraAlterar.Size = new System.Drawing.Size(348, 27);
            this.lblFatauraAlterar.TabIndex = 38;
            this.lblFatauraAlterar.Text = "FT Seller2021/1";
            this.lblFatauraAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(6, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 18);
            this.label13.TabIndex = 41;
            this.label13.Text = "Cliente";
            // 
            // txtCliente
            // 
            this.txtCliente.EditValue = "";
            this.txtCliente.Enabled = false;
            this.txtCliente.Location = new System.Drawing.Point(9, 33);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtCliente.Properties.Appearance.Options.UseFont = true;
            this.txtCliente.Size = new System.Drawing.Size(345, 26);
            this.txtCliente.TabIndex = 42;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtEnd);
            this.groupBox2.Controls.Add(this.textTel);
            this.groupBox2.Controls.Add(this.textNif);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtCliente);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(12, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(900, 98);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados Cliente";
            // 
            // txtEnd
            // 
            this.txtEnd.EditValue = "";
            this.txtEnd.Enabled = false;
            this.txtEnd.Location = new System.Drawing.Point(9, 65);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtEnd.Properties.Appearance.Options.UseFont = true;
            this.txtEnd.Size = new System.Drawing.Size(885, 26);
            this.txtEnd.TabIndex = 42;
            // 
            // textTel
            // 
            this.textTel.EditValue = "";
            this.textTel.Enabled = false;
            this.textTel.Location = new System.Drawing.Point(631, 33);
            this.textTel.Name = "textTel";
            this.textTel.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.textTel.Properties.Appearance.Options.UseFont = true;
            this.textTel.Size = new System.Drawing.Size(263, 26);
            this.textTel.TabIndex = 42;
            // 
            // textNif
            // 
            this.textNif.EditValue = "";
            this.textNif.Enabled = false;
            this.textNif.Location = new System.Drawing.Point(360, 33);
            this.textNif.Name = "textNif";
            this.textNif.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.textNif.Properties.Appearance.Options.UseFont = true;
            this.textNif.Size = new System.Drawing.Size(265, 26);
            this.textNif.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(628, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 18);
            this.label2.TabIndex = 41;
            this.label2.Text = "Tel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(357, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 18);
            this.label1.TabIndex = 41;
            this.label1.Text = "NIF";
            // 
            // cmbMotivoNota
            // 
            this.cmbMotivoNota.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbMotivoNota.Location = new System.Drawing.Point(489, 138);
            this.cmbMotivoNota.Name = "cmbMotivoNota";
            this.cmbMotivoNota.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cmbMotivoNota.Properties.Appearance.Options.UseFont = true;
            this.cmbMotivoNota.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbMotivoNota.Size = new System.Drawing.Size(423, 26);
            this.cmbMotivoNota.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(383, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 18);
            this.label6.TabIndex = 41;
            this.label6.Text = "Motivo da Nota";
            // 
            // lblDescLinhas
            // 
            this.lblDescLinhas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDescLinhas.AutoSize = true;
            this.lblDescLinhas.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblDescLinhas.ForeColor = System.Drawing.Color.Gray;
            this.lblDescLinhas.Location = new System.Drawing.Point(3, 2);
            this.lblDescLinhas.Name = "lblDescLinhas";
            this.lblDescLinhas.Size = new System.Drawing.Size(129, 20);
            this.lblDescLinhas.TabIndex = 45;
            this.lblDescLinhas.Text = "Desc/Linhas: 400";
            // 
            // cmbTipoOperacaoNota
            // 
            this.cmbTipoOperacaoNota.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbTipoOperacaoNota.Location = new System.Drawing.Point(6, 64);
            this.cmbTipoOperacaoNota.Name = "cmbTipoOperacaoNota";
            this.cmbTipoOperacaoNota.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cmbTipoOperacaoNota.Properties.Appearance.Options.UseFont = true;
            this.cmbTipoOperacaoNota.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTipoOperacaoNota.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbTipoOperacaoNota.Size = new System.Drawing.Size(183, 26);
            this.cmbTipoOperacaoNota.TabIndex = 47;
            this.cmbTipoOperacaoNota.SelectedIndexChanged += new System.EventHandler(this.cmbTipoNota_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.lblIva);
            this.panel2.Controls.Add(this.lblDescLinhas);
            this.panel2.Controls.Add(this.lblIncid);
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Location = new System.Drawing.Point(200, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(715, 48);
            this.panel2.TabIndex = 48;
            // 
            // lblIva
            // 
            this.lblIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIva.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblIva.Location = new System.Drawing.Point(431, 1);
            this.lblIva.Name = "lblIva";
            this.lblIva.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblIva.Size = new System.Drawing.Size(285, 20);
            this.lblIva.TabIndex = 41;
            this.lblIva.Text = "IVA: 1400";
            // 
            // lblIncid
            // 
            this.lblIncid.AutoSize = true;
            this.lblIncid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncid.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblIncid.Location = new System.Drawing.Point(3, 21);
            this.lblIncid.Name = "lblIncid";
            this.lblIncid.Size = new System.Drawing.Size(122, 24);
            this.lblIncid.TabIndex = 41;
            this.lblIncid.Text = "Incid: 20000";
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTotal.Location = new System.Drawing.Point(426, 21);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTotal.Size = new System.Drawing.Size(290, 24);
            this.lblTotal.TabIndex = 41;
            this.lblTotal.Text = "Total: 20000";
            // 
            // lblNotaNo
            // 
            this.lblNotaNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotaNo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblNotaNo.Location = new System.Drawing.Point(732, 94);
            this.lblNotaNo.Name = "lblNotaNo";
            this.lblNotaNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblNotaNo.Size = new System.Drawing.Size(183, 12);
            this.lblNotaNo.TabIndex = 38;
            this.lblNotaNo.Text = "NC AGT2020/2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(18, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 18);
            this.label3.TabIndex = 41;
            this.label3.Text = "Fatura da referente nota";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(4, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 18);
            this.label4.TabIndex = 41;
            this.label4.Text = "Opção";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            this.panel3.Controls.Add(this.bunifuImageButton2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(927, 34);
            this.panel3.TabIndex = 60;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton2.Image = global::UI.Main.Properties.Resources.Delete_64px;
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(898, 0);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(29, 34);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 120;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(132)))));
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.Silver;
            this.bunifuThinButton21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuThinButton21.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuThinButton21.ButtonText = "Salvar";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.DarkGray;
            this.bunifuThinButton21.Location = new System.Drawing.Point(734, 650);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(172, 41);
            this.bunifuThinButton21.TabIndex = 120;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            this.panel4.Location = new System.Drawing.Point(13, 645);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(893, 5);
            this.panel4.TabIndex = 121;
            // 
            // btnRemoveProduct
            // 
            this.btnRemoveProduct.ActiveBorderThickness = 1;
            this.btnRemoveProduct.ActiveCornerRadius = 20;
            this.btnRemoveProduct.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(48)))), ((int)(((byte)(44)))));
            this.btnRemoveProduct.ActiveForecolor = System.Drawing.Color.Transparent;
            this.btnRemoveProduct.ActiveLineColor = System.Drawing.Color.Transparent;
            this.btnRemoveProduct.BackColor = System.Drawing.SystemColors.Control;
            this.btnRemoveProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemoveProduct.BackgroundImage")));
            this.btnRemoveProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemoveProduct.ButtonText = "Remover produto";
            this.btnRemoveProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveProduct.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveProduct.ForeColor = System.Drawing.Color.White;
            this.btnRemoveProduct.IdleBorderThickness = 1;
            this.btnRemoveProduct.IdleCornerRadius = 20;
            this.btnRemoveProduct.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(48)))), ((int)(((byte)(44)))));
            this.btnRemoveProduct.IdleForecolor = System.Drawing.Color.Transparent;
            this.btnRemoveProduct.IdleLineColor = System.Drawing.Color.Transparent;
            this.btnRemoveProduct.Location = new System.Drawing.Point(14, 654);
            this.btnRemoveProduct.Margin = new System.Windows.Forms.Padding(5);
            this.btnRemoveProduct.Name = "btnRemoveProduct";
            this.btnRemoveProduct.Size = new System.Drawing.Size(157, 43);
            this.btnRemoveProduct.TabIndex = 123;
            this.btnRemoveProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRemoveProduct.Click += new System.EventHandler(this.bunifuThinButton23_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel3;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 7;
            this.bunifuElipse1.TargetControl = this;
            // 
            // FrmCreditOrDebitNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 700);
            this.Controls.Add(this.btnRemoveProduct);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.gdvControlProducts);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cmbMotivoNota);
            this.Controls.Add(this.cmbTipoOperacaoNota);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblNotaNo);
            this.Controls.Add(this.lblFatauraAlterar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCreditOrDebitNote";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Credito E Débito";
            this.Load += new System.EventHandler(this.FrmCreditOrDebitNote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdvControlProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCliente.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textTel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textNif.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMotivoNota.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoOperacaoNota.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gdvControlProducts;
        private DevExpress.XtraGrid.Views.Grid.GridView gridProducts;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn Qdade;
        private DevExpress.XtraGrid.Columns.GridColumn Desconto;
        private DevExpress.XtraGrid.Columns.GridColumn Preco;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private System.Windows.Forms.Label lblFatauraAlterar;
        private System.Windows.Forms.Label label13;
        private DevExpress.XtraEditors.TextEdit txtCliente;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.TextEdit textTel;
        private DevExpress.XtraEditors.TextEdit textNif;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.ComboBoxEdit cmbMotivoNota;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDescLinhas;
        private DevExpress.XtraEditors.ComboBoxEdit cmbTipoOperacaoNota;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblIva;
        private System.Windows.Forms.Label lblIncid;
        private System.Windows.Forms.Label lblTotal;
        private DevExpress.XtraEditors.TextEdit txtEnd;
        private System.Windows.Forms.Label lblNotaNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuThinButton2 btnRemoveProduct;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}