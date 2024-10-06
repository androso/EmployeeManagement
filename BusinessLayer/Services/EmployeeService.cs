using CommonLayer.Entities;
using DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class EmployeeService
    {
        private EmployeeRepository _employeeRepository;

        public EmployeeService()
        {
            _employeeRepository = new EmployeeRepository();
        }

        public List<Employee> GetAllEmployees()
        {
            return _employeeRepository.GetEmployees();
        }

        public void AddEmployee(Employee employee)
        {
            if (employee.HireDate > DateTime.Now)
            {
                throw new ArgumentException("Fecha de contratación no puede ser en el futuro");
            }

            _employeeRepository.AddEmployee(employee);
        }

        public void UpdateEmployee(Employee employee)
        {
            if (employee.HireDate > DateTime.Now)
            {
                throw new ArgumentException("Fecha de contratación no puede ser en el futuro");
            }

            _employeeRepository.EditEmployee(employee);
        }

        public void DeleteEmployee(int id)
        {
            _employeeRepository.DeleteEmployee(id);
        }
    }
}
