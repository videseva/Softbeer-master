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
    public class ProveedorServices
    {
        ConnectionManager connectionManager;
        ProveedorRepository proveedorRepository;
        List<Proveedor> proveedores;
        Proveedor proveedor;
        Correo email = new Correo();

        public ProveedorServices()
        {
            connectionManager = new ConnectionManager();
            proveedorRepository = new ProveedorRepository(connectionManager.ObtenerConexion());
        }

        public string Guardar(Proveedor proveedor)
        {
            try
            {
                connectionManager.Abrir();
                proveedorRepository.Guardar(proveedor);
                string mensajeEmail = email.EnviarEmail(proveedor);
                connectionManager.Cerrar();
                return "Proveedor registrado con exito./n"+mensajeEmail;
            }
            catch (Exception e)
            {
                connectionManager.Cerrar();
                Console.WriteLine(e);
                return $"ERROR EN LA BASE DE DATOS : {e.Message}";
             
            }
        }

        public List<Proveedor> Consultar()
        {
            try
            {
                connectionManager.Abrir();
                proveedores = proveedorRepository.Consultar();
                connectionManager.Cerrar();
                return proveedores;
            }
            catch (Exception e)
            {
                connectionManager.Cerrar();
                Console.WriteLine(e);
                Console.WriteLine($"Error de DB: {e.Message}");
                return null;
            }
        }
   
        public string Editar(Proveedor proveedor )
        {
            try
            {
                connectionManager.Abrir();
                proveedorRepository.Editar(proveedor);
                connectionManager.Cerrar();
                return "Edición exitosa";
            }
            catch (Exception e)
            {
                connectionManager.Cerrar();
                Console.WriteLine(e);
                return $"Error de DB: {e.Message}";
            }
        }

        public string Eliminar(string identificacion)
        {
            try
            {

                connectionManager.Abrir();
                proveedorRepository.Eliminar(identificacion);
                connectionManager.Cerrar();
                return "Registro eliminado con exitosa";
            }
            catch (Exception e)
            {
                connectionManager.Cerrar();
                Console.WriteLine(e);
                return $"Error de DB: {e.Message}";
            }
        }

        public Proveedor BuscaProveedor(string identificacion)
        {

            try
            {
                connectionManager.Abrir();
                proveedor = proveedorRepository.Buscar(identificacion);
                connectionManager.Cerrar();
                return proveedor;
            }
            catch (Exception e)
            {
                connectionManager.Cerrar();
                Console.WriteLine(e);
                return null;
            }
        }
    }

}
