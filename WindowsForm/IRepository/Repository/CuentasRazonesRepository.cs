using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsForm.Models;

namespace WindowsForm.IRepository.Repository
{
    public class CuentasRazonesRepository : IRepository<CuentaDeLasRazones>
    {
        private readonly string _connectionString;

        public CuentasRazonesRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Add(CuentaDeLasRazones cuenta)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = @"INSERT INTO CuentasRazones 
                (NombreDeLaEmpresa, ActivoCirculante, PasivoCirculante, PasivoNoCirculante, Inventario, 
                ActivoTotal, PasivoTotal, CapitalContable, ActivoFijo, CuentasPorCobrar, UtilidadOperativa, CapitalSocial, 
                VentasCredito, VentasNetas, CostoVentas, UtilidadAntesDeImpuestos, UtilidadNeta, 
                UtilidadAntesDeInteresesImpuestos, CargosporIntereses, UtilidadNetaparaAccionista, 
                AccionesenCirculacion, PreciodelMercadoporAccion) 
                 VALUES 
                 (@NombreDeLaEmpresa, @ActivoCirculante, @PasivoCirculante, @PasivoNoCirculante, @Inventario, 
                @ActivoTotal, @PasivoTotal, @CapitalContable, @ActivoFijo, @CuentasPorCobrar, @UtilidadOperativa, @CapitalSocial, 
                @VentasCredito, @VentasNetas, @CostoVentas, @UtilidadAntesDeImpuestos, @UtilidadNeta, 
                @UtilidadAntesDeInteresesImpuestos, @CargosporIntereses, @UtilidadNetaparaAccionista, 
                @AccionesenCirculacion, @PreciodelMercadoporAccion)";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@NombreDeLaEmpresa", cuenta.NombreDeLaEmpresa);
                command.Parameters.AddWithValue("@ActivoCirculante", cuenta.ActivoCirculante);
                command.Parameters.AddWithValue("@PasivoCirculante", cuenta.PasivoCirculante);
                command.Parameters.AddWithValue("@PasivoNoCirculante", cuenta.PasivoNoCirculante);
                command.Parameters.AddWithValue("@Inventario", cuenta.Inventario);
                command.Parameters.AddWithValue("@ActivoTotal", cuenta.ActivoTotal);
                command.Parameters.AddWithValue("@PasivoTotal", cuenta.PasivoTotal);
                command.Parameters.AddWithValue("@CapitalContable", cuenta.CapitalContable);
                command.Parameters.AddWithValue("@ActivoFijo", cuenta.ActivoFijo);
                command.Parameters.AddWithValue("@CuentasPorCobrar", cuenta.CuentasPorCobrar);
                command.Parameters.AddWithValue("@UtilidadOperativa", cuenta.UtilidadOperativa);
                command.Parameters.AddWithValue("@CapitalSocial", cuenta.CapitalSocial);
                command.Parameters.AddWithValue("@VentasCredito", cuenta.VentasCredito);
                command.Parameters.AddWithValue("@VentasNetas", cuenta.VentasNetas);
                command.Parameters.AddWithValue("@CostoVentas", cuenta.CostoVentas);
                command.Parameters.AddWithValue("@UtilidadAntesDeImpuestos", cuenta.UtilidadAntesDeImpuestos);
                command.Parameters.AddWithValue("@UtilidadNeta", cuenta.UtilidadNeta);
                command.Parameters.AddWithValue("@UtilidadAntesDeInteresesImpuestos", cuenta.UtilidadAntesDeInteresesImpuestos);
                command.Parameters.AddWithValue("@CargosporIntereses", cuenta.CargosporIntereses);
                command.Parameters.AddWithValue("@UtilidadNetaparaAccionista", cuenta.UtilidadNetaparaAccionista);
                command.Parameters.AddWithValue("@AccionesenCirculacion", cuenta.AccionesenCirculacion);
                command.Parameters.AddWithValue("@PreciodelMercadoporAccion", cuenta.PreciodelMercadoporAccion);


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

