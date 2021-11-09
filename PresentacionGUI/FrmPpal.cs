using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace PresentacionGUI
{
    public partial class FrmPpal : Form
    {
        public FrmPpal()
        {
            InitializeComponent();
            AbrirFormInPanel(new FrmHome());
     
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void AbrirFormInPanel(object formHijo)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();

        }

        private void iconCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconRestaurar.Visible = true;
            iconMaximizar.Visible = false;
        }

        private void iconRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconRestaurar.Visible = false;
            iconMaximizar.Visible = true;
        }

        private void barraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnProveedor_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FrmProveedores());
        }

       

        private void BtnVentas_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FrmVentas());
        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FrmProductos());
        }

        private void BtnCompras_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FrmCompras());
        }

        private void BtnListadoFactura_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FrmListadoFactura());
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FrmCliente());
        }

        private void BtnPrestamos_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FrmPrestamoscs());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FrmHome());
        }
    }
}
