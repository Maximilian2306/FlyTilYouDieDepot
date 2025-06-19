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
    /// Interaktionslogik für Tests.xaml
    /// </summary>
    public partial class Tests : Page
    {
        public Tests()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button1.Content = "Mistviech";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string message = "Hallo" + " " + txtBox_vorname.Text + " " + txtBox_nachname.Text;
            MessageBox.Show(message);
            lbl_message.Content = message;
        }
    }
}
