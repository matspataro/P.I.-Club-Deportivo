using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace P.I._Club_Deportivo.Datos
{
    public class Conexion
    {

        private string baseDatos;
        private string servidor;
        private string puerto;
        private string usuario;
        private string clave;
        private static Conexion con = null;
        private Conexion()
        {
            this.baseDatos = Environment.GetEnvironmentVariable("DB_NAME") ?? "club_deportivo_pi";
            this.servidor = Environment.GetEnvironmentVariable("DB_SERVER") ?? "localhost";
            this.puerto = Environment.GetEnvironmentVariable("DB_PORT") ?? "3306";
            this.usuario = Environment.GetEnvironmentVariable("DB_USER") ?? "root";
            this.clave = Environment.GetEnvironmentVariable("DB_PASSWORD") ?? "";
        }

        // proceso de interacción
        public MySqlConnection CrearConexion()
        {
            // instanciamos una conexion
            MySqlConnection cadena = new MySqlConnection();

            try
            {
                cadena.ConnectionString = "datasource=" + this.servidor +
                ";port=" + this.puerto +
                ";username=" + this.usuario +
                ";password=" + this.clave +
                ";Database=" + this.baseDatos;

            }
            catch (Exception ex)
            {
                cadena = null;
                throw new Exception("Error al crear la conexión con la base de datos: " + ex.Message, ex);
            }
            return cadena;
        }
        // para evaluar la instancia de la conectividad
        public static Conexion getInstancia()
        {
            if (con == null) // quiere decir que la conexion esta cerrada
            {
                con = new Conexion(); // se crea una nueva
                Console.WriteLine("Se creó una nueva instancia de la conexión.");
            }
            return con;
        }
    }
}
