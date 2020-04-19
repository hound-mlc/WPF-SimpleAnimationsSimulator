using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace RusticSimulators
{
    /// <summary>
    /// Lógica de interacción para Pandemic1.xaml
    /// </summary>
    public partial class Pandemic1 : Page
    {
        public string patogeno;
        public string contagio;

        public Pandemic1()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void virus_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void virus_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            patogeno = "Virus";
            lbl1.Text = "Virus";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (animales.IsChecked == true) contagio = "Animales";
            else if (aire.IsChecked == true) contagio = "Aire";
            else contagio = "Contacto";
            ResultadoPandemia res = new ResultadoPandemia(textNombre.Text, patogeno, contagio);
            this.NavigationService.Navigate(res);
        }

        private void bacteria_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            patogeno = "Bacteria";
            lbl1.Text = "Bacteria";
        }

        private void hongo_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            patogeno = "Hongo";
            lbl1.Text = "Hongo";
        }
    }
}
