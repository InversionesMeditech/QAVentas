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
    public partial class Material : DevExpress.XtraEditors.XtraForm
    {
        public Material()
        {
            InitializeComponent();
        }

        private void materialBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.materialBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dSAQCobranza);
                MessageBox.Show("Se guardo correctamente", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al Guardar verifiqué los datos " + ex.ToString(), "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Material_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSAQCobranza.Material' Puede moverla o quitarla según sea necesario.
            this.materialTableAdapter.Fill(this.dSAQCobranza.Material);

        }
    }
}