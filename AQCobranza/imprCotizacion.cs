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
    public partial class imprCotizacion : DevExpress.XtraEditors.XtraForm
    {
        public string cod_cotiza;
        public imprCotizacion()
        {
            InitializeComponent();
        }

        private void imprCotizacion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DSAQCobranza.Cliente' Puede moverla o quitarla según sea necesario.
            txtCod_Cotiza.Text = cod_cotiza; // TODO: esta línea de código carga datos en la tabla 'DSAQCobranza.ps_Cotizacion_Buscar' Puede moverla o quitarla según sea necesario.
            this.ps_Cotizacion_BuscarTableAdapter.Fill(this.DSAQCobranza.ps_Cotizacion_Buscar, txtCod_Cotiza.Text); 
            this.reportViewer1.RefreshReport();
        }
    }
}