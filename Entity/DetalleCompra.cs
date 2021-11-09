using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class DetalleCompra
    {
        public string CodigoDetalle { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal SubTotal{ get; set; }
        public Factura Factura { get; set; }
        public Producto Producto{ get; set; }
        
        public DetalleCompra(Producto producto, int cantidad)
        {
            Producto = producto;
            Cantidad = cantidad;
            Descripcion = producto.Nombre;
            PrecioUnitario = producto.PrecioCosto;
            CalcularTotal();
        }

        public void CalcularTotal()
        {
            SubTotal = Cantidad * PrecioUnitario;
        }

        public override bool Equals(object obj)
        {
            return obj is DetalleCompra factura &&
                   CodigoDetalle == factura.CodigoDetalle;
        }
    }
}
