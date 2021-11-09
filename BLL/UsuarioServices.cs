using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;

namespace BLL
{
    public class UsuarioServices
    {
        ConnectionManager connectionManager;
        UsuarioRepository usuarioRepository;
        Usuario usuario;
        public UsuarioServices()
        {
            connectionManager = new ConnectionManager();
           usuarioRepository = new UsuarioRepository(connectionManager.ObtenerConexion());
        }

        public Usuario Consultar()
        {
            try
            {
                connectionManager.Abrir();
                usuario = usuarioRepository.Consultar();
                connectionManager.Cerrar();
                return usuario;
            }
            catch (Exception e)
            {
                connectionManager.Cerrar();
                Console.WriteLine(e);
                Console.WriteLine($"Error de DB: {e.Message}");
                return null;
            }
        }
    }
}
