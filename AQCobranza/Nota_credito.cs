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
    public partial class Nota_credito : DevExpress.XtraEditors.XtraForm
    {
        Mensajes objMsg = new Mensajes();
        public string usuario;
        public Nota_credito()
        {
            InitializeComponent();

        }

        private void Nuevo()
        {
            this.documento_pagoTableAdapter.FillByNC(this.dSAQCobranza.Documento_pago);
            this.ps_NC_BuscarTableAdapter.Fill(this.dSCaja.ps_NC_Buscar,fechaTextEdit.DateTime);
            cod_usuarioTextEdit.Text = usuario;
            fechaTextEdit.DateTime = DateTime.Now.Date;
            montoSpinEdit.Text = "0.0";
            estadoCheckEdit.Checked = true;
            comprobanteTextEdit.Text = "";
        }
        private void nota_creditoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {


        }

        private void Nota_credito_Load(object sender, EventArgs e)
        {
            fechaTextEdit.DateTime = DateTime.Now.Date;
            Nuevo();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                this.header_PagoTableAdapter.FillByNC(this.dSAQCobranza.Header_Pago, txtCompro_bus.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (comprobanteTextEdit.Text == "")
            {
                objMsg.M_error("Seleccióne un Comprobante");
            }
            else
            {
                if (id_ncLabel1.Text != "")
                {
                    objMsg.M_error("Seleccione Nuevo para registrar Otra Nota de Crédito");
                }
                else
                {
                    try
                    {
                        string fmt = "000000.##";
                        int intValue;
                        string _id_notC;
                        _id_notC = txtTpago.Text.Trim() + txtSerie.Text.Trim() + "-" + txtComprobante.Text.Trim();
                        this.nota_creditoTableAdapter.Insert(_id_notC, fechaTextEdit.DateTime, Convert.ToDouble(montoSpinEdit.Text), cod_usuarioTextEdit.Text, Convert.ToInt16(cbTpago.SelectedValue), estadoCheckEdit.Checked, comprobanteTextEdit.Text);
                        intValue = Convert.ToInt32(txtComprobante.Text) + 1;
                        this.documento_pagoTableAdapter.UpdateQuery(intValue.ToString(fmt), Convert.ToInt32(cbTpago.SelectedValue), txtSerie.Text, txtTpago.Text);
                        objMsg.M_correcto("Se registro Correctante");
                        Nuevo();

                    }
                    catch (System.Exception ex)
                    {
                        objMsg.M_error("no se registro" + ex.Message);
                    }
                }
            }
        }

        private void fechaTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.ps_NC_BuscarTableAdapter.Fill(this.dSCaja.ps_NC_Buscar, fechaTextEdit.DateTime);
            }

            catch (System.Exception ex)
            {
                objMsg.M_error(" " + ex.Message);
            }
           
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (id_ncLabel1.Text == "")
                {
                    objMsg.M_error("Seleccionar una Nota de Credito para cambiar su Estado");
                }
                else
                {
                    if (objMsg.M_Actualizar("El estado de la Nota de credito :" + id_ncLabel1.Text))
                    {
                        this.nota_creditoTableAdapter.UpdateQuery_Estado(estadoCheckEdit.Checked, id_ncLabel1.Text);
                        objMsg.M_correcto("el estado de la nota de Crédito : " + id_ncLabel1.Text);
                        Nuevo();
                    }
             
                }

            }

            catch (System.Exception ex)
            {
                objMsg.M_error("No se Actualizo " + ex.Message);
            }

        }
        }
}