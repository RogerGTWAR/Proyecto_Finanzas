using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsForm.Estado_de_Resultado_Forms;
using WindowsForm.Models;

namespace WindowsForm.IRepository.Repository
{
    public class GastosERRepository : IRepository<Models.Gasto>
    {

        private readonly string _connectionString;

        public GastosERRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Add(Models.Gasto gastos)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "INSERT INTO GastosER (ID_DatosER, ID_Clasificacion, Nombre, Monto) " +
                               "VALUES (@ID_DatosER, @ID_Clasificacion, @NombreDeCuenta, @Monto)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID_DatosER", gastos.ID_DatosER);
                command.Parameters.AddWithValue("@ID_Clasificacion", gastos.ID_Clasificacion);
                command.Parameters.AddWithValue("@NombreDeCuenta", gastos.NombreDeCuenta ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Monto", gastos.Monto);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Add(Activo newCuenta)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "DELETE FROM GastosER WHERE ID_GastosER = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<Models.Gasto> GetAll()
        {
            List<Models.Gasto> gastos = new List<Models.Gasto>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM GastosER";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    gastos.Add(new Models.Gasto
                    {
                        ID_Gastos = (int)reader["ID_GastosER"],
                        ID_DatosER = Convert.ToInt32(reader["ID_DatosER"]),
                        ID_Clasificacion = (int)reader["ID_Clasificacion"],
                        NombreDeCuenta = reader["Nombre"]?.ToString(),
                        Monto = (decimal)reader["Monto"]

                    });
                }
            }
            return gastos;
        }

        public Models.Gasto GetById(int id)
        {
            Models.Gasto gastos  = null;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM GastosER WHERE ID_GastosER = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    gastos = new Models.Gasto
                    {
                        ID_Gastos = (int)reader["ID_GastosER"],
                        ID_DatosER = Convert.ToInt32(reader["ID_DatosER"]),
                        ID_Clasificacion = (int)reader["ID_Clasificacion"],
                        NombreDeCuenta = reader["NombreDeCuenta"]?.ToString(),
                        Monto = (decimal)reader["Monto"],

                    };
                }
            }
            return gastos;
        }

        public void Update(Models.Gasto gastos)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "UPDATE GastosER SET ID_DatosER = @ID_DatosER, ID_Clasificacion = @ID_Clasificacion, " +
                               "NombreDeCuenta = @NombreDeCuenta, Monto = @Monto " +
                               "WHERE ID_GastosER = @ID_Gastos";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID_Gastos", gastos.ID_Gastos);
                command.Parameters.AddWithValue("@ID_DatosER", gastos.ID_DatosER);
                command.Parameters.AddWithValue("@ID_Clasificacion", gastos.ID_Clasificacion);
                command.Parameters.AddWithValue("@NombreDeCuenta", gastos.NombreDeCuenta ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Monto", gastos.Monto);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
