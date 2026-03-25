/* En el campeonato estudiantil llegan a la última etapa los participantes que superen los 80 puntos.
 * El algoritmo pide el nombre de cada participante y la puntuación de los 3 jurados.
 * Debe mostrar el nombre y el puntaje total de cada participante.
 * Nota: cuando se ingrese "FIN" en el nombre del participante finaliza nuestro programa. */

using System;

namespace w1e2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int JUDGE_QTTY = 3;
            string EXIT_STATMENT = "FIN";
            string name = "";
            int pointsAcumulate = 0;
            while(name != EXIT_STATMENT)
            {
                Console.Write("Ingrese el nombre del participante: ");
                name = Console.ReadLine().ToUpper();
                if(name != EXIT_STATMENT)
                {
                    for (int i = 0; i < JUDGE_QTTY; i++) {
                        Console.Write("Ingrese el puntaje del juez #" + i + ": ");
                        pointsAcumulate += int.Parse( Console.ReadLine() );
                    }
                    Console.WriteLine("Participante: " + name + " Puntaje: " + pointsAcumulate + "\n\n");
                }
            }
        }
    }
}
