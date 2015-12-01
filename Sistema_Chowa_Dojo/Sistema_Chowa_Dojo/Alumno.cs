using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
namespace Sistema_Chowa_Dojo
{
    class Alumno
    {
        String rut;
        String nombre;
        String apellido;
        String telefono;
        String email;
        String direccion;
        String categoria;
        int regular;
        String fecha_nac;
        String fecha_insc;

        public Alumno(String rut,
        //Constructor de alumno
                    String nombre,
                    String apellido,
                    String telefono,
                    String email,
                    String direccion,
                    int regular,
                    String fecha_nac,
                    String fecha_insc,
                    String categoria)
        {
            this.rut = rut;
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.email = email;
            this.direccion = direccion;
            this.regular = regular;
            this.fecha_nac = fecha_nac;
            this.fecha_insc = fecha_insc;
            this.categoria = categoria;
        }
        Modelo model = new Modelo();
        Controlador controlador = new Controlador();
        public void ingresarDatos()
        {
            
            model.ingresarDatosDB(rut, nombre, apellido, telefono, email, direccion,
                regular, fecha_nac, fecha_insc, categoria);
            controlador.actualizarDatos();

        }

        public void crearFicha()
        {
            Document document = new Document();
            PdfWriter.GetInstance(document,
                          new FileStream("devjoker.pdf",
                                 FileMode.OpenOrCreate));
            document.Open();
            document.Add(new Paragraph("Este es mi primer PDF "));
            document.Close();
        }

    }
}
