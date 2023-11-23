using Entidades;
using System;
using Oracle.ManagedDataAccess.Client;

namespace Datos
{
    public class RegistrarEscogidos:Conexion
    {
        OracleCommand command;
        OracleConnection connection;
        Datos.Conexion conexion = new Datos.Conexion();
        public string registrarES(Reg_Escogidos registro)
        {
            try
            {
                AbrirDB();
                connection = miconexion();
                command = new OracleCommand("insertar_escogidos", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("RE_cedula_admin", OracleDbType.Varchar2).Value = registro.CC_ADMIN;
                command.Parameters.Add("RE_cedula_empleado", OracleDbType.Varchar2).Value = registro.Cedula_Empleado;
                command.Parameters.Add("RE_cantidad", OracleDbType.Decimal).Value = registro.cantidad;
                command.Parameters.Add("RE_fecha", OracleDbType.Date).Value = registro.Fecha;
                command.ExecuteNonQuery();
                conexion.CerrarBd();
                return "La cantidad ha sido guardado";
            }
            catch (Exception e)
            {

                return e.Message;
            }
        }
    }
}
