using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace Logica
{
    public class Reportes
    {
        public void RptListadoCafe(List<Reg_Cafés> ListCafe, string nombrePDF) //PDF REG CAFE
        {

            iTextSharp.text.Font font = new iTextSharp.text.Font(0);
            Document document = new Document();
            PdfWriter.GetInstance(document,
             new FileStream(nombrePDF + ".pdf",
             FileMode.OpenOrCreate));
            document.Open();
            //document.Add(new Paragraph("LISTADO DE PERSONAS " + "\n" + "\n"));
            Chunk chunk = new Chunk("                                                            REPORTE DE CAFE " + "\n" + "\n",
                FontFactory.GetFont("Times New Roman", 12,
                iTextSharp.text.Font.BOLD));

            var paraf = new Paragraph(chunk);
            //paraf.InsertRange
            //;
            document.Add(new Paragraph(chunk));

            PdfPTable tabla = new PdfPTable(4);
            tabla.WidthPercentage = 90;
            tabla.SetWidths(new int[] { 8, 8, 9, 12 });

            ///*P*/hrase pNombre = new Phrase(PersonaDTO.Nombre, font);
            tabla.AddCell(new Phrase("ID CAFE", font));
            tabla.AddCell(new Phrase("KILOS SECOS", font));
            tabla.AddCell(new Phrase("KILOS DE CEREZA", font));
            tabla.AddCell(new Phrase("Fecha", font));

            foreach (var item in ListCafe)
            {
                tabla.AddCell(new Phrase(item.id_cafe, font));
                tabla.AddCell(new Phrase(item.Secos_Kilos.ToString(), font));
                tabla.AddCell(new Phrase(item.Cereza_Kilos.ToString(), font));
                tabla.AddCell(new Phrase(item.Fecha.ToShortDateString(), font));
            }
            document.Add(tabla);
            document.Close();

        }

        public void RptListadoNomina(List<Entidades.Nomina> ListNomina, string nombrePDF) //PDF REG CAFE
        {

            iTextSharp.text.Font font = new iTextSharp.text.Font(0);
            Document document = new Document();
            PdfWriter.GetInstance(document,
             new FileStream(nombrePDF + ".pdf",
             FileMode.OpenOrCreate));
            document.Open();
            //document.Add(new Paragraph("LISTADO DE PERSONAS " + "\n" + "\n"));
            Chunk chunk = new Chunk("                                            " + nombrePDF + " " + "\n" + "\n",
                FontFactory.GetFont("Times New Roman", 15,
                iTextSharp.text.Font.BOLD));

            var paraf = new Paragraph(chunk);
            //paraf.InsertRange
            //;
            document.Add(new Paragraph(chunk));

            PdfPTable tabla = new PdfPTable(8);
            tabla.WidthPercentage = 90;
            tabla.SetWidths(new int[] { 10, 10, 12, 10, 13, 13,14, 15 });

            ///*P*/hrase pNombre = new Phrase(PersonaDTO.Nombre, font);
            tabla.AddCell(new Phrase("N°PAGO", font));
            tabla.AddCell(new Phrase("CEDULA", font));
            tabla.AddCell(new Phrase("NOMBRE", font));
            tabla.AddCell(new Phrase("KILOS TOTALES", font));
            tabla.AddCell(new Phrase("PEDIDOS TOTALES", font));
            tabla.AddCell(new Phrase("SALARIO BASE", font));
            tabla.AddCell(new Phrase("TOTAL", font));
            tabla.AddCell(new Phrase("FECHA", font));

            foreach (var item in ListNomina)
            {
                tabla.AddCell(new Phrase(item.id_nomina, font));
                tabla.AddCell(new Phrase(item.CC_Empleado, font));
                tabla.AddCell(new Phrase(item.Nombre, font));
                tabla.AddCell(new Phrase(item.Total_Kilos.ToString(), font));
                tabla.AddCell(new Phrase(item.Total_Pedidos.ToString(), font));
                tabla.AddCell(new Phrase(item.Salario_Base.ToString(), font));
                tabla.AddCell(new Phrase(item.Total_pagado.ToString(), font));
                tabla.AddCell(new Phrase(item.Fecha_nomina.ToShortDateString(), font));
            }
            document.Add(tabla);
            document.Close();

        }

        public void RptListadoEscogidos(List<Reg_Escogidos> ListRegEscogidos, string nombrePDF) //PDF REG CAFE
        {

            iTextSharp.text.Font font = new iTextSharp.text.Font(0);
            Document document = new Document();
            PdfWriter.GetInstance(document,
             new FileStream(nombrePDF + ".pdf",
             FileMode.OpenOrCreate));
            document.Open();
            //document.Add(new Paragraph("LISTADO DE PERSONAS " + "\n" + "\n"));
            Chunk chunk = new Chunk("                                            " + nombrePDF + " " + "\n" + "\n",
                FontFactory.GetFont("Times New Roman", 15,
                iTextSharp.text.Font.BOLD));

            var paraf = new Paragraph(chunk);
            //paraf.InsertRange
            //;
            document.Add(new Paragraph(chunk));

            PdfPTable tabla = new PdfPTable(4);
            tabla.WidthPercentage = 90;
            tabla.SetWidths(new int[] { 7, 12, 12, 10 });

            ///*P*/hrase pNombre = new Phrase(PersonaDTO.Nombre, font);
            tabla.AddCell(new Phrase("N°ESCOGIDO", font));
            tabla.AddCell(new Phrase("CEDULA EMPLEADO", font));
            tabla.AddCell(new Phrase("CANTIDAD", font));
            tabla.AddCell(new Phrase("FECHA DE REGISTRO", font));
          

            foreach (var item in ListRegEscogidos)
            {
                tabla.AddCell(new Phrase(item.id_escogido, font));
                tabla.AddCell(new Phrase(item.Cedula_Empleado, font));
                tabla.AddCell(new Phrase(item.cantidad.ToString(), font));
                tabla.AddCell(new Phrase(item.Fecha.ToShortDateString(), font));
               
            }
            document.Add(tabla);
            document.Close();

        }
    }
}
