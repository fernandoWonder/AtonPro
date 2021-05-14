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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTitulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategoriaId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.livroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eFTeste2DataSet = new UI.Main.EFTeste2DataSet();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.livroTableAdapter = new UI.Main.EFTeste2DataSetTableAdapters.LivroTableAdapter();
            this.jTextBox1 = new JTextBox.JTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eFTeste2DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.layoutControl1.Location = new System.Drawing.Point(0, 428);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(960, 120);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(960, 120);
            this.Root.TextVisible = false;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colTitulo,
            this.colCategoriaId});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
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
            // gridControl1
            // 
            this.gridControl1.DataSource = this.livroBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 68);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(936, 451);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // livroBindingSource
            // 
            this.livroBindingSource.DataMember = "Livro";
            this.livroBindingSource.DataSource = this.eFTeste2DataSet;
            // 
            // eFTeste2DataSet
            // 
            this.eFTeste2DataSet.DataSetName = "EFTeste2DataSet";
            this.eFTeste2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.simpleButton2.AppearanceDisabled.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.AppearanceDisabled.Options.UseBackColor = true;
            this.simpleButton2.AppearanceDisabled.Options.UseFont = true;
            this.simpleButton2.Location = new System.Drawing.Point(734, 19);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(210, 43);
            this.simpleButton2.TabIndex = 46;
            this.simpleButton2.Text = "Adicionar";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // livroTableAdapter
            // 
            this.livroTableAdapter.ClearBeforeFill = true;
            // 
            // jTextBox1
            // 
            this.jTextBox1.AutoSize = true;
            this.jTextBox1.BorderColor = System.Drawing.Color.Gray;
            this.jTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.jTextBox1.Hint = "PESQUISAR";
            this.jTextBox1.IsPassword = false;
            this.jTextBox1.Length = 0;
            this.jTextBox1.Location = new System.Drawing.Point(12, 23);
            this.jTextBox1.Name = "jTextBox1";
            this.jTextBox1.OnFocus = System.Drawing.Color.DarkGray;
            this.jTextBox1.OnlyChar = false;
            this.jTextBox1.OnlyNumber = false;
            this.jTextBox1.Size = new System.Drawing.Size(252, 39);
            this.jTextBox1.TabIndex = 47;
            this.jTextBox1.TextValue = "PESQUISAR";
            // 
            // FrmProdutoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 548);
            this.Controls.Add(this.jTextBox1);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.layoutControl1);
            this.Name = "FrmProdutoView";
            this.Text = "FrmProdutoView";
            this.Load += new System.EventHandler(this.FrmProdutoView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eFTeste2DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private EFTeste2DataSet eFTeste2DataSet;
        private System.Windows.Forms.BindingSource livroBindingSource;
        private EFTeste2DataSetTableAdapters.LivroTableAdapter livroTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colTitulo;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoriaId;
        private JTextBox.JTextBox jTextBox1;
    }
}