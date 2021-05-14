namespace UI.Main.Views.Configs
{
    partial class FrmCurrentAccountConfigs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCurrentAccountConfigs));
            this.cbPaymentMechanism = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmbAccount = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cbPaymentMechanism.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAccount.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cbPaymentMechanism
            // 
            this.cbPaymentMechanism.EditValue = "";
            this.cbPaymentMechanism.Location = new System.Drawing.Point(34, 49);
            this.cbPaymentMechanism.Name = "cbPaymentMechanism";
            this.cbPaymentMechanism.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cbPaymentMechanism.Properties.Appearance.Options.UseFont = true;
            this.cbPaymentMechanism.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbPaymentMechanism.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbPaymentMechanism.Size = new System.Drawing.Size(334, 26);
            this.cbPaymentMechanism.TabIndex = 92;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.Location = new System.Drawing.Point(34, 22);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(183, 21);
            this.labelControl6.TabIndex = 91;
            this.labelControl6.Text = "Forma de Pagamento";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(421, 22);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(54, 21);
            this.labelControl1.TabIndex = 91;
            this.labelControl1.Text = "Conta";
            // 
            // cmbAccount
            // 
            this.cmbAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbAccount.EditValue = "";
            this.cmbAccount.Location = new System.Drawing.Point(421, 49);
            this.cmbAccount.Name = "cmbAccount";
            this.cmbAccount.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cmbAccount.Properties.Appearance.Options.UseFont = true;
            this.cmbAccount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbAccount.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbAccount.Size = new System.Drawing.Size(277, 26);
            this.cmbAccount.TabIndex = 92;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Appearance.BackColor = System.Drawing.Color.White;
            this.btnSave.Appearance.BackColor2 = System.Drawing.Color.White;
            this.btnSave.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseBackColor = true;
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.btnSave.AppearanceDisabled.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.AppearanceDisabled.Options.UseBackColor = true;
            this.btnSave.AppearanceDisabled.Options.UseFont = true;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.ImageOptions.Image = global::UI.Main.Properties.Resources.Save_48px;
            this.btnSave.Location = new System.Drawing.Point(560, 96);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(138, 43);
            this.btnSave.TabIndex = 94;
            this.btnSave.Text = "SALVAR";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(30, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(682, 133);
            this.label1.TabIndex = 95;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // FrmCurrentAccountConfigs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 457);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbAccount);
            this.Controls.Add(this.cbPaymentMechanism);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl6);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCurrentAccountConfigs";
            this.Text = "Configurar Contas";
            ((System.ComponentModel.ISupportInitialize)(this.cbPaymentMechanism.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAccount.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit cbPaymentMechanism;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cmbAccount;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private System.Windows.Forms.Label label1;
    }
}