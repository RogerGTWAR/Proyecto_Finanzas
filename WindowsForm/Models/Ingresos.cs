using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForm.Models
{
    public class Ingresos
    {
        public Ingresos()
        {
        }
        public int ID_Ingresos { get; set; }
        public string? ID_DatosER { get; set; }
        public int ID_Clasificacion { get; set; }
        public string? NombreDeCuenta {  get; set; }
        public decimal Monto { get; set; }
        public decimal Total { get; set; }

    }
}
