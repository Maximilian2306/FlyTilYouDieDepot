using FlyTilYouDieDepot.Entities;
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

namespace FTYDD_WPF
{
    /// <summary>
    /// Interaktionslogik für Plane_Configuration.xaml
    /// </summary>
    public partial class Plane_Configuration : Page
    {
        public Plane_Configuration(Plane plane)
        {
            InitializeComponent();

            Plane plane1 = plane as Plane;
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Techn_Daten_Click(object sender, RoutedEventArgs e)
        {
            TechDatenBoeing_737 t1 = new TechDatenBoeing_737();

            t1.Show();
        }

        private void GoBack_button_Click(object sender, RoutedEventArgs e)
        {
            MainPage m1 = new MainPage();

            NavigationService.Navigate(m1);
        }

        private void ueber_uns_Click(object sender, RoutedEventArgs e)
        {
            ContactPage c1 = new ContactPage();

            NavigationService.Navigate(c1);
        }

        private void home_Click(object sender, RoutedEventArgs e)
        {
            MainPage m1 = new MainPage();

            NavigationService.Navigate(m1);
        }

        private void info_Click(object sender, RoutedEventArgs e)
        {
            Info info = new Info();

            info.Show();
        }

        private void uebersicht_Click(object sender, RoutedEventArgs e)
        {
            AuswahlPage auswahl = new AuswahlPage();

            NavigationService.Navigate(auswahl);
        }

        private void warenkorb_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
