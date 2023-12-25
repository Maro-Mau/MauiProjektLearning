using MySql.Data.MySqlClient;
using System;
using System.Data.Common;
using System.Diagnostics;

namespace KarteiKartenApp
{
    class DatabaseConection
    {
        public string ConectDB(string Query)
        {
            string server = "88.99.194.190";
            int port = 3306;
            string database = "Login";
            string username = "rene";
            string password = "GEHEIM";
            string connectionString = $"Server={server};Port={port};Database={database};User ID={username};Password={password};";
            string DBRespons = "";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    // Verbindung öffnen
                    connection.Open();
                    Debug.WriteLine("Verbindung erfolgreich hergestellt!");

                    // Hier können Sie nun MySQL-Befehle ausführen oder Abfragen durchführen
                    string sql = Query;
                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        using (DbDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    // Zugriff auf Ihre Daten hier
                                    DBRespons += reader.GetString(0); // Beispiel für den Zugriff auf Daten
                                }
                            }
                        }
                    }
                    return DBRespons;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"Fehler beim Verbindungsaufbau: {ex.Message}");
                    return "Fehler beim Verbindungsaufbau";
                }
            }
        }
    }
}
