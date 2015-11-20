﻿using System;
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

        private void boton_historial_med_Click(object sender, RoutedEventArgs e)
        {
            controlador.Ver_historial_medico();
        }
    }
}
