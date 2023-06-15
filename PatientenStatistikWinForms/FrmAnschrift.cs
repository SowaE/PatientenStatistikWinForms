using System;
using System.Data.Common;
using System.Windows.Forms;
using Db_Schicht;

namespace PatientenStatistikWinForms
{
    /// <summary>
    /// Muster für eine einfache datenhaltende WinForms-Klasse, deren Objekte in ComboBox-
    /// oder ListBox-Controls anderer Klassen angezeigt werden
    /// </summary>
    
    public partial class FrmAnschrift : Form, IDbReadWriteDelete
    {
        #region Deklarationen, Konstruktoren und DataHasChanged

        public int AnschriftID { get; private set; } = 0; // der PK der Datenbanktabelle

        protected bool wasDataChanged = false; // hat der Benutzer seit dem letzten Speichern Daten geändert?

        // Der Standard-Konstruktor ist unbedingt notwendig für den Designer
        public FrmAnschrift()
        {
            InitializeComponent();
        }

        // Mit diesem Konstruktor kann man dem Objekt beim Erstellen Zusatzinfos mitgeben,
        // zumindest den Db-Datensatz zum Initialisieren der Daten im WinForms-Objekt
        public FrmAnschrift(DbDataReader reader): this() // eigenen Standard-Konstruktor aufrufen
        {
            if (reader != null)
                DbReadRecord(reader);
        }

        // wird bei Änderung irgendeines Wertes im Objekt aufgerufen (kann auch in 
        // abgeleiteten Klassen per Code mit += registriert werden). Es sollten so viele
        // Verweise vorhanden sein wie es datenhaktende Steuerelemente gibt.
        protected void DataHasBeenChanged(Object sender, EventArgs e)
        {
            wasDataChanged = true;
        }

        #endregion

        #region Methoden des Interfaces IDbReadWriteRecord und FormClosing-EventHandler-Methode

        /// <summary>
        /// Liest den aktuellen Datensatz von "reader" in die Steuerelemente ein und setzt die AnschriftID
        /// </summary>
        /// <param name="reader">Enthält im aktuellen Datensatz die in das Objekt zu übertragenden Daten</param>
        public virtual void DbReadRecord(DbDataReader reader)
        {
            AnschriftID = Convert.ToInt32(reader["AnschriftID"]);
            txtStrasse.Text = reader["Strasse"].ToString();
            txtHausNr.Text = reader["HausNr"].ToString();
            txtLand.Text = reader["Land"].ToString();
            txtPLZ.Text = reader["PLZ"].ToString();
            txtOrt.Text = reader["Ort"].ToString();
            wasDataChanged = false;
        }

        /// <summary>
        /// Speichert die Objektdaten in einem bestehenden (UPDATE-Anweisung, wenn AnschriftID > 0) oder 
        /// neuen (INSERT-Anweisung, wenn AnschriftID == 0) Datensatz der Tabelle Anschrift. Im letzten
        /// Fall wird die neue AnschriftID gesetzt.
        /// Tritt ein Fehler auf (z.B. NOT-NULL-Spalte ist leer), wird eine Exception geworfen.
        /// </summary>
        public virtual void DbWriteRecord()
        {
            AnschriftID = DbSchicht.WriteRecord("Anschrift", AnschriftID,
                ("Strasse", txtStrasse.Text, txtStrasse), 
                ("HausNr", txtHausNr.Text, txtHausNr),
                ("Land", txtLand.Text, txtLand), 
                ("PLZ", txtPLZ.Text, txtPLZ),
                ("Ort", txtOrt.Text, txtOrt));

            wasDataChanged = false;
        }

        /// <summary>
        /// Löscht den Datensatz mit der AnschriftID, falls diese größer 0 ist.
        /// Tritt ein Fehler auf, wird eine Exception geworfen.
        /// </summary>
        public void DbDeleteRecord()
        {
            DbSchicht.DeleteRecord("Anschrift", AnschriftID);
            // Datensätze von abgeleiteten Klassen werden mitgelöscht
        }

        /// <summary>
        /// Diese Ereignisbehandlermethode kümmert sich um das Speichern vor dem Schließen 
        /// des Formulars. Sie muss nicht überschrieben werden, funkioniert also auch in 
        ///  abgeleiteten Klassen)
        /// Wichtig: Die Methode muss im FormClosing-Event registriert sein
        /// </summary>
        /// <param name="sender">der Auslöser des Events</param>
        /// <param name="e">setzt man e.Cancel auf true, wird das Fenster nicht geschlossen</param>
        public void FrmAnschrift_FormClosing(object sender, FormClosingEventArgs e)
        {
            DbSchicht.FormClosing(this, wasDataChanged, e);
        }

        #endregion

        #region Properties zum Anzeigen des Objekts in einer ComboBox oder ListBox
        public virtual string DisplayMember
        {
            get
            {   // individuell je nach Klasse implementieren
                return $"{this.GetType().Name.Substring(3)} {txtStrasse.Text} {txtHausNr.Text}, {txtLand.Text} {txtPLZ.Text} {txtOrt.Text}";
            }
        }

        public FrmAnschrift ValueMember
        {
            get
            {
                return this; // direkt das aktuelle Objekt in der List- oder ComboBox-Zeile speichern
            }
        }

        #endregion
    }
}
