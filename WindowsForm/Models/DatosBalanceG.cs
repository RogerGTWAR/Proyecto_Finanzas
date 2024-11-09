using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForm.Models
{
    public class DatosBalanceG
    {
        public DatosBalanceG() { }

        public int ID_DatosBalance { get; set; }  
        public string NombreBG { get; set; } 
        private DateTime _fechaInicio;
        public DateTime FechaInicio
        {
            get => _fechaInicio.Date;
            set => _fechaInicio = value.Date;
        }

        private DateTime _fechafin;
        public DateTime Fechafin
        {
            get => _fechafin.Date;
            set => _fechafin = value.Date;
        }
    }
}
