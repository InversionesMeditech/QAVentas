namespace AQCobranza
{
    partial class Conceptos_egreso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Conceptos_egreso));
            System.Windows.Forms.Label cod_concEgresoLabel;
            System.Windows.Forms.Label concep_EgresoLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label estadoLabel;
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dSCaja = new AQCobranza.DSCaja();
            this.concepto_egresoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.concepto_egresoTableAdapter = new AQCobranza.DSCajaTableAdapters.Concepto_egresoTableAdapter();
            this.tableAdapterManager = new AQCobranza.DSCajaTableAdapters.TableAdapterManager();
            this.concepto_egresoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.concepto_egresoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cod_concEgresoSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.concep_EgresoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.estadoCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.descripcionTextEdit = new DevExpress.XtraEditors.MemoEdit();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.concepto_egresoGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcod_concEgreso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colConcep_Egreso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestado = new DevExpress.XtraGrid.Columns.GridColumn();
            cod_concEgresoLabel = new System.Windows.Forms.Label();
            concep_EgresoLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dSCaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.concepto_egresoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.concepto_egresoBindingNavigator)).BeginInit();
            this.concepto_egresoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cod_concEgresoSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.concep_EgresoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descripcionTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.concepto_egresoGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImage = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImage")));
            this.groupControl1.Controls.Add(this.splitContainerControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(789, 445);
            this.groupControl1.TabIndex = 12;
            this.groupControl1.Text = "Conceptos de Egresos";
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
            this.splitContainerControl1.Size = new System.Drawing.Size(785, 404);
            this.splitContainerControl1.TabIndex = 7;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.concepto_egresoBindingNavigator);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 0);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(100, 404);
            this.groupControl3.TabIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.CaptionImage = ((System.Drawing.Image)(resources.GetObject("groupControl2.CaptionImage")));
            this.groupControl2.Controls.Add(this.groupControl4);
            this.groupControl2.Controls.Add(cod_concEgresoLabel);
            this.groupControl2.Controls.Add(this.cod_concEgresoSpinEdit);
            this.groupControl2.Controls.Add(concep_EgresoLabel);
            this.groupControl2.Controls.Add(this.concep_EgresoTextEdit);
            this.groupControl2.Controls.Add(descripcionLabel);
            this.groupControl2.Controls.Add(estadoLabel);
            this.groupControl2.Controls.Add(this.estadoCheckEdit);
            this.groupControl2.Controls.Add(this.descripcionTextEdit);
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(663, 453);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Datos del Concepto de Egreso";
            // 
            // dSCaja
            // 
            this.dSCaja.DataSetName = "DSCaja";
            this.dSCaja.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // concepto_egresoBindingSource
            // 
            this.concepto_egresoBindingSource.DataMember = "Concepto_egreso";
            this.concepto_egresoBindingSource.DataSource = this.dSCaja;
            // 
            // concepto_egresoTableAdapter
            // 
            this.concepto_egresoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Concepto_egresoTableAdapter = this.concepto_egresoTableAdapter;
            this.tableAdapterManager.UpdateOrder = AQCobranza.DSCajaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // concepto_egresoBindingNavigator
            // 
            this.concepto_egresoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.concepto_egresoBindingNavigator.BindingSource = this.concepto_egresoBindingSource;
            this.concepto_egresoBindingNavigator.CountItem = null;
            this.concepto_egresoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.concepto_egresoBindingNavigator.Dock = System.Windows.Forms.DockStyle.Left;
            this.concepto_egresoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.concepto_egresoBindingNavigatorSaveItem});
            this.concepto_egresoBindingNavigator.Location = new System.Drawing.Point(2, 20);
            this.concepto_egresoBindingNavigator.MoveFirstItem = null;
            this.concepto_egresoBindingNavigator.MoveLastItem = null;
            this.concepto_egresoBindingNavigator.MoveNextItem = null;
            this.concepto_egresoBindingNavigator.MovePreviousItem = null;
            this.concepto_egresoBindingNavigator.Name = "concepto_egresoBindingNavigator";
            this.concepto_egresoBindingNavigator.PositionItem = null;
            this.concepto_egresoBindingNavigator.Size = new System.Drawing.Size(98, 382);
            this.concepto_egresoBindingNavigator.TabIndex = 13;
            this.concepto_egresoBindingNavigator.Text = "bindingNavigator1";
            this.concepto_egresoBindingNavigator.RefreshItems += new System.EventHandler(this.concepto_egresoBindingNavigator_RefreshItems);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = global::AQCobranza.Properties.Resources.additem_32x32;
            this.bindingNavigatorAddNewItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(95, 36);
            this.bindingNavigatorAddNewItem.Text = "NUEVO";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Image = global::AQCobranza.Properties.Resources.cancel_32x32;
            this.bindingNavigatorDeleteItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(95, 36);
            this.bindingNavigatorDeleteItem.Text = "ELIMINAR";
            // 
            // concepto_egresoBindingNavigatorSaveItem
            // 
            this.concepto_egresoBindingNavigatorSaveItem.Image = global::AQCobranza.Properties.Resources.saveto_32x32;
            this.concepto_egresoBindingNavigatorSaveItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.concepto_egresoBindingNavigatorSaveItem.Name = "concepto_egresoBindingNavigatorSaveItem";
            this.concepto_egresoBindingNavigatorSaveItem.Size = new System.Drawing.Size(95, 36);
            this.concepto_egresoBindingNavigatorSaveItem.Text = "GUARDAR";
            this.concepto_egresoBindingNavigatorSaveItem.Click += new System.EventHandler(this.concepto_egresoBindingNavigatorSaveItem_Click);
            // 
            // cod_concEgresoLabel
            // 
            cod_concEgresoLabel.AutoSize = true;
            cod_concEgresoLabel.Location = new System.Drawing.Point(18, 42);
            cod_concEgresoLabel.Name = "cod_concEgresoLabel";
            cod_concEgresoLabel.Size = new System.Drawing.Size(44, 13);
            cod_concEgresoLabel.TabIndex = 0;
            cod_concEgresoLabel.Text = "Código:";
            // 
            // cod_concEgresoSpinEdit
            // 
            this.cod_concEgresoSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.concepto_egresoBindingSource, "cod_concEgreso", true));
            this.cod_concEgresoSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.cod_concEgresoSpinEdit.Enabled = false;
            this.cod_concEgresoSpinEdit.Location = new System.Drawing.Point(132, 39);
            this.cod_concEgresoSpinEdit.Name = "cod_concEgresoSpinEdit";
            this.cod_concEgresoSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cod_concEgresoSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.cod_concEgresoSpinEdit.TabIndex = 1;
            // 
            // concep_EgresoLabel
            // 
            concep_EgresoLabel.AutoSize = true;
            concep_EgresoLabel.Location = new System.Drawing.Point(18, 68);
            concep_EgresoLabel.Name = "concep_EgresoLabel";
            concep_EgresoLabel.Size = new System.Drawing.Size(108, 13);
            concep_EgresoLabel.TabIndex = 2;
            concep_EgresoLabel.Text = "Concepto de Egreso:";
            // 
            // concep_EgresoTextEdit
            // 
            this.concep_EgresoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.concepto_egresoBindingSource, "Concep_Egreso", true));
            this.concep_EgresoTextEdit.Location = new System.Drawing.Point(132, 65);
            this.concep_EgresoTextEdit.Name = "concep_EgresoTextEdit";
            this.concep_EgresoTextEdit.Size = new System.Drawing.Size(278, 20);
            this.concep_EgresoTextEdit.TabIndex = 3;
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(18, 94);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(65, 13);
            descripcionLabel.TabIndex = 4;
            descripcionLabel.Text = "Descripción:";
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Location = new System.Drawing.Point(18, 135);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(44, 13);
            estadoLabel.TabIndex = 6;
            estadoLabel.Text = "Estado:";
            // 
            // estadoCheckEdit
            // 
            this.estadoCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.concepto_egresoBindingSource, "estado", true));
            this.estadoCheckEdit.Location = new System.Drawing.Point(132, 132);
            this.estadoCheckEdit.Name = "estadoCheckEdit";
            this.estadoCheckEdit.Properties.Caption = "";
            this.estadoCheckEdit.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style16;
            this.estadoCheckEdit.Size = new System.Drawing.Size(100, 22);
            this.estadoCheckEdit.TabIndex = 7;
            // 
            // descripcionTextEdit
            // 
            this.descripcionTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.concepto_egresoBindingSource, "Descripcion", true));
            this.descripcionTextEdit.Location = new System.Drawing.Point(132, 91);
            this.descripcionTextEdit.Name = "descripcionTextEdit";
            this.descripcionTextEdit.Size = new System.Drawing.Size(278, 35);
            this.descripcionTextEdit.TabIndex = 5;
            // 
            // groupControl4
            // 
            this.groupControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl4.Controls.Add(this.concepto_egresoGridControl);
            this.groupControl4.Location = new System.Drawing.Point(21, 160);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(594, 239);
            this.groupControl4.TabIndex = 8;
            // 
            // concepto_egresoGridControl
            // 
            this.concepto_egresoGridControl.DataSource = this.concepto_egresoBindingSource;
            this.concepto_egresoGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.concepto_egresoGridControl.Location = new System.Drawing.Point(2, 20);
            this.concepto_egresoGridControl.MainView = this.gridView1;
            this.concepto_egresoGridControl.Name = "concepto_egresoGridControl";
            this.concepto_egresoGridControl.Size = new System.Drawing.Size(590, 217);
            this.concepto_egresoGridControl.TabIndex = 0;
            this.concepto_egresoGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcod_concEgreso,
            this.colConcep_Egreso,
            this.colDescripcion,
            this.colestado});
            this.gridView1.GridControl = this.concepto_egresoGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colcod_concEgreso
            // 
            this.colcod_concEgreso.Caption = "Código";
            this.colcod_concEgreso.FieldName = "cod_concEgreso";
            this.colcod_concEgreso.Image = ((System.Drawing.Image)(resources.GetObject("colcod_concEgreso.Image")));
            this.colcod_concEgreso.Name = "colcod_concEgreso";
            this.colcod_concEgreso.Visible = true;
            this.colcod_concEgreso.VisibleIndex = 0;
            // 
            // colConcep_Egreso
            // 
            this.colConcep_Egreso.Caption = "Concepto Egreso";
            this.colConcep_Egreso.FieldName = "Concep_Egreso";
            this.colConcep_Egreso.Image = ((System.Drawing.Image)(resources.GetObject("colConcep_Egreso.Image")));
            this.colConcep_Egreso.Name = "colConcep_Egreso";
            this.colConcep_Egreso.Visible = true;
            this.colConcep_Egreso.VisibleIndex = 1;
            // 
            // colDescripcion
            // 
            this.colDescripcion.Caption = "Descripción";
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Image = ((System.Drawing.Image)(resources.GetObject("colDescripcion.Image")));
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 2;
            // 
            // colestado
            // 
            this.colestado.Caption = "Estado";
            this.colestado.FieldName = "estado";
            this.colestado.Image = ((System.Drawing.Image)(resources.GetObject("colestado.Image")));
            this.colestado.Name = "colestado";
            this.colestado.Visible = true;
            this.colestado.VisibleIndex = 3;
            // 
            // Conceptos_egreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 445);
            this.Controls.Add(this.groupControl1);
            this.Name = "Conceptos_egreso";
            this.Text = "Concepto de Egresos";
            this.Load += new System.EventHandler(this.Conceptos_egreso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dSCaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.concepto_egresoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.concepto_egresoBindingNavigator)).EndInit();
            this.concepto_egresoBindingNavigator.ResumeLayout(false);
            this.concepto_egresoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cod_concEgresoSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.concep_EgresoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descripcionTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.concepto_egresoGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DSCaja dSCaja;
        private System.Windows.Forms.BindingSource concepto_egresoBindingSource;
        private DSCajaTableAdapters.Concepto_egresoTableAdapter concepto_egresoTableAdapter;
        private DSCajaTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator concepto_egresoBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton concepto_egresoBindingNavigatorSaveItem;
        private DevExpress.XtraEditors.SpinEdit cod_concEgresoSpinEdit;
        private DevExpress.XtraEditors.TextEdit concep_EgresoTextEdit;
        private DevExpress.XtraEditors.CheckEdit estadoCheckEdit;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraGrid.GridControl concepto_egresoGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colcod_concEgreso;
        private DevExpress.XtraGrid.Columns.GridColumn colConcep_Egreso;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colestado;
        private DevExpress.XtraEditors.MemoEdit descripcionTextEdit;
    }
}