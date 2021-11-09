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
    public partial class FrmCompras : Form
    {
        FacturaCompraService facturaCompraService;
        DetalleCompraService detalleCompraService;
        ProductoService productoService;
        Proveedor proveedor = new Proveedor();
        ProveedorServices proveedorServices;
        FacturaCompra factura = new FacturaCompra();
        List<DetalleCompra> listaDetalles;
        public FrmCompras()
        {
            InitializeComponent();
            proveedorServices = new ProveedorServices();
            facturaCompraService = new FacturaCompraService();
            detalleCompraService = new DetalleCompraService();
            productoService = new ProductoService();
           // listaDetalles = new List<DetalleCompra>();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            new FrmAgregarProveedor().Show();
        }
       
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            factura.FechaFacturacion = DtmFechaFacturacion.Value; //DtmFechaFacturacion.Value.Date.ToShortDateString;
            factura.IdProveedor = TxtCedulaProveedor.Text;
            factura.Estado = "Pendiente"; //Pendiente por cambiar
            factura.getListaDetalleFactura();
            string idProducto = TxtIdProducto.Text;
            int cantidad = Convert.ToInt32(TxtCantidad.Text);



            string messageFactura = facturaCompraService.Guardar(factura);
            CuadrosDialogo.BoxInfo(messageFactura, this);

        }

        private void BtnAgregarDetalles_Click(object sender, EventArgs e)
        {
            
            string idProducto = TxtIdProducto.Text;
            int cantidad = Convert.ToInt32(TxtCantidad.Text);

            ProductoResponse response = productoService.BuscarProducto(idProducto);
            if (!response.Error)
            {
                factura.AgregarDetalle(response.producto,cantidad);
                llenarTablaDetalleFactura();
            }
            else
               CuadrosDialogo.BoxInfo(response.Mensaje, this);

            
        }

        private void llenarTablaDetalleFactura()
        {
            DtgProductos.Rows.Clear();
            foreach (var item in factura.getListaDetalleFactura())
            {
                int subtotal;
               
                DtgProductos.Rows.Add(item.Producto.Codigo, item.Producto.Nombre, item.PrecioUnitario,
                    item.Cantidad, item.SubTotal);

                lbsubtotal.Text = item.SubTotal.ToString();
            }
        }


        private void BtnBuscarCliente_Click(object sender, EventArgs e)
        {
            proveedor = new Proveedor();
            MaPProveedor(proveedor);
        }

        private Proveedor MaPProveedor(Proveedor proveedor)
        {
            String identificacion;
            identificacion = TxtCedulaProveedor.Text;
            proveedor = proveedorServices.BuscaProveedor(identificacion);
            lbPrimen.Text = proveedor.PrimerNombre;
            lbsegundoN.Text = proveedor.SegundoNombre;
            lbPrimerApellido.Text = proveedor.PrimerApellido;
            lbSegundoApellido.Text = proveedor.SegundoNombre;
            lbcorrreo.Text = proveedor.Correo;
            lbtelefono.Text = proveedor.Telefono;
            lbnitempresa.Text = proveedor.NitEmpresa;
            lbnombreempresa.Text = proveedor.NombreEmpresa;

            return proveedor;
        }
    }
}
