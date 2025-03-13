using System;
using System.Data.SQLite;

namespace YourNamespace
{
    public static class DatabaseHelper
    {
        private static string connectionString = "Data Source=UserDatabase.db;Version=3;";

        static DatabaseHelper()
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string createTableQuery = @"
                    CREATE TABLE IF NOT EXISTS Users (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Username TEXT UNIQUE,
                        Password TEXT,
                        Name TEXT,
                        TDEE INTEGER,
                        Goal TEXT,
                        Weight REAL
                    )";
                using (var command = new SQLiteCommand(createTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public static bool RegisterUser(string username, string password, string name, int tdee, string goal, double weight)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Users (Username, Password, Name, TDEE, Goal, Weight) VALUES (@username, @password, @name, @tdee, @goal, @weight)";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@tdee", tdee);
                    command.Parameters.AddWithValue("@goal", goal);
                    command.Parameters.AddWithValue("@weight", weight);

                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public static SQLiteDataReader GetUserByUsername(string username)
        {
            var connection = new SQLiteConnection(connectionString);
            connection.Open();
            string query = "SELECT * FROM Users WHERE Username = @username";
            var command = new SQLiteCommand(query, connection);
            command.Parameters.AddWithValue("@username", username);
            return command.ExecuteReader();
        }

        public static bool UpdateUserWeight(string username, double newWeight)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE Users SET Weight = @weight WHERE Username = @username";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@weight", newWeight);
                    command.Parameters.AddWithValue("@username", username);
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
