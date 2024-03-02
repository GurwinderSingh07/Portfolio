using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Final_version
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageDialog md = new MessageDialog("Hello");

            if (u_input.Text == "")
            {
                md.Content= "Please provide your username";
                md.ShowAsync();           
            }
            else if (p_input.Password == "")
            {
                md.Content = "Please provide the password";
                md.ShowAsync();
            }
            else if (male.IsChecked==false && female.IsChecked==false)
            {
                md.Content = "Please Select Your Gender ";
                md.ShowAsync();
            }
            else if(cd.IsChecked==false && nb.IsChecked==false && pp.IsChecked==false) 
            {
                md.Content = "Plase Select Payment Type";
                md.ShowAsync();
            }
            else if(check.IsChecked==false)
            {
                md.Content = "Please agree to terms and conditions";
                md.ShowAsync();
            }
            else
            {
                md.Content = "Congratulations!! you have successfully signed up ";
                md.ShowAsync();
            }



        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            u_input.Text = "";
            p_input.Password = "";
            male.IsChecked = false;
            female.IsChecked = false;
            cd.IsChecked = false;
            nb.IsChecked = false;   
            pp.IsChecked = false;
            check.IsChecked = false;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageDialog md = new MessageDialog("Bye");
            md.ShowAsync();
            Application.Current.Exit();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            p_input.Password = "";
        }

        private void show_password_Click(object sender, RoutedEventArgs e)
        {
            s_p_box.Text = p_input.Password;
        }

        private void u_input_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
