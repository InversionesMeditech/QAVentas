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
    public partial class Caja : DevExpress.XtraEditors.XtraForm
    {
        AccesoDao objDao = new AccesoDao();
        Mensajes objMsg = new Mensajes();

        List<E_Header_Pago> lstHpago = new List<E_Header_Pago>();

        public string usuario;
        public Caja()
        {
            InitializeComponent();
        }

        private void Caja_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSAQCobranza.View_Guia_remision_busqueda' Puede moverla o quitarla según sea necesario.
            this.view_Guia_remision_busquedaTableAdapter.Fill(this.dSAQCobranza.View_Guia_remision_busqueda);      
            this.documento_pagoTableAdapter.Fill(this.dSAQCobranza.Documento_pago);
            txtcod_usuario.Text = usuario;
            //txtTpago.Text = "FAC";
        }

        private void cbTpago_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }



        private void CGordenPago_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.ps_GeneraDTpagoTableAdapter.Fill(this.dSAQCobranza.ps_GeneraDTpago, txtcod_orden.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            bool _entregado;
            double total = 0.0, _unidadesxentregar;

            for (int i = 0; i < gridView2.RowCount; i++)
            {
                _entregado = Convert.ToBoolean(gridView2.GetRowCellValue(i, "flg_entregado"));
                _unidadesxentregar = Convert.ToDouble(gridView2.GetRowCellValue(i, "Sub_total"));

                if (_entregado)
                {
                    total = total + _unidadesxentregar;
                }

            }
            txtmonto_total.Text = Convert.ToString(total);
            if (txtTpago.Text == "FAC")
            {
                txtigv.Text = Convert.ToString(Convert.ToDouble(txtmonto_total.Text) * 0.18);
            }
            else
            {
                txtigv.Text = Convert.ToString(0.00);
            }

            txtmonto.Text = Convert.ToString(Convert.ToDouble(txtmonto_total.Text) - Convert.ToDouble(txtigv.Text));

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtComprobante.Text != "")
            {
                if(txtFecha.Text != "")
                {
                    if(txtmonto_total.Text != "")
                    {
                        try
                        {
                            string fmt = "000000.##";
                            int intValue;
                            string _Cod_concep, _comprobante, _Det_Cot;
                            DateTime _fecha;
                            double _descuento ,  _monto;
                            _comprobante = txtTpago.Text.Trim()+txtSerie.Text.Trim()+"-"+txtComprobante.Text.Trim();
                            lstHpago = objDao.Registrar_Hpago(_comprobante, txtFecha.DateTime, txtRuc_DNI.Text, Convert.ToDouble(txtmonto.Text), Convert.ToDouble(txtigv.Text),
                                                 Convert.ToDouble(txtmonto_total.Text), txtcod_usuario.Text, Convert.ToInt16(cbTpago.SelectedValue), txtcod_orden.Text,Convert.ToInt16(txtDias_venc.Text));
                           
                            for (int i = 0; i < gridView2.RowCount; i++)
                            {
                                _fecha = txtFecha.DateTime;
                                _monto = Convert.ToDouble(gridView2.GetRowCellValue(i, "Sub_total"));
                                _descuento = Convert.ToDouble(gridView2.GetRowCellValue(i, "descuento"));
                                _Cod_concep = Convert.ToString(gridView2.GetRowCellValue(i, "Cod_concep"));
                                _Det_Cot = Convert.ToString(gridView2.GetRowCellValue(i, "Det_Cot"));
                                objDao.Registrar_Dpago(_Cod_concep, _fecha, _descuento, _monto, _comprobante, _Det_Cot);
                            }
               

                            intValue = Convert.ToInt32(txtComprobante.Text)+1;
                            this.documento_pagoTableAdapter.UpdateQuery(intValue.ToString(fmt), Convert.ToInt32(cbTpago.SelectedValue), txtSerie.Text, txtTpago.Text);
                            ps_GeneraDTpagoGridControl.Enabled = false;
                            btnRegistrar.Enabled = false;
                            objMsg.M_correcto("Se registro Correctante,Puede Imprimir");
                            btnImprimir.Enabled = true;
                            simpleButton3.Enabled = true;
                        }
                        catch
                        {
                            objMsg.M_error("Problemas con el registro,Verificar si el Comprobante ya fue utilizado");
                        }                               
                    }
                    else
                    {
                        objMsg.M_error("Es necesario Calcular el monto, antes de Guardar e Imprimir");
                        btnCalcular.Focus();
                    }                   
                }
                else
                {
                    objMsg.M_error("Es Obligatorio La fecha de Pago");
                    txtFecha.Focus();
                }
            }
            else
            {
                objMsg.M_error("Es Obligatorio el Comprobante");
                txtComprobante.Focus();
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            ps_GeneraDTpagoGridControl.Enabled = true;
            btnRegistrar.Enabled = true;
            txtcod_orden.Text = "";
            //txtcod_usuario.Text = "";
            //txtComprobante.Text = "";
            txtFecha.Text = "";
            txtigv.Text = "";
            txtmonto.Text = "";
            txtmonto_total.Text = "";
            txtRuc_DNI.Text = "";
            btnImprimir.Enabled = false;
            simpleButton3.Enabled = false;
            this.view_Guia_remision_busquedaTableAdapter.Fill(this.dSAQCobranza.View_Guia_remision_busqueda);    
            this.documento_pagoTableAdapter.Fill(this.dSAQCobranza.Documento_pago);
        }

        private void txtcod_orden_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.ps_GeneraDTpagoTableAdapter.Fill(this.dSAQCobranza.ps_GeneraDTpago, txtcod_orden.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
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

        private void ps_GeneraDTpagoGridControl_Click(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            string _comprobante;
           
            if (txtComprobante.Text == "")
            {
                objMsg.M_error("Registre un Comprobante para Imprimir");
            }
            else
            {
                _comprobante = txtTpago.Text.Trim() + txtSerie.Text.Trim() + "-" + txtComprobante.Text.Trim();

                impri_factura chForm = new impri_factura();
                chForm._comprobante = _comprobante;
                chForm.Show();
            }
        }

        private void btnReimprimir_Click(object sender, EventArgs e)
        {
            if (lblcompro.Text == "")
            {
                objMsg.M_error("Registre un Comprobante para Imprimir");
            }
            else
            {
                impri_factura chForm = new impri_factura();
                chForm._comprobante = lblcompro.Text;
                chForm.Show();
            }
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            if (this.Controls.Find("CuadreCaja", true).Count() == 0)
            {
                CuadreCaja chForm = new CuadreCaja();
    
                chForm.Show();
            }

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if(objMsg.M_Imprimir(""))
            {
                this.view_ComprobanteTableAdapter.Fill(this.dSAQCobranza.View_Comprobante, lblcompro.Text);
                Factura Factura1 = new Factura();
                Factura1.SetDataSource(this.dSAQCobranza);
                Factura1.PrintToPrinter(1, false, 0, 1);
            }

           
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (objMsg.M_Imprimir(""))
            {
                string _comprobante;

                if (txtComprobante.Text == "")
                {
                    objMsg.M_error("Registre un Comprobante para Imprimir");
                }
                else
                {
                    _comprobante = txtTpago.Text.Trim() + txtSerie.Text.Trim() + "-" + txtComprobante.Text.Trim();

                    this.view_ComprobanteTableAdapter.Fill(this.dSAQCobranza.View_Comprobante, _comprobante);
                    Factura Factura1 = new Factura();
                    Factura1.SetDataSource(this.dSAQCobranza);
                    Factura1.PrintToPrinter(1, false, 0, 1);
                }
               
            }
        }

        private void txtcod_usuario_EditValueChanged(object sender, EventArgs e)
        {

        }

   


    }
}