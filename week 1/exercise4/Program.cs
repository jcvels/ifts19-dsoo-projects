/* Se trata de implementar un programa que sume los dígitos de un número entero no negativo de 4 dígitos.
 * Por ejemplo, la suma de los dígitos del 3433 es 13.
 * Para darle un poco más de emoción, el programa no se limitará a escribir el resultado de la suma,
 * sino que también escribirá todos los sumandos utilizados: 3 + 4 + 3 + 3 = 13. */

using System;

namespace exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int NUMBER_SIZE = 4;
            string numberString = "";
            int addition = 0;
            Console.Write("Ingrese un numero de " + NUMBER_SIZE + " digitos: ");
            numberString = Console.ReadLine();
            if (numberString.Length == NUMBER_SIZE)
            {
                for (int i = 0; i < NUMBER_SIZE; i++)
                {
                    addition += int.Parse(numberString.Substring(i, 1));
                    Console.Write(numberString.Substring(i, 1));
                    if(i < NUMBER_SIZE - 1)
                    {
                        Console.Write(" + ");
                    }
                }
                Console.Write(" = " + addition);
            }
            else
            {
                Console.WriteLine("El numero debe tener " + NUMBER_SIZE + " digitos");
            }
        }
    }
}
