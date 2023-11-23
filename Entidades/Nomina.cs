using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Nomina
    {
        
        public string CC_Empleado { get; set; }
        public string CC_ADMIN { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public decimal Total_Kilos { get; set; }
        public decimal Total_Pedidos { get; set; }
        public decimal Salario_Base { get; set; }
        public decimal Total_pagado { get; set; }
        public DateTime Fecha_nomina { get; set; }

       
    }
}