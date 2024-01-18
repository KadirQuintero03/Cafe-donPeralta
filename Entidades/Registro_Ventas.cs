using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Registro_Ventas
    {
        public string Id_ventas { get; set; }
        public float Kilos { get; set; }
        public float Valor_Kilo { get; set; }
        public string Factor { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }
      
    }
}
