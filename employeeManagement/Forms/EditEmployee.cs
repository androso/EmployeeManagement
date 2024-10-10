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
    public partial class EditEmployee : Form
    {
        private MainForm mainForm;
        private Employee selectedEmployee;
        private PositionService _positionService;
        private EmployeeService _employeeService;

        public EditEmployee(MainForm mainForm, Employee selectedEmployee)
        {
            _positionService = new PositionService();
            _employeeService = new EmployeeService();

            this.mainForm = mainForm;
            this.selectedEmployee = selectedEmployee;
            InitializeComponent();
            fullNameTextbox.Text = selectedEmployee.FullName;
            birthDate.Text = selectedEmployee.DateOfBirth.ToString();
            hireDate.Text = selectedEmployee.HireDate.ToString();
            phone.Text = selectedEmployee.Phone;

            positionCombobox.DataSource = _positionService.GetAllPositions();
            positionCombobox.DisplayMember = "PositionName";
            positionCombobox.ValueMember = "Id";
            positionCombobox.SelectedValue = selectedEmployee.PositionId;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); 
            mainForm.Show(); 
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.FullName = fullNameTextbox.Text;
            emp.DateOfBirth = DateTime.Parse(birthDate.Text);
            emp.HireDate = DateTime.Parse(hireDate.Text);
            emp.Phone = phone.Text;
            emp.PositionId = (int)positionCombobox.SelectedValue;

            EmployeeValidator empValidator = new EmployeeValidator();
            ValidationResult res = empValidator.Validate(emp);

            if (!res.IsValid)
            {
                DisplayValidationErrors(res);
                return;
            }
            else
            {
                _employeeService.UpdateEmployee(emp);
                this.Close();
                mainForm.Show();
            }
        }
        private void DisplayValidationErrors(ValidationResult result)
        {
            validationErrorProvider.Clear();

            foreach (var error in result.Errors)
            {
                switch (error.PropertyName)
                {
                    case nameof(Employee.FullName):
                        validationErrorProvider.SetError(fullNameTextbox, error.ErrorMessage);
                        break;
                    case nameof(Employee.DateOfBirth):
                        validationErrorProvider.SetError(birthDate, error.ErrorMessage);
                        break;
                    case nameof(Employee.HireDate):
                        validationErrorProvider.SetError(hireDate, error.ErrorMessage);
                        break;
                    case nameof(Employee.Phone):
                        validationErrorProvider.SetError(phone, error.ErrorMessage);
                        break;
                }
            }
        }
    }
}
