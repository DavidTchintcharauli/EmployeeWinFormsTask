using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace EmployeeWinFormsTask.Database
{
    class DatabaseAccess
    {
        public static SqlConnection Connect()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["EmployeeWinFormsTask.Properties.Settings.employeeTaskConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);

            return connection;
        }
    }
}
