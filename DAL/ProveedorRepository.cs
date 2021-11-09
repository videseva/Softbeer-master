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
     public class ProveedorRepository
    {
        private readonly OracleConnection oracleConnection;
        OracleCommand oracleCommand;
        OracleDataReader oracleData;
    
        private readonly List<Proveedor> proveedores;

        string nombre_tabla = "PROVEEDOR";
        public ProveedorRepository(OracleConnection connection)
        {
            oracleConnection = connection;
        }

        public void Guardar(Proveedor proveedor)
        {
            using (oracleCommand = oracleConnection.CreateCommand())
            {
                oracleCommand.CommandText = "PR_INS_PROVEEDOR";
                oracleCommand.CommandType = CommandType.StoredProcedure;
                oracleCommand.Parameters.Add("cedula", OracleDbType.Varchar2).Value = proveedor.Identificacion;
                oracleCommand.Parameters.Add("PrimerNombre", OracleDbType.Varchar2).Value = proveedor.PrimerNombre;
                oracleCommand.Parameters.Add("SegundoNombre", OracleDbType.Varchar2).Value = proveedor.SegundoNombre;
                oracleCommand.Parameters.Add("PrimerApellido", OracleDbType.Varchar2).Value = proveedor.PrimerApellido;
                oracleCommand.Parameters.Add("SegundoApellido", OracleDbType.Varchar2).Value = proveedor.SegundoApellido;
                oracleCommand.Parameters.Add("telefono", OracleDbType.Varchar2).Value = proveedor.Telefono;
                oracleCommand.Parameters.Add("genero", OracleDbType.Varchar2).Value = proveedor.Genero;
                oracleCommand.Parameters.Add("correo", OracleDbType.Varchar2).Value = proveedor.Correo;
                oracleCommand.Parameters.Add("nitempresa", OracleDbType.Varchar2).Value = proveedor.NitEmpresa;
                oracleCommand.Parameters.Add("nombreempresa", OracleDbType.Varchar2).Value = proveedor.NombreEmpresa;


                oracleCommand.ExecuteNonQuery();
            }
        }


        public Proveedor Buscar(string cedula)
        {
            using (oracleCommand = oracleConnection.CreateCommand())
            {
                oracleCommand.CommandText = "SELECT cedula, primernombre,segundonombre, primerapellido,segundoapellido,telefono,genero,correo,nitempresa,nombreempresa FROM " + nombre_tabla ;

                oracleCommand.Parameters.Add("Cedula", OracleDbType.Varchar2).Value = cedula;
                oracleData = oracleCommand.ExecuteReader();
                if (oracleData.Read())
                {
                    return Mapear(oracleData);
                }
            }
            return null;
        }

        public List<Proveedor> Consultar()
        {
            
            List<Proveedor> proveedores = new List<Proveedor>();
            using (oracleCommand = oracleConnection.CreateCommand())
            {
                oracleCommand.CommandText = @"SELECT cedula, primernombre,segundonombre, primerapellido,segundoapellido,telefono,genero,correo,nitempresa,nombreempresa FROM PROVEEDOR";
                oracleData = oracleCommand.ExecuteReader();
                if (oracleData.HasRows)
                {
                    while (oracleData.Read())
                    {
                        Proveedor proveedor = Mapear(oracleData);
                        proveedores.Add(proveedor);
                    }
                    oracleData.Close();
                }
              
            }
            return proveedores;
        }

        private Proveedor Mapear(OracleDataReader oracleDataReader)
        {
           
            Proveedor proveedor = new Proveedor();
            if (!oracleData.HasRows) return null;
            proveedor.Identificacion = (string)oracleData["cedula"];
            proveedor.PrimerNombre = (string)oracleData["PrimerNombre"];
            proveedor.SegundoNombre = (string)oracleData["SegundoNombre"];
            proveedor.PrimerApellido = (string)oracleData["PrimerApellido"];
            proveedor.SegundoApellido = (string)oracleData["SegundoApellido"];
            proveedor.Telefono = (string)oracleData["Telefono"];
            proveedor.Genero = (string)oracleData["Genero"];
            proveedor.Correo = (string)oracleData["Correo"];
            proveedor.NitEmpresa = (string)oracleData["NitEmpresa"];
            proveedor.NombreEmpresa = (string)oracleData["NombreEmpresa"];
           
            return proveedor;
        }

        public void Editar(Proveedor proveedor)
        {
            using (oracleCommand = oracleConnection.CreateCommand())
            {
                oracleCommand.CommandText = "UPDATE " + nombre_tabla + " SET PrimerNombre = :PrimerNombre WHERE cedula = :identificacion";

                oracleCommand.Parameters.Add("PrimerNombre", OracleDbType.Varchar2).Value = proveedor.PrimerNombre;
                oracleCommand.Parameters.Add("cedula", OracleDbType.Varchar2).Value = proveedor.Identificacion;
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
