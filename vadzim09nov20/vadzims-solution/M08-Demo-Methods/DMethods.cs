using System;
using System.Linq;

// using ausgelagerte_Methoden;

namespace M08_Demo_Methods
{
    class DMethods
    {
        static void Main(string[] args)
        {
            Console.WriteLine("METHODS & FUNCTIONS");

            Console.WriteLine("\n in, out, ref");


            // Console.WriteLine(variable); erst nach der Deklaration möglich
            int variable = 4;


            // Methoden dürfen for ihrer Definition aufgerufen werden.


            // ====================================
            // Console.WriteLine("\nMethoden in eine andere Datei auslagern");
            // Console.WriteLine(ausgelagerte_Methoden.giveSix());


            // Szenario: Der Methode wird ein Array übergeben, um Duplikate im Array zu ersetzen

            int[] numbers = new int[] { 4, 7, 2, 2, 5 };

            // Aufruf einer Statischen Methode ist innerhalb derselben Klasse möglich
            int[] result = ReplaceDuplicateClassic(numbers);
            Console.WriteLine($"Arrayvariable direkt: result - {result}"); // System.Int32[]
            foreach (var item in result)
            {
                Console.WriteLine($"results item: {item}");
            }


            // ====================================
            Console.WriteLine("\nAufruf einer Methode mit out"); 
            // Variante 1: out Variable direkt beim Aufruf anlegen
            result = ReplaceDuplicateAndGiveNewLength(numbers, out int l);
            foreach (var item in result)
            {
                Console.WriteLine($"results item: {item}");
            }
            Console.WriteLine($"{l}");



            // Variante 2: out Variable vor dem Aufruf anlegen
            int lng;
            result = ReplaceDuplicateAndGiveNewLength(numbers, out lng);
            foreach (var item in result)
            {
                Console.WriteLine($"results item: {item}");
            }
            Console.WriteLine($"{lng}");           


            // Beenden von der Konsole
            Console.ReadLine();
        }

        static int[] ReplaceDuplicateClassic(int[] zahlen)
        // Als Overload wäre es auch möglich
        //static int[] ReplaceDuplicate(int[] zahlen)
        {
            int[] ohneDuplikate = zahlen.Distinct().ToArray();
            // Distinct Returns distinct elements from a sequence by using the default equality comparer
            //     to compare values.
            return ohneDuplikate;
        }

        static int[] ReplaceDuplicateAndGiveNewLength(int[] zahlen, out int länge)
        // Als Overload wäre es auch möglich
        //static int[] ReplaceDuplicate(int[] zahlen, out int länge)
        {
            int[] ohneDuplikate = zahlen.Distinct().ToArray();
            länge = ohneDuplikate.Length;
            return ohneDuplikate;
        }
    }

    //class TestProgram
    //{
    //    Program myProgram = new Program();
    //    Program.Main(new string[] strings);
    //    Program.ReplaceDuplicateClassic();
    //}
}
