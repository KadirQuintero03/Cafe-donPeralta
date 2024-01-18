using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Registrado_Escogido
    {
        public string CC_Empleado  { get; set; }
        public string Cant_Escogida { get; set; }
        public DateTime Fecha { get; set; }

        public override string ToString()
        {
            return string.Format(CC_Empleado + ";"+Cant_Escogida + ";"+Fecha);
        }
    }
}
