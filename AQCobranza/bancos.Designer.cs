namespace AQCobranza
{
    partial class bancos
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
            System.Windows.Forms.Label nombre_cortoLabel;
            System.Windows.Forms.Label nombre_largoLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bancos));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bancosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bancosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSAQCobranza = new AQCobranza.DSAQCobranza();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bancosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.bancosGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnombre_corto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre_largo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cod_bancoSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.nombre_cortoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.nombre_largoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.cuenta_bancosGridControl = new DevExpress.XtraGrid.GridControl();
            this.cuenta_bancosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnumero_cuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltipo_moneda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tipo_monedaComboBox = new System.Windows.Forms.ComboBox();
            this.cod_cuentaSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.BntEliminar = new DevExpress.XtraEditors.SimpleButton();
            this.BtnActualizar = new DevExpress.XtraEditors.SimpleButton();
            this.btnRegistrar = new DevExpress.XtraEditors.SimpleButton();
            this.numero_cuentaTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.bancosTableAdapter = new AQCobranza.DSAQCobranzaTableAdapters.BancosTableAdapter();
            this.tableAdapterManager = new AQCobranza.DSAQCobranzaTableAdapters.TableAdapterManager();
            this.cuenta_bancosTableAdapter = new AQCobranza.DSAQCobranzaTableAdapters.Cuenta_bancosTableAdapter();
            nombre_cortoLabel = new System.Windows.Forms.Label();
            nombre_largoLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bancosBindingNavigator)).BeginInit();
            this.bancosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bancosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAQCobranza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bancosGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cod_bancoSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nombre_cortoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nombre_largoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cuenta_bancosGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuenta_bancosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cod_cuentaSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numero_cuentaTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // nombre_cortoLabel
            // 
            nombre_cortoLabel.AutoSize = true;
            nombre_cortoLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            nombre_cortoLabel.Location = new System.Drawing.Point(26, 54);
            nombre_cortoLabel.Name = "nombre_cortoLabel";
            nombre_cortoLabel.Size = new System.Drawing.Size(88, 13);
            nombre_cortoLabel.TabIndex = 2;
            nombre_cortoLabel.Text = "Nombre Corto:";
            // 
            // nombre_largoLabel
            // 
            nombre_largoLabel.AutoSize = true;
            nombre_largoLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            nombre_largoLabel.Location = new System.Drawing.Point(26, 80);
            nombre_largoLabel.Name = "nombre_largoLabel";
            nombre_largoLabel.Size = new System.Drawing.Size(111, 13);
            nombre_largoLabel.TabIndex = 4;
            nombre_largoLabel.Text = "Nombre Completo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            label1.Location = new System.Drawing.Point(26, 28);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(102, 13);
            label1.TabIndex = 6;
            label1.Text = "Código de Banco:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            label2.Location = new System.Drawing.Point(39, 88);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(99, 13);
            label2.TabIndex = 14;
            label2.Text = "Tipo de Moneda:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            label3.Location = new System.Drawing.Point(39, 60);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(102, 13);
            label3.TabIndex = 15;
            label3.Text = "Cuenta Bancaria:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            label4.Location = new System.Drawing.Point(39, 34);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(108, 13);
            label4.TabIndex = 16;
            label4.Text = "Código de Cuenta:";
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImage = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImage")));
            this.groupControl1.Controls.Add(this.splitContainerControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(850, 417);
            this.groupControl1.TabIndex = 9;
            this.groupControl1.Text = "Configuración de Bancos";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(2, 33);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.splitContainerControl1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.splitContainerControl1.Panel2.Controls.Add(this.splitContainerControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(846, 382);
            this.splitContainerControl1.SplitterPosition = 118;
            this.splitContainerControl1.TabIndex = 7;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bancosBindingNavigator);
            this.groupBox1.Location = new System.Drawing.Point(1, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(110, 377);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // bancosBindingNavigator
            // 
            this.bancosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bancosBindingNavigator.BackColor = System.Drawing.Color.Transparent;
            this.bancosBindingNavigator.BindingSource = this.bancosBindingSource;
            this.bancosBindingNavigator.CountItem = null;
            this.bancosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bancosBindingNavigator.Dock = System.Windows.Forms.DockStyle.Left;
            this.bancosBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bancosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.bancosBindingNavigatorSaveItem});
            this.bancosBindingNavigator.Location = new System.Drawing.Point(3, 17);
            this.bancosBindingNavigator.MoveFirstItem = null;
            this.bancosBindingNavigator.MoveLastItem = null;
            this.bancosBindingNavigator.MoveNextItem = null;
            this.bancosBindingNavigator.MovePreviousItem = null;
            this.bancosBindingNavigator.Name = "bancosBindingNavigator";
            this.bancosBindingNavigator.PositionItem = null;
            this.bancosBindingNavigator.Size = new System.Drawing.Size(103, 357);
            this.bancosBindingNavigator.TabIndex = 10;
            this.bancosBindingNavigator.Text = "bindingNavigator1";
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
            // bancosBindingSource
            // 
            this.bancosBindingSource.DataMember = "Bancos";
            this.bancosBindingSource.DataSource = this.dSAQCobranza;
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
            // bancosBindingNavigatorSaveItem
            // 
            this.bancosBindingNavigatorSaveItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.bancosBindingNavigatorSaveItem.Image = global::AQCobranza.Properties.Resources.saveto_32x32;
            this.bancosBindingNavigatorSaveItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bancosBindingNavigatorSaveItem.Name = "bancosBindingNavigatorSaveItem";
            this.bancosBindingNavigatorSaveItem.Size = new System.Drawing.Size(100, 36);
            this.bancosBindingNavigatorSaveItem.Text = "GUARDAR";
            this.bancosBindingNavigatorSaveItem.Click += new System.EventHandler(this.bancosBindingNavigatorSaveItem_Click_3);
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.Controls.Add(this.groupControl2);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.Controls.Add(this.groupControl3);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(719, 378);
            this.splitContainerControl2.SplitterPosition = 321;
            this.splitContainerControl2.TabIndex = 1;
            this.splitContainerControl2.Text = "splitContainerControl2";
            // 
            // groupControl2
            // 
            this.groupControl2.CaptionImage = ((System.Drawing.Image)(resources.GetObject("groupControl2.CaptionImage")));
            this.groupControl2.Controls.Add(this.groupControl4);
            this.groupControl2.Controls.Add(label1);
            this.groupControl2.Controls.Add(this.cod_bancoSpinEdit);
            this.groupControl2.Controls.Add(nombre_cortoLabel);
            this.groupControl2.Controls.Add(this.nombre_cortoTextEdit);
            this.groupControl2.Controls.Add(nombre_largoLabel);
            this.groupControl2.Controls.Add(this.nombre_largoTextEdit);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(321, 378);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Datos del Banco";
            // 
            // groupControl4
            // 
            this.groupControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl4.Controls.Add(this.bancosGridControl);
            this.groupControl4.Location = new System.Drawing.Point(5, 103);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(311, 270);
            this.groupControl4.TabIndex = 7;
            // 
            // bancosGridControl
            // 
            this.bancosGridControl.DataSource = this.bancosBindingSource;
            this.bancosGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bancosGridControl.Location = new System.Drawing.Point(2, 21);
            this.bancosGridControl.MainView = this.gridView1;
            this.bancosGridControl.Name = "bancosGridControl";
            this.bancosGridControl.Size = new System.Drawing.Size(307, 247);
            this.bancosGridControl.TabIndex = 5;
            this.bancosGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.bancosGridControl.Click += new System.EventHandler(this.bancosGridControl_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnombre_corto,
            this.colnombre_largo});
            this.gridView1.GridControl = this.bancosGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            // 
            // colnombre_corto
            // 
            this.colnombre_corto.Caption = "Nombre Corto";
            this.colnombre_corto.FieldName = "nombre_corto";
            this.colnombre_corto.Image = ((System.Drawing.Image)(resources.GetObject("colnombre_corto.Image")));
            this.colnombre_corto.Name = "colnombre_corto";
            this.colnombre_corto.Visible = true;
            this.colnombre_corto.VisibleIndex = 0;
            // 
            // colnombre_largo
            // 
            this.colnombre_largo.Caption = "Nombre Completo";
            this.colnombre_largo.FieldName = "nombre_largo";
            this.colnombre_largo.Image = ((System.Drawing.Image)(resources.GetObject("colnombre_largo.Image")));
            this.colnombre_largo.Name = "colnombre_largo";
            this.colnombre_largo.Visible = true;
            this.colnombre_largo.VisibleIndex = 1;
            // 
            // cod_bancoSpinEdit
            // 
            this.cod_bancoSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bancosBindingSource, "cod_banco", true));
            this.cod_bancoSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.cod_bancoSpinEdit.Enabled = false;
            this.cod_bancoSpinEdit.Location = new System.Drawing.Point(143, 25);
            this.cod_bancoSpinEdit.Name = "cod_bancoSpinEdit";
            this.cod_bancoSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cod_bancoSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.cod_bancoSpinEdit.TabIndex = 1;
            this.cod_bancoSpinEdit.EditValueChanged += new System.EventHandler(this.cod_bancoSpinEdit_EditValueChanged);
            // 
            // nombre_cortoTextEdit
            // 
            this.nombre_cortoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bancosBindingSource, "nombre_corto", true));
            this.nombre_cortoTextEdit.Location = new System.Drawing.Point(143, 51);
            this.nombre_cortoTextEdit.Name = "nombre_cortoTextEdit";
            this.nombre_cortoTextEdit.Size = new System.Drawing.Size(100, 20);
            this.nombre_cortoTextEdit.TabIndex = 3;
            // 
            // nombre_largoTextEdit
            // 
            this.nombre_largoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bancosBindingSource, "nombre_largo", true));
            this.nombre_largoTextEdit.Location = new System.Drawing.Point(143, 77);
            this.nombre_largoTextEdit.Name = "nombre_largoTextEdit";
            this.nombre_largoTextEdit.Size = new System.Drawing.Size(186, 20);
            this.nombre_largoTextEdit.TabIndex = 5;
            // 
            // groupControl3
            // 
            this.groupControl3.CaptionImage = ((System.Drawing.Image)(resources.GetObject("groupControl3.CaptionImage")));
            this.groupControl3.Controls.Add(this.groupControl5);
            this.groupControl3.Controls.Add(label4);
            this.groupControl3.Controls.Add(label3);
            this.groupControl3.Controls.Add(label2);
            this.groupControl3.Controls.Add(this.tipo_monedaComboBox);
            this.groupControl3.Controls.Add(this.cod_cuentaSpinEdit);
            this.groupControl3.Controls.Add(this.BntEliminar);
            this.groupControl3.Controls.Add(this.BtnActualizar);
            this.groupControl3.Controls.Add(this.btnRegistrar);
            this.groupControl3.Controls.Add(this.numero_cuentaTextEdit);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 0);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(393, 378);
            this.groupControl3.TabIndex = 1;
            this.groupControl3.Text = "Datos de la Cuenta Bancaria";
            // 
            // groupControl5
            // 
            this.groupControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl5.Controls.Add(this.cuenta_bancosGridControl);
            this.groupControl5.Location = new System.Drawing.Point(6, 153);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new System.Drawing.Size(365, 220);
            this.groupControl5.TabIndex = 17;
            // 
            // cuenta_bancosGridControl
            // 
            this.cuenta_bancosGridControl.DataSource = this.cuenta_bancosBindingSource;
            this.cuenta_bancosGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cuenta_bancosGridControl.Location = new System.Drawing.Point(2, 20);
            this.cuenta_bancosGridControl.MainView = this.gridView2;
            this.cuenta_bancosGridControl.Name = "cuenta_bancosGridControl";
            this.cuenta_bancosGridControl.Size = new System.Drawing.Size(361, 198);
            this.cuenta_bancosGridControl.TabIndex = 8;
            this.cuenta_bancosGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // cuenta_bancosBindingSource
            // 
            this.cuenta_bancosBindingSource.DataMember = "Cuenta_bancos";
            this.cuenta_bancosBindingSource.DataSource = this.dSAQCobranza;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnumero_cuenta,
            this.coltipo_moneda});
            this.gridView2.GridControl = this.cuenta_bancosGridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colnumero_cuenta
            // 
            this.colnumero_cuenta.FieldName = "numero_cuenta";
            this.colnumero_cuenta.Name = "colnumero_cuenta";
            this.colnumero_cuenta.Visible = true;
            this.colnumero_cuenta.VisibleIndex = 0;
            // 
            // coltipo_moneda
            // 
            this.coltipo_moneda.FieldName = "tipo_moneda";
            this.coltipo_moneda.Name = "coltipo_moneda";
            this.coltipo_moneda.Visible = true;
            this.coltipo_moneda.VisibleIndex = 1;
            // 
            // tipo_monedaComboBox
            // 
            this.tipo_monedaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cuenta_bancosBindingSource, "tipo_moneda", true));
            this.tipo_monedaComboBox.FormattingEnabled = true;
            this.tipo_monedaComboBox.Items.AddRange(new object[] {
            "Soles",
            "Dolares"});
            this.tipo_monedaComboBox.Location = new System.Drawing.Point(153, 83);
            this.tipo_monedaComboBox.Name = "tipo_monedaComboBox";
            this.tipo_monedaComboBox.Size = new System.Drawing.Size(121, 21);
            this.tipo_monedaComboBox.TabIndex = 13;
            // 
            // cod_cuentaSpinEdit
            // 
            this.cod_cuentaSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cuenta_bancosBindingSource, "cod_cuenta", true));
            this.cod_cuentaSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.cod_cuentaSpinEdit.Enabled = false;
            this.cod_cuentaSpinEdit.Location = new System.Drawing.Point(153, 29);
            this.cod_cuentaSpinEdit.Name = "cod_cuentaSpinEdit";
            this.cod_cuentaSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cod_cuentaSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.cod_cuentaSpinEdit.TabIndex = 12;
            // 
            // BntEliminar
            // 
            this.BntEliminar.Image = ((System.Drawing.Image)(resources.GetObject("BntEliminar.Image")));
            this.BntEliminar.Location = new System.Drawing.Point(268, 110);
            this.BntEliminar.Name = "BntEliminar";
            this.BntEliminar.Size = new System.Drawing.Size(99, 35);
            this.BntEliminar.TabIndex = 11;
            this.BntEliminar.Text = "Eliminar";
            this.BntEliminar.Click += new System.EventHandler(this.BntEliminar_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("BtnActualizar.Image")));
            this.BtnActualizar.Location = new System.Drawing.Point(156, 110);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(106, 35);
            this.BtnActualizar.TabIndex = 10;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrar.Image")));
            this.btnRegistrar.Location = new System.Drawing.Point(40, 110);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(108, 35);
            this.btnRegistrar.TabIndex = 9;
            this.btnRegistrar.Text = "Agregar";
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // numero_cuentaTextEdit
            // 
            this.numero_cuentaTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cuenta_bancosBindingSource, "numero_cuenta", true));
            this.numero_cuentaTextEdit.Location = new System.Drawing.Point(153, 55);
            this.numero_cuentaTextEdit.Name = "numero_cuentaTextEdit";
            this.numero_cuentaTextEdit.Size = new System.Drawing.Size(100, 20);
            this.numero_cuentaTextEdit.TabIndex = 5;
            // 
            // bancosTableAdapter
            // 
            this.bancosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AcabadosTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BancosTableAdapter = this.bancosTableAdapter;
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
            // cuenta_bancosTableAdapter
            // 
            this.cuenta_bancosTableAdapter.ClearBeforeFill = true;
            // 
            // bancos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 417);
            this.Controls.Add(this.groupControl1);
            this.LookAndFeel.SkinName = "Office 2013";
            this.Name = "bancos";
            this.Text = "Configuración de Bancos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.bancos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bancosBindingNavigator)).EndInit();
            this.bancosBindingNavigator.ResumeLayout(false);
            this.bancosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bancosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAQCobranza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bancosGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cod_bancoSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nombre_cortoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nombre_largoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cuenta_bancosGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuenta_bancosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cod_cuentaSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numero_cuentaTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraDataLayout.DataLayoutControl bancosDataLayoutControl;
        private DevExpress.XtraDataLayout.DataLayoutControl bancosDataLayoutControl1;
        private DSAQCobranza dSAQCobranza;
        private System.Windows.Forms.BindingSource bancosBindingSource;
        private DSAQCobranzaTableAdapters.BancosTableAdapter bancosTableAdapter;
        private DSAQCobranzaTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator bancosBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bancosBindingNavigatorSaveItem;
        private DevExpress.XtraEditors.SpinEdit cod_bancoSpinEdit;
        private DevExpress.XtraEditors.TextEdit nombre_cortoTextEdit;
        private DevExpress.XtraEditors.TextEdit nombre_largoTextEdit;
        private DevExpress.XtraGrid.GridControl bancosGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre_corto;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre_largo;
        private System.Windows.Forms.BindingSource cuenta_bancosBindingSource;
        private DSAQCobranzaTableAdapters.Cuenta_bancosTableAdapter cuenta_bancosTableAdapter;
        private DevExpress.XtraGrid.GridControl cuenta_bancosGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.TextEdit numero_cuentaTextEdit;
        private DevExpress.XtraEditors.SpinEdit cod_cuentaSpinEdit;
        private DevExpress.XtraEditors.SimpleButton BntEliminar;
        private DevExpress.XtraEditors.SimpleButton BtnActualizar;
        private DevExpress.XtraEditors.SimpleButton btnRegistrar;
        private DevExpress.XtraGrid.Columns.GridColumn colnumero_cuenta;
        private DevExpress.XtraGrid.Columns.GridColumn coltipo_moneda;
        private System.Windows.Forms.ComboBox tipo_monedaComboBox;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.GroupControl groupControl5;
    }
}