using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForm.Models
{
    public class CuentasDeLasRazones
    {
        public CuentasDeLasRazones() { }
        public int ID_CuentasDeRazones { get; set; }
        public string NombreDeLaEmpresa { get; set; }
        public decimal ActivoCirculante { get; set; }
        public decimal PasivoCirculante { get; set; }
        public decimal Inventario { get; set; }
        public decimal ActivoTotal { get; set; }
        public decimal PasivoTotal { get; set; }
        public decimal CapitalContable { get; set; }
        public decimal ActivoFijo { get; set; }
        public decimal InteresesPagados { get; set; }
        public decimal CuentasPorCobrar { get; set; }
        public decimal UtilidadOperativa { get; set; }
        public decimal VentasNetas { get; set; }
        public decimal CostoVentas { get; set; }
        public decimal VentasAnuales { get; set; }
        public decimal UtilidadAntesDeImpuestos { get; set; }
        public decimal UtilidadNeta { get; set; }

        public decimal CalcularCapitalTrabajo()
        {
            return ActivoCirculante - PasivoCirculante;
        }

        public decimal CalcularRazonCorriente()
        {
            return PasivoCirculante != 0 ? ActivoCirculante / PasivoCirculante : 0;
        }

        public decimal CalcularPruebaAcida()
        {
            return PasivoCirculante != 0 ? (ActivoCirculante - Inventario) / PasivoCirculante : 0;
        }

        // Métodos de Actividad
        //public decimal CalcularRotacionInventario()
        //{
        //    return InventarioPromedio != 0 ? CostoVentas / InventarioPromedio : 0;
        //}

        public decimal CalcularRotacionCuentasPorCobrar()
        {
            return VentasAnuales != 0 ? VentasAnuales / CuentasPorCobrar : 0;
        }

        public decimal CalcularPeriodoPromedioCobro()
        {
            return CalcularRotacionCuentasPorCobrar() != 0 ? 365 / CalcularRotacionCuentasPorCobrar() : 0;
        }

        public decimal CalcularRotacionActivosFijos()
        {
            return ActivoFijo != 0 ? VentasNetas / ActivoFijo : 0;
        }

        public decimal CalcularRotacionActivosTotales()
        {
            return ActivoTotal != 0 ? VentasNetas / ActivoTotal : 0;
        }

        // Métodos de Endeudamiento
        public decimal CalcularRazonDeudaTotal()
        {
            return ActivoTotal != 0 ? PasivoTotal / ActivoTotal : 0;
        }

        public decimal CalcularRazonPasivoCapital()
        {
            return CapitalContable != 0 ? PasivoTotal / CapitalContable : 0;
        }

        public decimal CalcularCoberturaIntereses()
        {
            return InteresesPagados != 0 ? UtilidadOperativa / InteresesPagados : 0;
        }

        // Métodos de Rentabilidad
        public decimal CalcularMargenUtilidadBruta()
        {
            return VentasNetas != 0 ? (VentasNetas - CostoVentas) / VentasNetas : 0;
        }

        public decimal CalcularMargenUtilidadOperativa()
        {
            return VentasNetas != 0 ? UtilidadOperativa / VentasNetas : 0;
        }

        public decimal CalcularMargenUtilidadNeta()
        {
            return VentasNetas != 0 ? UtilidadNeta / VentasNetas : 0;
        }
    }
}


