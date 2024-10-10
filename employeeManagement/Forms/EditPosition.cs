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
    public partial class EditPosition : Form
    {
        private MainForm _mainForm;
        private Position _position;
        private PositionService _positionService;
        private DepartmentService _departmentService;

        public EditPosition(MainForm mainForm, Position position)
        {
            this._mainForm = mainForm;
            this._position = position;

            this._positionService = new PositionService();
            this._departmentService = new DepartmentService();

            InitializeComponent();
            baseSalaryTextbox.Text = position.BaseSalary.ToString();
            positionNameTextbox.Text = position.PositionName;
            departmentCombobox.DataSource = _departmentService.GetAllDepartments();
            departmentCombobox.DisplayMember = "DepartmentName";
            departmentCombobox.ValueMember = "Id";
            departmentCombobox.SelectedValue = position.DepartmentId;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            decimal baseSalary;

            if (decimal.TryParse(baseSalaryTextbox.Text, out baseSalary))
            {
                _position.BaseSalary = baseSalary;
                _position.PositionName = positionNameTextbox.Text;
                _position.DepartmentId = (int)departmentCombobox.SelectedValue;

                _positionService.UpdatePosition(_position);

                this.Close();
            }
        }
    }
}
