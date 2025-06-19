using FlyTilYouDieDepot.Entities;
using FlyTilYouDieDepot.Logic;
using FlyTilYouDieDepot.Data;
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
    /// Interaktionslogik für LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        FTYDDContext context = new FTYDDContext();
        Customer_UseCase c2 = new Customer_UseCase();
        public LoginPage()
        {
            InitializeComponent();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            button_reg.IsEnabled = true;
            button_anm.IsEnabled = true;
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            button_reg.IsEnabled = false;
            button_anm.IsEnabled = false;
        }

        private void button_reg_Click(object sender, RoutedEventArgs e)
        {
            if (txtBox_email.Text != null && txtBox_passwort.Password != null)
            {
 
                if (c2.GetCustomer(txtBox_email.Text) == null)
                {
                    c2.CreateCustomers("", "", "", txtBox_email.Text, txtBox_passwort.Password);

                    MainPage m1 = new MainPage();

                    NavigationService.Navigate(m1); 
                  
                }
            }
            else if (txtBox_passwort.Password == null || txtBox_email.Text == null)
            {
                button_reg.IsEnabled = false;
                button_anm.IsEnabled = false;
            }
        }

        private void button_anm_Click(object sender, RoutedEventArgs e)
        {
            if (txtBox_email.Text != null && txtBox_passwort.Password != null)
            {
                //button_anm.IsEnabled = false;


                if (c2.GetCustomer(txtBox_email.Text).Email == txtBox_email.Text)
                {
                    MainPage m1 = new MainPage();
                    NavigationService.Navigate(m1);
                }
            }
            else if (txtBox_passwort == null || txtBox_email == null)
            {
                button_reg.IsEnabled = false;
                button_anm.IsEnabled = false;
            }
        }
    }
}
