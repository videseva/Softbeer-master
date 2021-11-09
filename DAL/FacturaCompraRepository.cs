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
    public class FacturaCompraRepository
    {
        OracleConnection oracleConnection;
        OracleCommand oracleCommand;
        OracleDataReader oracleData;
        Factura facturaCompra;
        List<Factura> facturasCompra;

        string nombre_tabla = "FACTURACOMPRA";
        public FacturaCompraRepository(OracleConnection connection)
        {
            oracleConnection = connection;
        }

        public void Guardar(FacturaCompra factura)
        {
            using (oracleCommand = oracleConnection.CreateCommand())
            {
                oracleCommand.CommandText = "PR_INS_FACTURA";
                oracleCommand.CommandType = CommandType.StoredProcedure;
                oracleCommand.Parameters.Add("CEDULA", OracleDbType.Varchar2).Value = factura.IdProveedor;
                oracleCommand.Parameters.Add("ESTADO", OracleDbType.Varchar2).Value = factura.Estado;
            
                oracleCommand.ExecuteNonQuery();
            }
        }


        
    }
}
