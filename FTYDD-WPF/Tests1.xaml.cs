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
    /// Interaktionslogik für Tests1.xaml
    /// </summary>
    public partial class Tests1 : Page
    {
        public Tests1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (bronze_abo.IsChecked == true)
            {
                lbl_abo.Content = "Du hast das Bronze-Abo gewählt!";
            }
            else if (silber_abo.IsChecked == true)
            {
                lbl_abo.Content = "Du hast das Silber-Abo gewählt!";
            }
            else if (gold_abo.IsChecked == true)
            {
                lbl_abo.Content = "Du hast das Gold-Abo gewählt!";
            }

            if (mann_rb.IsChecked == true)
            {
                lbl_geschlecht.Content = "Du bist a mo!!!";
            }
            else if (frau_rb.IsChecked == true)
            {
                lbl_geschlecht.Content = "Du bist a madl!!!";
            }
            else
            {
                lbl_geschlecht.Content = "Du bist dir nicht sicher was du eig bist!!!";
            }
        }
    }
}
