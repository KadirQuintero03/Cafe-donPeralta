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
        public string actualizar(Empleado entity)
        {
            var respuesta = repositorioEmpleados.Modificar(entity);
            return respuesta;
        }
        public string Eliminar(Empleado entity)
        {
            var respuesta = repositorioEmpleados.Eliminar(entity);
            return respuesta;
        }
        public string Add(Empleado entity)
        {
            var estado = repositorioEmpleados.RegistrarEmpleado(entity);
            return estado;
        }
        public List<Empleado> BuscarPorTodo(string valor) {
            
          return repositorioEmpleados.BuscarPorTodo(valor);
        }
        public string Buscar(Empleado entity)
        {
            throw new NotImplementedException();
        }

        public List<Empleado> GetAll(string admin)
        {
            return repositorioEmpleados.GetAll(admin);
        }

        public string BuscarEmpleado(string cedula)
        {
            return repositorioEmpleados.BuscarEmpleadoPorCedula(cedula);
        }
    }
}
