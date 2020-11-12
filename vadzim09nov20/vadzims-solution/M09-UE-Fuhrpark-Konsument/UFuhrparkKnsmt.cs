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


            Console.ReadLine();

        }
    }
}
