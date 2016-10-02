namespace AQCobranza
{
    partial class Comprobantes
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
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label serieLabel;
            System.Windows.Forms.Label correlativLabel;
            System.Windows.Forms.Label abreLabel;
            System.Windows.Forms.Label estadoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Comprobantes));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.documento_pagoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.documento_pagoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSAQCobranza = new AQCobranza.DSAQCobranza();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.documento_pagoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.documento_pagoGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colserie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcorrelativ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colabre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nombreTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.serieTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.correlativTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.abreTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.estadoCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.documento_pagoTableAdapter = new AQCobranza.DSAQCobranzaTableAdapters.Documento_pagoTableAdapter();
            this.tableAdapterManager = new AQCobranza.DSAQCobranzaTableAdapters.TableAdapterManager();
            nombreLabel = new System.Windows.Forms.Label();
            serieLabel = new System.Windows.Forms.Label();
            correlativLabel = new System.Windows.Forms.Label();
            abreLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documento_pagoBindingNavigator)).BeginInit();
            this.documento_pagoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documento_pagoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAQCobranza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documento_pagoGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nombreTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serieTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.correlativTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abreTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoCheckEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(15, 29);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(48, 13);
            nombreLabel.TabIndex = 2;
            nombreLabel.Text = "Nombre:";
            // 
            // serieLabel
            // 
            serieLabel.AutoSize = true;
            serieLabel.Location = new System.Drawing.Point(15, 55);
            serieLabel.Name = "serieLabel";
            serieLabel.Size = new System.Drawing.Size(35, 13);
            serieLabel.TabIndex = 4;
            serieLabel.Text = "Serie:";
            // 
            // correlativLabel
            // 
            correlativLabel.AutoSize = true;
            correlativLabel.Location = new System.Drawing.Point(15, 81);
            correlativLabel.Name = "correlativLabel";
            correlativLabel.Size = new System.Drawing.Size(64, 13);
            correlativLabel.TabIndex = 6;
            correlativLabel.Text = "Correlativo:";
            // 
            // abreLabel
            // 
            abreLabel.AutoSize = true;
            abreLabel.Location = new System.Drawing.Point(15, 107);
            abreLabel.Name = "abreLabel";
            abreLabel.Size = new System.Drawing.Size(68, 13);
            abreLabel.TabIndex = 8;
            abreLabel.Text = "Abreviatura:";
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Location = new System.Drawing.Point(15, 133);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(0, 13);
            estadoLabel.TabIndex = 10;
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImage = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImage")));
            this.groupControl1.Controls.Add(this.splitContainerControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(764, 409);
            this.groupControl1.TabIndex = 10;
            this.groupControl1.Text = "Comprobantes";
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
            this.splitContainerControl1.Size = new System.Drawing.Size(760, 368);
            this.splitContainerControl1.SplitterPosition = 121;
            this.splitContainerControl1.TabIndex = 7;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.documento_pagoBindingNavigator);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 0);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(121, 368);
            this.groupControl3.TabIndex = 0;
            // 
            // documento_pagoBindingNavigator
            // 
            this.documento_pagoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.documento_pagoBindingNavigator.BindingSource = this.documento_pagoBindingSource;
            this.documento_pagoBindingNavigator.CountItem = null;
            this.documento_pagoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.documento_pagoBindingNavigator.Dock = System.Windows.Forms.DockStyle.Left;
            this.documento_pagoBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.documento_pagoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.documento_pagoBindingNavigatorSaveItem});
            this.documento_pagoBindingNavigator.Location = new System.Drawing.Point(2, 20);
            this.documento_pagoBindingNavigator.MoveFirstItem = null;
            this.documento_pagoBindingNavigator.MoveLastItem = null;
            this.documento_pagoBindingNavigator.MoveNextItem = null;
            this.documento_pagoBindingNavigator.MovePreviousItem = null;
            this.documento_pagoBindingNavigator.Name = "documento_pagoBindingNavigator";
            this.documento_pagoBindingNavigator.PositionItem = null;
            this.documento_pagoBindingNavigator.Size = new System.Drawing.Size(103, 346);
            this.documento_pagoBindingNavigator.TabIndex = 11;
            this.documento_pagoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.bindingNavigatorAddNewItem.Image = global::AQCobranza.Properties.Resources.additem_32x32;
            this.bindingNavigatorAddNewItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(100, 36);
            this.bindingNavigatorAddNewItem.Text = "NUEVO";
            // 
            // documento_pagoBindingSource
            // 
            this.documento_pagoBindingSource.DataMember = "Documento_pago";
            this.documento_pagoBindingSource.DataSource = this.dSAQCobranza;
            // 
            // dSAQCobranza
            // 
            this.dSAQCobranza.DataSetName = "DSAQCobranza";
            this.dSAQCobranza.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.bindingNavigatorDeleteItem.Image = global::AQCobranza.Properties.Resources.cancel_32x32;
            this.bindingNavigatorDeleteItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(100, 36);
            this.bindingNavigatorDeleteItem.Text = "ELIMINAR";
            // 
            // documento_pagoBindingNavigatorSaveItem
            // 
            this.documento_pagoBindingNavigatorSaveItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.documento_pagoBindingNavigatorSaveItem.Image = global::AQCobranza.Properties.Resources.saveto_32x32;
            this.documento_pagoBindingNavigatorSaveItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.documento_pagoBindingNavigatorSaveItem.Name = "documento_pagoBindingNavigatorSaveItem";
            this.documento_pagoBindingNavigatorSaveItem.Size = new System.Drawing.Size(100, 36);
            this.documento_pagoBindingNavigatorSaveItem.Text = "GUARDAR";
            this.documento_pagoBindingNavigatorSaveItem.Click += new System.EventHandler(this.documento_pagoBindingNavigatorSaveItem_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.CaptionImage = ((System.Drawing.Image)(resources.GetObject("groupControl2.CaptionImage")));
            this.groupControl2.Controls.Add(this.groupControl4);
            this.groupControl2.Controls.Add(nombreLabel);
            this.groupControl2.Controls.Add(this.nombreTextEdit);
            this.groupControl2.Controls.Add(serieLabel);
            this.groupControl2.Controls.Add(this.serieTextEdit);
            this.groupControl2.Controls.Add(correlativLabel);
            this.groupControl2.Controls.Add(this.correlativTextEdit);
            this.groupControl2.Controls.Add(abreLabel);
            this.groupControl2.Controls.Add(this.abreTextEdit);
            this.groupControl2.Controls.Add(estadoLabel);
            this.groupControl2.Controls.Add(this.estadoCheckEdit);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(634, 368);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Datos del Comprobante";
            // 
            // groupControl4
            // 
            this.groupControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl4.Controls.Add(this.documento_pagoGridControl);
            this.groupControl4.Location = new System.Drawing.Point(6, 157);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(618, 281);
            this.groupControl4.TabIndex = 12;
            // 
            // documento_pagoGridControl
            // 
            this.documento_pagoGridControl.DataSource = this.documento_pagoBindingSource;
            this.documento_pagoGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.documento_pagoGridControl.Location = new System.Drawing.Point(2, 20);
            this.documento_pagoGridControl.MainView = this.gridView1;
            this.documento_pagoGridControl.Name = "documento_pagoGridControl";
            this.documento_pagoGridControl.Size = new System.Drawing.Size(614, 259);
            this.documento_pagoGridControl.TabIndex = 0;
            this.documento_pagoGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnombre,
            this.colserie,
            this.colcorrelativ,
            this.colabre,
            this.colestado});
            this.gridView1.GridControl = this.documento_pagoGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // colnombre
            // 
            this.colnombre.Caption = "Nombre";
            this.colnombre.FieldName = "nombre";
            this.colnombre.Image = ((System.Drawing.Image)(resources.GetObject("colnombre.Image")));
            this.colnombre.Name = "colnombre";
            this.colnombre.Visible = true;
            this.colnombre.VisibleIndex = 0;
            // 
            // colserie
            // 
            this.colserie.Caption = "Serie";
            this.colserie.FieldName = "serie";
            this.colserie.Image = ((System.Drawing.Image)(resources.GetObject("colserie.Image")));
            this.colserie.Name = "colserie";
            this.colserie.Visible = true;
            this.colserie.VisibleIndex = 1;
            // 
            // colcorrelativ
            // 
            this.colcorrelativ.Caption = "Correlativo";
            this.colcorrelativ.FieldName = "correlativ";
            this.colcorrelativ.Image = ((System.Drawing.Image)(resources.GetObject("colcorrelativ.Image")));
            this.colcorrelativ.Name = "colcorrelativ";
            this.colcorrelativ.Visible = true;
            this.colcorrelativ.VisibleIndex = 2;
            // 
            // colabre
            // 
            this.colabre.Caption = "Abreviatura";
            this.colabre.FieldName = "abre";
            this.colabre.Image = ((System.Drawing.Image)(resources.GetObject("colabre.Image")));
            this.colabre.Name = "colabre";
            this.colabre.Visible = true;
            this.colabre.VisibleIndex = 3;
            // 
            // colestado
            // 
            this.colestado.Caption = "Estado";
            this.colestado.FieldName = "estado";
            this.colestado.Image = ((System.Drawing.Image)(resources.GetObject("colestado.Image")));
            this.colestado.Name = "colestado";
            this.colestado.Visible = true;
            this.colestado.VisibleIndex = 4;
            // 
            // nombreTextEdit
            // 
            this.nombreTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.documento_pagoBindingSource, "nombre", true));
            this.nombreTextEdit.Location = new System.Drawing.Point(95, 26);
            this.nombreTextEdit.Name = "nombreTextEdit";
            this.nombreTextEdit.Size = new System.Drawing.Size(117, 20);
            this.nombreTextEdit.TabIndex = 3;
            // 
            // serieTextEdit
            // 
            this.serieTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.documento_pagoBindingSource, "serie", true));
            this.serieTextEdit.Location = new System.Drawing.Point(95, 52);
            this.serieTextEdit.Name = "serieTextEdit";
            this.serieTextEdit.Properties.Mask.EditMask = "000";
            this.serieTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.serieTextEdit.Size = new System.Drawing.Size(35, 20);
            this.serieTextEdit.TabIndex = 5;
            // 
            // correlativTextEdit
            // 
            this.correlativTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.documento_pagoBindingSource, "correlativ", true));
            this.correlativTextEdit.Location = new System.Drawing.Point(95, 78);
            this.correlativTextEdit.Name = "correlativTextEdit";
            this.correlativTextEdit.Properties.Mask.EditMask = "000000";
            this.correlativTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.correlativTextEdit.Size = new System.Drawing.Size(79, 20);
            this.correlativTextEdit.TabIndex = 7;
            // 
            // abreTextEdit
            // 
            this.abreTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.documento_pagoBindingSource, "abre", true));
            this.abreTextEdit.Location = new System.Drawing.Point(95, 104);
            this.abreTextEdit.Name = "abreTextEdit";
            this.abreTextEdit.Properties.Mask.EditMask = "aaa";
            this.abreTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.abreTextEdit.Size = new System.Drawing.Size(59, 20);
            this.abreTextEdit.TabIndex = 9;
            // 
            // estadoCheckEdit
            // 
            this.estadoCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.documento_pagoBindingSource, "estado", true));
            this.estadoCheckEdit.EditValue = true;
            this.estadoCheckEdit.Location = new System.Drawing.Point(18, 128);
            this.estadoCheckEdit.Name = "estadoCheckEdit";
            this.estadoCheckEdit.Properties.Caption = "Estado:";
            this.estadoCheckEdit.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style16;
            this.estadoCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.estadoCheckEdit.Size = new System.Drawing.Size(100, 22);
            this.estadoCheckEdit.TabIndex = 11;
            this.estadoCheckEdit.CheckedChanged += new System.EventHandler(this.estadoCheckEdit_CheckedChanged);
            // 
            // documento_pagoTableAdapter
            // 
            this.documento_pagoTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.Documento_pagoTableAdapter = this.documento_pagoTableAdapter;
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
            // Comprobantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 409);
            this.Controls.Add(this.groupControl1);
            this.Name = "Comprobantes";
            this.Text = "Comprobantes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Comprobantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documento_pagoBindingNavigator)).EndInit();
            this.documento_pagoBindingNavigator.ResumeLayout(false);
            this.documento_pagoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documento_pagoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAQCobranza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.documento_pagoGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nombreTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serieTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.correlativTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abreTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoCheckEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DSAQCobranza dSAQCobranza;
        private System.Windows.Forms.BindingSource documento_pagoBindingSource;
        private DSAQCobranzaTableAdapters.Documento_pagoTableAdapter documento_pagoTableAdapter;
        private DSAQCobranzaTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator documento_pagoBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton documento_pagoBindingNavigatorSaveItem;
        private DevExpress.XtraEditors.TextEdit nombreTextEdit;
        private DevExpress.XtraEditors.TextEdit serieTextEdit;
        private DevExpress.XtraEditors.TextEdit correlativTextEdit;
        private DevExpress.XtraEditors.TextEdit abreTextEdit;
        private DevExpress.XtraEditors.CheckEdit estadoCheckEdit;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraGrid.GridControl documento_pagoGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private DevExpress.XtraGrid.Columns.GridColumn colserie;
        private DevExpress.XtraGrid.Columns.GridColumn colcorrelativ;
        private DevExpress.XtraGrid.Columns.GridColumn colabre;
        private DevExpress.XtraGrid.Columns.GridColumn colestado;
    }
}