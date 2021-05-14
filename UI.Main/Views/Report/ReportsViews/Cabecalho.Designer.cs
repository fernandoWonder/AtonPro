namespace UI.Main.Views.Report.ReportsViews
{
    partial class Cabecalho
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrPictureBox2 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrLabel96 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel95 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel94 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel93 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel91 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel90 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel89 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel87 = new DevExpress.XtraReports.UI.XRLabel();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.DataCompany = new DevExpress.DataAccess.ObjectBinding.ObjectDataSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DataCompany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPictureBox2,
            this.xrLabel96,
            this.xrLabel95,
            this.xrLabel94,
            this.xrLabel93,
            this.xrLabel91,
            this.xrLabel90,
            this.xrLabel89,
            this.xrLabel87});
            this.Detail.HeightF = 116.4584F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrPictureBox2
            // 
            this.xrPictureBox2.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource(global::UI.Main.Properties.Resources.team, true);
            this.xrPictureBox2.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 0F);
            this.xrPictureBox2.Name = "xrPictureBox2";
            this.xrPictureBox2.SizeF = new System.Drawing.SizeF(106.9583F, 115.8334F);
            this.xrPictureBox2.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            // 
            // xrLabel96
            // 
            this.xrLabel96.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.xrLabel96.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel96.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Empresa]")});
            this.xrLabel96.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.xrLabel96.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.xrLabel96.LocationFloat = new DevExpress.Utils.PointFloat(123.9583F, 0F);
            this.xrLabel96.Multiline = true;
            this.xrLabel96.Name = "xrLabel96";
            this.xrLabel96.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel96.SizeF = new System.Drawing.SizeF(661.0417F, 23F);
            this.xrLabel96.StylePriority.UseBorderColor = false;
            this.xrLabel96.StylePriority.UseBorders = false;
            this.xrLabel96.StylePriority.UseFont = false;
            this.xrLabel96.StylePriority.UseForeColor = false;
            this.xrLabel96.Text = "FENITECH";
            // 
            // xrLabel95
            // 
            this.xrLabel95.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.xrLabel95.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel95.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.xrLabel95.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.xrLabel95.LocationFloat = new DevExpress.Utils.PointFloat(123.9583F, 25.99999F);
            this.xrLabel95.Multiline = true;
            this.xrLabel95.Name = "xrLabel95";
            this.xrLabel95.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel95.SizeF = new System.Drawing.SizeF(661.0417F, 14F);
            this.xrLabel95.StylePriority.UseBorderColor = false;
            this.xrLabel95.StylePriority.UseBorders = false;
            this.xrLabel95.StylePriority.UseFont = false;
            this.xrLabel95.StylePriority.UseForeColor = false;
            this.xrLabel95.Text = "Empresa de tecnologias e soluçoes para seus problemas";
            // 
            // xrLabel94
            // 
            this.xrLabel94.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.xrLabel94.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel94.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Email]")});
            this.xrLabel94.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.xrLabel94.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.xrLabel94.LocationFloat = new DevExpress.Utils.PointFloat(123.9583F, 77.99999F);
            this.xrLabel94.Multiline = true;
            this.xrLabel94.Name = "xrLabel94";
            this.xrLabel94.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel94.SizeF = new System.Drawing.SizeF(258.9584F, 14F);
            this.xrLabel94.StylePriority.UseBorderColor = false;
            this.xrLabel94.StylePriority.UseBorders = false;
            this.xrLabel94.StylePriority.UseFont = false;
            this.xrLabel94.StylePriority.UseForeColor = false;
            this.xrLabel94.Text = "Email: FETICH@gmail.com";
            this.xrLabel94.TextFormatString = "Email: {0}";
            // 
            // xrLabel93
            // 
            this.xrLabel93.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.xrLabel93.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel93.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[UrlSite]")});
            this.xrLabel93.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.xrLabel93.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.xrLabel93.LocationFloat = new DevExpress.Utils.PointFloat(394.3748F, 77.99997F);
            this.xrLabel93.Multiline = true;
            this.xrLabel93.Name = "xrLabel93";
            this.xrLabel93.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel93.SizeF = new System.Drawing.SizeF(390.6252F, 14.00002F);
            this.xrLabel93.StylePriority.UseBorderColor = false;
            this.xrLabel93.StylePriority.UseBorders = false;
            this.xrLabel93.StylePriority.UseFont = false;
            this.xrLabel93.StylePriority.UseForeColor = false;
            this.xrLabel93.Text = "www.wonderfndsf.com";
            this.xrLabel93.TextFormatString = "Site: {0}";
            // 
            // xrLabel91
            // 
            this.xrLabel91.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.xrLabel91.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel91.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Tel] / [Tel1]")});
            this.xrLabel91.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.xrLabel91.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.xrLabel91.LocationFloat = new DevExpress.Utils.PointFloat(394.3748F, 60.00001F);
            this.xrLabel91.Multiline = true;
            this.xrLabel91.Name = "xrLabel91";
            this.xrLabel91.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel91.SizeF = new System.Drawing.SizeF(390.6252F, 14F);
            this.xrLabel91.StylePriority.UseBorderColor = false;
            this.xrLabel91.StylePriority.UseBorders = false;
            this.xrLabel91.StylePriority.UseFont = false;
            this.xrLabel91.StylePriority.UseForeColor = false;
            this.xrLabel91.Text = "Telefone: 923423423";
            this.xrLabel91.TextFormatString = "Telefones: {0}";
            // 
            // xrLabel90
            // 
            this.xrLabel90.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.xrLabel90.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel90.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Nif]")});
            this.xrLabel90.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.xrLabel90.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.xrLabel90.LocationFloat = new DevExpress.Utils.PointFloat(123.9583F, 60F);
            this.xrLabel90.Multiline = true;
            this.xrLabel90.Name = "xrLabel90";
            this.xrLabel90.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel90.SizeF = new System.Drawing.SizeF(258.9584F, 14F);
            this.xrLabel90.StylePriority.UseBorderColor = false;
            this.xrLabel90.StylePriority.UseBorders = false;
            this.xrLabel90.StylePriority.UseFont = false;
            this.xrLabel90.StylePriority.UseForeColor = false;
            this.xrLabel90.Text = "NIF: 4322342443";
            this.xrLabel90.TextFormatString = "NIF: {0}";
            // 
            // xrLabel89
            // 
            this.xrLabel89.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.xrLabel89.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel89.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Empresa]")});
            this.xrLabel89.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.xrLabel89.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.xrLabel89.LocationFloat = new DevExpress.Utils.PointFloat(123.9583F, 43F);
            this.xrLabel89.Multiline = true;
            this.xrLabel89.Name = "xrLabel89";
            this.xrLabel89.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel89.SizeF = new System.Drawing.SizeF(661.0417F, 14F);
            this.xrLabel89.StylePriority.UseBorderColor = false;
            this.xrLabel89.StylePriority.UseBorders = false;
            this.xrLabel89.StylePriority.UseFont = false;
            this.xrLabel89.StylePriority.UseForeColor = false;
            this.xrLabel89.Text = "Endereço: RUA DO SHOPPING, MAIANGA";
            this.xrLabel89.TextFormatString = "Endereço: {0}";
            // 
            // xrLabel87
            // 
            this.xrLabel87.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Cidade].[Cidade]")});
            this.xrLabel87.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel87.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.xrLabel87.LocationFloat = new DevExpress.Utils.PointFloat(123.9583F, 101.8334F);
            this.xrLabel87.Multiline = true;
            this.xrLabel87.Name = "xrLabel87";
            this.xrLabel87.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel87.SizeF = new System.Drawing.SizeF(249.25F, 14F);
            this.xrLabel87.StylePriority.UseFont = false;
            this.xrLabel87.StylePriority.UseForeColor = false;
            this.xrLabel87.StylePriority.UseTextAlignment = false;
            this.xrLabel87.Text = "Luanda - Angola";
            this.xrLabel87.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrLabel87.TextFormatString = "{0} - Angola";
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 0F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 0.4165649F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // DataCompany
            // 
            this.DataCompany.DataSource = typeof(Domain.Domain.Entities.Company);
            this.DataCompany.Name = "DataCompany";
            // 
            // Cabecalho
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.DataCompany});
            this.DataSource = this.DataCompany;
            this.Margins = new System.Drawing.Printing.Margins(48, 17, 0, 0);
            this.Version = "19.1";
            ((System.ComponentModel.ISupportInitialize)(this.DataCompany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBox2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel96;
        private DevExpress.XtraReports.UI.XRLabel xrLabel95;
        private DevExpress.XtraReports.UI.XRLabel xrLabel94;
        private DevExpress.XtraReports.UI.XRLabel xrLabel93;
        private DevExpress.XtraReports.UI.XRLabel xrLabel91;
        private DevExpress.XtraReports.UI.XRLabel xrLabel90;
        private DevExpress.XtraReports.UI.XRLabel xrLabel89;
        private DevExpress.DataAccess.ObjectBinding.ObjectDataSource DataCompany;
        private DevExpress.XtraReports.UI.XRLabel xrLabel87;
    }
}
