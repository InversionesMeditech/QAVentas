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
using AQCbrDao;

namespace AQCobranza
{
    public partial class CuadreCaja : DevExpress.XtraEditors.XtraForm
    {
        Mensajes msg = new Mensajes();
        public CuadreCaja()
        {
            InitializeComponent();
        }
        private void listar()
        {
             try
            {
                this.header_PagoTableAdapter.FillBy(this.dSAQCobranza.Header_Pago, txtFecha.Text);
                lbltotal.Text = "S/"+Convert.ToString(this.header_PagoTableAdapter.Sum_total(txtFecha.Text));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void header_PagoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.header_PagoBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dSAQCobranza);
                msg.M_correcto("Se Actualizó Correctamente");
                listar();
            }
            catch
            {
                msg.M_error("Error al Actualizar, Verificar los datos ingresados");

            }
           

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
           

        }

        private void CuadreCaja_Load(object sender, EventArgs e)
        {
            listar();
        }

        private void txtFecha_EditValueChanged(object sender, EventArgs e)
        {
            listar();
        }
    }
}