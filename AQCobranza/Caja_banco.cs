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
    public partial class Caja_banco : DevExpress.XtraEditors.XtraForm
    {
        Mensajes msg = new Mensajes();
        public Caja_banco()
        {
            InitializeComponent();
        }

        private void Caja_banco_Load(object sender, EventArgs e)
        {

            try
            {
                this.bancosTableAdapter.Fill(this.dSAQCobranza.Bancos);
                this.cuenta_bancosTableAdapter.FillBy(this.dSAQCobranza.Cuenta_bancos, Convert.ToInt16(cbBanco.SelectedValue));
                this.depositoBanco_VWTableAdapter.Fill(this.dSAQCobranza.DepositoBanco_VW, fecha_deposito.Text);
                fecha_deposito.DateTime = DateTime.Now;
                txtFecha_trans.DateTime = DateTime.Now;
                this.cChica_Ingreso_VWTableAdapter.Fill(this.dSAQCobranza.CChica_Ingreso_VW, txtFecha_trans.Text);
            }
            catch
            {

            }
        }

        private void cbBanco_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.cuenta_bancosTableAdapter.FillBy(this.dSAQCobranza.Cuenta_bancos, Convert.ToInt16(cbBanco.SelectedValue));
            }
            catch
            {

            }
        }
        private void cbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        private void fecha_deposito_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.depositoBanco_VWTableAdapter.Fill(this.dSAQCobranza.DepositoBanco_VW, fecha_deposito.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void depositoBanco_VWGridControl_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                dep_BancosTableAdapter1.Insert(Convert.ToInt16(cbCuenta.SelectedValue), fecha_deposito.Text, txtNumOp.Text, Convert.ToDouble(txtMonto.Text), cbCliente.Text,ppc_comprob.Text);
                this.depositoBanco_VWTableAdapter.Fill(this.dSAQCobranza.DepositoBanco_VW, fecha_deposito.Text);
                msg.M_correcto("Se registro Correctamente");
            }
            catch (System.Exception ex)
            {
                msg.M_error("No se registro, Verificar los datos:" + ex);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (msg.M_eliminar("El depósito"))
            {
                try
                {
                    dep_BancosTableAdapter1.Delete(Convert.ToInt16(lblidDeposito.Text));
                    this.depositoBanco_VWTableAdapter.Fill(this.dSAQCobranza.DepositoBanco_VW, fecha_deposito.Text);
                    msg.M_correcto("Se Elimino Correctamente");
                }
                catch (System.Exception ex)
                {
                    msg.M_error("No se Elimino, Verificar los datos:" + ex);
                }
            }
        }

        private void txtFecha_trans_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.cChica_IngresoTableAdapter.FillBy(this.dSAQCobranza.CChica_Ingreso, txtFecha_trans.Text);
            }
            catch
            {

            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (txtM_ingreso.Text == "" || lblMonto.Text =="" )
            {
                msg.M_eliminar("Ingrese el Monto del Ingreso a la Caja Chica o Verifique si selecciono una cuenta con Monto");
            }
            else
            {

                if (Convert.ToDouble(txtM_ingreso.Text) <= Convert.ToDouble(lblMonto.Text))
                {
                    try
                    {
                        this.cChica_IngresoTableAdapter.Insert(txtFecha_trans.Text, "Banco", Convert.ToDouble(txtM_ingreso.Text), Convert.ToInt16(lblidDeposito.Text));
                        this.cChica_Ingreso_VWTableAdapter.Fill(this.dSAQCobranza.CChica_Ingreso_VW, txtFecha_trans.Text);
                        msg.M_correcto("Se Registro Correctamente");
                    }
                    catch (System.Exception ex)
                    {
                        msg.M_error("No se Registro, Verificar los datos:" + ex);
                    }
                }
                else
                {
                    msg.M_error("El monto supera al del deposito, verificar");
                }

            }
        }

        private void BntEliminar_Click(object sender, EventArgs e)
        {
            if (msg.M_eliminar("El Ingreso"))
            {
                try
                {
                    this.cChica_IngresoTableAdapter.Delete(Convert.ToInt16(lblidIngreso.Text));
                    this.cChica_Ingreso_VWTableAdapter.Fill(this.dSAQCobranza.CChica_Ingreso_VW, txtFecha_trans.Text);
                    msg.M_correcto("Se Elimino Correctamente");
                }
                catch (System.Exception ex)
                {
                    msg.M_error("No se Elimino, Verificar los datos:" + ex);
                }
            }
        }

          private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                this.header_PagoTableAdapter.Fill(this.dSAQCobranza.Header_Pago, txtCompro_bus.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

    }
}