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
    public partial class bancos : DevExpress.XtraEditors.XtraForm
    {
        Mensajes msg = new Mensajes();
        public bancos()
        {
            InitializeComponent();
        }

        private void bancosBindingNavigatorSaveItem_Click_3(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.bancosBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dSAQCobranza);
                msg.M_correcto("Se registro Correctamente!!");
                this.bancosTableAdapter.Fill(this.dSAQCobranza.Bancos);
            }
            catch (Exception ex)
            {
                msg.M_error("Error al Registrar,Verificar los datos ingresados :" + ex.ToString());
            }


        }
    

        private void bancos_Load(object sender, EventArgs e)
        {
            try
            {
                this.bancosTableAdapter.Fill(this.dSAQCobranza.Bancos);
                this.cuenta_bancosTableAdapter.FillBy(this.dSAQCobranza.Cuenta_bancos, Convert.ToInt16(cod_bancoSpinEdit.Value));
            }
            catch 
            {
               
            }
            
            
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                this.cuenta_bancosTableAdapter.Insert(Convert.ToInt16(cod_bancoSpinEdit.Value), numero_cuentaTextEdit.Text.Trim(), tipo_monedaComboBox.Text.Trim());
                this.cuenta_bancosTableAdapter.FillBy(this.dSAQCobranza.Cuenta_bancos, Convert.ToInt16(cod_bancoSpinEdit.Value));
                msg.M_correcto("Se Agrego cuenta Correctamente!!");
            }
            catch (Exception ex)
            {
                msg.M_error("Error al Agregar Cuenta ,Verificar los datos ingresados :" + ex.ToString());
            }

           
        }

        private void cod_bancoSpinEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void bancosGridControl_Click(object sender, EventArgs e)
        {
            this.cuenta_bancosTableAdapter.FillBy(this.dSAQCobranza.Cuenta_bancos, Convert.ToInt16(cod_bancoSpinEdit.Value));
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                this.cuenta_bancosTableAdapter.Update(numero_cuentaTextEdit.Text.TrimEnd(), tipo_monedaComboBox.Text.Trim(),Convert.ToInt16(cod_cuentaSpinEdit.Value));
                this.cuenta_bancosTableAdapter.FillBy(this.dSAQCobranza.Cuenta_bancos, Convert.ToInt16(cod_bancoSpinEdit.Value));
                msg.M_correcto("Se Actualizo cuenta Correctamente!!");
            }
            catch (Exception ex)
            {
                msg.M_error("Error al Actualizar Cuenta ,Verificar los datos ingresados :" + ex.ToString());
            }
        }

        private void BntEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                this.cuenta_bancosTableAdapter.Delete(Convert.ToInt16(cod_cuentaSpinEdit.Value));
                this.cuenta_bancosTableAdapter.FillBy(this.dSAQCobranza.Cuenta_bancos, Convert.ToInt16(cod_bancoSpinEdit.Value));
                msg.M_correcto("Se Eliminó cuenta Correctamente!!");
            }
            catch (Exception ex)
            {
                msg.M_error("Error al Eliminar la Cuenta Es posible que ya este Utilizada en algun Proceso ,Verificar los datos ingresados :" + ex.ToString());
            }
        }

       
      

    }
}