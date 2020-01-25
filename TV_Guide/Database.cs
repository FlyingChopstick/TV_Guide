using System.Data.SQLite;
using System.Configuration;

namespace TV_Guide
{
    class Database
    {
        //public SQLiteConnection Connection;
        public SQLiteConnection Connection;

        public Database()
        {
            Connection = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString);
            //Connection = new SQLiteConnection("Data Source=./tv.db");
            //Connection = new SQLiteConnection(LoadConnectionString());
        }

        public void OpenConnection()
        {
            if (Connection.State != System.Data.ConnectionState.Open)
            {
                Connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (Connection.State != System.Data.ConnectionState.Closed)
            {
                Connection.Close();
            }
        }

        /**
        private static string LoadConnectionString(string id="Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
        /**/

        //private static string db_name = "tv.db";
    }
}
