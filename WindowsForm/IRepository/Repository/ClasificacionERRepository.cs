using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsForm.Models;

namespace WindowsForm.IRepository.Repository
{
    public class ClasificacionERRepository : IRepository<ClasificacionER>
    {
        private readonly string _connectionString;

        public ClasificacionERRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IEnumerable<ClasificacionER> GetAll()
        {
            List<ClasificacionER> clasificaciones = new List<ClasificacionER>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM ClasificacionesER";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    try
                    {
                        clasificaciones.Add(new ClasificacionER
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

        public ClasificacionER GetById(int id)
        {
            ClasificacionER clasificacion = null;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM ClasificacionesER WHERE ID_Clasificacion = @ID_Clasificacion";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID_Clasificacion", id);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    clasificacion = new ClasificacionER
                    {
                        ID_Clasificacion = (int)reader["ID_Clasificacion"],
                        Descripcion = (string)reader["Descripcion"]
                    };
                }
            }
            return clasificacion;
        }

        public int? GetIdByDescrip(string descrip)
        {
            string query = "Select TOP 1 ID_Clasificacion from ClasificacionesER where Descripcion = @Descripcion";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@Descripcion", descrip);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    // Si el resultado no es nulo, convierte el valor a int y devuélvelo
                    if (result != null && int.TryParse(result.ToString(), out int idClasi))
                    {
                        return idClasi;
                    }
                    else
                    {
                        return null; // Si no hay resultados, devuelve null
                    }

                }
                catch (Exception e)
                {
                    throw new Exception("Error: " + e.Message);
                }
            }
        }

        public void Add(ClasificacionER clasificacion)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "INSERT INTO ClasificacionesER (Descripcion) VALUES (@Descripcion)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Descripcion", clasificacion.Descripcion);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Update(ClasificacionER clasificacion)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "UPDATE ClasificacionesER SET Descripcion = @Descripcion WHERE ID_Clasificacion = @ID_Clasificacion";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Descripcion", clasificacion.Descripcion);
                command.Parameters.AddWithValue("@ID_Clasificacion", clasificacion.ID_Clasificacion);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        
        public void Delete(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    string query = "DELETE FROM ClasificacionesER WHERE ID_Clasificacion = @ID_Clasificacion";
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

        public void Add(Activo newCuenta)
        {
            //using (SqlConnection connection = new SqlConnection(_connectionString))
            //{
            //    string query = "INSERT INTO Activos (NumeroDeBalance) VALUES (@NumeroDeBalance)";
            //    SqlCommand command = new SqlCommand(query, connection);
            //    command.Parameters.AddWithValue("@NumeroDeBalance", newCuenta.ID_DatosBalance);
            //    connection.Open();
            //    command.ExecuteNonQuery();
            //}
        }

        public List<string> GetClasificacionesER()
        {
            List<string> lista = new List<string>();
            DataTable clasif = new DataTable();
            string query = "SELECT Descripcion FROM ClasificacionesER";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                try
                {
                    connection.Open();
                    adapter.Fill(clasif);

                    // Recorrer cada fila del DataTable y agregar la ubicación a la lista
                    foreach (DataRow row in clasif.Rows)
                    {
                        lista.Add(row["Descripcion"].ToString());
                    }
                }
                catch (Exception e)
                {
                    throw new Exception("Error: " + e.Message);
                }
            }
            return lista;
        }
    }
}
