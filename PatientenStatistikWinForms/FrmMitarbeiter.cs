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
    public partial class FrmMitarbeiter : FrmPerson, IDbReadWriteDelete
    {

        #region Deklarationen, Konstruktoren und DataHasChanged

        public int MitarbeiterID { get; set; } = 0;

        public int FirmaID_FK { get; set; }

        public FrmMitarbeiter() : base()
        {
            InitializeComponent();
            // registrieren der geerbten Methode für das FormClosing-Event:
            nupPersonalNr.ValueChanged += DataHasBeenChanged;
        }

        public FrmMitarbeiter(DbDataReader reader, int firmaID_FK) : this()
        {
            this.FirmaID_FK = firmaID_FK;
            if (reader != null)
                DbReadRecord(reader);
        }

        #endregion

        #region überschriebene Methoden des Interfaces IDbReadWriteRecord

        public override void DbReadRecord(DbDataReader reader)
        {
            base.DbReadRecord(reader);
            MitarbeiterID = Convert.ToInt32(reader["MitarbeiterID"]);
            nupPersonalNr.Value = Convert.ToInt32(reader["PersonalNr"]);
            wasDataChanged = false;

            // Lesen der Arbeitszeiten
            DbDataReader readerArbeitszeiten = DbSchicht.GetDataReader("SELECT * FROM Arbeitszeit "
                + "WHERE MitarbeiterID_FK=" + MitarbeiterID + " ORDER BY Tag, Kommt, Geht", true);

            List<FrmArbeitszeit> arbeitszeiten = new List<FrmArbeitszeit>();
            while (readerArbeitszeiten.Read())
            {
                FrmArbeitszeit frm = new FrmArbeitszeit(readerArbeitszeiten, MitarbeiterID);
                // Display- und ValueMember wurden schon an der Oberfläche gesetzt
                arbeitszeiten.Add(frm);
            }
            DbSchicht.CloseSecondConnection();
            lbxArbeitszeiten.DataSource = arbeitszeiten;
        }

        public override void DbWriteRecord()
        {
            base.DbWriteRecord();
            MitarbeiterID = DbSchicht.WriteRecord("Mitarbeiter", MitarbeiterID,
                ("FirmaID_FK", FirmaID_FK, null),
                ("PersonID_FK", this.PersonID, null),
                ("PersonalNr", Convert.ToInt32(this.nupPersonalNr.Value), this.nupPersonalNr));

            wasDataChanged = false;
        }

        #endregion

        #region Methoden für die Kontextmenüs der Arbeitszeit-ListBox

        // Kümmert sich darum, dass bearbeiten und löschen nicht möglich, wenn
        // die ComboBox leer ist
        private void menContextArbeitszeiten_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            menBearbeitenArbeitszeiten.Enabled = lbxArbeitszeiten.SelectedItem != null;
            menLoeschenArbeitszeiten.Enabled = menBearbeitenArbeitszeiten.Enabled;
        }

        private void MenNeuArbeitszeiten_Click(object sender, EventArgs e)
        {
            try
            {
                if (MitarbeiterID == 0)  // speichern notwendig
                    DbWriteRecord();

                // Soeichern erfolgreich
                var arbeitszeiten = (lbxArbeitszeiten.DataSource == null) ? new List<FrmArbeitszeit>()
                                            : lbxArbeitszeiten.DataSource as List<FrmArbeitszeit>;
                var frm = new FrmArbeitszeit(null, MitarbeiterID);
                frm.ShowDialog();

                if (frm.ArbeitszeitID > 0)
                {
                    arbeitszeiten.Add(frm);
                    // ListBox aktualisieren:
                    lbxArbeitszeiten.DataSource = null;
                    lbxArbeitszeiten.DataSource = arbeitszeiten;
                    lbxArbeitszeiten.DisplayMember = "DisplayMember";
                }

                lbxArbeitszeiten.SelectedItem = frm;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Speichern: " + ex.Message, "Fehler", MessageBoxButtons.OK);
            }
        }

        private void menBearbeitenArbeitszeiten_Click(object sender, EventArgs e)
        {
            if (lbxArbeitszeiten.SelectedItem == null)
                return;
            var frm = lbxArbeitszeiten.SelectedItem as FrmArbeitszeit;
            frm.ShowDialog();
            // ListBox aktualisieren:
            var arbeitszeiten = lbxArbeitszeiten.DataSource as List<FrmArbeitszeit>;
            lbxArbeitszeiten.DataSource = null;
            lbxArbeitszeiten.DataSource = arbeitszeiten;
            lbxArbeitszeiten.DisplayMember = "DisplayMember";

            //lbxArbeitszeiten.SelectedItem = frm; // aktuelles wieder markieren
        }

        private void MenLoeschen_Click(object sender, EventArgs e)
        {
            var arbeitszeiten = lbxArbeitszeiten.DataSource as List<FrmArbeitszeit>;
            var frm = lbxArbeitszeiten.SelectedItem as FrmArbeitszeit;
            frm.DbDeleteRecord();
            arbeitszeiten.Remove(frm);
            // ListBox aktualisieren:
            lbxArbeitszeiten.DataSource = null;
            lbxArbeitszeiten.DataSource = arbeitszeiten;
            lbxArbeitszeiten.DisplayMember = "DisplayMember";
        }

        #endregion

        #region Properties zum Anzeigen des Objekts in einer ComboBox oder ListBox

        public virtual string DisplayMember
        {
            get
            {   // individuell je nach Klasse implementieren
                return $"{this.GetType().Name.Substring(3)} Nr. {nupPersonalNr.Value}, {txtVorname.Text} {txtNachname.Text}";
            }
        }

        public FrmMitarbeiter ValueMember
        {
            get
            {
                return this;
            }
        }

        #endregion
    }
}
