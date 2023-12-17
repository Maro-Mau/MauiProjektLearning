using MySql.Data.MySqlClient;
using System;
using System.Diagnostics;

namespace KarteiKartenApp
{
    class LoginDatabaseCheck
    {
        public void DatabaseConection()
        {
            string server = "88.99.194.190";
            int port = 3306;
            string database = "Login";
            string username = "rene";
            string password = "Lugo-2012!";

            string connectionString = $"Server={server};Port={port};Database={database};User ID={username};Password={password};";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    // Verbindung öffnen
                    connection.Open();
                    Debug.WriteLine("Verbindung erfolgreich hergestellt!");

                    // Hier können Sie nun MySQL-Befehle ausführen oder Abfragen durchführen
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"Fehler beim Verbindungsaufbau: {ex.Message}");
                }
            }
        }
    }
}
