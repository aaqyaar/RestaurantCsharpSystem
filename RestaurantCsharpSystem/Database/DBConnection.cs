using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RestaurantCsharpSystem.Database
{
    public class DBConnection
    {
        static string connectionString = @"Data Source=DESKTOP\SQLEXPRESS; Initial Catalog=Restaurant_DB; Integrated Security=SSPI;";
        public static SqlConnection conn = new SqlConnection(connectionString);
    }
}
