using SharedModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForm.Models
{
    public class Razones
    { 
        public decimal ActivoCirculante { get; set; }
        public decimal PasivoCirculante { get; set; }
        public decimal Inventario { get; set; }
        public decimal ActivoTotal { get; set; }
        public decimal PasivoTotal { get; set; }
        public decimal InteresesPagados { get; set; }
        public decimal UtilidadOperativa { get; set; }
        public decimal VentasNetas { get; set; }
        public decimal UtilidadNeta { get; set; }
        public decimal InventarioPromedio { get; set; }
        public decimal CostoVentas { get; set; }
        public decimal CapitalContable { get; set; }
        public decimal CuentasPorCobrar { get; set; }
        public decimal VentasAnuales { get; set; }

        public decimal CalcularRazonCorriente()
        {
            return PasivoCirculante != 0 ? ActivoCirculante / PasivoCirculante : 0;
        }
        public decimal CalcularPruebaAcida()
        {
            return PasivoCirculante != 0 ? (ActivoCirculante - Inventario) / PasivoCirculante : 0;
        }
        public decimal CalcularRazonEndeudamiento()
        {
            return ActivoTotal != 0 ? PasivoTotal / ActivoTotal : 0;
        }
        public decimal CalcularCoberturaIntereses()
        {
            return InteresesPagados != 0 ? UtilidadOperativa / InteresesPagados : 0;
        }
        public decimal CalcularMargenUtilidadNeta()
        {
            return VentasNetas != 0 ? UtilidadNeta / VentasNetas : 0;
        }
        public decimal CalcularRetornoSobreActivos()
        {
            return ActivoTotal != 0 ? UtilidadNeta / ActivoTotal : 0;
        }
        public decimal CalcularRotacionInventario()
        {
            return InventarioPromedio != 0 ? CostoVentas / InventarioPromedio : 0;
        }
        public decimal CalcularRetornoSobreCapital()
        {
            return CapitalContable != 0 ? UtilidadNeta / CapitalContable : 0;
        }
        public decimal CalcularRotacionCuentasPorCobrar()
        {
            return VentasAnuales != 0 ? VentasAnuales / CuentasPorCobrar : 0;
        }
        public decimal CalcularPeriodoPromedioCobro()
        {
            return CuentasPorCobrar != 0 ? 365 / CalcularRotacionCuentasPorCobrar() : 0;
        }

        public decimal CalcularMargenBruto()
        {
            return VentasNetas != 0 ? (VentasNetas - CostoVentas) / VentasNetas : 0;
        }
        public decimal CalcularRazonCapitalTrabajo()
        {
            return ActivoCirculante != 0 ? ActivoCirculante - PasivoCirculante : 0;
        }
    }
}


