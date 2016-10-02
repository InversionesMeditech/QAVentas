namespace AQCobranza
{
    partial class Cliente
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
            System.Windows.Forms.Label ruc_DNILabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label apellidosLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label observacionesLabel;
            System.Windows.Forms.Label fotoLabel1;
            System.Windows.Forms.Label compradorLabel;
            System.Windows.Forms.Label com_telefonoLabel;
            System.Windows.Forms.Label com_correoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cliente));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clienteBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSAQCobranza = new AQCobranza.DSAQCobranza();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.clienteBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.PCcliente = new DevExpress.XtraEditors.PopupContainerControl();
            this.SCcliente = new DevExpress.XtraEditors.SearchControl();
            this.GCcliente = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRuc_DNI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApellidos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtdni = new DevExpress.XtraEditors.PopupContainerEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.com_correoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.com_telefonoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.compradorTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.fotoPictureBox = new System.Windows.Forms.PictureBox();
            this.ruc_DNITextEdit = new DevExpress.XtraEditors.TextEdit();
            this.nombreTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.apellidosTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.direccionTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.observacionesTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.clienteTableAdapter = new AQCobranza.DSAQCobranzaTableAdapters.ClienteTableAdapter();
            this.tableAdapterManager = new AQCobranza.DSAQCobranzaTableAdapters.TableAdapterManager();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ruc_DNILabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            apellidosLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            observacionesLabel = new System.Windows.Forms.Label();
            fotoLabel1 = new System.Windows.Forms.Label();
            compradorLabel = new System.Windows.Forms.Label();
            com_telefonoLabel = new System.Windows.Forms.Label();
            com_correoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingNavigator)).BeginInit();
            this.clienteBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAQCobranza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PCcliente)).BeginInit();
            this.PCcliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SCcliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GCcliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdni.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.com_correoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.com_telefonoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compradorTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ruc_DNITextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nombreTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apellidosTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.direccionTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.observacionesTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ruc_DNILabel
            // 
            ruc_DNILabel.AutoSize = true;
            ruc_DNILabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            ruc_DNILabel.Location = new System.Drawing.Point(19, 29);
            ruc_DNILabel.Name = "ruc_DNILabel";
            ruc_DNILabel.Size = new System.Drawing.Size(57, 13);
            ruc_DNILabel.TabIndex = 11;
            ruc_DNILabel.Text = "Ruc/DNI:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            nombreLabel.Location = new System.Drawing.Point(19, 55);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(131, 13);
            nombreLabel.TabIndex = 13;
            nombreLabel.Text = "Nombre/Razón Social:";
            // 
            // apellidosLabel
            // 
            apellidosLabel.AutoSize = true;
            apellidosLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            apellidosLabel.Location = new System.Drawing.Point(19, 81);
            apellidosLabel.Name = "apellidosLabel";
            apellidosLabel.Size = new System.Drawing.Size(61, 13);
            apellidosLabel.TabIndex = 15;
            apellidosLabel.Text = "Apellidos:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            direccionLabel.Location = new System.Drawing.Point(19, 107);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(62, 13);
            direccionLabel.TabIndex = 17;
            direccionLabel.Text = "Dirección:";
            // 
            // observacionesLabel
            // 
            observacionesLabel.AutoSize = true;
            observacionesLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            observacionesLabel.Location = new System.Drawing.Point(19, 133);
            observacionesLabel.Name = "observacionesLabel";
            observacionesLabel.Size = new System.Drawing.Size(93, 13);
            observacionesLabel.TabIndex = 19;
            observacionesLabel.Text = "Observaciones:";
            // 
            // fotoLabel1
            // 
            fotoLabel1.AutoSize = true;
            fotoLabel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            fotoLabel1.Location = new System.Drawing.Point(336, 29);
            fotoLabel1.Name = "fotoLabel1";
            fotoLabel1.Size = new System.Drawing.Size(38, 13);
            fotoLabel1.TabIndex = 21;
            fotoLabel1.Text = "Foto :";
            // 
            // compradorLabel
            // 
            compradorLabel.AutoSize = true;
            compradorLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            compradorLabel.Location = new System.Drawing.Point(5, 27);
            compradorLabel.Name = "compradorLabel";
            compradorLabel.Size = new System.Drawing.Size(73, 13);
            compradorLabel.TabIndex = 0;
            compradorLabel.Text = "Comprador:";
            // 
            // com_telefonoLabel
            // 
            com_telefonoLabel.AutoSize = true;
            com_telefonoLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            com_telefonoLabel.Location = new System.Drawing.Point(7, 54);
            com_telefonoLabel.Name = "com_telefonoLabel";
            com_telefonoLabel.Size = new System.Drawing.Size(59, 13);
            com_telefonoLabel.TabIndex = 2;
            com_telefonoLabel.Text = "Telefono:";
            // 
            // com_correoLabel
            // 
            com_correoLabel.AutoSize = true;
            com_correoLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            com_correoLabel.Location = new System.Drawing.Point(7, 83);
            com_correoLabel.Name = "com_correoLabel";
            com_correoLabel.Size = new System.Drawing.Size(48, 13);
            com_correoLabel.TabIndex = 4;
            com_correoLabel.Text = "Correo:";
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
            this.splitContainerControl1.Size = new System.Drawing.Size(812, 356);
            this.splitContainerControl1.SplitterPosition = 188;
            this.splitContainerControl1.TabIndex = 7;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.groupBox1);
            this.groupControl3.Controls.Add(this.PCcliente);
            this.groupControl3.Controls.Add(this.txtdni);
            this.groupControl3.Controls.Add(this.labelControl6);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 0);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(188, 356);
            this.groupControl3.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clienteBindingNavigator);
            this.groupBox1.Location = new System.Drawing.Point(8, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(112, 256);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // clienteBindingNavigator
            // 
            this.clienteBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.clienteBindingNavigator.BindingSource = this.clienteBindingSource;
            this.clienteBindingNavigator.CountItem = null;
            this.clienteBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.clienteBindingNavigator.Dock = System.Windows.Forms.DockStyle.Left;
            this.clienteBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.clienteBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.clienteBindingNavigatorSaveItem});
            this.clienteBindingNavigator.Location = new System.Drawing.Point(3, 17);
            this.clienteBindingNavigator.MoveFirstItem = null;
            this.clienteBindingNavigator.MoveLastItem = null;
            this.clienteBindingNavigator.MoveNextItem = null;
            this.clienteBindingNavigator.MovePreviousItem = null;
            this.clienteBindingNavigator.Name = "clienteBindingNavigator";
            this.clienteBindingNavigator.PositionItem = null;
            this.clienteBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.clienteBindingNavigator.Size = new System.Drawing.Size(103, 236);
            this.clienteBindingNavigator.TabIndex = 9;
            this.clienteBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(100, 36);
            this.bindingNavigatorAddNewItem.Text = "NUEVO";
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.dSAQCobranza;
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
            // clienteBindingNavigatorSaveItem
            // 
            this.clienteBindingNavigatorSaveItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.clienteBindingNavigatorSaveItem.Image = global::AQCobranza.Properties.Resources.saveto_32x32;
            this.clienteBindingNavigatorSaveItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.clienteBindingNavigatorSaveItem.Name = "clienteBindingNavigatorSaveItem";
            this.clienteBindingNavigatorSaveItem.Size = new System.Drawing.Size(100, 36);
            this.clienteBindingNavigatorSaveItem.Text = "GUARDAR";
            this.clienteBindingNavigatorSaveItem.Click += new System.EventHandler(this.clienteBindingNavigatorSaveItem_Click);
            // 
            // PCcliente
            // 
            this.PCcliente.Controls.Add(this.SCcliente);
            this.PCcliente.Controls.Add(this.GCcliente);
            this.PCcliente.Location = new System.Drawing.Point(121, 289);
            this.PCcliente.Name = "PCcliente";
            this.PCcliente.Size = new System.Drawing.Size(476, 226);
            this.PCcliente.TabIndex = 11;
            // 
            // SCcliente
            // 
            this.SCcliente.Client = this.GCcliente;
            this.SCcliente.Location = new System.Drawing.Point(4, 4);
            this.SCcliente.Name = "SCcliente";
            this.SCcliente.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.SCcliente.Properties.Client = this.GCcliente;
            this.SCcliente.Properties.NullValuePrompt = "Ingrese el texto a Buscar....";
            this.SCcliente.Size = new System.Drawing.Size(304, 20);
            this.SCcliente.TabIndex = 1;
            // 
            // GCcliente
            // 
            this.GCcliente.DataSource = this.clienteBindingSource;
            this.GCcliente.Location = new System.Drawing.Point(3, 30);
            this.GCcliente.MainView = this.gridView1;
            this.GCcliente.Name = "GCcliente";
            this.GCcliente.Size = new System.Drawing.Size(489, 185);
            this.GCcliente.TabIndex = 0;
            this.GCcliente.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRuc_DNI,
            this.colNombre,
            this.colApellidos});
            this.gridView1.GridControl = this.GCcliente;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colRuc_DNI
            // 
            this.colRuc_DNI.Caption = "Ruc/DNI";
            this.colRuc_DNI.FieldName = "Ruc_DNI";
            this.colRuc_DNI.Name = "colRuc_DNI";
            this.colRuc_DNI.Visible = true;
            this.colRuc_DNI.VisibleIndex = 0;
            // 
            // colNombre
            // 
            this.colNombre.Caption = "Nombre/Razón Social";
            this.colNombre.FieldName = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 1;
            // 
            // colApellidos
            // 
            this.colApellidos.Caption = "Apellidos";
            this.colApellidos.FieldName = "Apellidos";
            this.colApellidos.Name = "colApellidos";
            this.colApellidos.Visible = true;
            this.colApellidos.VisibleIndex = 2;
            // 
            // txtdni
            // 
            this.txtdni.Location = new System.Drawing.Point(8, 43);
            this.txtdni.Name = "txtdni";
            this.txtdni.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtdni.Properties.PopupControl = this.PCcliente;
            this.txtdni.Size = new System.Drawing.Size(175, 20);
            this.txtdni.TabIndex = 8;
            this.txtdni.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtdni_MouseClick);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Location = new System.Drawing.Point(5, 24);
            this.labelControl6.LookAndFeel.SkinName = "Office 2013";
            this.labelControl6.LookAndFeel.UseDefaultLookAndFeel = false;
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(127, 13);
            this.labelControl6.TabIndex = 7;
            this.labelControl6.Text = "RUC/DNI de busqueda:";
            // 
            // groupControl2
            // 
            this.groupControl2.CaptionImage = ((System.Drawing.Image)(resources.GetObject("groupControl2.CaptionImage")));
            this.groupControl2.Controls.Add(this.groupControl4);
            this.groupControl2.Controls.Add(fotoLabel1);
            this.groupControl2.Controls.Add(this.fotoPictureBox);
            this.groupControl2.Controls.Add(ruc_DNILabel);
            this.groupControl2.Controls.Add(this.ruc_DNITextEdit);
            this.groupControl2.Controls.Add(nombreLabel);
            this.groupControl2.Controls.Add(this.nombreTextEdit);
            this.groupControl2.Controls.Add(apellidosLabel);
            this.groupControl2.Controls.Add(this.apellidosTextEdit);
            this.groupControl2.Controls.Add(direccionLabel);
            this.groupControl2.Controls.Add(this.direccionTextEdit);
            this.groupControl2.Controls.Add(observacionesLabel);
            this.groupControl2.Controls.Add(this.observacionesTextEdit);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(619, 356);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Datos del Cliente";
            // 
            // groupControl4
            // 
            this.groupControl4.CaptionImage = ((System.Drawing.Image)(resources.GetObject("groupControl4.CaptionImage")));
            this.groupControl4.Controls.Add(com_correoLabel);
            this.groupControl4.Controls.Add(this.com_correoTextEdit);
            this.groupControl4.Controls.Add(com_telefonoLabel);
            this.groupControl4.Controls.Add(this.com_telefonoTextEdit);
            this.groupControl4.Controls.Add(compradorLabel);
            this.groupControl4.Controls.Add(this.compradorTextEdit);
            this.groupControl4.Location = new System.Drawing.Point(22, 167);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(352, 120);
            this.groupControl4.TabIndex = 23;
            this.groupControl4.Text = "Representante";
            // 
            // com_correoTextEdit
            // 
            this.com_correoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.clienteBindingSource, "com_correo", true));
            this.com_correoTextEdit.Location = new System.Drawing.Point(134, 80);
            this.com_correoTextEdit.Name = "com_correoTextEdit";
            this.com_correoTextEdit.Properties.Mask.EditMask = ".+";
            this.com_correoTextEdit.Size = new System.Drawing.Size(213, 20);
            this.com_correoTextEdit.TabIndex = 5;
            // 
            // com_telefonoTextEdit
            // 
            this.com_telefonoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.clienteBindingSource, "com_telefono", true));
            this.com_telefonoTextEdit.Location = new System.Drawing.Point(134, 51);
            this.com_telefonoTextEdit.Name = "com_telefonoTextEdit";
            this.com_telefonoTextEdit.Properties.Mask.EditMask = "000-000000";
            this.com_telefonoTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.com_telefonoTextEdit.Size = new System.Drawing.Size(119, 20);
            this.com_telefonoTextEdit.TabIndex = 3;
            // 
            // compradorTextEdit
            // 
            this.compradorTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.clienteBindingSource, "Comprador", true));
            this.compradorTextEdit.Location = new System.Drawing.Point(134, 24);
            this.compradorTextEdit.Name = "compradorTextEdit";
            this.compradorTextEdit.Size = new System.Drawing.Size(213, 20);
            this.compradorTextEdit.TabIndex = 1;
            // 
            // fotoPictureBox
            // 
            this.fotoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fotoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.clienteBindingSource, "foto", true));
            this.fotoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("fotoPictureBox.Image")));
            this.fotoPictureBox.Location = new System.Drawing.Point(380, 24);
            this.fotoPictureBox.Name = "fotoPictureBox";
            this.fotoPictureBox.Size = new System.Drawing.Size(210, 223);
            this.fotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoPictureBox.TabIndex = 22;
            this.fotoPictureBox.TabStop = false;
            this.fotoPictureBox.Click += new System.EventHandler(this.fotoPictureBox_Click);
            // 
            // ruc_DNITextEdit
            // 
            this.ruc_DNITextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.clienteBindingSource, "Ruc_DNI", true));
            this.ruc_DNITextEdit.Location = new System.Drawing.Point(156, 24);
            this.ruc_DNITextEdit.Name = "ruc_DNITextEdit";
            this.ruc_DNITextEdit.Size = new System.Drawing.Size(131, 20);
            this.ruc_DNITextEdit.TabIndex = 12;
            // 
            // nombreTextEdit
            // 
            this.nombreTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.clienteBindingSource, "Nombre", true));
            this.nombreTextEdit.Location = new System.Drawing.Point(156, 50);
            this.nombreTextEdit.Name = "nombreTextEdit";
            this.nombreTextEdit.Size = new System.Drawing.Size(218, 20);
            this.nombreTextEdit.TabIndex = 14;
            // 
            // apellidosTextEdit
            // 
            this.apellidosTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.clienteBindingSource, "Apellidos", true));
            this.apellidosTextEdit.Location = new System.Drawing.Point(156, 76);
            this.apellidosTextEdit.Name = "apellidosTextEdit";
            this.apellidosTextEdit.Size = new System.Drawing.Size(218, 20);
            this.apellidosTextEdit.TabIndex = 16;
            // 
            // direccionTextEdit
            // 
            this.direccionTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.clienteBindingSource, "Direccion", true));
            this.direccionTextEdit.Location = new System.Drawing.Point(156, 102);
            this.direccionTextEdit.Name = "direccionTextEdit";
            this.direccionTextEdit.Size = new System.Drawing.Size(218, 20);
            this.direccionTextEdit.TabIndex = 18;
            // 
            // observacionesTextEdit
            // 
            this.observacionesTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.clienteBindingSource, "Observaciones", true));
            this.observacionesTextEdit.Location = new System.Drawing.Point(156, 128);
            this.observacionesTextEdit.Name = "observacionesTextEdit";
            this.observacionesTextEdit.Size = new System.Drawing.Size(218, 20);
            this.observacionesTextEdit.TabIndex = 20;
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImage = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImage")));
            this.groupControl1.Controls.Add(this.splitContainerControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(816, 397);
            this.groupControl1.TabIndex = 8;
            this.groupControl1.Text = "Cliente";
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AcabadosTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BancosTableAdapter = null;
            this.tableAdapterManager.CChica_EgresoTableAdapter = null;
            this.tableAdapterManager.CChica_IngresoTableAdapter = null;
            this.tableAdapterManager.ClienteTableAdapter = this.clienteTableAdapter;
            this.tableAdapterManager.Cuenta_bancosTableAdapter = null;
            this.tableAdapterManager.Dep_BancosTableAdapter = null;
            this.tableAdapterManager.Documento_pagoTableAdapter = null;
            this.tableAdapterManager.ERP_empresaTableAdapter = null;
            this.tableAdapterManager.Header_cotizaTableAdapter = null;
            this.tableAdapterManager.Header_GremisionTableAdapter = null;
            this.tableAdapterManager.Header_PagoTableAdapter = null;
            this.tableAdapterManager.ImpresionesTableAdapter = null;
            this.tableAdapterManager.MaterialTableAdapter = null;
            this.tableAdapterManager.Unidad_MedidaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AQCobranza.DSAQCobranzaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 397);
            this.Controls.Add(this.groupControl1);
            this.LookAndFeel.SkinName = "Office 2013";
            this.Name = "Cliente";
            this.Text = "Cliente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingNavigator)).EndInit();
            this.clienteBindingNavigator.ResumeLayout(false);
            this.clienteBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAQCobranza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PCcliente)).EndInit();
            this.PCcliente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SCcliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GCcliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdni.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.groupControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.com_correoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.com_telefonoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compradorTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ruc_DNITextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nombreTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apellidosTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.direccionTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.observacionesTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.PopupContainerEdit txtdni;
        private DevExpress.XtraEditors.PopupContainerControl PCcliente;
        private DSAQCobranza dSAQCobranza;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private DSAQCobranzaTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private DSAQCobranzaTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator clienteBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton clienteBindingNavigatorSaveItem;
        private DevExpress.XtraEditors.SearchControl SCcliente;
        private DevExpress.XtraGrid.GridControl GCcliente;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colRuc_DNI;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colApellidos;
        private DevExpress.XtraEditors.TextEdit ruc_DNITextEdit;
        private DevExpress.XtraEditors.TextEdit nombreTextEdit;
        private DevExpress.XtraEditors.TextEdit apellidosTextEdit;
        private DevExpress.XtraEditors.TextEdit direccionTextEdit;
        private DevExpress.XtraEditors.TextEdit observacionesTextEdit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox fotoPictureBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.TextEdit com_correoTextEdit;
        private DevExpress.XtraEditors.TextEdit com_telefonoTextEdit;
        private DevExpress.XtraEditors.TextEdit compradorTextEdit;
    }
}