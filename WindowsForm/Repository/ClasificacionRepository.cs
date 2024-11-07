using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsForm.Models;

namespace WindowsForm.Repository
{
    public class ClasificacionRepository : IRepository<Clasificacion>
    {
        private readonly string _connectionString;

        public ClasificacionRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IEnumerable<Clasificacion> GetAll()
        {
            List<Clasificacion> clasificaciones = new List<Clasificacion>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Clasificaciones";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    try
                    {
                        clasificaciones.Add(new Clasificacion
                        {
                            ID_Clasificacion = reader["ID_Clasificacion"] != DBNull.Value ? (int)reader["ID_Clasificacion"] : 0, 
                            Descripcion = reader["Descripcion"] != DBNull.Value ? (string)reader["Descripcion"] : string.Empty 
                        });
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error al leer los datos: " + ex.Message);
                    }
                }
            }
            return clasificaciones;
        }

        public Clasificacion GetById(int id)
        {
            Clasificacion clasificacion = null;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Clasificaciones WHERE ID_Clasificacion = @ID_Clasificacion";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID_Clasificacion", id);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    clasificacion = new Clasificacion
                    {
                        ID_Clasificacion = (int)reader["ID_Clasificacion"],
                        Descripcion = (string)reader["Descripcion"]
                    };
                }
            }
            return clasificacion;
        }

        public void Add(Clasificacion clasificacion)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "INSERT INTO Clasificaciones (Descripcion) VALUES (@Descripcion)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Descripcion", clasificacion.Descripcion);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Update(Clasificacion clasificacion)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "UPDATE Clasificaciones SET Descripcion = @Descripcion WHERE ID_Clasificacion = @ID_Clasificacion";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Descripcion", clasificacion.Descripcion);
                command.Parameters.AddWithValue("@ID_Clasificacion", clasificacion.ID_Clasificacion);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        //Revisar
        public void Delete(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    string query = "DELETE FROM Clasificaciones WHERE ID_Clasificacion = @ID_Clasificacion";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ID_Clasificacion", id);

                    connection.Open();

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected == 0)
                    {
                        throw new Exception("No se encontró ninguna clasificación con ese ID.");
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("Error al intentar eliminar la clasificación porque esta siendo utilizada: ");
            }
        }

    }
}

