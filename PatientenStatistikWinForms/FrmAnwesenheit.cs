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
        public int AnwesenheitID { get; private set; } = 0;

        protected bool wasDataChanged = false;

        public FrmAnwesenheit()
        {
            InitializeComponent();
        }

        public FrmAnwesenheit(DbDataReader reader) : this()
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
            AnwesenheitID = Convert.ToInt32(reader["AnwesenheitID"]);
            dtpAnwesenheitstag.Value = Convert.ToDateTime(reader["Anwesenheitstag"]);
            txtGrund.Text = reader["Grund"].ToString();
            wasDataChanged = false;
        }

        public virtual void DbWriteRecord()
        {
            int PatientID_FK = 0;
            AnwesenheitID = DbSchicht.WriteRecord("Anwesenheit", AnwesenheitID,
                            ("Anwesenheitstag", dtpAnwesenheitstag.Value, dtpAnwesenheitstag),
                            ("Grund", txtGrund.Text, txtGrund),
                            ("PatientID_FK", PatientID_FK, null));
            wasDataChanged = false;
        }

        public void DbDeleteRecord()
        {
            DbSchicht.DeleteRecord("Anwesenheit", AnwesenheitID);
        }

        protected void FrmAnwesenheit_FormClosing(object sender, FormClosingEventArgs e)
        {
            DbSchicht.FormClosing(this, wasDataChanged, e);
        }

        #endregion

        #region Properties zum Anzeigen des Objekts in einer ComboBox oder ListBox
        public virtual string DisplayMember
        {
            get
            {   // individuell je nach Klasse implementieren
                return $"{this.GetType().Name.Substring(3)} {Convert.ToDateTime(dtpAnwesenheitstag.Value).ToString()}, {txtGrund.Text}";
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
