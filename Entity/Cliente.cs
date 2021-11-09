using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Cliente : Persona
    {
        public Cliente(string direccion,string identificacion, string primerNombre,
            string segundoNombre, string primerApellido, string segundoApellido, string telefono,
            string correo, string  genero) : base(identificacion, primerNombre, segundoNombre, primerApellido,
            segundoApellido, telefono, correo, genero)
        {
            Direccion = direccion;
        }
        public Cliente()
        {

        }

        public string Direccion { get; set; }
    }
}
