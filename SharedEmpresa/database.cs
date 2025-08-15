using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SharedEmpresa
{
    public static class database
    {
        private static string connectionString = "datasource=localhost; username=root; password=''; database=projeto ";
        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
