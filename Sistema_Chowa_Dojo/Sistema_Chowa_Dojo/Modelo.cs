using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Chowa_Dojo
{
    class Modelo
    {
        public SQLiteConnection m_dbConnection;
        const string c = "\'";

        public void conectar_DB() {
            m_dbConnection = new SQLiteConnection("Data Source=db_chowa.db;Version=3;");
            m_dbConnection.Open();
        }
        public void ingresarDatosDB(String rut,
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
           
            conectar_DB();
            String query = "INSERT INTO alumno (rut,nombre,apellido,mail,direccion,telefono,categoria,regular,fecha_insc,fecha_nac)VALUES(" + c + rut + c + "," + c + nombre + c + ","+c+apellido+c+","+c+email+c+","+c+direccion+c+","+c+telefono+c+","+c+categoria+c+","+regular+","+c+ fecha_insc + c+","+c+fecha_nac+c+"); ";
            SQLiteCommand command = new SQLiteCommand(query, m_dbConnection);
            command.ExecuteNonQuery();
        }

        public void ingresarDatos_apoderadoBD(string nombre, string apellido, string telefono, string email, string rut)
        {
            conectar_DB();
            String query = "INSERT INTO apoderado (rut,nombre,apellido,telefono,mail)VALUES(" + c + rut + c + "," + c + nombre + c + "," + c + apellido + c + "," + c + telefono + c + ","+c+email+c+"); ";
            SQLiteCommand command = new SQLiteCommand(query, m_dbConnection);
            command.ExecuteNonQuery();

        }

        public void nueva_lesionDB(string rut, string nombre_Lesion, string fecha, string referencia)
        {
            conectar_DB();
            String query = "INSERT INTO lesion(nombre,fecha,referencia,rut) VALUES(" + c + nombre_Lesion + c + "," + c + fecha+ c + ","+ c + referencia + c +"," + c + rut + c + ");"; 
        }

       
    }
}
