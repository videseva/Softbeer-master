using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Producto
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public int Existencias { get; set; }
        public decimal PrecioCosto { get; set; }
        public decimal PrecioVenta { get; set; }
        public string EsRetornable { get; set; }
        public string Estado { get; set; }
        public string IdCategoria { get; set; }
        public Categoria Categoria { get; set; }

        public string DescontarExistencias(int cantidad)
        {
            if (Existencias >= cantidad)
            {
                Existencias -= cantidad;
                return "Se descontaron la cantidad ingresada";
            }
            else
                return "No hay suficiente existencias";
        }
        public void AumentarExistencias(int cantidad)
        {
            Existencias += cantidad;
        }
    }
}
