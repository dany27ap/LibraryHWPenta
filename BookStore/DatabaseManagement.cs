using System;
using MySql.Data.MySqlClient;


namespace BookStore {
    public class DatabaseManagement {

        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public DatabaseManagement() {
            server = "localhost";
            database = "LibraryManagement";
            uid = "root";
            password = "";
            string connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" +
                                      "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString);
        }

        public bool canOpenConnection() {
            try {
                connection.Open();
                return true;
            }
            catch (MySqlException e) {
                Console.WriteLine(e.StackTrace);
                return false;
            }
        }

        public bool canCloseConnection() {
            try {
                connection.Close();
                return true;
            }
            catch (Exception e) {
                Console.Write(e.StackTrace);
                return false;
            }
        }

        public void InsertBook(String tableName, params string[] value) {
            string query = "INSERT INTO " + tableName + " (id, title, author) VALUES('" + value[0] + "', '" + value[1] + "', '" + value[2] + "';";

            if (canOpenConnection()) {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();

                this.canCloseConnection();
            }
        }
        
    }
    
}