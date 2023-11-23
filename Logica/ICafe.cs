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
       

        public string Add(Reg_Cafés entity)
        {
            var estado = registrado.RegistradoCafe(entity);
            return estado;
        }

        public string Buscar(Reg_Cafés entity)
        {
            throw new NotImplementedException();
        }

        public List<Reg_Cafés> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
