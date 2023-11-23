using Entidades;
using Logica;
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
    public partial class Manejo_Empleados : Form
    {
        public Manejo_Empleados()
        {
            InitializeComponent();
        }

        IEmpleados ServicioEmpleados = new IEmpleados();

        private void btnRegistrarEmpleados_Click(object sender, EventArgs e)
        {
            RegistroEmpleados();
        }

        void RegistroEmpleados()
        {

            Logica.IEmpleados iempleados = new Logica.IEmpleados();
            var empleado = new Empleado();


            empleado.CC_ADMIN = txtE_cedula_A.Text;
            empleado.cedula = txtE_cedula.Text;
            empleado.nombre = txtE_nombre.Text;
            empleado.nombre2 = txtE_nombre2.Text;
            empleado.apellido = txtE_apellido.Text;
            empleado.apellido2 = txtE_apellido2.Text;
            var estado = iempleados.Add(empleado);
            MessageBox.Show(estado.ToString());
        }

        void VerDatosEmpleados()
        {
            List<Empleado> lista = ServicioEmpleados.GetAll();
            if ((lista == null) || (lista.Count == 0))
            {
                return;
            }
            else
            {
                dataGridEmpleado.Rows.Clear();
                foreach (var item in lista)
                {
                    DataGridViewRow fila = new DataGridViewRow();

                    DataGridViewCell CeldID = new DataGridViewTextBoxCell();
                    CeldID.Value = item.cedula;
                    fila.Cells.Add(CeldID);

                    DataGridViewCell CeldPN = new DataGridViewTextBoxCell();
                    CeldPN.Value = item.nombre;
                    fila.Cells.Add(CeldPN);

                    DataGridViewCell CeldSN = new DataGridViewTextBoxCell();
                    CeldSN.Value =  item.nombre2;
                    fila.Cells.Add(CeldSN);

                    DataGridViewCell CeldPA = new DataGridViewTextBoxCell();
                    CeldPA.Value = item.apellido;
                    fila.Cells.Add(CeldPA);

                    DataGridViewCell CeldSA = new DataGridViewTextBoxCell();
                    CeldSA.Value =  item.apellido2;
                    fila.Cells.Add(CeldSA);

                    DataGridViewCell CeldID_Admin = new DataGridViewTextBoxCell();
                    CeldID_Admin.Value = item.CC_ADMIN;
                    fila.Cells.Add(CeldID_Admin);

                    dataGridEmpleado.Rows.Add(fila);
                }
            }
        }

        void LimpiarCampoEmpleados()
        {
            txtE_cedula.Clear();
            txtE_nombre.Clear();
            txtE_nombre2.Clear();
            txtE_apellido.Clear();
            txtE_apellido2.Clear();
        }

        private void Manejo_Empleados_Load(object sender, EventArgs e)
        {
            VerDatosEmpleados();
        }
    }
}