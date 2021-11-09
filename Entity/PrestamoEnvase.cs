using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class PrestamoEnvase
    {
        public string CodigoPrestamo { get; set; }
        public int Cantidad { get; set; }
        public string Estado { get; set; }
        public Factura Factura { get; set; }
        public Producto Producto { get; set; }

        public PrestamoEnvase(Producto producto, int cantidad)
        {
            Cantidad = cantidad;
            Producto = producto;
            Estado = "Activo";
        }



    }
}
