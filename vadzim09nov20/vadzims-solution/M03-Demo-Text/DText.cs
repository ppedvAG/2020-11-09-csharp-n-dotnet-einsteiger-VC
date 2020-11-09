using System;

namespace M03_Demo_Text
{
    class DText
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LITERALS");

            Console.WriteLine("\neinfaches String");
            string str1 = "text    {DateTime.Now}  text" +
                "nächste Zeile text"; // Tabs werden übernommen, new Line aber nicht

            Console.WriteLine("str1: {0}", str1);

            // ==============================================================
            Console.WriteLine("\ninterpolation String (Dollar String)");
            string str2 = $"DateTime.Now: {DateTime.Now}"; // Von der Eigenschaft 'Now' kommt ein DateTime Objekt zurück.
            // automatisch wird dieses Objekt zu einem String umgewandelt und in das umschließende String eingebaut.
            // string test = DateTime.Now; // direkt DateTime Objekt an eine String-Variable zuzuweisen geht nicht.

            Console.WriteLine("str2: {0}", str2);

            Console.WriteLine($"str2: {str2}");

            // Mehrere Zeilen in einem Dollar-String?
            // Nein
            string str3 = $"text     text" +
                $"nächste Zeile text";
            Console.WriteLine($"str3: {str3}");

            // ==============================================================
            Console.WriteLine("\nVerbatim-String (At-String)");
            // Alle Leerräume werden übernommen. Verbatim-Strings sind deswegen vom Formatieren vom Code ausgeschlossen.
            string str4 = @"text        text
            nächste Zeile text";
            Console.WriteLine($"str4: {str4}");

            // ==============================================================
            Console.WriteLine("\nKombi von Dollar- und At-String");

            string str5 = $@"DateTime.Now: {DateTime.Now}
DateTime.MinValue: {DateTime.MinValue}
DateTime.MaxValue: {DateTime.MaxValue}";
            Console.WriteLine($"str5: {str5}");


            // ==============================================================
            Console.WriteLine("Escapes");
            string str6 = "text \text \ntext";
            Console.WriteLine($"str6: {str6}");


            Console.WriteLine("\n\nSTRING DEFAULT");

            // Default bei string ist 'null'
            string str7 = default;
            // Console.WriteLine($"str7: {str7.ToString()}"); // Exception, weil str7 ist gleich null

            // zum Vergleich Default bei int ist 0
            int int1 = default;
            Console.WriteLine($"int1: {int1.ToString()}");


            // ==============================================================
            // mit var lege ich keinen Datentyp fest
            var test1 = DateTime.Now;


            // ==============================================================
            // String - Konstruktor
            var str8 = new String("d");
            Console.WriteLine($"str8.GetType(): {str8.GetType()}"); // System.String
            Console.WriteLine($"str6.GetType(): {str6.GetType()}"); // System.String


            Console.ReadLine();
        }
    }
}
