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
    public partial class FrmAnweseneheit : Form
    {
        #region Deklarationen, Konstruktoren und DataHasChanged
        public int AnwesenheitID { get; private set; } = 0;

        protected bool wasDataChanged = false;

        public FrmAnweseneheit()
        {
            InitializeComponent();
        }

        public FrmAnweseneheit(DbDataReader reader) : this()
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

        #endregion
        #region Methoden für die Kontextmenüs der Contains-ComboBox

        #endregion
        #region Individuelle Methoden

        #endregion

    }
}
