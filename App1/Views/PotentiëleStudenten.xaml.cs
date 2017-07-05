using App1;
using App1.Models;
using App1.Viewmodels;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ProjectWindows.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PotentiëleStudenten : Page
    {
        Leerling leerling;
        string test;

        public PotentiëleStudenten()
        {
            this.DataContext = new PotentiëleStudentenViewModel();
            leerling = new Leerling();
            test = leerling.Voornaam;

        }
        private void Navigate_Mainpage(object sender, RoutedEventArgs e)
        {
            
            
            this.Frame.Navigate(typeof(MainPage), null);
        }
        private void AddLeerling(object sender, RoutedEventArgs e)
        {
            
            this.Frame.Navigate(typeof(MainPage), null);
        }
    }
}
