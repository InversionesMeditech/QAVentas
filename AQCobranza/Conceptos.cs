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
using AQCbrEntidades;

namespace AQCobranza
{
    public partial class Conceptos : DevExpress.XtraEditors.XtraForm
    {
        AccesoDao objdao = new AccesoDao();
        Mensajes msg = new Mensajes();

        List<E_Conceptos> lstConceptos = new List<E_Conceptos>();
        bool rtp = false;
        public Conceptos()
        {
            InitializeComponent();
        }
        /*FUNCIONES Y METODOS*/
        private void Cargar_Conceptos(string _concepto)
        {
            try
            {
                this.ps_Conceptos_BuscarTableAdapter.Fill(this.dSAQCobranza.ps_Conceptos_Buscar, _concepto);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        private void Limpiar()
        {
            txtConcepto.Text = "";
            txtObserva.Text = "";
            txtCodigo.Text = "";
            txtCxUnidad.Text = "0";
            txtcodExtra.Text = "";
        }
        /*****/
        private void Conceptos_Load(object sender, EventArgs e)
        {
            Cargar_Conceptos("%");
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            int existe;
            existe = objdao.buscar_Conceptos_exter(txtcodExtra.Text.Trim());
            if (existe == 0 || txtcodExtra.Text == "")
            {

                if (txtConcepto.Text != "")
                {
                    rtp = objdao.Registrar_Conceptos(txtConcepto.Text, txtObserva.Text, Convert.ToDouble(txtCxUnidad.Text), txtcodExtra.Text);
                    if (rtp)
                    {
                        msg.M_correcto("Se Registro Correctamente");
                        Limpiar();
                    }
                    else
                    {
                        msg.M_error("Error al Registrar, Verifique los datos");
                    }
                }
                else
                {
                    msg.M_error("Debe Ingresar el Concepto");
                }
                Cargar_Conceptos("%");
            }
            else
            {
                msg.M_error("El codigo Externo ya esta siendo utilizado, si decea Actualizar hacer click en el botón (ACTUALIZAR)");
            }
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtConcepto.Text != "" || txtCodigo.Text != "")
            {
                rtp = objdao.Actualizar_Conceptos(txtCodigo.Text, txtConcepto.Text, txtObserva.Text, Convert.ToDouble(txtCxUnidad.Text), txtcodExtra.Text);
                if (rtp)
                {
                    MessageBox.Show("Se Actualizo Correctamente", "Mesaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Error al Actualizar, Verifique los datos", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe Ingresar el Concepto o Buscar un Concepto antes de Actualizar(verificar que el código este lleno)", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Cargar_Conceptos(txtbus_concep.Text + "%");
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtbus_concep.Text == "")
            {
                Cargar_Conceptos("%");
            }
            else
            {
                Cargar_Conceptos(txtbus_concep.Text + "%");
            }

        }
        private void txtbus_concep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtbus_concep.Text == "")
            {
                Cargar_Conceptos("%");
            }
            else
            {
                Cargar_Conceptos("%" + txtbus_concep.Text + "%");
            }
        }
        private void gwConceptos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Enabled = false;
            txtCodigo.Text = Convert.ToString(gwConceptos.CurrentRow.Cells[0].Value).Trim();
            txtcodExtra.Text = Convert.ToString(gwConceptos.CurrentRow.Cells[1].Value).Trim();
            txtConcepto.Text = Convert.ToString(gwConceptos.CurrentRow.Cells[2].Value).Trim();
            txtObserva.Text = Convert.ToString(gwConceptos.CurrentRow.Cells[3].Value).Trim();
            txtCxUnidad.Text = Convert.ToString(gwConceptos.CurrentRow.Cells[4].Value).Trim();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void gwConceptos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodigo.Text == "")
                {
                    msg.M_error("Selecciona un Concepto para Eliminar");
                }
                else
                {
                    if (msg.M_eliminar("el Concepto \n(" + txtConcepto.Text+" )"))
                    {
                        objdao.Eliminar_concepto(txtCodigo.Text);
                        Cargar_Conceptos("%");
                        msg.M_correcto("Se Eliminó Correctamente");
                    }
                }

            }
            catch (Exception ex)
            {
                msg.M_error("Error al Eliminar, Verifique que el Concepto No está siendo utilizado ");
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (this.Controls.Find("Conceptos_egreso", true).Count() == 0)
            {
                Conceptos_egreso chForm = new Conceptos_egreso();
                chForm.Show();
            }
        }








    }
}