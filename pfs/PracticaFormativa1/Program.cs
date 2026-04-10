using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaFormativa1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var home = new Domicilio("Jonte",5250,"Monte Castro");
            var persona1 = new Persona("Camila", home.ToString());
            var persona2 = new Persona("Facundo", home.ToString());
            var tvDevice = new Televisor("Fake", "TV12345", 32, false, 1);

            Console.WriteLine("Domicilio: " + home.ToString());
            Console.WriteLine("Persona 1: " + persona1.ToString());
            Console.WriteLine("Persona 2: " + persona2.ToString());
            Console.WriteLine("TV: " + tvDevice.ToString());

            Console.WriteLine("\n> Facundo intenta cambiar el canal");
            tvDevice.cambiarCanal(10);
            Console.WriteLine(tvDevice.ToString());


            Console.WriteLine("\n> Camila enciende el televisor");
            tvDevice.cambiarEstado();
            Console.WriteLine(tvDevice.ToString());

            Console.WriteLine("\n> Camila intenta cambiar el canal: ");
            tvDevice.cambiarCanal(10);
            Console.WriteLine(tvDevice.ToString());

        }
    }
}
