using System;
using System.Collections.Generic;
using System.Text;

namespace M09_UE_Fuhrpark_Bibliothek
{
    interface IKannAndereTransportieren
    {
        Transportmittel[] AktTransMittelLadung { get; set; }
        public int AktLadungAnzahl { get; set; }
        int MaxTransMittelLadung { get; set; }

        /// <summary>
        /// Methode, die ein Array von Transportmitteln in die Prop AktTranMittelLadung hinzufügt.
        /// </summary>
        /// <param name="transport">Array von Transportmitteln, welchen an das Array AktTransMittelLadung angekettet werden soll</param>
        /// <returns>AktLadungAnzahl</returns>
        int Belade(Transportmittel[] transport);

        /// <summary>
        /// Methode, die die gewünschten Transportmittel aus dem Ladung-Array rausnimmt.
        /// </summary>
        /// <param name="transportsZuEntladen">Objekte, die aus dem Ladungsarray gelöscht werden sollen</param>
        /// <returns>Anzahl von Elementen im neuen Array
        /// </returns>
        int Entlade(Transportmittel[] transportsZuEntladen);
    }
}
