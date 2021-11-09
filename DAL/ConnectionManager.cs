using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Oracle.ManagedDataAccess.Client;


namespace DAL
{
     public class ConnectionManager
    {
        OracleConnection oracleConnection;
        public ConnectionManager()
        {
            oracleConnection = new OracleConnection("DATA SOURCE = localhost:1521/xepdb1; USER ID = AdminSoftbeer  ; PASSWORD=12345");
        }
        public void Abrir()
        {
            oracleConnection.Open();
        }
        public void Cerrar()
        {
            oracleConnection.Close();
        }

        public OracleConnection ObtenerConexion()
        {
            return oracleConnection;
        }
    }
}
