using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using WindowsForm.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WindowsForm.Repository
{
    public class DatosERRepository : IRepository<DatosER>
    {
        private readonly string _connectionString;

        public DatosERRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        public IEnumerable<DatosER> GetAll()
        {
            List<DatosER> datosList = new List<DatosER>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM DatosERx";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    try
                    {
                        datosList.Add(new DatosER
                        {
                            ID_DatosER = reader["ID_DatosER"] != DBNull.Value ? (int)reader["ID_DatosER"] : 0,
                            NombreER = reader["NombreER"] != DBNull.Value ? (string)reader["NombreER"] : string.Empty,
                            FechaInicio = reader["FechaInicio"] != DBNull.Value ? (DateTime)reader["FechaInicio"] : DateTime.MinValue,
                            Fechafin = reader["Fechafin"] != DBNull.Value ? (DateTime)reader["Fechafin"] : DateTime.MinValue

                        });
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error al leer los datos: " + ex.Message);
                    }
                }
            }
            return datosList;
        }

        public DatosER GetById(int id)
        {
            DatosER dato = null;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM DatosERx WHERE ID_DatosER = @ID_DatosER";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID_DatosER", id);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    dato = new DatosER
                    {
                        ID_DatosER = (int)reader["ID_DatosER"],
                        NombreER = (string)reader["NombreER"],
                        FechaInicio = (DateTime)reader["FechaInicio"],
                        Fechafin = (DateTime)reader["Fechafin"]
                    };
                }
            }
            return dato;
        }
        public void Add(DatosER dato)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "INSERT INTO DatosERx (NombreER, FechaInicio, Fechafin) VALUES (@NombreER, @FechaInicio, @Fechafin)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@NombreER", dato.NombreER);
                command.Parameters.AddWithValue("@FechaInicio", dato.FechaInicio);
                command.Parameters.AddWithValue("@Fechafin", dato.Fechafin);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Update(DatosER dato)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "UPDATE DatosERx SET NombreER = @NombreER, FechaInicio = @FechaInicio, Fechafin = @Fechafin WHERE ID_DatosER = @ID_DatosER";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@NombreER", dato.NombreER);
                command.Parameters.AddWithValue("@FechaInicio", dato.FechaInicio);
                command.Parameters.AddWithValue("@Fechafin", dato.Fechafin);
                command.Parameters.AddWithValue("@ID_DatosER", dato.ID_DatosER);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "DELETE FROM DatosERx WHERE ID_DatosER = @ID_DatosER";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID_DatosER", id);
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
