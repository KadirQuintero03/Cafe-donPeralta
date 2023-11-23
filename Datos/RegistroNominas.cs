using System;
using Entidades;
using Oracle.ManagedDataAccess.Client;

namespace Datos
{
    public class RegistroNominas : Conexion
    {
        OracleCommand command;
        OracleConnection connection;
        Datos.Conexion conexion = new Datos.Conexion();
        public string RegistrarNominas(Nomina nomina)
        {
            /*
             * cedula empleado
             * salario base 
             * fecha
             * 
             */
            try
            {
                AbrirDB();
                connection = miconexion();
                command = new OracleCommand("insertar_nomina", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("N_cedula_empleado", OracleDbType.Varchar2).Value = nomina.CC_Empleado;
                command.Parameters.Add("N_salario_base", OracleDbType.Decimal).Value = nomina.Salario_Base;
                command.Parameters.Add("N_fecha", OracleDbType.Date).Value = nomina.Fecha_nomina;
                command.ExecuteNonQuery();
                conexion.CerrarBd();
                return "Nomina registrada";
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
