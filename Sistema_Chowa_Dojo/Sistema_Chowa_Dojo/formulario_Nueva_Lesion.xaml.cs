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
using System.Windows.Shapes;

namespace Sistema_Chowa_Dojo
{
    /// <summary>
    /// Interaction logic for formulario_Nueva_Lesion.xaml
    /// </summary>
    public partial class formulario_Nueva_Lesion : Window
    {
        public formulario_Nueva_Lesion()
        {
            InitializeComponent();
        }
        Controlador controlador = new Controlador();
        private void crear_lesion_Click(object sender, RoutedEventArgs e)
        {
            //controlador.Crea_Nueva_Lesion();

        }

        private void cerrar_nueva_lesion_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
