namespace UI.Main.Views.Save
{
    partial class FrmProdutoView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProdutoView));
            this.livroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTitulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategoriaId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnDeleteProduct = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnEdit = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnAddProduto = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProduto = new DevExpress.XtraEditors.TextEdit();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gdvControlProducts = new DevExpress.XtraGrid.GridControl();
            this.gridViewProducts = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.livroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtProduto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvControlProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            // 
            // colTitulo
            // 
            this.colTitulo.FieldName = "Titulo";
            this.colTitulo.Name = "colTitulo";
            this.colTitulo.Visible = true;
            this.colTitulo.VisibleIndex = 1;
            // 
            // colCategoriaId
            // 
            this.colCategoriaId.FieldName = "CategoriaId";
            this.colCategoriaId.Name = "colCategoriaId";
            this.colCategoriaId.Visible = true;
            this.colCategoriaId.VisibleIndex = 2;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnDeleteProduct);
            this.panelControl1.Controls.Add(this.btnEdit);
            this.panelControl1.Controls.Add(this.btnAddProduto);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.txtProduto);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(983, 65);
            this.panelControl1.TabIndex = 0;
            this.panelControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl1_Paint);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.ActiveBorderThickness = 1;
            this.btnDeleteProduct.ActiveCornerRadius = 20;
            this.btnDeleteProduct.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(35)))), ((int)(((byte)(51)))));
            this.btnDeleteProduct.ActiveForecolor = System.Drawing.Color.White;
            this.btnDeleteProduct.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnDeleteProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnDeleteProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteProduct.BackgroundImage")));
            this.btnDeleteProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteProduct.ButtonText = "Remover";
            this.btnDeleteProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteProduct.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProduct.ForeColor = System.Drawing.Color.White;
            this.btnDeleteProduct.IdleBorderThickness = 1;
            this.btnDeleteProduct.IdleCornerRadius = 20;
            this.btnDeleteProduct.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(79)))), ((int)(((byte)(76)))));
            this.btnDeleteProduct.IdleForecolor = System.Drawing.Color.White;
            this.btnDeleteProduct.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnDeleteProduct.Location = new System.Drawing.Point(863, 14);
            this.btnDeleteProduct.Margin = new System.Windows.Forms.Padding(5);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(108, 46);
            this.btnDeleteProduct.TabIndex = 165;
            this.btnDeleteProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.ActiveBorderThickness = 1;
            this.btnEdit.ActiveCornerRadius = 20;
            this.btnEdit.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(168)))), ((int)(((byte)(0)))));
            this.btnEdit.ActiveForecolor = System.Drawing.Color.White;
            this.btnEdit.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.BackgroundImage")));
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.ButtonText = "Editar";
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.IdleBorderThickness = 1;
            this.btnEdit.IdleCornerRadius = 20;
            this.btnEdit.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.btnEdit.IdleForecolor = System.Drawing.Color.White;
            this.btnEdit.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnEdit.Location = new System.Drawing.Point(752, 15);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(108, 46);
            this.btnEdit.TabIndex = 164;
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAddProduto
            // 
            this.btnAddProduto.ActiveBorderThickness = 1;
            this.btnAddProduto.ActiveCornerRadius = 20;
            this.btnAddProduto.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(132)))));
            this.btnAddProduto.ActiveForecolor = System.Drawing.Color.White;
            this.btnAddProduto.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(132)))));
            this.btnAddProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnAddProduto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddProduto.BackgroundImage")));
            this.btnAddProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddProduto.ButtonText = "Adicionar";
            this.btnAddProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProduto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduto.ForeColor = System.Drawing.Color.White;
            this.btnAddProduto.IdleBorderThickness = 1;
            this.btnAddProduto.IdleCornerRadius = 20;
            this.btnAddProduto.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            this.btnAddProduto.IdleForecolor = System.Drawing.Color.White;
            this.btnAddProduto.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            this.btnAddProduto.Location = new System.Drawing.Point(642, 16);
            this.btnAddProduto.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddProduto.Name = "btnAddProduto";
            this.btnAddProduto.Size = new System.Drawing.Size(108, 46);
            this.btnAddProduto.TabIndex = 163;
            this.btnAddProduto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddProduto.Click += new System.EventHandler(this.btnAddProduto_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(8, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 23);
            this.label2.TabIndex = 74;
            this.label2.Text = "Produto";
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(98, 11);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.txtProduto.Properties.Appearance.Options.UseFont = true;
            this.txtProduto.Size = new System.Drawing.Size(206, 26);
            this.txtProduto.TabIndex = 73;
            this.txtProduto.EditValueChanged += new System.EventHandler(this.txtProduto_EditValueChanged);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gdvControlProducts);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 65);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(983, 636);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gdvControlProducts
            // 
            this.gdvControlProducts.Location = new System.Drawing.Point(12, 12);
            this.gdvControlProducts.MainView = this.gridViewProducts;
            this.gdvControlProducts.Name = "gdvControlProducts";
            this.gdvControlProducts.Size = new System.Drawing.Size(959, 612);
            this.gdvControlProducts.TabIndex = 8;
            this.gdvControlProducts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewProducts});
            this.gdvControlProducts.Click += new System.EventHandler(this.gdvControlProducts_Click);
            // 
            // gridViewProducts
            // 
            this.gridViewProducts.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn12,
            this.gridColumn13,
            this.gridColumn14,
            this.gridColumn15,
            this.gridColumn16,
            this.gridColumn7});
            this.gridViewProducts.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.gridViewProducts.GridControl = this.gdvControlProducts;
            this.gridViewProducts.Name = "gridViewProducts";
            this.gridViewProducts.OptionsBehavior.Editable = false;
            this.gridViewProducts.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewProducts.OptionsView.ShowGroupPanel = false;
            this.gridViewProducts.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            this.gridViewProducts.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Id";
            this.gridColumn3.FieldName = "Id";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            this.gridColumn3.Width = 90;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Descricao";
            this.gridColumn8.FieldName = "Descricao";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 1;
            this.gridColumn8.Width = 90;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Preco";
            this.gridColumn9.DisplayFormat.FormatString = "F2";
            this.gridColumn9.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn9.FieldName = "Preco1";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 2;
            this.gridColumn9.Width = 96;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Armazem";
            this.gridColumn10.FieldName = "stock";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 4;
            this.gridColumn10.Width = 90;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Categoria";
            this.gridColumn12.FieldName = "Category";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 5;
            this.gridColumn12.Width = 90;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "Tipo de Artigo";
            this.gridColumn13.FieldName = "tipo_artigo";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 6;
            this.gridColumn13.Width = 90;
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "Data de Expiração";
            this.gridColumn14.FieldName = "Data";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 7;
            this.gridColumn14.Width = 90;
            // 
            // gridColumn15
            // 
            this.gridColumn15.Caption = "Quantidade";
            this.gridColumn15.FieldName = "Stock";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 8;
            this.gridColumn15.Width = 139;
            // 
            // gridColumn16
            // 
            this.gridColumn16.Caption = " Ref Stock";
            this.gridColumn16.FieldName = "Id_Stock";
            this.gridColumn16.Name = "gridColumn16";
            this.gridColumn16.Visible = true;
            this.gridColumn16.VisibleIndex = 9;
            this.gridColumn16.Width = 88;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Preco C/IVA";
            this.gridColumn7.DisplayFormat.FormatString = "F2";
            this.gridColumn7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn7.FieldName = "Preco1CIVA";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 3;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(983, 636);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gdvControlProducts;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(963, 616);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Código";
            this.gridColumn1.FieldName = "Id";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.AllowFocus = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Armazem";
            this.gridColumn2.FieldName = "Armazem";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.AllowFocus = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.OptionsColumn.AllowFocus = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 4;
            // 
            // FrmProdutoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 701);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.panelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmProdutoView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.FrmProdutoView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.livroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtProduto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdvControlProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource livroBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colTitulo;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoriaId;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl gdvControlProducts;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewProducts;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtProduto;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDeleteProduct;
        private Bunifu.Framework.UI.BunifuThinButton2 btnEdit;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAddProduto;
    }
}