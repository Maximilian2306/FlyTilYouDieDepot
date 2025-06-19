using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
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
using System.Windows.Threading;

namespace FTYDD_WPF
{
    /// <summary>
    /// Interaktionslogik für MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();

            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += new EventHandler(UpdateTimer_Trick);
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Start();


        }


        private void UpdateTimer_Trick(object sender, EventArgs e)
        {
            ActualTime.Text = DateTime.Now.ToString();
        }

        private void HomePageLabel_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void combobox_1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem selectedItem = combobox_1.SelectedItem as ComboBoxItem;
            if (selectedItem != null)
            {
                string selectedOption = selectedItem.Content.ToString();
                if (selectedOption == "Boeing 737")
                {
                    // Navigieren zur Boeing_737 Seite
                    NavigationService.Navigate(new Boeing_737());
                }
                else if (selectedOption == "Übersicht")
                {
                    // Zurücknavigieren zur vorherigen Seite
                    NavigationService.Navigate(new AuswahlPage());
                }
                else if (selectedOption == "Gulfstream G700")
                {
                    NavigationService.Navigate(new Gulfstream_G700());
                }
                else if (selectedOption == "Lockheed Martin F-35")
                {
                    NavigationService.Navigate(new Lockheed_Martin_F_35());
                }
                // Weitere Bedingungen für andere Optionen
            }
        }

        private void ÜberUns_button_Click(object sender, RoutedEventArgs e)
        {
            ContactPage cp1 = new ContactPage();    

            NavigationService.Navigate(cp1);
        }

        private void Info_Click(object sender, RoutedEventArgs e)
        {
            Info info = new Info();

            info.Show();
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

        private void logIn_Click(object sender, RoutedEventArgs e)
        {
            LoginPage loginPage = new LoginPage();  

            NavigationService.Navigate(loginPage);
        }

        private void facebook_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void youtube_Click(object sender, RoutedEventArgs e)
        {

        }

        private void wiki_Click(object sender, RoutedEventArgs e)
        {

        }
    }

      
    }


