using Entidades;
using System;
using System.Collections.Generic;
using Oracle.ManagedDataAccess.Client;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class RepositorioPedidos : Conexion
    {
        OracleCommand command;
        OracleConnection connection;
        Datos.Conexion conexion = new Datos.Conexion();
        public string RegistrarPedido(Pedidos pedido) //FACTURA PEDIDOS
        {
            try
            {
                AbrirDB();
                connection = miconexion();
                command = new OracleCommand("insertar_pedido", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                //lleva una secuencia 
                command.Parameters.Add("FP_id_pedido", OracleDbType.Varchar2).Value = pedido.Id_pedido;
                command.Parameters.Add("FP_fecha", OracleDbType.Date).Value = pedido.fecha;
                command.ExecuteNonQuery();
                conexion.CerrarBd();
                return "Pedido registrado";
            }
            catch (OracleException ex)
            {
                if (ex.Number == 1)
                {
                    return "ESTE NUMERO DE FACTURA YA EXISTE."; // Mensaje personalizado para la restricción única
                }

                if (ex.Number == 2291) // Número de error específico para violación de la llave foránea en Oracle
                {
                    return "NO SE ENCUENTRA EL JEFE CON ESTA CEDULA, POR FAVOR VERIFIQUE";
                }
                else
                {
                    return "ERROR DE " + ex.Message; // Mostrar el mensaje de la excepción de Oracle
                }
            }
        }
        public string RegistrarDetallePedido(Detalle_Pedidos pedido) //DETALLE PEDIDO
        {
            try
            {
                AbrirDB();
                connection = miconexion();
                command = new OracleCommand("insertar_detalleP", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("DP_id_pedido", OracleDbType.Varchar2).Value = pedido.Id_pedido;
                command.Parameters.Add("DP_id_producto", OracleDbType.Varchar2).Value = pedido.id_producto;
                command.Parameters.Add("DP_cedula_empleado", OracleDbType.Varchar2).Value = pedido.cedula_empleado;
                command.Parameters.Add("DP_cantidad", OracleDbType.Int32).Value = pedido.cantidad;
                command.ExecuteNonQuery();
                conexion.CerrarBd();
                return "El detalle del pedido fue registrado";

            }
            catch (Exception e)
            {

                return e.Message;
            }
        }
        public List<Pedidos> GetAll(string admin)
        {
            try
            {
                List <Pedidos> lista = new List<Pedidos>();
                AbrirDB();
                connection = miconexion();
                command = new OracleCommand("SELECT f.id_pedido, f.nombre_producto,f.nombre_empleado,f.apellido_empleado,f.total,f.fecha FROM factura_pedidos f JOIN DETALLE_PEDIDOS d ON(f.id_pedido = d.id_pedido)JOIN empleados e ON(e.cedula = d.cedula_empleado) WHERE e.cedula_admin =: admin", connection);
                command.Parameters.Add(":admin", admin);
                var raid = command.ExecuteReader();
                while (raid.Read())
                {
                    lista.Add(Mappear(raid));
                }
                CerrarBd();
                return lista;

            }
            catch (Exception)
            {

                throw;
            }
        }
        public Pedidos Mappear(OracleDataReader linea)
        {
            Pedidos pedido = new Pedidos();
            pedido.Id_pedido = linea.GetString(0);
            pedido.Nombre_producto = linea.GetString(1);
            pedido.Nombre_empleado = linea.GetString(2);
            pedido.apellido = linea.GetString(3);
            pedido.total = decimal.Parse(linea.GetString(4));
            pedido.fecha = DateTime.Parse(linea.GetString(5));
             return pedido;
        }
    }
}
