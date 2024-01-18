using Entidades;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;

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
            catch (OracleException ex)
            {
                if (ex.Number == 1)
                {
                    return "ESTA EMPLEADO YA EXISTE."; // Mensaje personalizado para la restricción única
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
        public List<Empleado> GetAll(string admin)
        {
            try
            {
                List<Empleado> lista = new List<Empleado>();
                AbrirDB();
                connection = miconexion();
                command = new OracleCommand("SELECT * FROM EMPLEADOS WHERE CEDULA_ADMIN =:admin", connection);
                command.Parameters.Add(":admin", admin);
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
            empleado.cedula = linea.GetString(1);
            empleado.nombre = linea.GetString(2);
            empleado.nombre2 = linea.IsDBNull(3) ? null : linea.GetString(3);
            empleado.apellido = linea.GetString(4);
            empleado.apellido2 = linea.IsDBNull(5) ? null : linea.GetString(5);
            empleado.CC_ADMIN = linea.GetString(0);
            empleado.FechaInicio = DateTime.Parse(linea.GetString(6));
            return empleado;
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
            catch (Exception)
            {

                return null;
            }
        }
        public List<Empleado> BuscarPorTodo(string algo)
        {
            var lista = new List<Empleado>();
            foreach (var item in GetAll())
            {
                if (item.cedula.StartsWith(algo) || item.nombre.StartsWith(algo) || item.apellido.StartsWith(algo))
                {
                    lista.Add(item);
                }

            }
            return lista;
        }
        public string Eliminar(Empleado empleado)
        {
            try
            {
                AbrirDB();
                connection = miconexion();
                command = new OracleCommand("eliminar_empleado", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("E_cedula", OracleDbType.Varchar2).Value = empleado.cedula;
                command.ExecuteNonQuery();
                CerrarBd();
                return "usuario Eliminado";
            }
            catch (Exception e)
            {

                return e.Message;
            }
        }
        public string Modificar(Empleado empleado)
        {
            try
            {
                AbrirDB();
                connection = miconexion();
                command = new OracleCommand("modificar_empleado", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("E_cedula", OracleDbType.Varchar2).Value = empleado.cedula;
                command.Parameters.Add("E_nombre", OracleDbType.Varchar2).Value = empleado.nombre;
                command.Parameters.Add("E_nombre2", OracleDbType.Varchar2).Value = empleado.nombre2;
                command.Parameters.Add("E_apellido", OracleDbType.Varchar2).Value = empleado.apellido;
                command.Parameters.Add("E_apellido2", OracleDbType.Varchar2).Value = empleado.apellido2;
                command.ExecuteNonQuery();
                CerrarBd();
                return "usuario actualizado";

            }
            catch (Exception e)
            {

                return e.Message;
            }
        }

        public string BuscarEmpleadoPorCedula(string cedula)
        {

            AbrirDB();
            connection= miconexion();
            command = new OracleCommand("BEGIN :EXISTE:=ExisteEmpleado(:Cedulap);END;",connection);
            command.Parameters.Add("EXISTE",OracleDbType.Varchar2,1).Direction= ParameterDirection.ReturnValue;
            command.Parameters.Add("Cedulap",OracleDbType.Varchar2).Value = cedula;

            command.ExecuteNonQuery();
            conexion.CerrarBd();

            string existe = command.Parameters["EXISTE"].Value.ToString();

            return existe;
        }
    }
}
