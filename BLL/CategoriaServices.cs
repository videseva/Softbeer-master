using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using Entity;
using DAL;

namespace BLL
{
     public class CategoriaServices
    {
        ConnectionManager connectionManager;
        CategoriaRepository categoriaRepository;
        List<Categoria> categorias;
        Categoria categoria;
        public CategoriaServices()
        {
            connectionManager = new ConnectionManager();
            categoriaRepository = new CategoriaRepository(connectionManager.ObtenerConexion());
        }
        public string Guardar(Categoria categoria)
        {
         
            try
            {
                connectionManager.Abrir();
                categoriaRepository.Guardar(categoria);
                connectionManager.Cerrar();
                return "categoria registrado con exito.";
            }
            catch (Exception e)
            {
                connectionManager.Cerrar();
                Console.WriteLine(e);
                return $"ERROR EN LA BASE DE DATOS : {e.Message}";
            }
        
        }

        public List<Categoria> Consultar()
        {
         
            try
            {
                connectionManager.Abrir();
                categorias = categoriaRepository.Consultar();
                connectionManager.Cerrar();
                return categorias;
            }
            catch (Exception e)
            {
                connectionManager.Cerrar();
                Console.WriteLine(e);
                Console.WriteLine($"Error de DB: {e.Message}");
                return categorias;
            }
        }




    }
}
