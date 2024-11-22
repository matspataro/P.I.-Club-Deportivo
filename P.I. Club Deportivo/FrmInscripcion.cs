using MySql.Data.MySqlClient;
using P.I._Club_Deportivo.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P.I._Club_Deportivo
{
    public partial class FrmInscripcion : Form
    {
        public FrmInscripcion()
        {
            InitializeComponent();
            cboTipoCliente.Items.Add("Socio");
            cboTipoCliente.Items.Add("No Socio");
        }

        private void btnInscribir_Click(object sender, EventArgs e)
        {
            // Obtener datos de los controles del formulario
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string documento = txtDocumento.Text;
            string direccion = txtDireccion.Text;
            string contacto = txtContacto.Text;
            bool aptoFisico = chkAptoFisico.Checked;
            string tipoCliente = cboTipoCliente.SelectedItem.ToString();

            // Validar que no haya campos vacíos
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) ||
                string.IsNullOrEmpty(documento) || string.IsNullOrEmpty(tipoCliente))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.");
                return;
            }

            MySqlConnection sqlCon = null;

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();

                string checkQuery = "SELECT COUNT(*) FROM persona WHERE documento = @documento";
                MySqlCommand checkCommand = new MySqlCommand(checkQuery, sqlCon);
                checkCommand.Parameters.AddWithValue("@documento", documento);

                sqlCon.Open();
                int count = Convert.ToInt32(checkCommand.ExecuteScalar());

                if (count > 0) // Si existe al menos un registro
                {
                    MessageBox.Show("El postulante ya existe.");
                    return;
                }

                // Crear la instancia de la clase Persona (Socio o NoSocio)
                Persona nuevaPersona;
                if (tipoCliente == "Socio")
                {
                    nuevaPersona = new Socio
                    {
                        Nombre = nombre,
                        Apellido = apellido,
                        Documento = documento,
                        Direccion = direccion,
                        Contacto = contacto,
                        AptoFisico = aptoFisico,
                        EstaPago = false, 
                        FechaVencimiento = CalcularFechaVencimiento(tipoCliente)
                    };
                }
                else
                {
                    nuevaPersona = new NoSocio
                    {
                        Nombre = nombre,
                        Apellido = apellido,
                        Documento = documento,
                        Direccion = direccion,
                        Contacto = contacto,
                        AptoFisico = aptoFisico,
                        EstaPago = false,
                        FechaVencimiento = DateTime.Now 
                    };
                }

                // Insertar un nuevo registro
                string query = "INSERT INTO persona (nombre, apellido, direccion, documento, contacto, aptoFisico, tipoCliente, fechaVencimiento) " +
                                "VALUES (@nombre, @apellido, @direccion, @documento, @contacto, @aptoFisico, @tipoCliente, @fechaVencimiento)";

                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.Parameters.AddWithValue("@nombre", nuevaPersona.Nombre);
                comando.Parameters.AddWithValue("@apellido", nuevaPersona.Apellido);
                comando.Parameters.AddWithValue("@direccion", nuevaPersona.Direccion);
                comando.Parameters.AddWithValue("@documento", nuevaPersona.Documento);
                comando.Parameters.AddWithValue("@contacto", nuevaPersona.Contacto);
                comando.Parameters.AddWithValue("@aptoFisico", nuevaPersona.AptoFisico);
                comando.Parameters.AddWithValue("@tipoCliente", tipoCliente);
                comando.Parameters.AddWithValue("@fechaVencimiento", nuevaPersona.FechaVencimiento);

                int filasAfectadas = comando.ExecuteNonQuery();

                // Verificar si el registro se insertó correctamente
                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Registro ingresado con éxito.");
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se pudo ingresar el registro.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar el registro: " + ex.Message);
            }
            finally
            {
                // Cierro la conexión si está abierta
                if (sqlCon != null && sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }


        // Método para limpiar los campos del formulario
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDocumento.Clear();
            txtDireccion.Clear();
            txtContacto.Clear();
            chkAptoFisico.Checked = false;
            cboTipoCliente.SelectedIndex = -1;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FrmPrincipal principal = new FrmPrincipal();
            principal.Show();
            this.Hide();
        }

        private void FrmInscripcion_Load(object sender, EventArgs e)
        {

        }

        //Método para calcular la fecha de vencimiento según el tipo de Cliente
        private DateTime CalcularFechaVencimiento(string tipoCuota)
        {
            if (tipoCuota == "Socio")
            {
                // Seteo el vencimiento en un mes
                return DateTime.Now.AddMonths(1);
            }
            else
            {
                return DateTime.Now;
            }
        }
    }
}
