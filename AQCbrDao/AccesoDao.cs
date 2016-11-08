using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data;
using AQCbrEntidades;
namespace AQCbrDao
{
    public class AccesoDao
    {
        OdbcConnection cnn = new OdbcConnection();

        List<E_Cliente> lstCliente = new List<E_Cliente>();
        List<E_Conceptos> lstConceptos = new List<E_Conceptos>();
        List<E_Header_cotiza> lstHDCotiza = new List<E_Header_cotiza>();
        List<E_Orden_compra> lstOrdCompra = new List<E_Orden_compra>();
        List<E_Gremision> lstGremision = new List<E_Gremision>();
        List<E_Usuarios> lstUsuario = new List<E_Usuarios>();
        List<E_Header_Pago> lstHpago = new List<E_Header_Pago>();

        E_Cliente objCliente = new E_Cliente();
        E_Conceptos objConcepto = new E_Conceptos();
        E_Header_cotiza objHDcotiza = new E_Header_cotiza();
        E_Orden_compra objOrdCompra = new E_Orden_compra();
        E_Gremision objGremision = new E_Gremision();
        E_Usuarios objUsuario = new E_Usuarios();
        E_Header_Pago objHpago = new E_Header_Pago();

        private OdbcConnection conexion_bd()
        {
            cnn.ConnectionString = "Dsn=AQCobranzaBD;uid=AQCobranza;pwd=162916";
            cnn.Open();
            return cnn;
        }
        /*******************CLIENTE*******************/
        public bool Registrar_cliente(string _Ruc_DNI, string _Nombre, string _Apellidos, string _Direccion, string _Observaciones)
        {
            bool rpt = false;
            try
            {
                if (cnn.State == ConnectionState.Closed) { conexion_bd(); }
                OdbcCommand cmd = new OdbcCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "{ CALL ps_Cliente_insertar(?,?,?,?,?) }";
                cmd.Parameters.AddWithValue("@0", _Ruc_DNI);
                cmd.Parameters.AddWithValue("@1", _Nombre);
                cmd.Parameters.AddWithValue("@2", _Apellidos);
                cmd.Parameters.AddWithValue("@3", _Direccion);
                cmd.Parameters.AddWithValue("@4", _Observaciones);
                cmd.Connection = cnn;
                cmd.CommandTimeout = 3600;
                cmd.ExecuteReader();
                rpt = true;
                cnn.Close();
            }
            catch
            {
                rpt = false;
            }
            return rpt;
        }
        public List<E_Cliente> buscar_cliente(string _Ruc_DNI)
        {
            if (cnn.State == ConnectionState.Closed) { conexion_bd(); }
            OdbcCommand cmd = new OdbcCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "{ CALL ps_Cliente_buscar(?) }";
            cmd.Parameters.AddWithValue("@0", _Ruc_DNI);
            cmd.Connection = cnn;
            cmd.CommandTimeout = 3600;
            OdbcDataReader dr = cmd.ExecuteReader();
            lstCliente.Clear();
            while (dr.Read())
            {
                objCliente = new E_Cliente();
                objCliente.Ruc_DNI = Convert.ToString(dr.GetValue(0));
                objCliente.Nombre = Convert.ToString(dr.GetValue(1));
                objCliente.Apellidos = Convert.ToString(dr.GetValue(2));
                objCliente.Direccion = Convert.ToString(dr.GetValue(3));
                objCliente.Observaciones = Convert.ToString(dr.GetValue(4));
                lstCliente.Add(objCliente);
            }
            dr.Close();
            cnn.Close();
            return lstCliente;
        }
        public bool Actualizar_cliente(string _Ruc_DNI, string _Nombre, string _Apellidos, string _Direccion, string _Observaciones)
        {
            bool rpt = false;
            try
            {
                if (cnn.State == ConnectionState.Closed) { conexion_bd(); }
                OdbcCommand cmd = new OdbcCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "{ CALL ps_Cliente_Actualizar(?,?,?,?,?) }";
                cmd.Parameters.AddWithValue("@0", _Ruc_DNI);
                cmd.Parameters.AddWithValue("@1", _Nombre);
                cmd.Parameters.AddWithValue("@2", _Apellidos);
                cmd.Parameters.AddWithValue("@3", _Direccion);
                cmd.Parameters.AddWithValue("@4", _Observaciones);
                cmd.Connection = cnn;
                cmd.CommandTimeout = 3600;
                cmd.ExecuteReader();
                rpt = true;
                cnn.Close();
            }
            catch
            {
                rpt = false;
            }
            return rpt;
        }
        /*********************************************/
        /*******************CONCEPTOS*******************/
        public bool Registrar_Conceptos(string _concepto, string _observaciones, double _costoxunidad, string _cod_concepto)
        {
            bool rpt = false;
            try
            {
                if (cnn.State == ConnectionState.Closed) { conexion_bd(); }
                OdbcCommand cmd = new OdbcCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "{ CALL ps_Concepto_Insertar(?,?,?,?) }";
                cmd.Parameters.AddWithValue("@0", _concepto);
                cmd.Parameters.AddWithValue("@1", _observaciones);
                cmd.Parameters.AddWithValue("@2", _costoxunidad);
                cmd.Parameters.AddWithValue("@3", _cod_concepto);
                cmd.Connection = cnn;
                cmd.CommandTimeout = 3600;
                cmd.ExecuteReader();
                rpt = true;
                cnn.Close();
            }
            catch
            {
                rpt = false;
            }
            return rpt;
        }
        public List<E_Conceptos> buscar_Conceptos(string _concepto)
        {
            if (cnn.State == ConnectionState.Closed) { conexion_bd(); }
            OdbcCommand cmd = new OdbcCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "{ CALL ps_Conceptos_Buscar(?) }";
            cmd.Parameters.AddWithValue("@0", _concepto);
            cmd.Connection = cnn;
            cmd.CommandTimeout = 3600;
            OdbcDataReader dr = cmd.ExecuteReader();
            lstConceptos.Clear();
            while (dr.Read())
            {
                objConcepto = new E_Conceptos();
                objConcepto.Cod_concep = Convert.ToString(dr.GetValue(0));
                objConcepto.concepto = Convert.ToString(dr.GetValue(1));
                objConcepto.Observaciones = Convert.ToString(dr.GetValue(2));
                lstConceptos.Add(objConcepto);
            }
            dr.Close();
            cnn.Close();
            return lstConceptos;
        }
        public bool Actualizar_Conceptos(string _Cod_concepto, string _concepto, string _observaciones, double _costoxunidad,string _cod_extra)
        {
            bool rpt = false;
            try
            {
                if (cnn.State == ConnectionState.Closed) { conexion_bd(); }
                OdbcCommand cmd = new OdbcCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "{ CALL ps_Conceptos_Actualizar(?,?,?,?,?) }";
                cmd.Parameters.AddWithValue("@0", _Cod_concepto);
                cmd.Parameters.AddWithValue("@1", _concepto);
                cmd.Parameters.AddWithValue("@2", _observaciones);
                cmd.Parameters.AddWithValue("@3", _costoxunidad);
                cmd.Parameters.AddWithValue("@4", _cod_extra);
                cmd.Connection = cnn;
                cmd.CommandTimeout = 3600;
                cmd.ExecuteReader();
                rpt = true;
                cnn.Close();
            }
            catch
            {
                rpt = false;
            }
            return rpt;
        }
       public void Eliminar_concepto(string _cod_concepto)
        {
            if (cnn.State == ConnectionState.Closed) { conexion_bd(); }
            OdbcCommand cmd = new OdbcCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "{ CALL ps_Concepto_Eliminar(?) }";
            cmd.Parameters.AddWithValue("@1", _cod_concepto);
            cmd.Connection = cnn;
            cmd.CommandTimeout = 3600;
            cmd.ExecuteReader();
            cnn.Close();
       }
       public int buscar_Conceptos_exter(string _concepto_exter)
       {
           if (cnn.State == ConnectionState.Closed) { conexion_bd(); }
           OdbcCommand cmd = new OdbcCommand();
           cmd.CommandType = CommandType.StoredProcedure;
           cmd.CommandText = "{ CALL ps_Concepto_BuscarExterno(?) }";
           cmd.Parameters.AddWithValue("@0", _concepto_exter);
           cmd.Connection = cnn;
           cmd.CommandTimeout = 3600;
           OdbcDataReader dr = cmd.ExecuteReader();
           int existe = 0;
           while (dr.Read())
           {
                   existe = Convert.ToInt16(dr.GetValue(0));
           }
           dr.Close();
           cnn.Close();
           return existe;
       }
        /**************************************************/
        /*******************CONTIZACION*******************/
        public List<E_Header_cotiza> Registrar_HD_Cotiza(string _ruc_dni, DateTime _fecha, string _cod_usuario,bool _estado, int _d_validez)
        {
            if (cnn.State == ConnectionState.Closed) { conexion_bd(); }
            OdbcCommand cmd = new OdbcCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "{ CALL ps_Hcotiza_Insertar(?,?,?,?,?) }";
            cmd.Parameters.AddWithValue("@0", _ruc_dni);
            cmd.Parameters.AddWithValue("@1", _fecha);
            cmd.Parameters.AddWithValue("@2", _cod_usuario);
            cmd.Parameters.AddWithValue("@3", _estado);
            cmd.Parameters.AddWithValue("@4", _d_validez);
            cmd.Connection = cnn;
            cmd.CommandTimeout = 3600;
            OdbcDataReader dr = cmd.ExecuteReader();
            lstHDCotiza.Clear();
            while (dr.Read())
            {
                objHDcotiza = new E_Header_cotiza();
                objHDcotiza.Cod_Cot = Convert.ToString(dr.GetValue(0));
                objHDcotiza.Ruc_DNI = Convert.ToString(dr.GetValue(1));
                objHDcotiza.Fecha = Convert.ToDateTime(dr.GetValue(2));
                objHDcotiza.cod_usuario = Convert.ToString(dr.GetValue(3));
                objHDcotiza.estado = Convert.ToBoolean(dr.GetValue(4));
                objHDcotiza.d_validez = Convert.ToString(dr.GetValue(5));
                lstHDCotiza.Add(objHDcotiza);
            }
            dr.Close();
            cnn.Close();
            return lstHDCotiza;
        }
        public void registrar_DT_Cotiza(string _Cod_Cot, string _Cod_concep, double _monto, double _descuento, DateTime _Fecha, double _Unidades, int _codmaterial, int _codimpre, int _codacabado, string _medida, int _umedida)
        {
            //try
            //{
                if (cnn.State == ConnectionState.Closed) { conexion_bd(); }
                OdbcCommand cmd = new OdbcCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "{ CALL ps_Dcotiza_Insertar(?,?,?,?,?,?,?,?,?,?,?) }";
                cmd.Parameters.AddWithValue("@0", _Cod_Cot);
                cmd.Parameters.AddWithValue("@1", _Cod_concep);
                cmd.Parameters.AddWithValue("@2", _monto);
                cmd.Parameters.AddWithValue("@3", _descuento);
                cmd.Parameters.AddWithValue("@4", _Fecha);
                cmd.Parameters.AddWithValue("@5", _Unidades);
                cmd.Parameters.AddWithValue("@6", _codmaterial);
                cmd.Parameters.AddWithValue("@7", _codimpre);
                cmd.Parameters.AddWithValue("@8", _codacabado);
                cmd.Parameters.AddWithValue("@9", _medida);
                cmd.Parameters.AddWithValue("@10", _umedida);
                cmd.Connection = cnn;
                cmd.CommandTimeout = 3600;
                cmd.ExecuteReader();
                cnn.Close();
            //}
            //catch
            //{

            //}
        }
        public List<E_Header_cotiza> Buscar_HD_Cotiza(string _Cod_Cot)
        {
            if (cnn.State == ConnectionState.Closed) { conexion_bd(); }
            OdbcCommand cmd = new OdbcCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "{ CALL ps_Hcotiza_Buscar(?) }";
            cmd.Parameters.AddWithValue("@0", _Cod_Cot);
            cmd.Connection = cnn;
            cmd.CommandTimeout = 3600;
            OdbcDataReader dr = cmd.ExecuteReader();
            lstHDCotiza.Clear();
            while (dr.Read())
            {
                objHDcotiza = new E_Header_cotiza();
                objHDcotiza.Cod_Cot = Convert.ToString(dr.GetValue(0));
                objHDcotiza.Ruc_DNI = Convert.ToString(dr.GetValue(1));
                objHDcotiza.Fecha = Convert.ToDateTime(dr.GetValue(2));
                objHDcotiza.cod_usuario = Convert.ToString(dr.GetValue(3));
                objHDcotiza.estado = Convert.ToBoolean(dr.GetValue(4));
                objHDcotiza.d_validez = Convert.ToString(dr.GetValue(5));
                lstHDCotiza.Add(objHDcotiza);
            }
            dr.Close();
            cnn.Close();
            return lstHDCotiza;
        }
        public void Eliminar_DT_Cotiza(string _Cod_Cot)
        {

            try
            {
                if (cnn.State == ConnectionState.Closed) { conexion_bd(); }
                OdbcCommand cmd = new OdbcCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "{ CALL ps_Dcotiza_Eliminar(?) }";
                cmd.Parameters.AddWithValue("@0", _Cod_Cot);
                cmd.Connection = cnn;
                cmd.CommandTimeout = 3600;
                cmd.ExecuteReader();
                cnn.Close();
            }
            catch
            {

            }
        }
        public void Actualizar_HD_Cotiza(string _Cod_Cot,DateTime _fecha, bool _estado, int _d_validez)
        {

            try
            {
                if (cnn.State == ConnectionState.Closed) { conexion_bd(); }
                OdbcCommand cmd = new OdbcCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "{ CALL ps_Hcotiza_Actualizar(?,?,?,?) }";
                cmd.Parameters.AddWithValue("@0", _Cod_Cot);
                cmd.Parameters.AddWithValue("@1", _fecha);
                cmd.Parameters.AddWithValue("@2", _estado);
                cmd.Parameters.AddWithValue("@3", _d_validez);
                cmd.Connection = cnn;
                cmd.CommandTimeout = 3600;
                cmd.ExecuteReader();
                cnn.Close();
            }
            catch
            {

            }
        }
        public void Actualizar_entrega(string _det_Cot, DateTime _fecha_entrega, bool _flag_entrega)
        {
            try
            {
                if (cnn.State == ConnectionState.Closed) { conexion_bd(); }
                OdbcCommand cmd = new OdbcCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "{ CALL ps_Dcotiza_ActualizarEntrega(?,?,?) }";
                cmd.Parameters.AddWithValue("@0", _det_Cot);
                cmd.Parameters.AddWithValue("@1", _flag_entrega);
                cmd.Parameters.AddWithValue("@2", _fecha_entrega);
                cmd.Connection = cnn;
                cmd.CommandTimeout = 3600;
                cmd.ExecuteReader();
                cnn.Close();
            }
            catch
            {

            }
        }
        /******************ORDEN DE COMPRA**********/
        public List<E_Orden_compra> Registrar_OrdCompra(
            string _cod_orden_empresa,
            string _cod_cot,
            string _observaciones,
            DateTime _fecha)
        {


            try
            {
                if (cnn.State == ConnectionState.Closed) { conexion_bd(); }
                OdbcCommand cmd = new OdbcCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "{ CALL ps_OrdenCompra_Insertar(?,?,?,?) }";
                cmd.Parameters.AddWithValue("@0", _cod_orden_empresa);
                cmd.Parameters.AddWithValue("@1", _cod_cot);
                cmd.Parameters.AddWithValue("@2", _observaciones);
                cmd.Parameters.AddWithValue("@3", _fecha);
                cmd.Connection = cnn;
                cmd.CommandTimeout = 3600;
                OdbcDataReader dr = cmd.ExecuteReader();
                lstOrdCompra.Clear();
                while (dr.Read())
                {
                    objOrdCompra = new E_Orden_compra();
                    objOrdCompra.cod_orden = Convert.ToString(dr.GetValue(0));
                    objOrdCompra.cod_orden_empresa = Convert.ToString(dr.GetValue(1));
                    objOrdCompra.cod_cot = Convert.ToString(dr.GetValue(2));
                    objOrdCompra.observaciones = Convert.ToString(dr.GetValue(3));
                    objOrdCompra.fecha = Convert.ToDateTime(dr.GetValue(4));
                    lstOrdCompra.Add(objOrdCompra);
                }
                dr.Close();
                cnn.Close();
            }
            catch
            {

            }
            return lstOrdCompra;
        }
        public void Eliminar_orden(string _cod_Orden)
        {
            // try
            //{
                if (cnn.State == ConnectionState.Closed) { conexion_bd(); }
                OdbcCommand cmd = new OdbcCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM Orden_compra WHERE cod_orden = '"+_cod_Orden+"'";
                cmd.Connection = cnn;
                cmd.CommandTimeout = 3600;
                cmd.ExecuteReader();
                cnn.Close();
            //}
            //catch
            //{

            //}
            
        }
        
