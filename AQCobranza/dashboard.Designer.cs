namespace AQCobranza
{
    partial class dashboard
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
            System.Windows.Forms.Label ruc_empresaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Cantidad_pagadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSAQDashboard = new AQCobranza.DSAQDashboard();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.e_logoPictureBox = new System.Windows.Forms.PictureBox();
            this.eRP_empresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSAQCobranza = new AQCobranza.DSAQCobranza();
            this.razon_SocialLabel1 = new System.Windows.Forms.Label();
            this.ruc_empresaLabel1 = new System.Windows.Forms.Label();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lblaño = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cbMes = new System.Windows.Forms.ComboBox();
            this.splitContainerControl3 = new DevExpress.XtraEditors.SplitContainerControl();
            this.splitContainerControl4 = new DevExpress.XtraEditors.SplitContainerControl();
            this.splitContainerControl5 = new DevExpress.XtraEditors.SplitContainerControl();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.eRP_empresaTableAdapter = new AQCobranza.DSAQCobranzaTableAdapters.ERP_empresaTableAdapter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Cantidad_pagadosTableAdapter = new AQCobranza.DSAQDashboardTableAdapters.Cantidad_pagadosTableAdapter();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.CantidadVencidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CantidadVencidosTableAdapter = new AQCobranza.DSAQDashboardTableAdapters.CantidadVencidosTableAdapter();
            ruc_empresaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Cantidad_pagadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAQDashboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.e_logoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eRP_empresaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAQCobranza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl3)).BeginInit();
            this.splitContainerControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl4)).BeginInit();
            this.splitContainerControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl5)).BeginInit();
            this.splitContainerControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadVencidosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Cantidad_pagadosBindingSource
            // 
            this.Cantidad_pagadosBindingSource.DataMember = "Cantidad_pagados";
            this.Cantidad_pagadosBindingSource.DataSource = this.dSAQDashboard;
            // 
            // dSAQDashboard
            // 
            this.dSAQDashboard.DataSetName = "DSAQDashboard";
            this.dSAQDashboard.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ruc_empresaLabel
            // 
            ruc_empresaLabel.AutoSize = true;
            ruc_empresaLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            ruc_empresaLabel.Location = new System.Drawing.Point(4, 37);
            ruc_empresaLabel.Name = "ruc_empresaLabel";
            ruc_empresaLabel.Size = new System.Drawing.Size(33, 13);
            ruc_empresaLabel.TabIndex = 4;
            ruc_empresaLabel.Text = "RUC:";
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImage = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImage")));
            this.groupControl1.Controls.Add(this.splitContainerControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(838, 462);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Dashboard";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(2, 39);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.splitContainerControl1.Panel1.Controls.Add(this.splitContainerControl2);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.splitContainerControl1.Panel2.Controls.Add(this.splitContainerControl3);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(834, 421);
            this.splitContainerControl1.SplitterPosition = 163;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.CustomHeaderButtons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Button", ((System.Drawing.Image)(resources.GetObject("splitContainerControl2.CustomHeaderButtons"))))});
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.Horizontal = false;
            this.splitContainerControl2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.splitContainerControl2.Panel1.Controls.Add(this.e_logoPictureBox);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.splitContainerControl2.Panel2.Controls.Add(this.razon_SocialLabel1);
            this.splitContainerControl2.Panel2.Controls.Add(ruc_empresaLabel);
            this.splitContainerControl2.Panel2.Controls.Add(this.ruc_empresaLabel1);
            this.splitContainerControl2.Panel2.Controls.Add(this.labelControl2);
            this.splitContainerControl2.Panel2.Controls.Add(this.lblaño);
            this.splitContainerControl2.Panel2.Controls.Add(this.labelControl1);
            this.splitContainerControl2.Panel2.Controls.Add(this.cbMes);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(159, 417);
            this.splitContainerControl2.SplitterPosition = 120;
            this.splitContainerControl2.TabIndex = 0;
            this.splitContainerControl2.Text = "splitContainerControl2";
            this.splitContainerControl2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainerControl2_Paint);
            // 
            // e_logoPictureBox
            // 
            this.e_logoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.eRP_empresaBindingSource, "e_logo", true));
            this.e_logoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.e_logoPictureBox.Location = new System.Drawing.Point(0, 0);
            this.e_logoPictureBox.Name = "e_logoPictureBox";
            this.e_logoPictureBox.Size = new System.Drawing.Size(155, 116);
            this.e_logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e_logoPictureBox.TabIndex = 1;
            this.e_logoPictureBox.TabStop = false;
            // 
            // eRP_empresaBindingSource
            // 
            this.eRP_empresaBindingSource.DataMember = "ERP_empresa";
            this.eRP_empresaBindingSource.DataSource = this.dSAQCobranza;
            // 
            // dSAQCobranza
            // 
            this.dSAQCobranza.DataSetName = "DSAQCobranza";
            this.dSAQCobranza.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // razon_SocialLabel1
            // 
            this.razon_SocialLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eRP_empresaBindingSource, "Razon_Social", true));
            this.razon_SocialLabel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.razon_SocialLabel1.Location = new System.Drawing.Point(6, 4);
            this.razon_SocialLabel1.Name = "razon_SocialLabel1";
            this.razon_SocialLabel1.Size = new System.Drawing.Size(131, 33);
            this.razon_SocialLabel1.TabIndex = 7;
            this.razon_SocialLabel1.Text = "label1";
            this.razon_SocialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ruc_empresaLabel1
            // 
            this.ruc_empresaLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eRP_empresaBindingSource, "ruc_empresa", true));
            this.ruc_empresaLabel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.ruc_empresaLabel1.Location = new System.Drawing.Point(47, 37);
            this.ruc_empresaLabel1.Name = "ruc_empresaLabel1";
            this.ruc_empresaLabel1.Size = new System.Drawing.Size(100, 22);
            this.ruc_empresaLabel1.TabIndex = 5;
            this.ruc_empresaLabel1.Text = "label1";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Location = new System.Drawing.Point(4, 86);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(29, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Mes :";
            // 
            // lblaño
            // 
            this.lblaño.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblaño.Location = new System.Drawing.Point(47, 62);
            this.lblaño.Name = "lblaño";
            this.lblaño.Size = new System.Drawing.Size(54, 13);
            this.lblaño.TabIndex = 2;
            this.lblaño.Text = "?????????";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(4, 62);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(25, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Año:";
            // 
            // cbMes
            // 
            this.cbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMes.FormattingEnabled = true;
            this.cbMes.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.cbMes.Location = new System.Drawing.Point(47, 83);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(90, 21);
            this.cbMes.TabIndex = 0;
            this.cbMes.SelectedIndexChanged += new System.EventHandler(this.cbMes_SelectedIndexChanged);
            // 
            // splitContainerControl3
            // 
            this.splitContainerControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl3.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl3.Name = "splitContainerControl3";
            this.splitContainerControl3.Panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.splitContainerControl3.Panel1.Controls.Add(this.splitContainerControl4);
            this.splitContainerControl3.Panel1.Text = "Panel1";
            this.splitContainerControl3.Panel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.splitContainerControl3.Panel2.Controls.Add(this.splitContainerControl5);
            this.splitContainerControl3.Panel2.Text = "Panel2";
            this.splitContainerControl3.Size = new System.Drawing.Size(662, 417);
            this.splitContainerControl3.SplitterPosition = 328;
            this.splitContainerControl3.TabIndex = 0;
            this.splitContainerControl3.Text = "splitContainerControl3";
            // 
            // splitContainerControl4
            // 
            this.splitContainerControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl4.Horizontal = false;
            this.splitContainerControl4.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl4.Name = "splitContainerControl4";
            this.splitContainerControl4.Panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.splitContainerControl4.Panel1.Controls.Add(this.reportViewer2);
            this.splitContainerControl4.Panel1.Text = "Panel1";
            this.splitContainerControl4.Panel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.splitContainerControl4.Panel2.Text = "Panel2";
            this.splitContainerControl4.Size = new System.Drawing.Size(324, 413);
            this.splitContainerControl4.SplitterPosition = 202;
            this.splitContainerControl4.TabIndex = 0;
            this.splitContainerControl4.Text = "splitContainerControl4";
            // 
            // splitContainerControl5
            // 
            this.splitContainerControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl5.Horizontal = false;
            this.splitContainerControl5.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl5.Name = "splitContainerControl5";
            this.splitContainerControl5.Panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.splitContainerControl5.Panel1.Controls.Add(this.reportViewer1);
            this.splitContainerControl5.Panel1.Text = "Panel1";
            this.splitContainerControl5.Panel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.splitContainerControl5.Panel2.Text = "Panel2";
            this.splitContainerControl5.Size = new System.Drawing.Size(325, 413);
            this.splitContainerControl5.SplitterPosition = 202;
            this.splitContainerControl5.TabIndex = 1;
            this.splitContainerControl5.Text = "splitContainerControl5";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.Cantidad_pagadosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AQCobranza.Dashboard.FacturasPagadas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ShowToolBar = false;
            this.reportViewer1.Size = new System.Drawing.Size(321, 198);
            this.reportViewer1.TabIndex = 0;
            // 
            // eRP_empresaTableAdapter
            // 
            this.eRP_empresaTableAdapter.ClearBeforeFill = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Cantidad_pagadosTableAdapter
            // 
            this.Cantidad_pagadosTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.CantidadVencidosBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "AQCobranza.Dashboard.facVencidos.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 0);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ShowToolBar = false;
            this.reportViewer2.Size = new System.Drawing.Size(320, 198);
            this.reportViewer2.TabIndex = 0;
            // 
            // CantidadVencidosBindingSource
            // 
            this.CantidadVencidosBindingSource.DataMember = "CantidadVencidos";
            this.CantidadVencidosBindingSource.DataSource = this.dSAQDashboard;
            // 
            // CantidadVencidosTableAdapter
            // 
            this.CantidadVencidosTableAdapter.ClearBeforeFill = true;
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 462);
            this.ControlBox = false;
            this.Controls.Add(this.groupControl1);
            this.MinimizeBox = false;
            this.Name = "dashboard";
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Cantidad_pagadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAQDashboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.e_logoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eRP_empresaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAQCobranza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl3)).EndInit();
            this.splitContainerControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl4)).EndInit();
            this.splitContainerControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl5)).EndInit();
            this.splitContainerControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CantidadVencidosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private DSAQCobranza dSAQCobranza;
        private System.Windows.Forms.BindingSource eRP_empresaBindingSource;
        private DSAQCobranzaTableAdapters.ERP_empresaTableAdapter eRP_empresaTableAdapter;
        private System.Windows.Forms.PictureBox e_logoPictureBox;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl3;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl4;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl5;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lblaño;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ComboBox cbMes;
        private DSAQDashboard dSAQDashboard;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label razon_SocialLabel1;
        private System.Windows.Forms.Label ruc_empresaLabel1;
        private System.Windows.Forms.BindingSource Cantidad_pagadosBindingSource;
        private DSAQDashboardTableAdapters.Cantidad_pagadosTableAdapter Cantidad_pagadosTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource CantidadVencidosBindingSource;
        private DSAQDashboardTableAdapters.CantidadVencidosTableAdapter CantidadVencidosTableAdapter;
    }
}