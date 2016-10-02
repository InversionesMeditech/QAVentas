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
    public partial class Comprobantes : DevExpress.XtraEditors.XtraForm
    {
        public Comprobantes()
        {
            InitializeComponent();
        }

        private void documento_pagoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.documento_pagoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSAQCobranza);

        }

        private void Comprobantes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSAQCobranza.Documento_pago' Puede moverla o quitarla según sea necesario.
            this.documento_pagoTableAdapter.Fill(this.dSAQCobranza.Documento_pago);

        }

        private void estadoCheckEdit_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}