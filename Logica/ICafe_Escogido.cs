using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Logica
{
    public class ICafe_Escogido : Iservice<Reg_Escogidos>
    {
       RegistrarEscogidos registrar = new RegistrarEscogidos();
        public string Add(Reg_Escogidos entity)
        {
            var estado = registrar.registrarES(entity);
            return estado;
        }

        public string Buscar(Reg_Escogidos entity)
        {
            throw new NotImplementedException();
        }

        public List<Reg_Escogidos> GetAll()
        {
            throw new NotImplementedException();
        }
        
    }
}

