using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipularClases
{
    internal class Postulante
    {
        private string nombre;
        private string apellido;
        private string tipo;
        private int documento;

        public Postulante(string nombre, string apellido, string tipo, int documento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.tipo = tipo;
            this.documento = documento;
        }
        public string toString()
        {
            return "Nombre: " + this.nombre + "\nApellido: " + this.apellido + "\nDocumento: " + this.documento + " [ " + this.tipo +" ]";
        }
    }
}
