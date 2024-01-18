using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Detalle_Factura_Venta
    {
        public string CC_ADMIN { get; set; }
        public string Id_Venta { get; set; }
        public string Nombre { get; set; }
        public string cafe{ get; set; }
        public string tipo_cafe { get; set; }
        public string Factor { get; set; }
        public decimal valor_base { get; set; }
        public decimal valor_kilo { get; set; }
        public decimal kilos_netos { get; set; }
        public decimal total_pagar { get; set; }
        public DateTime fecha { get; set; }
    }
}
