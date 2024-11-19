using MySql.Data.MySqlClient;
using P.I._Club_Deportivo.Datos;

namespace P.I._Club_Deportivo
{
    public partial class FrmAgregarPago : Form
    {
        private FrmPago frmPagoReferencia;
        public Persona Persona;
        private int idCliente;

        public FrmAgregarPago(FrmPago frmPagoReferencia, String tipoCliente, int idCliente)
        {
            InitializeComponent();
            cboMetodoPago.Items.Add("Efectivo");
            cboMetodoPago.Items.Add("TC - 1 cuota");
            cboMetodoPago.Items.Add("TC - 3 cuotas");
            cboMetodoPago.Items.Add("TC - 6 cutoas");
            this.frmPagoReferencia = frmPagoReferencia;
            txtTipoCliente.Text = tipoCliente;
            this.idCliente = idCliente;
        }

        private void btnAceptarPago_Click(object sender, EventArgs e)
        {
            decimal monto;

            if (string.IsNullOrWhiteSpace(txtMonto.Text))
            {
                MessageBox.Show("Por favor, ingrese el monto a pagar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtMonto.Text, out monto))
            {
                MessageBox.Show("Por favor, ingrese un monto válido.");
            }

            if (string.IsNullOrWhiteSpace(cboMetodoPago.Text))
            {
                MessageBox.Show("Por favor, seleccione el método de pago.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            pagar(cboMetodoPago.Text, monto, idCliente);
            actualizarPersona(idCliente);
            frmPagoReferencia.ActualizarEstadoPago();

            frmPagoReferencia.Show();
            this.Hide();

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPagoReferencia.Show();
            this.Hide();
        }

        private void pagar(string tipoPago, decimal monto, int id)
        {
            string query = "INSERT INTO pago (fecha, tipoPago, monto, personaId) VALUES (@fecha, @tipoPago, @monto, @personaId)";

            using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion())
            using (MySqlCommand comando = new MySqlCommand(query, sqlCon))
            {
                comando.Parameters.AddWithValue("@fecha", DateTime.Now);
                comando.Parameters.AddWithValue("@tipoPago", tipoPago);
                comando.Parameters.AddWithValue("@monto", monto);
                comando.Parameters.AddWithValue("@personaId", id);

                sqlCon.Open();
                comando.ExecuteNonQuery();

            }
        }

        public void actualizarPersona(int id)
        {
            string query = "UPDATE persona SET pago = @pago WHERE id = @id";

            using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion())
            using (MySqlCommand comando = new MySqlCommand(query, sqlCon))
            {
                comando.Parameters.AddWithValue("@pago", true);
                comando.Parameters.AddWithValue("@id", id);

                sqlCon.Open();
                comando.ExecuteNonQuery();
            }
        }

    }
}
