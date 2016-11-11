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
    public partial class Conceptos_egreso : DevExpress.XtraEditors.XtraForm
    {
        public Conceptos_egreso()
        {
            InitializeComponent();
        }

        private void concepto_egresoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.concepto_egresoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSCaja);

        }

        private void Conceptos_egreso_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSCaja.Concepto_egreso' Puede moverla o quitarla según sea necesario.
            this.concepto_egresoTableAdapter.Fill(this.dSCaja.Concepto_egreso);

        }

        private void concepto_egresoBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}