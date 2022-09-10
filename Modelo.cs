using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesDeLaHuerta
{
     class Modelo
    {
        public int registro(Usuario usuarios) 
        {
            SqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string sql = "INSERT INTO usuario (usuario, contraseña, id) VALUES(@usuario, @contraseña, @id)";
            
            SqlCommand comando = new SqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@usuarios", usuario.Usuario);
            comando.Parameters.AddWithValue("@contraseña", usuario.Contraseña);
            comando.Parameters.AddWithValue("@id", usuario.Id);

            int resultado = comando.ExecuteNonQuery();

            return resultado;
        }

        public bool existeUsuario(string usuario) 
        {
            SqlDataReader reader;
            SqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string sql = "SELECT id FROM usuarios WHERE usuario LIKE @usuario";

            SqlCommand comando = new SqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@usuario", usuario);
            reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                return true;
            }
            else {
                return false;
            }
        }
    }
}
