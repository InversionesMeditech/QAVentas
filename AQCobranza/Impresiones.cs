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
    public partial class Impresiones : DevExpress.XtraEditors.XtraForm
    {
        public Impresiones()
        {
            InitializeComponent();
        }

        private void Impresiones_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSAQCobranza.Impresiones' Puede moverla o quitarla según sea necesario.
            this.impresionesTableAdapter.Fill(this.dSAQCobranza.Impresiones);


        }

        private void impresionesBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.impresionesBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dSAQCobranza);
                MessageBox.Show("Se guardo correctamente", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al Guardar verifiqué los datos " + ex.ToString(), "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
    }
}