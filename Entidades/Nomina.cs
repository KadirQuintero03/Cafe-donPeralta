using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Nomina
    {

        public Nomina() { }
        public Nomina(string id_nomina, string cC_Empleado, string cC_ADMIN, string nombre, string apellido, decimal total_Kilos, decimal total_Pedidos, decimal salario_Base, decimal total_pagado, DateTime fecha_nomina)
        {
            this.id_nomina = id_nomina;
            CC_Empleado = cC_Empleado;
            CC_ADMIN = cC_ADMIN;
            Nombre = nombre;
            Apellido = apellido;
            Total_Kilos = total_Kilos;
            Total_Pedidos = total_Pedidos;
            Salario_Base = salario_Base;
            Total_pagado = total_pagado;
            Fecha_nomina = fecha_nomina;
        }

        public string id_nomina { get; set; }
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