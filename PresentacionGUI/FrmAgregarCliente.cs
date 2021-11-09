using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionGUI
{
    public partial class FrmAgregarCliente : Form
    {
        public FrmAgregarCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLimpiarCampos_Click(object sender, EventArgs e)
        {
            txtNumeroIdentificacion.Text = "";
            txtPrimerNombreCliente.Text = "";
            txtSegundoNombreCliente.Text = "";
            txtPrimerApellidoCliente.Text = "";
            txtSegundoApellidoCliente.Text = "";
            txtDireccion.Text = "";
            txtCorreo.Text = "";
            txtTelefono.Text = "";
        }
    }
}
