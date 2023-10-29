using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Data;
using System.Data.SqlClient;
using FinalProject_QUANLYKHO.Contanst;

namespace FinalProject_QUANLYKHO.DB
{
    internal class ConfigDB
    {
        private static ConfigDB instance;
        private SqlConnection connection;

        private ConfigDB()
        {
            // Initialize the database connection
            string connectionString = ContanstApp.CONNECT_DB_URL;
            connection = new SqlConnection(connectionString);
        }

        public static ConfigDB Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ConfigDB();
                }
                return instance;
            }
        }

        public SqlConnection GetConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            return connection;
        }

        public void CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}




