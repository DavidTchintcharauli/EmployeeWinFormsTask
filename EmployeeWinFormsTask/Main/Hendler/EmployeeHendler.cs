using EmployeeWinFormsTask.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeWinFormsTask.Main.Hendler
{
    public class EmployeeHendler
    {
        public static DataTable GetEmployeeList()
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter("dbo.Employee_ListGet", DatabaseAccess.Connect()))
                {
                    adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adapter.Fill(dataTable);
                }
            }
            catch (Exception)
            {

                throw;
            }
            
            return dataTable;
        }
    }
}
