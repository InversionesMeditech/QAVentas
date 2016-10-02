namespace AQCobranza
{
    partial class Material
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
            System.Windows.Forms.Label cod_materialLabel;
            System.Windows.Forms.Label materialLabel;
            System.Windows.Forms.Label observacionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Material));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.materialBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.materialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSAQCobranza = new AQCobranza.DSAQCobranza();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.materialBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.cod_materialSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.materialTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.CGMaterial = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcod_material = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaterial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colobservacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.searchControl1 = new DevExpress.XtraEditors.SearchControl();
            this.observacionTextEdit = new DevExpress.XtraEditors.MemoEdit();
            this.materialTableAdapter = new AQCobranza.DSAQCobranzaTableAdapters.MaterialTableAdapter();
            this.tableAdapterManager = new AQCobranza.DSAQCobranzaTableAdapters.TableAdapterManager();
            cod_materialLabel = new System.Windows.Forms.Label();
            materialLabel = new System.Windows.Forms.Label();
            observacionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingNavigator)).BeginInit();
            this.materialBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAQCobranza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cod_materialSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CGMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.observacionTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cod_materialLabel
            // 
            cod_materialLabel.AutoSize = true;
            cod_materialLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            cod_materialLabel.Location = new System.Drawing.Point(12, 29);
            cod_materialLabel.Name = "cod_materialLabel";
            cod_materialLabel.Size = new System.Drawing.Size(48, 13);
            cod_materialLabel.TabIndex = 6;
            cod_materialLabel.Text = "Código:";
            // 
            // materialLabel
            // 
            materialLabel.AutoSize = true;
            materialLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            materialLabel.Location = new System.Drawing.Point(12, 55);
            materialLabel.Name = "materialLabel";
            materialLabel.Size = new System.Drawing.Size(57, 13);
            materialLabel.TabIndex = 8;
            materialLabel.Text = "Material:";
            // 
            // observacionLabel
            // 
            observacionLabel.AutoSize = true;
            observacionLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            observacionLabel.Location = new System.Drawing.Point(12, 81);
            observacionLabel.Name = "observacionLabel";
            observacionLabel.Size = new System.Drawing.Size(80, 13);
            observacionLabel.TabIndex = 10;
            observacionLabel.Text = "Observación:";
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImage = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImage")));
            this.groupControl1.Controls.Add(this.splitContainerControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(539, 391);
            this.groupControl1.TabIndex = 10;
            this.groupControl1.Text = "Materiales";
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
            this.splitContainerControl1.Size = new System.Drawing.Size(535, 356);
            this.splitContainerControl1.SplitterPosition = 118;
            this.splitContainerControl1.TabIndex = 7;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.materialBindingNavigator);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 0);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(118, 356);
            this.groupControl3.TabIndex = 0;
            // 
            // materialBindingNavigator
            // 
            this.materialBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.materialBindingNavigator.BindingSource = this.materialBindingSource;
            this.materialBindingNavigator.CountItem = null;
            this.materialBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.materialBindingNavigator.Dock = System.Windows.Forms.DockStyle.Left;
            this.materialBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.materialBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.materialBindingNavigatorSaveItem});
            this.materialBindingNavigator.Location = new System.Drawing.Point(2, 21);
            this.materialBindingNavigator.MoveFirstItem = null;
            this.materialBindingNavigator.MoveLastItem = null;
            this.materialBindingNavigator.MoveNextItem = null;
            this.materialBindingNavigator.MovePreviousItem = null;
            this.materialBindingNavigator.Name = "materialBindingNavigator";
            this.materialBindingNavigator.PositionItem = null;
            this.materialBindingNavigator.Size = new System.Drawing.Size(103, 333);
            this.materialBindingNavigator.TabIndex = 11;
            this.materialBindingNavigator.Text = "bindingNavigator1";
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
            // materialBindingSource
            // 
            this.materialBindingSource.DataMember = "Material";
            this.materialBindingSource.DataSource = this.dSAQCobranza;
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
            // materialBindingNavigatorSaveItem
            // 
            this.materialBindingNavigatorSaveItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.materialBindingNavigatorSaveItem.Image = global::AQCobranza.Properties.Resources.saveto_32x32;
            this.materialBindingNavigatorSaveItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.materialBindingNavigatorSaveItem.Name = "materialBindingNavigatorSaveItem";
            this.materialBindingNavigatorSaveItem.Size = new System.Drawing.Size(100, 36);
            this.materialBindingNavigatorSaveItem.Text = "GUARDAR";
            this.materialBindingNavigatorSaveItem.Click += new System.EventHandler(this.materialBindingNavigatorSaveItem_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.CaptionImage = ((System.Drawing.Image)(resources.GetObject("groupControl2.CaptionImage")));
            this.groupControl2.Controls.Add(cod_materialLabel);
            this.groupControl2.Controls.Add(this.cod_materialSpinEdit);
            this.groupControl2.Controls.Add(materialLabel);
            this.groupControl2.Controls.Add(this.materialTextEdit);
            this.groupControl2.Controls.Add(observacionLabel);
            this.groupControl2.Controls.Add(this.groupControl4);
            this.groupControl2.Controls.Add(this.observacionTextEdit);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(412, 356);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Datos del Material";
            // 
            // cod_materialSpinEdit
            // 
            this.cod_materialSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.materialBindingSource, "cod_material", true));
            this.cod_materialSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.cod_materialSpinEdit.Enabled = false;
            this.cod_materialSpinEdit.Location = new System.Drawing.Point(98, 24);
            this.cod_materialSpinEdit.Name = "cod_materialSpinEdit";
            this.cod_materialSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cod_materialSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.cod_materialSpinEdit.TabIndex = 7;
            // 
            // materialTextEdit
            // 
            this.materialTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.materialBindingSource, "Material", true));
            this.materialTextEdit.Location = new System.Drawing.Point(98, 50);
            this.materialTextEdit.Name = "materialTextEdit";
            this.materialTextEdit.Size = new System.Drawing.Size(284, 20);
            this.materialTextEdit.TabIndex = 9;
            // 
            // groupControl4
            // 
            this.groupControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl4.Controls.Add(this.CGMaterial);
            this.groupControl4.Controls.Add(this.searchControl1);
            this.groupControl4.Location = new System.Drawing.Point(5, 142);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(397, 291);
            this.groupControl4.TabIndex = 6;
            // 
            // CGMaterial
            // 
            this.CGMaterial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CGMaterial.DataSource = this.materialBindingSource;
            this.CGMaterial.Location = new System.Drawing.Point(0, 43);
            this.CGMaterial.MainView = this.gridView1;
            this.CGMaterial.Name = "CGMaterial";
            this.CGMaterial.Size = new System.Drawing.Size(392, 149);
            this.CGMaterial.TabIndex = 1;
            this.CGMaterial.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcod_material,
            this.colMaterial,
            this.colobservacion});
            this.gridView1.GridControl = this.CGMaterial;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colcod_material
            // 
            this.colcod_material.Caption = "Código";
            this.colcod_material.FieldName = "cod_material";
            this.colcod_material.Image = ((System.Drawing.Image)(resources.GetObject("colcod_material.Image")));
            this.colcod_material.Name = "colcod_material";
            this.colcod_material.Visible = true;
            this.colcod_material.VisibleIndex = 0;
            // 
            // colMaterial
            // 
            this.colMaterial.Caption = "Material";
            this.colMaterial.FieldName = "Material";
            this.colMaterial.Image = ((System.Drawing.Image)(resources.GetObject("colMaterial.Image")));
            this.colMaterial.Name = "colMaterial";
            this.colMaterial.Visible = true;
            this.colMaterial.VisibleIndex = 1;
            // 
            // colobservacion
            // 
            this.colobservacion.Caption = "Observación";
            this.colobservacion.FieldName = "observacion";
            this.colobservacion.Image = ((System.Drawing.Image)(resources.GetObject("colobservacion.Image")));
            this.colobservacion.Name = "colobservacion";
            this.colobservacion.Visible = true;
            this.colobservacion.VisibleIndex = 2;
            // 
            // searchControl1
            // 
            this.searchControl1.Client = this.CGMaterial;
            this.searchControl1.Location = new System.Drawing.Point(5, 18);
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl1.Properties.Client = this.CGMaterial;
            this.searchControl1.Properties.NullValuePrompt = "Ingrese el Texto para Buscar";
            this.searchControl1.Size = new System.Drawing.Size(168, 20);
            this.searchControl1.TabIndex = 1;
            // 
            // observacionTextEdit
            // 
            this.observacionTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.materialBindingSource, "observacion", true));
            this.observacionTextEdit.Location = new System.Drawing.Point(98, 76);
            this.observacionTextEdit.Name = "observacionTextEdit";
            this.observacionTextEdit.Size = new System.Drawing.Size(284, 58);
            this.observacionTextEdit.TabIndex = 11;
            // 
            // materialTableAdapter
            // 
            this.materialTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.MaterialTableAdapter = this.materialTableAdapter;
            this.tableAdapterManager.Unidad_MedidaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AQCobranza.DSAQCobranzaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            // 
            // Material
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 391);
            this.Controls.Add(this.groupControl1);
            this.LookAndFeel.SkinName = "Office 2013";
            this.Name = "Material";
            this.Text = "Materiales";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Material_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingNavigator)).EndInit();
            this.materialBindingNavigator.ResumeLayout(false);
            this.materialBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAQCobranza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cod_materialSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CGMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.observacionTextEdit.Properties)).EndInit();
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
        private System.Windows.Forms.BindingSource materialBindingSource;
        private DSAQCobranzaTableAdapters.MaterialTableAdapter materialTableAdapter;
        private DSAQCobranzaTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator materialBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton materialBindingNavigatorSaveItem;
        private DevExpress.XtraEditors.SpinEdit cod_materialSpinEdit;
        private DevExpress.XtraEditors.TextEdit materialTextEdit;
        private DevExpress.XtraGrid.GridControl CGMaterial;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colcod_material;
        private DevExpress.XtraGrid.Columns.GridColumn colMaterial;
        private DevExpress.XtraGrid.Columns.GridColumn colobservacion;
        private DevExpress.XtraEditors.MemoEdit observacionTextEdit;
    }
}