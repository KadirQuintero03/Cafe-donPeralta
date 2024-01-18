using System;
using System.Collections.Generic;
using System.Data;
//using System.Data.OracleClient;
using Oracle.ManagedDataAccess.Client;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace Datos
{
    public class Conexion
    {
        OracleConnection connection;

        public string ruta = "DATA SOURCE= LOCALHOST:1521/XEPDB1 ; PASSWORD = 12345 ; USER ID = proyecto";
        public Conexion()
        {
            connection = new OracleConnection(ruta);
        }
        public void CerrarBd()
        {
            if (ConnectionState.Open == connection.State)
            {
                connection.Close();
            }
        }

        public void AbrirDB()
        {
            if (connection.State != ConnectionState.Open) { connection.Open(); }
        }
        public OracleConnection miconexion()
        {
            return connection;
        }
    }
}