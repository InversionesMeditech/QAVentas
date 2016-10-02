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
    public partial class OrdenCompra : DevExpress.XtraEditors.XtraForm
    {
        AccesoDao objDao = new AccesoDao();
        Mensajes Msg = new Mensajes();

        List<E_Orden_compra> lstOrdCompra = new List<E_Orden_compra>();
        public OrdenCompra()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            txtOCemp.Text = "";
            txtCotización.Text = "";
            txtObserva.Text = "";
            txtCodOC.Text = "";
        }

        private void Cargar_ord()
        {
            this.orden_de_CompraTableAdapter.Fill(this.dSAQCobranza.Orden_de_Compra);
            this.view_DT_GenOrdCompraTableAdapter.Fill(this.dSQAOrdenCompra.View_DT_GenOrdCompra, txtCotización.Text);
            this.wv_OrdCompr_Header_cotizaTableAdapter.Fill(this.dSQAOrdenCompra.wv_OrdCompr_Header_cotiza);
        }
        private void OrdenCompra_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSQAOrdenCompra.wv_OrdCompr_Header_cotiza' Puede moverla o quitarla según sea necesario.
            this.wv_OrdCompr_Header_cotizaTableAdapter.Fill(this.dSQAOrdenCompra.wv_OrdCompr_Header_cotiza);
            // TODO: esta línea de código carga datos en la tabla 'dSAQCobranza.Orden_de_Compra' Puede moverla o quitarla según sea necesario.
            this.orden_de_CompraTableAdapter.Fill(this.dSAQCobranza.Orden_de_Compra);
            txtFecha.Text = Convert.ToString(DateTime.Today);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtOCemp.Text != "" || txtCotización.Text != "")
            {
                bool _flag = false;
                double _und_envio;
                string _det_Cot;

                for (int i = 0; i < gridView6.RowCount; i++)
                {
                    _und_envio = 0;
                    _und_envio = Convert.ToDouble(gridView6.GetRowCellValue(i, "Unidades_Solicitadas"));
                    if (_und_envio > 0)
                    {
                        _flag = true;
                    }
                }
                if (_flag)
                {
                    lstOrdCompra = objDao.Registrar_OrdCompra(txtOCemp.Text, txtCotización.Text, txtObserva.Text, DateTime.Today);
                    if (lstOrdCompra.Count != 0)
                    {

                        txtCodOC.Text = lstOrdCompra[0].cod_orden;
                        txtOCemp.Text = lstOrdCompra[0].cod_orden_empresa;
                        txtCotización.Text = lstOrdCompra[0].cod_cot;
                        txtFecha.Text = Convert.ToString(lstOrdCompra[0].fecha);
                        txtObserva.Text = lstOrdCompra[0].observaciones;
                        for (int i = 0; i < gridView6.RowCount; i++)
                        {
                            _und_envio = 0;
                            _det_Cot = "";
                            _und_envio = Convert.ToDouble(gridView6.GetRowCellValue(i, "Unidades_Solicitadas"));
                            _det_Cot = Convert.ToString(gridView6.GetRowCellValue(i, "Det_Cot"));
                            if (_und_envio > 0)
                            {
                                this.det_Ord_CompraTableAdapter1.Insert(txtCodOC.Text, _und_envio, _det_Cot);
                            }
                        }                       
                        MessageBox.Show("Se registro correctamente, Puede Imprimir la Orde de compra");
                        Cargar_ord();
                    }
                    else
                    {
                        MessageBox.Show("Error al Registrar, Verifique los datos", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    Msg.M_error("Ingrese por lo menos 1 envío");
                }
            }
            else
            {
                MessageBox.Show("Debe Código de Orden de Compra de la Empresa / debe ingresar el codigo de cotización", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (txtOCemp.Text != "")
            {

            }
            else
            {
                Msg.M_error("Registre o Busque una orden de Compra para Imprimir");
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            
    
            if (Msg.M_eliminar("Desea Eliminar la Orden de Compra?"))
            {
                int ExisteGR = Convert.ToInt16(this.header_GremisionTableAdapter1.ExisteGrm(txtCodOC.Text));
                if (ExisteGR == 0)
                {
                    try
                    {
                        this.det_Ord_CompraTableAdapter1.Delete(txtCodOC.Text);
                        objDao.Eliminar_orden(txtCodOC.Text);
                        Cargar_ord();
                    }
                    catch (Exception ex)
                    {
                        Msg.M_error(ex.ToString());
                    }

                }
                else
                {
                    Msg.M_error("No se Puede Eliminar, la Orden de pago tiene una Guía de Remisión Registrada.");
                   
                }
            }
        }

        private void txtCotización_EditValueChanged(object sender, EventArgs e)
        {
            this.view_DT_GenOrdCompraTableAdapter.Fill(this.dSQAOrdenCompra.View_DT_GenOrdCompra, txtCotización.Text);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }

        private void orden_de_CompraGridControl_Click(object sender, EventArgs e)
        {

        }






    }
}