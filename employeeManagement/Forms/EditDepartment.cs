using BusinessLayer.Services;
using CommonLayer.Entities;
using FluentValidation.Results;
using PresentationLayer.Validations;
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

            DepartmentValidator depValidator = new DepartmentValidator();
            ValidationResult results = depValidator.Validate(_department);

            if (!results.IsValid)
            {
                DisplayValidationErrors(results);
                return;
            }

            _departmentService.UpdateDepartment(_department);
            
            this.Close();

        }
        private void DisplayValidationErrors(ValidationResult result)
        {
            validationErrorProvider.Clear();

            foreach (var error in result.Errors)
            {
                switch (error.PropertyName)
                {
                    case nameof(Department.DepartmentName):
                        validationErrorProvider.SetError(departmentNameTextbox, error.ErrorMessage);
                        break;
                    case nameof(Department.Description):
                        validationErrorProvider.SetError(departmentDescriptionTextBox, error.ErrorMessage);
                        break;
                }
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
