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
    public partial class Cotizaciones : DevExpress.XtraEditors.XtraForm
    {
        public string usuario;
        AccesoDao objdao = new AccesoDao();
        Mensajes msg = new Mensajes();

        List<E_Conceptos> lstConceptos = new List<E_Conceptos>();
        List<E_Header_cotiza> lstHDcotiza = new List<E_Header_cotiza>();
 
        public Cotizaciones()
        {
            InitializeComponent();
        }
        private void buscar_cotizacion()
        {
            try
            {
                this.ps_Cotizacion_BuscarTableAdapter.Fill(this.dSAQCobranza.ps_Cotizacion_Buscar, txtCod_cotz.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        private void Cotizaciones_Load(object sender, EventArgs e)
        {
            Panel frmPanel = new Panel();
            txtUsuario.Text = usuario;                       
            this.unidad_MedidaTableAdapter.Fill(this.dSAQCobranza.Unidad_Medida);
            this.impresionesTableAdapter.Fill(this.dSAQCobranza.Impresiones);
            this.acabadosTableAdapter.Fill(this.dSAQCobranza.Acabados);
            this.materialTableAdapter.Fill(this.dSAQCobranza.Material);
            this.header_cotizaTableAdapter.Fill(this.dSAQCobranza.Header_cotiza);
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtCod_cotz.Text == "")
            {
                lstHDcotiza = objdao.Registrar_HD_Cotiza(txtDNI.Text, txtFecha.DateTime, txtUsuario.Text, chEstado.Checked,Convert.ToInt16(txtd_validez.Text));
                txtCod_cotz.Text = Convert.ToString(lstHDcotiza[0].Cod_Cot).Trim();
                txtd_validez.Text = lstHDcotiza[0].d_validez.Trim();
                chEstado.Checked = Convert.ToBoolean(lstHDcotiza[0].estado);
                if (txtCod_cotz.Text != "")
                {
                    MessageBox.Show("Se Registro Correctamente,Ahora puede Agregar sus Conceptos...", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se Registro, verificar los datos", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Para registrar otra cotización Click en 'Nuevo' para limpiar todo los campos");
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtCod_cotz.Text == "")
            {
                MessageBox.Show("Para Agregar Conceptos, tiene que guardar la cotización o buscar una Anterior para actualizar", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                objdao.registrar_DT_Cotiza(txtCod_cotz.Text, txtCod_Concep.Text, Convert.ToDouble(txtMonto.Text), Convert.ToDouble(txtDescuento.Text), txtFecha.DateTime, Convert.ToInt32(txtUnidad.Text),Convert.ToInt32(cbmaterial.SelectedValue),Convert.ToInt32(cbAcabado.SelectedValue),Convert.ToInt32(cbColor.SelectedValue),txtdescr.Text,Convert.ToInt32(cbUmedida.SelectedValue));
                buscar_cotizacion();
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            lstHDcotiza.Clear();
            lstHDcotiza = objdao.Buscar_HD_Cotiza(txtBCotiza.Text);
            if (lstHDcotiza.Count != 0)
            {
                txtCod_cotz.Text = lstHDcotiza[0].Cod_Cot.Trim();
                txtDNI.Text = lstHDcotiza[0].Ruc_DNI.Trim(); ;
                txtUsuario.Text = lstHDcotiza[0].cod_usuario.Trim();
                txtFecha.DateTime = Convert.ToDateTime(lstHDcotiza[0].Fecha);
                chEstado.Checked = Convert.ToBoolean(lstHDcotiza[0].estado);
                buscar_cotizacion();
            }
            else
            {
                MessageBox.Show("No se encontro la Cotización", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        private void GCCotiza_Click(object sender, EventArgs e)
        {
            lstHDcotiza.Clear();
            lstHDcotiza = objdao.Buscar_HD_Cotiza(txtBCotiza.Text);
            if (lstHDcotiza.Count != 0)
            {
                txtCod_cotz.Text = lstHDcotiza[0].Cod_Cot.Trim();
                txtDNI.Text = lstHDcotiza[0].Ruc_DNI.Trim(); ;
                txtUsuario.Text = lstHDcotiza[0].cod_usuario.Trim();
                txtFecha.DateTime = Convert.ToDateTime(lstHDcotiza[0].Fecha);
                chEstado.Checked = Convert.ToBoolean(lstHDcotiza[0].estado);
                txtd_validez.Text = lstHDcotiza[0].d_validez;
                buscar_cotizacion();
            }
            else
            {
                MessageBox.Show("No se encontro la Cotización", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void txtDNI_MouseClick(object sender, MouseEventArgs e)
        {
            this.clienteTableAdapter.Fill(this.dSAQCobranza.Cliente);
        }

        private void txtBCotiza_Click(object sender, EventArgs e)
        {

        }

        private void ps_Cotizacion_BuscarGridControl_Click(object sender, EventArgs e)
        {

        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (lblcot_eliminar.Text != "")
            {
                DialogResult dialogo = MessageBox.Show("¿Desea quitar de la lista",
                      "Quitar de la lista", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogo == DialogResult.Yes)
                {
                    objdao.Eliminar_DT_Cotiza(lblcot_eliminar.Text);
                    buscar_cotizacion();
                }

            }
            else
            {
                MessageBox.Show("Seleccione un concepto de la lista", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void txtCod_Concep_Click(object sender, EventArgs e)
        {
            this.ps_Conceptos_BuscarTableAdapter.Fill(this.dSAQCobranza.ps_Conceptos_Buscar, "%");
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (txtCod_cotz.Text =="")
            {
                MessageBox.Show("Para imprimir busque una cotizacion ", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                imprCotizacion chForm = new imprCotizacion();
                chForm.cod_cotiza = txtCod_cotz.Text;
                chForm.Show();
            }
            
            
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            txtCod_cotz.Text = "";
            buscar_cotizacion();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (msg.M_Actualizar("La Cotización"))
            {
                try
                {
                    objdao.Actualizar_HD_Cotiza(txtBCotiza.Text, txtFecha.DateTime, chEstado.Checked,Convert.ToInt16(txtd_validez.Text));
                    msg.M_correcto("Se registro Correctamente");
                }
                catch
                {
                    msg.M_error("No se registro, Verifique los datos");
                }
              
            }
        }

       


    }
}