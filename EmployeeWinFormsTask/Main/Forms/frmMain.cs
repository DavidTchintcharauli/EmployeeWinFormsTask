using EmployeeWinFormsTask.Emploeyee.Forms;
using EmployeeWinFormsTask.Main.Hendler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeWinFormsTask
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            gcEmployee.DataSource = EmployeeHendler.GetEmployeeList();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            frmEmployeeAddEdit frmEmployeeAddEdit = new frmEmployeeAddEdit();

            DialogResult result = frmEmployeeAddEdit.ShowDialog();

            if (result == DialogResult.OK)
            {
                gcEmployee.DataSource = EmployeeHendler.GetEmployeeList();
            }
        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {

        }

        private void gcEmployee_Click(object sender, EventArgs e)
        {

        }
    }
}
