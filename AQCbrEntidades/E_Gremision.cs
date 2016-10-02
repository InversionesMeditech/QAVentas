using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AQCbrEntidades
{
    public class E_Gremision
    {
        public string cod_Gremision { get; set; }
        public DateTime fecha { get; set; }
        public string Destinatario { get; set; }
        public string Domicilio { get; set; }
        public string Ruc_DNI { get; set; }
        public string Transportista { get; set; }
        public string T_domicilio { get; set; }
        public string T_RUC { get; set; }
        public string T_placa { get; set; }
        public string cod_orden { get; set; }
    }
}
