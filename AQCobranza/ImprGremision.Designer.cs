namespace AQCobranza
{
    partial class ImprGremision
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImprGremision));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txtCod_Gremision = new DevExpress.XtraEditors.TextEdit();
            this.DSAQCobranza = new AQCobranza.DSAQCobranza();
            this.View_Guia_remisionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.View_Guia_remisionTableAdapter = new AQCobranza.DSAQCobranzaTableAdapters.View_Guia_remisionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCod_Gremision.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSAQCobranza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.View_Guia_remisionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImage = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImage")));
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.groupControl2);
            this.groupControl1.Controls.Add(this.txtCod_Gremision);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(723, 378);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Imprimir Guía";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(24, 50);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(76, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Codigo de Guía:";
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
            this.groupControl2.Size = new System.Drawing.Size(698, 293);
            this.groupControl2.TabIndex = 2;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.View_Guia_remisionBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AQCobranza.Impr.Guia_rem.imprGremision.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(2, 21);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(694, 270);
            this.reportViewer1.TabIndex = 1;
            // 
            // txtCod_Gremision
            // 
            this.txtCod_Gremision.Enabled = false;
            this.txtCod_Gremision.Location = new System.Drawing.Point(134, 42);
            this.txtCod_Gremision.Name = "txtCod_Gremision";
            this.txtCod_Gremision.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txtCod_Gremision.Properties.Appearance.Options.UseFont = true;
            this.txtCod_Gremision.Size = new System.Drawing.Size(201, 26);
            this.txtCod_Gremision.TabIndex = 0;
            // 
            // DSAQCobranza
            // 
            this.DSAQCobranza.DataSetName = "DSAQCobranza";
            this.DSAQCobranza.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // View_Guia_remisionBindingSource
            // 
            this.View_Guia_remisionBindingSource.DataMember = "View_Guia_remision";
            this.View_Guia_remisionBindingSource.DataSource = this.DSAQCobranza;
            // 
            // View_Guia_remisionTableAdapter
            // 
            this.View_Guia_remisionTableAdapter.ClearBeforeFill = true;
            // 
            // ImprGremision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 378);
            this.Controls.Add(this.groupControl1);
            this.Name = "ImprGremision";
            this.Text = "Impresión de Guía";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ImprGremision_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtCod_Gremision.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSAQCobranza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.View_Guia_remisionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DevExpress.XtraEditors.TextEdit txtCod_Gremision;
        private System.Windows.Forms.BindingSource View_Guia_remisionBindingSource;
        private DSAQCobranza DSAQCobranza;
        private DSAQCobranzaTableAdapters.View_Guia_remisionTableAdapter View_Guia_remisionTableAdapter;
    }
}