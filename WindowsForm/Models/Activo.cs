using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForm.Models
{
    public class Activo
    {
        public Activo()
        {
        }
        public Activo(string nombreCuenta, decimal monto, decimal total, int clasificacion, int numeroDeBalance = 0)
        {
            ID_DatosBalance = numeroDeBalance;
            NombreCuenta = nombreCuenta;
            Monto = monto;
            Total = total;
            ID_Clasificacion = clasificacion;
        }
        public int ID_Activo { get; set; }
        public int ID_DatosBalance { get; set; }
        public int ID_Clasificacion { get; set; }
        public string NombreCuenta { get; set; }
        public decimal Monto { get; set; }
        public decimal Total { get; set; }

    }
}
