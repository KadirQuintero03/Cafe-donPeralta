using Entidades;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Nomina : Form
    {
        INomina nominas = new INomina();
        public Log_in logInForm;
        Reportes reportes = new Reportes();
        IEmpleados ServicioEmpleados= new IEmpleados();
        public Nomina()
        {
            InitializeComponent();
        }
        void LimpiarDatos()
        {
            txtFNvalordia.Clear();
            txtFN_cedulaE.Clear();

        }
        void VerDatos()
        {

            List<Entidades.Nomina> nomina = nominas.GetAll(txt_FNcedulaA.Text);

            if (nomina != null)
            {
                foreach (var item in nomina)
                {
                    dataGridView1.Rows.Add(new object[]
                    {
                        item.id_nomina,
                        item.CC_Empleado,
                        item.Nombre,
                        item.Apellido,
                        item.Total_Kilos,
                        item.Total_Pedidos,
                        item.Salario_Base,
                        item.Total_pagado
                    });
                }
            }
             
        }
        void RegistrarDatos()
        {
            if ((string.IsNullOrEmpty(txtFNvalordia.Text)) || (string.IsNullOrEmpty(txtFN_cedulaE.Text)) || (string.IsNullOrEmpty(txt_FNcedulaA.Text)))
            {
                MessageBox.Show("LLENE TODOS LOS CAMPOS");
            }
            else
            {
                if (ServicioEmpleados.BuscarEmpleado(txtFN_cedulaE.Text) == "S")
                {
                    Entidades.Nomina nomina = new Entidades.Nomina();
                    nomina.CC_Empleado = txtFN_cedulaE.Text;
                    nomina.Salario_Base = decimal.Parse(txtFNvalordia.Text);
                    DateTime Fecha = dateTimePicker1.Value;
                    string fechaFormateada = Fecha.ToString("dd-MMM-yyyy");
                    nomina.Fecha_nomina = DateTime.Parse(fechaFormateada);
                    var estado = nominas.Add(nomina);
                    MessageBox.Show(estado.ToString());
                    LimpiarDatos();

                    if (estado.StartsWith("N"))
                    {
                        dataGridView1.Rows.Clear();
                    }
                    VerDatos();
                }
                else
                {
                    MessageBox.Show("EMPLEADO NO ENCONTRADO");
                }
            }
               
        }
        private void Nomina_Load(object sender, EventArgs e)
        {
            txt_FNcedulaA.Text = logInForm.Admint;
            VerDatos();
            
        }

        private void btn_FNregistrar_Click(object sender, EventArgs e)
        {
            RegistrarDatos();
        }

        private void btn_FNpdf_Click(object sender, EventArgs e)
        {
           InformePdfNomina();
        }

        private void InformePdfNomina()
        {
            if (string.IsNullOrEmpty(txtPdfN.Text))
            {
                MessageBox.Show("POR FAVOR DIGITE LA CEDULA DEL EMPLEADO");
                return;
               
            }
            else
            {
               if (nominas.GetAll(txt_FNcedulaA.Text)!=null)
                {

                    List<Entidades.Nomina> nominaEmpleado = new List<Entidades.Nomina>();
                    string nombre = string.Empty;
                    string apellido= string.Empty;

                    foreach (var item in nominas.GetAll(txt_FNcedulaA.Text))
                    {
                        if (item.CC_Empleado == txtPdfN.Text)
                        {
                            nominaEmpleado.Add(item);
                            nombre = item.Nombre;
                            apellido=item.Apellido;
                        }
                    }

                    if (nominaEmpleado.Count == 0)
                    {
                        MessageBox.Show("NO HAY NOMINA DE ESTE EMPLEADO,VERIFIQUE");
                    }
                    else
                    {
                        GenerarPdfPorEmpleado(nominaEmpleado, "NOMINA DE "+nombre.ToUpper()+" "+apellido.ToUpper());
                    }


                }
                else
                {
                    MessageBox.Show("NO HAY NOMINAS REGISTRADAS");
                }
               
            }
        }

        private void GenerarPdfPorEmpleado(List<Entidades.Nomina> ListPdf,string NombrePdf)
        {
            reportes.RptListadoNomina(ListPdf, NombrePdf);
            Process.Start(NombrePdf+".pdf");

        }
    }
}
