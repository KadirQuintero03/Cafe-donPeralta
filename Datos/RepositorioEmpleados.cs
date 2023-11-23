using Entidades;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;

namespace Datos
{
    public class RepositorioEmpleados : Conexion
    {
        OracleCommand command;
        OracleConnection connection;
        Datos.Conexion conexion = new Datos.Conexion();
        public string RegistrarEmpleado(Empleado empleado)
        {
            try
            {
                AbrirDB();
                connection= miconexion();
                command = new OracleCommand(" PK_proce_empleado.insertar_empleado", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("E_cedula_A", OracleDbType.Varchar2).Value = empleado.CC_ADMIN;
                command.Parameters.Add("E_cedula", OracleDbType.Varchar2).Value = empleado.cedula;
                command.Parameters.Add("E_nombre", OracleDbType.Varchar2).Value = empleado.nombre;
                command.Parameters.Add("E_nombre2", OracleDbType.Varchar2).Value = empleado.nombre2;
                command.Parameters.Add("E_apellido", OracleDbType.Varchar2).Value = empleado.apellido;
                command.Parameters.Add("E_apellido2", OracleDbType.Varchar2).Value = empleado.apellido2;
                command.ExecuteNonQuery();
                CerrarBd();
                return "usuario creado";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        public List<Empleado> GetAll()
        {
            try
            {
                List<Empleado> lista = new List<Empleado>();
                AbrirDB();
                connection = miconexion();
                command = new OracleCommand("SELECT * FROM EMPLEADOS", connection);
                var raid = command.ExecuteReader();
                while (raid.Read())
                {
                    lista.Add(Mappear(raid));
                }
                CerrarBd();
                return lista;
            }
            catch (Exception )
            {

                return null;
            }

        }
        public Empleado Mappear(OracleDataReader linea)
        {
            var empleado = new Empleado();
            empleado.cedula = linea.GetString(0);
            empleado.nombre = linea.GetString(1);
            empleado.nombre2 = linea.GetString(2);
            empleado.apellido = linea.GetString(3);
            empleado.apellido2 = linea.GetString(4);
            empleado.CC_ADMIN = linea.GetString(5);
            return empleado;
        }
    }
}
