namespace AQCobranza
{
    partial class Impresiones
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
            System.Windows.Forms.Label observacionesLabel;
            System.Windows.Forms.Label impresionLabel;
            System.Windows.Forms.Label cod_impresionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Impresiones));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.impresionesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.impresionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSAQCobranza = new AQCobranza.DSAQCobranza();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.impresionesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.cod_impresionSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.impresionTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.GCImpresion = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcod_impresion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImpresion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colobservaciones = new DevExpress.XtraGrid.Columns.GridColumn();
            this.searchControl1 = new DevExpress.XtraEditors.SearchControl();
            this.observacionesTextEdit = new DevExpress.XtraEditors.MemoEdit();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.impresionesTableAdapter = new AQCobranza.DSAQCobranzaTableAdapters.ImpresionesTableAdapter();
            this.tableAdapterManager = new AQCobranza.DSAQCobranzaTableAdapters.TableAdapterManager();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridSplitContainer1 = new DevExpress.XtraGrid.GridSplitContainer();
            observacionesLabel = new System.Windows.Forms.Label();
            impresionLabel = new System.Windows.Forms.Label();
            cod_impresionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.impresionesBindingNavigator)).BeginInit();
            this.impresionesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.impresionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAQCobranza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cod_impresionSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.impresionTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GCImpresion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.observacionesTextEdit.Properties)).BeginInit();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).BeginInit();
            this.gridSplitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // observacionesLabel
            // 
            observacionesLabel.AutoSize = true;
            observacionesLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            observacionesLabel.Location = new System.Drawing.Point(7, 85);
            observacionesLabel.Name = "observacionesLabel";
            observacionesLabel.Size = new System.Drawing.Size(93, 13);
            observacionesLabel.TabIndex = 10;
            observacionesLabel.Text = "Observaciones:";
            // 
            // impresionLabel
            // 
            impresionLabel.AutoSize = true;
            impresionLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            impresionLabel.Location = new System.Drawing.Point(7, 59);
            impresionLabel.Name = "impresionLabel";
            impresionLabel.Size = new System.Drawing.Size(68, 13);
            impresionLabel.TabIndex = 8;
            impresionLabel.Text = "Impresión:";
            // 
            // cod_impresionLabel
            // 
            cod_impresionLabel.AutoSize = true;
            cod_impresionLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            cod_impresionLabel.Location = new System.Drawing.Point(7, 33);
            cod_impresionLabel.Name = "cod_impresionLabel";
            cod_impresionLabel.Size = new System.Drawing.Size(48, 13);
            cod_impresionLabel.TabIndex = 6;
            cod_impresionLabel.Text = "Código:";
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImage = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImage")));
            this.groupControl1.Controls.Add(this.splitContainerControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(616, 430);
            this.groupControl1.TabIndex = 10;
            this.groupControl1.Text = "Impresiones";
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
            this.splitContainerControl1.Size = new System.Drawing.Size(612, 389);
            this.splitContainerControl1.SplitterPosition = 118;
            this.splitContainerControl1.TabIndex = 7;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.impresionesBindingNavigator);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 0);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(118, 389);
            this.groupControl3.TabIndex = 0;
            // 
            // impresionesBindingNavigator
            // 
            this.impresionesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.impresionesBindingNavigator.BindingSource = this.impresionesBindingSource;
            this.impresionesBindingNavigator.CountItem = null;
            this.impresionesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.impresionesBindingNavigator.Dock = System.Windows.Forms.DockStyle.Left;
            this.impresionesBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.impresionesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.impresionesBindingNavigatorSaveItem});
            this.impresionesBindingNavigator.Location = new System.Drawing.Point(2, 20);
            this.impresionesBindingNavigator.MoveFirstItem = null;
            this.impresionesBindingNavigator.MoveLastItem = null;
            this.impresionesBindingNavigator.MoveNextItem = null;
            this.impresionesBindingNavigator.MovePreviousItem = null;
            this.impresionesBindingNavigator.Name = "impresionesBindingNavigator";
            this.impresionesBindingNavigator.PositionItem = null;
            this.impresionesBindingNavigator.Size = new System.Drawing.Size(103, 367);
            this.impresionesBindingNavigator.TabIndex = 12;
            this.impresionesBindingNavigator.Text = "bindingNavigator1";
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
            // impresionesBindingSource
            // 
            this.impresionesBindingSource.DataMember = "Impresiones";
            this.impresionesBindingSource.DataSource = this.dSAQCobranza;
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
            // impresionesBindingNavigatorSaveItem
            // 
            this.impresionesBindingNavigatorSaveItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.impresionesBindingNavigatorSaveItem.Image = global::AQCobranza.Properties.Resources.saveto_32x32;
            this.impresionesBindingNavigatorSaveItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.impresionesBindingNavigatorSaveItem.Name = "impresionesBindingNavigatorSaveItem";
            this.impresionesBindingNavigatorSaveItem.Size = new System.Drawing.Size(100, 36);
            this.impresionesBindingNavigatorSaveItem.Text = "GUARDAR";
            this.impresionesBindingNavigatorSaveItem.Click += new System.EventHandler(this.impresionesBindingNavigatorSaveItem_Click_1);
            // 
            // groupControl2
            // 
            this.groupControl2.CaptionImage = ((System.Drawing.Image)(resources.GetObject("groupControl2.CaptionImage")));
            this.groupControl2.Controls.Add(this.cod_impresionSpinEdit);
            this.groupControl2.Controls.Add(this.impresionTextEdit);
            this.groupControl2.Controls.Add(cod_impresionLabel);
            this.groupControl2.Controls.Add(impresionLabel);
            this.groupControl2.Controls.Add(observacionesLabel);
            this.groupControl2.Controls.Add(this.groupControl4);
            this.groupControl2.Controls.Add(this.observacionesTextEdit);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(489, 389);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Datos de la Impresión";
            // 
            // cod_impresionSpinEdit
            // 
            this.cod_impresionSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.impresionesBindingSource, "cod_impresion", true));
            this.cod_impresionSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.cod_impresionSpinEdit.Enabled = false;
            this.cod_impresionSpinEdit.Location = new System.Drawing.Point(105, 28);
            this.cod_impresionSpinEdit.Name = "cod_impresionSpinEdit";
            this.cod_impresionSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cod_impresionSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.cod_impresionSpinEdit.TabIndex = 11;
            // 
            // impresionTextEdit
            // 
            this.impresionTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.impresionesBindingSource, "Impresion", true));
            this.impresionTextEdit.Location = new System.Drawing.Point(105, 54);
            this.impresionTextEdit.Name = "impresionTextEdit";
            this.impresionTextEdit.Size = new System.Drawing.Size(257, 20);
            this.impresionTextEdit.TabIndex = 13;
            // 
            // groupControl4
            // 
            this.groupControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl4.Controls.Add(this.GCImpresion);
            this.groupControl4.Controls.Add(this.searchControl1);
            this.groupControl4.Location = new System.Drawing.Point(5, 152);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(488, 227);
            this.groupControl4.TabIndex = 6;
            // 
            // GCImpresion
            // 
            this.GCImpresion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GCImpresion.DataSource = this.impresionesBindingSource;
            this.GCImpresion.Location = new System.Drawing.Point(14, 50);
            this.GCImpresion.MainView = this.gridView2;
            this.GCImpresion.Name = "GCImpresion";
            this.GCImpresion.Size = new System.Drawing.Size(457, 165);
            this.GCImpresion.TabIndex = 1;
            this.GCImpresion.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcod_impresion,
            this.colImpresion,
            this.colobservaciones});
            this.gridView2.GridControl = this.GCImpresion;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colcod_impresion
            // 
            this.colcod_impresion.Caption = "Código";
            this.colcod_impresion.FieldName = "cod_impresion";
            this.colcod_impresion.Image = ((System.Drawing.Image)(resources.GetObject("colcod_impresion.Image")));
            this.colcod_impresion.Name = "colcod_impresion";
            this.colcod_impresion.Visible = true;
            this.colcod_impresion.VisibleIndex = 0;
            // 
            // colImpresion
            // 
            this.colImpresion.Caption = "Impresión";
            this.colImpresion.FieldName = "Impresion";
            this.colImpresion.Image = ((System.Drawing.Image)(resources.GetObject("colImpresion.Image")));
            this.colImpresion.Name = "colImpresion";
            this.colImpresion.Visible = true;
            this.colImpresion.VisibleIndex = 1;
            // 
            // colobservaciones
            // 
            this.colobservaciones.Caption = "Obsercaciones";
            this.colobservaciones.FieldName = "observaciones";
            this.colobservaciones.Image = ((System.Drawing.Image)(resources.GetObject("colobservaciones.Image")));
            this.colobservaciones.Name = "colobservaciones";
            this.colobservaciones.Visible = true;
            this.colobservaciones.VisibleIndex = 2;
            // 
            // searchControl1
            // 
            this.searchControl1.Client = this.GCImpresion;
            this.searchControl1.Location = new System.Drawing.Point(5, 17);
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl1.Properties.Client = this.GCImpresion;
            this.searchControl1.Properties.NullValuePrompt = "Ingrese el Texto para Buscar";
            this.searchControl1.Size = new System.Drawing.Size(168, 20);
            this.searchControl1.TabIndex = 1;
            // 
            // observacionesTextEdit
            // 
            this.observacionesTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.impresionesBindingSource, "observaciones", true));
            this.observacionesTextEdit.Location = new System.Drawing.Point(105, 80);
            this.observacionesTextEdit.Name = "observacionesTextEdit";
            this.observacionesTextEdit.Size = new System.Drawing.Size(257, 64);
            this.observacionesTextEdit.TabIndex = 15;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.AutoScroll = true;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.groupControl1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(616, 430);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            this.toolStripContainer1.LeftToolStripPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStripContainer1.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.LeftToolStripPanel.Name = "";
            this.toolStripContainer1.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.toolStripContainer1.LeftToolStripPanel.Padding = new System.Windows.Forms.Padding(0, 0, 25, 0);
            this.toolStripContainer1.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.toolStripContainer1.LeftToolStripPanel.Size = new System.Drawing.Size(25, 430);
            this.toolStripContainer1.LeftToolStripPanel.Visible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            // 
            // 
            // 
            this.toolStripContainer1.RightToolStripPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStripContainer1.RightToolStripPanel.Location = new System.Drawing.Point(591, 0);
            this.toolStripContainer1.RightToolStripPanel.Name = "";
            this.toolStripContainer1.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.toolStripContainer1.RightToolStripPanel.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.toolStripContainer1.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.toolStripContainer1.RightToolStripPanel.Size = new System.Drawing.Size(25, 430);
            this.toolStripContainer1.RightToolStripPanel.Visible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(616, 430);
            this.toolStripContainer1.TabIndex = 11;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // 
            // 
            this.toolStripContainer1.TopToolStripPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolStripContainer1.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.TopToolStripPanel.Name = "";
            this.toolStripContainer1.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.toolStripContainer1.TopToolStripPanel.Padding = new System.Windows.Forms.Padding(0, 0, 25, 25);
            this.toolStripContainer1.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.toolStripContainer1.TopToolStripPanel.Size = new System.Drawing.Size(616, 25);
            this.toolStripContainer1.TopToolStripPanel.Visible = false;
            // 
            // impresionesTableAdapter
            // 
            this.impresionesTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.ImpresionesTableAdapter = this.impresionesTableAdapter;
            this.tableAdapterManager.MaterialTableAdapter = null;
            this.tableAdapterManager.Unidad_MedidaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AQCobranza.DSAQCobranzaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            // 
            // gridView1
            // 
            this.gridView1.Name = "gridView1";
            // 
            // gridSplitContainer1
            // 
            this.gridSplitContainer1.Grid = null;
            this.gridSplitContainer1.Location = new System.Drawing.Point(6, 43);
            this.gridSplitContainer1.Name = "gridSplitContainer1";
            this.gridSplitContainer1.Size = new System.Drawing.Size(454, 171);
            this.gridSplitContainer1.TabIndex = 2;
            // 
            // Impresiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 430);
            this.Controls.Add(this.toolStripContainer1);
            this.LookAndFeel.SkinName = "Office 2013";
            this.Name = "Impresiones";
            this.Text = "Impresiones";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Impresiones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.impresionesBindingNavigator)).EndInit();
            this.impresionesBindingNavigator.ResumeLayout(false);
            this.impresionesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.impresionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAQCobranza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cod_impresionSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.impresionTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GCImpresion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.observacionesTextEdit.Properties)).EndInit();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).EndInit();
            this.gridSplitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.SearchControl searchControl1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private DSAQCobranza dSAQCobranza;
        private System.Windows.Forms.BindingSource impresionesBindingSource;
        private DSAQCobranzaTableAdapters.ImpresionesTableAdapter impresionesTableAdapter;
        private DSAQCobranzaTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator impresionesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton impresionesBindingNavigatorSaveItem;
        private DevExpress.XtraEditors.SpinEdit cod_impresionSpinEdit;
        private DevExpress.XtraEditors.TextEdit impresionTextEdit;
        private DevExpress.XtraGrid.GridControl GCImpresion;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colcod_impresion;
        private DevExpress.XtraGrid.Columns.GridColumn colImpresion;
        private DevExpress.XtraGrid.Columns.GridColumn colobservaciones;
        private DevExpress.XtraEditors.MemoEdit observacionesTextEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridSplitContainer gridSplitContainer1;
    }
}