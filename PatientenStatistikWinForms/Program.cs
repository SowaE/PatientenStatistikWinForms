using Db_Schicht;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientenStatistikWinForms
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Test der Klasse FrmPerson
            DbSchicht.OpenConnection();
            FrmPraxis frm = null;
            DbDataReader reader = DbSchicht.GetDataReader("SELECT * FROM Praxis");
            if (reader.Read())
                frm = new FrmPraxis(reader);
            else
                frm = new FrmPraxis();

            Application.Run(frm);
        }
    }
}
