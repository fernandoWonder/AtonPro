namespace UI.Main.Views.Report.ReportsViews
{
    partial class MotivosIsencaoReport
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
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine4 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.DataSourceMotivos = new DevExpress.DataAccess.ObjectBinding.ObjectDataSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DataSourceMotivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 0F;
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 0F;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel5,
            this.xrLabel3,
            this.xrLabel9,
            this.xrLabel10});
            this.Detail.HeightF = 16.00003F;
            this.Detail.Name = "Detail";
            this.Detail.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.Detail_BeforePrint);
            // 
            // xrLabel5
            // 
            this.xrLabel5.BorderColor = System.Drawing.Color.LightGray;
            this.xrLabel5.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Motivo]")});
            this.xrLabel5.Font = new System.Drawing.Font("Arial", 8F);
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(228.8751F, 0F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(284.9168F, 16.00003F);
            this.xrLabel5.StylePriority.UseBorderColor = false;
            this.xrLabel5.StylePriority.UseBorders = false;
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.Text = "Artigo";
            this.xrLabel5.WordWrap = false;
            // 
            // xrLabel3
            // 
            this.xrLabel3.BorderColor = System.Drawing.Color.LightGray;
            this.xrLabel3.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel3.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Taxa]")});
            this.xrLabel3.Font = new System.Drawing.Font("Arial", 8F);
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(4F, 0F);
            this.xrLabel3.Multiline = true;
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(75.62501F, 16.00003F);
            this.xrLabel3.StylePriority.UseBorderColor = false;
            this.xrLabel3.StylePriority.UseBorderDashStyle = false;
            this.xrLabel3.StylePriority.UseBorders = false;
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.Text = "Artigo";
            this.xrLabel3.TextFormatString = "IVA {0:n2}";
            // 
            // xrLabel9
            // 
            this.xrLabel9.BorderColor = System.Drawing.Color.LightGray;
            this.xrLabel9.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel9.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TotalIncidencia]")});
            this.xrLabel9.Font = new System.Drawing.Font("Arial", 8F);
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(82.62502F, 0F);
            this.xrLabel9.Multiline = true;
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(73.12505F, 16.00003F);
            this.xrLabel9.StylePriority.UseBorderColor = false;
            this.xrLabel9.StylePriority.UseBorders = false;
            this.xrLabel9.StylePriority.UseFont = false;
            this.xrLabel9.Text = "Artigo";
            this.xrLabel9.TextFormatString = "{0:n2}";
            // 
            // xrLabel10
            // 
            this.xrLabel10.BorderColor = System.Drawing.Color.LightGray;
            this.xrLabel10.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel10.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TotalTaxa]")});
            this.xrLabel10.Font = new System.Drawing.Font("Arial", 8F);
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(155.7501F, 0F);
            this.xrLabel10.Multiline = true;
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel10.SizeF = new System.Drawing.SizeF(72.20824F, 16.00003F);
            this.xrLabel10.StylePriority.UseBorderColor = false;
            this.xrLabel10.StylePriority.UseBorders = false;
            this.xrLabel10.StylePriority.UseFont = false;
            this.xrLabel10.Text = "Artigo";
            this.xrLabel10.TextFormatString = "{0:n2}";
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel8,
            this.xrLabel6,
            this.xrLabel7,
            this.xrLine4,
            this.xrLabel4});
            this.ReportHeader.HeightF = 20.3334F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // xrLabel8
            // 
            this.xrLabel8.BackColor = System.Drawing.Color.Gainsboro;
            this.xrLabel8.Font = new System.Drawing.Font("Arial", 9.75F);
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(155.7501F, 0.8749981F);
            this.xrLabel8.Multiline = true;
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(70.62511F, 13.99997F);
            this.xrLabel8.StylePriority.UseBackColor = false;
            this.xrLabel8.StylePriority.UseFont = false;
            this.xrLabel8.StylePriority.UseTextAlignment = false;
            this.xrLabel8.Text = "Total";
            this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            // 
            // xrLabel6
            // 
            this.xrLabel6.BackColor = System.Drawing.Color.Gainsboro;
            this.xrLabel6.Font = new System.Drawing.Font("Arial", 9.75F);
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(80.12505F, 0.8749981F);
            this.xrLabel6.Multiline = true;
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(73.12505F, 13.99997F);
            this.xrLabel6.StylePriority.UseBackColor = false;
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            this.xrLabel6.Text = "Incid/Qtd";
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            // 
            // xrLabel7
            // 
            this.xrLabel7.BackColor = System.Drawing.Color.Gainsboro;
            this.xrLabel7.Font = new System.Drawing.Font("Arial", 9.75F);
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(228.8751F, 0.8749962F);
            this.xrLabel7.Multiline = true;
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(284.9167F, 13.99997F);
            this.xrLabel7.StylePriority.UseBackColor = false;
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.StylePriority.UseTextAlignment = false;
            this.xrLabel7.Text = "Motivo";
            this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            // 
            // xrLine4
            // 
            this.xrLine4.BorderWidth = 1F;
            this.xrLine4.LocationFloat = new DevExpress.Utils.PointFloat(3.999996F, 14.87497F);
            this.xrLine4.Name = "xrLine4";
            this.xrLine4.SizeF = new System.Drawing.SizeF(509.7918F, 5.458434F);
            this.xrLine4.StylePriority.UseBorderWidth = false;
            // 
            // xrLabel4
            // 
            this.xrLabel4.BackColor = System.Drawing.Color.Gainsboro;
            this.xrLabel4.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel4.BorderWidth = 1F;
            this.xrLabel4.Font = new System.Drawing.Font("Arial", 9.75F);
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(4F, 0.8749981F);
            this.xrLabel4.Multiline = true;
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(73.12505F, 13.99997F);
            this.xrLabel4.StylePriority.UseBackColor = false;
            this.xrLabel4.StylePriority.UseBorderDashStyle = false;
            this.xrLabel4.StylePriority.UseBorderWidth = false;
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            this.xrLabel4.Text = "Taxa";
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            // 
            // DataSourceMotivos
            // 
            this.DataSourceMotivos.DataSource = typeof(Appplication.Controller.Assistents.TabelaImposto);
            this.DataSourceMotivos.Name = "DataSourceMotivos";
            // 
            // MotivosIsencaoReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail,
            this.ReportHeader});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.DataSourceMotivos});
            this.DataSource = this.DataSourceMotivos;
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(46, 30, 0, 0);
            this.Version = "19.1";
            ((System.ComponentModel.ISupportInitialize)(this.DataSourceMotivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel9;
        private DevExpress.XtraReports.UI.XRLabel xrLabel10;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRLabel xrLabel8;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.XRLine xrLine4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.DataAccess.ObjectBinding.ObjectDataSource DataSourceMotivos;
    }
}
