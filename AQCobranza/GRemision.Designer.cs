namespace AQCobranza
{
    partial class GRemision
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GRemision));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.PCOcompra = new DevExpress.XtraEditors.PopupContainerControl();
            this.CGOCompra = new DevExpress.XtraGrid.GridControl();
            this.orden_de_CompraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSAQCobranza = new AQCobranza.DSAQCobranza();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcod_orden = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcod_orden_empresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcod_cot = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRuc_DNI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComprador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BusOrd = new DevExpress.XtraEditors.SearchControl();
            this.btnActualizar = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.btnRegistrar = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.lblid_compro = new DevExpress.XtraEditors.LabelControl();
            this.documento_pagoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.serieTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.abreTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.headerGremisionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnActua_Guia = new DevExpress.XtraEditors.SimpleButton();
            this.txtCod_cliente = new DevExpress.XtraEditors.TextEdit();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.txtTPlaca = new DevExpress.XtraEditors.TextEdit();
            this.TXTTRuc = new DevExpress.XtraEditors.TextEdit();
            this.txtTDomicilio = new DevExpress.XtraEditors.TextEdit();
            this.txtTransportista = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.TxtDomicilio = new DevExpress.XtraEditors.TextEdit();
            this.txtDestinatario = new DevExpress.XtraEditors.TextEdit();
            this.txtCod_Gremision = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txtcod_orden = new DevExpress.XtraEditors.PopupContainerEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnImprimir = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.ps_Generar_DTGremisionGridControl = new DevExpress.XtraGrid.GridControl();
            this.ps_Generar_DTGremisionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDet_Cot = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCod_concep = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colconcepto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmedida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnidadesXentregar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_unidades = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colflag_entregado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblcot_eliminar = new DevExpress.XtraEditors.LabelControl();
            this.TxtFecha = new DevExpress.XtraEditors.DateEdit();
            this.orden_de_CompraTableAdapter = new AQCobranza.DSAQCobranzaTableAdapters.Orden_de_CompraTableAdapter();
            this.tableAdapterManager = new AQCobranza.DSAQCobranzaTableAdapters.TableAdapterManager();
            this.ps_Generar_DTGremisionTableAdapter = new AQCobranza.DSAQCobranzaTableAdapters.ps_Generar_DTGremisionTableAdapter();
            this.header_GremisionTableAdapter = new AQCobranza.DSAQCobranzaTableAdapters.Header_GremisionTableAdapter();
            this.documento_pagoTableAdapter = new AQCobranza.DSAQCobranzaTableAdapters.Documento_pagoTableAdapter();
            this.header_PagoTableAdapter1 = new AQCobranza.DSAQCobranzaTableAdapters.Header_PagoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCOcompra)).BeginInit();
            this.PCOcompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CGOCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orden_de_CompraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAQCobranza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BusOrd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documento_pagoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serieTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abreTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerGremisionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCod_cliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTPlaca.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXTTRuc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTDomicilio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransportista.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDomicilio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDestinatario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCod_Gremision.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcod_orden.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ps_Generar_DTGremisionGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ps_Generar_DTGremisionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFecha.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFecha.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImage = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImage")));
            this.groupControl1.Controls.Add(this.splitContainerControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(938, 643);
            this.groupControl1.TabIndex = 10;
            this.groupControl1.Text = "Guía de Remisión";
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
            this.splitContainerControl1.Size = new System.Drawing.Size(934, 602);
            this.splitContainerControl1.SplitterPosition = 169;
            this.splitContainerControl1.TabIndex = 7;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.PCOcompra);
            this.groupControl3.Controls.Add(this.btnActualizar);
            this.groupControl3.Controls.Add(this.simpleButton2);
            this.groupControl3.Controls.Add(this.btnRegistrar);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 0);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(169, 602);
            this.groupControl3.TabIndex = 0;
            // 
            // PCOcompra
            // 
            this.PCOcompra.Controls.Add(this.CGOCompra);
            this.PCOcompra.Controls.Add(this.BusOrd);
            this.PCOcompra.Location = new System.Drawing.Point(11, 231);
            this.PCOcompra.Name = "PCOcompra";
            this.PCOcompra.Size = new System.Drawing.Size(708, 323);
            this.PCOcompra.TabIndex = 9;
            // 
            // CGOCompra
            // 
            this.CGOCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CGOCompra.DataSource = this.orden_de_CompraBindingSource;
            this.CGOCompra.Location = new System.Drawing.Point(6, 29);
            this.CGOCompra.MainView = this.gridView1;
            this.CGOCompra.Name = "CGOCompra";
            this.CGOCompra.Size = new System.Drawing.Size(689, 279);
            this.CGOCompra.TabIndex = 16;
            this.CGOCompra.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.CGOCompra.Click += new System.EventHandler(this.orden_de_CompraGridControl_Click);
            // 
            // orden_de_CompraBindingSource
            // 
            this.orden_de_CompraBindingSource.DataMember = "Orden de Compra";
            this.orden_de_CompraBindingSource.DataSource = this.dSAQCobranza;
            // 
            // dSAQCobranza
            // 
            this.dSAQCobranza.DataSetName = "DSAQCobranza";
            this.dSAQCobranza.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.ActiveFilterString = "[fecha] >= LocalDateTimeThisWeek() And [fecha] < LocalDateTimeTomorrow()";
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcod_orden,
            this.colcod_orden_empresa,
            this.colcod_cot,
            this.colfecha,
            this.colRuc_DNI,
            this.colNombre,
            this.colComprador});
            this.gridView1.GridControl = this.CGOCompra;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colfecha, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colcod_orden
            // 
            this.colcod_orden.Caption = "Código";
            this.colcod_orden.FieldName = "cod_orden";
            this.colcod_orden.Name = "colcod_orden";
            this.colcod_orden.Visible = true;
            this.colcod_orden.VisibleIndex = 0;
            // 
            // colcod_orden_empresa
            // 
            this.colcod_orden_empresa.Caption = "Código Empresa";
            this.colcod_orden_empresa.FieldName = "cod_orden_empresa";
            this.colcod_orden_empresa.Name = "colcod_orden_empresa";
            this.colcod_orden_empresa.Visible = true;
            this.colcod_orden_empresa.VisibleIndex = 1;
            // 
            // colcod_cot
            // 
            this.colcod_cot.Caption = "Cotización";
            this.colcod_cot.FieldName = "cod_cot";
            this.colcod_cot.Name = "colcod_cot";
            this.colcod_cot.Visible = true;
            this.colcod_cot.VisibleIndex = 2;
            // 
            // colfecha
            // 
            this.colfecha.Caption = "Fecha";
            this.colfecha.FieldName = "fecha";
            this.colfecha.Name = "colfecha";
            this.colfecha.Visible = true;
            this.colfecha.VisibleIndex = 3;
            // 
            // colRuc_DNI
            // 
            this.colRuc_DNI.Caption = "RUC_DNI";
            this.colRuc_DNI.FieldName = "Ruc_DNI";
            this.colRuc_DNI.Name = "colRuc_DNI";
            this.colRuc_DNI.Visible = true;
            this.colRuc_DNI.VisibleIndex = 4;
            // 
            // colNombre
            // 
            this.colNombre.Caption = "Nombre/RazonSocial ";
            this.colNombre.FieldName = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 5;
            // 
            // colComprador
            // 
            this.colComprador.Caption = "Comprador";
            this.colComprador.FieldName = "Comprador";
            this.colComprador.Name = "colComprador";
            this.colComprador.Visible = true;
            this.colComprador.VisibleIndex = 6;
            // 
            // BusOrd
            // 
            this.BusOrd.Client = this.CGOCompra;
            this.BusOrd.Location = new System.Drawing.Point(6, 3);
            this.BusOrd.Name = "BusOrd";
            this.BusOrd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.BusOrd.Properties.Client = this.CGOCompra;
            this.BusOrd.Properties.NullValuePrompt = "Ingrese el Texto a Buscar:";
            this.BusOrd.Size = new System.Drawing.Size(140, 20);
            this.BusOrd.TabIndex = 16;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.Location = new System.Drawing.Point(5, 58);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(119, 34);
            this.btnActualizar.TabIndex = 5;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.Visible = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(5, 98);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(119, 34);
            this.simpleButton2.TabIndex = 4;
            this.simpleButton2.Text = "Nuevo";
            this.simpleButton2.Visible = false;
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrar.Image")));
            this.btnRegistrar.Location = new System.Drawing.Point(5, 20);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(119, 34);
            this.btnRegistrar.TabIndex = 0;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.CaptionImage = ((System.Drawing.Image)(resources.GetObject("groupControl2.CaptionImage")));
            this.groupControl2.Controls.Add(this.lblid_compro);
            this.groupControl2.Controls.Add(this.labelControl12);
            this.groupControl2.Controls.Add(this.serieTextEdit);
            this.groupControl2.Controls.Add(this.abreTextEdit);
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.Controls.Add(this.comboBox1);
            this.groupControl2.Controls.Add(this.btnActua_Guia);
            this.groupControl2.Controls.Add(this.txtCod_cliente);
            this.groupControl2.Controls.Add(this.groupControl5);
            this.groupControl2.Controls.Add(this.TxtDomicilio);
            this.groupControl2.Controls.Add(this.txtDestinatario);
            this.groupControl2.Controls.Add(this.txtCod_Gremision);
            this.groupControl2.Controls.Add(this.labelControl11);
            this.groupControl2.Controls.Add(this.txtcod_orden);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Controls.Add(this.btnImprimir);
            this.groupControl2.Controls.Add(this.groupControl4);
            this.groupControl2.Controls.Add(this.TxtFecha);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(760, 602);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Datos de la Guia";
            // 
            // lblid_compro
            // 
            this.lblid_compro.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.documento_pagoBindingSource, "cod_documen", true));
            this.lblid_compro.Location = new System.Drawing.Point(119, 3);
            this.lblid_compro.Name = "lblid_compro";
            this.lblid_compro.Size = new System.Drawing.Size(10, 13);
            this.lblid_compro.TabIndex = 59;
            this.lblid_compro.Text = "??";
            // 
            // documento_pagoBindingSource
            // 
            this.documento_pagoBindingSource.DataMember = "Documento_pago";
            this.documento_pagoBindingSource.DataSource = this.dSAQCobranza;
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(189, 35);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(4, 13);
            this.labelControl12.TabIndex = 58;
            this.labelControl12.Text = "-";
            // 
            // serieTextEdit
            // 
            this.serieTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.documento_pagoBindingSource, "serie", true));
            this.serieTextEdit.Enabled = false;
            this.serieTextEdit.Location = new System.Drawing.Point(156, 33);
            this.serieTextEdit.Name = "serieTextEdit";
            this.serieTextEdit.Size = new System.Drawing.Size(30, 20);
            this.serieTextEdit.TabIndex = 57;
            // 
            // abreTextEdit
            // 
            this.abreTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.documento_pagoBindingSource, "abre", true));
            this.abreTextEdit.Enabled = false;
            this.abreTextEdit.Location = new System.Drawing.Point(119, 33);
            this.abreTextEdit.Name = "abreTextEdit";
            this.abreTextEdit.Size = new System.Drawing.Size(35, 20);
            this.abreTextEdit.TabIndex = 56;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Location = new System.Drawing.Point(16, 220);
            this.labelControl6.LookAndFeel.SkinName = "Office 2013";
            this.labelControl6.LookAndFeel.UseDefaultLookAndFeel = false;
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(97, 13);
            this.labelControl6.TabIndex = 55;
            this.labelControl6.Text = "Guias Anteriores:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.headerGremisionBindingSource;
            this.comboBox1.DisplayMember = "cod_Gremision";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(119, 215);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 54;
            this.comboBox1.ValueMember = "cod_Gremision";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // headerGremisionBindingSource
            // 
            this.headerGremisionBindingSource.DataMember = "Header_Gremision";
            this.headerGremisionBindingSource.DataSource = this.dSAQCobranza;
            // 
            // btnActua_Guia
            // 
            this.btnActua_Guia.Image = ((System.Drawing.Image)(resources.GetObject("btnActua_Guia.Image")));
            this.btnActua_Guia.Location = new System.Drawing.Point(390, 207);
            this.btnActua_Guia.Name = "btnActua_Guia";
            this.btnActua_Guia.Size = new System.Drawing.Size(136, 36);
            this.btnActua_Guia.TabIndex = 53;
            this.btnActua_Guia.Text = "Eliminar Guía";
            this.btnActua_Guia.Click += new System.EventHandler(this.btnActua_Guia_Click);
            // 
            // txtCod_cliente
            // 
            this.txtCod_cliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orden_de_CompraBindingSource, "Ruc_DNI", true));
            this.txtCod_cliente.Enabled = false;
            this.txtCod_cliente.Location = new System.Drawing.Point(119, 91);
            this.txtCod_cliente.Name = "txtCod_cliente";
            this.txtCod_cliente.Size = new System.Drawing.Size(119, 20);
            this.txtCod_cliente.TabIndex = 52;
            // 
            // groupControl5
            // 
            this.groupControl5.CaptionImage = ((System.Drawing.Image)(resources.GetObject("groupControl5.CaptionImage")));
            this.groupControl5.Controls.Add(this.txtTPlaca);
            this.groupControl5.Controls.Add(this.TXTTRuc);
            this.groupControl5.Controls.Add(this.txtTDomicilio);
            this.groupControl5.Controls.Add(this.txtTransportista);
            this.groupControl5.Controls.Add(this.labelControl10);
            this.groupControl5.Controls.Add(this.labelControl9);
            this.groupControl5.Controls.Add(this.labelControl8);
            this.groupControl5.Controls.Add(this.labelControl7);
            this.groupControl5.Location = new System.Drawing.Point(353, 17);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new System.Drawing.Size(395, 142);
            this.groupControl5.TabIndex = 51;
            this.groupControl5.Text = "Transportista";
            // 
            // txtTPlaca
            // 
            this.txtTPlaca.Location = new System.Drawing.Point(94, 109);
            this.txtTPlaca.Name = "txtTPlaca";
            this.txtTPlaca.Size = new System.Drawing.Size(164, 20);
            this.txtTPlaca.TabIndex = 50;
            // 
            // TXTTRuc
            // 
            this.TXTTRuc.Location = new System.Drawing.Point(94, 78);
            this.TXTTRuc.Name = "TXTTRuc";
            this.TXTTRuc.Size = new System.Drawing.Size(164, 20);
            this.TXTTRuc.TabIndex = 49;
            // 
            // txtTDomicilio
            // 
            this.txtTDomicilio.Location = new System.Drawing.Point(94, 51);
            this.txtTDomicilio.Name = "txtTDomicilio";
            this.txtTDomicilio.Size = new System.Drawing.Size(290, 20);
            this.txtTDomicilio.TabIndex = 48;
            // 
            // txtTransportista
            // 
            this.txtTransportista.Location = new System.Drawing.Point(94, 25);
            this.txtTransportista.Name = "txtTransportista";
            this.txtTransportista.Size = new System.Drawing.Size(290, 20);
            this.txtTransportista.TabIndex = 47;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl10.Location = new System.Drawing.Point(58, 112);
            this.labelControl10.LookAndFeel.SkinName = "Office 2013";
            this.labelControl10.LookAndFeel.UseDefaultLookAndFeel = false;
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(33, 13);
            this.labelControl10.TabIndex = 40;
            this.labelControl10.Text = "Placa:";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl9.Location = new System.Drawing.Point(67, 81);
            this.labelControl9.LookAndFeel.SkinName = "Office 2013";
            this.labelControl9.LookAndFeel.UseDefaultLookAndFeel = false;
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(24, 13);
            this.labelControl9.TabIndex = 39;
            this.labelControl9.Text = "Ruc:";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl8.Location = new System.Drawing.Point(37, 55);
            this.labelControl8.LookAndFeel.SkinName = "Office 2013";
            this.labelControl8.LookAndFeel.UseDefaultLookAndFeel = false;
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(54, 13);
            this.labelControl8.TabIndex = 38;
            this.labelControl8.Text = "Domicilio:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl7.Location = new System.Drawing.Point(8, 28);
            this.labelControl7.LookAndFeel.SkinName = "Office 2013";
            this.labelControl7.LookAndFeel.UseDefaultLookAndFeel = false;
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(80, 13);
            this.labelControl7.TabIndex = 37;
            this.labelControl7.Text = "Transportista:";
            // 
            // TxtDomicilio
            // 
            this.TxtDomicilio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orden_de_CompraBindingSource, "Direccion", true));
            this.TxtDomicilio.Enabled = false;
            this.TxtDomicilio.Location = new System.Drawing.Point(119, 181);
            this.TxtDomicilio.Name = "TxtDomicilio";
            this.TxtDomicilio.Size = new System.Drawing.Size(389, 20);
            this.TxtDomicilio.TabIndex = 45;
            // 
            // txtDestinatario
            // 
            this.txtDestinatario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orden_de_CompraBindingSource, "Nombre", true));
            this.txtDestinatario.Enabled = false;
            this.txtDestinatario.Location = new System.Drawing.Point(119, 153);
            this.txtDestinatario.Name = "txtDestinatario";
            this.txtDestinatario.Size = new System.Drawing.Size(228, 20);
            this.txtDestinatario.TabIndex = 44;
            // 
            // txtCod_Gremision
            // 
            this.txtCod_Gremision.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.documento_pagoBindingSource, "correlativ", true));
            this.txtCod_Gremision.Enabled = false;
            this.txtCod_Gremision.Location = new System.Drawing.Point(197, 33);
            this.txtCod_Gremision.Name = "txtCod_Gremision";
            this.txtCod_Gremision.Size = new System.Drawing.Size(75, 20);
            this.txtCod_Gremision.TabIndex = 42;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl11.Location = new System.Drawing.Point(28, 66);
            this.labelControl11.LookAndFeel.SkinName = "Office 2013";
            this.labelControl11.LookAndFeel.UseDefaultLookAndFeel = false;
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(84, 13);
            this.labelControl11.TabIndex = 41;
            this.labelControl11.Text = "Orden Compra:";
            // 
            // txtcod_orden
            // 
            this.txtcod_orden.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orden_de_CompraBindingSource, "cod_orden", true));
            this.txtcod_orden.Location = new System.Drawing.Point(119, 62);
            this.txtcod_orden.Name = "txtcod_orden";
            this.txtcod_orden.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtcod_orden.Properties.PopupControl = this.PCOcompra;
            this.txtcod_orden.Size = new System.Drawing.Size(119, 20);
            this.txtcod_orden.TabIndex = 8;
            this.txtcod_orden.Click += new System.EventHandler(this.txtcod_orden_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Location = new System.Drawing.Point(28, 93);
            this.labelControl5.LookAndFeel.SkinName = "Office 2013";
            this.labelControl5.LookAndFeel.UseDefaultLookAndFeel = false;
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(50, 13);
            this.labelControl5.TabIndex = 36;
            this.labelControl5.Text = "Ruc/DNI:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Location = new System.Drawing.Point(28, 186);
            this.labelControl4.LookAndFeel.SkinName = "Office 2013";
            this.labelControl4.LookAndFeel.UseDefaultLookAndFeel = false;
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(54, 13);
            this.labelControl4.TabIndex = 35;
            this.labelControl4.Text = "Domicilio:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Location = new System.Drawing.Point(28, 155);
            this.labelControl3.LookAndFeel.SkinName = "Office 2013";
            this.labelControl3.LookAndFeel.UseDefaultLookAndFeel = false;
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(73, 13);
            this.labelControl3.TabIndex = 34;
            this.labelControl3.Text = "Destinatario:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Location = new System.Drawing.Point(28, 125);
            this.labelControl2.LookAndFeel.SkinName = "Office 2013";
            this.labelControl2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(36, 13);
            this.labelControl2.TabIndex = 33;
            this.labelControl2.Text = "Fecha:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(28, 36);
            this.labelControl1.LookAndFeel.SkinName = "Office 2013";
            this.labelControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(41, 13);
            this.labelControl1.TabIndex = 32;
            this.labelControl1.Text = "Código:";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.Location = new System.Drawing.Point(246, 207);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(121, 36);
            this.btnImprimir.TabIndex = 31;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // groupControl4
            // 
            this.groupControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl4.CaptionImage = ((System.Drawing.Image)(resources.GetObject("groupControl4.CaptionImage")));
            this.groupControl4.Controls.Add(this.ps_Generar_DTGremisionGridControl);
            this.groupControl4.Controls.Add(this.lblcot_eliminar);
            this.groupControl4.Location = new System.Drawing.Point(22, 251);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(729, 341);
            this.groupControl4.TabIndex = 11;
            this.groupControl4.Text = "Conceptos";
            // 
            // ps_Generar_DTGremisionGridControl
            // 
            this.ps_Generar_DTGremisionGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ps_Generar_DTGremisionGridControl.DataSource = this.ps_Generar_DTGremisionBindingSource;
            this.ps_Generar_DTGremisionGridControl.Location = new System.Drawing.Point(14, 26);
            this.ps_Generar_DTGremisionGridControl.MainView = this.gridView2;
            this.ps_Generar_DTGremisionGridControl.Name = "ps_Generar_DTGremisionGridControl";
            this.ps_Generar_DTGremisionGridControl.Size = new System.Drawing.Size(708, 301);
            this.ps_Generar_DTGremisionGridControl.TabIndex = 17;
            this.ps_Generar_DTGremisionGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // ps_Generar_DTGremisionBindingSource
            // 
            this.ps_Generar_DTGremisionBindingSource.DataMember = "ps_Generar_DTGremision";
            this.ps_Generar_DTGremisionBindingSource.DataSource = this.dSAQCobranza;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDet_Cot,
            this.colCod_concep,
            this.colconcepto,
            this.colmedida,
            this.colUnidadesXentregar,
            this.col_unidades,
            this.colUnidad,
            this.colflag_entregado});
            this.gridView2.GridControl = this.ps_Generar_DTGremisionGridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colDet_Cot
            // 
            this.colDet_Cot.Caption = "Código Detalle";
            this.colDet_Cot.FieldName = "Det_Cot";
            this.colDet_Cot.Name = "colDet_Cot";
            this.colDet_Cot.OptionsColumn.AllowEdit = false;
            // 
            // colCod_concep
            // 
            this.colCod_concep.Caption = "Código Concepto";
            this.colCod_concep.FieldName = "Cod_concep";
            this.colCod_concep.Name = "colCod_concep";
            this.colCod_concep.OptionsColumn.AllowEdit = false;
            this.colCod_concep.Visible = true;
            this.colCod_concep.VisibleIndex = 0;
            // 
            // colconcepto
            // 
            this.colconcepto.Caption = "Concepto";
            this.colconcepto.FieldName = "concepto";
            this.colconcepto.Name = "colconcepto";
            this.colconcepto.OptionsColumn.AllowEdit = false;
            this.colconcepto.Visible = true;
            this.colconcepto.VisibleIndex = 1;
            // 
            // colmedida
            // 
            this.colmedida.Caption = "Medida";
            this.colmedida.FieldName = "medida";
            this.colmedida.Name = "colmedida";
            this.colmedida.OptionsColumn.AllowEdit = false;
            this.colmedida.Visible = true;
            this.colmedida.VisibleIndex = 5;
            // 
            // colUnidadesXentregar
            // 
            this.colUnidadesXentregar.Caption = "Unidades por Entregar";
            this.colUnidadesXentregar.FieldName = "UnidadesXentregar";
            this.colUnidadesXentregar.Name = "colUnidadesXentregar";
            this.colUnidadesXentregar.Visible = true;
            this.colUnidadesXentregar.VisibleIndex = 3;
            // 
            // col_unidades
            // 
            this.col_unidades.Caption = "Unidades en TOTAL";
            this.col_unidades.FieldName = "Unidades";
            this.col_unidades.Name = "col_unidades";
            this.col_unidades.OptionsColumn.AllowEdit = false;
            this.col_unidades.Visible = true;
            this.col_unidades.VisibleIndex = 2;
            // 
            // colUnidad
            // 
            this.colUnidad.Caption = "Unidad";
            this.colUnidad.FieldName = "Unidad";
            this.colUnidad.Name = "colUnidad";
            this.colUnidad.OptionsColumn.AllowEdit = false;
            this.colUnidad.Visible = true;
            this.colUnidad.VisibleIndex = 6;
            // 
            // colflag_entregado
            // 
            this.colflag_entregado.Caption = "Entregado";
            this.colflag_entregado.FieldName = "flag_entregado";
            this.colflag_entregado.Name = "colflag_entregado";
            this.colflag_entregado.Visible = true;
            this.colflag_entregado.VisibleIndex = 4;
            // 
            // lblcot_eliminar
            // 
            this.lblcot_eliminar.Appearance.Font = new System.Drawing.Font("Tahoma", 1F);
            this.lblcot_eliminar.Location = new System.Drawing.Point(209, 68);
            this.lblcot_eliminar.Name = "lblcot_eliminar";
            this.lblcot_eliminar.Size = new System.Drawing.Size(0, 2);
            this.lblcot_eliminar.TabIndex = 17;
            // 
            // TxtFecha
            // 
            this.TxtFecha.EditValue = null;
            this.TxtFecha.Location = new System.Drawing.Point(119, 125);
            this.TxtFecha.Name = "TxtFecha";
            this.TxtFecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TxtFecha.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TxtFecha.Properties.DisplayFormat.FormatString = "";
            this.TxtFecha.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.TxtFecha.Properties.EditFormat.FormatString = "";
            this.TxtFecha.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.TxtFecha.Properties.Mask.EditMask = "";
            this.TxtFecha.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.TxtFecha.Size = new System.Drawing.Size(119, 20);
            this.TxtFecha.TabIndex = 43;
            // 
            // orden_de_CompraTableAdapter
            // 
            this.orden_de_CompraTableAdapter.ClearBeforeFill = true;
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
            // ps_Generar_DTGremisionTableAdapter
            // 
            this.ps_Generar_DTGremisionTableAdapter.ClearBeforeFill = true;
            // 
            // header_GremisionTableAdapter
            // 
            this.header_GremisionTableAdapter.ClearBeforeFill = true;
            // 
            // documento_pagoTableAdapter
            // 
            this.documento_pagoTableAdapter.ClearBeforeFill = true;
            // 
            // header_PagoTableAdapter1
            // 
            this.header_PagoTableAdapter1.ClearBeforeFill = true;
            // 
            // GRemision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 643);
            this.Controls.Add(this.groupControl1);
            this.LookAndFeel.SkinName = "Office 2013";
            this.Name = "GRemision";
            this.Text = "Guía de Remisión";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GRemision_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PCOcompra)).EndInit();
            this.PCOcompra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CGOCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orden_de_CompraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAQCobranza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BusOrd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documento_pagoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serieTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abreTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerGremisionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCod_cliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            this.groupControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTPlaca.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXTTRuc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTDomicilio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransportista.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDomicilio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDestinatario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCod_Gremision.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcod_orden.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.groupControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ps_Generar_DTGremisionGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ps_Generar_DTGremisionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFecha.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFecha.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.PopupContainerControl PCOcompra;
        private DevExpress.XtraEditors.SearchControl BusOrd;
        private DevExpress.XtraEditors.PopupContainerEdit txtcod_orden;
        private DevExpress.XtraEditors.SimpleButton btnActualizar;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton btnRegistrar;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnImprimir;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.LabelControl lblcot_eliminar;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.GroupControl groupControl5;
        private DevExpress.XtraEditors.TextEdit txtTPlaca;
        private DevExpress.XtraEditors.TextEdit TXTTRuc;
        private DevExpress.XtraEditors.TextEdit txtTDomicilio;
        private DevExpress.XtraEditors.TextEdit txtTransportista;
        private DevExpress.XtraEditors.TextEdit TxtDomicilio;
        private DevExpress.XtraEditors.TextEdit txtDestinatario;
        private DevExpress.XtraEditors.TextEdit txtCod_Gremision;
        private DevExpress.XtraEditors.DateEdit TxtFecha;
        private DSAQCobranza dSAQCobranza;
        private System.Windows.Forms.BindingSource orden_de_CompraBindingSource;
        private DSAQCobranzaTableAdapters.Orden_de_CompraTableAdapter orden_de_CompraTableAdapter;
        private DSAQCobranzaTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl CGOCompra;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colcod_orden;
        private DevExpress.XtraGrid.Columns.GridColumn colcod_orden_empresa;
        private DevExpress.XtraGrid.Columns.GridColumn colcod_cot;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha;
        private DevExpress.XtraGrid.Columns.GridColumn colRuc_DNI;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colComprador;
        private DevExpress.XtraEditors.TextEdit txtCod_cliente;
        private System.Windows.Forms.BindingSource ps_Generar_DTGremisionBindingSource;
        private DSAQCobranzaTableAdapters.ps_Generar_DTGremisionTableAdapter ps_Generar_DTGremisionTableAdapter;
        private DevExpress.XtraGrid.GridControl ps_Generar_DTGremisionGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colDet_Cot;
        private DevExpress.XtraGrid.Columns.GridColumn colconcepto;
        private DevExpress.XtraGrid.Columns.GridColumn colmedida;
        private DevExpress.XtraGrid.Columns.GridColumn colUnidadesXentregar;
        private DevExpress.XtraGrid.Columns.GridColumn colUnidad;
        private DevExpress.XtraGrid.Columns.GridColumn colflag_entregado;
        private DevExpress.XtraGrid.Columns.GridColumn colCod_concep;
        private DevExpress.XtraGrid.Columns.GridColumn col_unidades;
        private DevExpress.XtraEditors.SimpleButton btnActua_Guia;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource headerGremisionBindingSource;
        private DSAQCobranzaTableAdapters.Header_GremisionTableAdapter header_GremisionTableAdapter;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.BindingSource documento_pagoBindingSource;
        private DSAQCobranzaTableAdapters.Documento_pagoTableAdapter documento_pagoTableAdapter;
        private DevExpress.XtraEditors.TextEdit serieTextEdit;
        private DevExpress.XtraEditors.TextEdit abreTextEdit;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl lblid_compro;
        private DSAQCobranzaTableAdapters.Header_PagoTableAdapter header_PagoTableAdapter1;
    }
}