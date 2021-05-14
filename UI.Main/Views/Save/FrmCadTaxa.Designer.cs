namespace UI.Main.Views.Save
{
    partial class FrmCadTaxa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadTaxa));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDesc = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.btnEliminar = new DevExpress.XtraEditors.SimpleButton();
            this.cmbTaxType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescricao = new DevExpress.XtraEditors.TextEdit();
            this.txtCode = new DevExpress.XtraEditors.TextEdit();
            this.txtTax = new DevExpress.XtraEditors.TextEdit();
            this.gdvControlTaxs = new DevExpress.XtraGrid.GridControl();
            this.gridTaxs = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ClCodigoISE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ClTaxCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ClDescricao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ClMotivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ClTaxaZero = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ClTaxaNor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTaxType.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTax.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvControlTaxs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTaxs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.panel1);
            this.layoutControl1.Controls.Add(this.gdvControlTaxs);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(849, 568);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblDesc);
            this.panel1.Controls.Add(this.labelControl5);
            this.panel1.Controls.Add(this.simpleButton2);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.cmbTaxType);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 193);
            this.panel1.TabIndex = 5;
            // 
            // lblDesc
            // 
            this.lblDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDesc.Appearance.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.lblDesc.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.lblDesc.Appearance.Options.UseFont = true;
            this.lblDesc.Appearance.Options.UseForeColor = true;
            this.lblDesc.Location = new System.Drawing.Point(419, 153);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(46, 23);
            this.lblDesc.TabIndex = 69;
            this.lblDesc.Text = "Taxa";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(13, 127);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(123, 23);
            this.labelControl5.TabIndex = 66;
            this.labelControl5.Text = "Tipo de Taxa";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.simpleButton2.Appearance.Options.UseForeColor = true;
            this.simpleButton2.Location = new System.Drawing.Point(586, 156);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(115, 23);
            this.simpleButton2.TabIndex = 45;
            this.simpleButton2.Text = " Salvar";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.Location = new System.Drawing.Point(707, 156);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(115, 23);
            this.btnEliminar.TabIndex = 45;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // cmbTaxType
            // 
            this.cmbTaxType.Location = new System.Drawing.Point(13, 153);
            this.cmbTaxType.Name = "cmbTaxType";
            this.cmbTaxType.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cmbTaxType.Properties.Appearance.Options.UseFont = true;
            this.cmbTaxType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTaxType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbTaxType.Size = new System.Drawing.Size(400, 26);
            this.cmbTaxType.TabIndex = 4;
            this.cmbTaxType.SelectedIndexChanged += new System.EventHandler(this.cmbTaxType_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelControl2);
            this.panel2.Controls.Add(this.labelControl4);
            this.panel2.Controls.Add(this.labelControl3);
            this.panel2.Controls.Add(this.txtDescricao);
            this.panel2.Controls.Add(this.txtCode);
            this.panel2.Controls.Add(this.txtTax);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(825, 125);
            this.panel2.TabIndex = 5;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(13, 60);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(98, 23);
            this.labelControl2.TabIndex = 68;
            this.labelControl2.Text = "Motivo ISE";
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(448, 3);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(46, 23);
            this.labelControl4.TabIndex = 67;
            this.labelControl4.Text = "Taxa";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(13, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(72, 23);
            this.labelControl3.TabIndex = 66;
            this.labelControl3.Text = "Codigo";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(13, 85);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtDescricao.Properties.Appearance.Options.UseFont = true;
            this.txtDescricao.Size = new System.Drawing.Size(774, 26);
            this.txtDescricao.TabIndex = 0;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(13, 28);
            this.txtCode.Name = "txtCode";
            this.txtCode.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtCode.Properties.Appearance.Options.UseFont = true;
            this.txtCode.Size = new System.Drawing.Size(400, 26);
            this.txtCode.TabIndex = 0;
            // 
            // txtTax
            // 
            this.txtTax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTax.EditValue = "0";
            this.txtTax.Location = new System.Drawing.Point(448, 28);
            this.txtTax.Name = "txtTax";
            this.txtTax.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtTax.Properties.Appearance.Options.UseFont = true;
            this.txtTax.Properties.Mask.EditMask = "d3";
            this.txtTax.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTax.Size = new System.Drawing.Size(339, 26);
            this.txtTax.TabIndex = 0;
            // 
            // gdvControlTaxs
            // 
            this.gdvControlTaxs.AllowDrop = true;
            this.gdvControlTaxs.EmbeddedNavigator.AllowDrop = true;
            this.gdvControlTaxs.Location = new System.Drawing.Point(12, 209);
            this.gdvControlTaxs.MainView = this.gridTaxs;
            this.gdvControlTaxs.Name = "gdvControlTaxs";
            this.gdvControlTaxs.Size = new System.Drawing.Size(825, 347);
            this.gdvControlTaxs.TabIndex = 4;
            this.gdvControlTaxs.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridTaxs});
            // 
            // gridTaxs
            // 
            this.gridTaxs.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ClCodigoISE,
            this.ClTaxCode,
            this.ClDescricao,
            this.ClMotivo,
            this.ClTaxaZero,
            this.ClTaxaNor,
            this.gridColumn2});
            this.gridTaxs.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridTaxs.GridControl = this.gdvControlTaxs;
            this.gridTaxs.Name = "gridTaxs";
            this.gridTaxs.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridTaxs.OptionsMenu.ShowFooterItem = true;
            this.gridTaxs.OptionsNavigation.AutoFocusNewRow = true;
            this.gridTaxs.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridTaxs.OptionsView.ShowGroupPanel = false;
            this.gridTaxs.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridTaxs_CellValueChanged);
            // 
            // ClCodigoISE
            // 
            this.ClCodigoISE.Caption = "Código";
            this.ClCodigoISE.FieldName = "Id";
            this.ClCodigoISE.Name = "ClCodigoISE";
            this.ClCodigoISE.Visible = true;
            this.ClCodigoISE.VisibleIndex = 3;
            this.ClCodigoISE.Width = 58;
            // 
            // ClTaxCode
            // 
            this.ClTaxCode.Caption = "Codigo ";
            this.ClTaxCode.FieldName = "Code";
            this.ClTaxCode.Name = "ClTaxCode";
            this.ClTaxCode.Visible = true;
            this.ClTaxCode.VisibleIndex = 0;
            this.ClTaxCode.Width = 57;
            // 
            // ClDescricao
            // 
            this.ClDescricao.FieldName = "Descricao";
            this.ClDescricao.Name = "ClDescricao";
            this.ClDescricao.Visible = true;
            this.ClDescricao.VisibleIndex = 1;
            this.ClDescricao.Width = 260;
            // 
            // ClMotivo
            // 
            this.ClMotivo.Caption = "Motivo";
            this.ClMotivo.FieldName = "MencaoFatura";
            this.ClMotivo.Name = "ClMotivo";
            this.ClMotivo.Visible = true;
            this.ClMotivo.VisibleIndex = 4;
            this.ClMotivo.Width = 338;
            // 
            // ClTaxaZero
            // 
            this.ClTaxaZero.Caption = "Taxa ";
            this.ClTaxaZero.FieldName = "CodigoTaxa.Taxa";
            this.ClTaxaZero.GroupFormat.FormatString = "F2";
            this.ClTaxaZero.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.ClTaxaZero.Name = "ClTaxaZero";
            this.ClTaxaZero.OptionsColumn.AllowEdit = false;
            this.ClTaxaZero.Visible = true;
            this.ClTaxaZero.VisibleIndex = 5;
            this.ClTaxaZero.Width = 48;
            // 
            // ClTaxaNor
            // 
            this.ClTaxaNor.Caption = "Taxa";
            this.ClTaxaNor.FieldName = "Taxa";
            this.ClTaxaNor.GroupFormat.FormatString = "F2";
            this.ClTaxaNor.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.ClTaxaNor.Name = "ClTaxaNor";
            this.ClTaxaNor.Visible = true;
            this.ClTaxaNor.VisibleIndex = 2;
            this.ClTaxaNor.Width = 43;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Principal";
            this.gridColumn2.FieldName = "flagPrincipal";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 6;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(849, 568);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gdvControlTaxs;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 197);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(829, 351);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.panel1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(829, 197);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Name = "gridColumn1";
            // 
            // FrmCadTaxa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 568);
            this.Controls.Add(this.layoutControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCadTaxa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastar Taxa";
            this.Load += new System.EventHandler(this.FrmCadTaxa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTaxType.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTax.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvControlTaxs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTaxs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.TextEdit txtTax;
        private DevExpress.XtraEditors.TextEdit txtDescricao;
        private DevExpress.XtraEditors.TextEdit txtCode;
        private DevExpress.XtraGrid.GridControl gdvControlTaxs;
        private DevExpress.XtraGrid.Views.Grid.GridView gridTaxs;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.ComboBoxEdit cmbTaxType;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraGrid.Columns.GridColumn ClCodigoISE;
        private DevExpress.XtraGrid.Columns.GridColumn ClTaxCode;
        private DevExpress.XtraGrid.Columns.GridColumn ClDescricao;
        private DevExpress.XtraGrid.Columns.GridColumn ClMotivo;
        private DevExpress.XtraGrid.Columns.GridColumn ClTaxaZero;
        private DevExpress.XtraGrid.Columns.GridColumn ClTaxaNor;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.SimpleButton btnEliminar;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl lblDesc;
    }
}