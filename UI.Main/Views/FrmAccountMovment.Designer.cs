namespace UI.Main.Views
{
    partial class FrmAccountMovment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAccountMovment));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.cmbMovmentType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.searchLUpAccountDestin = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.searchLUpAccount = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtSaldoAtual = new DevExpress.XtraEditors.TextEdit();
            this.txtSaldo = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnSalvar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMovmentType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLUpAccountDestin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLUpAccount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaldoAtual.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaldo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.panelControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(663, 359);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.btnSalvar);
            this.panelControl1.Controls.Add(this.txtDescricao);
            this.panelControl1.Controls.Add(this.cmbMovmentType);
            this.panelControl1.Controls.Add(this.searchLUpAccountDestin);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.searchLUpAccount);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.txtSaldoAtual);
            this.panelControl1.Controls.Add(this.txtSaldo);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(639, 335);
            this.panelControl1.TabIndex = 5;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtDescricao.Location = new System.Drawing.Point(23, 189);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(353, 102);
            this.txtDescricao.TabIndex = 107;
            // 
            // cmbMovmentType
            // 
            this.cmbMovmentType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbMovmentType.Location = new System.Drawing.Point(335, 111);
            this.cmbMovmentType.Name = "cmbMovmentType";
            this.cmbMovmentType.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.cmbMovmentType.Properties.Appearance.Options.UseFont = true;
            this.cmbMovmentType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbMovmentType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbMovmentType.Size = new System.Drawing.Size(268, 28);
            this.cmbMovmentType.TabIndex = 106;
            // 
            // searchLUpAccountDestin
            // 
            this.searchLUpAccountDestin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchLUpAccountDestin.EditValue = "1";
            this.searchLUpAccountDestin.EnterMoveNextControl = true;
            this.searchLUpAccountDestin.Location = new System.Drawing.Point(335, 40);
            this.searchLUpAccountDestin.Name = "searchLUpAccountDestin";
            this.searchLUpAccountDestin.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.searchLUpAccountDestin.Properties.Appearance.Options.UseFont = true;
            this.searchLUpAccountDestin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search)});
            this.searchLUpAccountDestin.Properties.DisplayMember = "Descricao";
            this.searchLUpAccountDestin.Properties.NullText = "Conta destino";
            this.searchLUpAccountDestin.Properties.PopupView = this.gridView1;
            this.searchLUpAccountDestin.Size = new System.Drawing.Size(268, 26);
            this.searchLUpAccountDestin.TabIndex = 105;
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(335, 13);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(121, 21);
            this.labelControl2.TabIndex = 103;
            this.labelControl2.Text = "Conta Destino";
            // 
            // searchLUpAccount
            // 
            this.searchLUpAccount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchLUpAccount.EditValue = "1";
            this.searchLUpAccount.EnterMoveNextControl = true;
            this.searchLUpAccount.Location = new System.Drawing.Point(23, 40);
            this.searchLUpAccount.Name = "searchLUpAccount";
            this.searchLUpAccount.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.searchLUpAccount.Properties.Appearance.Options.UseFont = true;
            this.searchLUpAccount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search)});
            this.searchLUpAccount.Properties.DisplayMember = "Descricao";
            this.searchLUpAccount.Properties.NullText = "Conta a retirar";
            this.searchLUpAccount.Properties.PopupView = this.gridView2;
            this.searchLUpAccount.Size = new System.Drawing.Size(293, 26);
            this.searchLUpAccount.TabIndex = 105;
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(23, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(54, 21);
            this.labelControl1.TabIndex = 103;
            this.labelControl1.Text = "Conta";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(335, 84);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(161, 21);
            this.labelControl3.TabIndex = 103;
            this.labelControl3.Text = "Tipo de movimento";
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(23, 162);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(84, 21);
            this.labelControl4.TabIndex = 103;
            this.labelControl4.Text = "Descrição";
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.Location = new System.Drawing.Point(23, 86);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(95, 21);
            this.labelControl6.TabIndex = 103;
            this.labelControl6.Text = "Saldo atual";
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(180, 86);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(117, 21);
            this.labelControl5.TabIndex = 103;
            this.labelControl5.Text = "Saldo a retirar";
            // 
            // txtSaldoAtual
            // 
            this.txtSaldoAtual.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSaldoAtual.EditValue = "0";
            this.txtSaldoAtual.Location = new System.Drawing.Point(23, 113);
            this.txtSaldoAtual.Name = "txtSaldoAtual";
            this.txtSaldoAtual.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtSaldoAtual.Properties.Appearance.Options.UseFont = true;
            this.txtSaldoAtual.Properties.Mask.EditMask = "d3";
            this.txtSaldoAtual.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtSaldoAtual.Properties.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.txtSaldoAtual.Size = new System.Drawing.Size(139, 26);
            this.txtSaldoAtual.TabIndex = 7;
            this.txtSaldoAtual.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
            // 
            // txtSaldo
            // 
            this.txtSaldo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSaldo.EditValue = "0";
            this.txtSaldo.Location = new System.Drawing.Point(180, 113);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtSaldo.Properties.Appearance.Options.UseFont = true;
            this.txtSaldo.Properties.Mask.EditMask = "d3";
            this.txtSaldo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtSaldo.Properties.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.txtSaldo.Size = new System.Drawing.Size(136, 26);
            this.txtSaldo.TabIndex = 7;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(663, 359);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.panelControl1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(643, 339);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSalvar.Appearance.BackColor = System.Drawing.Color.White;
            this.btnSalvar.Appearance.BackColor2 = System.Drawing.Color.White;
            this.btnSalvar.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Appearance.Options.UseBackColor = true;
            this.btnSalvar.Appearance.Options.UseFont = true;
            this.btnSalvar.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnSalvar.AppearanceDisabled.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.AppearanceDisabled.Options.UseBackColor = true;
            this.btnSalvar.AppearanceDisabled.Options.UseFont = true;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.ImageOptions.Image = global::UI.Main.Properties.Resources.Save_48px;
            this.btnSalvar.Location = new System.Drawing.Point(465, 247);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(138, 44);
            this.btnSalvar.TabIndex = 108;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // FrmAccountMovment
            // 
            this.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 359);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAccountMovment";
            this.Text = "Movimentação de saldo";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMovmentType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLUpAccountDestin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLUpAccount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaldoAtual.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaldo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.TextEdit txtSaldo;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLUpAccountDestin;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLUpAccount;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cmbMovmentType;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.TextBox txtDescricao;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton btnSalvar;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtSaldoAtual;
    }
}