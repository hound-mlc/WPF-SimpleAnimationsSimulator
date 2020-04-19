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
    /// Lógica de interacción para MeteorFall.xaml
    /// </summary>
    public partial class MeteorFall : Page
    {
        public MeteorFall()
        {
            InitializeComponent();
        }

        public MeteorFall(string material)
        {
            InitializeComponent();
            if (material == "hielo")
            {
                BitmapImage hielo = new BitmapImage();
                hielo.BeginInit();
                hielo.UriSource = new Uri("meteorIce.png", UriKind.Relative);
                hielo.EndInit();
                meteor.Source = hielo;
            }
            else if (material == "metal")
            {
                BitmapImage metal = new BitmapImage();
                metal.BeginInit();
                metal.UriSource = new Uri("meteorMetal.png",UriKind.Relative);
                metal.EndInit();
                meteor.Source = metal;
            }
        }
    }
}
