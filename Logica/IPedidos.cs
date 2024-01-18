using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class IPedidos : Iservice<Pedidos>
    {
        RepositorioPedidos pedidos = new RepositorioPedidos();
        Conexion conexion = new Conexion();

        public string Add(Pedidos entity)
        {
            var estado = pedidos.RegistrarPedido(entity);
            return estado;
        }
        public string add(Detalle_Pedidos entity)
        {
            var estado = pedidos.RegistrarDetallePedido(entity);
            return estado;
        }

        public string Buscar(Pedidos entity)
        {
            throw new NotImplementedException();
        }

        public List<Pedidos> GetAll(string admin)
        {
            return pedidos.GetAll(admin);
        }
        public List<Pedidos> BuscarPorTodo(string valor)
        {
            List<Pedidos> pedidos= new List<Pedidos>(); 
            return pedidos;

        }
    }
}
