/* Resolver la consiga del punto 4 con la particularidad que el número puede tener cualquier cantidad de dígitos,
 * es decir, puede ser un número de dos dígitos como un número de 6 dígitos.
 * Tomá la codificación anterior e introducí los cambios que sean necesarios. */

using System;

namespace exercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numberString = "";
            int addition = 0;
            Console.Write("Ingrese un numero: ");
            numberString = Console.ReadLine();
            for (int i = 0; i < numberString.Length; i++)
            {
                addition += int.Parse(numberString.Substring(i, 1));
                Console.Write(numberString.Substring(i, 1));
                if (i < numberString.Length - 1)
                {
                    Console.Write(" + ");
                }
            }
            Console.Write(" = " + addition);
        }
    }
}
