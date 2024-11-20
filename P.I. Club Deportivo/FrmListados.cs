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
    public partial class FrmListados : Form
    {
        bool esInicializado = false;
        public FrmListados()
        {
            InitializeComponent();

            // Agrego las opciones al ComboBox
            cboListadoOpciones.Items.Add("Socios");
            cboListadoOpciones.Items.Add("No Socios");
            cboListadoOpciones.Items.Add("Vencimientos del día");

            //Por defecto selecciono los que vencen hoy
            cboListadoOpciones.SelectedIndex = 2;

            ConfigurarDataGridView();

            CargarSociosConCuotaVencidaHoy();

            esInicializado = true;
        }


        private void ConfigurarDataGridView()
        {
            dgvSocios.Columns.Clear();

            // Defino las columnas a mostrar
            dgvSocios.Columns.Add("Nombre", "Nombre");
            dgvSocios.Columns.Add("Apellido", "Apellido");
            dgvSocios.Columns.Add("Documento", "Documento");
            dgvSocios.Columns.Add("FechaVencimiento", "Fecha de vencimiento");
      
            dgvSocios.Columns["FechaVencimiento"].ValueType = typeof(DateTime);
        }

        private void CargarSociosConCuotaVencidaHoy()
        {
            string query = "SELECT nombre, apellido, documento, fechaVencimiento FROM persona WHERE tipoCliente = 'Socio' AND DATE(fechaVencimiento) = CURDATE()";
            MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion();
            MySqlCommand comando = new MySqlCommand(query, sqlCon);

            try
            {
                sqlCon.Open();
                MySqlDataReader reader = comando.ExecuteReader();

                // Limpiar el DataGridView antes de cargar nuevos datos
                dgvSocios.Rows.Clear();

                // Comprobar si hay registros
                if (reader.HasRows)
                {
                    // Cargar los datos si hay registros
                    while (reader.Read())
                    {
                        dgvSocios.Rows.Add(reader["nombre"], reader["apellido"], reader["documento"], reader["fechaVencimiento"]);
                    }
                }
                else
                {
                    MessageBox.Show("No hay socios con cuota vencida hoy.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
        }

        private void cboListadoOpciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!esInicializado) return;

            switch (cboListadoOpciones.SelectedItem.ToString())
            {
                case "Todos los socios":
                    CargarTodosLosSocios();
                    break;
                case "No socios":
                    CargarNoSocios();
                    break;
                case "Vencen hoy":
                    CargarSociosConCuotaVencidaHoy();
                    break;
            }
        }

        private void CargarTodosLosSocios()
        {
            string query = "SELECT nombre, apellido, documento, fechaVencimiento FROM persona WHERE tipoCliente = 'Socio'";
            CargarSocios(query);
        }

        private void CargarNoSocios()
        {
            string query = "SELECT nombre, apellido, documento, fechaVencimiento FROM persona WHERE tipoCliente = 'No Socio'";
            CargarSocios(query);
        }

        private void CargarSocios(string query)
        {
            MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion();
            MySqlCommand comando = new MySqlCommand(query, sqlCon);

            try
            {
                sqlCon.Open();
                MySqlDataReader reader = comando.ExecuteReader();

                // Limpiar el DataGridView antes de cargar nuevos datos
                dgvSocios.Rows.Clear();

                // Comprobar si hay registros
                if (reader.HasRows)
                {
                    // Cargar los datos si hay registros
                    while (reader.Read())
                    {
                        dgvSocios.Rows.Add(reader["nombre"], reader["apellido"], reader["documento"], reader["fechaVencimiento"]);
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron registros.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
        }

        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            FrmPrincipal principal = new FrmPrincipal();
            principal.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
