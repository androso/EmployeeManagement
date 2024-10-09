using BusinessLayer.Services;
using CommonLayer.Entities;
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
    public partial class EditDepartment : Form
    {
        private MainForm _mainForm;
        private Department _department;
        private DepartmentService _departmentService;
        public EditDepartment(MainForm mainForm, Department department)
        {
            this._mainForm = mainForm;
            this._department = department;

            this._departmentService = new DepartmentService();
            InitializeComponent();

            departmentNameTextbox.Text = department.DepartmentName;
            departmentDescriptionTextBox.Text = department.Description;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            _department.DepartmentName = departmentNameTextbox.Text;
            _department.Description = departmentDescriptionTextBox.Text;

            _departmentService.UpdateDepartment(_department);

            this.Close();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
