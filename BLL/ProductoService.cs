using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using Entity;
using DAL;

namespace BLL
{
    public class ProductoService
    {
        ConnectionManager connectionManager;
        ProductoRepository productoRepository;
        List<Producto> productos;
        Producto producto;

        public ProductoService()
        {
            connectionManager = new ConnectionManager();
            productoRepository = new ProductoRepository(connectionManager.ObtenerConexion());
        }

        public string Guardar(Producto producto)
        {
            try
            {
                connectionManager.Abrir();
                productoRepository.Guardar(producto);
                connectionManager.Cerrar();
                return "Producto registrado con exito.";
            }
            catch (Exception e)
            {
                connectionManager.Cerrar();
                Console.WriteLine(e);
                return $"ERROR EN LA BASE DE DATOS : {e.Message}";
            }
        }

        public ConsultaProductosResponse Consultar()
        {
            try
            {
                connectionManager.Abrir();
                productos = productoRepository.Consultar();
                connectionManager.Cerrar();
                return new ConsultaProductosResponse(productos);
            }
            catch (Exception e)
            {
                connectionManager.Cerrar();
                return new ConsultaProductosResponse($"Error de DB: {e.Message}" +
                    $"Stack: {e.StackTrace}");
            }
        }
        public ProductoResponse BuscarProducto(string idProducto)
        {
            try
            {
                connectionManager.Abrir();
                Producto productoEncontrado = productoRepository.BuscarProducto(idProducto);
                connectionManager.Cerrar();
                if (productoEncontrado == null)
                {
                    return new ProductoResponse("Este producto no se encuentra registrado");
                }
                else
                {
                    return new ProductoResponse(productoEncontrado);
                }
            }
            catch (Exception e)
            {
                connectionManager.Cerrar();
                return new ProductoResponse($"Error de DB: {e.Message}" +
                    $"Stack: {e.StackTrace}");
            }
            
        }
        public string ModificarProducto(Producto producto)
        {
            try
            {
                connectionManager.Abrir();
                productoRepository.ModificarProducto(producto);
                connectionManager.Cerrar();
                return "Producot modificado exitosamente";
            }
            catch (Exception e)
            {
                connectionManager.Cerrar();
                return $"ERROR EN LA BASE DE DATOS : {e.Message}";
            }
        }

    }
    public class ConsultaProductosResponse
    {
        public ConsultaProductosResponse(List<Producto> productos)
        {
            this.productos = productos;
            Error = false;
        }

        public ConsultaProductosResponse(string mensaje)
        {
            Mensaje = mensaje;
            Error = true;
        }

        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public List<Producto> productos { get; set; }

    }
    public class ProductoResponse
    {
        public ProductoResponse(Producto producto)
        {
            this.producto = producto;
            Error = false;
        }

        public ProductoResponse(string mensaje)
        {
            Mensaje = mensaje;
            Error = true;
        }

        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public Producto producto { get; set; }

    }
}
