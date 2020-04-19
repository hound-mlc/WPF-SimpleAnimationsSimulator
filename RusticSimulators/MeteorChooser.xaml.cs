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

namespace RusticSimulators
{
    /// <summary>
    /// Lógica de interacción para MeteorChooser.xaml
    /// </summary>
    public partial class MeteorChooser : Page
    {
        public string material;
        public MeteorChooser()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (hielo.IsChecked == true)
            {
                material = "hielo";
            }
            else if (roca.IsChecked == true)
            {
                material = "roca";
            }
            else material = "metal";
            MeteorFall res = new MeteorFall(material);
            this.NavigationService.Navigate(res);
        }
    }
}
