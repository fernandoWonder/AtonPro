namespace UI.Main.Views.PDV
{
    partial class FrmPdv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPdv));
            this.jDragControl1 = new JDragControl.JDragControl(this.components);
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.jImageButton1 = new JImageButton.JImageButton();
            this.jTextBox1 = new JTextBox.JTextBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // jDragControl1
            // 
            this.jDragControl1.GetForm = this;
            // 
            // tabPane1
            // 
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Controls.Add(this.tabNavigationPage2);
            this.tabPane1.Location = new System.Drawing.Point(12, 12);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1,
            this.tabNavigationPage2});
            this.tabPane1.RegularSize = new System.Drawing.Size(946, 473);
            this.tabPane1.SelectedPage = this.tabNavigationPage2;
            this.tabPane1.Size = new System.Drawing.Size(946, 473);
            this.tabPane1.TabIndex = 5;
            this.tabPane1.Text = "tabPane1";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Appearance.BackColor = System.Drawing.Color.White;
            this.tabNavigationPage1.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.tabNavigationPage1.Appearance.Options.UseBackColor = true;
            this.tabNavigationPage1.Appearance.Options.UseFont = true;
            this.tabNavigationPage1.Caption = "Produtos";
            this.tabNavigationPage1.Controls.Add(this.jImageButton1);
            this.tabNavigationPage1.Controls.Add(this.jTextBox1);
            this.tabNavigationPage1.Controls.Add(this.gridControl1);
            this.tabNavigationPage1.Controls.Add(this.pictureBox1);
            this.tabNavigationPage1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(946, 446);
            // 
            // jImageButton1
            // 
            this.jImageButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.jImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.jImageButton1.CausesValidation = false;
            this.jImageButton1.Cursor = System.Windows.Forms.Cursors.Default;
            this.jImageButton1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("jImageButton1.ErrorImage")));
            this.jImageButton1.Image = global::UI.Main.Properties.Resources.close;
            this.jImageButton1.ImageHover = null;
            this.jImageButton1.InitialImage = null;
            this.jImageButton1.Location = new System.Drawing.Point(914, 3);
            this.jImageButton1.Name = "jImageButton1";
            this.jImageButton1.Size = new System.Drawing.Size(29, 31);
            this.jImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.jImageButton1.TabIndex = 4;
            this.jImageButton1.Zoom = 4;
            // 
            // jTextBox1
            // 
            this.jTextBox1.AutoSize = true;
            this.jTextBox1.BorderColor = System.Drawing.Color.Silver;
            this.jTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.jTextBox1.Hint = "Produto";
            this.jTextBox1.IsPassword = false;
            this.jTextBox1.Length = 0;
            this.jTextBox1.Location = new System.Drawing.Point(1, 8);
            this.jTextBox1.Name = "jTextBox1";
            this.jTextBox1.OnFocus = System.Drawing.Color.DarkGray;
            this.jTextBox1.OnlyChar = false;
            this.jTextBox1.OnlyNumber = false;
            this.jTextBox1.Size = new System.Drawing.Size(403, 41);
            this.jTextBox1.TabIndex = 3;
            this.jTextBox1.TextValue = "Produto";
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.gridControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.gridControl1.Location = new System.Drawing.Point(4, 206);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(400, 200);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.Caption = "Finalizar Vrnda";
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.Size = new System.Drawing.Size(946, 446);
            // 
            // FrmPdv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(970, 497);
            this.Controls.Add(this.tabPane1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.Name = "FrmPdv";
            this.Text = "FrmPdv";
            this.Load += new System.EventHandler(this.FrmPdv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            this.tabNavigationPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private JDragControl.JDragControl jDragControl1;
        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private JImageButton.JImageButton jImageButton1;
        private JTextBox.JTextBox jTextBox1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
    }
}