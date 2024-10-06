using CommonLayer.Entities;
using DataAccessLayer.DbConnection;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class PositionRepository
    {
        private SqlDataAccess _dbConnection;

        public PositionRepository()
        {
            _dbConnection = new SqlDataAccess();
        }

        public List<Position> GetPositions()
        {
            List<Position> positions = new List<Position>();

            using (var connection = _dbConnection.GetConnection())
            {
                string query = "SELECT Id, PositionName, BaseSalary, DepartmentId FROM Positions";

                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Position position = new Position();
                    position.Id = (int)reader["Id"];
                    position.PositionName = (string)reader["PositionName"];
                    position.BaseSalary = (int)reader["BaseSalary"];
                    position.DepartmentId = (int)reader["DepartmentId"];

                    positions.Add(position);
                }
            }

            return positions;
        }

        public void AddPosition(Position position)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = "INSERT INTO Positions (PositionName, BaseSalary, DepartmentId) VALUES (@PositionName, @BaseSalary, @DepartmentId)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PositionName", position.PositionName);
                command.Parameters.AddWithValue("@BaseSalary", position.BaseSalary);
                command.Parameters.AddWithValue("@DepartmentId", position.DepartmentId);
                connection.Open();

                command.ExecuteNonQuery();
            }
        }

        public void EditPosition(Position position)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = "UPDATE Positions SET PositionName = @PositionName, BaseSalary = @BaseSalary, DepartmentId = @DepartmentId WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PositionName", position.PositionName);
                command.Parameters.AddWithValue("@BaseSalary", position.BaseSalary);
                command.Parameters.AddWithValue("@DepartmentId", position.DepartmentId);
                command.Parameters.AddWithValue("@Id", position.Id);
                connection.Open();

                command.ExecuteNonQuery();
            }
        }

        public void DeletePosition(int id)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = "DELETE FROM Positions WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);
                connection.Open();

                command.ExecuteNonQuery();
            }
        }
    }
}