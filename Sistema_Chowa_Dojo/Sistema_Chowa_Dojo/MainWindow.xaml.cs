using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace Sistema_Chowa_Dojo
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();                
        }

        Controlador controlador = new Controlador();

        private void button_Click(object sender, RoutedEventArgs e)
        {
            controlador.crearEstudiante();
        }

        private void combo_categoria_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem cbi = (ComboBoxItem)combo_categoria.SelectedItem;
            string selectedText = cbi.Content.ToString();
            label_prueba.Content = selectedText;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void boton_ingresar_Ascenso_Click(object sender, RoutedEventArgs e)
        {
            controlador.ingresar_ascenso();
        }

        private void boton_historial_med_Click(object sender, RoutedEventArgs e)
        {
            controlador.Ver_historial_medico();
        }

        private void Editar_Datos_Alumno_Click(object sender, RoutedEventArgs e)
        {
            controlador.EditarAlumno();

        }
    }
}
