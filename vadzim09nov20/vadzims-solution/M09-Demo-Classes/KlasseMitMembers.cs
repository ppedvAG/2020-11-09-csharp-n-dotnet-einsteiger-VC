using System;
using System.Collections.Generic;
using System.Text;

namespace M09_Demo_Classes
{
    /*
    * Objekte direkt in einem Namensraum dürfen nicht:
    * - private
    * - protected
    * - protected internal
    * - private protected
    * 
    * sein
   */
    //private class KlassePrivate // so geht es nicht
    //{

    //}

    class KlasseMitMembers
    {
        // FIELDS

        public int feldPublic;

        private int feldPrivate;

        int feldOhneModifizerer;


        // PROPS

        public int PropertyPublic { get; set; }

        private int PropertyPrivate { get; set; }
        // kein Modifizierer bei Props ist dasselbe wie private
        int PropOhneModifizierer { get; set; }


        // PROPS VON LOKALEN DATENTYPEN

        public KlassePublicInAndererKlasse PropVomTypLokalerPublicKlasse { get; set; }

        // Darf nicht nach draußen sichtbar sein wegen dem privaten Datentyp
        // public KlassePrivateInAndererKlasse PropVomTypLokalerPrivateKlasse { get; set; }


        // PROPS MIT MODIFIZIERERN BEI ACCESSORS

        private int myVar; // snippet propfull tab tab

        public int MyProperty // ohne Modifizierer sind Getter & Setter public - im Gegenteil zu Klassenmitgliedern
        {
            get { return myVar; }
            set { myVar = value; }
        }
        public int PropPublicMitPrivateGet { private get; set; }
                       
        public int PropPublicMitPrivateSet { get; private set; }






        // CLASSES

        // ist in der Memberliste von Intellisense nicht aufgelistet
        public class KlassePublicInAndererKlasse
        {
            public static int PropInKlassePublicInAndererKlasse { get; set; } 
        }
        private class KlassePrivateInAndererKlasse
        {

        }

        class KlasseOhneModifiziererInAndererKlasse
        {

        }

        // METHODS

        public void MethodePublic()
        {

        }
        private void MethodePrivate()
        {

        }
        // kein Modifizierer bei Methoden ist dasselbe wie private
        void MethodeOhneModifizierer()
        {

        }
    }

}
