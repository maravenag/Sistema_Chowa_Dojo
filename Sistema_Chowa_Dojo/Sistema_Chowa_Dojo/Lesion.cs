using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Chowa_Dojo
{
    class Lesion
    {
        String Nombre_Lesion;
        String Fecha;
        String Referencia;
        public Lesion(String Nombre_Lesion,
                   String Fecha,
                   String Referencia
                  )
        {
            this.Nombre_Lesion = Nombre_Lesion;
            this.Fecha = Fecha;
            this.Referencia = Referencia;
       
        }
        //aqui deberian crearse  
        //las funciones que conectan con la base de datos
    }
}
