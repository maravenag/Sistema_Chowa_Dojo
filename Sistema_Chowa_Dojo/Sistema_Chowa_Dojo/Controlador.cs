using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Chowa_Dojo
{
    class Controlador
    {

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
                             String fecha_insc)
        {
            //Se crea el objeto alumno y se le pasan los datos
            Alumno alumno = new Alumno(nombre, apellido, rut, telefono, email, direccion, 1, fecha_nac, fecha_insc);
 
        }
        public void Ver_historial_medico()
            //despliega historial medico
        {
            historial_medico historial = new historial_medico();
            historial.Show();
            
        }

    }
}
