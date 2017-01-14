namespace AQCobranza
{
    partial class Nota_credito
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
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label montoLabel;
            System.Windows.Forms.Label cod_usuarioLabel;
            System.Windows.Forms.Label tipo_docLabel;
            System.Windows.Forms.Label comprobanteLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nota_credito));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.ps_NC_BuscarGridControl = new DevExpress.XtraGrid.GridControl();
            this.ps_NC_BuscarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSCaja = new AQCobranza.DSCaja();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_nc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmonto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcod_usuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcomprobante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.popupContainerControl1 = new DevExpress.XtraEditors.PopupContainerControl();
            this.groupControl6 = new DevExpress.XtraEditors.GroupControl();
            this.view_ComprobanteGridControl = new DevExpress.XtraGrid.GridControl();
            this.headerPagoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSAQCobranza = new AQCobranza.DSAQCobranza();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnBuscar = new DevExpress.XtraEditors.SimpleButton();
            this.txtCompro_bus = new DevExpress.XtraEditors.TextEdit();
            this.id_ncLabel1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSerie = new DevExpress.XtraEditors.TextEdit();
            this.documentopagoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtTpago = new System.Windows.Forms.Label();
            this.txtComprobante = new DevExpress.XtraEditors.TextEdit();
            this.cbTpago = new System.Windows.Forms.ComboBox();
            this.cod_usuarioTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.estadoCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.fechaTextEdit = new DevExpress.XtraEditors.DateEdit();
            this.comprobanteTextEdit = new DevExpress.XtraEditors.PopupContainerEdit();
            this.montoSpinEdit = new DevExpress.XtraEditors.TextEdit();
            this.nota_creditoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nota_creditoTableAdapter = new AQCobranza.DSCajaTableAdapters.Nota_creditoTableAdapter();
            this.tableAdapterManager = new AQCobranza.DSCajaTableAdapters.TableAdapterManager();
            this.documento_pagoTableAdapter = new AQCobranza.DSAQCobranzaTableAdapters.Documento_pagoTableAdapter();
            this.header_PagoTableAdapter = new AQCobranza.DSAQCobranzaTableAdapters.Header_PagoTableAdapter();
            this.ps_NC_BuscarTableAdapter = new AQCobranza.DSCajaTableAdapters.ps_NC_BuscarTableAdapter();
            fechaLabel = new System.Windows.Forms.Label();
            montoLabel = new System.Windows.Forms.Label();
            cod_usuarioLabel = new System.Windows.Forms.Label();
            tipo_docLabel = new System.Windows.Forms.Label();
            comprobanteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ps_NC_BuscarGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ps_NC_BuscarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSCaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupContainerControl1)).BeginInit();
            this.popupContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).BeginInit();
            this.groupControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_ComprobanteGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerPagoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAQCobranza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompro_bus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSerie.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentopagoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComprobante.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cod_usuarioTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechaTextEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechaTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprobanteTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.montoSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nota_creditoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(11, 95);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(38, 13);
            fechaLabel.TabIndex = 5;
            fechaLabel.Text = "fecha:";
            // 
            // montoLabel
            // 
            montoLabel.AutoSize = true;
            montoLabel.Location = new System.Drawing.Point(11, 149);
            montoLabel.Name = "montoLabel";
            montoLabel.Size = new System.Drawing.Size(41, 13);
            montoLabel.TabIndex = 7;
            montoLabel.Text = "monto:";
            // 
            // cod_usuarioLabel
            // 
            cod_usuarioLabel.AutoSize = true;
            cod_usuarioLabel.Location = new System.Drawing.Point(200, 123);
            cod_usuarioLabel.Name = "cod_usuarioLabel";
            cod_usuarioLabel.Size = new System.Drawing.Size(66, 13);
            cod_usuarioLabel.TabIndex = 9;
            cod_usuarioLabel.Text = "cod usuario:";
            // 
            // tipo_docLabel
            // 
            tipo_docLabel.AutoSize = true;
            tipo_docLabel.Location = new System.Drawing.Point(13, 42);
            tipo_docLabel.Name = "tipo_docLabel";
            tipo_docLabel.Size = new System.Drawing.Size(65, 13);
            tipo_docLabel.TabIndex = 11;
            tipo_docLabel.Text = "Documento:";
            // 
            // comprobanteLabel
            // 
            comprobanteLabel.AutoSize = true;
            comprobanteLabel.Location = new System.Drawing.Point(11, 123);
            comprobanteLabel.Name = "comprobanteLabel";
            comprobanteLabel.Size = new System.Drawing.Size(74, 13);
            comprobanteLabel.TabIndex = 15;
            comprobanteLabel.Text = "comprobante:";
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImage = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImage")));
            this.groupControl1.Controls.Add(this.splitContainerControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(665, 415);
            this.groupControl1.TabIndex = 12;
            this.groupControl1.Text = "Nota de Crédito";
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
            this.splitContainerControl1.Size = new System.Drawing.Size(661, 374);
            this.splitContainerControl1.SplitterPosition = 104;
            this.splitContainerControl1.TabIndex = 7;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.simpleButton4);
            this.groupControl3.Controls.Add(this.simpleButton2);
            this.groupControl3.Controls.Add(this.simpleButton1);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 0);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(104, 374);
            this.groupControl3.TabIndex = 0;
            // 
            // simpleButton4
            // 
            this.simpleButton4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton4.Appearance.Options.UseFont = true;
            this.simpleButton4.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.Image")));
            this.simpleButton4.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.simpleButton4.Location = new System.Drawing.Point(5, 83);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(94, 56);
            this.simpleButton4.TabIndex = 61;
            this.simpleButton4.Text = "Nuevo";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.simpleButton2.Location = new System.Drawing.Point(5, 23);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(94, 54);
            this.simpleButton2.TabIndex = 60;
            this.simpleButton2.Text = "Guardar Nuevo";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.simpleButton1.Location = new System.Drawing.Point(5, 145);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(94, 56);
            this.simpleButton1.TabIndex = 59;
            this.simpleButton1.Text = "Actualizar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.CaptionImage = ((System.Drawing.Image)(resources.GetObject("groupControl2.CaptionImage")));
            this.groupControl2.Controls.Add(this.groupControl4);
            this.groupControl2.Controls.Add(this.popupContainerControl1);
            this.groupControl2.Controls.Add(this.id_ncLabel1);
            this.groupControl2.Controls.Add(this.label1);
            this.groupControl2.Controls.Add(this.txtSerie);
            this.groupControl2.Controls.Add(this.txtTpago);
            this.groupControl2.Controls.Add(this.txtComprobante);
            this.groupControl2.Controls.Add(this.cbTpago);
            this.groupControl2.Controls.Add(fechaLabel);
            this.groupControl2.Controls.Add(montoLabel);
            this.groupControl2.Controls.Add(cod_usuarioLabel);
            this.groupControl2.Controls.Add(this.cod_usuarioTextEdit);
            this.groupControl2.Controls.Add(tipo_docLabel);
            this.groupControl2.Controls.Add(this.estadoCheckEdit);
            this.groupControl2.Controls.Add(comprobanteLabel);
            this.groupControl2.Controls.Add(this.fechaTextEdit);
            this.groupControl2.Controls.Add(this.comprobanteTextEdit);
            this.groupControl2.Controls.Add(this.montoSpinEdit);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(552, 374);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Datos de la Nota de Crédito";
            // 
            // groupControl4
            // 
            this.groupControl4.CaptionImage = ((System.Drawing.Image)(resources.GetObject("groupControl4.CaptionImage")));
            this.groupControl4.Controls.Add(this.ps_NC_BuscarGridControl);
            this.groupControl4.Location = new System.Drawing.Point(5, 172);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(542, 199);
            this.groupControl4.TabIndex = 67;
            this.groupControl4.Text = "Notas de Crédito";
            // 
            // ps_NC_BuscarGridControl
            // 
            this.ps_NC_BuscarGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ps_NC_BuscarGridControl.DataSource = this.ps_NC_BuscarBindingSource;
            this.ps_NC_BuscarGridControl.Location = new System.Drawing.Point(5, 23);
            this.ps_NC_BuscarGridControl.MainView = this.gridView1;
            this.ps_NC_BuscarGridControl.Name = "ps_NC_BuscarGridControl";
            this.ps_NC_BuscarGridControl.Size = new System.Drawing.Size(530, 171);
            this.ps_NC_BuscarGridControl.TabIndex = 0;
            this.ps_NC_BuscarGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // ps_NC_BuscarBindingSource
            // 
            this.ps_NC_BuscarBindingSource.DataMember = "ps_NC_Buscar";
            this.ps_NC_BuscarBindingSource.DataSource = this.dSCaja;
            // 
            // dSCaja
            // 
            this.dSCaja.DataSetName = "DSCaja";
            this.dSCaja.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_nc,
            this.colmonto,
            this.colcod_usuario,
            this.colestado,
            this.colcomprobante});
            this.gridView1.GridControl = this.ps_NC_BuscarGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colid_nc
            // 
            this.colid_nc.FieldName = "id_nc";
            this.colid_nc.Name = "colid_nc";
            this.colid_nc.Visible = true;
            this.colid_nc.VisibleIndex = 0;
            // 
            // colmonto
            // 
            this.colmonto.FieldName = "monto";
            this.colmonto.Name = "colmonto";
            this.colmonto.Visible = true;
            this.colmonto.VisibleIndex = 1;
            // 
            // colcod_usuario
            // 
            this.colcod_usuario.FieldName = "cod_usuario";
            this.colcod_usuario.Name = "colcod_usuario";
            this.colcod_usuario.Visible = true;
            this.colcod_usuario.VisibleIndex = 2;
            // 
            // colestado
            // 
            this.colestado.FieldName = "estado";
            this.colestado.Name = "colestado";
            this.colestado.Visible = true;
            this.colestado.VisibleIndex = 3;
            // 
            // colcomprobante
            // 
            this.colcomprobante.FieldName = "comprobante";
            this.colcomprobante.Name = "colcomprobante";
            this.colcomprobante.Visible = true;
            this.colcomprobante.VisibleIndex = 4;
            // 
            // popupContainerControl1
            // 
            this.popupContainerControl1.Controls.Add(this.groupControl6);
            this.popupContainerControl1.Location = new System.Drawing.Point(383, 26);
            this.popupContainerControl1.Name = "popupContainerControl1";
            this.popupContainerControl1.Size = new System.Drawing.Size(376, 192);
            this.popupContainerControl1.TabIndex = 65;
            // 
            // groupControl6
            // 
            this.groupControl6.Controls.Add(this.view_ComprobanteGridControl);
            this.groupControl6.Controls.Add(this.btnBuscar);
            this.groupControl6.Controls.Add(this.txtCompro_bus);
            this.groupControl6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl6.Location = new System.Drawing.Point(0, 0);
            this.groupControl6.Name = "groupControl6";
            this.groupControl6.Size = new System.Drawing.Size(376, 192);
            this.groupControl6.TabIndex = 58;
            this.groupControl6.Text = "Buscar Comprobante";
            // 
            // view_ComprobanteGridControl
            // 
            this.view_ComprobanteGridControl.DataSource = this.headerPagoBindingSource;
            this.view_ComprobanteGridControl.Location = new System.Drawing.Point(5, 48);
            this.view_ComprobanteGridControl.MainView = this.gridView3;
            this.view_ComprobanteGridControl.Name = "view_ComprobanteGridControl";
            this.view_ComprobanteGridControl.Size = new System.Drawing.Size(366, 139);
            this.view_ComprobanteGridControl.TabIndex = 2;
            this.view_ComprobanteGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // headerPagoBindingSource
            // 
            this.headerPagoBindingSource.DataMember = "Header_Pago";
            this.headerPagoBindingSource.DataSource = this.dSAQCobranza;
            // 
            // dSAQCobranza
            // 
            this.dSAQCobranza.DataSetName = "DSAQCobranza";
            this.dSAQCobranza.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.colfecha1});
            this.gridView3.GridControl = this.view_ComprobanteGridControl;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsBehavior.Editable = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "comprobante";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // colfecha1
            // 
            this.colfecha1.FieldName = "fecha";
            this.colfecha1.Name = "colfecha1";
            this.colfecha1.Visible = true;
            this.colfecha1.VisibleIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(131, 21);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(26, 23);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtCompro_bus
            // 
            this.txtCompro_bus.Location = new System.Drawing.Point(5, 23);
            this.txtCompro_bus.Name = "txtCompro_bus";
            this.txtCompro_bus.Size = new System.Drawing.Size(120, 20);
            this.txtCompro_bus.TabIndex = 0;
            // 
            // id_ncLabel1
            // 
            this.id_ncLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ps_NC_BuscarBindingSource, "id_nc", true));
            this.id_ncLabel1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_ncLabel1.Location = new System.Drawing.Point(173, 0);
            this.id_ncLabel1.Name = "id_ncLabel1";
            this.id_ncLabel1.Size = new System.Drawing.Size(146, 20);
            this.id_ncLabel1.TabIndex = 64;
            this.id_ncLabel1.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 13);
            this.label1.TabIndex = 63;
            this.label1.Text = "-";
            // 
            // txtSerie
            // 
            this.txtSerie.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.documentopagoBindingSource, "serie", true));
            this.txtSerie.Enabled = false;
            this.txtSerie.Location = new System.Drawing.Point(85, 66);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Properties.Mask.EditMask = "000-000000";
            this.txtSerie.Size = new System.Drawing.Size(31, 20);
            this.txtSerie.TabIndex = 62;
            // 
            // documentopagoBindingSource
            // 
            this.documentopagoBindingSource.DataMember = "Documento_pago";
            this.documentopagoBindingSource.DataSource = this.dSAQCobranza;
            // 
            // txtTpago
            // 
            this.txtTpago.AutoSize = true;
            this.txtTpago.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.documentopagoBindingSource, "abre", true));
            this.txtTpago.Location = new System.Drawing.Point(55, 66);
            this.txtTpago.Name = "txtTpago";
            this.txtTpago.Size = new System.Drawing.Size(22, 13);
            this.txtTpago.TabIndex = 61;
            this.txtTpago.Text = "???";
            // 
            // txtComprobante
            // 
            this.txtComprobante.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.documentopagoBindingSource, "correlativ", true));
            this.txtComprobante.Enabled = false;
            this.txtComprobante.Location = new System.Drawing.Point(128, 66);
            this.txtComprobante.Name = "txtComprobante";
            this.txtComprobante.Properties.Mask.EditMask = "000-000000";
            this.txtComprobante.Size = new System.Drawing.Size(70, 20);
            this.txtComprobante.TabIndex = 60;
            // 
            // cbTpago
            // 
            this.cbTpago.DataSource = this.documentopagoBindingSource;
            this.cbTpago.DisplayMember = "nombre";
            this.cbTpago.FormattingEnabled = true;
            this.cbTpago.Location = new System.Drawing.Point(85, 39);
            this.cbTpago.Name = "cbTpago";
            this.cbTpago.Size = new System.Drawing.Size(100, 21);
            this.cbTpago.TabIndex = 53;
            this.cbTpago.ValueMember = "cod_documen";
            // 
            // cod_usuarioTextEdit
            // 
            this.cod_usuarioTextEdit.Enabled = false;
            this.cod_usuarioTextEdit.Location = new System.Drawing.Point(269, 120);
            this.cod_usuarioTextEdit.Name = "cod_usuarioTextEdit";
            this.cod_usuarioTextEdit.Size = new System.Drawing.Size(100, 20);
            this.cod_usuarioTextEdit.TabIndex = 10;
            // 
            // estadoCheckEdit
            // 
            this.estadoCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.ps_NC_BuscarBindingSource, "estado", true));
            this.estadoCheckEdit.EditValue = true;
            this.estadoCheckEdit.Location = new System.Drawing.Point(200, 144);
            this.estadoCheckEdit.Name = "estadoCheckEdit";
            this.estadoCheckEdit.Properties.Caption = "Estado :";
            this.estadoCheckEdit.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style5;
            this.estadoCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.estadoCheckEdit.Size = new System.Drawing.Size(100, 22);
            this.estadoCheckEdit.TabIndex = 14;
            // 
            // fechaTextEdit
            // 
            this.fechaTextEdit.EditValue = new System.DateTime(2016, 12, 4, 10, 59, 21, 551);
            this.fechaTextEdit.Location = new System.Drawing.Point(85, 92);
            this.fechaTextEdit.Name = "fechaTextEdit";
            this.fechaTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fechaTextEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fechaTextEdit.Properties.DisplayFormat.FormatString = "";
            this.fechaTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fechaTextEdit.Properties.EditFormat.FormatString = "";
            this.fechaTextEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fechaTextEdit.Properties.Mask.EditMask = "";
            this.fechaTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.fechaTextEdit.Size = new System.Drawing.Size(151, 20);
            this.fechaTextEdit.TabIndex = 6;
            this.fechaTextEdit.EditValueChanged += new System.EventHandler(this.fechaTextEdit_EditValueChanged);
            // 
            // comprobanteTextEdit
            // 
            this.comprobanteTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.headerPagoBindingSource, "comprobante", true));
            this.comprobanteTextEdit.Location = new System.Drawing.Point(85, 120);
            this.comprobanteTextEdit.Name = "comprobanteTextEdit";
            this.comprobanteTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comprobanteTextEdit.Properties.PopupControl = this.popupContainerControl1;
            this.comprobanteTextEdit.Size = new System.Drawing.Size(100, 20);
            this.comprobanteTextEdit.TabIndex = 16;
            // 
            // montoSpinEdit
            // 
            this.montoSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.headerPagoBindingSource, "monto_total", true));
            this.montoSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.montoSpinEdit.Location = new System.Drawing.Point(85, 146);
            this.montoSpinEdit.Name = "montoSpinEdit";
            this.montoSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.montoSpinEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.montoSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.montoSpinEdit.TabIndex = 8;
            // 
            // nota_creditoBindingSource
            // 
            this.nota_creditoBindingSource.DataMember = "Nota_credito";
            this.nota_creditoBindingSource.DataSource = this.dSCaja;
            // 
            // nota_creditoTableAdapter
            // 
            this.nota_creditoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Concepto_egresoTableAdapter = null;
            this.tableAdapterManager.Nota_creditoTableAdapter = this.nota_creditoTableAdapter;
            this.tableAdapterManager.UpdateOrder = AQCobranza.DSCajaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // documento_pagoTableAdapter
            // 
            this.documento_pagoTableAdapter.ClearBeforeFill = true;
            // 
            // header_PagoTableAdapter
            // 
            this.header_PagoTableAdapter.ClearBeforeFill = true;
            // 
            // ps_NC_BuscarTableAdapter
            // 
            this.ps_NC_BuscarTableAdapter.ClearBeforeFill = true;
            // 
            // Nota_credito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 415);
            this.Controls.Add(this.groupControl1);
            this.Name = "Nota_credito";
            this.Text = "Nota de Credito";
            this.Load += new System.EventHandler(this.Nota_credito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ps_NC_BuscarGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ps_NC_BuscarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSCaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupContainerControl1)).EndInit();
            this.popupContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).EndInit();
            this.groupControl6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.view_ComprobanteGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerPagoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAQCobranza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompro_bus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSerie.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentopagoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComprobante.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cod_usuarioTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechaTextEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechaTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprobanteTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.montoSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nota_creditoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DSCaja dSCaja;
        private System.Windows.Forms.BindingSource nota_creditoBindingSource;
        private DSCajaTableAdapters.Nota_creditoTableAdapter nota_creditoTableAdapter;
        private DSCajaTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.TextEdit cod_usuarioTextEdit;
        private DevExpress.XtraEditors.CheckEdit estadoCheckEdit;
        private System.Windows.Forms.ComboBox cbTpago;
        private DSAQCobranza dSAQCobranza;
        private System.Windows.Forms.BindingSource documentopagoBindingSource;
        private DSAQCobranzaTableAdapters.Documento_pagoTableAdapter documento_pagoTableAdapter;
        private System.Windows.Forms.Label id_ncLabel1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtSerie;
        private System.Windows.Forms.Label txtTpago;
        private DevExpress.XtraEditors.TextEdit txtComprobante;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.DateEdit fechaTextEdit;
        private DevExpress.XtraEditors.PopupContainerEdit comprobanteTextEdit;
        private DevExpress.XtraEditors.PopupContainerControl popupContainerControl1;
        private DevExpress.XtraEditors.GroupControl groupControl6;
        private DevExpress.XtraGrid.GridControl view_ComprobanteGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha1;
        private DevExpress.XtraEditors.SimpleButton btnBuscar;
        private DevExpress.XtraEditors.TextEdit txtCompro_bus;
        private System.Windows.Forms.BindingSource headerPagoBindingSource;
        private DSAQCobranzaTableAdapters.Header_PagoTableAdapter header_PagoTableAdapter;
        private DevExpress.XtraEditors.TextEdit montoSpinEdit;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private System.Windows.Forms.BindingSource ps_NC_BuscarBindingSource;
        private DSCajaTableAdapters.ps_NC_BuscarTableAdapter ps_NC_BuscarTableAdapter;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraGrid.GridControl ps_NC_BuscarGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_nc;
        private DevExpress.XtraGrid.Columns.GridColumn colmonto;
        private DevExpress.XtraGrid.Columns.GridColumn colcod_usuario;
        private DevExpress.XtraGrid.Columns.GridColumn colestado;
        private DevExpress.XtraGrid.Columns.GridColumn colcomprobante;
    }
}