        /********************************************/
        /******************GUIA DE REMISION*****************/
        public List<E_Gremision> Registrar_Gremision(
            string _cod_Grm,
            DateTime _fecha,
            string _Destinatario,
            string _Domicilio,
            string _Ruc_DNI,
            string _Transportista,
            string _T_domicilio,
            string _T_RUC,
            string _T_placa,
            string _cod_orden
            )
        {
            try
            {
                if (cnn.State == ConnectionState.Closed) { conexion_bd(); }
                OdbcCommand cmd = new OdbcCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "{ CALL ps_HGremision_Insertar(?,?,?,?,?,?,?,?,?,?) }";
                cmd.Parameters.AddWithValue("@0", _cod_Grm);
                cmd.Parameters.AddWithValue("@1", _fecha);
                cmd.Parameters.AddWithValue("@2", _Destinatario);
                cmd.Parameters.AddWithValue("@3", _Domicilio);
                cmd.Parameters.AddWithValue("@4", _Ruc_DNI);
                cmd.Parameters.AddWithValue("@5", _Transportista);
                cmd.Parameters.AddWithValue("@6", _T_domicilio);
                cmd.Parameters.AddWithValue("@7", _T_RUC);
                cmd.Parameters.AddWithValue("@8", _T_placa);
                cmd.Parameters.AddWithValue("@9", _cod_orden);
                cmd.Connection = cnn;
                cmd.CommandTimeout = 3600;
                OdbcDataReader dr = cmd.ExecuteReader();
                lstGremision.Clear();
                while (dr.Read())
                {
                    objGremision = new E_Gremision();
                    objGremision.cod_Gremision = Convert.ToString(dr.GetValue(0));
                    objGremision.fecha = Convert.ToDateTime(dr.GetValue(1));
                    objGremision.Destinatario = Convert.ToString(dr.GetValue(2));
                    objGremision.Domicilio = Convert.ToString(dr.GetValue(3));
                    objGremision.Ruc_DNI = Convert.ToString(dr.GetValue(4));
                    objGremision.Transportista = Convert.ToString(dr.GetValue(5));
                    objGremision.T_domicilio = Convert.ToString(dr.GetValue(6));
                    objGremision.T_RUC = Convert.ToString(dr.GetValue(7));
                    objGremision.T_placa = Convert.ToString(dr.GetValue(8));
                    objGremision.cod_orden = Convert.ToString(dr.GetValue(9));
                    lstGremision.Add(objGremision);
                }
                dr.Close();
                cnn.Close();
            }
            catch
            {

            }
            return lstGremision;
        }
        /******************Insertar detalle Guia**********************/
        public bool registrar_DT_Guia(
            string _cod_Gremision,
            double _Unidades_entregadas,
            DateTime _fecha_entrega,
            string _Det_Cot)
        {

            try
            {
                if (cnn.State == ConnectionState.Closed) { conexion_bd(); }
                OdbcCommand cmd = new OdbcCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "{ CALL ps_DTGremision_instertar(?,?,?,?) }";
                cmd.Parameters.AddWithValue("@0", _cod_Gremision);
                cmd.Parameters.AddWithValue("@1", _Unidades_entregadas);
                cmd.Parameters.AddWithValue("@2", _fecha_entrega);
                cmd.Parameters.AddWithValue("@3", _Det_Cot);
                cmd.Connection = cnn;
                cmd.CommandTimeout = 3600;
                cmd.ExecuteReader();
                cnn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Eliminar_Guía(string _Cod_Gremision)
        {
            try
            {
                if (cnn.State == ConnectionState.Closed) { conexion_bd(); }
                OdbcCommand cmd = new OdbcCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "{ CALL ps_HGremision_Eliminar(?) }";
                cmd.Parameters.AddWithValue("@0", _Cod_Gremision);
                cmd.Connection = cnn;
                cmd.CommandTimeout = 3600;
                cmd.ExecuteReader();
                cnn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        /*********************************************************/
        public List<E_Usuarios> login(string _usuario, string _clave)
        {
            try
            {
                if (cnn.State == ConnectionState.Closed) { conexion_bd(); }
                OdbcCommand cmd = new OdbcCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT cod_usuario FROM dbo.Usuarios WHERE cod_usuario = '" + _usuario + "' AND Contraseña = '" + _clave + "'";
                cmd.Connection = cnn;
                cmd.CommandTimeout = 3600;
                OdbcDataReader dr = cmd.ExecuteReader();
                lstUsuario.Clear();
                while (dr.Read())
                {
                    objUsuario = new E_Usuarios();
                    objUsuario.cod_usuario = Convert.ToString(dr.GetValue(0));
                    lstUsuario.Add(objUsuario);
                }
                dr.Close();
                cnn.Close();

                return lstUsuario;
            }
            catch
            {
                return lstUsuario;
            }
        }
        public List<E_Usuarios> Listar_permisos(string _usuario)
        {
            try
            {
                if (cnn.State == ConnectionState.Closed) { conexion_bd(); }
                OdbcCommand cmd = new OdbcCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "{ CALL ps_ListarPermisos(?) }";
                cmd.Parameters.AddWithValue("@0", _usuario);
                cmd.Connection = cnn;
                cmd.CommandTimeout = 3600;
                OdbcDataReader dr = cmd.ExecuteReader();
                lstUsuario.Clear();
                while (dr.Read())
                {
                    objUsuario = new E_Usuarios();
                    objUsuario.cod_usuario = Convert.ToString(dr.GetValue(0));
                    objUsuario.Contraseña = Convert.ToString(dr.GetValue(1));
                    objUsuario.Nombre = Convert.ToString(dr.GetValue(2));
                    objUsuario.Apellidos = Convert.ToString(dr.GetValue(3));
                    objUsuario.Cargo = Convert.ToString(dr.GetValue(4));
                    objUsuario.Administrador = Convert.ToBoolean(dr.GetValue(5));
                    objUsuario.m_cliente = Convert.ToBoolean(dr.GetValue(6));
                    objUsuario.m_conceptos = Convert.ToBoolean(dr.GetValue(7));
                    objUsuario.m_material = Convert.ToBoolean(dr.GetValue(8));
                    objUsuario.m_impresion = Convert.ToBoolean(dr.GetValue(9));
                    objUsuario.m_undMed = Convert.ToBoolean(dr.GetValue(10));
                    objUsuario.m_usuarios = Convert.ToBoolean(dr.GetValue(11));
                    objUsuario.m_empresa = Convert.ToBoolean(dr.GetValue(12));
                    objUsuario.m_rep_caja = Convert.ToBoolean(dr.GetValue(13));
                    objUsuario.m_rep_deuda = Convert.ToBoolean(dr.GetValue(14));
                    objUsuario.m_cotiza = Convert.ToBoolean(dr.GetValue(15));
                    objUsuario.m_ord_comp = Convert.ToBoolean(dr.GetValue(16));
                    objUsuario.m_Gremision = Convert.ToBoolean(dr.GetValue(17));
                    objUsuario.m_caja = Convert.ToBoolean(dr.GetValue(18));
                    objUsuario.m_caja_chica = Convert.ToBoolean(dr.GetValue(19));
                    objUsuario.m_caja_banco = Convert.ToBoolean(dr.GetValue(20));
                    objUsuario.m_bancos = Convert.ToBoolean(dr.GetValue(21));
                    objUsuario.m_acabados = Convert.ToBoolean(dr.GetValue(22));
                    lstUsuario.Add(objUsuario);
                    dr.Close();
                    cnn.Close();


                }
            }
            catch
            {

            }
            return lstUsuario;
        }

        public List<E_Header_Pago> Registrar_Hpago(
            string _comprobante,
            DateTime _fecha,
            string _Ruc_DNI,
            double _monto,
            double _igv,
            double _monto_total,
            string _cod_usuario,
            int _Tipo_doc,
            string _cod_orden,
            int _dias_pago
            )
        {
            
                if (cnn.State == ConnectionState.Closed) { conexion_bd(); }
                OdbcCommand cmd = new OdbcCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "{ CALL ps_HPago_Insertar(?,?,?,?,?,?,?,?,?,?) }";
                cmd.Parameters.AddWithValue("@0", _comprobante);
                cmd.Parameters.AddWithValue("@1", _fecha);
                cmd.Parameters.AddWithValue("@2", _Ruc_DNI);
                cmd.Parameters.AddWithValue("@3", _monto);
                cmd.Parameters.AddWithValue("@4", _igv);
                cmd.Parameters.AddWithValue("@5", _monto_total);
                cmd.Parameters.AddWithValue("@6", _cod_usuario);
                cmd.Parameters.AddWithValue("@7", _Tipo_doc);
                cmd.Parameters.AddWithValue("@8", _cod_orden);
                cmd.Parameters.AddWithValue("@9", _dias_pago);
                cmd.Connection = cnn;
                cmd.CommandTimeout = 3600;
                OdbcDataReader dr = cmd.ExecuteReader();
                lstHpago.Clear();
                while (dr.Read())
                {
                    objHpago = new E_Header_Pago();
                    objHpago.Comprobante = Convert.ToString(dr.GetValue(0));
                    objHpago.fecha = Convert.ToDateTime(dr.GetValue(1));
                    objHpago.Ruc_DNI = Convert.ToString(dr.GetValue(2));
                    objHpago.monto = Convert.ToDouble(dr.GetValue(3));
                    objHpago.igv = Convert.ToDouble(dr.GetValue(4));
                    objHpago.monto_total = Convert.ToDouble(dr.GetValue(5));
                    objHpago.cod_usuario = Convert.ToString(dr.GetValue(6));
                    objHpago.tipo_doc = Convert.ToInt16(dr.GetValue(7));
                    objHpago.cod_orden = Convert.ToString(dr.GetValue(8));
                    objHpago.dias_venc = Convert.ToInt16(dr.GetValue(9));
                   
                }
                dr.Close();
                cnn.Close();
                       return lstHpago;
        }
        public void Registrar_Dpago(string _Cod_concep, DateTime _fecha, double _descuento, double _monto, string _comprobante, string _Det_Cot)
        {
            if (cnn.State == ConnectionState.Closed) { conexion_bd(); }
            OdbcCommand cmd = new OdbcCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "{ CALL ps_DPago_insertar(?,?,?,?,?,?) }";
            cmd.Parameters.AddWithValue("@0", _Cod_concep);
            cmd.Parameters.AddWithValue("@1", _fecha);
            cmd.Parameters.AddWithValue("@2", _descuento);
            cmd.Parameters.AddWithValue("@3", _monto);
            cmd.Parameters.AddWithValue("@4", _comprobante);
            cmd.Parameters.AddWithValue("@5", _Det_Cot);
            cmd.Connection = cnn;
            cmd.CommandTimeout = 3600;
            cmd.ExecuteReader();
            cnn.Close();
        }
    }
}
