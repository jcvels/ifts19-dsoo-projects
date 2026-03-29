using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeclarandoClase
{
    internal class Persona
    {
        private string nombre;
        private int edad;

        public Persona(string nombre)
        {
            this.edad = 0;
            this.nombre = nombre;
        }

        public string getNombre()
        {
            return this.nombre;
        }

        public string Nombre
        {
            set { this.nombre = value; }
            get { return this.nombre; }
        }
    }
}
