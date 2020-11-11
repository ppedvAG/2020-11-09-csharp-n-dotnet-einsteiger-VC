using System;

namespace M09_Demo_Classes
{
    class DClasses
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CLASSES");

            // ==============================================================
            // _datentyp_ _variablenname_ = _wert_
            PersonOhneCtor personOhneCtor = new PersonOhneCtor();
            // Auch wenn in der Klasse kein Konstruktor definiert, 
            // darf man den automatischen Ktor verwenden
            Console.WriteLine($"personOhneCtor: {personOhneCtor}"); // M09_Demo_Classes.PersonOhneCtor
            personOhneCtor.Vorname = "Max";
            personOhneCtor.Nachname = "Mustermann";



            // ==============================================================
            // Andere Methoden kommen von der Klasse Object
            personOhneCtor.ToString();
            PersonOhneCtor personOhneCtor1 = new PersonOhneCtor();
            personOhneCtor1.Vorname = "Max";
            personOhneCtor1.Nachname = "Mustermann";

            Console.WriteLine("\n Vergleicht man komplexe Datentypen mit ==, kommt immer false zurück");
            Console.WriteLine(personOhneCtor == personOhneCtor1 ? "gleich" : "ungleich");

            Console.WriteLine("\n Objekte verden mit Equals() verglichen");
            Console.WriteLine(Object.Equals(personOhneCtor, personOhneCtor1) ? "equal" : "not equal");

            Console.WriteLine(Object.ReferenceEquals(personOhneCtor, personOhneCtor1) ? "ref equal" : "ref not equal");

            // Wie kriegt man raus, dass die Werte doch gleich sind?
            Console.WriteLine(personOhneCtor.Equals(personOhneCtor1) ? "equal (not static)" : "not equal (not static)");

            // todo 



            // ==============================================================
            personOhneCtor1 = personOhneCtor;
            Console.WriteLine("\n Vergleich nach der Referenzübergabe mit ==");

            Console.WriteLine(personOhneCtor == personOhneCtor1 ? "gleich" : "ungleich"); // gleich

            Console.WriteLine("\n Vergleich nach der Referenzübergabe mit Equals()");
            Console.WriteLine(Object.Equals(personOhneCtor, personOhneCtor1) ? "equal" : "not equal"); // equal



            // ==============================================================
            Console.WriteLine("\n Anlegen von Instanzen einer Klasse mit Ktor");

            PersonMitCtor personMitCtor = new PersonMitCtor("Kowalski");
            Console.WriteLine(personMitCtor.Nachname);

            // kann ich hier auch den leeren Ktor verwenden?
            // PersonMitCtor personMitCtor1 = new PersonMitCtor(); // nein, weil der auto-Ktor wurde überschrieben



            // ==============================================================
            PersonMitCtorUndAdresse mitCtorUndAdresse = new PersonMitCtorUndAdresse("Müller", "Hauptstraße 1");



            // ==============================================================
            Console.WriteLine("\n\n MODIFIER");
            Console.WriteLine("\n Modifizierer von Mitgliedern einer Klasse");
            // Elemente mit dem Modifizierer private sind nur in dem Scope verfügbar, wo sie angelegt sind
            KlasseMitMembers klasseMitMembers = new KlasseMitMembers();


            // Durch Intellisens schau nach, welche Member von dieser Variable hier verfügbar sind
            // klasseMitMembers.


            // KlassePublicInAndererKlasse // ist in einer anderen Klasse im gleichen Namensraum nicht verfügbar


            Console.WriteLine("\n Modifizierer von Klassen im gleichen Namensraum");

            KlasseOhneModifizierer klasseOhneModifizierer = new KlasseOhneModifizierer(); // verfügbar
            KlassePublic klassePublic = new KlassePublic(); // verfügbar
            KlasseInternal klasseInternal = new KlasseInternal(); // verfügbar



            Console.WriteLine("\n Modifizierer von Getter & Setter / Accessors einer Prop in einer anderen Klasse");
            klasseMitMembers.PropPublicMitPrivateGet = 9; // geht
            // klasseMitMembers.PropPublicMitPrivateSet = 3; // von hier nicht änderbar, weil Setter private ist. Nur innerhalb der Klasse



            Console.ReadLine();
        }
    }

    class PersonOhneCtor
    {
        public string Nachname { get; set; }
        // internal - sichtbar innerhalb vom gleichen Namensraum
        internal string Vorname { get; set; }
        private int Alter { get; set; }
    }

    class PersonMitCtor
    {
        public string Nachname { get; }
        // Konstruktoren
        // Szenario: für eine Eigenschaft ist in einer DB kein Null-Wert erlaubt. 
        // Durch den Ktor verhindern, dass diese Eigenschaft bei Klasseninstanzen ohne Wert bleibt.
        public PersonMitCtor(string nachname)
        {
            Nachname = nachname;
        }
        // will man einen leeren Ktor weiterhin verwenden, muss er hier explizit definiert werden
        //public PersonMitCtor()
        //{
        //}
    }

    // z.B Klasse Mitarbeiter kann man von Klasse Person ableiten
    // Jeder Mitarbeiter ist eine Person 
    class PersonMitCtorUndAdresse : PersonMitCtor
    {
        public string Adresse { get; set; }
        // ctor tab tab 
        public PersonMitCtorUndAdresse(string nachname, string adresse) : base(nachname)
        {
            Adresse = adresse;
        }
    }

    class PersonMitFeldern
    {

    }
}
