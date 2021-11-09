using System;
using System.Collections.Generic;

namespace Entity
{
    public class Usuario
    {
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public string Correo { get; set; }
        public Usuario()
        {

        }
        public bool ValidarContraseña(string contraseña,string usuario)
        {
            return contraseña.Equals(Contraseña);
        }
    }
}
