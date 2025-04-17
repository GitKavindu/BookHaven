using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHeven.config
{
   public class DataSourceConfig {
        private static string connectionString = "Server=127.0.0.1;Port=3000;Database=bookhaven;Uid=root;Pwd=1234;";

        public static MySqlConnection GetConnection() {
            return new MySqlConnection(connectionString);
        } 
    }
}
