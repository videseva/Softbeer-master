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
    public class CategoriaRepository
    {
        OracleConnection oracleConnection;
        OracleCommand oracleCommand;
        OracleDataReader oracleData;
        Categoria categoria;
        List<Categoria> categorias;

        string nombre_tabla = "CATEGORIA";
        public CategoriaRepository(OracleConnection connection)
        {
            oracleConnection = connection;
        }

        public void Guardar(Categoria categoria)
        {
            using (oracleCommand = oracleConnection.CreateCommand())
            {
                oracleCommand.CommandText = "pr_ins_categoria";
                oracleCommand.CommandType = CommandType.StoredProcedure;
                oracleCommand.Parameters.Add("nombre", OracleDbType.Varchar2).Value = categoria.Nombre;
                oracleCommand.ExecuteNonQuery();
            }
        }

        public List<Categoria> Consultar()
        {
            
            using (oracleCommand = oracleConnection.CreateCommand())
            {
                oracleCommand.CommandText = "SELECT id_categoria, nombre FROM " + nombre_tabla;
                oracleData = oracleCommand.ExecuteReader();
            }
            return RecorrerConsulta(oracleData);


        }


        private List<Categoria> RecorrerConsulta(OracleDataReader oracleDataReader)
        {
            List<Categoria> categorias = new List<Categoria>();
            if (oracleDataReader.HasRows)
            {
                while (oracleDataReader.Read())
                {
                    categorias.Add(Mapear(oracleDataReader));
                }
            }
            return categorias;
        }

        private Categoria Mapear(OracleDataReader oracleDataReader)
        {

            categoria = new Categoria();
            categoria.Codigo = (int)oracleDataReader["id_categoria"];
            categoria.Nombre = (string)oracleDataReader["nombre"];
            return categoria;
        }
    }
}
