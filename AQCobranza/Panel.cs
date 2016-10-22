using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AQCbrDao;
using AQCbrEntidades;

namespace AQCobranza
{
    public partial class Panel : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public string Usuario;
        AccesoDao objDao = new AccesoDao();

        List<E_Usuarios> lstusuario = new List<E_Usuarios>();
        public Panel()
        {
            InitializeComponent();
        }
        public void PermisosUsuario()
        {
            lstusuario = objDao.Listar_permisos(Usuario);
            if (!lstusuario[0].Administrador)
            {
                if (!lstusuario[0].m_cliente)
                {
                    barCliente.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                }
                if (!lstusuario[0].m_conceptos)
                {
                    barConceptos.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                }
                if (!lstusuario[0].m_material)
                {
                    barMaterial.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                }
                if (!lstusuario[0].m_impresion)
                {
                    barImpresion.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                }
                if (!lstusuario[0].m_undMed)
                {
                    barUmedida.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                }
                if (!lstusuario[0].m_usuarios)
                {
                    barUsuarios.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                }
                if (!lstusuario[0].m_empresa)
                {
                    barEmpresa.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                }
                if (!lstusuario[0].m_rep_caja)
                {
                    barRcaja.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                }
                if (!lstusuario[0].m_rep_deuda)
                {
                    barRdeuda.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                }
                if (!lstusuario[0].m_cotiza)
                {
                    barCotizaciones.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                }
                if (!lstusuario[0].m_ord_comp)
                {
                    barOrdCompra.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                }
                if (!lstusuario[0].m_Gremision)
                {
                    barGremision.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                }
                if (!lstusuario[0].m_caja)
                {
                    barCaja.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                }
                if (!lstusuario[0].m_caja_chica)
                {
                    barCajaChica.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                }
                if (!lstusuario[0].m_caja_banco)
                {
                    barCaja_banco.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    barCompro.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                }
                if (!lstusuario[0].m_bancos)
                {
                    barBancos.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                }
                if (!lstusuario[0].m_acabados)
                {
                    barAcabados.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                }


            }
        }
   
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.Controls.Find("Cliente", true).Count() == 0)
            {

                Cliente chForm = new Cliente();
                chForm.MdiParent = this;
                chForm.Show();
            }

            
        }

        private void Panel_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult dialogo = MessageBox.Show("¿Desea cerrar el programa?",
                       "Cerrar el programa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogo == DialogResult.No)
            {
               
               e.Cancel = true;
               
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.Controls.Find("Cotizaciones", true).Count() == 0)
            {
                Cotizaciones chForm = new Cotizaciones();
                chForm.usuario = txtUsuario.Text;
                chForm.MdiParent = this;
                chForm.Show();
            }

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.Controls.Find("OrdenCompra", true).Count() == 0)
            {
                OrdenCompra chForm = new OrdenCompra();
                chForm.MdiParent = this;
                chForm.Show();
            }

        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.Controls.Find("Caja", true).Count() == 0)
            {
                Caja chForm = new Caja();
                chForm.usuario = txtUsuario.Text;
                chForm.MdiParent = this;
                chForm.Show();
            }
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.Controls.Find("Conceptos", true).Count() == 0)
            {
                Conceptos chForm = new Conceptos();
                chForm.MdiParent = this;
                chForm.Show();
            }

        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.Controls.Find("Usuario", true).Count() == 0)
            {
                Usuario chForm = new Usuario();
                chForm.MdiParent = this;
                chForm.Show();
            }

        }


        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.Controls.Find("Acabados", true).Count() == 0)
            {
                Acabados chForm = new Acabados();
                chForm.MdiParent = this;
                chForm.Show();
            }

        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.Controls.Find("Material", true).Count() == 0)
            {
                Material chForm = new Material();
                chForm.MdiParent = this;
                chForm.Show();
            }

        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.Controls.Find("Impresiones", true).Count() == 0)
            {
                Impresiones chForm = new Impresiones();
                chForm.MdiParent = this;
                chForm.Show();
            }

        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.Controls.Find("Unidad_Medida", true).Count() == 0)
            {
                Unidad_Medida chForm = new Unidad_Medida();
                chForm.MdiParent = this;
                chForm.Show();
            }

        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void Panel_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSAQCobranza.ERP_empresa' Puede moverla o quitarla según sea necesario.
            this.eRP_empresaTableAdapter.Fill(this.dSAQCobranza.ERP_empresa);
            // TODO: esta línea de código carga datos en la tabla 'dSAQCobranza.ERP_empresa' Puede moverla o quitarla según sea necesario.
            this.eRP_empresaTableAdapter.Fill(this.dSAQCobranza.ERP_empresa);
               
            txtEmpresa.Text = "Copyright©" + DateTime.Today.Year + "  DIDISAC Todo los derechos reservados";
            PermisosUsuario();
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.Controls.Find("GRemision", true).Count() == 0)
            {
                GRemision chForm = new GRemision();
                chForm.MdiParent = this;
                chForm.Show();
            }

        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.Controls.Find("Empresa", true).Count() == 0)
            {
                Empresa chForm = new Empresa();
                chForm.MdiParent = this;
                chForm.Show();
            }

        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.Controls.Find("Permisos", true).Count() == 0)
            {
                Permisos chForm = new Permisos();
                chForm.MdiParent = this;
                chForm.Show();
            }

        }

        private void barCaja_banco_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.Controls.Find("Caja_banco", true).Count() == 0)
            {
                Caja_banco chForm = new Caja_banco();
                chForm.MdiParent = this;
                chForm.Show();
            }
        }

        private void barCajaChica_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.Controls.Find("CajaChica", true).Count() == 0)
            {
                CajaChica chForm = new CajaChica();
                chForm.MdiParent = this;
                chForm.Show();
            }
        }

        private void barBancos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.Controls.Find("bancos", true).Count() == 0)
            {
                bancos chForm = new bancos();
                chForm.MdiParent = this;
                chForm.Show();
            } 
        }

        private void eRP_empresaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.eRP_empresaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSAQCobranza);

        }

        private void eRP_empresaBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.eRP_empresaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSAQCobranza);

        }

        private void barCompro_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.Controls.Find("Comprobantes", true).Count() == 0)
            {
                Comprobantes chForm = new Comprobantes();
                chForm.MdiParent = this;
                chForm.Show();
            }
        }

        private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("QAVentas.chm");
        }

        private void Panel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.F1))
            {
                System.Diagnostics.Process.Start("QAVentas.chm");
            }
        }

        private void Panel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                System.Diagnostics.Process.Start("QAVentas.chm");
            }
        }
    }

}
