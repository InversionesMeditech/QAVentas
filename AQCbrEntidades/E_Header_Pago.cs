using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AQCbrEntidades
{
    public class E_Header_Pago
    {
        public string Comprobante { get; set; }
        public DateTime fecha { get; set; }
        public string Ruc_DNI { get; set; }
        public double monto { get; set; }
        public double igv { get; set; }
        public double monto_total { get; set; }
        public string cod_usuario { get; set; }
        public int tipo_doc { get; set; }
        public string cod_orden{ get; set; }
    }
}
