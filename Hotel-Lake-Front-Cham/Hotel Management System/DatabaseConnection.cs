using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Hotel_Management_System
{
    class DatabaseConnection
    {
        public static MySqlConnection Connectdb()
        {
            try
            {
                String MYSQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=hotel;";
                MySqlConnection databaseConnection = new MySqlConnection(MYSQLConnectionString);
                return databaseConnection;
            }
            catch (MySqlException ex)
            {
                return null;
            }

        }
    }
}

