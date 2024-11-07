﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForm.Models
{

        public class Pasivo_Capital
        {
        public Pasivo_Capital()
        {
        }

        public Pasivo_Capital(string nombreCuenta, decimal monto, decimal total, int clasificacion, int numeroDeBalance = 0)
            {
                NumeroDeBalance = numeroDeBalance;
                NombreCuenta = nombreCuenta;
                Monto = monto;
                Total = total;
                ID_Clasificacion = clasificacion;
            }
            public int ID { get; set; }
            public int NumeroDeBalance { get; set; }
            public int ID_Clasificacion { get; set; }
            public string NombreCuenta { get; set; }
            public decimal Monto { get; set; }
            public decimal Total { get; set; }

        }
    
}
