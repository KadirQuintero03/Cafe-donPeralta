using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class IVentas : Iservice<Factura_Ventas>
    {
        RepositorioVentas ventas = new RepositorioVentas();
        Conexion conexion = new Conexion();
        public string Add(Factura_Ventas entity)
        {
            var respuesta = ventas.RegistrarVenta(entity);
            return respuesta;
        }
        public string add(Detalle_Factura_Venta entity)
        {
            var respuesta = ventas.RegistrarDetalleVenta(entity);
            return respuesta;
        }
        public string Buscar(Factura_Ventas entity)
        {
            throw new NotImplementedException();
        }

        public List<Detalle_Factura_Venta> GetAlls(string admin)
        {
            return ventas.GetAll(admin);
        }
        public List<Detalle_Factura_Venta> BuscarPorTodo(string valor,string admin)
        {
            return ventas.BuscarPorTodo(valor,admin);
        }

        List<Factura_Ventas> Iservice<Factura_Ventas>.GetAll(string admin)
        {
            throw new NotImplementedException();
        }


    }
}
