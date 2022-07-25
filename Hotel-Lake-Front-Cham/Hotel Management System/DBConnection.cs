using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Hotel_Management_System
{
    class DBConnection
    {
        public MySqlConnection getConnection()
        {
            string connectionString;
            MySqlConnection conn;
            connectionString = "server=127.0.0.1;port=3306;username=root;password=;database=hotel";
            conn = new MySqlConnection(connectionString);
            conn.Open();
            return conn;
        }
    }
}
