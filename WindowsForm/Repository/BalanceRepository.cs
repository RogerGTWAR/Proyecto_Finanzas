using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsForm.Models;

namespace WindowsForm.Repository
{
    public class BalanceRepository : IRepository<NumeroDeBalances>
    {
        private readonly string _connectionString;

        public BalanceRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IEnumerable<NumeroDeBalances> GetAll()
        {
            List<NumeroDeBalances> balanceIds = new List<NumeroDeBalances>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM NumerosDeBalance";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    balanceIds.Add(new NumeroDeBalances
                    {
                        ID = (int)reader["ID"],
                        NumeroDeBalance = (int)reader["NumeroDeBalance"],
                    });
                }
            }
            return balanceIds;
        }

        public NumeroDeBalances GetById(int id)
        {
            NumeroDeBalances balanceId = null;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM NumerosDeBalance WHERE ID = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    balanceId = new NumeroDeBalances
                    {
                        ID = (int)reader["ID"],
                        NumeroDeBalance = (int)reader["NumeroDeBalance"]
                    };
                }
            }
            return balanceId;
        }

        public void Add(NumeroDeBalances balanceId)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "INSERT INTO NumerosDeBalance (NumeroDeBalance) VALUES (@NumeroDeBalance)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@NumeroDeBalance", balanceId.NumeroDeBalance);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Update(NumeroDeBalances balanceId)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "UPDATE NumerosDeBalance SET NumeroDeBalance = @NumeroDeBalance WHERE NumeroDeBalance = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@NumeroDeBalance", balanceId.NumeroDeBalance);
                command.Parameters.AddWithValue("@Id", balanceId.NumeroDeBalance);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "DELETE FROM NumerosDeBalance WHERE NumeroDeBalance = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Add(Activo newCuenta)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "INSERT INTO NumerosDeBalance (NumeroDeBalance) VALUES (@NumeroDeBalance)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@NumeroDeBalance", newCuenta.NumeroDeBalance);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
