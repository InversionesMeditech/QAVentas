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
    public partial class impri_factura : DevExpress.XtraEditors.XtraForm
    {
        public string _comprobante;
        public impri_factura()
        {
            InitializeComponent();
        }

        private void impri_factura_Load(object sender, EventArgs e)
        {
            txtcomprobante.Text = _comprobante;
            this.view_ComprobanteTableAdapter.Fill(this.dSAQCobranza.View_Comprobante, txtcomprobante.Text);
            Factura1 = new Factura();
            Factura1.SetDataSource(this.dSAQCobranza);
            crystalReportViewer1.ReportSource = Factura1;
            crystalReportViewer1.Refresh();
        }


    }
}