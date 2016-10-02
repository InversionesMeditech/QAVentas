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

namespace AQCobranza
{
    public partial class Usuario : DevExpress.XtraEditors.XtraForm
    {
        public Usuario()
        {
            InitializeComponent();
        }

        private void usuariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuariosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSAQCobranza);

        }

        private void Usuario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSAQCobranza.Usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.dSAQCobranza.Usuarios);
            if (administradorCheckEdit.Checked)
            {
                GrpPermisos.Enabled = false;
            }
            else
            {
                GrpPermisos.Enabled = true;
            }

        }

        private void administradorCheckEdit_CheckedChanged(object sender, EventArgs e)
        {
            if (administradorCheckEdit.Checked)
            {
                GrpPermisos.Enabled = false;
            }
            else
            {
                GrpPermisos.Enabled = true;
            }
        }
    }
}