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

        public DataTable GetDepartments()
        {
            DataTable departmentsTable = new DataTable();

            using (var connection = _dbConnection.GetConnection())
            {
                string query = "SELECT DepartmentID, DepartmentName, Description FROM Departments";

                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                departmentsTable.Load(reader);
            }

            return departmentsTable;
        }

        public void AddDepartment(Department department)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = "INSERT INTO Departments (DepartmentName, Description) VALUES (@DepartmentName, @Description)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@DepartmentName", department.DepartmentName);
                command.Parameters.AddWithValue("@Description", department.Description ?? (object)DBNull.Value);
                connection.Open();

                command.ExecuteNonQuery();
            }
        }

        public void EditDepartment(Department department)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = "UPDATE Departments SET DepartmentName = @DepartmentName, Description = @Description WHERE DepartmentID = @DepartmentID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@DepartmentName", department.DepartmentName);
                command.Parameters.AddWithValue("@Description", department.Description ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@DepartmentID", department.DepartmentID);
                connection.Open();

                command.ExecuteNonQuery();
            }
        }

        public void DeleteDepartment(int departmentID)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = "DELETE FROM Departments WHERE DepartmentID = @DepartmentID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@DepartmentID", departmentID);
                connection.Open();

                command.ExecuteNonQuery();
            }
        }
    }
}