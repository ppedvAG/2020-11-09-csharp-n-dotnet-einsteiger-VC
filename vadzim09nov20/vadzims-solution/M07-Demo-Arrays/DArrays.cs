using System;
using System.Linq;

namespace M07_Demo_Arrays
{
    class DArrays
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ARRAYS");

            // ========================================
            Console.WriteLine("Leeres Array - wird mit default-Werten für entsprechendes Datentyp befüllt");
            int[] intArray = new int[2];
            foreach (var item in intArray)
            {
                Console.WriteLine(item);
            }


            // ========================================
            Console.WriteLine("Array befüllen");
            intArray[0] = 2;
            intArray[1] = 6;

            foreach (int item in intArray)
            {
                Console.WriteLine(item);
            }


            // ========================================
            Console.WriteLine("\n Arrays für undefinierte Datentypen - nicht in C#");
            // var[] test = new var[];



            // ========================================
            Console.WriteLine("\n Array und Linq");
            int[] smallArray = new int[2];
            smallArray[0] = 3;
            Console.WriteLine($"smallArray.Last(): {smallArray.Last()}"); 
            // default-Wert wird auch von Last() berücksichtigt



            // ========================================
            Console.WriteLine("Mehrdimensionale Arrays");
            // Syntax: Var1
            // int[,] _name_ = new int[,] { {s1z1, s1z2 }, {s2z1, s2z2}, ... }

            // Syntax: Var2
            // int[,] _name_ = new int[_anzahlSpalten,_anzahlZeilen]

            // Syntax: Var3
            // int[,] _name_ = new int[_anzahlSpalten,_anzahlZeilen] { {s1z1, s1z2 }, {s2z1, s2z2}, ... }
            // Die Struktur in geschweiften Klammern muss der Anzahl von Spalten und Zeilen entsprechen!
            int[,] zweiDimArray = new int[3, 3] { { 3, 4, 6 }, { 5, 6, 7 }, { 4, 6, 9 } };
            foreach (int item in zweiDimArray)
            {
                Console.WriteLine(item);
            }



            // ========================================
            Console.WriteLine($"Länge vom mehrdimensionalen Array: dreiDimArray.Length - {zweiDimArray.Length}");

            //for (int i = 0; i < zweiDimArray.Length; i++)
            //{
            //    Console.WriteLine(zweiDimArray[i,i]);
            //}



            // ========================================
            Console.WriteLine($"zweiDimArray.Rank: {zweiDimArray.Rank}"); // 2 Dimensionen

            Console.WriteLine("Elemente vom Array mit Dimensionen ausgeben");
            if (zweiDimArray.Rank > 1)
            {
                for (int dimension = 1; dimension <= zweiDimArray.Rank; dimension++)
                    Console.WriteLine("   Dimension {0}: {1,3}", dimension,
                                      zweiDimArray.GetUpperBound(dimension - 1) + 1);
            }
            // GetUpperBound Gets the index of the last element of the specified dimension in the array.


            // ========================================
            Console.WriteLine("\n Das Array args bei der Main-Methode");
            foreach (string item in args)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
