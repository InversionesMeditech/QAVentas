using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AQCbrEntidades
{
    public class E_Header_cotiza
    {
        public string Cod_Cot { get; set; }
        public string Ruc_DNI { get; set; }
        public DateTime Fecha { get; set; }
        public string cod_usuario { get; set; }
        public bool estado { get; set; }
        public string d_validez { get; set; }
    }
}
