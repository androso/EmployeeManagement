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
            _employeeService.UpdateEmployee(new Employee
            {
                Id = selectedEmployee.Id,
                FullName = fullNameTextbox.Text,
                DateOfBirth = DateTime.Parse(birthDate.Text),
                HireDate = DateTime.Parse(hireDate.Text),
                Phone = phone.Text,
                PositionId = (int)positionCombobox.SelectedValue
            });

            this.Close();
            mainForm.Show();
            
        }
    }
}
