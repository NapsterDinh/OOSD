using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSD.Conn
{
    public class DBMySQLUltis
    {
        private static MySqlConnection conn=null;

        public static MySqlConnection
                GetDBConnection(string host, int port, string database, string username, string password)
        {
            String connString = "Server=" + host + ";Database=" + database
                + ";port=" + port + ";User Id=" + username + ";password=" + password;

            if (conn==null)
            {
                conn = new MySqlConnection(connString);
            }
            // Connection String.
            
            return conn;
        }
    }
}
