using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EmployeeWinFormsTask.Database
{
    public class DatabaseAccess
    {
        SqlConnection connection = new SqlConnection();
        public static ConnectionString Connect()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["EmployeeWinFormsTask.Properties.Settings.employeeTaskConnectionString"].ConnectionString;
            connection.ConnectionString = connectionString;

            return connection;
        }
    }
}
