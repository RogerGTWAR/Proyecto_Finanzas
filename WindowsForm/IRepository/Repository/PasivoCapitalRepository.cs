using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsForm.IRepository;
using WindowsForm.Models;

namespace WindowsForm.IRepository.Repository
{
    public class Pasivo_CapitalRepository : IRepository<Pasivo_Capital>
    {
        private readonly string _connectionString;

        public Pasivo_CapitalRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        public IEnumerable<Pasivo_Capital> GetAll()
        {
            List<Pasivo_Capital> cuentas = new List<Pasivo_Capital>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Pasivos_Capital";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Pasivo_Capital cuenta = new Pasivo_Capital
                    {
                        ID_Pasivo_Capital = (int)reader["ID_Pasivo_Capital"],
                        ID_DatosBalance = (int)reader["ID_DatosBalance"],
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


        public Pasivo_Capital GetById(int id)
        {
            Pasivo_Capital cuenta = null;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Pasivos_Capital WHERE ID_Pasivo_Capital = @ID_Pasivo_Capital";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    cuenta = new Pasivo_Capital
                    {
                        ID_Pasivo_Capital = (int)reader["ID_Pasivo_Capital"],
                        ID_DatosBalance = (int)reader["ID_DatosBalance"],
                        ID_Clasificacion = (int)reader["ID_Clasificacion"],
                        NombreCuenta = (string)reader["NombreCuenta"],
                        Monto = reader["Monto"] != DBNull.Value ? (decimal)reader["Monto"] : 0m,
                        Total = reader["Total"] != DBNull.Value ? (decimal)reader["Total"] : 0m

                    };
                }
            }
            return cuenta;
        }


        public void Add(Pasivo_Capital cuenta)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "INSERT INTO Pasivos_Capital (ID_DatosBalance,ID_Clasificacion, NombreCuenta, Monto, Total) VALUES (@ID_DatosBalance,@ID_Clasificacion, @NombreCuenta, @Monto, @Total)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID_DatosBalance", cuenta.ID_DatosBalance);
                command.Parameters.AddWithValue("@ID_Clasificacion", cuenta.ID_Clasificacion);
                command.Parameters.AddWithValue("@NombreCuenta", cuenta.NombreCuenta);
                command.Parameters.AddWithValue("@Monto", cuenta.Monto);
                command.Parameters.AddWithValue("@Total", cuenta.Total);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Update(Pasivo_Capital cuenta)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "UPDATE Pasivos_Capital SET ID_DatosBalance = @ID_DatosBalance,ID_Clasificacion = @ID_Clasificacion, NombreCuenta = @NombreCuenta, Monto = @Monto, Total = @Total WHERE ID_Pasivo_Capital = @ID_Pasivo_Capital";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID_DatosBalance", cuenta.ID_DatosBalance);
                command.Parameters.AddWithValue("@ID_Clasificacion", cuenta.ID_Clasificacion);
                command.Parameters.AddWithValue("@NombreCuenta", cuenta.NombreCuenta);
                command.Parameters.AddWithValue("@Monto", cuenta.Monto);
                command.Parameters.AddWithValue("@Total", cuenta.Total);
                command.Parameters.AddWithValue("@ID_Pasivo_Capital", cuenta.ID_Pasivo_Capital);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "DELETE FROM Pasivos_Capital WHERE ID_Pasivo_Capital = @ID_Pasivo_Capital";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID_Pasivo_Capital", id);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public decimal GetTotal()
        {
            decimal total = 0;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT SUM(Monto) FROM Pasivos_Capital";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                total = (decimal)command.ExecuteScalar();
            }
            return total;
        }
        public IEnumerable<Pasivo_Capital> ObtenerID_Balance(int idBalance, string nombreCuenta = null, decimal? monto = null, string color = null)
        {
            List<Pasivo_Capital> cuentasBalance = new List<Pasivo_Capital>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Pasivos_Capital WHERE ID_DatosBalance = @ID_DatosBalance";
                if (!string.IsNullOrEmpty(nombreCuenta))
                {
                    query += " AND NombreCuenta LIKE @NombreCuenta";
                }
                if (monto.HasValue)
                {
                    query += " AND Monto = @Monto";
                }

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID_DatosBalance", idBalance);
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
                    cuentasBalance.Add(new Pasivo_Capital
                    {
                        ID_Pasivo_Capital = (int)reader["ID_Pasivo_Capital"],
                        ID_DatosBalance = (int)reader["ID_DatosBalance"],
                        NombreCuenta = (string)reader["NombreCuenta"],
                        Monto = (decimal)reader["Monto"]
                    });
                }
            }

            return cuentasBalance;
        }
        public IEnumerable<Pasivo_Capital> ObtenerPorClasificacion(int clasificacion, int? numeroDeBalance = null, string nombreCuenta = null, decimal? monto = null)
        {
            List<Pasivo_Capital> cuentasBalance = new List<Pasivo_Capital>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Pasivos_Capital WHERE ID_Clasificacion = @ID_Clasificacion";

                if (numeroDeBalance.HasValue)
                {
                    query += " AND ID_DatosBalance = @ID_DatosBalance";
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
                    command.Parameters.AddWithValue("@ID_DatosBalance", numeroDeBalance.Value);
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
                    cuentasBalance.Add(new Pasivo_Capital
                    {
                        ID_Pasivo_Capital = (int)reader["ID_Pasivo_Capital"],
                        ID_Clasificacion = (int)reader["ID_Clasificacion"],
                        ID_DatosBalance = (int)reader["ID_DatosBalance"],
                        NombreCuenta = (string)reader["NombreCuenta"],
                        Monto = (decimal)reader["Monto"]
                    });
                }
            }

            return cuentasBalance;
        }

        public void Add(Activo newCuenta)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "INSERT INTO Pasivos_Capital (ID_DatosBalance,ID_Clasificacion, NombreCuenta, Monto, Total) VALUES (@ID_DatosBalance,@ID_Clasificacion, @NombreCuenta, @Monto, @Total)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID_DatosBalance", newCuenta.ID_DatosBalance);
                command.Parameters.AddWithValue("@ID_Clasificacion", newCuenta.ID_Clasificacion);
                command.Parameters.AddWithValue("@NombreCuenta", newCuenta.NombreCuenta);
                command.Parameters.AddWithValue("@Monto", newCuenta.Monto);
                command.Parameters.AddWithValue("@Total", newCuenta.Total);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}





