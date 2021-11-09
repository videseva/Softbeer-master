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
    public partial class FrmProductos : Form
    {
        ProductoService productoService;
        List<Producto> productos;
        public FrmProductos()
        {
            InitializeComponent();
            productoService = new ProductoService();
            Consultar();

        }

        public void Consultar()
        {
            DtgProductos.Rows.Clear();

            var response = productoService.Consultar();
            if (response.Error)
                CuadrosDialogo.BoxInfo(response.Mensaje, this);
            else
                foreach (var item in response.productos)
                {
                    DtgProductos.Rows.Add(item.Codigo, item.Nombre, item.PrecioVenta, item.PrecioCosto, item.Existencias, item.IdCategoria, item.Estado);
                }
        }

        private void AbrirFormularioHijo(FrmCrearProducto formHijo)
        {
            formHijo.MdiParent = this;
            formHijo.Show();
          
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            new FrmCrearProducto().Show();


        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            if(DtgProductos.SelectedRows.Count == 1)
            {
                producto.Codigo = DtgProductos.CurrentRow.Cells["ClmCodigo"].Value.ToString();
                producto.Nombre = DtgProductos.CurrentRow.Cells["ClmNombre"].Value.ToString();
                producto.PrecioCosto = Convert.ToDecimal(DtgProductos.CurrentRow.Cells["ClmPrecioCosto"].Value.ToString());
                producto.PrecioVenta = Convert.ToDecimal(DtgProductos.CurrentRow.Cells["ClmPrecioVenta"].Value.ToString());
            }
            new FrmModificarProducto(producto).Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            new FrmCategorias().Show();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            DtgProductos.Rows.Clear();
            
            if (CmbTipoBusqueda.Text == "Todos")
            {
                ConsultarTodos();
            }
            else if (CmbTipoBusqueda.Text == "Codigo del producto")
            {
                ConsultaPorCodigo(TxtBuscar.Text);
            }
            
        }

        private void ConsultarTodos()
        {
            ConsultaProductosResponse response = productoService.Consultar();
            if (response.Error)
                CuadrosDialogo.BoxInfo(response.Mensaje, this);
            else
                foreach (var item in response.productos)
                {
                    DtgProductos.Rows.Add(item.Codigo, item.Nombre, item.PrecioVenta, item.PrecioCosto, item.Existencias, item.Categoria.Nombre, item.Estado);
                }
        }
        private void ConsultaPorCodigo(string idCodigo)
        {
            ProductoResponse response = productoService.BuscarProducto(idCodigo);
            if(response.Error)
                CuadrosDialogo.BoxInfo(response.Mensaje, this);
            else
            {
                Producto item = response.producto;
                DtgProductos.Rows.Add(item.Codigo, item.Nombre, item.PrecioVenta, item.PrecioCosto, item.Existencias, item.Categoria.Nombre, item.Estado);
            }

        }
    }
}
