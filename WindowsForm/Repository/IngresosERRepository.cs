using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsForm.Models;

namespace WindowsForm.Repository
{
    public class IngresosERRepository : IRepository<Ingresos>
    {
        private readonly string _connectionString;

        public IngresosERRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IEnumerable<Ingresos> GetAll()
        {
            List<Ingresos> ingresosList = new List<Ingresos>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM IngresosER";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ingresosList.Add(new Ingresos
                    {
                        ID_Ingresos = (int)reader["ID_Ingresos"],
                        ID_DatosER = reader["ID_DatosER"]?.ToString(),
                        ID_Clasificacion = (int)reader["ID_Clasificacion"],
                        NombreDeCuenta = reader["NombreDeCuenta"]?.ToString(),
                        Monto = (decimal)reader["Monto"],
                        Total = (decimal)reader["Total"]
                    });
                }
            }
            return ingresosList;
        }

        public Ingresos GetById(int id)
        {
            Ingresos ingreso = null;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM IngresosER WHERE ID_Ingresos = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    ingreso = new Ingresos
                    {
                        ID_Ingresos = (int)reader["ID_Ingresos"],
                        ID_DatosER = reader["ID_DatosER"]?.ToString(),
                        ID_Clasificacion = (int)reader["ID_Clasificacion"],
                        NombreDeCuenta = reader["NombreDeCuenta"]?.ToString(),
                        Monto = (decimal)reader["Monto"],
                        Total = (decimal)reader["Total"]
                    };
                }
            }
            return ingreso;
        }

        public void Add(Ingresos ingreso)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "INSERT INTO IngresosER (ID_DatosER, ID_Clasificacion, NombreDeCuenta, Monto, Total) " +
                               "VALUES (@ID_DatosER, @ID_Clasificacion, @NombreDeCuenta, @Monto, @Total)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID_DatosER", ingreso.ID_DatosER ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@ID_Clasificacion", ingreso.ID_Clasificacion);
                command.Parameters.AddWithValue("@NombreDeCuenta", ingreso.NombreDeCuenta ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Monto", ingreso.Monto);
                command.Parameters.AddWithValue("@Total", ingreso.Total);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Update(Ingresos ingreso)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "UPDATE IngresosER SET ID_DatosER = @ID_DatosER, ID_Clasificacion = @ID_Clasificacion, " +
                               "NombreDeCuenta = @NombreDeCuenta, Monto = @Monto, Total = @Total " +
                               "WHERE ID_Ingresos = @ID_Ingresos";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID_Ingresos", ingreso.ID_Ingresos);
                command.Parameters.AddWithValue("@ID_DatosER", ingreso.ID_DatosER ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@ID_Clasificacion", ingreso.ID_Clasificacion);
                command.Parameters.AddWithValue("@NombreDeCuenta", ingreso.NombreDeCuenta ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Monto", ingreso.Monto);
                command.Parameters.AddWithValue("@Total", ingreso.Total);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "DELETE FROM IngresosER WHERE ID_Ingresos = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);
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