using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Liemers_College_App.Resources;
using System.Diagnostics;
using Microsoft.Phone.Tasks;

namespace Liemers_College_App
{
    public partial class MainPage : PhoneApplicationPage
    {

        string rooster;
        string cijfers;
        string teletop;
        string teletop2;

        // Constructor
        public MainPage()
        {
            InitializeComponent();

            rooster = "http://roosters4.gepro-osi.nl/roosters/rooster.php?klassen%5B%5D=z" + txt_rooster.Text + "&type=Klasrooster&wijzigingen=1&school=1493";
            cijfers = "https://leerlingen.liemerscollege.nl/Leren_bij___#objectWrapper2330=startdate%3D02-04-2014";
            teletop = "http://liemerscollege.teletop.nl/tt/liemers/home.nsf";
            teletop2 = "http://liemerscollege.teletop.nl/tt/liemers/";

            // Sample code to localize the ApplicationBar
            // BuildLocalizedApplicationBar();
        }

        private void btn_cijfers_Click(object sender, RoutedEventArgs e)
        {
            WebBrowserTask webBroswerTask = new WebBrowserTask();
            webBroswerTask.Uri = new Uri(cijfers);
            webBroswerTask.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            WebBrowserTask btnRooster = new WebBrowserTask();
            btnRooster.Uri = new Uri(rooster);
            btnRooster.Show();
        }

        private void btn_teletop_Click(object sender, RoutedEventArgs e)
        {
            if(chk_teletop.IsChecked.Equals(false)) 
            {
                WebBrowserTask btnTeletop = new WebBrowserTask();
                btnTeletop.Uri = new Uri(teletop);
                btnTeletop.Show();
            }
            else if (chk_teletop.IsChecked.Equals(true))
            {
                WebBrowserTask btnTeletopFixed = new WebBrowserTask();
                btnTeletopFixed.Uri = new Uri(teletop2);
                btnTeletopFixed.Show();
            }
        }

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}