using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using BLL;

namespace PresentacionGUI
{
    public partial class FrmHome : Form
    {
        Usuario usuario;
        UsuarioServices usuarioServices;
        public FrmHome()
        {
            InitializeComponent();
            usuario = new Usuario();
            usuarioServices = new UsuarioServices();
           // Consultar();
        }
        public void Consultar()
        {
            Usuario usuario = new Usuario();
            usuario = usuarioServices.Consultar();
            TxtUsuario.Text = usuario.NombreUsuario;
            TxtContrasena.Text = usuario.Contraseña;
            TxtCorreo.Text = usuario.Correo;

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
        }
    }
}
