﻿using Db_Schicht;
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
    public partial class FrmPraxis : Form, IDbReadWriteDelete
    {
        #region Deklarationen, Konstruktoren und DataHasChanged

        public int PraxisID { get; private set; } = 0;

        protected bool wasDataChanged = false;

        private static int anzPraxis;

        public FrmPraxis()
        {
            InitializeComponent();
            anzPraxis++;
            if (anzPraxis > 1)
                throw new ApplicationException("Es darf nur ein FrmFirma-Objekt geben!");
        }

        public FrmPraxis(DbDataReader reader) : this()
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
            PraxisID = Convert.ToInt32(reader["PraxisID"]);
            txtPraxisname.Text = reader["Praxisname"].ToString();
            FrmPerson.FillAnschriftCombo(reader, cbxAnschrift);

            // Lesen der Anschrift
            FrmPerson.FillAnschriftCombo(reader, cbxAnschrift);

            // Lesen der Patienten
            DbDataReader readerPatient = DbSchicht.GetDataReader("SELECT p.*, pa.* FROM Person p "
                + "INNER JOIN Patient pa ON p.PersonID = pa.PersonID_FK "
                + "WHERE pa.PraxisID_FK=" + PraxisID + " ORDER BY p.Nachname, p.Vorname", true);

            List<FrmPatient> patienten = new List<FrmPatient>();
            while (readerPatient.Read())
            {
                FrmPatient frm = new FrmPatient(readerPatient, PraxisID);
                // Display- und ValueMember wurden schon an der Oberfläche gesetzt
                patienten.Add(frm);
            }
            DbSchicht.CloseSecondConnection();
            lbxPatient.DataSource = patienten;

            wasDataChanged = false;
        }

        public virtual void DbWriteRecord()
        {
            Int32? anschriftID_FK; // wird mit dem ? hinten nullable
            if (cbxAnschrift.SelectedItem == null)
                anschriftID_FK = null;
            else
                anschriftID_FK = (cbxAnschrift.SelectedItem as FrmAnschrift).AnschriftID;

            PraxisID = DbSchicht.WriteRecord("Praxis", PraxisID,
                            ("Praxisname", txtPraxisname.Text, txtPraxisname),
                            ("AnschriftID_FK", anschriftID_FK, cbxAnschrift));

            wasDataChanged = false;
        }

        public void DbDeleteRecord()
        {
            if (PraxisID > 0)
                throw new ApplicationException("das einzige FrmFirma-Objekt darf nicht gelöscht werden!");
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
            (cbxAnschrift.SelectedItem as FrmAnschrift).DbDeleteRecord();
            cbxAnschrift.SelectedItem = null;
        }
        #endregion

        #region Methoden für die Kontextmenüs der Mitarbeiter-ListBox

        // Kümmert sich darum, dass bearbeiten und löschen nicht möglich, wenn
        // die ComboBox leer ist
        private void menContextMitarbeiter_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            menBearbeitenPraxis.Enabled = lbxPatient.SelectedItem != null;
            menLoeschenPraxis.Enabled = menNeuePraxis.Enabled;
        }

        private void MenPraxisNeu_Click(object sender, EventArgs e)
        {
            try
            {
                if (PraxisID == 0)  // speichern notwendig
                    DbWriteRecord();

                // Soeichern erfolgreich
                var patient = (lbxPatient.DataSource == null) ? new List<FrmPatient>()
                                                                      : lbxPatient.DataSource as List<FrmPatient>;
                var frm = new FrmPatient(null, PraxisID);
                frm.ShowDialog();

                if (frm.PraxisID_FK > 0)
                {
                    patient.Add(frm);
                    // ListBox aktualisieren:
                    lbxPatient.DataSource = null;
                    lbxPatient.DataSource = patient;
                    lbxPatient.DisplayMember = "DisplayMember";
                }

                lbxPatient.SelectedItem = frm;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Speichern: " + ex.Message, "Fehler", MessageBoxButtons.OK);
            }
        }

        private void MenBearbeitenPraxis_Click(object sender, EventArgs e)
        {
            if (lbxPatient.SelectedItem == null)
                return;
            var frm = lbxPatient.SelectedItem as FrmPatient;
            frm.ShowDialog();
            // ListBox aktualisieren:
            var patient = lbxPatient.DataSource as List<FrmPatient>;
            lbxPatient.DataSource = null;
            lbxPatient.DataSource = patient;
            lbxPatient.DisplayMember = "DisplayMember";
        }

        private void MenLoeschenPraxis_Click(object sender, EventArgs e)
        {
            var patient = lbxPatient.DataSource as List<FrmPatient>;
            var frm = lbxPatient.SelectedItem as FrmPatient;
            frm.DbDeleteRecord();
            patient.Remove(frm);
            // ListBox aktualisieren:
            lbxPatient.DataSource = null;
            lbxPatient.DataSource = patient;
            lbxPatient.DisplayMember = "DisplayMember";
        }
        #endregion
    }
}
