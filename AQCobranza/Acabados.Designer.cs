namespace AQCobranza
{
    partial class Acabados
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
            System.Windows.Forms.Label cod_AcabadosLabel;
            System.Windows.Forms.Label acabadosLabel;
            System.Windows.Forms.Label observacionesLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Acabados));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.acabadosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.acabadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSAQCobranza = new AQCobranza.DSAQCobranza();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.acabadosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.searchControl1 = new DevExpress.XtraEditors.SearchControl();
            this.GCAcabados = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcod_Acabados = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAcabados = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colobservaciones = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cod_AcabadosSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.acabadosTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.observacionesTextEdit = new DevExpress.XtraEditors.MemoEdit();
            this.acabadosTableAdapter = new AQCobranza.DSAQCobranzaTableAdapters.AcabadosTableAdapter();
            this.tableAdapterManager = new AQCobranza.DSAQCobranzaTableAdapters.TableAdapterManager();
            cod_AcabadosLabel = new System.Windows.Forms.Label();
            acabadosLabel = new System.Windows.Forms.Label();
            observacionesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.acabadosBindingNavigator)).BeginInit();
            this.acabadosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.acabadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAQCobranza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GCAcabados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cod_AcabadosSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acabadosTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.observacionesTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cod_AcabadosLabel
            // 
            cod_AcabadosLabel.AutoSize = true;
            cod_AcabadosLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            cod_AcabadosLabel.Location = new System.Drawing.Point(5, 35);
            cod_AcabadosLabel.Name = "cod_AcabadosLabel";
            cod_AcabadosLabel.Size = new System.Drawing.Size(48, 13);
            cod_AcabadosLabel.TabIndex = 0;
            cod_AcabadosLabel.Text = "Código:";
            // 
            // acabadosLabel
            // 
            acabadosLabel.AutoSize = true;
            acabadosLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            acabadosLabel.Location = new System.Drawing.Point(5, 61);
            acabadosLabel.Name = "acabadosLabel";
            acabadosLabel.Size = new System.Drawing.Size(59, 13);
            acabadosLabel.TabIndex = 2;
            acabadosLabel.Text = "Acabado:";
            // 
            // observacionesLabel
            // 
            observacionesLabel.AutoSize = true;
            observacionesLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            observacionesLabel.Location = new System.Drawing.Point(5, 87);
            observacionesLabel.Name = "observacionesLabel";
            observacionesLabel.Size = new System.Drawing.Size(93, 13);
            observacionesLabel.TabIndex = 4;
            observacionesLabel.Text = "Observaciones:";
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImage = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImage")));
            this.groupControl1.Controls.Add(this.splitContainerControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(547, 475);
            this.groupControl1.TabIndex = 9;
            this.groupControl1.Text = "Acabados";
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
            this.splitContainerControl1.Size = new System.Drawing.Size(543, 440);
            this.splitContainerControl1.SplitterPosition = 118;
            this.splitContainerControl1.TabIndex = 7;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.acabadosBindingNavigator);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 0);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(118, 440);
            this.groupControl3.TabIndex = 0;
            // 
            // acabadosBindingNavigator
            // 
            this.acabadosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.acabadosBindingNavigator.BindingSource = this.acabadosBindingSource;
            this.acabadosBindingNavigator.CountItem = null;
            this.acabadosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.acabadosBindingNavigator.Dock = System.Windows.Forms.DockStyle.Left;
            this.acabadosBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.acabadosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.acabadosBindingNavigatorSaveItem});
            this.acabadosBindingNavigator.Location = new System.Drawing.Point(2, 21);
            this.acabadosBindingNavigator.MoveFirstItem = null;
            this.acabadosBindingNavigator.MoveLastItem = null;
            this.acabadosBindingNavigator.MoveNextItem = null;
            this.acabadosBindingNavigator.MovePreviousItem = null;
            this.acabadosBindingNavigator.Name = "acabadosBindingNavigator";
            this.acabadosBindingNavigator.PositionItem = null;
            this.acabadosBindingNavigator.Size = new System.Drawing.Size(103, 417);
            this.acabadosBindingNavigator.TabIndex = 10;
            this.acabadosBindingNavigator.Text = "bindingNavigator1";
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
            // acabadosBindingSource
            // 
            this.acabadosBindingSource.DataMember = "Acabados";
            this.acabadosBindingSource.DataSource = this.dSAQCobranza;
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
            // acabadosBindingNavigatorSaveItem
            // 
            this.acabadosBindingNavigatorSaveItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.acabadosBindingNavigatorSaveItem.Image = global::AQCobranza.Properties.Resources.saveto_32x32;
            this.acabadosBindingNavigatorSaveItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.acabadosBindingNavigatorSaveItem.Name = "acabadosBindingNavigatorSaveItem";
            this.acabadosBindingNavigatorSaveItem.Size = new System.Drawing.Size(100, 36);
            this.acabadosBindingNavigatorSaveItem.Text = "GUARDAR";
            this.acabadosBindingNavigatorSaveItem.Click += new System.EventHandler(this.acabadosBindingNavigatorSaveItem_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.CaptionImage = ((System.Drawing.Image)(resources.GetObject("groupControl2.CaptionImage")));
            this.groupControl2.Controls.Add(this.groupControl4);
            this.groupControl2.Controls.Add(cod_AcabadosLabel);
            this.groupControl2.Controls.Add(this.cod_AcabadosSpinEdit);
            this.groupControl2.Controls.Add(acabadosLabel);
            this.groupControl2.Controls.Add(this.acabadosTextEdit);
            this.groupControl2.Controls.Add(observacionesLabel);
            this.groupControl2.Controls.Add(this.observacionesTextEdit);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(420, 440);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Datos de los Acabados";
            // 
            // groupControl4
            // 
            this.groupControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl4.Controls.Add(this.searchControl1);
            this.groupControl4.Controls.Add(this.GCAcabados);
            this.groupControl4.Location = new System.Drawing.Point(5, 186);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(405, 249);
            this.groupControl4.TabIndex = 6;
            // 
            // searchControl1
            // 
            this.searchControl1.Client = this.GCAcabados;
            this.searchControl1.Location = new System.Drawing.Point(5, 17);
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl1.Properties.Client = this.GCAcabados;
            this.searchControl1.Properties.NullValuePrompt = "Ingrese el Texto para Buscar";
            this.searchControl1.Size = new System.Drawing.Size(168, 20);
            this.searchControl1.TabIndex = 1;
            // 
            // GCAcabados
            // 
            this.GCAcabados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GCAcabados.DataSource = this.acabadosBindingSource;
            this.GCAcabados.Location = new System.Drawing.Point(5, 41);
            this.GCAcabados.MainView = this.gridView1;
            this.GCAcabados.Name = "GCAcabados";
            this.GCAcabados.Size = new System.Drawing.Size(395, 203);
            this.GCAcabados.TabIndex = 0;
            this.GCAcabados.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcod_Acabados,
            this.colAcabados,
            this.colobservaciones});
            this.gridView1.GridControl = this.GCAcabados;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colcod_Acabados
            // 
            this.colcod_Acabados.Caption = "Código";
            this.colcod_Acabados.FieldName = "cod_Acabados";
            this.colcod_Acabados.Image = ((System.Drawing.Image)(resources.GetObject("colcod_Acabados.Image")));
            this.colcod_Acabados.Name = "colcod_Acabados";
            this.colcod_Acabados.Visible = true;
            this.colcod_Acabados.VisibleIndex = 0;
            // 
            // colAcabados
            // 
            this.colAcabados.Caption = "Acabados";
            this.colAcabados.FieldName = "Acabados";
            this.colAcabados.Image = ((System.Drawing.Image)(resources.GetObject("colAcabados.Image")));
            this.colAcabados.Name = "colAcabados";
            this.colAcabados.Visible = true;
            this.colAcabados.VisibleIndex = 1;
            // 
            // colobservaciones
            // 
            this.colobservaciones.Caption = "Observaciones";
            this.colobservaciones.FieldName = "observaciones";
            this.colobservaciones.Image = ((System.Drawing.Image)(resources.GetObject("colobservaciones.Image")));
            this.colobservaciones.Name = "colobservaciones";
            this.colobservaciones.Visible = true;
            this.colobservaciones.VisibleIndex = 2;
            // 
            // cod_AcabadosSpinEdit
            // 
            this.cod_AcabadosSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.acabadosBindingSource, "cod_Acabados", true));
            this.cod_AcabadosSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.cod_AcabadosSpinEdit.Enabled = false;
            this.cod_AcabadosSpinEdit.Location = new System.Drawing.Point(103, 30);
            this.cod_AcabadosSpinEdit.Name = "cod_AcabadosSpinEdit";
            this.cod_AcabadosSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cod_AcabadosSpinEdit.Size = new System.Drawing.Size(84, 20);
            this.cod_AcabadosSpinEdit.TabIndex = 1;
            // 
            // acabadosTextEdit
            // 
            this.acabadosTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.acabadosBindingSource, "Acabados", true));
            this.acabadosTextEdit.Location = new System.Drawing.Point(103, 56);
            this.acabadosTextEdit.Name = "acabadosTextEdit";
            this.acabadosTextEdit.Size = new System.Drawing.Size(216, 20);
            this.acabadosTextEdit.TabIndex = 3;
            // 
            // observacionesTextEdit
            // 
            this.observacionesTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.acabadosBindingSource, "observaciones", true));
            this.observacionesTextEdit.Location = new System.Drawing.Point(103, 82);
            this.observacionesTextEdit.Name = "observacionesTextEdit";
            this.observacionesTextEdit.Size = new System.Drawing.Size(216, 85);
            this.observacionesTextEdit.TabIndex = 5;
            // 
            // acabadosTableAdapter
            // 
            this.acabadosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AcabadosTableAdapter = this.acabadosTableAdapter;
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
            this.tableAdapterManager.Unidad_MedidaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AQCobranza.DSAQCobranzaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            // 
            // Acabados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 475);
            this.Controls.Add(this.groupControl1);
            this.LookAndFeel.SkinName = "Office 2013";
            this.Name = "Acabados";
            this.Text = "Acabados";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Acabados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.acabadosBindingNavigator)).EndInit();
            this.acabadosBindingNavigator.ResumeLayout(false);
            this.acabadosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.acabadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAQCobranza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GCAcabados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cod_AcabadosSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acabadosTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.observacionesTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DSAQCobranza dSAQCobranza;
        private System.Windows.Forms.BindingSource acabadosBindingSource;
        private DSAQCobranzaTableAdapters.AcabadosTableAdapter acabadosTableAdapter;
        private DSAQCobranzaTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator acabadosBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton acabadosBindingNavigatorSaveItem;
        private DevExpress.XtraEditors.SpinEdit cod_AcabadosSpinEdit;
        private DevExpress.XtraEditors.TextEdit acabadosTextEdit;
        private DevExpress.XtraEditors.MemoEdit observacionesTextEdit;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.SearchControl searchControl1;
        private DevExpress.XtraGrid.GridControl GCAcabados;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colcod_Acabados;
        private DevExpress.XtraGrid.Columns.GridColumn colAcabados;
        private DevExpress.XtraGrid.Columns.GridColumn colobservaciones;
    }
}