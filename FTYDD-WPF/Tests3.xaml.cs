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
using System.Threading;
using System.Windows.Threading;

namespace FTYDD_WPF
{
    /// <summary>
    /// Interaktionslogik für Tests3.xaml
    /// </summary>
    public partial class Tests3 : Page
    {
        public Tests3()
        {
            InitializeComponent();

            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += new EventHandler(UpdateTimer_Trick);
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Start();

        }


        private void UpdateTimer_Trick (object sender, EventArgs e)
        {
            ActualTime.Text = DateTime.Now.ToString();
        }

    
        private void Add_button_Click(object sender, RoutedEventArgs e)
        {
         
            Acc_lbl.Content = $"Angemeldet als : {TextBox.Text}";

        }

        private void Info_button_Click(object sender, RoutedEventArgs e)
        {
            Info info = new Info();

            info.Show();
        }
    }
}
