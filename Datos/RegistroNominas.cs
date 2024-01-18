using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            catch (OracleException ex)
            {
                if (ex.Number == 1)
                {
                    return "ESTA NOMINA YA EXISTE."; // Mensaje personalizado para la restricción única
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
        public List<Nomina> GetAll(string admin)
        {
            
            try
            {
                var lista = new List<Nomina>();
                AbrirDB();
                connection = miconexion();
                command = new OracleCommand("SELECT * FROM nominas WHERE CEDULA_ADMIN =:admin", connection);
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
        public Nomina Mappear(OracleDataReader linea)
        {
            var nomina = new Nomina();
            nomina.id_nomina = linea.GetString(0);
            nomina.CC_Empleado = linea.GetString(1);
            nomina.CC_ADMIN = linea.GetString(2);
            nomina.Nombre = linea.GetString(3);
            nomina.Apellido = linea.GetString(4);
            nomina.Total_Kilos = decimal.Parse(linea.GetString(5));
            nomina.Total_Pedidos = decimal.Parse(linea.GetString(6));
            nomina.Salario_Base = decimal.Parse(linea.GetString(7));
            nomina.Total_pagado = decimal.Parse(linea.GetString(8));
            nomina.Fecha_nomina = linea.GetDateTime(9);
            return nomina;
        }
    }
}
