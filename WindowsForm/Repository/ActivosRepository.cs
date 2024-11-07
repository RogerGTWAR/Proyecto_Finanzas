using Microsoft.Data.SqlClient;
using WindowsForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WindowsForm.Repository
{
    public class CuentaRepository : IRepository<Activo>
    {
        private readonly string _connectionString;

        public CuentaRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IEnumerable<Activo> GetAll()
        {
            List<Activo> cuentas = new List<Activo>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Activos";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Activo cuenta = new Activo
                    {
                        ID = (int)reader["ID"],
                        NumeroDeBalance = (int)reader["NumeroDeBalance"],
                        ID_Clasificacion = (int)reader["ID_Clasificacion"],
                        NombreCuenta = (string)reader["NombreCuenta"],
                        Monto = reader["Monto"] != DBNull.Value ? (decimal)reader["Monto"] : 0m,
                        Total = reader["Total"] != DBNull.Value ? (decimal)reader["Total"] : 0m

                    };
                    cuentas.Add(cuenta);
                }
            }
            return cuentas;
        }

        public Activo GetById(int id)
        {
            Activo cuenta = null;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Activos WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    cuenta = new Activo
                    {
                        ID = (int)reader["Id"],
                        NumeroDeBalance = (int)reader["NumeroDeBalance"],
                        ID_Clasificacion = (int)reader["ID_Clasificacion"],
                        NombreCuenta = (string)reader["NombreCuenta"],
                        Monto = reader["Monto"] != DBNull.Value ? (decimal)reader["Monto"] : 0m,
                        Total = reader["Total"] != DBNull.Value ? (decimal)reader["Total"] : 0m

                    };
                }
            }
            return cuenta;
        }


        public void Add(Activo cuenta)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "INSERT INTO Activos (NumeroDeBalance,ID_Clasificacion, NombreCuenta, Monto, Total) VALUES (@NumeroDeBalance,@ID_Clasificacion, @NombreCuenta, @Monto, @Total)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@NumeroDeBalance", cuenta.NumeroDeBalance);
                command.Parameters.AddWithValue("@ID_Clasificacion", cuenta.ID_Clasificacion);
                command.Parameters.AddWithValue("@NombreCuenta", cuenta.NombreCuenta);
                command.Parameters.AddWithValue("@Monto", cuenta.Monto);
                command.Parameters.AddWithValue("@Total", cuenta.Total);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Update(Activo cuenta)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "UPDATE Activos SET NumeroDeBalance = @NumeroDeBalance,ID_Clasificacion = @ID_Clasificacion, NombreCuenta = @NombreCuenta, Monto = @Monto, Total = @Total WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@NumeroDeBalance", cuenta.NumeroDeBalance);
                command.Parameters.AddWithValue("@ID_Clasificacion", cuenta.ID_Clasificacion);
                command.Parameters.AddWithValue("@NombreCuenta", cuenta.NombreCuenta);
                command.Parameters.AddWithValue("@Monto", cuenta.Monto);
                command.Parameters.AddWithValue("@Total", cuenta.Total);
                command.Parameters.AddWithValue("@Id", cuenta.ID);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "DELETE FROM Activos WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public decimal GetTotal()
        {
            decimal total = 0;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT SUM(Monto) FROM Activos";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                total = (decimal)command.ExecuteScalar();
            }
            return total;
        }
        public IEnumerable<Activo> ObtenerID_Balance(int idBalance, string nombreCuenta = null, decimal? monto = null, string color = null)
        {
            List<Activo> cuentasBalance = new List<Activo>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Activos WHERE NumeroDeBalance = @NumeroDeBalance";
                if (!string.IsNullOrEmpty(nombreCuenta))
                {
                    query += " AND NombreCuenta LIKE @NombreCuenta";
                }
                if (monto.HasValue)
                {
                    query += " AND Monto = @Monto";
                }

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@NumeroDeBalance", idBalance);
                if (!string.IsNullOrEmpty(nombreCuenta))
                {
                    command.Parameters.AddWithValue("@NombreCuenta", "%" + nombreCuenta + "%");
                }

                if (monto.HasValue)
                {
                    command.Parameters.AddWithValue("@Monto", monto.Value);
                }

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    cuentasBalance.Add(new Activo
                    {
                        ID = (int)reader["ID"],
                        NumeroDeBalance = (int)reader["NumeroDeBalance"],
                        NombreCuenta = (string)reader["NombreCuenta"],
                        Monto = (decimal)reader["Monto"]
                    });
                }
            }

            return cuentasBalance;
        }
        public IEnumerable<Activo> ObtenerPorClasificacion(int clasificacion, int? numeroDeBalance = null, string nombreCuenta = null, decimal? monto = null)
        {
            List<Activo> cuentasBalance = new List<Activo>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Activos WHERE ID_Clasificacion = @ID_Clasificacion";

                if (numeroDeBalance.HasValue)
                {
                    query += " AND NumeroDeBalance = @NumeroDeBalance";
                }
                if (!string.IsNullOrEmpty(nombreCuenta))
                {
                    query += " AND NombreCuenta LIKE @NombreCuenta";
                }
                if (monto.HasValue)
                {
                    query += " AND Monto = @Monto";
                }

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID_Clasificacion", clasificacion);

                if (numeroDeBalance.HasValue)
                {
                    command.Parameters.AddWithValue("@NumeroDeBalance", numeroDeBalance.Value);
                }

                if (!string.IsNullOrEmpty(nombreCuenta))
                {
                    command.Parameters.AddWithValue("@NombreCuenta", "%" + nombreCuenta + "%");
                }

                if (monto.HasValue)
                {
                    command.Parameters.AddWithValue("@Monto", monto.Value);
                }

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    cuentasBalance.Add(new Activo
                    {
                        ID = (int)reader["ID"],
                        ID_Clasificacion = (int)reader["ID_Clasificacion"],
                        NumeroDeBalance = (int)reader["NumeroDeBalance"],
                        NombreCuenta = (string)reader["NombreCuenta"],
                        Monto = (decimal)reader["Monto"]
                    });
                }
            }

            return cuentasBalance;
        }


    }
}



