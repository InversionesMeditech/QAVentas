namespace AQCobranza
{
    partial class CuadreCaja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CuadreCaja));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.header_PagoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.header_PagoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSAQCobranza = new AQCobranza.DSAQCobranza();
            this.header_PagoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.lbltotal = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtFecha = new DevExpress.XtraEditors.DateEdit();
            this.header_PagoGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Conprobante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRuc_DNI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmonto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coligv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmonto_total = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.header_PagoTableAdapter = new AQCobranza.DSAQCobranzaTableAdapters.Header_PagoTableAdapter();
            this.tableAdapterManager = new AQCobranza.DSAQCobranzaTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.header_PagoBindingNavigator)).BeginInit();
            this.header_PagoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.header_PagoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAQCobranza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFecha.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.header_PagoGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImage = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImage")));
            this.groupControl1.Controls.Add(this.splitContainerControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(636, 391);
            this.groupControl1.TabIndex = 11;
            this.groupControl1.Text = "Cuadre de Caja";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(2, 39);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl3);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.groupControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(632, 350);
            this.splitContainerControl1.SplitterPosition = 121;
            this.splitContainerControl1.TabIndex = 7;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.header_PagoBindingNavigator);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 0);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(121, 350);
            this.groupControl3.TabIndex = 0;
            // 
            // header_PagoBindingNavigator
            // 
            this.header_PagoBindingNavigator.AddNewItem = null;
            this.header_PagoBindingNavigator.BindingSource = this.header_PagoBindingSource;
            this.header_PagoBindingNavigator.CountItem = null;
            this.header_PagoBindingNavigator.DeleteItem = null;
            this.header_PagoBindingNavigator.Dock = System.Windows.Forms.DockStyle.Left;
            this.header_PagoBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.header_PagoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.header_PagoBindingNavigatorSaveItem});
            this.header_PagoBindingNavigator.Location = new System.Drawing.Point(2, 20);
            this.header_PagoBindingNavigator.MoveFirstItem = null;
            this.header_PagoBindingNavigator.MoveLastItem = null;
            this.header_PagoBindingNavigator.MoveNextItem = null;
            this.header_PagoBindingNavigator.MovePreviousItem = null;
            this.header_PagoBindingNavigator.Name = "header_PagoBindingNavigator";
            this.header_PagoBindingNavigator.PositionItem = null;
            this.header_PagoBindingNavigator.Size = new System.Drawing.Size(98, 328);
            this.header_PagoBindingNavigator.TabIndex = 12;
            this.header_PagoBindingNavigator.Text = "bindingNavigator1";
            // 
            // header_PagoBindingSource
            // 
            this.header_PagoBindingSource.DataMember = "Header_Pago";
            this.header_PagoBindingSource.DataSource = this.dSAQCobranza;
            // 
            // dSAQCobranza
            // 
            this.dSAQCobranza.DataSetName = "DSAQCobranza";
            this.dSAQCobranza.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // header_PagoBindingNavigatorSaveItem
            // 
            this.header_PagoBindingNavigatorSaveItem.Image = global::AQCobranza.Properties.Resources.saveto_32x32;
            this.header_PagoBindingNavigatorSaveItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.header_PagoBindingNavigatorSaveItem.Name = "header_PagoBindingNavigatorSaveItem";
            this.header_PagoBindingNavigatorSaveItem.Size = new System.Drawing.Size(95, 36);
            this.header_PagoBindingNavigatorSaveItem.Text = "GUARDAR";
            this.header_PagoBindingNavigatorSaveItem.Click += new System.EventHandler(this.header_PagoBindingNavigatorSaveItem_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.CaptionImage = ((System.Drawing.Image)(resources.GetObject("groupControl2.CaptionImage")));
            this.groupControl2.Controls.Add(this.lbltotal);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Controls.Add(this.txtFecha);
            this.groupControl2.Controls.Add(this.header_PagoGridControl);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(506, 350);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Datos del Comprobante";
            // 
            // lbltotal
            // 
            this.lbltotal.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(365, 34);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(82, 14);
            this.lbltotal.TabIndex = 4;
            this.lbltotal.Text = "labelControl3";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(248, 34);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(111, 14);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Facturado  en Día:";
            this.labelControl2.Click += new System.EventHandler(this.labelControl2_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(6, 35);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(122, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Fecha de Facturación:";
            // 
            // txtFecha
            // 
            this.txtFecha.EditValue = null;
            this.txtFecha.Location = new System.Drawing.Point(134, 32);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtFecha.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtFecha.Size = new System.Drawing.Size(100, 20);
            this.txtFecha.TabIndex = 1;
            this.txtFecha.EditValueChanged += new System.EventHandler(this.txtFecha_EditValueChanged);
            // 
            // header_PagoGridControl
            // 
            this.header_PagoGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.header_PagoGridControl.DataSource = this.header_PagoBindingSource;
            this.header_PagoGridControl.Location = new System.Drawing.Point(5, 58);
            this.header_PagoGridControl.MainView = this.gridView1;
            this.header_PagoGridControl.Name = "header_PagoGridControl";
            this.header_PagoGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.header_PagoGridControl.Size = new System.Drawing.Size(491, 287);
            this.header_PagoGridControl.TabIndex = 0;
            this.header_PagoGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Conprobante,
            this.colRuc_DNI,
            this.colmonto,
            this.coligv,
            this.colmonto_total,
            this.colestado});
            this.gridView1.GridControl = this.header_PagoGridControl;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "monto_total", this.colestado, "")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // Conprobante
            // 
            this.Conprobante.Caption = "Conprobante";
            this.Conprobante.FieldName = "comprobante";
            this.Conprobante.Image = ((System.Drawing.Image)(resources.GetObject("Conprobante.Image")));
            this.Conprobante.Name = "Conprobante";
            this.Conprobante.OptionsColumn.AllowEdit = false;
            this.Conprobante.Visible = true;
            this.Conprobante.VisibleIndex = 0;
            this.Conprobante.Width = 83;
            // 
            // colRuc_DNI
            // 
            this.colRuc_DNI.Caption = "Ruc/DNI";
            this.colRuc_DNI.FieldName = "Ruc_DNI";
            this.colRuc_DNI.Image = ((System.Drawing.Image)(resources.GetObject("colRuc_DNI.Image")));
            this.colRuc_DNI.Name = "colRuc_DNI";
            this.colRuc_DNI.OptionsColumn.AllowEdit = false;
            this.colRuc_DNI.Visible = true;
            this.colRuc_DNI.VisibleIndex = 1;
            this.colRuc_DNI.Width = 121;
            // 
            // colmonto
            // 
            this.colmonto.Caption = "SubTotal";
            this.colmonto.FieldName = "monto";
            this.colmonto.Image = ((System.Drawing.Image)(resources.GetObject("colmonto.Image")));
            this.colmonto.Name = "colmonto";
            this.colmonto.OptionsColumn.AllowEdit = false;
            this.colmonto.Visible = true;
            this.colmonto.VisibleIndex = 2;
            this.colmonto.Width = 121;
            // 
            // coligv
            // 
            this.coligv.Caption = "IGV";
            this.coligv.FieldName = "igv";
            this.coligv.Image = ((System.Drawing.Image)(resources.GetObject("coligv.Image")));
            this.coligv.Name = "coligv";
            this.coligv.OptionsColumn.AllowEdit = false;
            this.coligv.Visible = true;
            this.coligv.VisibleIndex = 3;
            this.coligv.Width = 121;
            // 
            // colmonto_total
            // 
            this.colmonto_total.Caption = "Monto Total";
            this.colmonto_total.FieldName = "monto_total";
            this.colmonto_total.Image = ((System.Drawing.Image)(resources.GetObject("colmonto_total.Image")));
            this.colmonto_total.Name = "colmonto_total";
            this.colmonto_total.OptionsColumn.AllowEdit = false;
            this.colmonto_total.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "monto_total", "S/.{0:#.##}")});
            this.colmonto_total.Visible = true;
            this.colmonto_total.VisibleIndex = 4;
            this.colmonto_total.Width = 121;
            // 
            // colestado
            // 
            this.colestado.Caption = "Estado";
            this.colestado.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colestado.FieldName = "estado";
            this.colestado.Image = ((System.Drawing.Image)(resources.GetObject("colestado.Image")));
            this.colestado.Name = "colestado";
            this.colestado.Visible = true;
            this.colestado.VisibleIndex = 5;
            this.colestado.Width = 128;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style4;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // header_PagoTableAdapter
            // 
            this.header_PagoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AcabadosTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BancosTableAdapter = null;
            this.tableAdapterManager.CChica_EgresoTableAdapter = null;
            this.tableAdapterManager.CChica_IngresoTableAdapter = null;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.Cuenta_bancosTableAdapter = null;
            this.tableAdapterManager.Dep_BancosTableAdapter = null;
            this.tableAdapterManager.Documento_pagoTableAdapter = null;
            this.tableAdapterManager.ERP_empresaTableAdapter = null;
            this.tableAdapterManager.Header_cotizaTableAdapter = null;
            this.tableAdapterManager.Header_GremisionTableAdapter = null;
            this.tableAdapterManager.Header_PagoTableAdapter = this.header_PagoTableAdapter;
            this.tableAdapterManager.ImpresionesTableAdapter = null;
            this.tableAdapterManager.MaterialTableAdapter = null;
            this.tableAdapterManager.Orden_de_CompraTableAdapter = null;
            this.tableAdapterManager.Unidad_MedidaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AQCobranza.DSAQCobranzaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            // 
            // CuadreCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 391);
            this.Controls.Add(this.groupControl1);
            this.Name = "CuadreCaja";
            this.Text = "Cuadre de Caja";
            this.Load += new System.EventHandler(this.CuadreCaja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.header_PagoBindingNavigator)).EndInit();
            this.header_PagoBindingNavigator.ResumeLayout(false);
            this.header_PagoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.header_PagoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAQCobranza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFecha.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.header_PagoGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DSAQCobranza dSAQCobranza;
        private System.Windows.Forms.BindingSource header_PagoBindingSource;
        private DSAQCobranzaTableAdapters.Header_PagoTableAdapter header_PagoTableAdapter;
        private DSAQCobranzaTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator header_PagoBindingNavigator;
        private System.Windows.Forms.ToolStripButton header_PagoBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl header_PagoGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit txtFecha;
        private DevExpress.XtraGrid.Columns.GridColumn Conprobante;
        private DevExpress.XtraGrid.Columns.GridColumn colRuc_DNI;
        private DevExpress.XtraGrid.Columns.GridColumn colmonto;
        private DevExpress.XtraGrid.Columns.GridColumn coligv;
        private DevExpress.XtraGrid.Columns.GridColumn colmonto_total;
        private DevExpress.XtraGrid.Columns.GridColumn colestado;
        private DevExpress.XtraEditors.LabelControl lbltotal;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
    }
}