using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P.I._Club_Deportivo.Datos
{
    public class Pago
    {
        private List<Cuota> Cuotas { get; set; }
        public DateTime FechaPago { get; set; }
        public string MetodoPago { get; set; }
        public Boolean estaPago { get; set; }
        public decimal monto { get; set; }

        public Pago(DateTime fechaPago, string metodoPago, decimal monto)
        {
            FechaPago = fechaPago;
            MetodoPago = metodoPago;
            Cuotas = new List<Cuota>();
            this.monto = monto;
        }

        public void RegistrarCuota(Cuota cuota)
        {
            Cuotas.Add(cuota);
        }

    }
}