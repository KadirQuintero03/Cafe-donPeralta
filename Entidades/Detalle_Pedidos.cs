using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Detalle_Pedidos
    {
        public string Id_pedido { get; set; }
        public string id_producto { get; set;}
        public string cedula_empleado { get; set; }
        public int cantidad { get; set; }

    }
}
