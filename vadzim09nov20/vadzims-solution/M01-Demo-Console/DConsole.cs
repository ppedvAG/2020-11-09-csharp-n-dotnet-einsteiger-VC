using System;

namespace M01_Demo_Console
{
    class DConsole
    {

        static void Main(string[] args)
        {
            
            #region AllgemeineSyntax
            // mein Kommentar
            Console.WriteLine("Hello World!"); // Zum Schreiben einer Zeile in der Konsole

            // Mehrzeiler
            /*
             * adsf
             * asdf
             * asdf
             * asdfg
             * dfg
             */

            // Anweisungen werden mit einem Semikolon beendet

            // Geschweifte Klammern, wenn wir Definitionen für Namesnräume, Klassen, Methoden schreiben oder auch einige Kontrollstrukturen anwenden

            #endregion AllgemeineSyntax

            #region WriteLine
            // Variablen schreibt man mit kleinen Buchstaben

            // Deklaration von Variablen:
            // datentyp bezeichner = wert

            // Textwerte werden in Anführungszeichen geschrieben
            string name = "Vadzim";
            Console.WriteLine(name);


            Console.WriteLine(); // fügt neue Zeile hinzu

            Console.WriteLine("Hallo {0}", name);

            string name2 = "Helga";
            Console.WriteLine("Hallo {1} und {0}", name, name2);
            #endregion WriteLine

            #region ReadLine
            string eingabe = Console.ReadLine();
            Console.WriteLine(eingabe);
            #endregion ReadLine

            // string taste = Console.ReadKey(); // Damit kann man eine Taste ablesen

            // todo: Beenden mit Enter aber ohne ReadLine

            Console.ReadLine();
        }

    }
}
