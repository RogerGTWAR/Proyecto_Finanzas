using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForm.Models
{
    public class Ingreso
    {
        public Ingreso()
        {
        }
        public int ID_Ingresos { get; set; }
        public int ID_DatosER { get; set; }
        public int ID_Clasificacion { get; set; }
        public string? NombreDeCuenta {  get; set; }
        public decimal Monto { get; set; }
        

    }
}
