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

namespace BibliotecaLibri
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //List<Biblioteca> Biblioteche;
        //Biblioteca = Attuale;

        public MainWindow()
        {
            InitializeComponent();
            //Biblioteche = new List<Biblioteca>();
            //Attuale = new Biblioteca();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ListBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void InfoBiblioteca_Click(object sender, RoutedEventArgs e)
        {

        }

        private void InfoLibro_Click(object sender, RoutedEventArgs e)
        {
            int tmp = lst_libri.SelectedIndex;
            
            MessageBox.Show(Attuale.);
        }

        private void CreaLibro_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Creabiblioteca_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
