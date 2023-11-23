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
            RegistroVentas();
        }

        void RegistroVentas()
        {

        }

        void VerDatosVentas()
        {

        }

        void LimpiarCamposVentas()
        {

            txtRV_kiloneto.Clear();
            txtRV_valorXKilo.Clear();
            txtRV_factor.Clear();
        }

        private void Factura_Venta_Load(object sender, EventArgs e)
        {
            VerDatosVentas();
        }
    }
}