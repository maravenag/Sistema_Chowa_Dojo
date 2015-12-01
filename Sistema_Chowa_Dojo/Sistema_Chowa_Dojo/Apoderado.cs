using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Chowa_Dojo
{
    class Apoderado
    {
        String Nombre;
        String Apellido;
        String Telefono;
        String Email;
        String Rut;
        public Apoderado(String Nombre, String Apellido,String Telefono,String Email, String Rut) {
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Telefono = Telefono;
            this.Email = Email;
            this.Rut = Rut;

        }
        Modelo model = new Modelo();

        public void ingresardatos_apoderado()
        {
            model.ingresarDatos_apoderadoBD(Nombre,Apellido,Telefono,Email,Rut);
        }
    }
}
