using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace AQCobranza
{
    public partial class dashboard : DevExpress.XtraEditors.XtraForm
    {
        public dashboard()
        {
            InitializeComponent();
        }

        public void cargar_dashboard()
        {
            this.Cantidad_pagadosTableAdapter.Fill(this.dSAQDashboard.Cantidad_pagados,Convert.ToDecimal(cbMes.SelectedIndex+1),Convert.ToDecimal(lblaño.Text));
            this.reportViewer1.RefreshReport();
            this.CantidadVencidosTableAdapter.Fill(this.dSAQDashboard.CantidadVencidos);
            this.reportViewer2.RefreshReport();
        }
        private void dashboard_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSAQDashboard.CantidadVencidos' Puede moverla o quitarla según sea necesario.
         
            // TODO: esta línea de código carga datos en la tabla 'dSAQDashboard.Cantidad_pagados' Puede moverla o quitarla según sea necesario.
           this.eRP_empresaTableAdapter.Fill(this.dSAQCobranza.ERP_empresa);
           splitContainerControl3.SplitterPosition = splitContainerControl1.Width / 3;
           splitContainerControl4.SplitterPosition = splitContainerControl1.Height / 2;
           splitContainerControl5.SplitterPosition = splitContainerControl1.Height / 2;
           lblaño.Text = DateTime.Now.Year.ToString();
           cbMes.SelectedIndex = DateTime.Now.Month - 1;       
           cargar_dashboard();
           this.reportViewer2.RefreshReport();
           this.reportViewer2.RefreshReport();
        }

        private void splitContainerControl2_Paint(object sender, PaintEventArgs e)
        {

        }
    

        private void cbMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargar_dashboard();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cargar_dashboard();
        }

        
    }
}