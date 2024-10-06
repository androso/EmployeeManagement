using CommonLayer.Entities;
using DataAccessLayer.DbConnection;
using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace DataAccessLayer.Repositories
{
    public class EmployeeRepository
    {
        private SqlDataAccess _dbConnection;

        public EmployeeRepository()
        {
            _dbConnection = new SqlDataAccess();
        }

        public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();

            using (var connection = _dbConnection.GetConnection())
            {
                string query = "SELECT Id, FullName, DateOfBirth, HireDate, Phone, PositionId FROM Employees";

                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while(reader.Read())
                {
                    Employee employee = new Employee
                    {
                        Id = (int)reader["Id"],
                        FullName = (string)reader["FullName"],
                        DateOfBirth = reader["DateOfBirth"] != DBNull.Value ? (DateTime)reader["DateOfBirth"] : null,
                        HireDate = (DateTime)reader["HireDate"],
                        Phone = reader["Phone"] != DBNull.Value ? (string)reader["Phone"] : null,
                        PositionId = (int)reader["PositionId"]
                    };

                    employees.Add(employee);
                }
            }

            return employees;
        }

        public void AddEmployee(Employee employee)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = "INSERT INTO Employees (FullName, DateOfBirth, HireDate, Phone, PositionId) VALUES (@FullName, @DateOfBirth, @HireDate, @Phone, @PositionId)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@FullName", employee.FullName);
                command.Parameters.AddWithValue("@DateOfBirth", employee.DateOfBirth ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@HireDate", employee.HireDate);
                command.Parameters.AddWithValue("@Phone", employee.Phone ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@PositionId", employee.PositionId);
                connection.Open();

                command.ExecuteNonQuery();
            }
        }

        public void EditEmployee(Employee employee)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = "UPDATE Employees SET FullName = @FullName, DateOfBirth = @DateOfBirth, HireDate = @HireDate, Phone = @Phone, PositionId = @PositionId WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@FullName", employee.FullName);
                command.Parameters.AddWithValue("@DateOfBirth", employee.DateOfBirth ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@HireDate", employee.HireDate);
                command.Parameters.AddWithValue("@Phone", employee.Phone ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@PositionId", employee.PositionId);
                command.Parameters.AddWithValue("@Id", employee.Id);
                connection.Open();

                command.ExecuteNonQuery();
            }
        }

        public void DeleteEmployee(int id)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = "DELETE FROM Employees WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);
                connection.Open();

                command.ExecuteNonQuery();
            }
        }
    }
}