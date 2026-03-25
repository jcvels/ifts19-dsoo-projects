/* Tres personas aportan diferente capital a una sociedad y desean saber el valor total aportado y qué porcentaje aportó cada una (indicando nombre y porcentaje).
 * Para ello, solicitar la carga por teclado del nombre de cada socio, su capital aportado y a partir de esto calcular e informar lo requerido previamente. */

using System;

namespace exercise6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int PARTNERS = 3;
            string[] names = { "","","" };
            double[] capital = { 0,0,0 };
            double total_capital = 0;
            for (int i = 0; i < PARTNERS; i++)
            {
                Console.Write("Ingrese el nombre del socio: ");
                names[i] = Console.ReadLine();
                Console.Write("Ingrese capital aportado por " +  names[i] + " : $");
                capital[i] = double.Parse( Console.ReadLine() );
                total_capital += capital[i];
            }
            for (int i = 0; i < PARTNERS; i++)
            {
                double percentage = Math.Truncate(capital[i] / total_capital * 100);
                Console.WriteLine("Socio: " + names[i].ToUpper() + " aporta: $" + capital[i] + " representa: " + percentage + "%");
            }
            Console.WriteLine("Capital total aportado: $" + total_capital);
        }
    }
}
