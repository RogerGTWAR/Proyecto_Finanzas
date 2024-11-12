using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForm.Models
{
    public class RazonesFinanciera
    {
        public RazonesFinanciera()
        {
        }
        public int ID_RazonFinanciera { get; set; }
        public int ID_CuentasDeRazones { get; set; }
        public int ID_DatosBalance { get; set; }
        public int ID_DatosER {  get; set; }
        public decimal CapitalTrabajoNeto { get; set; }
        public decimal RazonCirculante { get; set; }
        public decimal PruebaAcida { get; set; }
        public decimal RotacionInventario { get; set; }
        public decimal RotacionCuentasPorCobrar { get; set; }
        public decimal PeriodoPromedioCobro { get; set; }
        public decimal RotacionActivosFijos { get; set; }
        public decimal RotacionActivosTotales { get; set; }
        public decimal RazonDeudaTotal { get; set; }
        public decimal RazonPasivoCapital { get; set; }
        public decimal RazonRotacionInteresUtilidad { get; set; }
        public decimal MUB { get; set; }
        public decimal MUO { get; set; }
        public decimal MUN { get; set; }
        public decimal UtilidadporAccion {  get; set; }
        public decimal RazonPrecio { get; set; }
        public decimal ValorenLibros { get; set; }
        public decimal ValorenLibrosporAccion { get; set; }
    }
}
