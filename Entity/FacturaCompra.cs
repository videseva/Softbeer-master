using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class FacturaCompra : Factura
    {
        public string IdProveedor { get; set; }
        public Proveedor proveedor { get; set; }
        
    }
}
