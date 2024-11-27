using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForm.IRepository
{
    public interface IBalanceRepository
    {
        decimal GetTotalActivosCirculantes(string nombreBG);
        decimal GetTotalActivos(string nombreBG);
        decimal GetActivosFijos(string nombreBG);
        decimal GetInventario(string nombreBG);
        decimal GetTotalPasivos(string nombreBG);
        decimal GetPasivosCirculantes(string nombreBG);
        decimal GetPasivosNoCirculantes(string nombreBG);
        decimal GetCapitalSocial(string nombreBG);
        decimal GetTotalCapital(string nombreBG);
        decimal GetVentasNetas(string nombreER);
        decimal GetUtilidadOperativa(string nombreER);
        decimal GetUtilidadAntesDeInteresesEImpuestos(string nombreER);
        decimal GetCargoPorIntereses(string nombreER);
        decimal GetVentasAlCredito(string nombreER);
        decimal GetCostoDeVenta(string nombreER);
        decimal GetUtilidadAntesDeImpuestos(string nombreER);
        decimal GetUtilidadNeta(string nombreER);
        decimal GetUtilidadNetaParaAccionistas(string nombreER);
        decimal GetAccionesEnCirculacion(string nombreER);
        decimal GetPrecioMercadoPorAccion(string nombreER);
    }
}
