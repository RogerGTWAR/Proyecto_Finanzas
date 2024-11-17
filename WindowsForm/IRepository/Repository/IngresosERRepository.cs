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
    public class IngresosERRepository : IRepository<Ingreso>
    {
        private readonly string _connectionString;

        public IngresosERRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IEnumerable<Ingreso> GetAll()
        {
            List<Ingreso> ingresosList = new List<Ingreso>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM IngresosER";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ingresosList.Add(new Ingreso
                    {
                        ID_Ingresos = (int)reader["ID_Ingresos"],
                        ID_DatosER = Convert.ToInt32(reader["ID_DatosER"]),
                        ID_Clasificacion = (int)reader["ID_Clasificacion"],
                        NombreDeCuenta = reader["NombreDeCuenta"]?.ToString(),
                        Monto = (decimal)reader["Monto"]
                       
                    });
                }
            }
            return ingresosList;
        }

        public Ingreso GetById(int id)
        {
            Ingreso ingreso = null;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM IngresosER WHERE ID_Ingresos = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    ingreso = new Ingreso
                    {
                        ID_Ingresos = (int)reader["ID_Ingresos"],
                        ID_DatosER = Convert.ToInt32(reader["ID_DatosER"]),
                        ID_Clasificacion = (int)reader["ID_Clasificacion"],
                        NombreDeCuenta = reader["NombreDeCuenta"]?.ToString(),
                        Monto = (decimal)reader["Monto"],
                       
                    };
                }
            }
            return ingreso;
        }

        public void Add(Ingreso ingreso)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "INSERT INTO IngresosER (ID_DatosER, ID_Clasificacion, NombreDeCuenta, Monto) " +
                               "VALUES (@ID_DatosER, @ID_Clasificacion, @NombreDeCuenta, @Monto)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID_DatosER", ingreso.ID_DatosER);
                command.Parameters.AddWithValue("@ID_Clasificacion", ingreso.ID_Clasificacion);
                command.Parameters.AddWithValue("@NombreDeCuenta", ingreso.NombreDeCuenta ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Monto", ingreso.Monto);
               
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Update(Ingreso ingreso)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "UPDATE IngresosER SET ID_DatosER = @ID_DatosER, ID_Clasificacion = @ID_Clasificacion, " +
                               "NombreDeCuenta = @NombreDeCuenta, Monto = @Monto " +
                               "WHERE ID_Ingresos = @ID_Ingresos";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID_Ingresos", ingreso.ID_Ingresos);
                command.Parameters.AddWithValue("@ID_DatosER", ingreso.ID_DatosER);
                command.Parameters.AddWithValue("@ID_Clasificacion", ingreso.ID_Clasificacion);
                command.Parameters.AddWithValue("@NombreDeCuenta", ingreso.NombreDeCuenta ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Monto", ingreso.Monto);
             
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