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
    public class DetalleCompraService
    {
        ConnectionManager connectionManager;
        DetalleCompraRepository detalleCompraRepository;
        List<DetalleCompra> detalleCompras;
        public DetalleCompraService()
        {
            connectionManager = new ConnectionManager();
            detalleCompraRepository = new DetalleCompraRepository(connectionManager.ObtenerConexion());
        }
        public string Guardar(DetalleCompra detalle)
        {
            try
            {
                connectionManager.Abrir();
                detalleCompraRepository.Guardar(detalle);
                connectionManager.Cerrar();
                return "Detalle guardado con exito";
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
