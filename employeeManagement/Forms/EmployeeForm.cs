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
    public partial class EmployeeForm : Form
    {
        private MainForm mainForm;
        private EmployeeService _employeeService;
        private PositionService _positionService;
        public EmployeeForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            _employeeService = new EmployeeService();
            _positionService = new PositionService();

            positionCombobox.DataSource = _positionService.GetAllPositions();
            positionCombobox.DisplayMember = "PositionName";
            positionCombobox.ValueMember = "Id";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Close();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            mainForm.Show();
            base.OnFormClosed(e);
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string fullName = fullNameTextbox.Text;
            DateTime dateOfBirth = birthDate.Value;
            DateTime hireDateValue = hireDate.Value;
            string phone = phoneTextbox.Text;
            int positionId = (int)positionCombobox.SelectedValue;

            Employee _em = new Employee();
            _em.FullName = fullName;
            _em.DateOfBirth = dateOfBirth;
            _em.HireDate = hireDateValue;
            _em.Phone = phone;
            _em.PositionId = positionId;

            _employeeService.AddEmployee(_em);

            this.Close();

        }
    }
}
