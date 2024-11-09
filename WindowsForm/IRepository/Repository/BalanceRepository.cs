using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsForm.IRepository;
using WindowsForm.Models;

namespace WindowsForm.IRepository.Repository
{
    public class BalanceRepository : IRepository<DatosBalanceG>
    {
        private readonly string _connectionString;

        public BalanceRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IEnumerable<DatosBalanceG> GetAll()
        {
            List<DatosBalanceG> balances = new List<DatosBalanceG>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM DatosBalance";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    balances.Add(new DatosBalanceG
                    {
                        ID_DatosBalance = (int)reader["ID_DatosBalance"],
                        NombreBG = reader["NombreBG"] != DBNull.Value ? (string)reader["NombreBG"] : string.Empty,
                        FechaInicio = reader["FechaInicio"] != DBNull.Value ? (DateTime)reader["FechaInicio"] : DateTime.MinValue,
                        Fechafin = reader["Fechafin"] != DBNull.Value ? (DateTime)reader["Fechafin"] : DateTime.MinValue
                    });
                }
            }
            return balances;
        }

        public DatosBalanceG GetById(int id)
        {
            DatosBalanceG balance = null;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM DatosBalance WHERE ID_DatosBalance = @ID_DatosBalance";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID_DatosBalance", id);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    balance = new DatosBalanceG
                    {
                        ID_DatosBalance = (int)reader["ID_DatosBalance"],
                        NombreBG = reader["NombreBG"] != DBNull.Value ? (string)reader["NombreBG"] : string.Empty,
                        FechaInicio = reader["FechaInicio"] != DBNull.Value ? (DateTime)reader["FechaInicio"] : DateTime.MinValue,
                        Fechafin = reader["Fechafin"] != DBNull.Value ? (DateTime)reader["Fechafin"] : DateTime.MinValue
                    };
                }
            }
            return balance;
        }

        public void Add(DatosBalanceG balance)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "INSERT INTO DatosBalance (NombreBG, FechaInicio, Fechafin) VALUES (@NombreBG, @FechaInicio, @Fechafin)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@NombreBG", balance.NombreBG);
                command.Parameters.AddWithValue("@FechaInicio", balance.FechaInicio);
                command.Parameters.AddWithValue("@Fechafin", balance.Fechafin);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Update(DatosBalanceG balance)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "UPDATE DatosBalance SET NombreBG = @NombreBG, FechaInicio = @FechaInicio, Fechafin = @Fechafin WHERE ID_DatosBalance = @ID_DatosBalance";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@NombreBG", balance.NombreBG);
                command.Parameters.AddWithValue("@FechaInicio", balance.FechaInicio);
                command.Parameters.AddWithValue("@Fechafin", balance.Fechafin);
                command.Parameters.AddWithValue("@ID_DatosBalance", balance.ID_DatosBalance);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "DELETE FROM DatosBalance WHERE ID_DatosBalance = @ID_DatosBalance";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID_DatosBalance", id);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Add(Activo newCuenta)
        {
            throw new NotImplementedException();
        }
    }
}
