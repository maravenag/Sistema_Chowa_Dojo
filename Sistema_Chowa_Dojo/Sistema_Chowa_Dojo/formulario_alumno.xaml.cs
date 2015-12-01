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
           
        }

        Controlador controlador = new Controlador();

        public string grado = "";
        public string categoria = "";


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
                 fecha_insc,
                 categoria
                 );
            if(apoderado_nombre.Text.Length!=0 && apoderado_apellido.Text.Length!=0 && apoderado_email.Text.Length!=0 && apoderado_telefono.Text.Length !=0) {

                controlador.IngresaDatos_Apoderado(apoderado_nombre.Text, apoderado_apellido.Text, apoderado_email.Text, apoderado_telefono.Text ,alumno_rut.Text);
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem cbi = (ComboBoxItem)comboBox.SelectedItem;
            string selectedText = cbi.Content.ToString();
            grado = selectedText;
            label10.Content = grado;
        }

        private void comboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem cbi = (ComboBoxItem)comboBox1.SelectedItem;
            string selectedText = cbi.Content.ToString();
            categoria = selectedText;
            label10.Content = categoria;
        }
    }
}
