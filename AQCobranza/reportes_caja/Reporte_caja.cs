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

namespace AQCobranza.reportes_caja
{
    public partial class Reporte_caja : DevExpress.XtraEditors.XtraForm
    {
        public Reporte_caja()
        {
            InitializeComponent();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Reporte_caja_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSAQReportes.ps_Reporte_caja_01' Puede moverla o quitarla según sea necesario.
            

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.ps_Reporte_caja_01TableAdapter.Fill(this.dSAQReportes.ps_Reporte_caja_01,Convert.ToInt16(cbAño.Text),cbMes.SelectedIndex+1);
            this.reportViewer1.RefreshReport();
        }
    }
}