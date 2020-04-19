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
    /// Lógica de interacción para ResultadoPandemia.xaml
    /// </summary>
    public partial class ResultadoPandemia : Page
    {
        public String nombre;
        public String patogeno;
        public String contagio;

        public ResultadoPandemia()
        {
            InitializeComponent();
        }

        public ResultadoPandemia(String nombre, String patogeno, String contagio)
        {
            InitializeComponent();
            this.nombre = nombre;
            this.patogeno = patogeno;
            this.contagio = contagio;
            lblNombre.Text = nombre;
            lblPatogeno.Text = "Tu " + patogeno.ToLower();
            String porcentaje = getPorcentajeMuertos(patogeno, contagio);
            lblPorcentaje.Text = porcentaje;
        }

        public String getPorcentajeMuertos(String patogeno, String contagio)
        {
            if (patogeno == "Virus" && contagio == "Aire") return "95.6%";
            else if (patogeno == "Virus" && contagio == "Contacto") return "60%";
            else if (patogeno == "Virus" && contagio == "Animales") return "40%";
            else if (patogeno == "Bacteria" && contagio == "Aire") return "5%";
            else if (patogeno == "Bacteria" && contagio == "Contacto") return "35%";
            else if (patogeno == "Bacteria" && contagio == "Animales") return "50%";
            else if (patogeno == "Hongo" && contagio == "Aire") return "1%";
            else if (patogeno == "Hongo" && contagio == "Contacto") return "10%";
            else return "15%";
        }
    }
}
