namespace AQCobranza
{
    partial class imprCotizacion
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(imprCotizacion));
            this.ps_Cotizacion_BuscarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DSAQCobranza = new AQCobranza.DSAQCobranza();
            this.txtCod_Cotiza = new DevExpress.XtraEditors.TextEdit();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ps_Cotizacion_BuscarTableAdapter = new AQCobranza.DSAQCobranzaTableAdapters.ps_Cotizacion_BuscarTableAdapter();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.ps_Cotizacion_BuscarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSAQCobranza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCod_Cotiza.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ps_Cotizacion_BuscarBindingSource
            // 
            this.ps_Cotizacion_BuscarBindingSource.DataMember = "ps_Cotizacion_Buscar";
            this.ps_Cotizacion_BuscarBindingSource.DataSource = this.DSAQCobranza;
            // 
            // DSAQCobranza
            // 
            this.DSAQCobranza.DataSetName = "DSAQCobranza";
            this.DSAQCobranza.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtCod_Cotiza
            // 
            this.txtCod_Cotiza.Enabled = false;
            this.txtCod_Cotiza.Location = new System.Drawing.Point(134, 42);
            this.txtCod_Cotiza.Name = "txtCod_Cotiza";
            this.txtCod_Cotiza.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txtCod_Cotiza.Properties.Appearance.Options.UseFont = true;
            this.txtCod_Cotiza.Size = new System.Drawing.Size(201, 26);
            this.txtCod_Cotiza.TabIndex = 0;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ps_Cotizacion_BuscarBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AQCobranza.Impr.Cotizaciones.imprCotiza.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(2, 21);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(754, 509);
            this.reportViewer1.TabIndex = 1;
            // 
            // ps_Cotizacion_BuscarTableAdapter
            // 
            this.ps_Cotizacion_BuscarTableAdapter.ClearBeforeFill = true;
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImage = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImage")));
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.groupControl2);
            this.groupControl1.Controls.Add(this.txtCod_Cotiza);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(783, 617);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Imprimir Cotización";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(24, 50);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(104, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Codigo de Cotización:";
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.CaptionImage = ((System.Drawing.Image)(resources.GetObject("groupControl2.CaptionImage")));
            this.groupControl2.Controls.Add(this.reportViewer1);
            this.groupControl2.Location = new System.Drawing.Point(13, 73);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(758, 532);
            this.groupControl2.TabIndex = 2;
            // 
            // imprCotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 617);
            this.Controls.Add(this.groupControl1);
            this.LookAndFeel.SkinName = "Office 2013";
            this.Name = "imprCotizacion";
            this.Text = "imprCotizacion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.imprCotizacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ps_Cotizacion_BuscarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSAQCobranza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCod_Cotiza.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtCod_Cotiza;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ps_Cotizacion_BuscarBindingSource;
        private DSAQCobranza DSAQCobranza;
        private DSAQCobranzaTableAdapters.ps_Cotizacion_BuscarTableAdapter ps_Cotizacion_BuscarTableAdapter;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
    }
}