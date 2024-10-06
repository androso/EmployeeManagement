using CommonLayer.Entities;
using DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class DepartmentService
    {
        private DepartmentRepository _departmentRepository;

        public DepartmentService()
        {
            _departmentRepository = new DepartmentRepository();
        }

        public List<Department> GetAllDepartments()
        {
            return _departmentRepository.GetDepartments();
        }

        public void AddDepartment(Department department)
        {
            _departmentRepository.AddDepartment(department);
        }

        public void UpdateDepartment(Department department)
        {
            _departmentRepository.EditDepartment(department);
        }

        public void DeleteDepartment(int id)
        {
            _departmentRepository.DeleteDepartment(id);
        }
    }
}