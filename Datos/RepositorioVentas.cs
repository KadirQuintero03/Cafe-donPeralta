using Entidades;
using System;
using Oracle.ManagedDataAccess.Client;
using System.Collections.Generic;

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
                
                command.Parameters.Add("FV_id_venta", OracleDbType.Varchar2).Value = ventas.ID_venta;
                command.Parameters.Add("FV_nombre_empresa", OracleDbType.Varchar2).Value = ventas.Nombre_Empresa;
                command.Parameters.Add("FV_fecha", OracleDbType.Date).Value = ventas.fecha;
                command.ExecuteNonQuery();
                conexion.CerrarBd();
                return "Venta Registrada";
            }
            catch (OracleException ex)
            {
                if (ex.Number == 1)
                {
                    return "ESTA VENTA YA EXISTE."; // Mensaje personalizado para la restricción única
                }
                else
                {
                    return "ERROR DE " + ex.Message; // Mostrar el mensaje de la excepción de Oracle
                }
            }

            catch (Exception)
            {
                return "ERROR DE GUARDADO";
            }
        }
        public string RegistrarDetalleVenta(Detalle_Factura_Venta venta)
        {
            try
            {
                AbrirDB();
                connection = miconexion();
                command = new OracleCommand("insertar_detalleV", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("DFV_cedula_admin", OracleDbType.Varchar2).Value = venta.CC_ADMIN;
                command.Parameters.Add("DFV_id_venta", OracleDbType.Varchar2).Value = venta.Id_Venta;
                command.Parameters.Add("DFV_id_cafe", OracleDbType.Varchar2).Value = venta.cafe;
                command.Parameters.Add("DFV_id_tipoC", OracleDbType.Varchar2).Value = venta.tipo_cafe;
                command.Parameters.Add("DFV_factor", OracleDbType.Varchar2).Value = venta.Factor;
                command.Parameters.Add("DFV_kilos_netos", OracleDbType.Decimal).Value = venta.kilos_netos;
                command.Parameters.Add("DFV_valor_Kilor", OracleDbType.Decimal).Value = venta.valor_kilo;
                command.Parameters.Add("DFV_valor_baseKilo", OracleDbType.Decimal).Value = venta.valor_base;
                command.ExecuteNonQuery();
                CerrarBd();
                return "Detalle de venta registrada";
            }
            catch (OracleException ex)
            {
                if (ex.Number == 1)
                {
                    return "ESTE DETALLE DE VENTA YA FUE REALIZADO."; // Mensaje personalizado para la restricción única
                }

                if (ex.Number == 2291) // Número de error específico para violación de la llave foránea en Oracle
                {
                    return "NO SE ENCUENTRA EL NUMERO DE FACTURA, POR FAVOR VERIFIQUE";
                }

                else
                {
                    return "ERROR DE " + ex.Message; // Mostrar el mensaje de la excepción de Oracle
                }
            }
        }

        public List<Detalle_Factura_Venta> GetAll(string admin)
        {
            try
            {
                List<Detalle_Factura_Venta> lista = new List<Detalle_Factura_Venta>();
                AbrirDB();
                connection = miconexion();
                command = new OracleCommand("SELECT d.CEDULA_ADMIN,f.id_venta,f.nombre_empresa,d.ID_CAFE,d.id_tipoc,d.factor,d.kilos_netos,d.valor_kilo,d.valor_basekilo,f.total,f.fecha FROM DETALLE_FACTURA_VENTAS d JOIN factura_ventas f ON(f.id_venta = d.id_venta) WHERE d.CEDULA_ADMIN =:admin", connection);
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

                return null;
            }
        }
        public Detalle_Factura_Venta Mappear(OracleDataReader linea)
        {
            var detalle = new Detalle_Factura_Venta();
            detalle.Id_Venta = linea.GetString(1);
            detalle.Nombre= linea.GetString(2);
            detalle.cafe = linea.GetString(3);
            detalle.tipo_cafe = linea.GetString(4);
            detalle.Factor = linea.GetString(5);
            detalle.kilos_netos = Decimal.Parse(linea.GetString(6));
            detalle.valor_kilo = Decimal.Parse(linea.GetString(7));
            detalle.valor_base = Decimal.Parse(linea.GetString(8));
            detalle.total_pagar = Decimal.Parse(linea.GetString(9));
            detalle.fecha = DateTime.Parse(linea.GetString(10));
            return detalle;
        }

        public List<Detalle_Factura_Venta> GetAll()
        {
            try
            {
                List<Detalle_Factura_Venta> lista = new List<Detalle_Factura_Venta>();
                AbrirDB();
                connection = miconexion();
                command = new OracleCommand("SELECT d.CEDULA_ADMIN,f.id_venta,f.nombre_empresa,d.ID_CAFE,d.id_tipoc,d.factor,d.kilos_netos,d.valor_kilo,d.valor_basekilo,f.total,f.fecha FROM DETALLE_FACTURA_VENTAS d JOIN factura_ventas f ON(f.id_venta = d.id_venta) WHERE d.CEDULA_ADMIN =:admin", connection);
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
        public List<Detalle_Factura_Venta> BuscarPorTodo(string algo,string admin)
        {
            List<Detalle_Factura_Venta> f = new List<Detalle_Factura_Venta> ();
            foreach (var item in GetAll(admin))
            {
                if (item.Id_Venta.StartsWith(algo)|| item.cafe.StartsWith(algo)|| item.tipo_cafe.StartsWith(algo))
                {
                    f.Add(item);
                }
            }
            return f;
        }

    }
}
