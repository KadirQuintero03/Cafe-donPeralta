using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Factura_Ventas
    {
        public string CC_ADMIN { get; set; }
        public string Factor { get; set;}
        public decimal Kilos_Netos { get; set; }
        public decimal Valor_Kilos { get; set; }
        public decimal Valor_BaseKilos { get; set; }
    }
}
