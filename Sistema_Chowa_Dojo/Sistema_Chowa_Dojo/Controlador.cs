using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Chowa_Dojo
{
    class Controlador
    {
        public Modelo model = new Modelo();
        public void crearEstudiante()
        //Funcion que despliega el formulario para el ingreso de los estudiantes
        {
            formulario_alumno formulario = new formulario_alumno();
            formulario.Show();
        }

        public void IngresaDatos(String nombre,
                                 String apellido,
                                 String rut,
                                 String telefono,
                                 String email,
                                 String direccion,
                                 String fecha_nac,
                                 String fecha_insc,
                                 String categoria)
        {
            //Se crea el objeto alumno y se le pasan los datos
            Alumno alumno = new Alumno(nombre, apellido, rut, telefono, email, direccion, 1, fecha_nac, fecha_insc, categoria);
            alumno.ingresarDatos();
            

            alumno.crearFicha();
            
        }

        public void Ver_historial_medico()
        //despliega historial medico
        {
            historial_medico historial = new historial_medico();
            historial.Show();

        }

        public void Crea_Nueva_Lesion(String nom_lesion, String fecha_lesion, String referencia)
        //se crea objeto lesion
        {
            Lesion lesion = new Lesion(nom_lesion, fecha_lesion, referencia);
           // lesion.guardar_lesion();
        }


        public void ingresar_ascenso()
        //se despliega historial de ascenso
        {
            Historial_Ascenso ascenso = new Historial_Ascenso();
            ascenso.Show();

        }

        public void IngresaDatos_Apoderado(string nom_apoderado, string apellido_apoderado, string apoderado_email , string telefono_apoderado,string rut)
        {
            Apoderado nuevo_apo = new Apoderado(nom_apoderado,apellido_apoderado,telefono_apoderado,apoderado_email,rut);
            nuevo_apo.ingresardatos_apoderado();
        }

        public void Crea_nuevo_ascenso(String nom_ascenso, String fecha)
        //se crea objeto ascenso
        {
            Ascenso lesion = new Ascenso(nom_ascenso, fecha);

        }
        public void EditarAlumno() {
            formulario_alumno formulario = new formulario_alumno();
            formulario.comboBox.IsEnabled = false;
            formulario.comboBox1.IsEnabled = false;
            formulario.Show();

        }
        public void actualizarDatos() { }
}
}
