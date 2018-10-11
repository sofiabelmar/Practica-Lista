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

namespace PracticaLista
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<Alumnos> alumnos = new List<Alumnos>();

        public MainWindow()
        {
            InitializeComponent();
            alumnos.Add(new Alumnos("Ernesto Eng", "151697", "Ing. Energías Renovables"));
            alumnos.Add(new Alumnos("Santiago Fabela", "161697", "Ing. Quimica"));
            alumnos.Add(new Alumnos("Sergio Fabela", "171697", "Ing. Industrial"));
            alumnos.Add(new Alumnos("Jorge Eduardo Elías", "181697", "Ing. en Software"));

            foreach (Alumnos alumno in alumnos)
            {
                lstAlumnos.Items.Add(new ListBoxItem() {

                    Content = alumno.Nombre

                });
            }
        }

        private void lstAlumnos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            lblNombre.Text = alumnos[lstAlumnos.SelectedIndex].Nombre;
            lblMatricula.Text = alumnos[lstAlumnos.SelectedIndex].Matricula;
            lblCarrera.Text = alumnos[lstAlumnos.SelectedIndex].Carrera;
        }
    }
}
