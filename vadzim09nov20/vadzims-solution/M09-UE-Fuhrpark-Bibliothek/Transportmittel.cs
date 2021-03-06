﻿using System;

namespace M09_UE_Fuhrpark_Bibliothek
{
    public class Transportmittel
    {
        // types
        enum Zustand { aus, an }
        enum GeschwindigkeitEinheit { km, miles }

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
            Console.WriteLine("StarteMotor von Klasse Transportmittel");
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

        // Zum Einsetzen dieser Methode siehe Fuhrpark Konsument
        public static double kmToMilesAndOtherWayBack(double wert, string einheit)
        {
            // Thema '#Enumeratoren'
            // Aufgabe: enum als Zwischenschritt einzubauen
            // enum hat zwei mögliche Werte: km und miles

            if (einheit == "miles")
                return wert * 0.46;
            else
                return wert / 0.46;
        }

    }

}
