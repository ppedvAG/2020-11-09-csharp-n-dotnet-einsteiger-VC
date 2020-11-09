using System;

namespace M04_UE_Mini_Rechner
{
    class URechner
    {
        static void Main(string[] args)
        {
            Console.Write("Bitte geben Sie eine Integer-Zahl ein: ");
            int intZahl = int.Parse(Console.ReadLine());
            Console.Write("Bitte geben Sie eine Double-Zahl ein: ");
            double doubleZahl = double.Parse(Console.ReadLine());
            int intSumme = intZahl + (int)doubleZahl;
            double doubleSumme = intZahl + doubleZahl;

            Console.WriteLine($"{intZahl} + {doubleZahl} als Integer = {intSumme}");
            Console.WriteLine($"{intZahl} + {doubleZahl} als Double = {doubleSumme}");

            //Console.WriteLine($"{Math.Max(intZahl, (int)doubleZahl)} / {Math.Min(intZahl, (int)doubleZahl)} = {Math.Max((double)intZahl, doubleZahl) / Math.Min((double)intZahl, doubleZahl)}");
            Console.WriteLine($"{Math.Max(intZahl, doubleZahl)} / {Math.Min(intZahl, doubleZahl)} = " +
                $"{ Math.Max(intZahl, doubleZahl) / Math.Min(intZahl, doubleZahl)}");
             Console.ReadKey();
        }

        // todo double / double ??? von Nico
        //var v2 = 0;
        //if (i1 > d1)
        //{​​​​
        //     double i1AsDouble = (double)i1;
        //    v2 = i1AsDouble / d1;
        //}​​​​
        // else {​​​​ v2 = ((double)d1) / ((double)i1); }​​​​ 
        //Console.WriteLine(v2);
    }
}
