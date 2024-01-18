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
    public partial class Log_in : Form
    {
        public string Admint { get; set; }
        Adminservices admin = new Adminservices();  
        public Log_in()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        void MovimientoPanel()
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            MovimientoPanel();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Usuario_Enter(object sender, EventArgs e)
        {
            if (Usuario.Text == "Cedula") {
                Usuario.Text = "";
            }
        }

        private void Usuario_Leave(object sender, EventArgs e)
        {
            if (Usuario.Text == "")
            {
                Usuario.Text = "Cedula";
            }
        }

        private void Contraseña_Enter(object sender, EventArgs e)
        {
            if (Contraseña.Text == "Contraseña")
            {
                Contraseña.Text = "";
                Contraseña.UseSystemPasswordChar = true;
            }
        }

        private void Contraseña_Leave(object sender, EventArgs e)
        {
            if (Contraseña.Text == "")
            {
                Contraseña.Text = "Contraseña";
                Contraseña.UseSystemPasswordChar = false;
            }
        }
        
        void acceder()
        {
            var admins = new Admin();
            admins.cedula = Usuario.Text;
            Admint = admins.cedula;
            admins.contraseña = Contraseña.Text;


            var  respuestas =  admin.verificarUser(admins);
            if (respuestas == "200")
            {
               
                Acceso_Admin manejoAdminForm = new Acceso_Admin();
                manejoAdminForm.logInForm = this;
                manejoAdminForm.Show();
            }
            else { MessageBox.Show("Contraseña o usuario incorrecto"); }
        }
        private void Access_Click(object sender, EventArgs e)
        {
            acceder();
        }

        private void Access_KeyPress(object sender, KeyPressEventArgs e)
        {
            acceder();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var sig = new Sig_in();
            sig.ShowDialog();
        }
    }
}