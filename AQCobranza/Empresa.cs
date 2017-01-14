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
//using System.Windows.Media;
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
         Color color1 = System.Drawing.ColorTranslator.FromHtml(g_Font_enca_colorTextEdit.Text);
         Color color2 = System.Drawing.ColorTranslator.FromHtml(g_Font_piepag_colorTextEdit.Text);
         button1.BackColor = color1;
         button2.BackColor = color2;
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                button1.BackColor = colorDialog1.Color;
                g_Font_enca_colorTextEdit.Text = String.Format("#{0:X2}{1:X2}{2:X2}", colorDialog1.Color.R, colorDialog1.Color.G, colorDialog1.Color.B);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                button2.BackColor = colorDialog1.Color;
                g_Font_piepag_colorTextEdit.Text = String.Format("#{0:X2}{1:X2}{2:X2}", colorDialog1.Color.R, colorDialog1.Color.G, colorDialog1.Color.B);
            }
        }

        private void groupControl5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}