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
    public partial class FrmModificarProducto : Form
    {
        Producto productoParaEditar;
        ProductoService productoService;
        public FrmModificarProducto(Producto producto)
        {
            InitializeComponent();
            this.productoParaEditar = producto;
            productoService = new ProductoService();
            LlenarCampos();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LlenarCampos()
        {
            TxtNombre.Text = productoParaEditar.Nombre;
            TxtPrecioCosto.Text = productoParaEditar.PrecioCosto.ToString();
            TxtPrecioVenta.Text = productoParaEditar.PrecioVenta.ToString();

        }

        private void BtnModificarProducto_Click(object sender, EventArgs e)
        {
            string mensaje = productoService.ModificarProducto(productoParaEditar);
            CuadrosDialogo.BoxInfo(mensaje, this);
        }
    }
}
