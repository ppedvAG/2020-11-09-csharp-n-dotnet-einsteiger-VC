using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M10_Demo_FileAccess_Und_Serializierung
{
    public class Transportmittel
    {
        // types
        enum Zustand { aus, an }

        // props
        // Wird der Wert in einer Methode gesetzt, dann braucht man den Setter
        // Wird der Wert gleich im Konstruktor gesetzt, braucht man keinen Setter
        // Muss nicht public sein, weil BeschreibeMich den Wert ausgibt
        // diese Prop kann auch als Feld angelegt werden
        // Will man diese Eigenschaft direkt ansprechen, ohne BeschreibeMich(), muss es public Prop bleiben
        string Modell { get; }

        // Es gibt keine Methode, wo der Preis geändert wird, 
        // Es ist einfacher, wenn Preis als Property angelegt ist
        public double Preis { get; set; }
        uint maximalGeschwindigkeit;
        // Will man diese Eigenschaft direkt ansprechen, ohne BeschreibeMich(), muss es public Prop bleiben
        public uint AktuelleGeschwindigkeit { get; private set; }
        // Muss nicht als Prop angelegt werden, weil gesetzt und gelesen wird es in den Methoden der Klasse
        Zustand FZustand;

        // ctor
        public Transportmittel(string name, double preis, uint maxGeschwindigkeit)
        {
            Modell = name;
            Preis = preis;
            maximalGeschwindigkeit = maxGeschwindigkeit;
            FZustand = Zustand.aus;
            AktuelleGeschwindigkeit = 0;
        }

        // methods
        public uint Beschleunige(uint erhöhung)
        {
            uint möglicheErhöhung = maximalGeschwindigkeit - AktuelleGeschwindigkeit;
            if (AktuelleGeschwindigkeit < maximalGeschwindigkeit)
            {
                if (FZustand == Zustand.an)
                {
                    if (erhöhung <= möglicheErhöhung)
                    {
                        AktuelleGeschwindigkeit += erhöhung;
                    }

                }
            }
            else
                AktuelleGeschwindigkeit = maximalGeschwindigkeit;
            Console.WriteLine("Beschleunigen von Transportmittel");
            return AktuelleGeschwindigkeit;
        }

        public void StarteMotor()
        {
            FZustand = Zustand.an;
        }

        public void StoppeMotor()
        {
            FZustand = Zustand.aus;
        }

        public virtual string BeschreibeMich()
        {
            return $@"
{Modell}, ({Preis} €)
Maximale Geschwindigkeit: {maximalGeschwindigkeit} km/h
Zustand: {FZustand}
Aktuelle Geschwindigkeit: {AktuelleGeschwindigkeit}";
        }

    }
}
