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
    /// Interaktionslogik für HomePage.xaml
    /// </summary>
    public partial class HomePage : Page
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void Button0_Click(object sender, RoutedEventArgs e)
        {
            label1.Content = "Blöd gelaufen";
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            ComboBoxItem selectedItem = comboBox.SelectedItem as ComboBoxItem;


            if (selectedItem != null)
            {
                string selectedOption = selectedItem.Content.ToString();

                if (selectedOption == "Privatjets")
                {
                    // Öffnen Sie das neue Fenster für Option 2
                    NavigationService?.Navigate(new PrivateJets());
                }
                else if (selectedOption == "Mittel/Kleinflugzeuge")
                {
                    //Öffnen Sie die neue Seite für Option 3
                    NavigationService?.Navigate(new MiddlePlanes());
                }
                // Fügen Sie weitere Bedingungen für andere Optionen hinzu, falls benötigt
            }
        }
    }
}
