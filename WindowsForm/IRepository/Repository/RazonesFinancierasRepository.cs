using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsForm.Models;

namespace WindowsForm.IRepository.Repository
{
    internal class RazonesFinancierasRepository : IRepository<RazonesFinanciera>
    {
        private readonly string _connectionString;

        public RazonesFinancierasRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IEnumerable<RazonesFinanciera> GetAll()
        {
            List<RazonesFinanciera> razonesList = new List<RazonesFinanciera>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM RazonesFinancieras";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    RazonesFinanciera razon = new RazonesFinanciera
                    {
                        ID_RazonesFinancieras = (int)reader["ID_RazonesFinancieras"],
                        ID_CuentasDeRazones = (int)reader["ID_CuentasDeRazones"],
                        ID_DatosBalance = (int)reader["ID_DatosBalance"],
                        ID_DatosER = (int)reader["ID_DatosER"],
                        CapitalTrabajoNeto = (decimal)reader["CapitalTrabajoNeto"],
                        RazonCirculante = (decimal)reader["RazonCirculante"],
                        PruebaAcida = (decimal)reader["PruebaAcida"],
                        RotacionInventario = (decimal)reader["RotacionInventario"],
                        RotacionCuentasPorCobrar = (decimal)reader["RotacionCuentasPorCobrar"],
                        PeriodoPromedioCobro = (decimal)reader["PeriodoPromedioCobro"],
                        RotacionActivosFijos = (decimal)reader["RotacionActivosFijos"],
                        RotacionActivosTotales = (decimal)reader["RotacionActivosTotales"],
                        RazonDeudaTotal = (decimal)reader["RazonDeudaTotal"],
                        RazonPasivoCapital = (decimal)reader["RazonPasivoCapital"],
                        RazonRotacionInteresUtilidad = (decimal)reader["RazonRotacionInteresUtilidad"],
                        MUB = (decimal)reader["MUB"],
                        MUO = (decimal)reader["MUO"],
                        MUN = (decimal)reader["MUN"]
                    };
                    razonesList.Add(razon);
                }
            }
            return razonesList;
        }

        public RazonesFinanciera GetById(int id)
        {
            RazonesFinanciera razon = null;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM RazonesFinancieras WHERE ID_RazonesFinancieras = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    razon = new RazonesFinanciera
                    {
                        ID_RazonesFinancieras = (int)reader["ID_RazonesFinancieras"],
                        ID_CuentasDeRazones = (int)reader["ID_CuentasDeRazones"],
                        ID_DatosBalance = (int)reader["ID_DatosBalance"],
                        ID_DatosER = (int)reader["ID_DatosER"],
                        CapitalTrabajoNeto = (decimal)reader["CapitalTrabajoNeto"],
                        RazonCirculante = (decimal)reader["RazonCirculante"],
                        PruebaAcida = (decimal)reader["PruebaAcida"],
                        RotacionInventario = (decimal)reader["RotacionInventario"],
                        RotacionCuentasPorCobrar = (decimal)reader["RotacionCuentasPorCobrar"],
                        PeriodoPromedioCobro = (decimal)reader["PeriodoPromedioCobro"],
                        RotacionActivosFijos = (decimal)reader["RotacionActivosFijos"],
                        RotacionActivosTotales = (decimal)reader["RotacionActivosTotales"],
                        RazonDeudaTotal = (decimal)reader["RazonDeudaTotal"],
                        RazonPasivoCapital = (decimal)reader["RazonPasivoCapital"],
                        RazonRotacionInteresUtilidad = (decimal)reader["RazonRotacionInteresUtilidad"],
                        MUB = (decimal)reader["MUB"],
                        MUO = (decimal)reader["MUO"],
                        MUN = (decimal)reader["MUN"]
                    };
                }
            }
            return razon;
        }

        public void Add(RazonesFinanciera razon)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = @"INSERT INTO RazonesFinancieras 
                                 (ID_CuentasDeRazones, ID_DatosBalance, ID_DatosER, CapitalTrabajoNeto, RazonCirculante, 
                                  PruebaAcida, RotacionInventario, RotacionCuentasPorCobrar, PeriodoPromedioCobro, 
                                  RotacionActivosFijos, RotacionActivosTotales, RazonDeudaTotal, RazonPasivoCapital, 
                                  RazonRotacionInteresUtilidad, MUB, MUO, MUN) 
                                 VALUES 
                                 (@ID_CuentasDeRazones, @ID_DatosBalance, @ID_DatosER, @CapitalTrabajoNeto, @RazonCirculante, 
                                  @PruebaAcida, @RotacionInventario, @RotacionCuentasPorCobrar, @PeriodoPromedioCobro, 
                                  @RotacionActivosFijos, @RotacionActivosTotales, @RazonDeudaTotal, @RazonPasivoCapital, 
                                  @RazonRotacionInteresUtilidad, @MUB, @MUO, @MUN)";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@ID_CuentasDeRazones", razon.ID_CuentasDeRazones);
                command.Parameters.AddWithValue("@ID_DatosBalance", razon.ID_DatosBalance);
                command.Parameters.AddWithValue("@ID_DatosER", razon.ID_DatosER);
                command.Parameters.AddWithValue("@CapitalTrabajoNeto", razon.CapitalTrabajoNeto);
                command.Parameters.AddWithValue("@RazonCirculante", razon.RazonCirculante);
                command.Parameters.AddWithValue("@PruebaAcida", razon.PruebaAcida);
                command.Parameters.AddWithValue("@RotacionInventario", razon.RotacionInventario);
                command.Parameters.AddWithValue("@RotacionCuentasPorCobrar", razon.RotacionCuentasPorCobrar);
                command.Parameters.AddWithValue("@PeriodoPromedioCobro", razon.PeriodoPromedioCobro);
                command.Parameters.AddWithValue("@RotacionActivosFijos", razon.RotacionActivosFijos);
                command.Parameters.AddWithValue("@RotacionActivosTotales", razon.RotacionActivosTotales);
                command.Parameters.AddWithValue("@RazonDeudaTotal", razon.RazonDeudaTotal);
                command.Parameters.AddWithValue("@RazonPasivoCapital", razon.RazonPasivoCapital);
                command.Parameters.AddWithValue("@RazonRotacionInteresUtilidad", razon.RazonRotacionInteresUtilidad);
                command.Parameters.AddWithValue("@MUB", razon.MUB);
                command.Parameters.AddWithValue("@MUO", razon.MUO);
                command.Parameters.AddWithValue("@MUN", razon.MUN);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Update(RazonesFinanciera razon)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = @"UPDATE RazonesFinancieras SET 
                                 ID_CuentasDeRazones = @ID_CuentasDeRazones,
                                 ID_DatosBalance = @ID_DatosBalance,
                                 ID_DatosER = @ID_DatosER,
                                 CapitalTrabajoNeto = @CapitalTrabajoNeto, 
                                 RazonCirculante = @RazonCirculante,
                                 PruebaAcida = @PruebaAcida,
                                 RotacionInventario = @RotacionInventario,
                                 RotacionCuentasPorCobrar = @RotacionCuentasPorCobrar,
                                 PeriodoPromedioCobro = @PeriodoPromedioCobro,
                                 RotacionActivosFijos = @RotacionActivosFijos,
                                 RotacionActivosTotales = @RotacionActivosTotales,
                                 RazonDeudaTotal = @RazonDeudaTotal,
                                 RazonPasivoCapital = @RazonPasivoCapital,
                                 RazonRotacionInteresUtilidad = @RazonRotacionInteresUtilidad,
                                 MUB = @MUB,
                                 MUO = @MUO,
                                 MUN = @MUN
                                 WHERE ID_RazonesFinancieras = @ID_RazonesFinancieras";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@ID_RazonesFinancieras", razon.ID_RazonesFinancieras);
                command.Parameters.AddWithValue("@ID_CuentasDeRazones", razon.ID_CuentasDeRazones);
                command.Parameters.AddWithValue("@ID_DatosBalance", razon.ID_DatosBalance);
                command.Parameters.AddWithValue("@ID_DatosER", razon.ID_DatosER);
                command.Parameters.AddWithValue("@CapitalTrabajoNeto", razon.CapitalTrabajoNeto);
                command.Parameters.AddWithValue("@RazonCirculante", razon.RazonCirculante);
                command.Parameters.AddWithValue("@PruebaAcida", razon.PruebaAcida);
                command.Parameters.AddWithValue("@RotacionInventario", razon.RotacionInventario);
                command.Parameters.AddWithValue("@RotacionCuentasPorCobrar", razon.RotacionCuentasPorCobrar);
                command.Parameters.AddWithValue("@PeriodoPromedioCobro", razon.PeriodoPromedioCobro);
                command.Parameters.AddWithValue("@RotacionActivosFijos", razon.RotacionActivosFijos);
                command.Parameters.AddWithValue("@RotacionActivosTotales", razon.RotacionActivosTotales);
                command.Parameters.AddWithValue("@RazonDeudaTotal", razon.RazonDeudaTotal);
                command.Parameters.AddWithValue("@RazonPasivoCapital", razon.RazonPasivoCapital);
                command.Parameters.AddWithValue("@RazonRotacionInteresUtilidad", razon.RazonRotacionInteresUtilidad);
                command.Parameters.AddWithValue("@MUB", razon.MUB);
                command.Parameters.AddWithValue("@MUO", razon.MUO);
                command.Parameters.AddWithValue("@MUN", razon.MUN);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "DELETE FROM RazonesFinancieras WHERE ID_RazonesFinancieras = @Id";
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
