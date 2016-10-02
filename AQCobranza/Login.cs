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

namespace AQCobranza
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        AccesoDao objDao = new AccesoDao();
        Mensajes objMensajes = new Mensajes();

        List<E_Usuarios> lstUsuario = new List<E_Usuarios>();
        public Login()
        {
            InitializeComponent();
        }

        public void valida_usuario()
        {
            lstUsuario = objDao.login(textEdit1.Text, textEdit2.Text);
            if (lstUsuario.Count > 0)
            {
                Panel frm = new Panel();
                frm.txtUsuario.Text = Convert.ToString(lstUsuario[0].cod_usuario);
                frm.Usuario = Convert.ToString(lstUsuario[0].cod_usuario);
                this.Hide();
                frm.ShowDialog();
                this.Close();
            }
            else
            {
                objMensajes.M_error("El usuario y/o contraseña es incorrecta");
            }
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            valida_usuario();
            
        }

        private void Login_Load(object sender, EventArgs e)
        {
        
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void textEdit1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                valida_usuario();
            }
        }

        private void textEdit2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                valida_usuario();
            }
        }



    }
}