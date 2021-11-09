using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ProveedorProducto
    {

        public int Cantidad { get; set; }
        public Proveedor proveedor { get; set; }
        public Producto producto { get; set; }
    }
}
