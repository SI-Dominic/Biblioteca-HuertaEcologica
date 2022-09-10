using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ClasesDeLaHuerta
{
     class Conexion
    {
        public static SqlConnection getConexion()
       {
            string servidor = "LocalHost";
            string puerto = "3306";
            string usuario = "root";
            string password = "1234";
            string bd = "proyecto_sisgran";
            string cadenaConexion = " server " + servidor + "; port= " + puerto + "; user id " + usuario + "; password= " + password + "; database " + bd;
            SqlConnection conexion = SqlConnection(cadenaConexion);

            return conexion;
        }

        private static SqlConnection SqlConnection(string cadenaConexion)
        {
            throw new NotImplementedException();
        }
    }
}
