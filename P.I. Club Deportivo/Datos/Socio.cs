using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace P.I._Club_Deportivo.Datos
{
    public class Socio : Persona
    {
        public decimal ImporteCuota { get; set; }

        public DateTime CalcularVencimiento()
        {
            return DateTime.Now.AddMonths(1);
        }

        public bool DebeCuota()
        {
            return !EstaPago;
        }
    }
}
