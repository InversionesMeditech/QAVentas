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
    public partial class GRemision : DevExpress.XtraEditors.XtraForm
    {
        List<E_Gremision> lstGremision = new List<E_Gremision>();

        AccesoDao objDao = new AccesoDao();
        Mensajes objMsg = new Mensajes();
        public GRemision()
        {
            InitializeComponent();
        }
        private void listar_Gen_Guia()
        {
            this.ps_Generar_DTGremisionTableAdapter.Fill(this.dSAQCobranza.ps_Generar_DTGremision, txtcod_orden.Text);
            this.header_GremisionTableAdapter.Fill(this.dSAQCobranza.Header_Gremision, txtcod_orden.Text);
            this.documento_pagoTableAdapter.FillByGRM(this.dSAQCobranza.Documento_pago);
        }
        private void bloquear()
        {
            groupControl4.Enabled = false;
            TxtFecha.Enabled = false;
            txtDestinatario.Enabled = false;
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            int cont = 0;
            for (int i = 0; i < gridView2.RowCount; i++)
            {
                if (Convert.ToBoolean(gridView2.GetRowCellValue(i, "flag_entregado")))
                {
                    cont++;
                }

            }

            if (cont == 0)
            {
                objMsg.M_error("No tiene seleccionado ninguna Entrega Verificar antes de Registrar una Guía");

            }
            else
            {
                if (TxtFecha.Text == "")
                {
                    objMsg.M_error("No tiene Ingresado una Fecha de Entrega");
                }
                else
                {
                    string fmt = "000000.##";
                    int intValue;
                    string _Cod_GRM = abreTextEdit.Text.Trim() + serieTextEdit.Text.Trim() + "-" + txtCod_Gremision.Text.Trim();

                    lstGremision = objDao.Registrar_Gremision(_Cod_GRM, TxtFecha.DateTime, txtDestinatario.Text, TxtDomicilio.Text, txtCod_cliente.Text, txtTransportista.Text, txtTDomicilio.Text, TXTTRuc.Text, txtTPlaca.Text, txtcod_orden.Text);
                    intValue = Convert.ToInt32(txtCod_Gremision.Text.Trim()) + 1;
                    this.documento_pagoTableAdapter.UpdateQuery(intValue.ToString(fmt), Convert.ToInt32(lblid_compro.Text), serieTextEdit.Text, abreTextEdit.Text);
                    if (lstGremision.Count != 0)
                    {
                        txtCod_Gremision.Text = lstGremision[0].cod_Gremision;
                        TxtFecha.DateTime = lstGremision[0].fecha;
                        txtDestinatario.Text = lstGremision[0].Destinatario;
                        TxtDomicilio.Text = lstGremision[0].Domicilio;
                        txtCod_cliente.Text = lstGremision[0].Ruc_DNI;
                        txtTransportista.Text = lstGremision[0].Transportista;
                        txtTDomicilio.Text = lstGremision[0].T_domicilio;
                        TXTTRuc.Text = lstGremision[0].T_RUC;
                        txtTPlaca.Text = lstGremision[0].T_placa;
                        txtcod_orden.Text = lstGremision[0].cod_orden;
                        bool _entregado;
                        string _cod_det;
                        double _unidadesxentregar;
                        for (int i = 0; i < gridView2.RowCount; i++)
                        {
                            _entregado = Convert.ToBoolean(gridView2.GetRowCellValue(i, "flag_entregado"));
                            if (_entregado)
                            {
                                _cod_det = Convert.ToString(gridView2.GetRowCellValue(i, "Det_Cot"));
                                _unidadesxentregar = Convert.ToDouble(gridView2.GetRowCellValue(i, "UnidadesXentregar"));
                                objDao.registrar_DT_Guia(_Cod_GRM, _unidadesxentregar, TxtFecha.DateTime, _cod_det);
                                objDao.Actualizar_entrega(_cod_det, TxtFecha.DateTime, _entregado);
                            }

                        }

                        listar_Gen_Guia();
                        objMsg.M_correcto("Se Registro Correctamente");

                    }
                    else
                    {
                        listar_Gen_Guia();
                        objMsg.M_error("No se registro Correctamente, Verifique el Correlativo si no esta Utilizado");

                    }
                }
            }
        }
        private void GRemision_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSAQCobranza.Documento_pago' Puede moverla o quitarla según sea necesario.
            this.documento_pagoTableAdapter.FillByGRM(this.dSAQCobranza.Documento_pago);

        }
        private void orden_de_CompraGridControl_Click(object sender, EventArgs e)
        {
            try
            {
                listar_Gen_Guia();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        private void txtcod_orden_Click(object sender, EventArgs e)
        {
            this.orden_de_CompraTableAdapter.Fill(this.dSAQCobranza.Orden_de_Compra);
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txtCod_Gremision.Text = Convert.ToString(comboBox1.SelectedValue);
        }
        private void btnActua_Guia_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(comboBox1.Text) == "")
            {
                objMsg.M_error("Seleccionar una Guía de Remisión para eliminar, Verificar");
            }
            else
            {

                if (objMsg.M_eliminar("¿Desea Eliminar la Guía?"))
                {
                    int ExistePago = Convert.ToInt16(this.header_PagoTableAdapter1.ExistePago(txtCod_Gremision.Text));
                    if (ExistePago == 0)
                    {
                        if (objDao.Eliminar_Guía(Convert.ToString(comboBox1.SelectedValue)))
                        {
                            objMsg.M_correcto("La Guía se eliminó correctamente");
                            listar_Gen_Guia();
                        }
                        else
                        {
                            objMsg.M_error("Error al Eliminar Verificar");
                            listar_Gen_Guia();
                        }
                    }
                    else
                    {
                        objMsg.M_error("La Guía tiene Comprobantes Activos, no se puede Eliminar.");
                    }

                }

            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(comboBox1.Text) == "")
            {
                objMsg.M_error("Elija o Registre una Guía de Remisón");
            }
            else
            {
                ImprGremision chForm = new ImprGremision();
                chForm.cod_Grem = Convert.ToString(comboBox1.SelectedValue);
                chForm.Show();
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }
    }
}