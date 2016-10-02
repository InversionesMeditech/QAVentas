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
    public partial class CajaChica : DevExpress.XtraEditors.XtraForm
    {
        Mensajes msg = new Mensajes();
        public CajaChica()
        {
            InitializeComponent();
        }
        private void cargar()
        {
            try
            {
                this.cChica_IngresoTableAdapter.FillBy(this.dSAQCobranza.CChica_Ingreso, txtfecha.Text);
                this.diferencia_Egresos_VWTableAdapter.Fill(this.dSAQCobranza.Diferencia_Egresos_VW, txtfecha.Text, txtfecha.Text);
                this.cChica_EgresoTableAdapter.Fill(this.dSAQCobranza.CChica_Egreso, txtfecha.Text);
                progressBarControl1.Properties.Maximum = Convert.ToInt16(lblingreso.Text);
                //progressBarControl1.Properties.Minimum = 0;
                progressBarControl1.Position = Convert.ToInt16(lblegreso.Text);
            }
            catch (System.Exception ex)
            {

            }
        }


        private void CajaChica_Load(object sender, EventArgs e)
        {
            cargar();
            txtfecha.DateTime = DateTime.Now;
        }

        private void txtfecha_EditValueChanged(object sender, EventArgs e)
        {
            cargar();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(lbldiferencia.Text) >= Convert.ToDouble(txtmonto.Text))
                {
                    this.cChica_EgresoTableAdapter.Insert(txtfecha.Text, txtMotivo.Text, txtDescr.Text, Convert.ToDouble(txtmonto.Text));
                    cargar();
                    msg.M_correcto("Se Registro Correctamente");
                }
                else
                {
                    msg.M_correcto("No tiene saldo suficiente para el Egreso");
                }

            }
            catch (System.Exception ex)
            {
                msg.M_error("No se Registro verificar los datos : " + ex);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(msg.M_eliminar("Desea Eliminar un Egreso?"))
            {
                try
                {
                    this.cChica_EgresoTableAdapter.Delete(Convert.ToInt16(lblidegreso.Text));
                    cargar();
                    msg.M_correcto("Se Eliminó el Egreso, Correctamente");
                }
                catch (System.Exception ex)
                {
                    msg.M_error("No se pudo eliminar el Egreso, verificar los datos : " + ex);
                }
            }
            
        }

        private void BntEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                this.cChica_IngresoTableAdapter.Delete(Convert.ToInt16(lblidIngreso.Text));
                cargar();
                msg.M_correcto("Se Eliminó el Ingreso, Correctamente");
            }
            catch (System.Exception ex)
            {
                msg.M_error("No se pudo eliminar el Ingreso, verificar los datos : " + ex);
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            try
            {
                this.cChica_IngresoTableAdapter.Insert(txtfecha.Text, "Manual", Convert.ToDouble(txtMonto_ingr.Text), 0);
                cargar();
                msg.M_correcto("Se Registro Correctamente");
            }
            catch (System.Exception ex)
            {
                msg.M_error("No se Registro verificar los datos : " + ex);
            }
        }

    }
}