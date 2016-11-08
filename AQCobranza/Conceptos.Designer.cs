namespace AQCobranza
{
    partial class Conceptos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Conceptos));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.btnNuevo = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.btnActualizar = new DevExpress.XtraEditors.SimpleButton();
            this.btnBuscar = new DevExpress.XtraEditors.SimpleButton();
            this.txtbus_concep = new DevExpress.XtraEditors.TextEdit();
            this.btnRegistrar = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.txtcodExtra = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtCxUnidad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.gwConceptos = new System.Windows.Forms.DataGridView();
            this.codconcepDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_extra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conceptoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacionesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoxunidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.psConceptosBuscarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSAQCobranzaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSAQCobranza = new AQCobranza.DSAQCobranza();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtCodigo = new DevExpress.XtraEditors.TextEdit();
            this.txtConcepto = new DevExpress.XtraEditors.TextEdit();
            this.txtObserva = new DevExpress.XtraEditors.MemoEdit();
            this.ps_Conceptos_BuscarTableAdapter = new AQCobranza.DSAQCobranzaTableAdapters.ps_Conceptos_BuscarTableAdapter();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtbus_concep.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtcodExtra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCxUnidad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gwConceptos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.psConceptosBuscarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAQCobranzaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAQCobranza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConcepto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObserva.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImage = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImage")));
            this.groupControl1.Controls.Add(this.splitContainerControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(748, 462);
            this.groupControl1.TabIndex = 11;
            this.groupControl1.Text = "Conceptos";
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
            this.splitContainerControl1.Size = new System.Drawing.Size(744, 421);
            this.splitContainerControl1.SplitterPosition = 196;
            this.splitContainerControl1.TabIndex = 7;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.btnNuevo);
            this.groupControl3.Controls.Add(this.labelControl6);
            this.groupControl3.Controls.Add(this.btnActualizar);
            this.groupControl3.Controls.Add(this.btnBuscar);
            this.groupControl3.Controls.Add(this.txtbus_concep);
            this.groupControl3.Controls.Add(this.btnRegistrar);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 0);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(196, 421);
            this.groupControl3.TabIndex = 0;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(8, 105);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(108, 34);
            this.btnNuevo.TabIndex = 8;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Location = new System.Drawing.Point(5, 24);
            this.labelControl6.LookAndFeel.SkinName = "Office 2013";
            this.labelControl6.LookAndFeel.UseDefaultLookAndFeel = false;
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(59, 13);
            this.labelControl6.TabIndex = 7;
            this.labelControl6.Text = "Concepto :";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.Location = new System.Drawing.Point(8, 185);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(108, 34);
            this.btnActualizar.TabIndex = 5;
            this.btnActualizar.Text = "Actualizar ";
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(8, 65);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(108, 34);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtbus_concep
            // 
            this.txtbus_concep.Location = new System.Drawing.Point(3, 39);
            this.txtbus_concep.Name = "txtbus_concep";
            this.txtbus_concep.Size = new System.Drawing.Size(180, 20);
            this.txtbus_concep.TabIndex = 1;
            this.txtbus_concep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbus_concep_KeyPress);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrar.Image")));
            this.btnRegistrar.Location = new System.Drawing.Point(8, 145);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(108, 34);
            this.btnRegistrar.TabIndex = 0;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.CaptionImage = ((System.Drawing.Image)(resources.GetObject("groupControl2.CaptionImage")));
            this.groupControl2.Controls.Add(this.simpleButton1);
            this.groupControl2.Controls.Add(this.txtcodExtra);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.txtCxUnidad);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.gwConceptos);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Controls.Add(this.txtCodigo);
            this.groupControl2.Controls.Add(this.txtConcepto);
            this.groupControl2.Controls.Add(this.txtObserva);
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(526, 421);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Datos del Concepto";
            // 
            // txtcodExtra
            // 
            this.txtcodExtra.Location = new System.Drawing.Point(166, 49);
            this.txtcodExtra.Name = "txtcodExtra";
            this.txtcodExtra.Properties.Mask.EditMask = "aaaaaaaaaa";
            this.txtcodExtra.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.txtcodExtra.Size = new System.Drawing.Size(185, 20);
            this.txtcodExtra.TabIndex = 13;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Location = new System.Drawing.Point(26, 52);
            this.labelControl5.LookAndFeel.SkinName = "Office 2013";
            this.labelControl5.LookAndFeel.UseDefaultLookAndFeel = false;
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(88, 13);
            this.labelControl5.TabIndex = 12;
            this.labelControl5.Text = "Código Externo:";
            // 
            // txtCxUnidad
            // 
            this.txtCxUnidad.EditValue = "0";
            this.txtCxUnidad.Location = new System.Drawing.Point(166, 147);
            this.txtCxUnidad.Name = "txtCxUnidad";
            this.txtCxUnidad.Properties.Mask.EditMask = "c";
            this.txtCxUnidad.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtCxUnidad.Size = new System.Drawing.Size(82, 20);
            this.txtCxUnidad.TabIndex = 11;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Location = new System.Drawing.Point(24, 146);
            this.labelControl4.LookAndFeel.SkinName = "Office 2013";
            this.labelControl4.LookAndFeel.UseDefaultLookAndFeel = false;
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(90, 13);
            this.labelControl4.TabIndex = 10;
            this.labelControl4.Text = "Costo x Unidad :";
            // 
            // gwConceptos
            // 
            this.gwConceptos.AllowUserToAddRows = false;
            this.gwConceptos.AllowUserToDeleteRows = false;
            this.gwConceptos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gwConceptos.AutoGenerateColumns = false;
            this.gwConceptos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gwConceptos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codconcepDataGridViewTextBoxColumn,
            this.cod_extra,
            this.conceptoDataGridViewTextBoxColumn,
            this.observacionesDataGridViewTextBoxColumn,
            this.costoxunidad});
            this.gwConceptos.DataSource = this.psConceptosBuscarBindingSource;
            this.gwConceptos.Location = new System.Drawing.Point(16, 185);
            this.gwConceptos.Name = "gwConceptos";
            this.gwConceptos.ReadOnly = true;
            this.gwConceptos.Size = new System.Drawing.Size(503, 226);
            this.gwConceptos.TabIndex = 9;
            this.gwConceptos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gwConceptos_CellClick);
            this.gwConceptos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gwConceptos_CellContentClick);
            // 
            // codconcepDataGridViewTextBoxColumn
            // 
            this.codconcepDataGridViewTextBoxColumn.DataPropertyName = "Cod_concep";
            this.codconcepDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codconcepDataGridViewTextBoxColumn.Name = "codconcepDataGridViewTextBoxColumn";
            this.codconcepDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cod_extra
            // 
            this.cod_extra.DataPropertyName = "cod_extra";
            this.cod_extra.HeaderText = "Cod. Extra";
            this.cod_extra.Name = "cod_extra";
            this.cod_extra.ReadOnly = true;
            // 
            // conceptoDataGridViewTextBoxColumn
            // 
            this.conceptoDataGridViewTextBoxColumn.DataPropertyName = "concepto";
            this.conceptoDataGridViewTextBoxColumn.HeaderText = "Concepto";
            this.conceptoDataGridViewTextBoxColumn.Name = "conceptoDataGridViewTextBoxColumn";
            this.conceptoDataGridViewTextBoxColumn.ReadOnly = true;
            this.conceptoDataGridViewTextBoxColumn.Width = 200;
            // 
            // observacionesDataGridViewTextBoxColumn
            // 
            this.observacionesDataGridViewTextBoxColumn.DataPropertyName = "Observaciones";
            this.observacionesDataGridViewTextBoxColumn.HeaderText = "Observaciones";
            this.observacionesDataGridViewTextBoxColumn.Name = "observacionesDataGridViewTextBoxColumn";
            this.observacionesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // costoxunidad
            // 
            this.costoxunidad.DataPropertyName = "costoxunidad";
            this.costoxunidad.HeaderText = "Costo x Unidad";
            this.costoxunidad.Name = "costoxunidad";
            this.costoxunidad.ReadOnly = true;
            // 
            // psConceptosBuscarBindingSource
            // 
            this.psConceptosBuscarBindingSource.DataMember = "ps_Conceptos_Buscar";
            this.psConceptosBuscarBindingSource.DataSource = this.dSAQCobranzaBindingSource;
            // 
            // dSAQCobranzaBindingSource
            // 
            this.dSAQCobranzaBindingSource.DataSource = this.dSAQCobranza;
            this.dSAQCobranzaBindingSource.Position = 0;
            // 
            // dSAQCobranza
            // 
            this.dSAQCobranza.DataSetName = "DSAQCobranza";
            this.dSAQCobranza.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Location = new System.Drawing.Point(24, 101);
            this.labelControl3.LookAndFeel.SkinName = "Office 2013";
            this.labelControl3.LookAndFeel.UseDefaultLookAndFeel = false;
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(89, 13);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Observaciones :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Location = new System.Drawing.Point(24, 75);
            this.labelControl2.LookAndFeel.SkinName = "Office 2013";
            this.labelControl2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(56, 13);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Concepto:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(24, 27);
            this.labelControl1.LookAndFeel.SkinName = "Office 2013";
            this.labelControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(110, 13);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Código Automatico:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(166, 26);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Properties.Mask.EditMask = "aaaaaaaaaa";
            this.txtCodigo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.txtCodigo.Size = new System.Drawing.Size(185, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // txtConcepto
            // 
            this.txtConcepto.Location = new System.Drawing.Point(166, 72);
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.Size = new System.Drawing.Size(346, 20);
            this.txtConcepto.TabIndex = 2;
            // 
            // txtObserva
            // 
            this.txtObserva.Location = new System.Drawing.Point(166, 98);
            this.txtObserva.Name = "txtObserva";
            this.txtObserva.Size = new System.Drawing.Size(346, 43);
            this.txtObserva.TabIndex = 3;
            // 
            // ps_Conceptos_BuscarTableAdapter
            // 
            this.ps_Conceptos_BuscarTableAdapter.ClearBeforeFill = true;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(264, 145);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(97, 34);
            this.simpleButton1.TabIndex = 9;
            this.simpleButton1.Text = "Eliminar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // Conceptos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 462);
            this.Controls.Add(this.groupControl1);
            this.LookAndFeel.SkinName = "Office 2013";
            this.Name = "Conceptos";
            this.Text = "Conceptos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Conceptos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtbus_concep.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtcodExtra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCxUnidad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gwConceptos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.psConceptosBuscarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAQCobranzaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAQCobranza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConcepto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObserva.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton btnActualizar;
        private DevExpress.XtraEditors.SimpleButton btnBuscar;
        private DevExpress.XtraEditors.TextEdit txtbus_concep;
        private DevExpress.XtraEditors.SimpleButton btnRegistrar;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtCodigo;
        private DevExpress.XtraEditors.TextEdit txtConcepto;
        private DevExpress.XtraEditors.SimpleButton btnNuevo;
        private System.Windows.Forms.DataGridView gwConceptos;
        private System.Windows.Forms.BindingSource psConceptosBuscarBindingSource;
        private System.Windows.Forms.BindingSource dSAQCobranzaBindingSource;
        private DSAQCobranza dSAQCobranza;
        private DSAQCobranzaTableAdapters.ps_Conceptos_BuscarTableAdapter ps_Conceptos_BuscarTableAdapter;
        private DevExpress.XtraEditors.TextEdit txtCxUnidad;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.MemoEdit txtObserva;
        private DevExpress.XtraEditors.TextEdit txtcodExtra;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.DataGridViewTextBoxColumn codconcepDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_extra;
        private System.Windows.Forms.DataGridViewTextBoxColumn conceptoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacionesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoxunidad;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;

    }
}