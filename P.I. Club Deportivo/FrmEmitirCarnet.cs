using MySql.Data.MySqlClient;
using P.I._Club_Deportivo.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P.I._Club_Deportivo
{
    public partial class FrmEmitirCarnet : Form
    {
        private Socio socio;
        public FrmEmitirCarnet()
        {
            InitializeComponent();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            // Valido que el usuario haya ingresado un documento antes de buscar
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Por favor, primero busque el socio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!socio.DebeCuota())
            {
                btnImprimir.Visible = false;
                PrintDocument pd = new PrintDocument();
                pd.PrintPage += new PrintPageEventHandler(ImprimirForm1);
                pd.Print();
                btnImprimir.Visible = true;
            }
            else
            {
                MessageBox.Show("No se puede imprimir, el socio posee deuda.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
        }

        private void ImprimirForm1(object o, PrintPageEventArgs e)
        {
            // Diseño del carnet
            Font font = new Font("Arial", 12);
            Brush brush = Brushes.Black;
            Brush brush2 = new SolidBrush(Color.FromArgb(207, 252, 230));

            // Simular el tamaño y estilo de un carnet
            e.Graphics.FillRectangle(brush2, new Rectangle(60, 60, 310, 180)); // Fondo del carnet
            e.Graphics.DrawRectangle(Pens.Black, new Rectangle(60, 60, 310, 180)); // Borde del carnet


            e.Graphics.DrawString("CLUB DEPORTIVO", new Font("Arial", 16, FontStyle.Bold), brush, new PointF(100, 70));
            string socioNumero = socio.id.ToString("D8");
            e.Graphics.DrawString("Socio Nro.: " + socioNumero, font, brush, new PointF(80, 100));
            e.Graphics.DrawString("Nombre: " + txtNombre.Text, font, brush, new PointF(80, 130));
            e.Graphics.DrawString("Documento: " + txtDocumento.Text, font, brush, new PointF(80, 160));
            e.Graphics.DrawString("Fecha de Vencimiento: " + socio.FechaVencimiento.ToString("dd/MM/yyyy"), font, brush, new PointF(80, 190));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Valido que el usuario haya ingresado un documento antes de buscar
            if (string.IsNullOrWhiteSpace(txtDocumento.Text))
            {
                MessageBox.Show("Por favor, ingrese el documento.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            socio = ObtenerSocioPorDocumento(txtDocumento.Text);
            if (socio != null)
            {
                txtNombre.Text = socio.Nombre + " " + socio.Apellido;
            }
            


        }

        public Socio ObtenerSocioPorDocumento(string documento)
        {
            string query = "SELECT id, nombre, apellido, documento, tipoCliente, fechaVencimiento, direccion, contacto, aptoFisico, pago FROM persona WHERE documento = @documento AND tipoCliente ='Socio'";

            using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion())
            using (MySqlCommand comando = new MySqlCommand(query, sqlCon))
            {
                comando.Parameters.AddWithValue("@documento", documento);
                sqlCon.Open();
                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    string tipoCliente = reader["tipoCliente"].ToString();

                    if (tipoCliente != null && tipoCliente.Equals("Socio"))
                    {
                        socio = new Socio();
                        socio.Nombre = reader["nombre"].ToString();
                        socio.Apellido = reader["apellido"].ToString();
                        socio.Documento = reader["documento"].ToString();
                        socio.Direccion = reader["direccion"].ToString();
                        socio.Contacto = reader["nombre"].ToString();
                        socio.AptoFisico = (bool)reader["aptoFisico"];
                        socio.EstaPago = Convert.ToBoolean(reader["pago"]);
                        socio.FechaVencimiento = Convert.ToDateTime(reader["fechaVencimiento"]);
                        socio.id = (int)reader["id"];
                    }



                }
                else
                {
                    MessageBox.Show("No se encontró el socio.");
                }
            }

            return socio;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmPrincipal frmPrincipal = new FrmPrincipal();
            frmPrincipal.Show();
            this.Hide();
        }
    }
}
