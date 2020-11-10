using System;

namespace M02_Demo_Scopes
{
    // private string flyOverClasses = "Ich will Freiheit genießen";

    class DScopes
    {
        // Scopes / Gültigkeitsbereiche / Kontexte - Grenzen für Sichtbarkeit / Gültigkeit einer Variable
        // Was ist eine Variable - irgendwas mit einem Bezeichner (Identifier, Nanem), 
        // vom Programmieren vergeben, 
        // was zum Abfangen von bestimmten Werten gedacht ist
        // Beispiele für Variablen:
        int i;
        string str = "sharing is caring, klassenweit sichtbar";
        static Random generator = new Random();
        const double pi = Math.PI;

        // Wo lege ich meine Variable an?
        // Prinzip: den Gültigkeitsbereich von Variable so weit wie nötig zu halten
        // STELLE nr 1:
        // wird eine Variable nur innerhalb einer Methode gebraucht, 
        // muss sie direkt dort angelegt werden
        // siehe varFürMain, oder varFürHier
        // die Argumentvariablen ohne out/ref sind auch nur innerhalb einer Methode sichtbar
        // die Methodenvariablen haben keine Modifizierer (public etc)


        // STELLE nr 2:
        // soll eine Variable für mehrere Methoden zur Verfügung stehen
        // wird sie eine Ebene höher, außerhalb der Methode definiert
        // siehe str, i, generator
        // soll so eine Variable auch für statische Methoden nutzbar sein,
        // bekommt sie auch den Modifizierer static


        // STELLE nr 3:
        // in Schleifen / if-Abfragen, sprich Kontrollstrukturen


        // STELLE nr 4:
        // eigene geschweiften Klammern, wenn ein umschließendes Scope zu groß erscheint


        // STELLE nr 5?:
        // Direkt in Namensräumen ist in .NET nicht möglich
         

        // Für alle Stellen: Variablen dürfen erst nach ihrer Deklaration / Initialisierung
        // genutzt werden

        static void Main(string[] args)
        {
            Console.WriteLine("SCOPES");
            string varFürMain = "ich möchte nur in Main sichtbar sein";

            // Variable aus der Klasse für alle Methoden
            Console.WriteLine(generator.Next(3, 6));

            // Variable in einer Schleife
            for (int iterator = 0; iterator < 5; iterator++)
            {
                Console.WriteLine($"i ist nur in for-Schleife sichtbar: {iterator}");
            }
            // Console.WriteLine($"i, komm her {iterator}"); // ist außerhalb der for-Schleife nicht verfügbar
            //while (true)
            //{
            //    bool nurFürWhile = false;
            //}

            { int eineBesonderheit = 4; }
            // { eineBesonderheit = 5; }
        }

        static void WeitereMethodeInDScopes()
        {
            // Console.WriteLine(varFürMain); // ist hier nicht verfügbar
            // der Name varFürMain darf hier als Bezeichner benutzt
            // kann aber iritierend seind

            string varFürHier = "nimm mich hier";
            Console.WriteLine(varFürHier);

            // Variable aus der Klasse für alle Methoden
            Console.WriteLine(generator.Next(4, 10));
        }
    }
}
