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
    public class FacturaCompraService
    {
        ConnectionManager connectionManager;
        FacturaCompraRepository facturaCompraRepository;
        DetalleCompraRepository detalleCompraRepository;
        List<Factura> facturas;
        Factura factura;
        public FacturaCompraService()
        {
            connectionManager = new ConnectionManager();
            facturaCompraRepository = new FacturaCompraRepository(connectionManager.ObtenerConexion());
            detalleCompraRepository = new DetalleCompraRepository(connectionManager.ObtenerConexion());
        }
        public string Guardar(FacturaCompra factura)
        {
            try
            {
                connectionManager.Abrir();
                facturaCompraRepository.Guardar(factura);
                foreach (var item in factura.getListaDetalleFactura())
                {
                    detalleCompraRepository.Guardar(item);
                }
                connectionManager.Cerrar();
                return "Factura de compra registrada con exito.";
            }
            catch (Exception e)
            {
                connectionManager.Cerrar();
                Console.WriteLine(e);
                return $"ERROR EN LA BASE DE DATOS : {e.Message}";
            }

        }
    }
}
