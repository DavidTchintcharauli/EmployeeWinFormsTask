using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using EmployeeWinFormsTask.Database;

namespace EmployeeWinFormsTask.Emploeyee.Forms
{
    public partial class frmEmployeeAddEdit : Form
    {
        public frmEmployeeAddEdit()
        {
            InitializeComponent();
            cbEmployeeGender.Items.AddRange(new string[] { "მამრობითი", "მდედრობითი" });
        }

        private readonly SqlConnection connection;
        private readonly string ConnectionString;

        private void btnSaveEmployee_Click(object sender, EventArgs e)
        {

            string employeeFullName = txtEmployeeFullName.Text.Trim();
            DateTime employeeDob = dtpickerEmployeeDob.Value;
            string employeeGender = cbEmployeeGender.SelectedItem?.ToString();
            string employeePhone = txtEmployeePhone.Text.Trim();
            string employeeAddress = txtEmployeeAddress.Text.Trim();
            string employeeEmail = txtEmployeeEmail.Text.Trim();
            string employeePersonalID = txtEmployeePersonalID.Text.Trim();

            if (string.IsNullOrWhiteSpace(employeeFullName) || employeeDob == DateTime.MinValue || string.IsNullOrWhiteSpace(employeeGender))
            {
                MessageBox.Show("გთცოვთ შეავსოთ ყველა სავალდებულო ველი (გვარი სახელი, დაბადების თარიღი, სქესი).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] nameParts = employeeFullName.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (nameParts.Length < 2)
            {
                MessageBox.Show("გთხოვთ მიუთითოთ პაციენტის გვარიც და სახლიც. ", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string firstName = nameParts[0];
            string lastName = string.Join(" ", nameParts.Skip(1));

            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
            {
                MessageBox.Show("მითითებული უნდა იყოს აუცილებლად პაციენტის გვარიც და სახელიც.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!string.IsNullOrEmpty(employeePhone))
            {
                if (!employeePhone.StartsWith("5") || employeePhone.Length != 9 || !employeePhone.All(char.IsDigit))
                {
                    MessageBox.Show("მითითებული ტელეფონის ნომერი არასწორია, ნობილური ნომერი უნდა იწუებოდეს 5-ით და უნდა შეიცავდეს 9 ციფრს.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (!ValidatePersonalID(employeePersonalID))
            {
                MessageBox.Show("პირადი ნომერი უნდა შეიცავდეს 11 ციფრს.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ValidateEmail(employeeEmail))
            {
                MessageBox.Show("მითითებული იმეილი არ არის სწორი.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int genederID = GetGenderByName(employeeGender);

            MessageBox.Show(employeeAddress);

        }

        private void btnCencelEmployee_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private int GetGenderByName(string genderName)
        {
            using (SqlDataAdapter command = new SqlDataAdapter("dbo.GetGenders", DatabaseAccess.Connect))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@GenderName", genderName);

                SqlParameter returnParam = new SqlParameter("GenderID", SqlDbType.Int);
                returnParam.Direction = ParameterDirection.Output;
                command.Parameters.Add(returnParam);

                command.ExecuteNonQuery();
                int GenderID = (int)returnParam.Value;

                if (GenderID > 0)
                {
                    return GenderID;
                }
                else
                {
                    return -1;
                }
            }
        }

        private bool ValidatePersonalID(string employeePersonalID)
        {
            if (!string.IsNullOrEmpty(employeePersonalID))
            {
                string pattern = @"^\d{11}$";

                if (Regex.IsMatch(employeePersonalID, pattern))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        private bool ValidateEmail(string employeEmail)
        {
            if (!string.IsNullOrEmpty(employeEmail))
            {
                try
                {
                    var addr = new System.Net.Mail.MailAddress(employeEmail);
                    return addr.Address == employeEmail;
                }
                catch
                {
                    return false;
                }
            }
            return true;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("frmEmployee", DatabaseAccess.Connect()))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@FullName", txtEmployeeFullName);
                    command.Parameters.AddWithValue("@Dob", dtpickerEmployeeDob);
                    command.Parameters.AddWithValue("@GenderID", cbEmployeeGender);
                    command.Parameters.AddWithValue("@Phone", txtEmployeePhone);
                    command.Parameters.AddWithValue("@Address", txtEmployeeAddress);
                    command.Parameters.AddWithValue("@Email", txtEmployeeEmail);
                    command.Parameters.AddWithValue("@PersonalID", txtEmployeePersonalID);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("დასაქემებულის ინფორმაცია წარმატებით განხორცილედა!", "Save Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("შეცდომა დაფიქსირდა პაციენტის ინფორმაციის დამახსოვრებისას", "Save Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            this.FormClosed += (s, args) =>
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                    connection.Dispose();
                }
            };
        }
    }
}
