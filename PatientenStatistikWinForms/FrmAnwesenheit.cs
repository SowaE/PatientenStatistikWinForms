using Db_Schicht;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientenStatistikWinForms
{
    public partial class FrmAnwesenheit : Form, IDbReadWriteDelete
    {
        #region Deklarationen, Konstruktoren und DataHasChanged

        public int AnwesenheitID { get; private set; } = 0; // der PK der Datenbanktabelle
        public int PatientID_FK { get; private set; } = 0;

        protected bool wasDataChanged = false; // hat der Benutzer seit dem letzten Speichern Daten geändert?

        // Der Standard-Konstruktor ist unbedingt notwendig für den Designer
        public FrmAnwesenheit()
        {
            InitializeComponent();
        }

        // Mit diesem Konstruktor kann man dem Objekt beim Erstellen Zusatzinfos mitgeben,
        // zumindest den Db-Datensatz zum Initialisieren der Daten im WinForms-Objekt
        public FrmAnwesenheit(DbDataReader reader, int patientID) : this() // eigenen Standard-Konstruktor aufrufen
        {
            PatientID_FK = patientID;
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
            AnwesenheitID = Convert.ToInt32(reader["AnwesenheitID"]);
            dtpAnwesenheitstag.Value = Convert.ToDateTime(reader["Anwesenheitstag"]);
            txtGrund.Text = reader["Grund"].ToString();
            PatientID_FK = Convert.ToInt32(reader["PatientID_FK"]);

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
            AnwesenheitID = DbSchicht.WriteRecord("anwesenheit", AnwesenheitID,
                ("Anwesenheitstag", dtpAnwesenheitstag.Value, dtpAnwesenheitstag),
                ("Grund", txtGrund.Text, txtGrund),
                ("PatientID_FK", PatientID_FK, null));

            wasDataChanged = false;
        }

        /// <summary>
        /// Löscht den Datensatz mit der AnschriftID, falls diese größer 0 ist.
        /// Tritt ein Fehler auf, wird eine Exception geworfen.
        /// </summary>
        public void DbDeleteRecord()
        {
            DbSchicht.DeleteRecord("Anwesenheit", AnwesenheitID);
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
        private void FrmAnwesenheit_FormClosing(object sender, FormClosingEventArgs e)
        {
            DbSchicht.FormClosing(this, wasDataChanged, e);
        }
        #endregion

        #region Properties zum Anzeigen des Objekts in einer ComboBox oder ListBox
        public virtual string DisplayMember
        {
            get
            {   // individuell je nach Klasse implementieren
                return $"{this.GetType().Name.Substring(3)}  {Convert.ToDateTime(dtpAnwesenheitstag.Value).ToShortDateString()} {txtGrund.Text}";
            }
        }
        public FrmAnwesenheit ValueMember
        {
            get
            {
                return this; // direkt das aktuelle Objekt in der List- oder ComboBox-Zeile speichern
            }
        }


        #endregion
    }
}

