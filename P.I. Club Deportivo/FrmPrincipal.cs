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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        internal string usuario;

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            lblIngreso.Text = "USUARIO: " + usuario;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnInscripcion_Click(object sender, EventArgs e)
        {
            FrmInscripcion inscripcion = new FrmInscripcion();

            inscripcion.Show();
            this.Hide();
        }

        private void btnSocios_Click(object sender, EventArgs e)
        {
            FrmSocios socios = new FrmSocios();

            socios.Show();
            this.Hide();
        }

        private void btnPago_Click(object sender, EventArgs e)
        {
            FrmPago pago = new FrmPago();

            pago.Show();
            this.Hide();
        }

        private void btnCarnet_Click(object sender, EventArgs e)
        {
            FrmEmitirCarnet frmEmitirCarnet = new FrmEmitirCarnet();
            frmEmitirCarnet.Show();
            this.Hide();
        }
    }
}
