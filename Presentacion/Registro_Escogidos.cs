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
    public partial class Registro_Escogidos : Form
    {
        public Registro_Escogidos()
        {
            InitializeComponent();
        }

        ICafe_Escogido ServicioCafeEscogido = new ICafe_Escogido(); //SERVICIO EL CUAL ACUMULA LO QUE SE TOMÓ POR CEDULA EN UNA FECHA

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        void MovimientoPanel()
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Registro_Escogidos_MouseDown(object sender, MouseEventArgs e)
        {
            MovimientoPanel();
        }

        private void btnRegisEsCo_Click(object sender, EventArgs e)
        {
            RegistrosEscogidos();
        }

        void RegistrosEscogidos()
        {

        }

        void VerDatosRegisEsc()
        {

        }

        void LimpiarRegisEscogidos()
        {
            TxtCC.Clear();
            TxtCantEsco.Clear();
        }

        private void Registro_Escogidos_Load(object sender, EventArgs e)
        {
            VerDatosRegisEsc();
        }
    }
}