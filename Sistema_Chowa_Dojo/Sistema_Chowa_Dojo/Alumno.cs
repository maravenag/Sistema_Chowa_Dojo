using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    String fecha_insc)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.email = email;
            this.direccion = direccion;
            this.regular = regular;
            this.fecha_nac = fecha_nac;
            this.fecha_insc = fecha_insc;
        }
    }
}
