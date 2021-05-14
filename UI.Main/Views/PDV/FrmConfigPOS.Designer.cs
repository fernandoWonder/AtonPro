namespace UI.Main.Views.PDV
{
    partial class FrmConfigPOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfigPOS));
            this.cmbUser = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmbSerie = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cmbAccounts = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cmbPaymentMechanism = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnAddConfig = new DevExpress.XtraEditors.SimpleButton();
            this.gdvControlConfig = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSalvar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.cmbUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSerie.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAccounts.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPaymentMechanism.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvControlConfig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbUser
            // 
            this.cmbUser.EditValue = "Usuário";
            this.cmbUser.Location = new System.Drawing.Point(23, 44);
            this.cmbUser.Name = "cmbUser";
            this.cmbUser.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.cmbUser.Properties.Appearance.Options.UseFont = true;
            this.cmbUser.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbUser.Properties.Items.AddRange(new object[] {
            "Usuário"});
            this.cmbUser.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbUser.Size = new System.Drawing.Size(330, 30);
            this.cmbUser.TabIndex = 95;
            this.cmbUser.SelectedIndexChanged += new System.EventHandler(this.cmbUser_SelectedIndexChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(23, 17);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 21);
            this.labelControl1.TabIndex = 96;
            this.labelControl1.Text = "Usuário";
            // 
            // cmbSerie
            // 
            this.cmbSerie.Location = new System.Drawing.Point(359, 44);
            this.cmbSerie.Name = "cmbSerie";
            this.cmbSerie.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.cmbSerie.Properties.Appearance.Options.UseFont = true;
            this.cmbSerie.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbSerie.Properties.Items.AddRange(new object[] {
            "Usuário"});
            this.cmbSerie.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbSerie.Size = new System.Drawing.Size(210, 30);
            this.cmbSerie.TabIndex = 95;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(359, 17);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(38, 21);
            this.labelControl2.TabIndex = 96;
            this.labelControl2.Text = "Série";
            // 
            // cmbAccounts
            // 
            this.cmbAccounts.Location = new System.Drawing.Point(23, 130);
            this.cmbAccounts.Name = "cmbAccounts";
            this.cmbAccounts.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.cmbAccounts.Properties.Appearance.Options.UseFont = true;
            this.cmbAccounts.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbAccounts.Properties.Items.AddRange(new object[] {
            "Usuário"});
            this.cmbAccounts.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbAccounts.Size = new System.Drawing.Size(258, 30);
            this.cmbAccounts.TabIndex = 95;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(23, 103);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(110, 21);
            this.labelControl3.TabIndex = 96;
            this.labelControl3.Text = "Caixa/Conta";
            // 
            // cmbPaymentMechanism
            // 
            this.cmbPaymentMechanism.Location = new System.Drawing.Point(287, 130);
            this.cmbPaymentMechanism.Name = "cmbPaymentMechanism";
            this.cmbPaymentMechanism.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.cmbPaymentMechanism.Properties.Appearance.Options.UseFont = true;
            this.cmbPaymentMechanism.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbPaymentMechanism.Properties.Items.AddRange(new object[] {
            "Usuário"});
            this.cmbPaymentMechanism.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbPaymentMechanism.Size = new System.Drawing.Size(241, 30);
            this.cmbPaymentMechanism.TabIndex = 95;
            this.cmbPaymentMechanism.SelectedIndexChanged += new System.EventHandler(this.cmbPaymentMechanism_SelectedIndexChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(287, 103);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(183, 21);
            this.labelControl4.TabIndex = 96;
            this.labelControl4.Text = "Forma de Pagamento";
            // 
            // btnAddConfig
            // 
            this.btnAddConfig.Appearance.BackColor = System.Drawing.Color.White;
            this.btnAddConfig.Appearance.BackColor2 = System.Drawing.Color.White;
            this.btnAddConfig.Appearance.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnAddConfig.Appearance.Options.UseBackColor = true;
            this.btnAddConfig.Appearance.Options.UseFont = true;
            this.btnAddConfig.Appearance.Options.UseTextOptions = true;
            this.btnAddConfig.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnAddConfig.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnAddConfig.AppearanceDisabled.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddConfig.AppearanceDisabled.Options.UseBackColor = true;
            this.btnAddConfig.AppearanceDisabled.Options.UseFont = true;
            this.btnAddConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddConfig.ImageOptions.SvgImage = global::UI.Main.Properties.Resources.actions_addcircled;
            this.btnAddConfig.Location = new System.Drawing.Point(534, 131);
            this.btnAddConfig.Name = "btnAddConfig";
            this.btnAddConfig.Size = new System.Drawing.Size(35, 29);
            this.btnAddConfig.TabIndex = 99;
            this.btnAddConfig.Click += new System.EventHandler(this.btnAddConfig_Click);
            // 
            // gdvControlConfig
            // 
            this.gdvControlConfig.Location = new System.Drawing.Point(23, 166);
            this.gdvControlConfig.MainView = this.gridView1;
            this.gdvControlConfig.Name = "gdvControlConfig";
            this.gdvControlConfig.Size = new System.Drawing.Size(546, 129);
            this.gdvControlConfig.TabIndex = 100;
            this.gdvControlConfig.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn1});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.GridControl = this.gdvControlConfig;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Forma_de_Pagamento";
            this.gridColumn2.FieldName = "PaymentMechanism.FormaPagamento";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 146;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Conta";
            this.gridColumn3.FieldName = "CurrentAccount.Descricao";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 379;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Id";
            this.gridColumn1.FieldName = "Id";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnSalvar.Appearance.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.btnSalvar.Appearance.Options.UseBackColor = true;
            this.btnSalvar.Appearance.Options.UseFont = true;
            this.btnSalvar.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnSalvar.AppearanceDisabled.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.AppearanceDisabled.Options.UseBackColor = true;
            this.btnSalvar.AppearanceDisabled.Options.UseFont = true;
            this.btnSalvar.Location = new System.Drawing.Point(430, 339);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(139, 43);
            this.btnSalvar.TabIndex = 101;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(3, 301);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(549, 23);
            this.labelControl5.TabIndex = 96;
            this.labelControl5.Text = "Por enquanto o usuário poderá usar qualquer armazem";
            this.labelControl5.Visible = false;
            // 
            // FrmConfigPOS
            // 
            this.ActiveGlowColor = System.Drawing.Color.Red;
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 394);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.gdvControlConfig);
            this.Controls.Add(this.btnAddConfig);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.cmbPaymentMechanism);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cmbAccounts);
            this.Controls.Add(this.cmbSerie);
            this.Controls.Add(this.cmbUser);
            this.Controls.Add(this.labelControl5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConfigPOS";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuração POS";
            ((System.ComponentModel.ISupportInitialize)(this.cmbUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSerie.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAccounts.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPaymentMechanism.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvControlConfig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit cmbUser;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cmbSerie;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ComboBoxEdit cmbAccounts;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ComboBoxEdit cmbPaymentMechanism;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton btnAddConfig;
        private DevExpress.XtraGrid.GridControl gdvControlConfig;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.SimpleButton btnSalvar;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}