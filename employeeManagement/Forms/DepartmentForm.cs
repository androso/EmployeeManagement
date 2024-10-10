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
    public partial class DepartmentForm : Form
    {
        private MainForm _mainForm;
        private DepartmentService _departmentService;
        public DepartmentForm(MainForm mainForm)
        {
            this._mainForm = mainForm;
            this._departmentService = new DepartmentService();
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            _mainForm.Show();
            this.Close();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        { 
            _mainForm.Show();
            base.OnFormClosed(e);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Department _department = new Department();
            _department.DepartmentName = departmentNameTextbox.Text;
            _department.Description = departmentDescriptionTextBox.Text;

            DepartmentValidator depValidator = new DepartmentValidator();
            ValidationResult results = depValidator.Validate(_department);

            if (!results.IsValid)
            {
                DisplayValidationErrors(results);
                return;
            }

            _departmentService.AddDepartment(_department);

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
    }
}
