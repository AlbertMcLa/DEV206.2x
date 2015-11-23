using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace RestaurantManager.UniversalWindows
{
    public sealed partial class OrderPage : Page
    {
        public OrderPage() {
            this.InitializeComponent();
        } // end OrderPage()

        private void MainPage_Click(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(MainPage));
        } // end MainPage_Click



    } // end class
} // end namespace
