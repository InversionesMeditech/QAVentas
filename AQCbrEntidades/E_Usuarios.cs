using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AQCbrEntidades
{
    public class E_Usuarios
    {
        public string cod_usuario { get; set; }
        public string Contraseña { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Cargo { get; set; }
        public bool Administrador { get; set; }
        public bool m_cliente { get; set; }
        public bool m_conceptos { get; set; }
        public bool m_material { get; set; }
        public bool m_impresion { get; set; }
        public bool m_undMed { get; set; }
        public bool m_usuarios { get; set; }
        public bool m_empresa { get; set; }
        public bool m_rep_caja { get; set; }
        public bool m_rep_deuda { get; set; }
        public bool m_cotiza { get; set; }
        public bool m_ord_comp { get; set; }
        public bool m_Gremision { get; set; }
        public bool m_caja { get; set; }
        public bool m_caja_banco { get; set; }
        public bool m_caja_chica { get; set; }
        public bool m_bancos { get; set; }
        public bool m_acabados { get; set; }
    }
}
