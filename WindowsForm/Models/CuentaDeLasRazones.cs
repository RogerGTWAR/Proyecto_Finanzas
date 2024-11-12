using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForm.Models
{
    public class CuentaDeLasRazones
    {
        public CuentaDeLasRazones() { }

            public int ID_CuentasDeRazones { get; set; }
            public string NombreDeLaEmpresa { get; set; }

            // Balance General
            // Activo
            public decimal ActivoCirculante { get; set; }
            public decimal ActivoFijo { get; set; }
            public decimal ActivoTotal { get; set; }
            public decimal Inventario { get; set; }
            public decimal CuentasPorCobrar { get; set; }

            // Pasivo
            public decimal PasivoCirculante { get; set; }
            public decimal PasivoNoCirculante { get; set; }
            public decimal PasivoTotal { get; set; }

            // Capital
            public decimal CapitalContable { get; set; }
            public decimal CapitalSocial { get; set; }

        // Estado de Resultados
        public decimal VentasCredito { get; set; }
            public decimal VentasNetas { get; set; }
            public decimal CostoVentas { get; set; }
            public decimal UtilidadOperativa { get; set; }
            public decimal UtilidadAntesDeImpuestos { get; set; }
            public decimal UtilidadNeta { get; set; }
            public decimal UtilidadAntesDeInteresesImpuestos { get; set; }
            public decimal CargosporIntereses { get; set; }
            public decimal UtilidadNetaparaAccionista { get; set; }

            // Otras Cuentas (Ratios Financieros)
            public decimal AccionesenCirculacion { get; set; }
            public decimal PreciodelMercadoporAccion { get; set; }
     }

}



