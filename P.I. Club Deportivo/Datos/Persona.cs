using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P.I._Club_Deportivo.Datos
{
    public abstract class Persona
    {
        // Atributos comunes a todas las personas
        private string Nombre;
        private string Apellido;
        private string Direccion;
        private string Documento;
        private string Contacto;
        private bool AptoFisico;

        // Constructor común
        public Persona(string nombre, string apellido, string direccion, string documento, string contacto, bool aptoFisico)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Direccion = direccion;
            this.Documento = documento;
            this.Contacto = contacto;
            this.AptoFisico = aptoFisico;
        }

        // Método abstracto que puede ser implementado de forma diferente en las clases hijas
        public abstract decimal CalcularCuota();
    }
}
