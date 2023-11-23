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
        public string RegistrarPedido(Pedidos pedido)
        {
            try
            {
                AbrirDB();
                connection = miconexion();
                command = new OracleCommand("insertar_pedido", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                //lleva una secuencia 
                command.Parameters.Add("P_cedula_empleado", OracleDbType.Varchar2).Value = pedido.CC_Empleado;
                command.Parameters.Add("P_nombre", OracleDbType.Varchar2).Value = pedido.Nombre_pedido;
                command.Parameters.Add("P_precio", OracleDbType.Decimal).Value = pedido.Precio;
                command.Parameters.Add("p_cantidad", OracleDbType.Int32).Value = pedido.Precio;
                command.Parameters.Add("p_total", OracleDbType.Decimal).Value = pedido.Total;
                command.ExecuteNonQuery();
                conexion.CerrarBd();
                return "Pedido registrado";
            }
            catch (Exception e)
            {

                return e.Message;
            }
        }
    }
}
