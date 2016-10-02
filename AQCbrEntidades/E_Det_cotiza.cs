using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AQCbrEntidades
{
    public class E_Det_cotiza
    {
        public string Det_Cot { get; set; }
        public string Cod_Cot { get; set; }
        public string Cod_concep { get; set; }
        public double monto { get; set; }
        public double descuento { get; set; }
        public DateTime Fecha { get; set; }
    }
}
