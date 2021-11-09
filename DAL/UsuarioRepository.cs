using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Oracle.ManagedDataAccess.Client;

namespace DAL
{
    public class UsuarioRepository
    {
        private readonly OracleConnection oracleConnection;
        OracleCommand oracleCommand;
        OracleDataReader oracleData;
        string nombre_tabla = "USUARIO";

        public UsuarioRepository(OracleConnection connection)
        {
            oracleConnection = connection;
        }
        public Usuario Consultar()
        {
            Usuario usuario = new Usuario();
            using (oracleCommand = oracleConnection.CreateCommand())
            {
                oracleCommand.CommandText = @"SELECT nombre_user, clave,correo FROM " + nombre_tabla;
                oracleData = oracleCommand.ExecuteReader();
                if (oracleData.HasRows)
                {
                    while (oracleData.Read())
                    {
                        usuario = Mapear(oracleData);
                       
                    }
                    oracleData.Close();
                }

            }
            return usuario;
        }

        private Usuario Mapear(OracleDataReader oracleDataReader)
        {

            Usuario usuario = new Usuario();
            if (!oracleData.HasRows) return null;
            usuario.NombreUsuario = (string)oracleData["nombre_user"];
            usuario.Contraseña = (string)oracleData["clave"];
            usuario.Correo = (string)oracleData["correo"];

            return usuario;
        }
        public void Editar(Usuario usuario)
        {
            using (oracleCommand = oracleConnection.CreateCommand())
            {
                oracleCommand.CommandText = "UPDATE " + nombre_tabla + " SET clave = :contraseña WHERE nombre_user = :NombreUsuario";

                oracleCommand.Parameters.Add("nombre_user", OracleDbType.Varchar2).Value = usuario.NombreUsuario;
                oracleCommand.Parameters.Add("clave", OracleDbType.Varchar2).Value = usuario.Contraseña;
                oracleCommand.ExecuteNonQuery();
            }
        }
    }
}