        public IEnumerable<CuentaDeLasRazones> GetAll()
        {
            List<CuentaDeLasRazones> cuentas = new List<CuentaDeLasRazones>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM CuentasRazones";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    CuentaDeLasRazones cuenta = new CuentaDeLasRazones
                    {
                        ID_CuentasDeRazones = (int)reader["ID_CuentasDeRazones"],
                        NombreDeLaEmpresa = (string)reader["NombreDeLaEmpresa"],
                        ActivoCirculante = (decimal)reader["ActivoCirculante"],
                        PasivoCirculante = (decimal)reader["PasivoCirculante"],
                        PasivoNoCirculante = (decimal)reader["PasivoNoCirculante"],
                        Inventario = (decimal)reader["Inventario"],
                        ActivoTotal = (decimal)reader["ActivoTotal"],
                        PasivoTotal = (decimal)reader["PasivoTotal"],
                        CapitalContable = (decimal)reader["CapitalContable"],
                        ActivoFijo = (decimal)reader["ActivoFijo"],
                        CuentasPorCobrar = (decimal)reader["CuentasPorCobrar"],
                        UtilidadOperativa = (decimal)reader["UtilidadOperativa"],
                        CapitalSocial = (decimal)reader["CapitalSocial"],
                        VentasCredito = (decimal)reader["VentasCredito"],
                        VentasNetas = (decimal)reader["VentasNetas"],
                        CostoVentas = (decimal)reader["CostoVentas"],
                        UtilidadAntesDeImpuestos = (decimal)reader["UtilidadAntesDeImpuestos"],
                        UtilidadNeta = (decimal)reader["UtilidadNeta"],
                        UtilidadAntesDeInteresesImpuestos = (decimal)reader["UtilidadAntesDeInteresesImpuestos"],
                        CargosporIntereses = (decimal)reader["CargosporIntereses"],
                        UtilidadNetaparaAccionista = (decimal)reader["UtilidadNetaparaAccionista"],
                        AccionesenCirculacion = (decimal)reader["AccionesenCirculacion"],
                        PreciodelMercadoporAccion = (decimal)reader["PreciodelMercadoporAccion"]
                    };
                    cuentas.Add(cuenta);
                }
            }
            return cuentas;
        }

        public CuentaDeLasRazones GetById(int id)
        {
            CuentaDeLasRazones cuenta = null;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM CuentasRazones WHERE ID_CuentasDeRazones = @ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", id);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    cuenta = new CuentaDeLasRazones
                    {
                        ID_CuentasDeRazones = (int)reader["ID_CuentasDeRazones"],
                        NombreDeLaEmpresa = (string)reader["NombreDeLaEmpresa"],
                        ActivoCirculante = (decimal)reader["ActivoCirculante"],
                        PasivoCirculante = (decimal)reader["PasivoCirculante"],
                        PasivoNoCirculante = (decimal)reader["PasivoNoCirculante"],
                        Inventario = (decimal)reader["Inventario"],
                        ActivoTotal = (decimal)reader["ActivoTotal"],
                        PasivoTotal = (decimal)reader["PasivoTotal"],
                        CapitalContable = (decimal)reader["CapitalContable"],
                        ActivoFijo = (decimal)reader["ActivoFijo"],
                        CuentasPorCobrar = (decimal)reader["CuentasPorCobrar"],
                        UtilidadOperativa = (decimal)reader["UtilidadOperativa"],
                        CapitalSocial = (decimal)reader["CapitalSocial"],
                        VentasCredito = (decimal)reader["VentasCredito"],
                        VentasNetas = (decimal)reader["VentasNetas"],
                        CostoVentas = (decimal)reader["CostoVentas"],
                        UtilidadAntesDeImpuestos = (decimal)reader["UtilidadAntesDeImpuestos"],
                        UtilidadNeta = (decimal)reader["UtilidadNeta"],
                        UtilidadAntesDeInteresesImpuestos = (decimal)reader["UtilidadAntesDeInteresesImpuestos"],
                        CargosporIntereses = (decimal)reader["CargosporIntereses"],
                        UtilidadNetaparaAccionista = (decimal)reader["UtilidadNetaparaAccionista"],
                        AccionesenCirculacion = (decimal)reader["AccionesenCirculacion"],
                        PreciodelMercadoporAccion = (decimal)reader["PreciodelMercadoporAccion"]
                    };
                }
            }
            return cuenta;
        }

        public void Update(CuentaDeLasRazones ado)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = @"UPDATE CuentasRazones SET 
                         NombreDeLaEmpresa = @NombreDeLaEmpresa, 
                         ActivoCirculante = @ActivoCirculante, 
                         PasivoCirculante = @PasivoCirculante, 
                         PasivoNoCirculante = @PasivoNoCirculante,
                         Inventario = @Inventario, 
                         ActivoTotal = @ActivoTotal, 
                         PasivoTotal = @PasivoTotal, 
                         CapitalContable = @CapitalContable,
                         ActivoFijo = @ActivoFijo,
                         CuentasPorCobrar = @CuentasPorCobrar,
                         UtilidadOperativa = @UtilidadOperativa,
                         CapitalSocial = @CapitalSocial,
                         VentasCredito = @VentasCredito,
                         VentasNetas = @VentasNetas,
                         CostoVentas = @CostoVentas,
                         UtilidadAntesDeImpuestos = @UtilidadAntesDeImpuestos,
                         UtilidadNeta = @UtilidadNeta,
                         UtilidadAntesDeInteresesImpuestos = @UtilidadAntesDeInteresesImpuestos,
                         CargosporIntereses = @CargosporIntereses,
                         UtilidadNetaparaAccionista = @UtilidadNetaparaAccionista,
                         AccionesenCirculacion = @AccionesenCirculacion,
                         PreciodelMercadoporAccion = @PreciodelMercadoporAccion
                         WHERE ID_CuentasDeRazones = @ID";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@NombreDeLaEmpresa", ado.NombreDeLaEmpresa);
                command.Parameters.AddWithValue("@ActivoCirculante", ado.ActivoCirculante);
                command.Parameters.AddWithValue("@PasivoCirculante", ado.PasivoCirculante);
                command.Parameters.AddWithValue("@PasivoNoCirculante", ado.PasivoNoCirculante);
                command.Parameters.AddWithValue("@Inventario", ado.Inventario);
                command.Parameters.AddWithValue("@ActivoTotal", ado.ActivoTotal);
                command.Parameters.AddWithValue("@PasivoTotal", ado.PasivoTotal);
                command.Parameters.AddWithValue("@CapitalContable", ado.CapitalContable);
                command.Parameters.AddWithValue("@ActivoFijo", ado.ActivoFijo);
                command.Parameters.AddWithValue("@CuentasPorCobrar", ado.CuentasPorCobrar);
                command.Parameters.AddWithValue("@UtilidadOperativa", ado.UtilidadOperativa);
                command.Parameters.AddWithValue("@CapitalSocial", ado.CapitalSocial);
                command.Parameters.AddWithValue("@VentasCredito", ado.VentasCredito);
                command.Parameters.AddWithValue("@VentasNetas", ado.VentasNetas);
                command.Parameters.AddWithValue("@CostoVentas", ado.CostoVentas);
                command.Parameters.AddWithValue("@UtilidadAntesDeImpuestos", ado.UtilidadAntesDeImpuestos);
                command.Parameters.AddWithValue("@UtilidadNeta", ado.UtilidadNeta);
                command.Parameters.AddWithValue("@UtilidadAntesDeInteresesImpuestos", ado.UtilidadAntesDeInteresesImpuestos);
                command.Parameters.AddWithValue("@CargosporIntereses", ado.CargosporIntereses);
                command.Parameters.AddWithValue("@UtilidadNetaparaAccionista", ado.UtilidadNetaparaAccionista);
                command.Parameters.AddWithValue("@AccionesenCirculacion", ado.AccionesenCirculacion);
                command.Parameters.AddWithValue("@PreciodelMercadoporAccion", ado.PreciodelMercadoporAccion);
                command.Parameters.AddWithValue("@ID", ado.ID_CuentasDeRazones);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
