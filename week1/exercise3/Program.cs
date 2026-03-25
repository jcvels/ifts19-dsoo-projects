/* Modifica la salida de la resolución del punto 2.
 * Se pide mostrar un mensaje que indique si cada participante llegó a la última etapa o no. */

using System;

namespace exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int JUDGE_QTTY = 3;
            string EXIT_STATMENT = "FIN";
            int REQUIRED_POINTS = 80;
            string name = "";
            string message = "";
            int pointsAcumulate = 0;
            while (name != EXIT_STATMENT)
            {
                Console.Write("Ingrese el nombre del participante: ");
                name = Console.ReadLine().ToUpper();
                if (name != EXIT_STATMENT)
                {
                    for (int i = 0; i < JUDGE_QTTY; i++)
                    {
                        Console.Write("Ingrese el puntaje del juez #" + i + ": ");
                        pointsAcumulate += int.Parse(Console.ReadLine());
                    }
                    message = "Participante: " + name + " Puntaje: " + pointsAcumulate + " Ultima etapa: ";
                    if(pointsAcumulate >= REQUIRED_POINTS) {
                        message += "SI";
                    }
                    else {
                        message += "NO";
                    }
                    Console.WriteLine(message + "\n\n");
                }
            }
        }
    }
}
