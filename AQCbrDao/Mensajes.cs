using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Windows.Forms;
namespace AQCbrDao
{
    public class Mensajes
    {
      
        public void M_error(string _mensaje)
        {
            MessageBox.Show(_mensaje, "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public  void M_correcto(string _mensaje)
        {
            MessageBox.Show(_mensaje, "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public bool M_eliminar(string _mensaje)
        {
            DialogResult dialogo = MessageBox.Show("¿Desea Eliminar " + _mensaje + "?",
                      "Eliminar Dato", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogo == DialogResult.Yes)
            {

                return true;

            }
            else
            {
                return false;
            }
        }
        public bool M_Actualizar(string _mensaje)
        {
            DialogResult dialogo = MessageBox.Show("¿Desea Actualizar " + _mensaje + "?",
                      "Actualizar Dato", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogo == DialogResult.Yes)
            {

                return true;

            }
            else
            {
                return false;
            }
        }
        public bool M_Imprimir(string _mensaje)
        {
            DialogResult dialogo = MessageBox.Show("¿Desea Imprimir Rápido " + _mensaje + "?",
                      "Impresión Rápida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogo == DialogResult.Yes)
            {

                return true;

            }
            else
            {
                return false;
            }
        }
    }
}
