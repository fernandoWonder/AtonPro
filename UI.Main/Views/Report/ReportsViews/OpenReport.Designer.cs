namespace UI.Main.Views.Report.ReportsViews
{
    partial class OpenReport
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
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrlblCompany = new DevExpress.XtraReports.UI.XRLabel();
            this.xrlblNif = new DevExpress.XtraReports.UI.XRLabel();
            this.xrlblTel = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblUser = new DevExpress.XtraReports.UI.XRLabel();
            this.lblDataHora = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblValor = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 27F;
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel12,
            this.lblUser});
            this.BottomMargin.HeightF = 39.04168F;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel3,
            this.xrLabel1,
            this.lblValor});
            this.Detail.HeightF = 119.2917F;
            this.Detail.Name = "Detail";
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblDataHora,
            this.xrlblCompany,
            this.xrlblNif,
            this.xrlblTel});
            this.ReportHeader.Name = "ReportHeader";
            // 
            // xrlblCompany
            // 
            this.xrlblCompany.Font = new System.Drawing.Font("Arial Narrow", 14.5F, System.Drawing.FontStyle.Bold);
            this.xrlblCompany.LocationFloat = new DevExpress.Utils.PointFloat(18.28473F, 0F);
            this.xrlblCompany.Name = "xrlblCompany";
            this.xrlblCompany.SizeF = new System.Drawing.SizeF(140.7153F, 24.19433F);
            this.xrlblCompany.StylePriority.UseFont = false;
            this.xrlblCompany.StylePriority.UseTextAlignment = false;
            this.xrlblCompany.Text = "Nome Empresa";
            this.xrlblCompany.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrlblNif
            // 
            this.xrlblNif.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
            this.xrlblNif.LocationFloat = new DevExpress.Utils.PointFloat(18.28473F, 24.19432F);
            this.xrlblNif.Multiline = true;
            this.xrlblNif.Name = "xrlblNif";
            this.xrlblNif.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrlblNif.SizeF = new System.Drawing.SizeF(140.7153F, 15.70832F);
            this.xrlblNif.StylePriority.UseFont = false;
            this.xrlblNif.StylePriority.UseTextAlignment = false;
            this.xrlblNif.Text = "NIF: 238444354653";
            this.xrlblNif.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrlblTel
            // 
            this.xrlblTel.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
            this.xrlblTel.LocationFloat = new DevExpress.Utils.PointFloat(18.28473F, 39.90258F);
            this.xrlblTel.Multiline = true;
            this.xrlblTel.Name = "xrlblTel";
            this.xrlblTel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrlblTel.SizeF = new System.Drawing.SizeF(140.7153F, 17.79165F);
            this.xrlblTel.StylePriority.UseFont = false;
            this.xrlblTel.StylePriority.UseTextAlignment = false;
            this.xrlblTel.Text = "Tel: 923 827 772";
            this.xrlblTel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel12
            // 
            this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(0F, 3.468164F);
            this.xrLabel12.Multiline = true;
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel12.SizeF = new System.Drawing.SizeF(84.16376F, 15.70833F);
            this.xrLabel12.Text = "Operador (a):";
            // 
            // lblUser
            // 
            this.lblUser.Font = new System.Drawing.Font("Arial", 8.75F);
            this.lblUser.LocationFloat = new DevExpress.Utils.PointFloat(84.16376F, 3.468164F);
            this.lblUser.Multiline = true;
            this.lblUser.Name = "lblUser";
            this.lblUser.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 20, 0, 0, 100F);
            this.lblUser.SizeF = new System.Drawing.SizeF(79.83624F, 15.70833F);
            this.lblUser.StylePriority.UseFont = false;
            this.lblUser.StylePriority.UsePadding = false;
            this.lblUser.StylePriority.UseTextAlignment = false;
            this.lblUser.Text = "Fernando";
            this.lblUser.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // lblDataHora
            // 
            this.lblDataHora.LocationFloat = new DevExpress.Utils.PointFloat(0F, 77F);
            this.lblDataHora.Multiline = true;
            this.lblDataHora.Name = "lblDataHora";
            this.lblDataHora.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblDataHora.SizeF = new System.Drawing.SizeF(137.0834F, 23F);
            this.lblDataHora.Text = "10/02/2022 18:30";
            // 
            // xrLabel3
            // 
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(18.28473F, 36.66666F);
            this.xrLabel3.Multiline = true;
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(137.0834F, 23F);
            this.xrLabel3.Text = "Abertura de Caixa\r\n";
            // 
            // xrLabel1
            // 
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(37.08339F, 62.08331F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.xrLabel1.Text = "Total de Caixa";
            // 
            // lblValor
            // 
            this.lblValor.LocationFloat = new DevExpress.Utils.PointFloat(37.08337F, 85.08333F);
            this.lblValor.Multiline = true;
            this.lblValor.Name = "lblValor";
            this.lblValor.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblValor.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.lblValor.StylePriority.UseTextAlignment = false;
            this.lblValor.Text = "0,00";
            this.lblValor.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // OpenReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail,
            this.ReportHeader});
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(9, 6, 27, 39);
            this.PageWidth = 189;
            this.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            this.PaperName = "Custom";
            this.Version = "19.1";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRLabel xrlblCompany;
        private DevExpress.XtraReports.UI.XRLabel xrlblNif;
        private DevExpress.XtraReports.UI.XRLabel xrlblTel;
        private DevExpress.XtraReports.UI.XRLabel xrLabel12;
        private DevExpress.XtraReports.UI.XRLabel lblUser;
        private DevExpress.XtraReports.UI.XRLabel lblDataHora;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel lblValor;
    }
}
