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
    public partial class ImprGremision : DevExpress.XtraEditors.XtraForm
    {
        public string cod_Grem;
        public ImprGremision()
        {
            InitializeComponent();
        }

        private void ImprGremision_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DSAQCobranza.View_Guia_remision' Puede moverla o quitarla según sea necesario.
            txtCod_Gremision.Text = cod_Grem;
            this.View_Guia_remisionTableAdapter.Fill(this.DSAQCobranza.View_Guia_remision,txtCod_Gremision.Text);
            this.reportViewer1.RefreshReport();
        }
    }
}