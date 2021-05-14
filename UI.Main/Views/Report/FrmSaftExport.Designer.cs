namespace UI.Main.Views.Report
{
    partial class FrmSaftExport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSaftExport));
            this.dtpDataFim = new System.Windows.Forms.DateTimePicker();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dtpDataInicio = new System.Windows.Forms.DateTimePicker();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtFileName = new DevExpress.XtraEditors.TextEdit();
            this.txtPasta = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnSalvar = new DevExpress.XtraEditors.SimpleButton();
            this.btnPath = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.txtFileName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPasta.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDataFim
            // 
            this.dtpDataFim.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.dtpDataFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFim.Location = new System.Drawing.Point(325, 94);
            this.dtpDataFim.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtpDataFim.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtpDataFim.Name = "dtpDataFim";
            this.dtpDataFim.Size = new System.Drawing.Size(186, 27);
            this.dtpDataFim.TabIndex = 73;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(325, 65);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(88, 23);
            this.labelControl3.TabIndex = 74;
            this.labelControl3.Text = "Data Fim";
            // 
            // dtpDataInicio
            // 
            this.dtpDataInicio.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.dtpDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicio.Location = new System.Drawing.Point(107, 94);
            this.dtpDataInicio.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtpDataInicio.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtpDataInicio.Name = "dtpDataInicio";
            this.dtpDataInicio.Size = new System.Drawing.Size(186, 27);
            this.dtpDataInicio.TabIndex = 72;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(107, 65);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(105, 23);
            this.labelControl2.TabIndex = 75;
            this.labelControl2.Text = "Data Inicio";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(107, 178);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(142, 21);
            this.labelControl1.TabIndex = 76;
            this.labelControl1.Text = "Nome do ficheiro";
            // 
            // txtFileName
            // 
            this.txtFileName.EditValue = "SellerSaft";
            this.txtFileName.Location = new System.Drawing.Point(107, 205);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtFileName.Properties.Appearance.Options.UseFont = true;
            this.txtFileName.Size = new System.Drawing.Size(404, 26);
            this.txtFileName.TabIndex = 71;
            // 
            // txtPasta
            // 
            this.txtPasta.EditValue = "C:\\SellerSaft";
            this.txtPasta.Enabled = false;
            this.txtPasta.Location = new System.Drawing.Point(107, 273);
            this.txtPasta.Name = "txtPasta";
            this.txtPasta.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.txtPasta.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtPasta.Properties.Appearance.Options.UseBackColor = true;
            this.txtPasta.Properties.Appearance.Options.UseFont = true;
            this.txtPasta.Size = new System.Drawing.Size(368, 26);
            this.txtPasta.TabIndex = 71;
            this.txtPasta.DoubleClick += new System.EventHandler(this.txtPasta_DoubleClick);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(107, 246);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(138, 21);
            this.labelControl4.TabIndex = 76;
            this.labelControl4.Text = "Salvar na pasta:";
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
            this.btnSalvar.Location = new System.Drawing.Point(388, 321);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(123, 36);
            this.btnSalvar.TabIndex = 102;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(482, 272);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(29, 27);
            this.btnPath.TabIndex = 103;
            this.btnPath.Text = "...";
            this.btnPath.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // FrmSaftExport
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 397);
            this.Controls.Add(this.btnPath);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.dtpDataFim);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.dtpDataInicio);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtPasta);
            this.Controls.Add(this.txtFileName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSaftExport";
            this.Text = "Exportar Saft";
            ((System.ComponentModel.ISupportInitialize)(this.txtFileName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPasta.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDataFim;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.DateTimePicker dtpDataInicio;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtFileName;
        private DevExpress.XtraEditors.TextEdit txtPasta;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton btnSalvar;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}