using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entity;


namespace PresentacionGUI
{
    public partial class FrmCrearProducto : Form
    {
        ProductoService productoService;
        public FrmCrearProducto()
        {
            InitializeComponent();
            productoService = new ProductoService();
        }

        private void BtnLimpiarCampos_Click(object sender, EventArgs e)
        {
            RefreshBox();
        }

        private void RefreshBox()
        {
            TxtExistencias.Text = null;
            TxtNombre.Text = null;
            TxtPrecioCosto.Text = null;
            TxtPrecioVenta.Text = null;
            TxtCategoria.Text = null;
            TxtCodigoProveedor.Text = null;
            TxtNombreProveedor.Text = null;
            RdbSi.Checked = false;
            RdbNo.Checked = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new FrmAgregarProveedor().Show();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnRegistrarProducto_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            producto.Nombre = TxtNombre.Text;
            producto.Existencias = Convert.ToInt32(TxtExistencias.Text);
            producto.PrecioVenta = Convert.ToDecimal(TxtPrecioVenta.Text);
            producto.PrecioCosto = Convert.ToDecimal(TxtPrecioCosto.Text);
            producto.IdCategoria = TxtCategoria.Text;
            if (RdbSi.Checked)
                producto.EsRetornable = "S";
            else
                producto.EsRetornable = "N";

            string message = productoService.Guardar(producto);
            CuadrosDialogo.BoxInfo(message, this);
            RefreshBox();
        }
    }
}
