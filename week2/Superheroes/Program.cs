using System;

namespace Superheroes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var batman = new Superheroe("Batman", 90, 70, 0);
            var superman = new Superheroe("Superman", 95, 60, 70);
            var wonderWoman = new Superheroe("Wonder Woman", 95, 60, 70);

            Console.WriteLine("Batman vs Superman -> " + batman.competir(superman));
            Console.WriteLine("Superman vs Batman -> " + superman.competir(batman));
            Console.WriteLine("Superman vs WonderWoman -> " + superman.competir(wonderWoman));
        }
    }
}
