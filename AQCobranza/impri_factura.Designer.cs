namespace AQCobranza
{
    partial class impri_factura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(impri_factura));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.Factura1 = new AQCobranza.Factura();
            this.txtcomprobante = new DevExpress.XtraEditors.TextEdit();
            this.dSAQCobranza = new AQCobranza.DSAQCobranza();
            this.view_ComprobanteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_ComprobanteTableAdapter = new AQCobranza.DSAQCobranzaTableAdapters.View_ComprobanteTableAdapter();
            this.tableAdapterManager = new AQCobranza.DSAQCobranzaTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtcomprobante.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAQCobranza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_ComprobanteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImage = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImage")));
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.groupControl2);
            this.groupControl1.Controls.Add(this.txtcomprobante);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(816, 423);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Imprimir Factura";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(24, 50);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(69, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Comprobante:";
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.CaptionImage = ((System.Drawing.Image)(resources.GetObject("groupControl2.CaptionImage")));
            this.groupControl2.Controls.Add(this.crystalReportViewer1);
            this.groupControl2.Location = new System.Drawing.Point(13, 73);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(791, 338);
            this.groupControl2.TabIndex = 2;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.CachedPageNumberPerDoc = 10;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(2, 23);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.Factura1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(787, 313);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // txtcomprobante
            // 
            this.txtcomprobante.Enabled = false;
            this.txtcomprobante.Location = new System.Drawing.Point(134, 42);
            this.txtcomprobante.Name = "txtcomprobante";
            this.txtcomprobante.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txtcomprobante.Properties.Appearance.Options.UseFont = true;
            this.txtcomprobante.Size = new System.Drawing.Size(201, 26);
            this.txtcomprobante.TabIndex = 0;
            // 
            // dSAQCobranza
            // 
            this.dSAQCobranza.DataSetName = "DSAQCobranza";
            this.dSAQCobranza.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view_ComprobanteBindingSource
            // 
            this.view_ComprobanteBindingSource.DataMember = "View_Comprobante";
            this.view_ComprobanteBindingSource.DataSource = this.dSAQCobranza;
            // 
            // view_ComprobanteTableAdapter
            // 
            this.view_ComprobanteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AcabadosTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BancosTableAdapter = null;
            this.tableAdapterManager.CChica_EgresoTableAdapter = null;
            this.tableAdapterManager.CChica_IngresoTableAdapter = null;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.Cuenta_bancosTableAdapter = null;
            this.tableAdapterManager.Dep_BancosTableAdapter = null;
            this.tableAdapterManager.Documento_pagoTableAdapter = null;
            this.tableAdapterManager.ERP_empresaTableAdapter = null;
            this.tableAdapterManager.Header_cotizaTableAdapter = null;
            this.tableAdapterManager.Header_GremisionTableAdapter = null;
            this.tableAdapterManager.Header_PagoTableAdapter = null;
            this.tableAdapterManager.ImpresionesTableAdapter = null;
            this.tableAdapterManager.MaterialTableAdapter = null;
            this.tableAdapterManager.Orden_de_CompraTableAdapter = null;
            this.tableAdapterManager.Unidad_MedidaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AQCobranza.DSAQCobranzaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            // 
            // impri_factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 423);
            this.Controls.Add(this.groupControl1);
            this.Name = "impri_factura";
            this.Text = "Imprimir Factura";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.impri_factura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtcomprobante.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAQCobranza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_ComprobanteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtcomprobante;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private Factura Factura1;
        public DevExpress.XtraEditors.GroupControl groupControl2;
        private DSAQCobranza dSAQCobranza;
        private System.Windows.Forms.BindingSource view_ComprobanteBindingSource;
        private DSAQCobranzaTableAdapters.View_ComprobanteTableAdapter view_ComprobanteTableAdapter;
        private DSAQCobranzaTableAdapters.TableAdapterManager tableAdapterManager;
    }
}