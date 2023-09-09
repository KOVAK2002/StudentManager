using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace StudentManager
{
    class MY_DB
    {
        private MySqlConnection con;

        public MY_DB()
        {
            // Initialize the MySqlConnection object with the connection string
            con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=students");
        }

        public MySqlConnection GetConnection
        {
            get
            {
                return con;
            }
        }
        public void openConnection()
        {
            if (con.State ==ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public void closeConnection()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}

