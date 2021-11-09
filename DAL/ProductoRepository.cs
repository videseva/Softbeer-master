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
    public class ProductoRepository
    {
        OracleConnection oracleConnection;
        OracleCommand oracleCommand;
        OracleDataReader oracleData;
        Producto producto;

        string nombre_tabla = "PRODUCTO";
        public ProductoRepository(OracleConnection connection)
        {
            oracleConnection = connection;
        }

        public void Guardar(Producto producto)
        {
            using (oracleCommand = oracleConnection.CreateCommand())
            {
                oracleCommand.CommandText = "PR_INS_PRODUCTO";
                oracleCommand.CommandType = CommandType.StoredProcedure;
                oracleCommand.Parameters.Add("nombre", OracleDbType.Varchar2).Value = producto.Nombre;
                oracleCommand.Parameters.Add("es_retornable", OracleDbType.Varchar2).Value = producto.EsRetornable;
                oracleCommand.Parameters.Add("existencias", OracleDbType.Int64).Value = producto.Existencias;
                oracleCommand.Parameters.Add("precio_venta", OracleDbType.Int64).Value = (Int64)producto.PrecioVenta;
                oracleCommand.Parameters.Add("costo", OracleDbType.Int64).Value = (Int64) producto.PrecioCosto;
                oracleCommand.Parameters.Add("id_categoria", OracleDbType.Int32).Value = Convert.ToInt32(producto.IdCategoria);

                oracleCommand.ExecuteNonQuery();
            }
        }


        public List<Producto> Consultar()
        {
            List<Producto> productos = new List<Producto>();
            using (oracleCommand = oracleConnection.CreateCommand())
            {
                oracleCommand.CommandText = @"SELECT id_producto, nombre, precio_venta, costo, existencias, id_categoria ,estado FROM " + nombre_tabla;
                oracleData = oracleCommand.ExecuteReader();
                if (oracleData.HasRows)
                {
                    while (oracleData.Read())
                    {
                        productos.Add(Mapear(oracleData));
                    }
                    oracleData.Close();
                }
            }
            return productos;

        }
        public Producto BuscarProducto(string idProducto)
        {
            Producto productoEncontrado = Consultar().Where(p => p.Codigo.Equals(idProducto)).FirstOrDefault();
            return productoEncontrado;
        }
        private Producto Mapear(OracleDataReader oracleDataReader)
        {
            
            producto = new Producto();
            if (!oracleData.HasRows) return null;
            producto.Codigo = Convert.ToString(oracleData["id_producto"]);
            producto.Nombre = (string)oracleData["nombre"];
            producto.PrecioVenta = Convert.ToDecimal(oracleData["precio_venta"]);
            producto.PrecioCosto = Convert.ToDecimal(oracleData["costo"]);
            producto.Existencias = Convert.ToInt32(oracleData["existencias"]);
            producto.IdCategoria = Convert.ToString(oracleData["id_categoria"]);
            producto.Estado = (string)oracleData["estado"];

            return producto;
        }
        public void ModificarProducto(Producto producto)
        {
            using (oracleCommand = oracleConnection.CreateCommand())
            {
                oracleCommand.CommandText = "UPDATE " + nombre_tabla + " SET precio_venta = :precio_venta, costo = :costo WHERE id_producto = :idProducto";
                //oracleCommand.CommandText = $"UPDATE producto SET precio_venta = {Convert.ToInt32(producto.PrecioVenta)}, costo = {Convert.ToInt32(producto.PrecioCosto)} " +
                //    $"WHERE id_producto = {Convert.ToInt32(producto.Codigo)};";

                oracleCommand.Parameters.Add("precio_venta", OracleDbType.Int32).Value = producto.PrecioVenta;
                oracleCommand.Parameters.Add("costo", OracleDbType.Int32).Value = producto.PrecioCosto;
                oracleCommand.Parameters.Add("idProducto", OracleDbType.Int32).Value = producto.Codigo;
                oracleCommand.ExecuteNonQuery();
                
            }


            
        }

    }
}
