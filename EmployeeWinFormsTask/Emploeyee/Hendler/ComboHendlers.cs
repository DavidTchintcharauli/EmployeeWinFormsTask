using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeWinFormsTask.Database;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EmployeeWinFormsTask.Emploeyee.Hendler
{
    class ComboHendlers
    {
        public static void GetGender(ComboBox combo)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter("dbo.GetGenders", DatabaseAccess.Connect()))
                {
                    adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adapter.Fill(dt);

                    combo.DataSource = dt;
                    combo.DisplayMember = "GenderName";
                    combo.ValueMember = "GenderID";
                    combo.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}
