using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForm.IRepository.Repository
{
    public class CalculosBalanceRepository : IBalanceRepository
    {
        private readonly string _connectionString;

        public CalculosBalanceRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        //private decimal ExecuteFunction(string functionName, string nombreBG)
        //{
        //    using (SqlConnection connection = new SqlConnection(_connectionString))
        //    {
        //        using (SqlCommand command = new SqlCommand($"SELECT {functionName}(@NombreBG)", connection))
        //        {
        //            command.Parameters.Add(new SqlParameter("@NombreBG", SqlDbType.NVarChar, 150) { Value = nombreBG });
        //            connection.Open();
        //            object result = command.ExecuteScalar();
        //            return result != DBNull.Value ? Convert.ToDecimal(result) : 0;
        //        }
        //    }
        //}
        private decimal ExecuteFunction(string functionName, string parameterName, string parameterValue)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand($"SELECT {functionName}(@{parameterName})", connection))
                {
                    command.Parameters.Add(new SqlParameter($"@{parameterName}", SqlDbType.NVarChar, 150) { Value = parameterValue });
                    connection.Open();
                    object result = command.ExecuteScalar();
                    return result != DBNull.Value ? Convert.ToDecimal(result) : 0;
                }
            }
        }
        public decimal GetTotalActivosCirculantes(string nombreBG)
        {
            return ExecuteFunction("dbo.SumarActivosCirculantesPorBalance", "@nombreBG", nombreBG);
        }

        public decimal GetTotalActivos(string nombreBG)
        {
            return ExecuteFunction("dbo.SumarActivosPorBalance", "@nombreBG", nombreBG);
        }

        public decimal GetActivosFijos(string nombreBG)
        {
            return ExecuteFunction("dbo.ObtenerActivosFijos", "@nombreBG", nombreBG);
        }

        public decimal GetInventario(string nombreBG)
        {
            return ExecuteFunction("dbo.ObtenerInventario", "@nombreBG", nombreBG);
        }

        public decimal GetCuentasxCobrar(string nombreBG)
        {
            return ExecuteFunction("dbo.ObtenerCuentasxCobrar", "@nombreBG", nombreBG);
        }
        public decimal GetTotalPasivos(string nombreBG)
        {
            return ExecuteFunction("dbo.SumarPasivosPorBalance", "@nombreBG", nombreBG);
        }

        public decimal GetPasivosCirculantes(string nombreBG)
        {
            return ExecuteFunction("dbo.SumarPasivoCirculantePorBalance", "@nombreBG", nombreBG);
        }

        public decimal GetPasivosNoCirculantes(string nombreBG)
        {
            return ExecuteFunction("dbo.SumarPasivoNoCirculantePorBalance", "@nombreBG", nombreBG);
        }

        public decimal GetCapitalSocial(string nombreBG)
        {
            return ExecuteFunction("dbo.ObtenerCapitalSocial", "@nombreBG", nombreBG);
        }

        public decimal GetTotalCapital(string nombreBG)
        {
            return ExecuteFunction("dbo.SumarCapitalPorBalance", "@nombreBG", nombreBG);
        }

        public decimal GetVentasNetas(string nombreER)
        {
            return ExecuteFunction("dbo.ObtenerVentasNetas", "@nombreER", nombreER);
        }

        public decimal GetUtilidadOperativa(string nombreER)
        {
            return ExecuteFunction("dbo.ObtenerUtilidadOperativa", "@nombreER", nombreER);
        }

        public decimal GetUtilidadAntesDeInteresesEImpuestos(string nombreER)
        {
            return ExecuteFunction("dbo.ObtenerUtilidadAntesdeInteresesImpuestos", "@nombreER", nombreER);
        }

        public decimal GetCargoPorIntereses(string nombreER)
        {
            return ExecuteFunction("dbo.ObtenerCargoPorIntereses", "@nombreER", nombreER);
        }

        public decimal GetVentasAlCredito(string nombreER)
        {
            return ExecuteFunction("dbo.ObtenerVentasAlCredito", "@nombreER", nombreER);
        }

        public decimal GetCostoDeVenta(string nombreER)
        {
            return ExecuteFunction("dbo.ObtenerCostoDeVenta", "@nombreER", nombreER);
        }

        public decimal GetUtilidadAntesDeImpuestos(string nombreER)
        {
            return ExecuteFunction("dbo.ObtenerUtilidadAntesdeImpuestos", "@nombreER", nombreER);
        }

        public decimal GetUtilidadNeta(string nombreER)
        {
            return ExecuteFunction("dbo.ObtenerUtilidadNeta", "@nombreER", nombreER);
        }

        public decimal GetUtilidadNetaParaAccionistas(string nombreER)
        {
            return ExecuteFunction("dbo.ObtenerUtilidadNetaParaAccionistas", "@nombreER", nombreER);
        }

        public decimal GetAccionesEnCirculacion(string nombreER)
        {
            return ExecuteFunction("dbo.ObtenerAccionesEnCirculacion", "@nombreER", nombreER);
        }

        public decimal GetPrecioMercadoPorAccion(string nombreER)
        {
            return ExecuteFunction("dbo.ObtenerPrecioMercadoPorAccion", "@nombreER", nombreER);
        }
    }
}


