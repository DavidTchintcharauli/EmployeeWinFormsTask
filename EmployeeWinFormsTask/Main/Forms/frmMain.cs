using EmployeeWinFormsTask.Emploeyee.Forms;
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
           // gcEmployee.DataSource = 
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            frmEmployeeAddEdit frmEmployeeAddEdit = new frmEmployeeAddEdit();

            DialogResult result = frmEmployeeAddEdit.ShowDialog();

            if (result == DialogResult.OK)
            {
                //RefreshfrmMain();
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
