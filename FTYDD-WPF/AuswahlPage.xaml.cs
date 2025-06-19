using FlyTilYouDieDepot.Logic;
using FlyTilYouDieDepot.Data;
using FlyTilYouDieDepot.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Runtime.ConstrainedExecution;
using static System.Net.Mime.MediaTypeNames;

namespace FTYDD_WPF
{
    /// <summary>
    /// Interaktionslogik für AuswahlPage.xaml
    /// </summary>
    public partial class AuswahlPage : Page
    {
        private Plane_UseCase plane_UseCase;
        private FTYDDContext context;

        public ObservableCollection<Plane> Planes { get; set; }
    
        
        public AuswahlPage()
        {
      
            InitializeComponent();

            context = new FTYDDContext();
            plane_UseCase = new Plane_UseCase(context);
            //  Planes = new ObservableCollection<Plane>(plane_UseCase.GetAllPlanes());

            Planes = new ObservableCollection<Plane>
            {
                new Plane
                {
                    Name = "Boeing 737",
                    Description = "Die Boeing 737 ist eines der am häufigsten genutzten Flugzeugmodelle weltweit.",
                    Height = 12,
                    Width = 35,
                    Lenght = 40,
                    Price = 83137500,
                    Colour = "White",
                    ImagePath = "/Images/Boeing_737.png",
                    DigitalData = "Boeing 737 digital data"
                },
                new Plane
                {
                    Name = "Gulfstream G700",
                    Description = "Die Gulfstream G700 ist ein ultralangstrecken Business Jet.",
                    Height = 8,
                    Width = 30,
                    Lenght = 33,
                    Price = 70137500,
                    Colour = "Gray",
                    ImagePath = "/Images/Gulfstream_G700.jpg",
                    DigitalData = "Gulfstream G700 digital data"
                },
                new Plane
                {
                    Name = "Lockheed Martin F-35",
                    Description = "Der Lockheed Martin F-35 Lightning II ist ein einstrahliges Mehrzweckkampfflugzeug.",
                    Height = 4,
                    Width = 11,
                    Lenght = 16,
                    Price = 74137500,
                    Colour = "Black",
                    ImagePath = "/Images/Lockheed_Martin_F-35_Lightning.jpg",
                    DigitalData = "Lockheed Martin F-35 digital data"
                },
                new Plane
                {
                    Name = "Airbus A320",
                    Description = "Der Airbus A320 ist ein zweistrahliges Kurz- und Mittelstreckenflugzeug.",
                    Height = 12,
                    Width = 34,
                    Lenght = 38,
                    Price = 98000000,
                    Colour = "Blue",
                    ImagePath = "/Images/PrivateJets_Hintergrund1.jpg",
                    DigitalData = "Airbus A320 digital data"
                },
                new Plane
                {
                    Name = "Cessna 172",
                    Description = "Die Cessna 172 ist ein einmotoriges Leichtflugzeug.",
                    Height = 3,
                    Width = 11,
                    Lenght = 8,
                    Price = 370000,
                    Colour = "Red",
                    ImagePath = "/Images/PrivateJets_Hintergrund.jpg",
                    DigitalData = "Cessna 172 digital data"
                }
            };

            DataContext = this;
            PlanesListView.ItemsSource = Planes;

            
        }


       
        

        private void Add_Button_Click(object sender, RoutedEventArgs e)
        {
            string name = NameTextBox.Text;

            string description_boeing = "Die Boeing 737 ist eines der am häufigsten genutzten Flugzeugmodelle weltweit, bekannt für ihre Effizienz, Zuverlässigkeit und Vielseitigkeit.Seit ihrer Einführung im Jahr 1967 hat sie sich als bevorzugte Wahl für Kurz-und Mittelstreckenflüge etabliert. Mit einer breiten Palette von Varianten, darunter die beliebte 737 MAX - Serie, bietet sie Platz für bis zu über 200 Passagiere und bietet ein komfortables Reiseerlebnis mit moderner Ausstattung und effizientem Design.";


            int height = int.Parse(HeightTextBox.Text);
            int width = int.Parse(WidthTextBox.Text);
            int length = int.Parse(LengthTextBox.Text);
            decimal price = decimal.Parse(PriceTextBox.Text);
            string colour = ColourTextBox.Text;

            string imagePath_boeing = "/Images/Boeing_737.png";

            string digitalData = DigitalDataTextBox.Text;

            Plane newPlane = plane_UseCase.CreatePlane(name, description_boeing, height, width, length, price, colour, imagePath_boeing, digitalData);

            Planes.Add(newPlane);
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

        private void PlanesListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

            Plane p = (Plane) PlanesListView.SelectedItem;

            NavigationService.Navigate(new Plane_Configuration(p));
        }
    }
}
