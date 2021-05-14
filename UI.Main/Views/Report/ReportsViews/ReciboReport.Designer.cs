namespace UI.Main.Views.Report.ReportsViews
{
    partial class ReciboReport
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
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrSubreportCompany = new DevExpress.XtraReports.UI.XRSubreport();
            this.xrSubreportPayments = new DevExpress.XtraReports.UI.XRSubreport();
            this.GroupHeader2 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrLine11 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabel59 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel104 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel101 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel98 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel105 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine12 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabel86 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel85 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel84 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel83 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabelDataImpressao = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabel44 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine7 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine6 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabel45 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel67 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel68 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel64 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine2 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabelExtenso = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine5 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabel30 = new DevExpress.XtraReports.UI.XRLabel();
            this.DataSourceRecibo = new DevExpress.DataAccess.ObjectBinding.ObjectDataSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DataSourceRecibo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 34.62499F;
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 32.00003F;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrSubreportPayments});
            this.Detail.HeightF = 40.5817F;
            this.Detail.Name = "Detail";
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrSubreportCompany});
            this.PageHeader.HeightF = 120.04F;
            this.PageHeader.Name = "PageHeader";
            // 
            // xrSubreportCompany
            // 
            this.xrSubreportCompany.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrSubreportCompany.Name = "xrSubreportCompany";
            this.xrSubreportCompany.SizeF = new System.Drawing.SizeF(802F, 120.04F);
            // 
            // xrSubreportPayments
            // 
            this.xrSubreportPayments.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrSubreportPayments.Name = "xrSubreportPayments";
            this.xrSubreportPayments.SizeF = new System.Drawing.SizeF(802F, 40.5817F);
            // 
            // GroupHeader2
            // 
            this.GroupHeader2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine11,
            this.xrLabel59,
            this.xrLabel104,
            this.xrLabel101,
            this.xrLabel98,
            this.xrLabel105,
            this.xrLine12,
            this.xrLabel86,
            this.xrLabel85,
            this.xrLabel84,
            this.xrLabel83,
            this.xrLabelDataImpressao,
            this.xrLabel12});
            this.GroupHeader2.HeightF = 125.1264F;
            this.GroupHeader2.Name = "GroupHeader2";
            // 
            // xrLine11
            // 
            this.xrLine11.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLine11.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.xrLine11.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLine11.Name = "xrLine11";
            this.xrLine11.SizeF = new System.Drawing.SizeF(802.0003F, 9.874821F);
            this.xrLine11.StylePriority.UseBorderDashStyle = false;
            // 
            // xrLabel59
            // 
            this.xrLabel59.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Documento].[Cliente].[Cliente]")});
            this.xrLabel59.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel59.LocationFloat = new DevExpress.Utils.PointFloat(2.499962F, 12.91653F);
            this.xrLabel59.Multiline = true;
            this.xrLabel59.Name = "xrLabel59";
            this.xrLabel59.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel59.SizeF = new System.Drawing.SizeF(337.6669F, 23F);
            this.xrLabel59.StylePriority.UseFont = false;
            this.xrLabel59.TextFormatString = "Cliente: {0}";
            // 
            // xrLabel104
            // 
            this.xrLabel104.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Documento].[Cliente].[Email]")});
            this.xrLabel104.Font = new System.Drawing.Font("Arial", 9.8F);
            this.xrLabel104.LocationFloat = new DevExpress.Utils.PointFloat(2.499965F, 52.91653F);
            this.xrLabel104.Multiline = true;
            this.xrLabel104.Name = "xrLabel104";
            this.xrLabel104.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel104.SizeF = new System.Drawing.SizeF(337.6669F, 17F);
            this.xrLabel104.StylePriority.UseFont = false;
            this.xrLabel104.TextFormatString = "Email: {0}";
            // 
            // xrLabel101
            // 
            this.xrLabel101.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Documento].[Cliente].[Tel]")});
            this.xrLabel101.Font = new System.Drawing.Font("Arial", 9.8F);
            this.xrLabel101.LocationFloat = new DevExpress.Utils.PointFloat(460.3333F, 35.91653F);
            this.xrLabel101.Multiline = true;
            this.xrLabel101.Name = "xrLabel101";
            this.xrLabel101.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel101.SizeF = new System.Drawing.SizeF(337.6669F, 15F);
            this.xrLabel101.StylePriority.UseFont = false;
            this.xrLabel101.TextFormatString = "Telefone: {0}";
            // 
            // xrLabel98
            // 
            this.xrLabel98.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Documento].[Cliente].[Nif]")});
            this.xrLabel98.Font = new System.Drawing.Font("Arial", 9.8F);
            this.xrLabel98.LocationFloat = new DevExpress.Utils.PointFloat(2.499962F, 35.91653F);
            this.xrLabel98.Multiline = true;
            this.xrLabel98.Name = "xrLabel98";
            this.xrLabel98.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel98.SizeF = new System.Drawing.SizeF(337.6669F, 17F);
            this.xrLabel98.StylePriority.UseFont = false;
            this.xrLabel98.TextFormatString = "NIF: {0}";
            // 
            // xrLabel105
            // 
            this.xrLabel105.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Documento].[Cliente].[Endereco]")});
            this.xrLabel105.Font = new System.Drawing.Font("Arial", 9.8F);
            this.xrLabel105.LocationFloat = new DevExpress.Utils.PointFloat(460.3333F, 12.91653F);
            this.xrLabel105.Multiline = true;
            this.xrLabel105.Name = "xrLabel105";
            this.xrLabel105.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel105.SizeF = new System.Drawing.SizeF(337.6669F, 17.99998F);
            this.xrLabel105.StylePriority.UseFont = false;
            this.xrLabel105.TextFormatString = "Endereço: {0}";
            // 
            // xrLine12
            // 
            this.xrLine12.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLine12.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.xrLine12.LocationFloat = new DevExpress.Utils.PointFloat(0F, 69.91653F);
            this.xrLine12.Name = "xrLine12";
            this.xrLine12.SizeF = new System.Drawing.SizeF(802.0003F, 9.874821F);
            this.xrLine12.StylePriority.UseBorderDashStyle = false;
            // 
            // xrLabel86
            // 
            this.xrLabel86.BorderColor = System.Drawing.Color.Gray;
            this.xrLabel86.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Documento].[TipoDocumento].[Descricao]")});
            this.xrLabel86.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.xrLabel86.LocationFloat = new DevExpress.Utils.PointFloat(0F, 79.79134F);
            this.xrLabel86.Multiline = true;
            this.xrLabel86.Name = "xrLabel86";
            this.xrLabel86.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel86.SizeF = new System.Drawing.SizeF(330.5415F, 18F);
            this.xrLabel86.StylePriority.UseBorderColor = false;
            this.xrLabel86.StylePriority.UseFont = false;
            this.xrLabel86.StylePriority.UseTextAlignment = false;
            this.xrLabel86.Text = "FACTURA";
            this.xrLabel86.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel85
            // 
            this.xrLabel85.BorderColor = System.Drawing.Color.Gray;
            this.xrLabel85.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Documento].[InvoiceNo]")});
            this.xrLabel85.Font = new System.Drawing.Font("Arial", 10.4F, System.Drawing.FontStyle.Bold);
            this.xrLabel85.LocationFloat = new DevExpress.Utils.PointFloat(0F, 100.7913F);
            this.xrLabel85.Multiline = true;
            this.xrLabel85.Name = "xrLabel85";
            this.xrLabel85.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel85.SizeF = new System.Drawing.SizeF(330.5415F, 17.00008F);
            this.xrLabel85.StylePriority.UseBorderColor = false;
            this.xrLabel85.StylePriority.UseFont = false;
            this.xrLabel85.StylePriority.UseTextAlignment = false;
            this.xrLabel85.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel84
            // 
            this.xrLabel84.BorderColor = System.Drawing.Color.Gray;
            this.xrLabel84.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel84.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel84.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel84.LocationFloat = new DevExpress.Utils.PointFloat(351.9997F, 79.79135F);
            this.xrLabel84.Multiline = true;
            this.xrLabel84.Name = "xrLabel84";
            this.xrLabel84.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel84.SizeF = new System.Drawing.SizeF(128.1252F, 18.58337F);
            this.xrLabel84.StylePriority.UseBorderColor = false;
            this.xrLabel84.StylePriority.UseBorderDashStyle = false;
            this.xrLabel84.StylePriority.UseBorders = false;
            this.xrLabel84.StylePriority.UseFont = false;
            this.xrLabel84.Text = "Data da Factura:";
            // 
            // xrLabel83
            // 
            this.xrLabel83.BorderColor = System.Drawing.Color.Gray;
            this.xrLabel83.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel83.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel83.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DataCadastro]")});
            this.xrLabel83.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel83.LocationFloat = new DevExpress.Utils.PointFloat(480.1249F, 79.79142F);
            this.xrLabel83.Multiline = true;
            this.xrLabel83.Name = "xrLabel83";
            this.xrLabel83.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel83.SizeF = new System.Drawing.SizeF(183.1252F, 18.58337F);
            this.xrLabel83.StylePriority.UseBorderColor = false;
            this.xrLabel83.StylePriority.UseBorderDashStyle = false;
            this.xrLabel83.StylePriority.UseBorders = false;
            this.xrLabel83.StylePriority.UseFont = false;
            this.xrLabel83.Text = "04/07/2020 12:12:21";
            this.xrLabel83.TextFormatString = "{0:dd/MM/yyyy HH:mm:ss}";
            // 
            // xrLabelDataImpressao
            // 
            this.xrLabelDataImpressao.BorderColor = System.Drawing.Color.Gray;
            this.xrLabelDataImpressao.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabelDataImpressao.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabelDataImpressao.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabelDataImpressao.LocationFloat = new DevExpress.Utils.PointFloat(480.1249F, 100.7913F);
            this.xrLabelDataImpressao.Multiline = true;
            this.xrLabelDataImpressao.Name = "xrLabelDataImpressao";
            this.xrLabelDataImpressao.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabelDataImpressao.SizeF = new System.Drawing.SizeF(183.1252F, 18.58337F);
            this.xrLabelDataImpressao.StylePriority.UseBorderColor = false;
            this.xrLabelDataImpressao.StylePriority.UseBorderDashStyle = false;
            this.xrLabelDataImpressao.StylePriority.UseBorders = false;
            this.xrLabelDataImpressao.StylePriority.UseFont = false;
            this.xrLabelDataImpressao.Text = "04/07/2020 12:12:21";
            this.xrLabelDataImpressao.TextFormatString = "{0:dd/MM/yyyy HH:mm:ss}";
            // 
            // xrLabel12
            // 
            this.xrLabel12.BorderColor = System.Drawing.Color.Gray;
            this.xrLabel12.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel12.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel12.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(351.9997F, 100.7913F);
            this.xrLabel12.Multiline = true;
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel12.SizeF = new System.Drawing.SizeF(128.1252F, 18.58337F);
            this.xrLabel12.StylePriority.UseBorderColor = false;
            this.xrLabel12.StylePriority.UseBorderDashStyle = false;
            this.xrLabel12.StylePriority.UseBorders = false;
            this.xrLabel12.StylePriority.UseFont = false;
            this.xrLabel12.Text = "Data da Impressão:";
            // 
            // PageFooter
            // 
            this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine1,
            this.xrLabel44,
            this.xrLine7,
            this.xrLine6,
            this.xrLabel45,
            this.xrLabel67,
            this.xrLabel68,
            this.xrLabel64,
            this.xrLine2,
            this.xrLabelExtenso,
            this.xrLine5,
            this.xrLabel30});
            this.PageFooter.HeightF = 110.125F;
            this.PageFooter.Name = "PageFooter";
            // 
            // xrLine1
            // 
            this.xrLine1.BorderWidth = 1F;
            this.xrLine1.ForeColor = System.Drawing.Color.Gray;
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 5F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(783F, 2.083333F);
            this.xrLine1.StylePriority.UseBorderWidth = false;
            this.xrLine1.StylePriority.UseForeColor = false;
            // 
            // xrLabel44
            // 
            this.xrLabel44.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel44.LocationFloat = new DevExpress.Utils.PointFloat(496.6252F, 12.08333F);
            this.xrLabel44.Multiline = true;
            this.xrLabel44.Name = "xrLabel44";
            this.xrLabel44.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel44.SizeF = new System.Drawing.SizeF(112.4999F, 17.00002F);
            this.xrLabel44.StylePriority.UseFont = false;
            this.xrLabel44.StylePriority.UseTextAlignment = false;
            this.xrLabel44.Text = "TOTAL:";
            this.xrLabel44.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            // 
            // xrLine7
            // 
            this.xrLine7.BorderWidth = 1F;
            this.xrLine7.ForeColor = System.Drawing.Color.Gray;
            this.xrLine7.LocationFloat = new DevExpress.Utils.PointFloat(496.6253F, 29.08334F);
            this.xrLine7.Name = "xrLine7";
            this.xrLine7.SizeF = new System.Drawing.SizeF(296.3748F, 2.083336F);
            this.xrLine7.StylePriority.UseBorderWidth = false;
            this.xrLine7.StylePriority.UseForeColor = false;
            // 
            // xrLine6
            // 
            this.xrLine6.BorderWidth = 1F;
            this.xrLine6.ForeColor = System.Drawing.Color.Gray;
            this.xrLine6.LocationFloat = new DevExpress.Utils.PointFloat(496.6252F, 10F);
            this.xrLine6.Name = "xrLine6";
            this.xrLine6.SizeF = new System.Drawing.SizeF(296.3749F, 2.083336F);
            this.xrLine6.StylePriority.UseBorderWidth = false;
            this.xrLine6.StylePriority.UseForeColor = false;
            // 
            // xrLabel45
            // 
            this.xrLabel45.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TotalRecibo]")});
            this.xrLabel45.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel45.LocationFloat = new DevExpress.Utils.PointFloat(631.1252F, 12.08327F);
            this.xrLabel45.Multiline = true;
            this.xrLabel45.Name = "xrLabel45";
            this.xrLabel45.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel45.RightToLeft = DevExpress.XtraReports.UI.RightToLeft.Yes;
            this.xrLabel45.SizeF = new System.Drawing.SizeF(161.8749F, 17.00002F);
            this.xrLabel45.StylePriority.UseFont = false;
            this.xrLabel45.StylePriority.UseTextAlignment = false;
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrLabel45.Summary = xrSummary1;
            this.xrLabel45.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            this.xrLabel45.TextFormatString = "{0:n2}";
            // 
            // xrLabel67
            // 
            this.xrLabel67.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Documento].[User].[Nome]")});
            this.xrLabel67.Font = new System.Drawing.Font("Arial", 9F);
            this.xrLabel67.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 31.16659F);
            this.xrLabel67.Multiline = true;
            this.xrLabel67.Name = "xrLabel67";
            this.xrLabel67.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel67.SizeF = new System.Drawing.SizeF(233.6036F, 15.41664F);
            this.xrLabel67.StylePriority.UseFont = false;
            this.xrLabel67.StylePriority.UseTextAlignment = false;
            this.xrLabel67.Text = "José Eduardo Chico";
            this.xrLabel67.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel68
            // 
            this.xrLabel68.Font = new System.Drawing.Font("Arial", 9F);
            this.xrLabel68.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 13.75001F);
            this.xrLabel68.Multiline = true;
            this.xrLabel68.Name = "xrLabel68";
            this.xrLabel68.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel68.SizeF = new System.Drawing.SizeF(233.6036F, 17.41665F);
            this.xrLabel68.StylePriority.UseFont = false;
            this.xrLabel68.StylePriority.UseTextAlignment = false;
            this.xrLabel68.Text = "Operador de Conta:";
            this.xrLabel68.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel64
            // 
            this.xrLabel64.Font = new System.Drawing.Font("Arial", 8F);
            this.xrLabel64.LocationFloat = new DevExpress.Utils.PointFloat(0F, 75.45897F);
            this.xrLabel64.Multiline = true;
            this.xrLabel64.Name = "xrLabel64";
            this.xrLabel64.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel64.SizeF = new System.Drawing.SizeF(802.0001F, 11.54169F);
            this.xrLabel64.StylePriority.UseFont = false;
            this.xrLabel64.StylePriority.UseTextAlignment = false;
            this.xrLabel64.Text = "Este documento não serve de fatura.\r\n";
            this.xrLabel64.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLine2
            // 
            this.xrLine2.BorderWidth = 1F;
            this.xrLine2.LineWidth = 1.5F;
            this.xrLine2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 64.91737F);
            this.xrLine2.Name = "xrLine2";
            this.xrLine2.SizeF = new System.Drawing.SizeF(802.0001F, 10.54166F);
            this.xrLine2.StylePriority.UseBorderWidth = false;
            // 
            // xrLabelExtenso
            // 
            this.xrLabelExtenso.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", ""),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "")});
            this.xrLabelExtenso.Font = new System.Drawing.Font("Arial", 8F);
            this.xrLabelExtenso.LocationFloat = new DevExpress.Utils.PointFloat(7.947286E-06F, 52.33402F);
            this.xrLabelExtenso.Multiline = true;
            this.xrLabelExtenso.Name = "xrLabelExtenso";
            this.xrLabelExtenso.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabelExtenso.SizeF = new System.Drawing.SizeF(802F, 12.58334F);
            this.xrLabelExtenso.StylePriority.UseFont = false;
            this.xrLabelExtenso.StylePriority.UseTextAlignment = false;
            this.xrLabelExtenso.Text = "Preco por extenso";
            this.xrLabelExtenso.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLine5
            // 
            this.xrLine5.BorderWidth = 1F;
            this.xrLine5.LineWidth = 1.5F;
            this.xrLine5.LocationFloat = new DevExpress.Utils.PointFloat(0F, 87.00066F);
            this.xrLine5.Name = "xrLine5";
            this.xrLine5.SizeF = new System.Drawing.SizeF(802.0001F, 6.541656F);
            this.xrLine5.StylePriority.UseBorderWidth = false;
            // 
            // xrLabel30
            // 
            this.xrLabel30.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Documento].[HashPositions]")});
            this.xrLabel30.Font = new System.Drawing.Font("Arial", 8F);
            this.xrLabel30.LocationFloat = new DevExpress.Utils.PointFloat(0F, 93.54227F);
            this.xrLabel30.Multiline = true;
            this.xrLabel30.Name = "xrLabel30";
            this.xrLabel30.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel30.SizeF = new System.Drawing.SizeF(802.0003F, 13.58272F);
            this.xrLabel30.StylePriority.UseFont = false;
            this.xrLabel30.Text = "Câmbio: 1,00";
            // 
            // DataSourceRecibo
            // 
            this.DataSourceRecibo.DataSource = typeof(Domain.Domain.Entities.Documents.Recibo);
            this.DataSourceRecibo.Name = "DataSourceRecibo";
            // 
            // ReciboReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail,
            this.PageHeader,
            this.GroupHeader2,
            this.PageFooter});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.DataSourceRecibo});
            this.DataSource = this.DataSourceRecibo;
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(17, 30, 35, 32);
            this.Version = "19.1";
            ((System.ComponentModel.ISupportInitialize)(this.DataSourceRecibo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.XRSubreport xrSubreportCompany;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader2;
        private DevExpress.XtraReports.UI.XRLine xrLine11;
        private DevExpress.XtraReports.UI.XRLabel xrLabel59;
        private DevExpress.XtraReports.UI.XRLabel xrLabel104;
        private DevExpress.XtraReports.UI.XRLabel xrLabel101;
        private DevExpress.XtraReports.UI.XRLabel xrLabel98;
        private DevExpress.XtraReports.UI.XRLabel xrLabel105;
        private DevExpress.XtraReports.UI.XRLine xrLine12;
        private DevExpress.XtraReports.UI.XRLabel xrLabel86;
        private DevExpress.XtraReports.UI.XRLabel xrLabel85;
        private DevExpress.XtraReports.UI.XRLabel xrLabel84;
        private DevExpress.XtraReports.UI.XRLabel xrLabel83;
        private DevExpress.XtraReports.UI.XRLabel xrLabelDataImpressao;
        private DevExpress.XtraReports.UI.XRLabel xrLabel12;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private DevExpress.XtraReports.UI.XRLabel xrLabel64;
        private DevExpress.XtraReports.UI.XRLine xrLine2;
        private DevExpress.XtraReports.UI.XRLabel xrLabelExtenso;
        private DevExpress.XtraReports.UI.XRLine xrLine5;
        private DevExpress.XtraReports.UI.XRLabel xrLabel30;
        private DevExpress.XtraReports.UI.XRLabel xrLabel67;
        private DevExpress.XtraReports.UI.XRLabel xrLabel68;
        private DevExpress.XtraReports.UI.XRLine xrLine1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel44;
        private DevExpress.XtraReports.UI.XRLine xrLine7;
        private DevExpress.XtraReports.UI.XRLine xrLine6;
        private DevExpress.XtraReports.UI.XRLabel xrLabel45;
        private DevExpress.DataAccess.ObjectBinding.ObjectDataSource DataSourceRecibo;
        private DevExpress.XtraReports.UI.XRSubreport xrSubreportPayments;
    }
}
