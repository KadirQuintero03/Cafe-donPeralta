
using Entidades;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Sig_in : Form
    {
        Logica.Adminservices adminservices = new Logica.Adminservices();
        public Sig_in()
        {
            InitializeComponent();
           
        }
    

        void ingresar_admin()
        {
            if ((string.IsNullOrEmpty(txtA_cedula.Text) || (string.IsNullOrEmpty(txtA_nombre.Text) || (string.IsNullOrEmpty(txtA_apellido.Text) || (string.IsNullOrEmpty(txtA_contraseña.Text))))))
            {
                MessageBox.Show("LLENE LOS VALORES EN LOS CAMPOS CORRESPONDIENTES");
            }
            else
            {
                var Admin = new Admin();
                Admin.cedula = txtA_cedula.Text;
                Admin.nombre = txtA_nombre.Text;
                Admin.nombre2 = txtA_nombre2.Text;
                Admin.apellido = txtA_apellido.Text;
                Admin.apellido2 = txtA_apellido2.Text;
                Admin.contraseña = txtA_contraseña.Text;
                var estado = adminservices.Add(Admin);
                MessageBox.Show(estado.ToString());
            }
                
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ingresar_admin();
        }
    }
}
