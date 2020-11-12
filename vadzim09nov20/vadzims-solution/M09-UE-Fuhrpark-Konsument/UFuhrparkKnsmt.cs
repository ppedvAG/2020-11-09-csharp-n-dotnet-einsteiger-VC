using M09_UE_Fuhrpark_Bibliothek;
using System;

namespace M09_UE_Fuhrpark_Konsument
{
    class UFuhrparkKnsmt
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Transportmittel transport = new Transportmittel("BMW", 4365.345, 200);

            // Bemerkung zu statischen Methoden / Memebers
            // transport.kmToMilesAndOtherWayBack(4.33, "miles"); // nicht möglich über Instanzverweis, weil Methode static
            double km = Transportmittel.kmToMilesAndOtherWayBack(4.33, "miles");

            PKW audiPKW = new PKW("Audi", 20000.30, 240, 5, 3000);

            // Bemerkung zu 'virtual & override' Methoden und Methoden mit 'new'
            Console.WriteLine(@$"
BeschreibeMich von Transportmittel transport:
{transport.BeschreibeMich()}
");
            Console.WriteLine(@$"

BeschreibeMich von PKW audiPKW:
{audiPKW.BeschreibeMich()}
");

            Console.WriteLine(@$"

StarteMotor von Transportmittel transport:
");
            transport.StarteMotor();

            Console.WriteLine(@$"

StarteMotor von PKW audiPKW:
");
            audiPKW.StarteMotor();

            Transportmittel audiTransportmittel = new PKW("Audi", 20000.30, 240, 5, 3000);

            Console.WriteLine(@$"

StarteMotor von Transportmittel audiTransportmittel (mit Konstruktor von PKW):
");
            audiTransportmittel.StarteMotor();


            Console.WriteLine(@$"
BeschreibeMich von Transportmittel audiTransportmittel (mit Konstruktor von PKW):
{audiTransportmittel.BeschreibeMich()}
");

            Flugzeug flugzeug = new Flugzeug("Boeing", 2_000_000.34, 400, 11, 34_999);
            Transportmittel transport1 = new Transportmittel("Auto", 100_000.00, 230);
            // ================================================
            Console.WriteLine("\n\nMethode die Prüft, ob Beladen möglich ist");
            Console.WriteLine("BeladeWennMöglich(flugzeug, t1): {0}", BeladeWennMöglich(flugzeug, transport1));


            bool BeladeWennMöglich(Transportmittel t1, Transportmittel t2)
            {
                if (t1 is Flugzeug && t2 is PKW)
                {
                    // Belade() ist nicht bei Transportmittel dabei
                    // Casting notwendig
                    // ((Flugzeug)t1).Belade(new Transportmittel[] { t2 });
                    // oder den Typ anpassen
                    (t1 as Flugzeug).Belade(new Transportmittel[] { t2 });
                    return true;
                }
                else if (t1 is PKW && t2 is Flugzeug)
                {
                    (t2 as Flugzeug).Belade(new Transportmittel[] { t1 });
                    return true;
                }
                else
                {
                    return false;
                }
            }


            Console.ReadLine();

        }
    }
}
