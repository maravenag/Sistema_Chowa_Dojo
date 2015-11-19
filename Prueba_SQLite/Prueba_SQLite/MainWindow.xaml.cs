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
using System.Data.SQLite;

namespace Prueba_SQLite
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
       

        public SQLiteConnection m_dbConnection;
        const string comilla = "\'";
        

        private void button_Click(object sender, RoutedEventArgs e)
        {
            String nombre = nombre_box.Text;
            String edad = edad_box.Text;

            m_dbConnection = new SQLiteConnection("Data Source=base_de_prueba.sqlite;Version=3;");
            m_dbConnection.Open();

            String query = "INSERT INTO alumnos (NOMBRE,EDAD) VALUES (" + comilla + nombre + comilla + "," + edad + ");";
            textBlock.Text = query;

            

           SQLiteCommand command = new SQLiteCommand(query, m_dbConnection);
           command.ExecuteNonQuery();
            }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
           SQLiteConnection.CreateFile("base_de_prueba.sqlite");
           m_dbConnection = new SQLiteConnection("Data Source=base_de_prueba.sqlite;Version=3;");
           m_dbConnection.Open();
           string query_crear = "CREATE TABLE alumnos (NOMBRE TEXT PRIMARY KEY, EDAD INT)";
           SQLiteCommand command = new SQLiteCommand(query_crear, m_dbConnection);
           command.ExecuteNonQuery();
        }
    }
}
