using System;
using System.Linq;

namespace M07_UE_Lotto
{
    class ULotto
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LOTTO");

            // 3 Zahlen vom Benutzer abfragen
            int[] userNumbers = new int[3];
            Console.WriteLine($"numbers: {userNumbers.Length}");
            int i = 0;
            do
            {
                Console.Write("Bitte geben Sie eine Zahl zwischen 1 und 10 ein: ");
                userNumbers[i] = int.Parse(Console.ReadLine());
                i++;
            } while (i < userNumbers.Length);
            Console.WriteLine($"Sie haben eingegeben: {userNumbers[0]}, {userNumbers[1]}, {userNumbers[2]}");

            // 3 Zufallszahlen erzeugen
            int[] randomNumbers = new int[3];
            int erraten = 0;
            Random generator = new Random();
            int zufallsZahl;
            for (int index = 0; index < randomNumbers.Length; index++)
            {
                zufallsZahl = generator.Next(1, 11);
                // Zufallszahlen dürfen nicht zweimal forkommen
                if (!randomNumbers.Contains(zufallsZahl))
                    randomNumbers[index] = zufallsZahl;
                else
                    index--;
                Console.WriteLine($"{index + 1}. Gewinnzahl: {randomNumbers[index]}");
                if (userNumbers.Contains(randomNumbers[index]))
                {
                    erraten++;
                }
            }

            Console.WriteLine("\nSie haben {0} Zahlen erraten.", erraten);

            Console.ReadKey();
        }
    }
}
