using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Floresol_ADM
{
    public class Database
    {
        public static string conect =
            "server=localhost;uid=root;pwd=;database=bank_adm";

        public static MySqlConnection Conecta()
        {
            return new MySqlConnection(conect);
        }
    }
}
