using Entidades;
using System;
using Oracle.ManagedDataAccess.Client;

namespace Datos
{
    public class RepositorioVentas : Conexion
    {
        OracleCommand command;
        OracleConnection connection;
        Datos.Conexion conexion = new Datos.Conexion();
        public string RegistrarVenta(Factura_Ventas ventas)
        {
            try
            {
                AbrirDB();
                connection = miconexion();
                command = new OracleCommand("insertar_venta", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                //lleva una secuencia
                
                command.Parameters.Add("FV_cedula_admin", OracleDbType.Varchar2).Value = ventas.CC_ADMIN;
                command.Parameters.Add("FV_factor", OracleDbType.Decimal).Value = ventas.Factor;
                command.Parameters.Add("FV_kilos_neto", OracleDbType.Decimal).Value = ventas.Kilos_Netos;
                command.Parameters.Add("FV_valor_kilo", OracleDbType.Decimal).Value = ventas.Valor_Kilos;
                command.Parameters.Add("FV_valor_baseKilo", OracleDbType.Decimal).Value = ventas.Valor_BaseKilos;
                command.ExecuteNonQuery();
                conexion.CerrarBd();
                return "Venta Registrada";
            }
            catch (Exception e)
            {
                return e.Message;
                
            }
        }

    }
}
