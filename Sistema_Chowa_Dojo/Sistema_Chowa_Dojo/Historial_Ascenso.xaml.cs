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
    /// Interaction logic for Historial_Ascenso.xaml
    /// </summary>
    public partial class Historial_Ascenso : Window
    {
        public Historial_Ascenso()
        {
            InitializeComponent();
            grado.Items.Add("10° Kyu");
            grado.Items.Add("9° Kyu");
            grado.Items.Add("8° Kyu");
            grado.Items.Add("7° Kyu");
            grado.Items.Add("6° Kyu");
            grado.Items.Add("5° Kyu");
            grado.Items.Add("4° Kyu");
            grado.Items.Add("3° Kyu");
        }

        private void boton_aceptar_Click(object sender, RoutedEventArgs e)
        {
            String grad = grado.Text;
            String fech = fecha_asc.Text;
            Controlador controlador = new Controlador();
            controlador.Crea_nuevo_ascenso(grad, fech);
            lv_histo_ascenso.Items.Add(new { Fecha = fecha_asc.Text, Grado = grado.Text });
            boton_aceptar.IsEnabled = false;
        }

        private void boton_cancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
