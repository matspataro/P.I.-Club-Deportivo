using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P.I._Club_Deportivo.Datos
{
    internal class Usuario
    {
        // metodo que retorna una tabla con la informacion del usuario
        public DataTable LoginUser(string username, string password)
        {
            MySqlDataReader resultado; // variable de tipo datareader
            DataTable tabla = new DataTable();
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {

                sqlCon = Conexion.getInstancia().CrearConexion();

                // el comando es un elemento que almacena en este caso el nombre
                // del procedimiento almacenado y la referencia a la conexion

                MySqlCommand comando = new MySqlCommand
                ("IngresoLogin", sqlCon); // IngresoLogin NOMBRE DEL PROCEDURE

                comando.CommandType = CommandType.StoredProcedure;

                // definimos los parametros que tiene el procedure
                comando.Parameters.Add("Usu", MySqlDbType.VarChar).Value = username;
                comando.Parameters.Add("Pass", MySqlDbType.VarChar).Value = password;

                // abrimos la conexion
                sqlCon.Open();
                resultado = comando.ExecuteReader(); // almacenamos el resulatdo en la variable
                tabla.Load(resultado); // cargamos la tabla con el resultado
                return tabla;
                //  de esta forma esta asociado el metodo con el procedure que esta almacenado en MySQL

            }
            catch (Exception ex)
            {
                throw new Exception("Error al retornar la tabla: " + ex.Message, ex);
            }
            // como proceso final
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
            };
        }
    }
}
