using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Proveedor : Persona
    {
        public Proveedor(string nombreEmpresa, string nitEmpresa, string identificacion, string primerNombre, 
            string segundoNombre, string primerApellido, string segundoApellido, string telefono, 
            string correo, string  genero) : base(identificacion, primerNombre, segundoNombre, primerApellido, 
            segundoApellido, telefono, correo, genero)
        {
            NombreEmpresa = nombreEmpresa;
            NitEmpresa = nitEmpresa;
        }
        public Proveedor()
        {

        }

        public string NombreEmpresa{ get; set; }
        public string NitEmpresa{ get; set; }
        public List<ProveedorProducto> ListaProveedorProducto{ get; set; }
        
    }
}
