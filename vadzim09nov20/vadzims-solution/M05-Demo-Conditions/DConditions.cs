using System;

namespace M05_Demo_Conditions
{
    class DConditions
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int i1 = 14;
            double d1 = 14.00;

            // Beim Vergleich wird der kleiner Datentyp zum größeren (z.B. int zu double) implizit erweitert
            if (i1 == d1)
            {
                Console.WriteLine("sind gleich");
            }
            else
            {
                Console.WriteLine("ungleich");
            }

            // Wenn nur eine Anweisung in den {}, dann sind sie optional
            if (i1 == d1)
                Console.WriteLine("sind gleich");
            else
                Console.WriteLine("ungleich");


            // Wenn in true und fals-Block nur eine Rückgabe erwartet wird, dann:
            Console.WriteLine(i1 == d1 ? "sind gleich" : "ungleich");


            switch (switch_on)
            {
                case
                break;
                default:
            }
            Console.ReadLine();


        }
    }
}
