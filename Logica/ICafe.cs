using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ICafe : Iservice<Reg_Cafés>
    {
        RegistrarCafe registrado = new RegistrarCafe();
        Conexion conexion = new Conexion();
       
        public string Actualizar(Reg_Cafés entity)
        {
            var estado = registrado.Actualizar(entity);
            return estado;
        }
        public string Add(Reg_Cafés entity)
        {
            var estado = registrado.RegistradoCafe(entity);
            return estado;
        }

        public string Buscar(Reg_Cafés entity)
        {
            throw new NotImplementedException();
        }

        public List<Reg_Cafés> GetAll(string admin)
        {
           return registrado.GetAll(admin);
        }
        public List<Reg_Cafés> BuscarPorTodo(string valor)
        {
            List<Reg_Cafés> lista = new List<Reg_Cafés>();
            return lista;

        }
    }
}
