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
        List<Biblioteca> Biblioteche = new List<Biblioteca>();
        Biblioteca Attuale;

        public MainWindow()
        {
            InitializeComponent();
            
        }

      

       

        private void InfoBiblioteca_Click(object sender, RoutedEventArgs e)
        {
            Attuale.ToString();
        }

        private void InfoLibro_Click(object sender, RoutedEventArgs e)
        {
            int tmp = lst_libri.SelectedIndex;
            
            MessageBox.Show(Attuale.ToString());
        }

        private void CreaLibro_Click(object sender, RoutedEventArgs e)
        {
            //Libri tmp = new Libri();  non c'è tempo per scrivere l'input
            //Attuale.AddLibro();
        }

        private void Creabiblioteca_Click(object sender, RoutedEventArgs e)
        {
            //Biblioteca New = new Biblioteca();
            //Biblioteche.Add(New);
        }

        private void lst_biblio_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Attuale = (Biblioteca)Biblioteche[lst_biblio.SelectedIndex];
            lst_libri.Items.Clear();
            lst_libri.ItemsSource = Attuale.ListaLibri;
        }
    }
}
