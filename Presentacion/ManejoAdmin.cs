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
using Logica;
using Entidades;

namespace Presentacion
{
    public partial class Acceso_Admin : Form
    {
        public Log_in logInForm;
        public Acceso_Admin()
        {
            InitializeComponent();
            //RegistrosEscogidos();
        }
        
        Log_in login = new Log_in();

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        void MovimientoPanel()
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ManejoAdmin_MouseDown(object sender, MouseEventArgs e)
        {
            MovimientoPanel();
        }

        private void ManejoAdmin_Load(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txtE_cedula_A.Text = logInForm.Admint;
            //txtE_cedula_A2.Text = logInForm.Admint;
            //txtE_cedula_A3.Text = logInForm.Admint;
            //txtE_cedula_A4.Text = logInForm.Admint;
        }

        private void btn_regEmp_Click(object sender, EventArgs e)
        {
            var empleado = new Manejo_Empleados();
            empleado.logInForm = logInForm;
            empleado.Show();
        }

        private void btn_regPed_Click(object sender, EventArgs e)
        {
            var pedido = new Registro_Pedidos();
            pedido.logInForm = logInForm;
            pedido.Show();
        }

        private void btn_regCaf_Click(object sender, EventArgs e)
        {
            var cafe = new Registro_Cafe();
            cafe.logInForm = logInForm;
            cafe.Show();
        }

        private void btn_regEsc_Click(object sender, EventArgs e)
        {
            var escogido = new Registro_Escogidos();
            escogido.logInForm = logInForm;
            escogido.Show();
        }

        private void btn_regFac_Click(object sender, EventArgs e)
        {
            var venta = new Factura_Venta();
            venta.logInForm = logInForm;
            venta.Show();
        }

        private void btnNomina_Click(object sender, EventArgs e)
        {
            var nomina = new Nomina();
            nomina.logInForm = logInForm;
            nomina.Show();

        }
    }
}