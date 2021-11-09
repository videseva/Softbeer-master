using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Factura
    {
        public string NumeroFactura { get; set; }
        public DateTime FechaFacturacion { get; set; }
        public string Estado{ get; set; }
        public decimal Total{ get; set; }
        
        private List<DetalleCompra> listaDetalleFactura;
        private List<PrestamoEnvase> listaPrestamoEnvases;

        public Factura()
        {
            listaDetalleFactura = new List<DetalleCompra>();
            listaPrestamoEnvases = new List<PrestamoEnvase>();
        }

        public List<DetalleCompra> getListaDetalleFactura()
        {
            return listaDetalleFactura;
        }

        public DetalleCompra AgregarDetalle(Producto producto, int cantidad)
        {
            if (cantidad < 1)
            {
                return null;
            }
            DetalleCompra detalleFacturaNew = new DetalleCompra(producto, cantidad);
            detalleFacturaNew.Factura = this;
            listaDetalleFactura.Add(detalleFacturaNew);
            return detalleFacturaNew;
        }
        public string RemoverDetalle(DetalleCompra detalleFactura)
        {
            if (listaDetalleFactura.Remove(detalleFactura))
                return "Detalle eliminado!";
            else
                return "No se ha podido eliminar detalle";
        }
        public PrestamoEnvase AgregarPrestamo(Producto producto, int cantidad)
        {
            if (cantidad < 1)
            {
                return null;
            }
            PrestamoEnvase prestamoNew = new PrestamoEnvase(producto, cantidad);
            prestamoNew.Factura = this;
            listaPrestamoEnvases.Add(prestamoNew);
            return prestamoNew;
        }
        public string Remover(PrestamoEnvase prestamo)
        {
            if (listaPrestamoEnvases.Remove(prestamo))
                return "Prestamo eliminado!";
            else
                return "No se ha podido eliminar el prestamo";
        }

        public void CalcularTotal()
        {
            decimal sumaDetalles = listaDetalleFactura.Sum(l => l.SubTotal);
            Total = sumaDetalles;
        }


    }
}
