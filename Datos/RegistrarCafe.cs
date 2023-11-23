using Entidades;
using System;
using Oracle.ManagedDataAccess.Client;

namespace Datos
{
    public class RegistrarCafe:Conexion
    {
        //lleva una secuencia 
        OracleCommand command;
        OracleConnection connection;
        Datos.Conexion conexion = new Datos.Conexion();

        public string RegistradoCafe(Reg_Cafés registrado)
        {
            try
            {
                AbrirDB();
                connection = miconexion();
                command = new OracleCommand("insertar_regcafes", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("RC_cedula_admin", OracleDbType.Varchar2).Value = registrado.CC_ADMIN;
                command.Parameters.Add("RC_cereza_kilos", OracleDbType.Decimal).Value = registrado.Cereza_Kilos;
                command.Parameters.Add("RC_secos_kilos", OracleDbType.Decimal).Value = registrado.Secos_Kilos;
                command.ExecuteNonQuery();
                conexion.CerrarBd();
                return "Registro Guardado en la Base";

            }
            catch (Exception e)
            {

                return e.Message;
            }
        }
    }
}
