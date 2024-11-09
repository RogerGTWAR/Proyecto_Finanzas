using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForm.Models
    {
        public class DatosER
        {
            public DatosER() { }

            public int ID_DatosER { get; set; }
            public string NombreER { get; set; }

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
