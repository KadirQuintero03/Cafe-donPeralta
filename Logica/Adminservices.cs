using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Adminservices :Iservice<Admin>
    {
        RepositorioAdmin admi =  new RepositorioAdmin();
        Conexion conexion = new Conexion();

        public string Add(Admin admin)
        {
            var estado = admi.RegistrarUser(admin);
            return estado;
        }



        public string Buscar(Admin entity)
        {
            throw new NotImplementedException();
        }

        public List<Admin> GetAll(string admin)
        {
            throw new NotImplementedException();
        }

        public string verificarUser(Admin admin)
        {
            try
            {
                var estado = admi.VerficiarAdmins(admin);
                return estado ;
            }
            catch (Exception e)
            {

                return e.Message;
            }
        }
    }
}
