using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AQCbrEntidades
{
    public class E_Det_pago
    {
        public string cod_det_pago { get; set; }
        public string cod_pago { get; set; }
        public string Cod_concep { get; set; }
        public DateTime fecha { get; set; }
        public double descuento { get; set; }
        public double monto { get; set; }
        public double igv { get; set; }
        public string comprobante { get; set; }
    }
}
