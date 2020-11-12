using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace M09_UE_Fuhrpark_Bibliothek
{
    public class Flugzeug : Transportmittel, IKannAndereTransportieren
    {
        public int MaxFlugHöhe { get; set; }
        public int GeflogeneKm { get; set; }
        public int MaxLadung { get; set; }
        public Transportmittel[] AktTransMittelLadung { get; set; }
        public int AktLadungAnzahl { get; set; }
        public int MaxTransMittelLadung { get; set; }

        public Flugzeug(string name, double preis, uint maximalGeschwindigkeit, int maximalFlugHöhe, int geflogeneKm) : base(name, preis, maximalGeschwindigkeit)
        {
            MaxFlugHöhe = maximalFlugHöhe;
            GeflogeneKm = geflogeneKm;
        }

        public override string BeschreibeMich()
        {
            return base.BeschreibeMich() + $"\nMaxFlugHöhe: {MaxFlugHöhe}";
        }

        public int Belade(Transportmittel[] transport)
        {
            foreach (var item in transport)
            {
                Console.WriteLine("Array in Belade()");
                Console.WriteLine(item);
            }
            // das brauchen wir, damit das Array bei neu angelegten Instanzen kein null ist
            // ist es ein null, wirft Concat() später eine Exception
            // Empty ist nicht gleich null!
            if (AktTransMittelLadung is null)
                AktTransMittelLadung = Array.Empty<Transportmittel>();
            Transportmittel[] neueLadung = AktTransMittelLadung.Concat(transport).ToArray();
            if (neueLadung.Length <= MaxTransMittelLadung)
            {
                AktTransMittelLadung = neueLadung;
                AktLadungAnzahl = AktTransMittelLadung.Length;
            }
            else
            {
                Console.WriteLine("Das Beladen ist Fehlgeschlagen");
            }
            return AktLadungAnzahl;
        }

        public int Entlade(Transportmittel[] transportsZuEntladen)
        {
            Transportmittel[] neueLadung = AktTransMittelLadung;
            foreach (var item in transportsZuEntladen)
            {
                neueLadung = neueLadung.Where(el => el != item).ToArray();
            }
            AktTransMittelLadung = neueLadung;
            AktLadungAnzahl = AktTransMittelLadung.Length;
            return AktLadungAnzahl;
        }
    }
}
