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
    public partial class Reporte_Deuda : DevExpress.XtraEditors.XtraForm
    {
        public Reporte_Deuda()
        {
            InitializeComponent();
        }

        private void Reporte_Deuda_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            this.ps_Reporte_deuda_01TableAdapter.Fill(this.dSAQReportes.ps_Reporte_deuda_01, Convert.ToInt16(cbAño.Text), cbMes.SelectedIndex + 1);
            this.reportViewer1.RefreshReport();
        }
    }
}