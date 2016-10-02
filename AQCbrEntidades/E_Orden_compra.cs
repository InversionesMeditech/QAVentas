using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AQCbrEntidades
{
    public class E_Orden_compra
    {
        public string cod_orden { get; set; }
        public string cod_orden_empresa { get; set; }
        public string cod_cot { get; set; }
        public string observaciones { get; set; }
        public DateTime fecha { get; set; }
    }
}
