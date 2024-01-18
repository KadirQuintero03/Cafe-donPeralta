using Entidades;
using System;
using Oracle.ManagedDataAccess.Client;
using System.Collections.Generic;
using Microsoft.Win32;

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
                return "REGISTRO GUARDADO";
            }
            catch (OracleException ex)
            {
                if (ex.Number == 1)
                {
                    return "ESTE REGISTRO YA EXISTE."; // Mensaje personalizado para la restricción única
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
        public List<Reg_Escogidos> GetAll(string admin)
        {
            try
            {
                List<Reg_Escogidos> lista = new List<Reg_Escogidos>();
                AbrirDB();
                connection = miconexion();
                command = new OracleCommand("SELECT * FROM REGESCOGIDOS WHERE CEDULA_ADMIN =:admin", connection);
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
        public Reg_Escogidos Mappear(OracleDataReader linea)
        {
            var escogidos = new Reg_Escogidos();
            escogidos.id_escogido = linea.GetString(0);
            escogidos.CC_ADMIN = linea.GetString(1);
            escogidos.Cedula_Empleado = linea.GetString(2);
            escogidos.cantidad = decimal.Parse(linea.GetString(3));
            escogidos.Fecha = DateTime.Parse(linea.GetString(4));
            return escogidos;
        }
        public string Acturalizar(Reg_Escogidos reg)
        {
            AbrirDB();
            connection = miconexion();
            command = new OracleCommand("modificar_escogidos", connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add("RE_id_escogido", OracleDbType.Varchar2).Value = reg.id_escogido;
            command.Parameters.Add("RE_cedula_admin", OracleDbType.Varchar2).Value = reg.CC_ADMIN;
            command.Parameters.Add("RE_cedula_empleado", OracleDbType.Varchar2).Value = reg.Cedula_Empleado;
            command.Parameters.Add("RE_cantidad", OracleDbType.Decimal).Value = reg.cantidad;
            command.Parameters.Add("RE_fecha", OracleDbType.Date).Value = reg.Fecha;
            command.ExecuteNonQuery();
            conexion.CerrarBd();
            return "Se actualizo";
        }
    }
}
