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
using AQCbrDao;
using AQCbrEntidades;
using System.IO;

namespace AQCobranza
{
    public partial class Cliente : DevExpress.XtraEditors.XtraForm
    {
        AccesoDao objdao = new AccesoDao();
        Mensajes Msg = new Mensajes();
        List<E_Cliente> lstCliente = new List<E_Cliente>();
        public Cliente()
        {
            InitializeComponent();
        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (ruc_DNITextEdit.Text != "")
            {
                try
                {
                    this.Validate();
                    this.clienteBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.dSAQCobranza);
                    ruc_DNITextEdit.Enabled = false;
                    Msg.M_correcto("Se Registro Correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al Guardar, Verifique los datos " + ex.Message, "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe Buscar o Ingresar el DNI del cliente", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
       }

        private void txtdni_MouseClick(object sender, MouseEventArgs e)
        {
            this.clienteTableAdapter.Fill(this.dSAQCobranza.Cliente);
            ruc_DNITextEdit.Enabled = false;
        }

        private void fotoPictureBox_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "jpg files (*.jpg)|*.jpg";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                         fotoPictureBox.Image = new System.Drawing.Bitmap(openFileDialog1.FileName); 
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex.Message);
                }
            }
        }

        private void GCcliente_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            ruc_DNITextEdit.Enabled = true;
        }


     
    }
}