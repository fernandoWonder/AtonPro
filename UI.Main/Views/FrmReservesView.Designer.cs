namespace UI.Main.Views
{
    partial class FrmReservesView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReservesView));
            this.btnDeleteProduct = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddProduto = new DevExpress.XtraEditors.SimpleButton();
            this.gdvReserves = new DevExpress.XtraGrid.GridControl();
            this.gridViewProducts = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gdvReserves)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteProduct.Appearance.BackColor = System.Drawing.Color.White;
            this.btnDeleteProduct.Appearance.BackColor2 = System.Drawing.Color.White;
            this.btnDeleteProduct.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProduct.Appearance.Options.UseBackColor = true;
            this.btnDeleteProduct.Appearance.Options.UseFont = true;
            this.btnDeleteProduct.Appearance.Options.UseTextOptions = true;
            this.btnDeleteProduct.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnDeleteProduct.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnDeleteProduct.AppearanceDisabled.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProduct.AppearanceDisabled.Options.UseBackColor = true;
            this.btnDeleteProduct.AppearanceDisabled.Options.UseFont = true;
            this.btnDeleteProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteProduct.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDeleteProduct.ImageOptions.SvgImage")));
            this.btnDeleteProduct.Location = new System.Drawing.Point(727, 12);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(120, 30);
            this.btnDeleteProduct.TabIndex = 63;
            this.btnDeleteProduct.Text = "Remover";
            this.btnDeleteProduct.Visible = false;
            // 
            // btnAddProduto
            // 
            this.btnAddProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddProduto.Appearance.BackColor = System.Drawing.Color.White;
            this.btnAddProduto.Appearance.BackColor2 = System.Drawing.Color.White;
            this.btnAddProduto.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduto.Appearance.Options.UseBackColor = true;
            this.btnAddProduto.Appearance.Options.UseFont = true;
            this.btnAddProduto.Appearance.Options.UseTextOptions = true;
            this.btnAddProduto.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnAddProduto.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnAddProduto.AppearanceDisabled.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduto.AppearanceDisabled.Options.UseBackColor = true;
            this.btnAddProduto.AppearanceDisabled.Options.UseFont = true;
            this.btnAddProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProduto.ImageOptions.SvgImage = global::UI.Main.Properties.Resources.actions_addcircled;
            this.btnAddProduto.Location = new System.Drawing.Point(904, 12);
            this.btnAddProduto.Name = "btnAddProduto";
            this.btnAddProduto.Size = new System.Drawing.Size(120, 30);
            this.btnAddProduto.TabIndex = 62;
            this.btnAddProduto.Text = "Adicionar";
            this.btnAddProduto.Click += new System.EventHandler(this.btnAddProduto_Click);
            // 
            // gdvReserves
            // 
            this.gdvReserves.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gdvReserves.Location = new System.Drawing.Point(0, 48);
            this.gdvReserves.MainView = this.gridViewProducts;
            this.gdvReserves.Name = "gdvReserves";
            this.gdvReserves.Size = new System.Drawing.Size(1028, 518);
            this.gdvReserves.TabIndex = 61;
            this.gdvReserves.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewProducts});
            // 
            // gridViewProducts
            // 
            this.gridViewProducts.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.gridViewProducts.GridControl = this.gdvReserves;
            this.gridViewProducts.Name = "gridViewProducts";
            this.gridViewProducts.OptionsBehavior.Editable = false;
            this.gridViewProducts.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewProducts.OptionsView.ShowGroupPanel = false;
            // 
            // FrmReservesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 566);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.btnAddProduto);
            this.Controls.Add(this.gdvReserves);
            this.Name = "FrmReservesView";
            this.Text = "Reservas";
            ((System.ComponentModel.ISupportInitialize)(this.gdvReserves)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnDeleteProduct;
        private DevExpress.XtraEditors.SimpleButton btnAddProduto;
        private DevExpress.XtraGrid.GridControl gdvReserves;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewProducts;
    }
}