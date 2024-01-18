using System;
//using System.Data.OracleClient;
using Oracle.ManagedDataAccess.Client;
using Entidades;
using System.Collections.Generic;

namespace Datos
{
    public class RepositorioAdmin:Conexion
    {
        OracleCommand command;
        OracleConnection connection;
        Datos.Conexion conexion = new Datos.Conexion();
        public string RegistrarUser(Admin admin)
        {
            try
            {
                AbrirDB();
                connection= miconexion();
                command = new OracleCommand("insertar_administrador", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("A_cedula", OracleDbType.Varchar2).Value = admin.cedula;
                command.Parameters.Add("A_nombre", OracleDbType.Varchar2).Value = admin.nombre;
                command.Parameters.Add("A_nombre2", OracleDbType.Varchar2).Value = admin.nombre2;
                command.Parameters.Add("A_apellido", OracleDbType.Varchar2).Value = admin.apellido;
                command.Parameters.Add("A_apellido2", OracleDbType.Varchar2).Value = admin.apellido2;
                command.Parameters.Add("A_contraseña", OracleDbType.Varchar2).Value =admin.contraseña;
                command.ExecuteNonQuery();
                conexion.CerrarBd();
                return "usuario creado";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        public string VerficiarAdmins(Admin admin)
        {
            try
            {
                AbrirDB();
                connection = miconexion();
                command = new OracleCommand("SELECT * FROM ADMINS WHERE CEDULA =: usuario AND CONTRASEÑA =: contra", connection);
                command.Parameters.Add("usuario", admin.cedula);
                command.Parameters.Add("contra", admin.contraseña);
                OracleDataReader raided = command.ExecuteReader();
                if (raided.Read())
                {
                    conexion.CerrarBd();
                    return "200";
                }
                else
                {
                    return "404";
                }
            }
            catch (Exception e)
            {

                return e.Message;
            }
            
        }
        
    }
}