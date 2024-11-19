using MySql.Data.MySqlClient;
using P.I._Club_Deportivo.Datos;

namespace P.I._Club_Deportivo
{
    public partial class FrmPago : Form
    {
        public string tipoCliente;
        public int idCliente;
        public FrmPago()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Valido que el usuario haya ingresado un documento antes de buscar
            if (string.IsNullOrWhiteSpace(txtDocumento.Text))
            {
                MessageBox.Show("Por favor, ingrese el documento.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Persona persona = ObtenerPersonaPorDocumento(txtDocumento.Text);
            this.idCliente = persona.id;

            // Muestro los valores en los txt
            txtNombre.Text = persona.Nombre;
            txtApellido.Text = persona.Apellido;
            DateTime fechaVencimiento = persona.FechaVencimiento;
            txtVencimiento.Text = fechaVencimiento.ToString("dd/MM/yyyy");

            txtEstado.Text = persona.EstaPago ? "Pagado" : "Pendiente";
            txtEstado.ForeColor = persona.EstaPago ? Color.Green : Color.Red;

        }

        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            FrmPrincipal principal = new FrmPrincipal();
            principal.Show();
            this.Hide();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAgregarPago agregarPago = new FrmAgregarPago(this, tipoCliente, idCliente);
            agregarPago.Show();
            this.Hide();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FrmPrincipal frmPrincipal = new FrmPrincipal();
            frmPrincipal.Show();
            this.Hide();
        }

        public Persona ObtenerPersonaPorDocumento(string documento)
        {
            Persona persona = null;
            string query = "SELECT id, nombre, apellido, documento, tipoCliente, fechaVencimiento, direccion, contacto, aptoFisico, pago FROM persona WHERE documento = @documento";

            using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion())
            using (MySqlCommand comando = new MySqlCommand(query, sqlCon))
            {
                comando.Parameters.AddWithValue("@documento", documento);
                sqlCon.Open();
                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    tipoCliente = reader["tipoCliente"].ToString();
                    persona = tipoCliente == "Socio" ? new Socio() : new NoSocio();

                    persona.Nombre = reader["nombre"].ToString();
                    persona.Apellido = reader["apellido"].ToString();
                    persona.Documento = reader["documento"].ToString();
                    persona.Direccion = reader["direccion"].ToString();
                    persona.Contacto = reader["nombre"].ToString();
                    persona.AptoFisico = (bool)reader["aptoFisico"];
                    persona.EstaPago = Convert.ToBoolean(reader["pago"]);
                    persona.id = (int)reader["id"];

                }
            }

            return persona;
        }

        public void ActualizarEstadoPago()
        {

            string documento = txtDocumento.Text;
            Persona persona = ObtenerPersonaPorDocumento(documento);

            if (persona != null)
            {
                // Actualizo el estado del pago en el formulario
                txtEstado.Text = persona.EstaPago? "Pagado" : "Pendiente";
            }
            else
            {
                MessageBox.Show("No se encontró la persona.");
            }
        }
    }
}
