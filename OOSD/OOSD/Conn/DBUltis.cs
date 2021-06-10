using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSD.Conn
{
    class DBUltis
    {
        public static MySqlConnection GetDBConnection()
        {
            string host = "mysql-34202-0.cloudclusters.net";
            int port =34202;
            string database = "OOSD";
            string username = "user";
            string password = "12345678";

            return DBMySQLUltis.GetDBConnection(host, port, database, username, password);
        }
    }
}
