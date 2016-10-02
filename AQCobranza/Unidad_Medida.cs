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
    public partial class Unidad_Medida : DevExpress.XtraEditors.XtraForm
    {
        public Unidad_Medida()
        {
            InitializeComponent();
        }

        private void unidad_MedidaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.unidad_MedidaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSAQCobranza);

        }

        private void unidad_MedidaBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.unidad_MedidaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSAQCobranza);

        }

        private void Unidad_Medida_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSAQCobranza.Unidad_Medida' Puede moverla o quitarla según sea necesario.
            this.unidad_MedidaTableAdapter.Fill(this.dSAQCobranza.Unidad_Medida);

        }
    }
}