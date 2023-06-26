using System;
using System.Data.Common;
using System.Text;
using System.Windows.Forms;
using PatientenStatistikWinForms;
using MySql.Data.MySqlClient;

namespace Db_Schicht
{

    /// <summary>
    /// Die Klasse liefert Methoden zum Datenbankzugriff. Nur sie sollte die MySql-Klassen verwenden.
    /// </summary>
    public class DbSchicht
    {

        private static string connectionString = "server=localhost;database=PatientenStatistik;userid=root;password=";

        // Verbindung zur MySql-bzw. MariaDb-Datenbank aufbauen:
        private static MySqlConnection conReader;   // ständige Verbindung für GetDataReader
        private static MySqlConnection conExecute;  // ständige Verbindung für WriteRecord und DeleteRecord
        private static MySqlConnection con2; // temporäre Verbindung, die notweinding ist, weil nur ein DataReader pro Connection offen sein darf

        private const string vorIdentifier = "`", nachIdentifier = "`"; // für den Aufbau von Sql-Anweisungen

        /// <summary>
        /// Muss einmal vor dem ersten Datenbankzugriff aufgerufen werden.
        /// </summary>
        /// <returns>true wenn erfolgreich, false im Fehlerfall, die App sollte sofort beendet werden</returns>
        public static bool OpenConnection()
        {
            try
            {
                conReader = new MySqlConnection(connectionString);
                conReader.Open();
                conExecute = new MySqlConnection(connectionString);
                conExecute.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\r\n\r\nDie App wird beendet", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Erstellt aus der sqlSelect-Anweisung einen DbDataReader zum Auslesen
        /// der gewünschten Datensätze
        /// Wichtig: Es können verschiedene MySql-Exceptions auftreten!
        /// </summary>
        /// <param name="sqlSelect">die Sql-Select-Anweisung</param>
        /// <param name="useSecondConnection">wenn true, wird con2 für verwendet, das möglichst schnell wieder mit 
        /// CloseSecondConnection geschlossen werden sollte</param>
        /// <param name="useExecuteConnection">Soll die Connection zum Ausführen der Delete bzw. WriteRecord.Methoen verwendet werden</param>
        /// <returns>den DbDataReader, mit dem man mit while alle Datensätze auslesen kann</returns>
        public static DbDataReader GetDataReader(string sqlSelect, bool useSecondConnection = false, bool useExecuteConnection = false)
        {
            // Command-Objekt zum Verarbeiten einer sql-Anweisung
            MySqlConnection connection;
            if (useSecondConnection)
            {
                con2 = new MySqlConnection(connectionString);
                con2.Open();
                connection = con2;
            }
            else if (useExecuteConnection)
                connection = conExecute;
            else
                connection = conReader;
            
            MySqlCommand cmd = new MySqlCommand(sqlSelect, connection);

            // DataReader zum Lesen aus sql-Ergebnis:
            return cmd.ExecuteReader();
        }

        /// <summary>
        /// Schließt die in GetDataReader geöffnete SecondConnection
        /// </summary>
        public static void CloseSecondConnection()
        {
            if (con2 != null)
            {
                con2.Close();
                con2 = null;
            }
        }

        /// <summary>
        /// Speichert die Objektdaten in einem bestehenden (UPDATE-Anweisung, wenn id > 0) oder 
        /// neuen (INSERT-Anweisung, wenn id == 0) Datensatz der angegebenen Tabelle. Im letzten
        /// Fall wird die neue id zurückgeliefert.
        /// Tritt ein Fehler auf (z.B. NOT-NULL-Spalte ist leer), wird eine Exception geworfen.
        /// </summary>
        /// <param name="tableName">Name der betroffenen Datenbanktabelle, deren PK-Spalte <tableName>ID heißen muss</param>
        /// <param name="id">der aktuelle PK-Wert</param>
        /// <param name="data">die Spaltennamen mit den zugehörigen Daten und dem Control für die Dateneingabe,
        /// das im Tag mit "*" gekennzeichnet sein muss, wenn eine Pflichteingabe erforderlich ist</param>
        /// <returns>die neue ID (nach INSERT INTO) oder die alte ID (nach UPDATE)</returns>
        public static int WriteRecord(string tableName, int id, params (string colName, object value, Control control)[] data)
        {
            // Prüfe alle Controls, ob Pflichteingaben fehlen (bricht das Speichern beim ersten Fehler mit Exception ab):
            foreach (var tupel in data)
            {
                if (tupel.control != null && tupel.control.Tag != null && 
                    tupel.control.Tag.ToString() == "*" && 
                    SqlData(tupel.value) == DBNull.Value)
                {
                    string name;
                    if (tupel.control != null)
                    {
                        tupel.control.Focus();
                        name = tupel.colName;
                    }
                    else
                        name = tupel.control.Name.Substring(3);
                    throw new ApplicationException($"Fehlende Pflichteingabe in {name}!");
                }
            }

            // Speichern
            int anzChanged = 0;
            MySqlCommand cmd;

            if (id > 0)
            {   // update-Anweisung generieren
                StringBuilder sql = new StringBuilder($"UPDATE {vorIdentifier}{tableName}{nachIdentifier} SET ");

                for (int i = 0; i < data.Length; i++)
                {
                    var tupel = data[i];
                    sql.Append($"{vorIdentifier}{tupel.colName}{nachIdentifier} = @P{i}");
                    if (i < data.Length - 1)
                        sql.Append(", ");
                }

                sql.Append($" WHERE {vorIdentifier}{tableName}ID{nachIdentifier} = @Pid");

                cmd = new MySqlCommand(sql.ToString(), conExecute);
                // Parameter mit Werten füllen:
                for (int i = 0; i < data.Length; i++)
                {
                    var tupel = data[i];
                    var sqlData = SqlData(tupel.value);
                    cmd.Parameters.AddWithValue($"@P{i}", sqlData); 
                }

                cmd.Parameters.AddWithValue("@Pid", id);
                anzChanged = cmd.ExecuteNonQuery();
            }
            else
            {   // Insert-into-Anweisung generieren und ausführen
                StringBuilder sql = new StringBuilder($"INSERT INTO {vorIdentifier}{tableName}{nachIdentifier} (");

                for (int i = 0; i < data.Length; i++)
                {
                    // Columns
                    var tupel = data[i];
                    sql.Append($"{vorIdentifier}{tupel.colName}{nachIdentifier}");
                    if (i < data.Length - 1)
                        sql.Append(", ");
                }
                sql.Append(") VALUES (");

                // VALUES mit Parametern füllen
                for (int i = 0; i < data.Length; i++)
                {
                    sql.Append($"@P{i}");
                    if (i < data.Length - 1)
                        sql.Append(", ");
                }
                sql.Append(")");

                cmd = new MySqlCommand(sql.ToString(), conExecute);
                
                // Parameter mit Werten füllen:
                for (int i = 0; i < data.Length; i++)
                {
                    var tupel = data[i];
                    var sqlData = SqlData(tupel.value);
                    cmd.Parameters.AddWithValue($"@P{i}", sqlData);
                }

                anzChanged = cmd.ExecuteNonQuery();

                // Ermittle last_insert_id() 
                DbDataReader reader = GetDataReader("SELECT last_insert_id() AS id", false, true);
                if (reader.Read())
                    id = Convert.ToInt32(reader["id"]);
                else
                    throw new ApplicationException("ID konnte nicht ermittelt werden");
                reader.Close();
            }

            if (anzChanged != 1)
                throw new ApplicationException($"WriteRecord hat {anzChanged} statt des erwarteten einen Datensatzes geändert!");
            return id;
        }

        private static object SqlData(object value)
        {
            if (value == null)
                return DBNull.Value;

            if (value is String)
            {
                string sqlDataString = value as string;
                if (String.IsNullOrWhiteSpace(sqlDataString))
                    return DBNull.Value;
            }
            return value;
        }


        /// <summary>
        /// Löscht den Datensatz aus der angegebenen Tabelle, dessen <tableName>ID gleich id ist"
        /// </summary>
        /// <param name="tableName">die Tabelle</param>
        /// <param name="id">die gewünschte ID</param>
        public static void DeleteRecord(string tableName, int id)
        {
            if (id > 0)
            {
                String sql = $"DELETE FROM {vorIdentifier}{tableName}{nachIdentifier} WHERE {vorIdentifier}{tableName}ID{nachIdentifier} = {id}";
                MySqlCommand cmd = new MySqlCommand(sql, conExecute);
                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Dient zum Aufruf in einer FormClosing-Eventhandler-Methdode und versucht,
        /// die Objektdaten in der Db zu speichern. Im Fehlerfall erscheint eine Rückfrage,
        /// ob das Fenster ohne Speichern geschlossen werden soll.
        /// </summary>
        /// <param name="frm">die Form mit dem FormClosing-Eventhandler</param>
        /// <param name="wasDataChanged">wurden Daten auf der Form geändert?</param>
        /// <param name="e">die FormClosingEventArgs</param>
        public static void FormClosing(IDbReadWriteDelete frm, bool wasDataChanged, FormClosingEventArgs e)
        {
            if (wasDataChanged)
            {
                try
                {
                    frm.DbWriteRecord();
                }
                catch (Exception ex)
                {
                    string meldung = $"Fehler beim Speichern: {ex.Message}\r\n\r\nFenster ohne speichern schließen?";
                    if (MessageBox.Show(meldung, "Fehler", MessageBoxButtons.YesNo, MessageBoxIcon.Question, 
                                        MessageBoxDefaultButton.Button2) == DialogResult.No)
                        e.Cancel = true;
                }
            }
        }
    }
}
