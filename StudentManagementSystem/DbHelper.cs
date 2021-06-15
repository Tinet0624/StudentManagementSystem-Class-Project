using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    static class DbHelper
    {
        public static SqlConnection GetConnection()
        {
            //create connection to DB
            SqlConnection con1 =
                new SqlConnection("Data Source=localhost;" +
                                    "Initial Catalog=SMS;" +
                                    "Integrated Security=True;");
            //SqlConnection con = new SqlConnection();
            //con.ConnectionString = "some connection string";
            return con1;
        }
    }
}
