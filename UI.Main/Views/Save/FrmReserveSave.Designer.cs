namespace UI.Main.Views.Save
{
    partial class FrmReserveSave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReserveSave));
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtHora = new DevExpress.XtraEditors.TextEdit();
            this.txtCliente = new DevExpress.XtraEditors.TextEdit();
            this.dateToDay = new Bunifu.Framework.UI.BunifuDatepicker();
            this.txtFone = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.dateReserve = new Bunifu.Framework.UI.BunifuDatepicker();
            this.searchLookUpTable = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtObservacoes = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHora.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpTable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacoes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            this.panel3.Controls.Add(this.bunifuImageButton2);
            this.panel3.Controls.Add(this.labelControl2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(787, 35);
            this.panel3.TabIndex = 67;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(18, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(91, 17);
            this.labelControl2.TabIndex = 119;
            this.labelControl2.Text = "Reservar Mesa";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            this.panel1.Location = new System.Drawing.Point(25, 343);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 5);
            this.panel1.TabIndex = 184;
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(36, 153);
            this.txtHora.Name = "txtHora";
            this.txtHora.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtHora.Properties.Appearance.Options.UseFont = true;
            this.txtHora.Size = new System.Drawing.Size(354, 22);
            this.txtHora.TabIndex = 187;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(36, 207);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtCliente.Properties.Appearance.Options.UseFont = true;
            this.txtCliente.Size = new System.Drawing.Size(311, 22);
            this.txtCliente.TabIndex = 189;
            // 
            // dateToDay
            // 
            this.dateToDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            this.dateToDay.BorderRadius = 0;
            this.dateToDay.Enabled = false;
            this.dateToDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateToDay.ForeColor = System.Drawing.Color.White;
            this.dateToDay.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateToDay.FormatCustom = null;
            this.dateToDay.Location = new System.Drawing.Point(426, 82);
            this.dateToDay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateToDay.Name = "dateToDay";
            this.dateToDay.Size = new System.Drawing.Size(329, 36);
            this.dateToDay.TabIndex = 191;
            this.dateToDay.Value = new System.DateTime(2010, 3, 1, 2, 42, 14, 734);
            // 
            // txtFone
            // 
            this.txtFone.Location = new System.Drawing.Point(426, 153);
            this.txtFone.Name = "txtFone";
            this.txtFone.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtFone.Properties.Appearance.Options.UseFont = true;
            this.txtFone.Size = new System.Drawing.Size(329, 22);
            this.txtFone.TabIndex = 193;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.White;
            this.simpleButton1.Appearance.BackColor2 = System.Drawing.Color.White;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseTextOptions = true;
            this.simpleButton1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.simpleButton1.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(151)))), ((int)(((byte)(250)))));
            this.simpleButton1.AppearanceDisabled.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.AppearanceDisabled.Options.UseBackColor = true;
            this.simpleButton1.AppearanceDisabled.Options.UseFont = true;
            this.simpleButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.simpleButton1.ImageOptions.SvgImage = global::UI.Main.Properties.Resources.actions_addcircled;
            this.simpleButton1.Location = new System.Drawing.Point(353, 199);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(37, 30);
            this.simpleButton1.TabIndex = 194;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // dateReserve
            // 
            this.dateReserve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            this.dateReserve.BorderRadius = 0;
            this.dateReserve.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateReserve.ForeColor = System.Drawing.Color.White;
            this.dateReserve.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateReserve.FormatCustom = null;
            this.dateReserve.Location = new System.Drawing.Point(36, 82);
            this.dateReserve.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateReserve.Name = "dateReserve";
            this.dateReserve.Size = new System.Drawing.Size(354, 36);
            this.dateReserve.TabIndex = 196;
            this.dateReserve.Value = new System.DateTime(2010, 3, 1, 2, 42, 14, 734);
            // 
            // searchLookUpTable
            // 
            this.searchLookUpTable.EditValue = "";
            this.searchLookUpTable.EnterMoveNextControl = true;
            this.searchLookUpTable.Location = new System.Drawing.Point(426, 207);
            this.searchLookUpTable.Name = "searchLookUpTable";
            this.searchLookUpTable.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.searchLookUpTable.Properties.Appearance.Options.UseFont = true;
            this.searchLookUpTable.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search)});
            this.searchLookUpTable.Properties.DisplayMember = "Mesa";
            this.searchLookUpTable.Properties.NullText = "";
            this.searchLookUpTable.Properties.PopupView = this.gridView1;
            this.searchLookUpTable.Properties.ValueMember = "Mesa";
            this.searchLookUpTable.Size = new System.Drawing.Size(329, 22);
            this.searchLookUpTable.TabIndex = 202;
            this.searchLookUpTable.EditValueChanged += new System.EventHandler(this.searchLookUpTable_EditValueChanged);
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.Location = new System.Drawing.Point(140, 286);
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtObservacoes.Properties.Appearance.Options.UseFont = true;
            this.txtObservacoes.Size = new System.Drawing.Size(615, 22);
            this.txtObservacoes.TabIndex = 203;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(33, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 205;
            this.label1.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(33, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 206;
            this.label2.Text = "Hora";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(33, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 207;
            this.label3.Text = "Data a reservar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(422, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 208;
            this.label4.Text = "Hoje";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(422, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 209;
            this.label5.Text = "Telefone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(423, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 210;
            this.label6.Text = "Mesa";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(32, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 17);
            this.label7.TabIndex = 211;
            this.label7.Text = "Observaçoes:";
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(132)))));
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.Silver;
            this.bunifuThinButton21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuThinButton21.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuThinButton21.ButtonText = "Salvar";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.DarkGray;
            this.bunifuThinButton21.Location = new System.Drawing.Point(585, 356);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(172, 48);
            this.bunifuThinButton21.TabIndex = 185;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton2.Image = global::UI.Main.Properties.Resources.Delete_64px;
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(758, 0);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(29, 32);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 121;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // FrmReserveSave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(787, 418);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtObservacoes);
            this.Controls.Add(this.searchLookUpTable);
            this.Controls.Add(this.dateReserve);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.txtFone);
            this.Controls.Add(this.dateToDay);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReserveSave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmReserveSave";
            this.Load += new System.EventHandler(this.FrmReserveSave_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHora.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpTable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacoes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.TextEdit txtHora;
        private DevExpress.XtraEditors.TextEdit txtCliente;
        private DevExpress.XtraEditors.TextEdit txtFone;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private Bunifu.Framework.UI.BunifuDatepicker dateReserve;
        private Bunifu.Framework.UI.BunifuDatepicker dateToDay;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpTable;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit txtObservacoes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}