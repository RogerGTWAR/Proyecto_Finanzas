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

        private decimal ExecuteFunction(string functionName, string nombreBG)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand($"SELECT {functionName}(@NombreBG)", connection))
                {
                    command.Parameters.Add(new SqlParameter("@NombreBG", SqlDbType.NVarChar, 150) { Value = nombreBG });
                    connection.Open();
                    object result = command.ExecuteScalar();
                    return result != DBNull.Value ? Convert.ToDecimal(result) : 0;
                }
            }
        }

        public decimal GetTotalActivosCirculantes(string nombreBG)
        {
            return ExecuteFunction("dbo.SumarActivosCirculantesPorBalance", nombreBG);
        }

        public decimal GetTotalActivos(string nombreBG)
        {
            return ExecuteFunction("dbo.SumarActivosPorBalance", nombreBG);
        }

        public decimal GetTotalPasivos(string nombreBG)
        {
            return ExecuteFunction("dbo.SumarPasivosPorBalance", nombreBG);
        }

        public decimal GetTotalPasivoCirculante(string nombreBG)
        {
            return ExecuteFunction("dbo.SumarPasivoCirculantePorBalance", nombreBG);
        }

        public decimal GetTotalPasivoNoCirculante(string nombreBG)
        {
            return ExecuteFunction("dbo.SumarPasivoNoCirculantePorBalance", nombreBG);
        }

        public decimal GetCapitalSocial(string nombreBG)
        {
            return ExecuteFunction("dbo.ObtenerCapitalSocial", nombreBG);
        }

        public decimal GetInventario(string nombreBG)
        {
            return ExecuteFunction("dbo.ObtenerInventario", nombreBG);
        }

        public decimal GetActivosFijos(string nombreBG)
        {
            return ExecuteFunction("dbo.ObtenerActivosFijos", nombreBG);
        }

        public decimal GetCuentasPorCobrar(string nombreBG)
        {
            return ExecuteFunction("dbo.ObtenerCuentasxCobrar", nombreBG);
        }

        public decimal GetTotalCapital(string nombreBG)
        {
            return ExecuteFunction("dbo.SumarCapitalPorBalance", nombreBG);
        }
    }
}

