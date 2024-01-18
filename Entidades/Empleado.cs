using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado:Persona
    {
        public string CC_ADMIN { get; set; }
        public DateTime FechaInicio { get; set; }
       
        //public DateTime FechaFinal { get; set; }
    }
}