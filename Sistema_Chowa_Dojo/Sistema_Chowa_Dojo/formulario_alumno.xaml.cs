using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Sistema_Chowa_Dojo
{
    /// <summary>
    /// Lógica de interacción para formulario_alumno.xaml
    /// </summary>
    public partial class formulario_alumno : Window
    {
        public formulario_alumno()
        {
            InitializeComponent();
            comboBox_grado.Items.Add("10° Kyu");
            comboBox_grado.Items.Add("9° Kyu");
            comboBox_grado.Items.Add("8° Kyu");
            comboBox_grado.Items.Add("7° Kyu");
            comboBox_grado.Items.Add("6° Kyu");
            comboBox_grado.Items.Add("5° Kyu");
            comboBox_grado.Items.Add("4° Kyu");
            comboBox_grado.Items.Add("3° Kyu");
            
        }

        Controlador controlador = new Controlador();
        public string grado = "";

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            grado = comboBox_grado.Text; // Acá está el grado guardado del combobox
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e) //Boton aceptar
        {
            DateTime actual = new DateTime();
            String fecha_insc = actual.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);

            controlador.IngresaDatos(
                 alumno_nombre.Text,
                 alumno_apellido.Text,
                 alumno_rut.Text,
                 alumno_telefono.Text,
                 alumno_email.Text,
                 alumno_direccion.Text,
                 fecha_nacimiento.Text,
                 fecha_insc
                 );
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
