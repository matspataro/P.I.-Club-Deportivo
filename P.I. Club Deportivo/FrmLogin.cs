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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();

            txtPass.UseSystemPasswordChar = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Validación para evitar que los campos de usuario y contraseña estén vacíos
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MessageBox.Show("Por favor, ingrese un nombre de usuario válido.", "Usuario incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPass.Text))
            {
                MessageBox.Show("Por favor, ingrese una contraseña válida.", "Contraseña incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Lógica de inicio de sesión
            DataTable tablaLogin = new DataTable(); // es la que recibe los datos desde el formulario
            Datos.Usuario dato = new Datos.Usuario(); // variable que contiene todas las caracteristicas de la clase
            tablaLogin = dato.LoginUser(txtUsuario.Text, txtPass.Text);
            if (tablaLogin.Rows.Count > 0)
            {
                // ____ quiere decir que el resultado tiene 1 fila por lo que el usuario EXISTE ___
            // _____ informamos con un mensaje al usuario _____
            MessageBox.Show("Ingreso exitoso", "MENSAJES DEL SISTEMA",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
                /*
                __________________________________________________________
                ___________________
                una vez que tenemos la conexion establecida PASAMOS al
                formulario PRINCIPAL
                Se debe "Instanciar" un objeto de la clase formulario
                principal
                ___________________________________________________________________________
                _______ */
                FrmPrincipal Principal = new FrmPrincipal();
                /*
                _________________________________________________________
                ___________
                * la siguiente linea permite tomar el dominio de la
                primera columna
                * de la primera fila del resultado de la ejecucion de la
                query
                *
                ________________________________________________________
                ____________ */
                Principal.usuario = Convert.ToString(txtUsuario.Text);
                Principal.Show(); // se llama al formulario principal
                this.Hide(); // se oculta el formulario del login
            }
            else
            {
                MessageBox.Show("Usuario y/o password incorrecto");
            }
        }
    }
    
}
