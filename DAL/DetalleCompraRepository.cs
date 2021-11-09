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
    public class DetalleCompraRepository
    {
        OracleConnection oracleConnection;
        OracleCommand oracleCommand;
        OracleDataReader oracleData;
        DetalleCompra detalle;
        List<DetalleCompra> detalleCompras;

        string nombre_tabla = "DETALLEFACTURACOMPRA";
        public DetalleCompraRepository(OracleConnection connection)
        {
            oracleConnection = connection;
        }

        public void Guardar(DetalleCompra detalle)
        {
            using (oracleCommand = oracleConnection.CreateCommand())
            {
                oracleCommand.CommandText = "PR_INS_DETALLEFACTURACOMPRA";
                oracleCommand.CommandType = CommandType.StoredProcedure;
                oracleCommand.Parameters.Add("id_producto", OracleDbType.Varchar2).Value = detalle.Producto.Codigo;
                oracleCommand.Parameters.Add("cantidad", OracleDbType.Int32).Value = detalle.Cantidad;
                oracleCommand.Parameters.Add("precioUnitario", OracleDbType.Int32).Value = detalle.PrecioUnitario;
                oracleCommand.ExecuteNonQuery();
            }
        }
    }
}
