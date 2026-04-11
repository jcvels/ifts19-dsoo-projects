using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaFormativa1
{
    internal class Domicilio
    {
        private string calle;
        private int numero;
        private string barrio;

        public Domicilio(string calle, int numero, string barrio)
        {
            this.calle = calle;
            this.numero = numero;
            this.barrio = barrio;
        }
        
        public string Calle
        {
            get { return this.calle; }
        }
        
        public int Numero
        {
            get { return this.numero; }
        }
        
        public string Barrio
        {
            get { return this.barrio; }
        }

        public override string ToString ()
        {
            return this.calle + " " + this.numero + ", " + this.barrio;
        }
    }
}
