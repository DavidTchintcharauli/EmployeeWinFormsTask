using EmployeeWinFormsTask.Database;
using EmployeeWinFormsTask.Emploeyee.Hendler;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace EmployeeWinFormsTask.Emploeyee.Forms
{
    public partial class frmEmployeeAddEdit : Form
    {
        public frmEmployeeAddEdit()
        {
            InitializeComponent();
        }

        private void btnSaveEmployee_Click(object sender, EventArgs e)
        {

            string employeeFullName = txtEmployeeFullName.Text.Trim();
            DateTime employeeDob = dtpickerEmployeeDob.Value;
           // string employeeGender = cbEmployeeGender.SelectedItem?.ToString();
            string employeePhone = txtEmployeePhone.Text.Trim();
            string employeeAddress = txtEmployeeAddress.Text.Trim();
            string employeeEmail = txtEmployeeEmail.Text.Trim();
            string employeePersonalID = txtEmployeePersonalID.Text.Trim();

            if (string.IsNullOrWhiteSpace(employeeFullName) || employeeDob == DateTime.MinValue)
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


                using (SqlCommand command = new SqlCommand("dbo.Employee_Set", DatabaseAccess.Connect()))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@FullName", txtEmployeeFullName.Text);
                    command.Parameters.AddWithValue("@Dob", dtpickerEmployeeDob.Value);
                    command.Parameters.AddWithValue("@GenderID", cbEmployeeGender.SelectedValue);
                    command.Parameters.AddWithValue("@Phone", txtEmployeePhone.Text);
                    command.Parameters.AddWithValue("@Address", txtEmployeeAddress.Text);
                    command.Parameters.AddWithValue("@Email", txtEmployeeEmail.Text);
                    command.Parameters.AddWithValue("@PersonalID", txtEmployeePersonalID.Text);
                command.Connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                command.Connection.Close();
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

        private void btnCencelEmployee_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
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
        }

        private void frmEmployeeAddEdit_Load(object sender, EventArgs e)
        {
            ComboHendlers.GetGender(cbEmployeeGender);
        }

        private void cbEmployeeGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
