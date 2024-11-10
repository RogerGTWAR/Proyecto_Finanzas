using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsForm.Models;

namespace WindowsForm.IRepository.Repository
{
    public class CuentasRazonesRepository : IRepository<CuentasDeLasRazones>
    {
        private readonly string _connectionString;

        public CuentasRazonesRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Add(CuentasDeLasRazones cuenta)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = @"INSERT INTO CuentasRazones 
                (NombreDeLaEmpresa, ActivoCirculante, PasivoCirculante, Inventario, ActivoTotal, PasivoTotal, 
                CapitalContable, ActivoFijo, InteresesPagados, CuentasPorCobrar, UtilidadOperativa, VentasNetas, 
                CostoVentas, VentasAnuales, UtilidadAntesDeImpuestos, UtilidadNeta) 
                VALUES 
                (@NombreDeLaEmpresa, @ActivoCirculante, @PasivoCirculante, @Inventario, @ActivoTotal, @PasivoTotal, 
                @CapitalContable, @ActivoFijo, @InteresesPagados, @CuentasPorCobrar, @UtilidadOperativa, @VentasNetas, 
                @CostoVentas, @VentasAnuales, @UtilidadAntesDeImpuestos, @UtilidadNeta)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@NombreDeLaEmpresa", cuenta.NombreDeLaEmpresa);
                command.Parameters.AddWithValue("@ActivoCirculante", cuenta.ActivoCirculante);
                command.Parameters.AddWithValue("@PasivoCirculante", cuenta.PasivoCirculante);
                command.Parameters.AddWithValue("@Inventario", cuenta.Inventario);
                command.Parameters.AddWithValue("@ActivoTotal", cuenta.ActivoTotal);
                command.Parameters.AddWithValue("@PasivoTotal", cuenta.PasivoTotal);
                command.Parameters.AddWithValue("@CapitalContable", cuenta.CapitalContable);
                command.Parameters.AddWithValue("@ActivoFijo", cuenta.ActivoFijo);
                command.Parameters.AddWithValue("@InteresesPagados", cuenta.InteresesPagados);
                command.Parameters.AddWithValue("@CuentasPorCobrar", cuenta.CuentasPorCobrar);
                command.Parameters.AddWithValue("@UtilidadOperativa", cuenta.UtilidadOperativa);
                command.Parameters.AddWithValue("@VentasNetas", cuenta.VentasNetas);
                command.Parameters.AddWithValue("@CostoVentas", cuenta.CostoVentas);
                command.Parameters.AddWithValue("@VentasAnuales", cuenta.VentasAnuales);
                command.Parameters.AddWithValue("@UtilidadAntesDeImpuestos", cuenta.UtilidadAntesDeImpuestos);
                command.Parameters.AddWithValue("@UtilidadNeta", cuenta.UtilidadNeta);

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
                string query = "DELETE FROM CuentasRazones WHERE ID_CuentasDeRazones = @ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", id);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<CuentasDeLasRazones> GetAll()
        {
            List<CuentasDeLasRazones> cuentas = new List<CuentasDeLasRazones>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM CuentasRazones";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    CuentasDeLasRazones cuenta = new CuentasDeLasRazones
                    {
                        ID_CuentasDeRazones = (int)reader["ID_CuentasDeRazones"],
                        NombreDeLaEmpresa = (string)reader["NombreDeLaEmpresa"],
                        ActivoCirculante = (decimal)reader["ActivoCirculante"],
                        PasivoCirculante = (decimal)reader["PasivoCirculante"],
                        Inventario = (decimal)reader["Inventario"],
                        ActivoTotal = (decimal)reader["ActivoTotal"],
                        PasivoTotal = (decimal)reader["PasivoTotal"],
                        CapitalContable = (decimal)reader["CapitalContable"],
                        ActivoFijo = (decimal)reader["ActivoFijo"],
                        InteresesPagados = (decimal)reader["InteresesPagados"],
                        CuentasPorCobrar = (decimal)reader["CuentasPorCobrar"],
                        UtilidadOperativa = (decimal)reader["UtilidadOperativa"],
                        VentasNetas = (decimal)reader["VentasNetas"],
                        CostoVentas = (decimal)reader["CostoVentas"],
                        VentasAnuales = (decimal)reader["VentasAnuales"],
                        UtilidadAntesDeImpuestos = (decimal)reader["UtilidadAntesDeImpuestos"],
                        UtilidadNeta = (decimal)reader["UtilidadNeta"]
                    };
                    cuentas.Add(cuenta);
                }
            }
            return cuentas;
        }

        public CuentasDeLasRazones GetById(int id)
        {
            CuentasDeLasRazones cuenta = null;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM CuentasRazones WHERE ID_CuentasDeRazones = @ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", id);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    cuenta = new CuentasDeLasRazones
                    {
                        ID_CuentasDeRazones = (int)reader["ID_CuentasDeRazones"],
                        NombreDeLaEmpresa = (string)reader["NombreDeLaEmpresa"],
                        ActivoCirculante = (decimal)reader["ActivoCirculante"],
                        PasivoCirculante = (decimal)reader["PasivoCirculante"],
                        Inventario = (decimal)reader["Inventario"],
                        ActivoTotal = (decimal)reader["ActivoTotal"],
                        PasivoTotal = (decimal)reader["PasivoTotal"],
                        CapitalContable = (decimal)reader["CapitalContable"],
                        ActivoFijo = (decimal)reader["ActivoFijo"],
                        InteresesPagados = (decimal)reader["InteresesPagados"],
                        CuentasPorCobrar = (decimal)reader["CuentasPorCobrar"],
                        UtilidadOperativa = (decimal)reader["UtilidadOperativa"],
                        VentasNetas = (decimal)reader["VentasNetas"],
                        CostoVentas = (decimal)reader["CostoVentas"],
                        VentasAnuales = (decimal)reader["VentasAnuales"],
                        UtilidadAntesDeImpuestos = (decimal)reader["UtilidadAntesDeImpuestos"],
                        UtilidadNeta = (decimal)reader["UtilidadNeta"]
                    };
                }
            }
            return cuenta;
        }

        public void Update(CuentasDeLasRazones cuenta)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = @"UPDATE CuentasRazones SET 
                                NombreDeLaEmpresa = @NombreDeLaEmpresa, 
                                ActivoCirculante = @ActivoCirculante, 
                                PasivoCirculante = @PasivoCirculante, 
                                Inventario = @Inventario, 
                                ActivoTotal = @ActivoTotal, 
                                PasivoTotal = @PasivoTotal, 
                                CapitalContable = @CapitalContable, 
                                ActivoFijo = @ActivoFijo, 
                                InteresesPagados = @InteresesPagados, 
                                CuentasPorCobrar = @CuentasPorCobrar, 
                                UtilidadOperativa = @UtilidadOperativa, 
                                VentasNetas = @VentasNetas, 
                                CostoVentas = @CostoVentas, 
                                VentasAnuales = @VentasAnuales, 
                                UtilidadAntesDeImpuestos = @UtilidadAntesDeImpuestos, 
                                UtilidadNeta = @UtilidadNeta 
                                WHERE ID_CuentasDeRazones = @ID";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@NombreDeLaEmpresa", cuenta.NombreDeLaEmpresa);
                command.Parameters.AddWithValue("@ActivoCirculante", cuenta.ActivoCirculante);
                command.Parameters.AddWithValue("@PasivoCirculante", cuenta.PasivoCirculante);
                command.Parameters.AddWithValue("@Inventario", cuenta.Inventario);
                command.Parameters.AddWithValue("@ActivoTotal", cuenta.ActivoTotal);
                command.Parameters.AddWithValue("@PasivoTotal", cuenta.PasivoTotal);
                command.Parameters.AddWithValue("@CapitalContable", cuenta.CapitalContable);
                command.Parameters.AddWithValue("@ActivoFijo", cuenta.ActivoFijo);
                command.Parameters.AddWithValue("@InteresesPagados", cuenta.InteresesPagados);
                command.Parameters.AddWithValue("@CuentasPorCobrar", cuenta.CuentasPorCobrar);
                command.Parameters.AddWithValue("@UtilidadOperativa", cuenta.UtilidadOperativa);
                command.Parameters.AddWithValue("@VentasNetas", cuenta.VentasNetas);
                command.Parameters.AddWithValue("@CostoVentas", cuenta.CostoVentas);
                command.Parameters.AddWithValue("@VentasAnuales", cuenta.VentasAnuales);
                command.Parameters.AddWithValue("@UtilidadAntesDeImpuestos", cuenta.UtilidadAntesDeImpuestos);
                command.Parameters.AddWithValue("@UtilidadNeta", cuenta.UtilidadNeta);
                command.Parameters.AddWithValue("@ID", cuenta.ID_CuentasDeRazones);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
