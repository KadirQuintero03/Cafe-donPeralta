using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class IEmpleados : Iservice<Empleado>
    {
        RepositorioEmpleados repositorioEmpleados = new RepositorioEmpleados();
        Conexion conexion = new Conexion();

        public string Add(Empleado entity)
        {
            var estado = repositorioEmpleados.RegistrarEmpleado(entity);
            return estado;
        }

        public string Buscar(Empleado entity)
        {
            throw new NotImplementedException();
        }

        public List<Empleado> GetAll()
        {
            return repositorioEmpleados.GetAll();
        }
    }
}
