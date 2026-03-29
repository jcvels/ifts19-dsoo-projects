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
        public string Nombre
        {
            set { this.nombre = value; }
            get { return this.nombre; }
        }
        public string Apellido
        {
            set { this.apellido = value; }
            get { return this.apellido; }
        }
        public string Tipo
        {
            set { this.tipo = value; }
            get { return this.tipo; }
        }
        public int Documento
        {
            set { this.documento = value; }
            get { return this.documento; }
        }
        public string toString()
        {
            return "Nombre: " + this.nombre + "\nApellido: " + this.apellido + "\nDocumento: " + this.documento + " [ " + this.tipo +" ]";
        }
    }
}
