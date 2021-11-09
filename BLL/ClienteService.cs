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
    public class ClienteService
    {
        ConnectionManager connectionManager;
        ClienteRepository clienteRepository;
        List<Cliente> clientes;
        Cliente cliente;

        public ClienteService()
        {
            connectionManager = new ConnectionManager();
            clienteRepository = new ClienteRepository(connectionManager.ObtenerConexion());
        }

        public string Guardar(Cliente cliente)
        {
            try
            {
                connectionManager.Abrir();
                clienteRepository.Guardar(cliente);
                connectionManager.Cerrar();
                return "Cliente registrado con exito.";
            }
            catch (Exception e)
            {
                connectionManager.Cerrar();
                Console.WriteLine(e);
                return $"ERROR EN LA BASE DE DATOS : {e.Message}";
            }
        }

        public List<Cliente> Consultar()
        {
            try
            {
                connectionManager.Abrir();
                clientes = clienteRepository.Consultar();
                connectionManager.Cerrar();
                return clientes;
            }
            catch (Exception e)
            {
                connectionManager.Cerrar();
                Console.WriteLine(e);
                Console.WriteLine($"Error de DB: {e.Message}");
                return null;
            }
        }


        public string Editar(Cliente cliente)
        {
            try
            {
                connectionManager.Abrir();
                clienteRepository.Editar(cliente);
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
            clienteRepository.Eliminar(identificacion);
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

    public Cliente Filtrar(string identificacion)
        {
            try
            {
                connectionManager.Abrir();
                cliente = clienteRepository.Filtrar(identificacion);
                connectionManager.Cerrar();
                return cliente;
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

