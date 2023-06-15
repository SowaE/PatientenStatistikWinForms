using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientenStatistikWinForms
{

    /// <summary>
    /// Dieses Interface muss von allen Windows-Forms-Klassen implementiert werden.
    /// Alle Methoden außer DbDeleteRecord müssen virtuell sein und in abgeleiteten 
    /// Klassen überschreiben werden.
    /// </summary>
    public interface IDbReadWriteDelete
    {
        // Die folgenden Methoden sind von allen WinForms-Objekten zu implementieren:

        /// <summary>
        /// Liest den aktuellen Datensatz von "reader" in die Steuerelemente eines WinForms-
        /// Objekts ein und setzt die in der Klasse als Property definierte ID aus dem PK.
        /// </summary>
        /// <param name="reader">Enthält im aktueellen Datensatz die in das Objekt zu übertragenden Daten</param>
        void DbReadRecord(DbDataReader reader);

        /// <summary>
        /// Speichert die Objektdaten in einem bestehenden (UPDATE-Anweisung, wenn die Objekt-ID > 0 ist)
        /// oder neuen (INSERT-Anweisung, wenn die Objekt-ID == 0 ist) Datensatz der Db-Tabelle, die für
        /// die aktuelle Klasse erzeugt worden ist. Wird ein neuer Datensatz eingefügt, wird die neue
        /// Objekt-ID gesetzt.
        /// Tritt ein Fehler auf (z.B. NOT-NULL-Spalte ist leer), wird eine Exception geworfen.
        /// Diese Methode wird normalerweise im FormClosing-Event aufgerufen.
        /// </summary>
        void DbWriteRecord();

        /// <summary>
        /// Löscht den Datensatz mit der aktuellen Objekt-ID, falls diese größer 0 ist.
        /// Tritt ein Fehler auf, wird eine Exception geworfen.
        /// Bitte die Löschweitergaben (ON DELETE CASCADE) beachten.
        /// </summary>
        void DbDeleteRecord();
    }
}
