using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EmployeeWinFormsTask.Database
{
    class DatabaseAccess
    {
        public static SqlConnection conn;
        public static SqlConnection Connect()
        {
            conn = new SqlConnection("Data Source=DEVELOPER3;Initial Catalog=employeeDb;Integrated Security=True");

            return conn;
        }
    }
}
