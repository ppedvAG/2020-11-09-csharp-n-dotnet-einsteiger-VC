using System;

namespace M04_Demo_Numbers
{
    class DNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INTEGER");

            Console.WriteLine("\n Literals");

            int i1 = 3;
            int i2 = 0b00110011; // binär
            int i3 = 0x236FAC;
            Console.WriteLine($"i1: {i1}, i2: {i2}, i3: {i3}");

            // ====================================================
            Console.WriteLine("\n Default bei int ist 0");


            // ====================================================
            int i4 = 4;
            Console.WriteLine($"i4.GetType(): {i4.GetType()}"); // System.Int32

            // ====================================================
            Console.WriteLine("\n Int Min & Max");
            Console.WriteLine($"Int32.MaxValue: {Int32.MaxValue}");

            // int i5 = 2_147_483_647 + 1; // Overload exception
            int i6 = Int32.MaxValue;
            int i7 = i6 + 2; // Overload wird nicht erkannt, wenn die Werte nicht als Literals zugewiesen werden
            Console.WriteLine($"i7: {i7}"); // -2147483647


            // ====================================================
            // Will man Exceptions bei Overloads haben, dann checked{} verwenden
            checked
            {
                // int i8 = i6 + 3;
                // Console.WriteLine($"i8: {i8}"); // System.OverflowException: 'Arithmetic operation resulted in an overflow.'
            }



            // ====================================================
            // ====================================================

            Console.WriteLine("\n\nDOUBLE");

            // ====================================================
            Console.WriteLine("\n Literals");
            double d1 = 3.222;
            Console.WriteLine($"d1 = 3.222: {d1}"); // 3,222

            float f1 = 3.222F; // Suffix, weil 3.222 ein double-Literal ist

            double d2 = 3.4D; // Suffix D, um eindeutig von anderen Kommazahlen zu unterscheiden.


            // ====================================================
            Console.WriteLine("\nString zu Double parsen");
            //Console.WriteLine("\nGeben Sie einen DoubleWert ein: ");
            //double d3 = double.Parse(Console.ReadLine());
            //Console.WriteLine($"d3: {d3}"); 
            // bei 3.4 -> 34
            // bei 3,4 -> 3,4

            //Console.WriteLine("\nParse & Culture");
            //Console.WriteLine("Geben Sie noch einen DoubleWert mit Punktnotation ein: ");
            //double d4 = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
            //Console.WriteLine($"d4: {d4}");
            // bei 3.4 -> 3,4 
            // bei 3,4 -> 34
            // Bei default benutzt Parse() CurrentCulture

            //Console.WriteLine("\nConvert.ToDouble()");
            //Console.WriteLine("Geben Sie noch einen DoubleWert mit Punktnotation ein: ");
            //double d5 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine($"d5: {d5}"); 
            // bei 3.4 -> 34
            // bei 3,4 -> 3,4

            // ====================================================
            #region DoubleKommaPunkt
            //// - Frage von Peter: 
            //// - wie kann ich Strings sowohl mit Punkt als auch mit Komma in ein Double parsen
            //Console.WriteLine("\ndouble.TryParse()");
            //Console.WriteLine("Geben Sie noch einen DoubleWert ein: ");
            //double d6;
            //var input = Console.ReadLine();
            //Console.WriteLine($"input: {input}");
            //// - TryParse() liefert true zurück, wenn beim Parse() ein double rauskommen würde
            //// - TryParse() liefert true sowohl bei 3,4, als auch bei 3.4
            //if (double.TryParse(input, out d6))
            //{
            //    if (input.Contains('.'))
            //        d6 = double.Parse(input, System.Globalization.CultureInfo.InvariantCulture);
            //    else
            //        d6 = double.Parse(input);
            //}
            //else
            //{
            //    Console.WriteLine("Es war keine Zahl mit Punkt- oder Kommanotation");
            //}
            //Console.WriteLine($"d6: {d6}");
            #endregion DoubleKommaPunkt



            // ====================================================
            #region DoublesDivision
            // - Frage von von Nico:
            // - double / double ??? 
            // Console.WriteLine("\nDouble divided through double");
            var v2 = 0;
            int int1 = 4;
            double double1 = 4.4;
            // - Funktioniert der /-Operator überhaupt mit double?            
            // v2 = int1 / double1; // Der Typ 'double' kann nicht implizit zu 'int' konvertiert werden

            // - int durch double, konvertiert zu int:
            // v2 = int1 / (int)double1; // Funktioniert, v2 ist gleich 1

            // - int, konvertiert zu double, geteilt durch double:
            // v2 = (double)int1 / double1; // Der Typ 'double' kann nicht implizit zu 'int' konvertiert werden
            // Console.WriteLine($"v2: {v2}");

            // - es liegt daran, dass die Variable v2 als 'int' durch den Wert 0 initialisiert wurde.
            // - Das heißt, der Datentyp darf sogar bei 'var'-Variablen nach dem ersten Initialisieren 
            // nicht mehr geändert werden, nur durch Konvertieren.

            var var3 = 0.0;
            // var3 = (double)int1 / double1; // Funktioniert. Konvertierung ist redundant, weil int zu double wird implizit konvertiert
            var3 = int1 / double1;
            // Console.WriteLine($"var3: {var3}"); // 0,9090909090909091
            #endregion DoublesDivision


            #region VergleichIntDouble
            Console.WriteLine("\nVergleich Int Double");
            // Was passiert beim Vergleich von verschiedenen Datentypen?
            // int kann implizit zu double umgewandelt werden, was hier auch durchgeführt wurde, 
            // um beide Zahlen zu vergleichen
            if (int1 <= double1) // Intellisense: bool double.operator <=(double left, double right)
            {
                Console.WriteLine("true block");
            }
            else
            {
                Console.WriteLine("false block");
            }
            #endregion VergleichIntDouble


            Console.ReadLine();
        }
    }
}
