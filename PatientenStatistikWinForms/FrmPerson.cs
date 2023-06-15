using System;
using System.Data.Common;
using System.Windows.Forms;
using Db_Schicht;

namespace PatientenStatistikWinForms
{
    /// <summary>
    /// Muster für eine WinForms-Klasse mit Contains-Beziehung und Enum-ComboBox,
    /// die keine Properties zum Anzeigen in einer List- oder ComboBox benötigt
    /// </summary>

    public partial class FrmPerson : Form, IDbReadWriteDelete
    {
        #region Deklarationen, Konstruktoren und DataHasChanged

        public enum GeschlechtEnum { Mann, Frau, divers };

        public int PersonID { get; private set; } = 0; 

        protected bool wasDataChanged = false; 

        public FrmPerson()
        {
            InitializeComponent();
            dtpGeburtsdatum.Value = null; // geht bei Klasse NullableDateTimePicker
            wasDataChanged = false;
        }

        public FrmPerson(DbDataReader reader) : this() 
        {
            if (reader != null)
                DbReadRecord(reader);
        }


        protected void DataHasBeenChanged(Object sender, EventArgs e)
        {
            wasDataChanged = true;
        }

        #endregion

        #region Methoden des Interfaces IDbReadWriteRecord und FormClosing-EventHandler-Methode

        public virtual void DbReadRecord(DbDataReader reader)
        {
            PersonID = Convert.ToInt32(reader["PersonID"]);
            txtVorname.Text = reader["Vorname"].ToString();
            txtNachname.Text = reader["Nachname"].ToString();
            dtpGeburtsdatum.Value = Convert.ToDateTime(reader["Geburtsdatum"]);

            FrmPerson.FillAnschriftCombo(reader, cbxAnschrift);

            wasDataChanged = false;
        }

        public virtual void DbWriteRecord()
        {
            Int32? anschriftID_FK; // wird mit dem ? hinten nullable
            if (cbxAnschrift.SelectedItem == null)
                anschriftID_FK = null;
            else
                anschriftID_FK = (cbxAnschrift.SelectedItem as FrmAnschrift).AnschriftID;

            PersonID = DbSchicht.WriteRecord("Person", PersonID,
                            ("Vorname", txtVorname.Text, txtVorname),
                            ("Nachname", txtNachname.Text, txtNachname), 
                            ("Geburtsdatum", dtpGeburtsdatum.Value, dtpGeburtsdatum),
                            ("AnschriftID_FK", anschriftID_FK, cbxAnschrift));

            wasDataChanged = false;
        }

        public void DbDeleteRecord()
        {
            DbSchicht.DeleteRecord("Person", PersonID);
            // Evtl. Löschen der zugehörigen Anschrift bzw. der AnschriftMitPostfach
            if (cbxAnschrift.SelectedItem != null)
                (cbxAnschrift.SelectedItem as FrmAnschrift).DbDeleteRecord();
        }

        protected void FrmPerson_FormClosing(object sender, FormClosingEventArgs e)
        {
            DbSchicht.FormClosing(this, wasDataChanged, e);
        }
        #endregion

        #region Methoden für die Kontextmenüs der Contains-ComboBox

        // Registriert das WinForms-Objekt in cbxAnschrift und zeigt es an
        private void SetAndOpenForm(FrmAnschrift frm)
        {
            if (cbxAnschrift.SelectedItem != null)
                (cbxAnschrift.SelectedItem as FrmAnschrift).DbDeleteRecord();
            frm.ShowDialog();
            cbxAnschrift.DataSource = new FrmAnschrift[] { frm };
            cbxAnschrift.SelectedItem = frm;
        }

        // Kümmert sich darum, dass bearbeiten und löschen nicht möglich ist, wenn
        // die ComboBox leer ist
        private void menContext_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            menBearbeiten.Enabled = cbxAnschrift.SelectedItem != null;
            menLoeschen.Enabled = menBearbeiten.Enabled;
        }

        private void MenAnschriftNeu_Click(object sender, EventArgs e)
        {
            SetAndOpenForm(new FrmAnschrift());
        }

 
        private void menBearbeiten_Click(object sender, EventArgs e)
        {
            if (cbxAnschrift.SelectedItem == null)
                return;
            FrmAnschrift frm = cbxAnschrift.SelectedItem as FrmAnschrift;
            frm.ShowDialog();
            // ComboBox aktualisieren:
            cbxAnschrift.DataSource = new FrmAnschrift[] { frm };
            cbxAnschrift.SelectedItem = frm;
        }

        private void MenLoeschen_Click(object sender, EventArgs e)
        {
            if (cbxAnschrift.SelectedItem != null)
            {
                (cbxAnschrift.SelectedItem as FrmAnschrift).DbDeleteRecord();
                cbxAnschrift.SelectedItem = null;
            }
        }
        #endregion

        #region Individuelle Methoden

        /// <summary>
        /// Die Klassenmethode ist so programmiert, dass sie auch in FrmFirma aufgerufen werden kann.
        /// Der Aufruf erfolgt in Methode DbReadRecord.
        /// Das Combo bleibt leer, wenn reader["AnschriftID_FK"] null ist, ansonsten wird mit einem 
        /// weiteren Reader abgefragt, ob nur eine Anschrift oder auch eine AnschriftMitPostach 
        /// vorhanden ist und das entsprechende Objekt erzeugt und in der ComboBox angezeigt.
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="cbxAnschrift"></param>
        public static void FillAnschriftCombo(DbDataReader reader, ComboBox cbxAnschrift)
        {
            if (reader["AnschriftID_FK"] != DBNull.Value)
            {   // Erstelle das Anschrift oder AnschriftMitPostfach-Objekt
                int anschriftID_FK = Convert.ToInt32(reader["AnschriftID_FK"]);
                DbDataReader readerAnschrift = DbSchicht.GetDataReader("SELECT * " +
                    " FROM Anschrift WHERE AnschriftID=" + anschriftID_FK, true);
                FrmAnschrift frm; 
                if (readerAnschrift.Read())
                {
                    frm = new FrmAnschrift(readerAnschrift);
                    readerAnschrift.Close();
                    DbSchicht.CloseSecondConnection();
                   // Display- und ValueMember wurden schon an der Oberfläche gesetzt
                    cbxAnschrift.DataSource = new FrmAnschrift[] { frm };
                    cbxAnschrift.SelectedItem = frm;
                }
                else
                    frm = new FrmAnschrift();
            }
        }

        /// <summary>
        /// Ermittelt das aktuelle Alter der Person. Das Ergebnis ist -1,
        /// wenn dtpGeburtsdatum noch null ist.
        /// </summary>
        /// <returns></returns>
        private int GetAlter()
        {
            if (dtpGeburtsdatum.Value == null)
                return -1;

            DateTime geburtsdatum = Convert.ToDateTime(dtpGeburtsdatum.Value);
            DateTime aktDat = DateTime.Now;
            if (aktDat.Month < geburtsdatum.Month ||
                aktDat.Month == geburtsdatum.Month && aktDat.Day < geburtsdatum.Day)
            {
                return aktDat.Year - geburtsdatum.Year - 1;
            }
            return aktDat.Year - geburtsdatum.Year;
        }

        #endregion
    }
}
