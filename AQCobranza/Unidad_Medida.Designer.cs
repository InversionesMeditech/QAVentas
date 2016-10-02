namespace AQCobranza
{
    partial class Unidad_Medida
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
            System.Windows.Forms.Label cod_unidadLabel;
            System.Windows.Forms.Label unidadLabel;
            System.Windows.Forms.Label numeroLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Unidad_Medida));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.unidad_MedidaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.unidad_MedidaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSAQCobranza = new AQCobranza.DSAQCobranza();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.unidad_MedidaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.cod_unidadSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.unidadTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.numeroSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.unidad_MedidaGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcod_unidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnumero = new DevExpress.XtraGrid.Columns.GridColumn();
            this.searchControl1 = new DevExpress.XtraEditors.SearchControl();
            this.unidad_MedidaTableAdapter = new AQCobranza.DSAQCobranzaTableAdapters.Unidad_MedidaTableAdapter();
            this.tableAdapterManager = new AQCobranza.DSAQCobranzaTableAdapters.TableAdapterManager();
            cod_unidadLabel = new System.Windows.Forms.Label();
            unidadLabel = new System.Windows.Forms.Label();
            numeroLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unidad_MedidaBindingNavigator)).BeginInit();
            this.unidad_MedidaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unidad_MedidaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAQCobranza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cod_unidadSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeroSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unidad_MedidaGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cod_unidadLabel
            // 
            cod_unidadLabel.AutoSize = true;
            cod_unidadLabel.Location = new System.Drawing.Point(7, 34);
            cod_unidadLabel.Name = "cod_unidadLabel";
            cod_unidadLabel.Size = new System.Drawing.Size(63, 13);
            cod_unidadLabel.TabIndex = 6;
            cod_unidadLabel.Text = "cod unidad:";
            // 
            // unidadLabel
            // 
            unidadLabel.AutoSize = true;
            unidadLabel.Location = new System.Drawing.Point(7, 60);
            unidadLabel.Name = "unidadLabel";
            unidadLabel.Size = new System.Drawing.Size(44, 13);
            unidadLabel.TabIndex = 8;
            unidadLabel.Text = "Unidad:";
            // 
            // numeroLabel
            // 
            numeroLabel.AutoSize = true;
            numeroLabel.Location = new System.Drawing.Point(7, 86);
            numeroLabel.Name = "numeroLabel";
            numeroLabel.Size = new System.Drawing.Size(47, 13);
            numeroLabel.TabIndex = 10;
            numeroLabel.Text = "numero:";
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImage = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImage")));
            this.groupControl1.Controls.Add(this.splitContainerControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(586, 431);
            this.groupControl1.TabIndex = 11;
            this.groupControl1.Text = "Unidades de Medida";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(2, 33);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl3);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.groupControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(582, 396);
            this.splitContainerControl1.SplitterPosition = 118;
            this.splitContainerControl1.TabIndex = 7;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.unidad_MedidaBindingNavigator);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 0);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(118, 396);
            this.groupControl3.TabIndex = 0;
            // 
            // unidad_MedidaBindingNavigator
            // 
            this.unidad_MedidaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.unidad_MedidaBindingNavigator.BindingSource = this.unidad_MedidaBindingSource;
            this.unidad_MedidaBindingNavigator.CountItem = null;
            this.unidad_MedidaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.unidad_MedidaBindingNavigator.Dock = System.Windows.Forms.DockStyle.Left;
            this.unidad_MedidaBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.unidad_MedidaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.unidad_MedidaBindingNavigatorSaveItem});
            this.unidad_MedidaBindingNavigator.Location = new System.Drawing.Point(2, 21);
            this.unidad_MedidaBindingNavigator.MoveFirstItem = null;
            this.unidad_MedidaBindingNavigator.MoveLastItem = null;
            this.unidad_MedidaBindingNavigator.MoveNextItem = null;
            this.unidad_MedidaBindingNavigator.MovePreviousItem = null;
            this.unidad_MedidaBindingNavigator.Name = "unidad_MedidaBindingNavigator";
            this.unidad_MedidaBindingNavigator.PositionItem = null;
            this.unidad_MedidaBindingNavigator.Size = new System.Drawing.Size(103, 373);
            this.unidad_MedidaBindingNavigator.TabIndex = 12;
            this.unidad_MedidaBindingNavigator.Text = "bindingNavigator1";
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
            // unidad_MedidaBindingSource
            // 
            this.unidad_MedidaBindingSource.DataMember = "Unidad_Medida";
            this.unidad_MedidaBindingSource.DataSource = this.dSAQCobranza;
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
            // unidad_MedidaBindingNavigatorSaveItem
            // 
            this.unidad_MedidaBindingNavigatorSaveItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.unidad_MedidaBindingNavigatorSaveItem.Image = global::AQCobranza.Properties.Resources.saveto_32x32;
            this.unidad_MedidaBindingNavigatorSaveItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.unidad_MedidaBindingNavigatorSaveItem.Name = "unidad_MedidaBindingNavigatorSaveItem";
            this.unidad_MedidaBindingNavigatorSaveItem.Size = new System.Drawing.Size(100, 36);
            this.unidad_MedidaBindingNavigatorSaveItem.Text = "GUARDAR";
            this.unidad_MedidaBindingNavigatorSaveItem.Click += new System.EventHandler(this.unidad_MedidaBindingNavigatorSaveItem_Click_1);
            // 
            // groupControl2
            // 
            this.groupControl2.AutoSize = true;
            this.groupControl2.CaptionImage = ((System.Drawing.Image)(resources.GetObject("groupControl2.CaptionImage")));
            this.groupControl2.Controls.Add(cod_unidadLabel);
            this.groupControl2.Controls.Add(this.cod_unidadSpinEdit);
            this.groupControl2.Controls.Add(unidadLabel);
            this.groupControl2.Controls.Add(this.unidadTextEdit);
            this.groupControl2.Controls.Add(numeroLabel);
            this.groupControl2.Controls.Add(this.numeroSpinEdit);
            this.groupControl2.Controls.Add(this.groupControl4);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(459, 396);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Datos de UM";
            // 
            // cod_unidadSpinEdit
            // 
            this.cod_unidadSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.unidad_MedidaBindingSource, "cod_unidad", true));
            this.cod_unidadSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.cod_unidadSpinEdit.Enabled = false;
            this.cod_unidadSpinEdit.Location = new System.Drawing.Point(76, 29);
            this.cod_unidadSpinEdit.Name = "cod_unidadSpinEdit";
            this.cod_unidadSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cod_unidadSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.cod_unidadSpinEdit.TabIndex = 7;
            // 
            // unidadTextEdit
            // 
            this.unidadTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.unidad_MedidaBindingSource, "Unidad", true));
            this.unidadTextEdit.Location = new System.Drawing.Point(76, 55);
            this.unidadTextEdit.Name = "unidadTextEdit";
            this.unidadTextEdit.Size = new System.Drawing.Size(100, 20);
            this.unidadTextEdit.TabIndex = 9;
            // 
            // numeroSpinEdit
            // 
            this.numeroSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.unidad_MedidaBindingSource, "numero", true));
            this.numeroSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numeroSpinEdit.Location = new System.Drawing.Point(76, 81);
            this.numeroSpinEdit.Name = "numeroSpinEdit";
            this.numeroSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.numeroSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.numeroSpinEdit.TabIndex = 11;
            // 
            // groupControl4
            // 
            this.groupControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl4.Controls.Add(this.unidad_MedidaGridControl);
            this.groupControl4.Controls.Add(this.searchControl1);
            this.groupControl4.Location = new System.Drawing.Point(5, 142);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(451, 244);
            this.groupControl4.TabIndex = 6;
            // 
            // unidad_MedidaGridControl
            // 
            this.unidad_MedidaGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.unidad_MedidaGridControl.DataSource = this.unidad_MedidaBindingSource;
            this.unidad_MedidaGridControl.Location = new System.Drawing.Point(14, 52);
            this.unidad_MedidaGridControl.MainView = this.gridView1;
            this.unidad_MedidaGridControl.Name = "unidad_MedidaGridControl";
            this.unidad_MedidaGridControl.Size = new System.Drawing.Size(432, 182);
            this.unidad_MedidaGridControl.TabIndex = 1;
            this.unidad_MedidaGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcod_unidad,
            this.colUnidad,
            this.colnumero});
            this.gridView1.GridControl = this.unidad_MedidaGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colcod_unidad
            // 
            this.colcod_unidad.Caption = "Código";
            this.colcod_unidad.FieldName = "cod_unidad";
            this.colcod_unidad.Image = ((System.Drawing.Image)(resources.GetObject("colcod_unidad.Image")));
            this.colcod_unidad.Name = "colcod_unidad";
            this.colcod_unidad.Visible = true;
            this.colcod_unidad.VisibleIndex = 0;
            // 
            // colUnidad
            // 
            this.colUnidad.Caption = "Descripción Unidad";
            this.colUnidad.FieldName = "Unidad";
            this.colUnidad.Image = ((System.Drawing.Image)(resources.GetObject("colUnidad.Image")));
            this.colUnidad.Name = "colUnidad";
            this.colUnidad.Visible = true;
            this.colUnidad.VisibleIndex = 1;
            // 
            // colnumero
            // 
            this.colnumero.Caption = "Cantidad";
            this.colnumero.FieldName = "numero";
            this.colnumero.Image = ((System.Drawing.Image)(resources.GetObject("colnumero.Image")));
            this.colnumero.Name = "colnumero";
            this.colnumero.Visible = true;
            this.colnumero.VisibleIndex = 2;
            // 
            // searchControl1
            // 
            this.searchControl1.Location = new System.Drawing.Point(5, 18);
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl1.Properties.NullValuePrompt = "Ingrese el Texto para Buscar";
            this.searchControl1.Size = new System.Drawing.Size(168, 20);
            this.searchControl1.TabIndex = 1;
            // 
            // unidad_MedidaTableAdapter
            // 
            this.unidad_MedidaTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.ImpresionesTableAdapter = null;
            this.tableAdapterManager.MaterialTableAdapter = null;
            this.tableAdapterManager.Unidad_MedidaTableAdapter = this.unidad_MedidaTableAdapter;
            this.tableAdapterManager.UpdateOrder = AQCobranza.DSAQCobranzaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            // 
            // Unidad_Medida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 431);
            this.Controls.Add(this.groupControl1);
            this.LookAndFeel.SkinName = "Office 2013";
            this.Name = "Unidad_Medida";
            this.Text = "Unidad de Medida";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Unidad_Medida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unidad_MedidaBindingNavigator)).EndInit();
            this.unidad_MedidaBindingNavigator.ResumeLayout(false);
            this.unidad_MedidaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unidad_MedidaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAQCobranza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cod_unidadSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeroSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.unidad_MedidaGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.SearchControl searchControl1;
        private DSAQCobranza dSAQCobranza;
        private System.Windows.Forms.BindingSource unidad_MedidaBindingSource;
        private DSAQCobranzaTableAdapters.Unidad_MedidaTableAdapter unidad_MedidaTableAdapter;
        private DSAQCobranzaTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator unidad_MedidaBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton unidad_MedidaBindingNavigatorSaveItem;
        private DevExpress.XtraEditors.SpinEdit cod_unidadSpinEdit;
        private DevExpress.XtraEditors.TextEdit unidadTextEdit;
        private DevExpress.XtraEditors.SpinEdit numeroSpinEdit;
        private DevExpress.XtraGrid.GridControl unidad_MedidaGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colcod_unidad;
        private DevExpress.XtraGrid.Columns.GridColumn colUnidad;
        private DevExpress.XtraGrid.Columns.GridColumn colnumero;
    }
}