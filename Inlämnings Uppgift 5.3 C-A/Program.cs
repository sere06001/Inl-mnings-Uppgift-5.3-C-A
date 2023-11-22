using System;
namespace Uppgift5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] frågor = new string[4] {"Vad heter Sveriges huvudstad?", "Vad heter Tysklands huvudstad?", "Vad heter Polens huvudstad?", "Vad heter Frakrikes huvudstad?"};
            string[] svar = new string[4] {"Stockholm", "Berlin", "Helsinki", "Paris"};
            Console.WriteLine("Ange ett tal mellan 1 och 4.");
            int fråga = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine(frågor[fråga-1]);
            Console.WriteLine("1: "+svar[0] + "    " + "2: "+svar[1]);
            Console.WriteLine("3: " + svar[2] + "     " + "4: " + svar[3]);
            int inputSvar = int.Parse(Console.ReadLine());

            if (inputSvar == fråga)
            {
                Console.WriteLine("Du svarade rätt!");
            }
            else
            {
                Console.WriteLine("Du svarade fel!");
            }
            Console.ReadKey();
        }
    }
}