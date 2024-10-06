using CommonLayer.Entities;
using DataAccessLayer.DbConnection;
using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace DataAccessLayer.Repositories
{
    public class DepartmentRepository
    {
        private SqlDataAccess _dbConnection;

        public DepartmentRepository()
        {
            _dbConnection = new SqlDataAccess();
        }

        public List<Department> GetDepartments()
        {
            List<Department> departments = new List<Department>();

            using (var connection = _dbConnection.GetConnection())
            {
                string query = "SELECT Id, DepartmentName, Description FROM Departments";

                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Department department = new Department();
                    department.Id = (int)reader["Id"];
                    department.DepartmentName = (string)reader["DepartmentName"];
                    department.Description = reader["Description"] != DBNull.Value ? (string)reader["Description"] : null;

                    departments.Add(department);
                }
            }

            return departments;
        }


        public void AddDepartment(Department department)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = "INSERT INTO Departments (DepartmentName, Description) VALUES (@DepartmentName, @Description)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@DepartmentName", department.DepartmentName);
                command.Parameters.AddWithValue("@Description", (object)department.Description ?? DBNull.Value);
                connection.Open();

                command.ExecuteNonQuery();
            }
        }

        public void EditDepartment(Department department)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = "UPDATE Departments SET DepartmentName = @DepartmentName, Description = @Description WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@DepartmentName", department.DepartmentName);
                command.Parameters.AddWithValue("@Description", (object)department.Description ?? DBNull.Value);
                command.Parameters.AddWithValue("@Id", department.Id);
                connection.Open();

                command.ExecuteNonQuery();
            }
        }

        public void DeleteDepartment(int id)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = "DELETE FROM Departments WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);
                connection.Open();

                command.ExecuteNonQuery();
            }
        }
    }
}