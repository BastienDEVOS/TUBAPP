using System;
using MySql.Data.MySqlClient;

namespace TUBAPP
{
    public static class DatabaseHelper
    {
        private static MySqlConnection? conn { get; set; }

        private static readonly string server = "YOUR_SERVER";
        private static readonly string user = "YOUR_USER";
        private static readonly string password = "YOUR_PASSWORD";
        private static readonly string database = "YOUR_DATABASE";

        private static readonly string connectionString =
            $"server={server};uid={user};pwd={password};database={database}";

        public static bool OpenConnection()
        {
            try
            {
                if (conn == null)
                    conn = new MySqlConnection(connectionString);

                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                return conn.State == System.Data.ConnectionState.Open;
            }
            catch (MySqlException ex)
            {
                Console.Error.WriteLine($"MySQL Error: {ex.Message}");
                return false;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Unexpected Error: {ex.Message}");
                return false;
            }
        }

        public static bool CloseConnection()
        {
            try
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                    conn.Dispose();
                    conn = null;
                    return true;
                }
                else if (conn != null)
                {
                    conn.Dispose();
                    conn = null;
                    return true;
                }
                return false;
            }
            catch (MySqlException ex)
            {
                Console.Error.WriteLine($"MySQL Error on close: {ex.Message}");
                return false;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Unexpected Error on close: {ex.Message}");
                return false;
            }
        }

        /// <summary>
        /// Gets the current open connection, or opens it if needed.
        /// </summary>
        public static MySqlConnection GetConnection()
        {
            if (conn == null || conn.State != System.Data.ConnectionState.Open)
            {
                if (!OpenConnection())
                    throw new InvalidOperationException("Unable to open database connection.");
            }
            return conn!;
        }
    }
}
