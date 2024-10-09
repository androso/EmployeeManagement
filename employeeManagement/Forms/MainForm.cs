﻿using BusinessLayer.Services;
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
    public partial class MainForm : Form
    {
        private EmployeeService _employeeService;
        private DepartmentService _departmentService;
        private PositionService _positionService;
        public MainForm()
        {
            InitializeComponent();
            _employeeService = new EmployeeService();
            _departmentService = new DepartmentService();
            _positionService = new PositionService();
            LoadEmployeeData();
        }
        private void LoadEmployeeData()
        {
            comboBox1.SelectedValue = "Empleado";
            comboBox1.Text = "Empleado";
            dataGridView1.DataSource = _employeeService.GetAllEmployees();
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
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un tipo de datos");
                return;
            }

            if (dataGridView1.SelectedRows.Count == 1)
            {
                // Obtener el valor seleccionado del combobox1
                string selectedValue = comboBox1.SelectedItem.ToString();

                // Si es empleado, abrir el formulario de empleado con los datos del empleado seleccionado

                if (selectedValue == "Empleado")
                {
                    Employee selectedEmployee = dataGridView1.SelectedRows[0].DataBoundItem as Employee;
                    if (selectedEmployee != null)
                    {
                        EditEmployee employeForm = new EditEmployee(this, selectedEmployee);
                        employeForm.Show();
                        employeForm.FormClosed += (s, args) => LoadEmployeeData();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo obtener el empleado seleccionado.");
                    }
                }
                // Si es departamento, abrir el formulario de departamento con los datos del departamento seleccionado
                else if (selectedValue == "Departamento")
                {
                    // Obtener el departamento seleccionado
                    Department selectedDepartment = dataGridView1.SelectedRows[0].DataBoundItem as  Department;

                    EditDepartment editDepartmentForm = new EditDepartment(this, selectedDepartment);
                    editDepartmentForm.Show();
                    editDepartmentForm.FormClosed += (s, args) => dataGridView1.DataSource = _departmentService.GetAllDepartments();
                }
                // Si es posición, abrir el formulario de posición con los datos de la posición seleccionada
                else if (selectedValue == "Posición")
                {
                    // Obtener la posición seleccionada
                    //Position selectedPosition = (Position)dataGridView1.SelectedRows[0].DataBoundItem;

                    // Abrir el formulario de posición con los datos de la posición seleccionada
                    //PositionForm positionForm = new PositionForm(this, selectedPosition);
                    //positionForm.Show();
                    //this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un registro");
            }
        }

        private void EmployeForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void EditDepartmentForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = comboBox1.SelectedItem.ToString();
            if (selectedValue == "Departamento")
            {
                dataGridView1.DataSource = _departmentService.GetAllDepartments();
            }
            else if (selectedValue == "Posición")
            {
                dataGridView1.DataSource = _positionService.GetAllPositions();
            }
            else if (selectedValue == "Empleado")
            {
                dataGridView1.DataSource = _employeeService.GetAllEmployees();
            }
            else
            {
                MessageBox.Show("Seleccione una opción");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                string selectedValue = comboBox1.SelectedItem.ToString();
                object selectedItem = dataGridView1.SelectedRows[0].DataBoundItem;

                
                switch (selectedValue)
                {
                    case "Empleado":
                        if (MessageBox.Show("¿Está seguro de que desea eliminar este registro?", "Confirmar eliminación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            Employee selectedEmployee = selectedItem as Employee;
                            _employeeService.DeleteEmployee(selectedEmployee.Id);
                            LoadEmployeeData();
                        } 
                        break;
                    case "Departamento":
                        Department selectedDepartment = selectedItem as Department;
                        if (MessageBox.Show("Si elimina este departamento, se eliminarán todos los empleados y posiciones asociados. ¿Está seguro de que desea continuar?", "Confirmar eliminación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            _departmentService.DeleteDepartment(selectedDepartment.Id);
                            LoadEmployeeData();
                        }
                        break;
                    case "Posición":
                        if (MessageBox.Show("Si elimina esta posición, se eliminarán todos los empleados asociados. ¿Está seguro de que desea continuar?", "Confirmar eliminación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            Position selectedPosition = selectedItem as Position;
                            _positionService.DeletePosition(selectedPosition.Id);
                            LoadEmployeeData();
                        }
                        break;
                    default:
                        break;
                }
                
            }
            else
            {
                MessageBox.Show("Seleccione un registro");
            }
        }
    }
}
