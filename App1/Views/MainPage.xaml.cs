using App1.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ProjectWindows
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
        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            HttpClient client = new HttpClient();
            var json = await client.GetStringAsync(new Uri("http://localhost:59239/api/leerlings"));
            var lst = JsonConvert.DeserializeObject<ObservableCollection<Leerling>>(json);
            ObservableCollection<Leerling> test = lst;

        }

        private void Navigate_Newsfeed(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(NewsFeed), null);
        }

        private void Navigate_Opleidingen(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Opleidingen), null);
        }

        private void Navigate_Campus(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Campus), null);
        }

        private void Navigate_PotentiëleStudenten(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(View.PotentiëleStudenten), null);
        }

        private void Navigate_AdminLogin(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(AdminLogin), null);
        }
    }
}