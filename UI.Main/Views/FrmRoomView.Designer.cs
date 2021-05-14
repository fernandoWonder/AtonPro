namespace UI.Main.Views
{
    partial class FrmRoomView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRoomView));
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition1 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition2 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition3 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition1 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition2 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition3 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableSpan tableSpan1 = new DevExpress.XtraEditors.TableLayout.TableSpan();
            DevExpress.XtraEditors.TableLayout.TableSpan tableSpan2 = new DevExpress.XtraEditors.TableLayout.TableSpan();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement1 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement2 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            this.tileViewColumn1 = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.tileViewColumn2 = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.btnDeleteProduct = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddProduto = new DevExpress.XtraEditors.SimpleButton();
            this.gdvReserves = new DevExpress.XtraGrid.GridControl();
            this.tileView1 = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gdvReserves)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.SuspendLayout();
            // 
            // tileViewColumn1
            // 
            this.tileViewColumn1.Caption = "tileViewColumn1";
            this.tileViewColumn1.FieldName = "quarto";
            this.tileViewColumn1.Name = "tileViewColumn1";
            this.tileViewColumn1.Visible = true;
            this.tileViewColumn1.VisibleIndex = 0;
            // 
            // tileViewColumn2
            // 
            this.tileViewColumn2.Caption = "tileViewColumn2";
            this.tileViewColumn2.FieldName = "imagem";
            this.tileViewColumn2.Name = "tileViewColumn2";
            this.tileViewColumn2.Visible = true;
            this.tileViewColumn2.VisibleIndex = 1;
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
            this.btnDeleteProduct.Location = new System.Drawing.Point(912, 41);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(120, 30);
            this.btnDeleteProduct.TabIndex = 66;
            this.btnDeleteProduct.Text = "Remover";
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
            this.btnAddProduto.Location = new System.Drawing.Point(786, 41);
            this.btnAddProduto.Name = "btnAddProduto";
            this.btnAddProduto.Size = new System.Drawing.Size(120, 30);
            this.btnAddProduto.TabIndex = 65;
            this.btnAddProduto.Text = "Adicionar";
            this.btnAddProduto.Click += new System.EventHandler(this.btnAddProduto_Click);
            // 
            // gdvReserves
            // 
            this.gdvReserves.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gdvReserves.Location = new System.Drawing.Point(0, 77);
            this.gdvReserves.MainView = this.tileView1;
            this.gdvReserves.Name = "gdvReserves";
            this.gdvReserves.Size = new System.Drawing.Size(1044, 558);
            this.gdvReserves.TabIndex = 64;
            this.gdvReserves.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tileView1});
            // 
            // tileView1
            // 
            this.tileView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.tileViewColumn1,
            this.tileViewColumn2});
            this.tileView1.GridControl = this.gdvReserves;
            this.tileView1.Name = "tileView1";
            this.tileView1.OptionsTiles.ItemSize = new System.Drawing.Size(118, 120);
            this.tileView1.TileColumns.Add(tableColumnDefinition1);
            this.tileView1.TileColumns.Add(tableColumnDefinition2);
            this.tileView1.TileColumns.Add(tableColumnDefinition3);
            tableRowDefinition1.Length.Value = 34D;
            tableRowDefinition2.Length.Value = 50D;
            tableRowDefinition3.Length.Value = 20D;
            this.tileView1.TileRows.Add(tableRowDefinition1);
            this.tileView1.TileRows.Add(tableRowDefinition2);
            this.tileView1.TileRows.Add(tableRowDefinition3);
            tableSpan1.ColumnSpan = 3;
            tableSpan1.RowIndex = 2;
            tableSpan2.ColumnSpan = 3;
            tableSpan2.RowSpan = 2;
            this.tileView1.TileSpans.Add(tableSpan1);
            this.tileView1.TileSpans.Add(tableSpan2);
            tileViewItemElement1.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 12.25F);
            tileViewItemElement1.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement1.Column = this.tileViewColumn1;
            tileViewItemElement1.ColumnIndex = 1;
            tileViewItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement1.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement1.RowIndex = 2;
            tileViewItemElement1.Text = "tileViewColumn1";
            tileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement2.Column = this.tileViewColumn2;
            tileViewItemElement2.ImageOptions.Image = global::UI.Main.Properties.Resources.Door_40px;
            tileViewItemElement2.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement2.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch;
            tileViewItemElement2.Text = "tileViewColumn2";
            tileViewItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileView1.TileTemplate.Add(tileViewItemElement1);
            this.tileView1.TileTemplate.Add(tileViewItemElement2);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            this.panel3.Controls.Add(this.bunifuImageButton2);
            this.panel3.Controls.Add(this.labelControl2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1044, 35);
            this.panel3.TabIndex = 68;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton2.Image = global::UI.Main.Properties.Resources.Delete_64px;
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(1015, 0);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(29, 32);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 121;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(18, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(51, 17);
            this.labelControl2.TabIndex = 119;
            this.labelControl2.Text = "Quartos";
            // 
            // FrmRoomView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1044, 635);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.btnAddProduto);
            this.Controls.Add(this.gdvReserves);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRoomView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmRoomView";
            ((System.ComponentModel.ISupportInitialize)(this.gdvReserves)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnDeleteProduct;
        private DevExpress.XtraEditors.SimpleButton btnAddProduto;
        private DevExpress.XtraGrid.GridControl gdvReserves;
        private DevExpress.XtraGrid.Views.Tile.TileView tileView1;
        private DevExpress.XtraGrid.Columns.TileViewColumn tileViewColumn1;
        private DevExpress.XtraGrid.Columns.TileViewColumn tileViewColumn2;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}