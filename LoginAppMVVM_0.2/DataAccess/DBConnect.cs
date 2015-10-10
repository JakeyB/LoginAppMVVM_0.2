using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LoginAppMVVM_0._2.DataAccess
{
    class DBConnect
    {
        // Initialise DB source location(Debug) and version
        const string DBConnectionString = @"Data Source=database.db;Version=3;";
        private readonly SQLiteConnection _sqliteCon = new SQLiteConnection(DBConnectionString);

        public DBConnect()
        {
            _sqliteCon.Open(); // Open the connection
        }

        public void CloseConnection()
        {
            _sqliteCon.Close(); // Close the connection
        }

        // Update the SQLite database
        public SQLiteDataReader Update(string statement)
        {
            try
            {
                var query = statement; // Create query, then command
                var createCommand = new SQLiteCommand(query, _sqliteCon);
                createCommand.ExecuteNonQuery(); // Execute query
                var dr = createCommand.ExecuteReader(); // Read data
                return dr; // Return data reader
            }
            catch (SQLiteException exception)
            {
                MessageBox.Show(exception.Message);
            }
            return null;
        }
    }
}
