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
        decimal GetTotalPasivos(string nombreBG);
        decimal GetTotalPasivoCirculante(string nombreBG);
        decimal GetTotalPasivoNoCirculante(string nombreBG);
        decimal GetCapitalSocial(string nombreBG);
        decimal GetInventario(string nombreBG);
        decimal GetActivosFijos(string nombreBG);
        decimal GetCuentasPorCobrar(string nombreBG);
        decimal GetTotalCapital(string nombreBG);
    }

}
