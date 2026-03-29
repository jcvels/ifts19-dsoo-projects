using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaFormativa1
{
    internal class Persona
    {
        private string nombre;
        private string domicilio;

        public Persona(string nombre, string domicilio)
        {
            this.nombre = nombre;
            this.domicilio = domicilio;
        }
        public string Nombre
        {
            set { this.nombre = value; }
            get { return this.nombre; }
        }
        public string Domicilio
        {
            set { this.domicilio = value; }
            get { return this.nombre; }
        }
    }
}
