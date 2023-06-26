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
    public partial class FrmPatient : FrmPerson, IDbReadWriteDelete
    {
        #region Deklarationen, Konstruktoren und DataHasChanged

        public int PatientID { get; set; } = 0;

        public int PraxisID_FK { get; set; }

        public FrmPatient() : base()
        {
            InitializeComponent();
            // registrieren der geerbten Methode für das FormClosing-Event:
            nupPatientNr.ValueChanged += DataHasBeenChanged;
        }

        public FrmPatient(DbDataReader reader, int praxisID_FK) : this()
        {
            this.PraxisID_FK = praxisID_FK;
            if (reader != null)
                DbReadRecord(reader);
        }

        #endregion


        // TODO Diese region kompilierbar machen:
        #region überschriebene Methoden des Interfaces IDbReadWriteRecord

        public override void DbReadRecord(DbDataReader reader)
        {
            base.DbReadRecord(reader);
            PatientID = Convert.ToInt32(reader["PatientID"]);
            nupPatientNr.Value = Convert.ToInt32(reader["PatientNr"]);
            wasDataChanged = false;

            // Lesen der Anwesenheit
            DbDataReader readerAnwesenheiten = DbSchicht.GetDataReader("SELECT * FROM Anwesenheit "
                + "WHERE PatientID_FK=" + PatientID + " ORDER BY Anwesenheitstag", true);

            List<FrmAnwesenheit> anwesenheiten = new List<FrmAnwesenheit>();
            while (readerAnwesenheiten.Read())
            {
                FrmAnwesenheit frm = new FrmAnwesenheit(readerAnwesenheiten, PatientID);
                // Display- und ValueMember wurden schon an der Oberfläche gesetzt
                anwesenheiten.Add(frm);
            }
            DbSchicht.CloseSecondConnection();
            lbxAnwesenheiten.DataSource = anwesenheiten;
        }

        public override void DbWriteRecord()
        {
            base.DbWriteRecord();
            PatientID = DbSchicht.WriteRecord("Patient", PatientID,
                ("PraxisID_FK", PraxisID_FK, null),
                ("PersonID_FK", this.PersonID, null),
                ("PatientNr", Convert.ToInt32(this.nupPatientNr.Value), this.nupPatientNr));

            wasDataChanged = false;
        }

        #endregion

        #region Methoden für die Kontextmenüs der Arbeitszeit-ListBox

        // Kümmert sich darum, dass bearbeiten und löschen nicht möglich, wenn
        // die ComboBox leer ist
        private void menContextAnwesenheiten_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            menBearbeitenAnwesenheit.Enabled = lbxAnwesenheiten.SelectedItem != null;
            menLoeschenAnwesenheit.Enabled = menBearbeitenAnwesenheit.Enabled;
        }

        private void MenNeuAnwesenheit_Click(object sender, EventArgs e)
        {
            try
            {
                if (PatientID == 0)  // speichern notwendig
                    DbWriteRecord();

                // Soeichern erfolgreich
                var anwesenheiten = (lbxAnwesenheiten.DataSource == null) 
                                            ? new List<FrmAnwesenheit>()
                                            : lbxAnwesenheiten.DataSource as List<FrmAnwesenheit>;
                var frm = new FrmAnwesenheit(null, PatientID);
                frm.ShowDialog();

                if (frm.PatientID_FK > 0)
                {
                    anwesenheiten.Add(frm);
                    // ListBox aktualisieren:
                    lbxAnwesenheiten.DataSource = null;
                    lbxAnwesenheiten.DataSource = anwesenheiten;
                    lbxAnwesenheiten.DisplayMember = "DisplayMember";
                }

                lbxAnwesenheiten.SelectedItem = frm;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Speichern: " + ex.Message, "Fehler", MessageBoxButtons.OK);
            }
        }

        private void menBearbeitenAnwesenheit_Click(object sender, EventArgs e)
        {
            if (lbxAnwesenheiten.SelectedItem == null)
                return;
            var frm = lbxAnwesenheiten.SelectedItem as FrmAnwesenheit;
            frm.ShowDialog();
            // ListBox aktualisieren:
            var anwesenheiten = lbxAnwesenheiten.DataSource as List<FrmAnwesenheit>;
            lbxAnwesenheiten.DataSource = null;
            lbxAnwesenheiten.DataSource = anwesenheiten;
            lbxAnwesenheiten.DisplayMember = "DisplayMember";
        }

        private void MenLoeschen_Click(object sender, EventArgs e)
        {
            var anwesenheiten = lbxAnwesenheiten.DataSource as List<FrmAnwesenheit>;
            var frm = lbxAnwesenheiten.SelectedItem as FrmAnwesenheit;
            frm.DbDeleteRecord();
            anwesenheiten.Remove(frm);
            // ListBox aktualisieren:
            lbxAnwesenheiten.DataSource = null;
            lbxAnwesenheiten.DataSource = anwesenheiten;
            lbxAnwesenheiten.DisplayMember = "DisplayMember";
        }

        #endregion

        #region Properties zum Anzeigen des Objekts in einer ComboBox oder ListBox

        public virtual string DisplayMember
        {
            get
            {   // individuell je nach Klasse implementieren
                return $"{this.GetType().Name.Substring(3)} Nr. {nupPatientNr.Value}, {txtVorname.Text} {txtNachname.Text}";
            }
        }

        public FrmPatient ValueMember
        {
            get
            {
                return this;
            }
        }

        #endregion

    }
}
