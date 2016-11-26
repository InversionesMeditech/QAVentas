namespace AQCobranza
{
    partial class Panel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Panel));
            this.repositoryItemPictureEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barCliente = new DevExpress.XtraBars.BarButtonItem();
            this.barCotizaciones = new DevExpress.XtraBars.BarButtonItem();
            this.barOrdCompra = new DevExpress.XtraBars.BarButtonItem();
            this.barCaja = new DevExpress.XtraBars.BarButtonItem();
            this.barConceptos = new DevExpress.XtraBars.BarButtonItem();
            this.barUsuarios = new DevExpress.XtraBars.BarButtonItem();
            this.barPermisos = new DevExpress.XtraBars.BarButtonItem();
            this.barRcaja = new DevExpress.XtraBars.BarButtonItem();
            this.barRdeuda = new DevExpress.XtraBars.BarButtonItem();
            this.barAcabados = new DevExpress.XtraBars.BarButtonItem();
            this.barMaterial = new DevExpress.XtraBars.BarButtonItem();
            this.barImpresion = new DevExpress.XtraBars.BarButtonItem();
            this.barUmedida = new DevExpress.XtraBars.BarButtonItem();
            this.barGremision = new DevExpress.XtraBars.BarButtonItem();
            this.barEmpresa = new DevExpress.XtraBars.BarButtonItem();
            this.barCaja_banco = new DevExpress.XtraBars.BarButtonItem();
            this.barCajaChica = new DevExpress.XtraBars.BarButtonItem();
            this.barBancos = new DevExpress.XtraBars.BarButtonItem();
            this.barCompro = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbCotizacion = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbOrdenCompra = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbReporteCaja = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.RBRdeudas = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbEmpresa = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbConcepto = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbBancos = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtEmpresa = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.dSAQCobranza = new AQCobranza.DSAQCobranza();
            this.eRP_empresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eRP_empresaTableAdapter = new AQCobranza.DSAQCobranzaTableAdapters.ERP_empresaTableAdapter();
            this.tableAdapterManager = new AQCobranza.DSAQCobranzaTableAdapters.TableAdapterManager();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dSAQCobranza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eRP_empresaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // repositoryItemPictureEdit2
            // 
            this.repositoryItemPictureEdit2.Name = "repositoryItemPictureEdit2";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barCliente,
            this.barCotizaciones,
            this.barOrdCompra,
            this.barCaja,
            this.barConceptos,
            this.barUsuarios,
            this.barPermisos,
            this.barRcaja,
            this.barRdeuda,
            this.barAcabados,
            this.barMaterial,
            this.barImpresion,
            this.barUmedida,
            this.barGremision,
            this.barEmpresa,
            this.barCaja_banco,
            this.barCajaChica,
            this.barBancos,
            this.barCompro,
            this.barButtonItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 38;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage3,
            this.ribbonPage2});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl1.Size = new System.Drawing.Size(823, 162);
            this.ribbonControl1.Click += new System.EventHandler(this.ribbonControl1_Click);
            // 
            // barCliente
            // 
            this.barCliente.Caption = "Cliente";
            this.barCliente.Glyph = ((System.Drawing.Image)(resources.GetObject("barCliente.Glyph")));
            this.barCliente.Id = 1;
            this.barCliente.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barCliente.LargeGlyph")));
            this.barCliente.Name = "barCliente";
            this.barCliente.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barCliente.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barCotizaciones
            // 
            this.barCotizaciones.Caption = "Cotizaciones";
            this.barCotizaciones.Glyph = ((System.Drawing.Image)(resources.GetObject("barCotizaciones.Glyph")));
            this.barCotizaciones.Id = 2;
            this.barCotizaciones.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barCotizaciones.LargeGlyph")));
            this.barCotizaciones.Name = "barCotizaciones";
            this.barCotizaciones.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barOrdCompra
            // 
            this.barOrdCompra.Caption = "Orden de Compra";
            this.barOrdCompra.Glyph = ((System.Drawing.Image)(resources.GetObject("barOrdCompra.Glyph")));
            this.barOrdCompra.Id = 3;
            this.barOrdCompra.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barOrdCompra.LargeGlyph")));
            this.barOrdCompra.Name = "barOrdCompra";
            this.barOrdCompra.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // barCaja
            // 
            this.barCaja.Caption = "Caja";
            this.barCaja.Glyph = ((System.Drawing.Image)(resources.GetObject("barCaja.Glyph")));
            this.barCaja.Id = 4;
            this.barCaja.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barCaja.LargeGlyph")));
            this.barCaja.Name = "barCaja";
            this.barCaja.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // barConceptos
            // 
            this.barConceptos.Caption = "Conceptos";
            this.barConceptos.Glyph = ((System.Drawing.Image)(resources.GetObject("barConceptos.Glyph")));
            this.barConceptos.Id = 5;
            this.barConceptos.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barConceptos.LargeGlyph")));
            this.barConceptos.Name = "barConceptos";
            this.barConceptos.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem5_ItemClick);
            // 
            // barUsuarios
            // 
            this.barUsuarios.Caption = "Usuarios";
            this.barUsuarios.Glyph = ((System.Drawing.Image)(resources.GetObject("barUsuarios.Glyph")));
            this.barUsuarios.Id = 6;
            this.barUsuarios.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barUsuarios.LargeGlyph")));
            this.barUsuarios.Name = "barUsuarios";
            this.barUsuarios.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barUsuarios.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem6_ItemClick);
            // 
            // barPermisos
            // 
            this.barPermisos.Caption = "Permisos";
            this.barPermisos.Glyph = ((System.Drawing.Image)(resources.GetObject("barPermisos.Glyph")));
            this.barPermisos.Id = 7;
            this.barPermisos.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barPermisos.LargeGlyph")));
            this.barPermisos.Name = "barPermisos";
            this.barPermisos.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem7_ItemClick);
            // 
            // barRcaja
            // 
            this.barRcaja.Caption = "Reportes de Caja";
            this.barRcaja.Glyph = ((System.Drawing.Image)(resources.GetObject("barRcaja.Glyph")));
            this.barRcaja.Id = 8;
            this.barRcaja.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barRcaja.LargeGlyph")));
            this.barRcaja.Name = "barRcaja";
            this.barRcaja.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barRcaja_ItemClick);
            // 
            // barRdeuda
            // 
            this.barRdeuda.Caption = "Reportes de Deudas";
            this.barRdeuda.Glyph = ((System.Drawing.Image)(resources.GetObject("barRdeuda.Glyph")));
            this.barRdeuda.Id = 9;
            this.barRdeuda.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barRdeuda.LargeGlyph")));
            this.barRdeuda.Name = "barRdeuda";
            // 
            // barAcabados
            // 
            this.barAcabados.ActAsDropDown = true;
            this.barAcabados.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.barAcabados.Caption = "Acabados";
            this.barAcabados.Glyph = ((System.Drawing.Image)(resources.GetObject("barAcabados.Glyph")));
            this.barAcabados.Id = 10;
            this.barAcabados.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barAcabados.LargeGlyph")));
            this.barAcabados.Name = "barAcabados";
            this.barAcabados.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barAcabados.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem10_ItemClick);
            // 
            // barMaterial
            // 
            this.barMaterial.Caption = "Material";
            this.barMaterial.Glyph = ((System.Drawing.Image)(resources.GetObject("barMaterial.Glyph")));
            this.barMaterial.Id = 11;
            this.barMaterial.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barMaterial.LargeGlyph")));
            this.barMaterial.Name = "barMaterial";
            this.barMaterial.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barMaterial.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem11_ItemClick);
            // 
            // barImpresion
            // 
            this.barImpresion.Caption = "Impresión";
            this.barImpresion.Glyph = ((System.Drawing.Image)(resources.GetObject("barImpresion.Glyph")));
            this.barImpresion.Id = 12;
            this.barImpresion.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barImpresion.LargeGlyph")));
            this.barImpresion.Name = "barImpresion";
            this.barImpresion.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barImpresion.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem12_ItemClick);
            // 
            // barUmedida
            // 
            this.barUmedida.Caption = "Unidad de Medida";
            this.barUmedida.Glyph = ((System.Drawing.Image)(resources.GetObject("barUmedida.Glyph")));
            this.barUmedida.Id = 13;
            this.barUmedida.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barUmedida.LargeGlyph")));
            this.barUmedida.Name = "barUmedida";
            this.barUmedida.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barUmedida.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem13_ItemClick);
            // 
            // barGremision
            // 
            this.barGremision.Caption = "Guía de Remisión";
            this.barGremision.Glyph = ((System.Drawing.Image)(resources.GetObject("barGremision.Glyph")));
            this.barGremision.Id = 20;
            this.barGremision.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barGremision.LargeGlyph")));
            this.barGremision.Name = "barGremision";
            this.barGremision.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem14_ItemClick);
            // 
            // barEmpresa
            // 
            this.barEmpresa.Caption = "Empresa";
            this.barEmpresa.Glyph = ((System.Drawing.Image)(resources.GetObject("barEmpresa.Glyph")));
            this.barEmpresa.Id = 24;
            this.barEmpresa.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barEmpresa.LargeGlyph")));
            this.barEmpresa.Name = "barEmpresa";
            this.barEmpresa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem16_ItemClick);
            // 
            // barCaja_banco
            // 
            this.barCaja_banco.Caption = "Caja Banco";
            this.barCaja_banco.Glyph = ((System.Drawing.Image)(resources.GetObject("barCaja_banco.Glyph")));
            this.barCaja_banco.Id = 25;
            this.barCaja_banco.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barCaja_banco.LargeGlyph")));
            this.barCaja_banco.Name = "barCaja_banco";
            this.barCaja_banco.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barCaja_banco_ItemClick);
            // 
            // barCajaChica
            // 
            this.barCajaChica.Caption = "Caja Chica";
            this.barCajaChica.Glyph = ((System.Drawing.Image)(resources.GetObject("barCajaChica.Glyph")));
            this.barCajaChica.Id = 26;
            this.barCajaChica.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barCajaChica.LargeGlyph")));
            this.barCajaChica.Name = "barCajaChica";
            this.barCajaChica.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barCajaChica_ItemClick);
            // 
            // barBancos
            // 
            this.barBancos.Caption = "Configurar Bancos";
            this.barBancos.Glyph = ((System.Drawing.Image)(resources.GetObject("barBancos.Glyph")));
            this.barBancos.Id = 28;
            this.barBancos.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBancos.LargeGlyph")));
            this.barBancos.Name = "barBancos";
            this.barBancos.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBancos_ItemClick);
            // 
            // barCompro
            // 
            this.barCompro.Caption = "Configurar Comprobantes";
            this.barCompro.Glyph = ((System.Drawing.Image)(resources.GetObject("barCompro.Glyph")));
            this.barCompro.Id = 36;
            this.barCompro.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barCompro.LargeGlyph")));
            this.barCompro.Name = "barCompro";
            this.barCompro.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barCompro_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Ayuda";
            this.barButtonItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.Glyph")));
            this.barButtonItem1.Id = 37;
            this.barButtonItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.LargeGlyph")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick_1);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbCotizacion,
            this.rbOrdenCompra,
            this.ribbonPageGroup1});
            this.ribbonPage1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage1.Image")));
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Principal";
            // 
            // rbCotizacion
            // 
            this.rbCotizacion.AllowTextClipping = false;
            this.rbCotizacion.ItemLinks.Add(this.barCotizaciones);
            this.rbCotizacion.ItemLinks.Add(this.barOrdCompra);
            this.rbCotizacion.ItemLinks.Add(this.barGremision);
            this.rbCotizacion.Name = "rbCotizacion";
            this.rbCotizacion.ShowCaptionButton = false;
            this.rbCotizacion.Text = "VENTAS";
            // 
            // rbOrdenCompra
            // 
            this.rbOrdenCompra.AllowTextClipping = false;
            this.rbOrdenCompra.ItemLinks.Add(this.barCaja);
            this.rbOrdenCompra.ItemLinks.Add(this.barCaja_banco);
            this.rbOrdenCompra.ItemLinks.Add(this.barCajaChica);
            this.rbOrdenCompra.Name = "rbOrdenCompra";
            this.rbOrdenCompra.ShowCaptionButton = false;
            this.rbOrdenCompra.Text = "CAJA";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "AYUDA";
            this.ribbonPageGroup1.Visible = false;
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbReporteCaja,
            this.RBRdeudas});
            this.ribbonPage3.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage3.Image")));
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Reportes";
            // 
            // rbReporteCaja
            // 
            this.rbReporteCaja.AllowTextClipping = false;
            this.rbReporteCaja.ItemLinks.Add(this.barRcaja);
            this.rbReporteCaja.Name = "rbReporteCaja";
            this.rbReporteCaja.ShowCaptionButton = false;
            // 
            // RBRdeudas
            // 
            this.RBRdeudas.AllowTextClipping = false;
            this.RBRdeudas.ItemLinks.Add(this.barRdeuda);
            this.RBRdeudas.Name = "RBRdeudas";
            this.RBRdeudas.ShowCaptionButton = false;
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbEmpresa,
            this.rbConcepto,
            this.rbBancos});
            this.ribbonPage2.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage2.Image")));
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Mantenimiento";
            // 
            // rbEmpresa
            // 
            this.rbEmpresa.AllowTextClipping = false;
            this.rbEmpresa.ItemLinks.Add(this.barEmpresa);
            this.rbEmpresa.ItemLinks.Add(this.barUsuarios);
            this.rbEmpresa.ItemLinks.Add(this.barCliente);
            this.rbEmpresa.Name = "rbEmpresa";
            this.rbEmpresa.ShowCaptionButton = false;
            this.rbEmpresa.Text = "EMPRESA";
            // 
            // rbConcepto
            // 
            this.rbConcepto.AllowTextClipping = false;
            this.rbConcepto.ItemLinks.Add(this.barConceptos);
            this.rbConcepto.ItemLinks.Add(this.barMaterial);
            this.rbConcepto.ItemLinks.Add(this.barAcabados);
            this.rbConcepto.ItemLinks.Add(this.barImpresion);
            this.rbConcepto.ItemLinks.Add(this.barUmedida);
            this.rbConcepto.Name = "rbConcepto";
            this.rbConcepto.ShowCaptionButton = false;
            this.rbConcepto.Text = "CONCEPTOS";
            // 
            // rbBancos
            // 
            this.rbBancos.AllowTextClipping = false;
            this.rbBancos.ItemLinks.Add(this.barBancos);
            this.rbBancos.ItemLinks.Add(this.barCompro);
            this.rbBancos.Name = "rbBancos";
            this.rbBancos.ShowCaptionButton = false;
            this.rbBancos.Text = "Bancos y Comprobantes";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(69, 17);
            this.toolStripStatusLabel1.Text = "Bienvenido:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(27, 17);
            this.txtUsuario.Text = "????";
            this.txtUsuario.Click += new System.EventHandler(this.txtUsuario_Click);
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(27, 17);
            this.txtEmpresa.Text = "????";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.txtUsuario,
            this.txtEmpresa});
            this.statusStrip1.Location = new System.Drawing.Point(0, 480);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(823, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // dSAQCobranza
            // 
            this.dSAQCobranza.DataSetName = "DSAQCobranza";
            this.dSAQCobranza.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eRP_empresaBindingSource
            // 
            this.eRP_empresaBindingSource.DataMember = "ERP_empresa";
            this.eRP_empresaBindingSource.DataSource = this.dSAQCobranza;
            // 
            // eRP_empresaTableAdapter
            // 
            this.eRP_empresaTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.ERP_empresaTableAdapter = this.eRP_empresaTableAdapter;
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
            // ribbonPage4
            // 
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "ribbonPage4";
            // 
            // Panel
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 502);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Panel";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Panel Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Panel_FormClosing);
            this.Load += new System.EventHandler(this.Panel_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Panel_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Panel_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dSAQCobranza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eRP_empresaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.BarButtonItem barCliente;
        private DevExpress.XtraBars.BarButtonItem barCotizaciones;
        private DevExpress.XtraBars.BarButtonItem barOrdCompra;
        private DevExpress.XtraBars.BarButtonItem barCaja;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbCotizacion;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbOrdenCompra;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.BarButtonItem barConceptos;
        private DevExpress.XtraBars.BarButtonItem barUsuarios;
        private DevExpress.XtraBars.BarButtonItem barPermisos;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbConcepto;
        private DevExpress.XtraBars.BarButtonItem barRcaja;
        private DevExpress.XtraBars.BarButtonItem barRdeuda;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbReporteCaja;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup RBRdeudas;
        private DevExpress.XtraBars.BarButtonItem barAcabados;
        private DevExpress.XtraBars.BarButtonItem barMaterial;
        private DevExpress.XtraBars.BarButtonItem barImpresion;
        private DevExpress.XtraBars.BarButtonItem barUmedida;
        private DevExpress.XtraBars.BarButtonItem barGremision;
        private DevExpress.XtraBars.BarButtonItem barEmpresa;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbEmpresa;
        private DevExpress.XtraBars.BarButtonItem barCaja_banco;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        public System.Windows.Forms.ToolStripStatusLabel txtUsuario;
        private System.Windows.Forms.ToolStripStatusLabel txtEmpresa;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private DevExpress.XtraBars.BarButtonItem barCajaChica;
        private DevExpress.XtraBars.BarButtonItem barBancos;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbBancos;
        private DSAQCobranza dSAQCobranza;
        private System.Windows.Forms.BindingSource eRP_empresaBindingSource;
        private DSAQCobranzaTableAdapters.ERP_empresaTableAdapter eRP_empresaTableAdapter;
        private DSAQCobranzaTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit2;
        private DevExpress.XtraBars.BarButtonItem barCompro;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}

