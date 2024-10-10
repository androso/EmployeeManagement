using BusinessLayer.Services;
using CommonLayer.Entities;
using FluentValidation.Results;
using PresentationLayer.Validations;
using System;
using System.Windows.Forms;

namespace PresentationLayer.Forms
{
    public partial class PositionForm : Form
    {
        private MainForm _mainForm;
        private PositionService _positionService;
        private DepartmentService _departmentService;
        public PositionForm(MainForm mainForm)
        {
            this._mainForm = mainForm;
            this._positionService = new PositionService();
            this._departmentService = new DepartmentService();
            InitializeComponent();
            departmentCombobox.DataSource = _departmentService.GetAllDepartments();
            departmentCombobox.DisplayMember = "DepartmentName";
            departmentCombobox.ValueMember = "Id";
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            _mainForm.Show();
            base.OnFormClosed(e);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            decimal baseSalary;

            if (decimal.TryParse(baseSalaryTextbox.Text, out baseSalary))
            {
                Position _position = new Position();
                _position.BaseSalary = baseSalary;
                _position.PositionName = positionNameTextbox.Text;
                _position.DepartmentId = (int)departmentCombobox.SelectedValue;

                PositionValidator posValidator = new PositionValidator();
                ValidationResult res = posValidator.Validate(_position);
                if (!res.IsValid)
                {
                    DisplayValidationErrors(res);
                    return;
                }
                else
                {
                    _positionService.AddPosition(_position);
                    this.Close();
                }
            }
        }
        private void DisplayValidationErrors(ValidationResult result)
        {
            validationErrorProvider.Clear();

            foreach (var error in result.Errors)
            {
                switch (error.PropertyName)
                {
                    case nameof(Position.PositionName):
                        validationErrorProvider.SetError(positionNameTextbox, error.ErrorMessage);
                        break;
                    case nameof(Position.BaseSalary):
                        validationErrorProvider.SetError(baseSalaryTextbox, error.ErrorMessage);
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
