using Entidades;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Factura_Venta : Form
    {
        public Log_in logInForm;
        public Factura_Venta()
        {
            InitializeComponent();
        }

        IVentas ServicioVentas = new IVentas(); //SERVICIO DE VENTAS

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        void MovimientoPanel()
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Factura_Venta_MouseDown(object sender, MouseEventArgs e)
        {
            MovimientoPanel();
        }

        private void btnRegistrarVentas_Click(object sender, EventArgs e)
        {

        }
        void RegistroDetalle()
        {
            if ((string.IsNullOrEmpty(txtFV_ref_facturaV.Text) || (string.IsNullOrEmpty(txtRV_cafe.Text) || (string.IsNullOrEmpty(txtRV_valorXKilo.Text)) || (string.IsNullOrEmpty(txtRV_valor_B.Text)) || (string.IsNullOrEmpty(txtRV_factor.Text) || (string.IsNullOrEmpty(txtRV_tipocafe.Text)) || (string.IsNullOrEmpty(txtRV_kiloneto.Text)))))) {
                MessageBox.Show("LLENE TODOS LOS CAMPOS");
            }
            else
            {
                var ventas = new Detalle_Factura_Venta();
                if (string.IsNullOrEmpty(txtE_cedula_A4.Text))
                {
                    ventas.CC_ADMIN = logInForm.Admint;
                }
                else
                {
                    ventas.CC_ADMIN = txtE_cedula_A4.Text;
                }
               
                ventas.Id_Venta = txtFV_ref_facturaV.Text;
                ventas.cafe = txtRV_cafe.Text;
                ventas.valor_kilo = decimal.Parse(txtRV_valorXKilo.Text);
                ventas.valor_base = decimal.Parse(txtRV_valor_B.Text);
                ventas.Factor = txtRV_factor.Text;
                ventas.tipo_cafe = txtRV_tipocafe.Text;
                ventas.kilos_netos = decimal.Parse(txtRV_kiloneto.Text);
                var estado = ServicioVentas.add(ventas);
                MessageBox.Show(estado.ToString());
                LimpiarCamposVentas();
                dataGridVenta.Rows.Clear();
                //VerDatosVentas();


            }
           


        }
        void RegistroVentas()
        {
            if (string.IsNullOrEmpty(txtFVfacturaV.Text) || (string.IsNullOrEmpty(txtRV_nombre_E.Text)))
            {
                MessageBox.Show("LLENE TODOS LOS CAMPOS");
            }
            else
            {
                var ventas = new Factura_Ventas();
                ventas.ID_venta = txtFVfacturaV.Text;
                ventas.Nombre_Empresa = txtRV_nombre_E.Text;
                ventas.fecha = DateTime.Parse(timepickerVenta.Text);
                var estado = ServicioVentas.Add(ventas);
                MessageBox.Show(estado.ToString());
                LimpiarCamposVentas();
               
            }
            
        }

        void VerDatosVentas()
        {
            List<Detalle_Factura_Venta> lista = ServicioVentas.GetAlls(txtE_cedula_A4.Text);
           
            if (lista != null)
            {
                foreach (var item in lista)
                {

                    dataGridVenta.Rows.Add(new object[]
                    {
                    item.Id_Venta,
                    item.Nombre,
                    item.cafe,
                    item.tipo_cafe,
                    item.Factor,
                    item.valor_base,
                    item.valor_kilo,
                    item.kilos_netos,
                    item.total_pagar,
                    item.fecha
                    });
                }
            }
           

        }

        void LimpiarCamposVentas()
        {
            txtFVfacturaV.Clear();
            txtRV_nombre_E.Clear();
            txtRV_kiloneto.Clear();
            txtRV_valorXKilo.Clear();
            txtRV_factor.Clear();
            txtFV_ref_facturaV.Clear();
            txtRV_cafe.Clear();
            txtRV_valor_B.Clear();
            txtRV_factor.Clear();
            txtRV_kiloneto.Clear();
            txtRV_tipocafe.Clear();
        }

        private void Factura_Venta_Load(object sender, EventArgs e)
        {
            txtE_cedula_A4.Text = logInForm.Admint;
            VerDatosVentas();
        }

        private void btncrearventa_Click(object sender, EventArgs e)
        {
            RegistroVentas();
        }

        private void btnRegistrarVentas_Click_1(object sender, EventArgs e)
        {
            RegistroDetalle();
            VerDatosVentas();
        }

        private void busquedaVenta_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(busquedaVenta.Text))
            {
                dataGridVenta.Rows.Clear();
                VerDatosVentas();

            }
            var busqueda = ServicioVentas.BuscarPorTodo(busquedaVenta.Text,txtE_cedula_A4.Text);
            dataGridVenta.Rows.Clear();
            foreach (var item in busqueda)
            {
                
                dataGridVenta.Rows.Add(new object[]
                {
                    item.Id_Venta,
                    item.Nombre,
                    item.cafe,
                    item.tipo_cafe,
                    item.Factor,
                    item.valor_base,
                    item.valor_kilo,
                    item.kilos_netos,
                    item.total_pagar,
                    item.fecha
                }
                );
            }
        }
    }
}