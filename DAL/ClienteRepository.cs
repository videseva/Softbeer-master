using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using Entity;

namespace DAL
{
    public class ClienteRepository
    {
        OracleConnection oracleConnection;
        OracleCommand oracleCommand;
        OracleDataReader oracleData;
        Cliente cliente;
        List<Cliente> listaClientes;

        string nombre_tabla = "CLIENTE";
        public ClienteRepository(OracleConnection connection)
        {
            oracleConnection = connection;
        }

        public void Guardar(Cliente cliente)
        {
            using (oracleCommand = oracleConnection.CreateCommand())
            {
                oracleCommand.CommandText = "PR_INS_CLIENTE";
                oracleCommand.CommandType = CommandType.StoredProcedure;
                oracleCommand.Parameters.Add("cedula", OracleDbType.Varchar2).Value = cliente.Identificacion;
                oracleCommand.Parameters.Add("PrimerNombre", OracleDbType.Varchar2).Value = cliente.PrimerNombre;
                oracleCommand.Parameters.Add("SegundoNombre", OracleDbType.Varchar2).Value = cliente.SegundoNombre;
                oracleCommand.Parameters.Add("PrimerApellido", OracleDbType.Varchar2).Value = cliente.PrimerApellido;
                oracleCommand.Parameters.Add("SegundoApellido", OracleDbType.Varchar2).Value = cliente.SegundoApellido;
                oracleCommand.Parameters.Add("telefono", OracleDbType.Varchar2).Value = cliente.Telefono;
                oracleCommand.Parameters.Add("genero", OracleDbType.Varchar2).Value = cliente.Genero;
                oracleCommand.Parameters.Add("direccion", OracleDbType.Varchar2).Value = cliente.Direccion;
                oracleCommand.Parameters.Add("correo", OracleDbType.Varchar2).Value = cliente.Correo;


                oracleCommand.ExecuteNonQuery();
            }
        }


        public Cliente Buscar(string cedula)
        {
            using (oracleCommand = oracleConnection.CreateCommand())
            {
                oracleCommand.CommandText = "SELECT cedula, primernombre,segundonombre, primerapellido, segundoapellido, telefono, genero, direccion, correo FROM " + nombre_tabla;

                oracleCommand.Parameters.Add("Cedula", OracleDbType.Varchar2).Value = cedula;
                oracleData = oracleCommand.ExecuteReader();
                if (oracleData.Read())
                {
                    return Mapear(oracleData);
                }
            }
            return null;
        }

        public List<Cliente> Consultar()
        {
            using (oracleCommand = oracleConnection.CreateCommand())
            {
                oracleCommand.CommandText = "SELECT * FROM " + nombre_tabla;
                oracleData = oracleCommand.ExecuteReader();
            }
            return RecorrerConsulta(oracleData);
        }

        private List<Cliente> RecorrerConsulta(OracleDataReader oracleDataReader)
        {
            List<Cliente> clientes = new List<Cliente>();
            if (oracleDataReader.HasRows)
            {
                while (oracleDataReader.Read())
                {
                    clientes.Add(Mapear(oracleDataReader));
                }
            }
            return clientes;
        }

        private Cliente Mapear(OracleDataReader oracleDataReader)
        {

            Console.WriteLine("CLIENTE " + oracleDataReader.GetString(0));
            string cedula = oracleDataReader.GetString(0);
            cliente = new Cliente();
            cliente.Identificacion = (string)oracleDataReader["cedula"];

            cliente.PrimerNombre = (string)oracleDataReader["PrimerNombre"];
            cliente.SegundoNombre = (string)oracleDataReader["SegundoNombre"];
            cliente.PrimerApellido = (string)oracleDataReader["PrimerApellido"];
            cliente.SegundoApellido = (string)oracleDataReader["SegundoApellido"];
            cliente.Genero = (string)oracleDataReader["Genero"];
            cliente.Telefono = (string)oracleDataReader["Telefono"];
            cliente.Direccion = (string)oracleDataReader["Direccion"];
            cliente.Correo = (string)oracleDataReader["Correo"];

            return cliente;
        }

        public Cliente Filtrar(string identificacion)
        {
            using (oracleCommand = oracleConnection.CreateCommand())
            {
                oracleCommand.CommandText = "SELECT * FROM " + nombre_tabla + " WHERE cedulad = :identificacion";

                oracleCommand.Parameters.Add("cedula", OracleDbType.Int32).Value = identificacion;
                oracleData = oracleCommand.ExecuteReader();
                if (oracleData.Read())
                {
                    return Mapear(oracleData);
                }
            }
            return null;
        }


        public void Editar(Cliente cliente)
        {
            using (oracleCommand = oracleConnection.CreateCommand())
            {
                oracleCommand.CommandText = "UPDATE " + nombre_tabla + " SET PrimerNombre = :PrimerNombre WHERE cedula = :identificacion";
                oracleCommand.Parameters.Add("PrimerNombre", OracleDbType.Varchar2).Value = cliente.PrimerNombre;
                oracleCommand.Parameters.Add("cedula", OracleDbType.Varchar2).Value = cliente.Identificacion;
                oracleCommand.ExecuteNonQuery();
            }
        }


        public void Eliminar(string identificacion)
        {
            using (oracleCommand = oracleConnection.CreateCommand())
            {
                oracleCommand.CommandText = "DELETE FROM " + nombre_tabla + " WHERE cedula = :identificacion";

                oracleCommand.Parameters.Add("cedula", OracleDbType.Varchar2).Value = identificacion;
                oracleCommand.ExecuteNonQuery();
            }
        }
    }

}
