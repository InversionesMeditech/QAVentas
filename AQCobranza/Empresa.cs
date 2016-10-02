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
using System.IO;
using AQCbrDao;
namespace AQCobranza
{
    public partial class Empresa : DevExpress.XtraEditors.XtraForm
    {
        Mensajes objMensajes = new Mensajes();
        public Empresa()
        {
            InitializeComponent();
        }
        public void cargarimagen(PictureBox _PBimagen)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Imagenes (*.png,*.jpg)|*.png;*.jpg";
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
                            _PBimagen.Image = new System.Drawing.Bitmap(openFileDialog1.FileName);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex.Message);
                }
            }
        }
        private void eRP_empresaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
                try
                {
                    this.Validate();
                    this.eRP_empresaBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.dSAQCobranza);
                    objMensajes.M_correcto("Se registró Correctamente");
                }
                catch
                {
                    objMensajes.M_error("No se registro Correctamente");
                } 
        }

        private void Empresa_Load(object sender, EventArgs e)
        {
         this.eRP_empresaTableAdapter.Fill(this.dSAQCobranza.ERP_empresa);
            if (ruc_empresaTextEdit.Text !="")
            {
                bindingNavigatorAddNewItem.Enabled = false;
            }
            else
            {
                bindingNavigatorAddNewItem.Enabled = true;
            }
        }

        private void e_logoPictureBox_Click(object sender, EventArgs e)
        {
            cargarimagen(e_logoPictureBox);
        }

        private void g_fotoPictureBox_Click(object sender, EventArgs e)
        {
            cargarimagen(g_fotoPictureBox);
        }

        private void g_firmaPictureBox_Click(object sender, EventArgs e)
        {
            cargarimagen(g_firmaPictureBox);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
           
        }

        private void g_EncabezadoPictureBox_Click(object sender, EventArgs e)
        {
            cargarimagen(g_EncabezadoPictureBox);
        }

        private void g_piepagPictureBox_Click(object sender, EventArgs e)
        {
            cargarimagen(g_piepagPictureBox);
        }

        private void g_fondoPictureBox_Click(object sender, EventArgs e)
        {
            //cargarimagen(g_fondoPictureBox);
        }
    }
}