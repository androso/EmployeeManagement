using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnEmploye_Click(object sender, EventArgs e)
        {
            EmployeForm employeForm = new EmployeForm(this);
            employeForm.Show();
            this.Hide();
        }

        private void btnPosition_Click(object sender, EventArgs e)
        {
            PositionForm positionForm = new PositionForm(this);
            positionForm.Show();
            this.Hide();
            
        }

        private void btnDepartment_Click(object sender, EventArgs e)
        {
            DepartmentForm departmentForm = new DepartmentForm(this);
            departmentForm.Show();
            this.Hide();
        }
    }
}
