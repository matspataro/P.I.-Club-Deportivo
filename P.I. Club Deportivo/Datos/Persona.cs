using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace P.I._Club_Deportivo.Datos
{
    public abstract class Persona
    {
        // Atributos comunes a todas las personas
        public int id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Documento { get; set; }
        public string Contacto { get; set; }
        public bool AptoFisico { get; set; }
        public List<Pago> Pagos { get; set; }
        public bool EstaPago {  get; set; }
        public DateTime FechaVencimiento { get; set; }

        public Persona()
        {
            // Establecer la fecha de vencimiento como la fecha actual por defecto para luego modificarla con el pago
            FechaVencimiento = DateTime.Now;
        }


        public virtual void Pagar(string tipoPago, decimal monto)
        {
            using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion())
            {
                string queryUpdate = "UPDATE persona SET pago = @pago WHERE id = @id";

                using (MySqlCommand comando = new MySqlCommand(queryUpdate, sqlCon))
                {
                    comando.Parameters.AddWithValue("@pago", true);
                    comando.Parameters.AddWithValue("@id", this.id);
                    sqlCon.Open();
                    comando.ExecuteNonQuery();
                }
            }

            RegistrarPago(tipoPago, monto);
        }

        private void RegistrarPago(string tipoPago, decimal monto)
        {
            using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion())
            {
                string queryInsertPago = "INSERT INTO pago (fecha, tipoPago, monto, personaId) VALUES (@fecha, @tipoPago, @monto, @personaId)";

                using (MySqlCommand comando = new MySqlCommand(queryInsertPago, sqlCon))
                {
                    comando.Parameters.AddWithValue("@fecha", DateTime.Now);
                    comando.Parameters.AddWithValue("@tipoPago", tipoPago);
                    comando.Parameters.AddWithValue("@monto", monto);
                    comando.Parameters.AddWithValue("@personaId", this.id);
                    sqlCon.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }
    }
}
