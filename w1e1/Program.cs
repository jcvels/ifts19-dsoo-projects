using System;

/* CONSIGNA: El precio de los productos no tiene incluido el incremento del 15% que representa la ganancia del negocio.
 * El algoritmo debe calcular el precio final a abonar por un cliente.
 * Se ingresa el precio del producto y como resultado muestra el precio de venta. */

namespace w1e1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double UTILITY = 0.15;
            double basicPrice = 0;
            double priceWUtilities = 0;
            Console.Write("Ingresar el precio del producto: $");
            basicPrice = float.Parse( Console.ReadLine() );
            priceWUtilities = basicPrice * (1 + UTILITY);
            Console.WriteLine("El precio final es: $" + priceWUtilities);
        }
    }
}
